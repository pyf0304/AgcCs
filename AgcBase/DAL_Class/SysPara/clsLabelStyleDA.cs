
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLabelStyleDA
 表名:LabelStyle(00050066)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 标签样式(LabelStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsLabelStyleDA : clsCommBase4DA
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
 return clsLabelStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsLabelStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsLabelStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsLabelStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsLabelStyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strLabelStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strLabelStyleId)
{
strLabelStyleId = strLabelStyleId.Replace("'", "''");
if (strLabelStyleId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:LabelStyle中,检查关键字,长度不正确!(clsLabelStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strLabelStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:LabelStyle中,关键字不能为空 或 null!(clsLabelStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strLabelStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsLabelStyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsLabelStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = "Select * from LabelStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_LabelStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsLabelStyleDA: GetDataTable_LabelStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = "Select * from LabelStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsLabelStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsLabelStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = "Select * from LabelStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsLabelStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsLabelStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LabelStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LabelStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsLabelStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from LabelStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsLabelStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} LabelStyle.* " + 
$"from LabelStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and LabelStyle.LabelStyleId not in " + 
$"(Select top {intTop_In} LabelStyle.LabelStyleId from LabelStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LabelStyle where {1} and LabelStyleId not in (Select top {2} LabelStyleId from LabelStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LabelStyle where {1} and LabelStyleId not in (Select top {3} LabelStyleId from LabelStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsLabelStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} LabelStyle.* " + 
$"from LabelStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and LabelStyle.LabelStyleId not in " + 
$"(Select top {intTop_In} LabelStyle.LabelStyleId from LabelStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LabelStyle where {1} and LabelStyleId not in (Select top {2} LabelStyleId from LabelStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LabelStyle where {1} and LabelStyleId not in (Select top {3} LabelStyleId from LabelStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsLabelStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsLabelStyleDA:GetObjLst)", objException.Message));
}
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = "Select * from LabelStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLabelStyleDA: GetObjLst)", objException.Message));
}
objLabelStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLabelStyleEN);
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
public List<clsLabelStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsLabelStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLabelStyleDA: GetObjLst)", objException.Message));
}
objLabelStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLabelStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetLabelStyle(ref clsLabelStyleEN objLabelStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = "Select * from LabelStyle where LabelStyleId = " + "'"+ objLabelStyleEN.LabelStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objLabelStyleEN.LabelStyleId = objDT.Rows[0][conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objLabelStyleEN.LabelStyleName = objDT.Rows[0][conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objLabelStyleEN.Style = objDT.Rows[0][conLabelStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objLabelStyleEN.Runat = objDT.Rows[0][conLabelStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objLabelStyleEN.FontSize = objDT.Rows[0][conLabelStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objLabelStyleEN.FontName = objDT.Rows[0][conLabelStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objLabelStyleEN.Width = TransNullToInt(objDT.Rows[0][conLabelStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objLabelStyleEN.Height = TransNullToInt(objDT.Rows[0][conLabelStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objLabelStyleEN.StyleZindex = TransNullToInt(objDT.Rows[0][conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objLabelStyleEN.StyleLeft = TransNullToInt(objDT.Rows[0][conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objLabelStyleEN.StylePosition = objDT.Rows[0][conLabelStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objLabelStyleEN.StyleTop = TransNullToInt(objDT.Rows[0][conLabelStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsLabelStyleDA: GetLabelStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strLabelStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clsLabelStyleEN GetObjByLabelStyleId(string strLabelStyleId)
{
CheckPrimaryKey(strLabelStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = "Select * from LabelStyle where LabelStyleId = " + "'"+ strLabelStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
 objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsLabelStyleDA: GetObjByLabelStyleId)", objException.Message));
}
return objLabelStyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsLabelStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsLabelStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = "Select * from LabelStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN()
{
LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(), //LabelStyleId
LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(), //LabelStyleName
Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(), //类型
Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(), //运行在
FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(), //字号
FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(), //字体
Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.Width].ToString().Trim()), //宽
Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.Height].ToString().Trim()), //高度
StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleZindex].ToString().Trim()), //Style_Zindex
StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleLeft].ToString().Trim()), //Style_Left
StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(), //Style_Position
StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleTop].ToString().Trim()) //Style_Top
};
objLabelStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLabelStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsLabelStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsLabelStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsLabelStyleDA: GetObjByDataRowLabelStyle)", objException.Message));
}
objLabelStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLabelStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsLabelStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsLabelStyleDA: GetObjByDataRow)", objException.Message));
}
objLabelStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLabelStyleEN;
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
objSQL = clsLabelStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLabelStyleEN._CurrTabName, conLabelStyle.LabelStyleId, 4, "");
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
objSQL = clsLabelStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLabelStyleEN._CurrTabName, conLabelStyle.LabelStyleId, 4, strPrefix);
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
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select LabelStyleId from LabelStyle where " + strCondition;
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
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select LabelStyleId from LabelStyle where " + strCondition;
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
 /// <param name = "strLabelStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strLabelStyleId)
{
CheckPrimaryKey(strLabelStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("LabelStyle", "LabelStyleId = " + "'"+ strLabelStyleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsLabelStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("LabelStyle", strCondition))
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
objSQL = clsLabelStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("LabelStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsLabelStyleEN objLabelStyleEN)
 {
 if (objLabelStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLabelStyleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = "Select * from LabelStyle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "LabelStyle");
objRow = objDS.Tables["LabelStyle"].NewRow();
objRow[conLabelStyle.LabelStyleId] = objLabelStyleEN.LabelStyleId; //LabelStyleId
objRow[conLabelStyle.LabelStyleName] = objLabelStyleEN.LabelStyleName; //LabelStyleName
 if (objLabelStyleEN.Style !=  "")
 {
objRow[conLabelStyle.Style] = objLabelStyleEN.Style; //类型
 }
 if (objLabelStyleEN.Runat !=  "")
 {
objRow[conLabelStyle.Runat] = objLabelStyleEN.Runat; //运行在
 }
 if (objLabelStyleEN.FontSize !=  "")
 {
objRow[conLabelStyle.FontSize] = objLabelStyleEN.FontSize; //字号
 }
 if (objLabelStyleEN.FontName !=  "")
 {
objRow[conLabelStyle.FontName] = objLabelStyleEN.FontName; //字体
 }
objRow[conLabelStyle.Width] = objLabelStyleEN.Width; //宽
objRow[conLabelStyle.Height] = objLabelStyleEN.Height; //高度
objRow[conLabelStyle.StyleZindex] = objLabelStyleEN.StyleZindex; //Style_Zindex
objRow[conLabelStyle.StyleLeft] = objLabelStyleEN.StyleLeft; //Style_Left
 if (objLabelStyleEN.StylePosition !=  "")
 {
objRow[conLabelStyle.StylePosition] = objLabelStyleEN.StylePosition; //Style_Position
 }
objRow[conLabelStyle.StyleTop] = objLabelStyleEN.StyleTop; //Style_Top
objDS.Tables[clsLabelStyleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsLabelStyleEN._CurrTabName);
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
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLabelStyleEN objLabelStyleEN)
{
 if (objLabelStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLabelStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objLabelStyleEN.LabelStyleId !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.LabelStyleId);
 var strLabelStyleId = objLabelStyleEN.LabelStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelStyleId + "'");
 }
 
 if (objLabelStyleEN.LabelStyleName !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.LabelStyleName);
 var strLabelStyleName = objLabelStyleEN.LabelStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelStyleName + "'");
 }
 
 if (objLabelStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Style);
 var strStyle = objLabelStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objLabelStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Runat);
 var strRunat = objLabelStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objLabelStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.FontSize);
 var strFontSize = objLabelStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objLabelStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.FontName);
 var strFontName = objLabelStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objLabelStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Width);
 arrValueListForInsert.Add(objLabelStyleEN.Width.ToString());
 }
 
 if (objLabelStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Height);
 arrValueListForInsert.Add(objLabelStyleEN.Height.ToString());
 }
 
 if (objLabelStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleZindex);
 arrValueListForInsert.Add(objLabelStyleEN.StyleZindex.ToString());
 }
 
 if (objLabelStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleLeft);
 arrValueListForInsert.Add(objLabelStyleEN.StyleLeft.ToString());
 }
 
 if (objLabelStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StylePosition);
 var strStylePosition = objLabelStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objLabelStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleTop);
 arrValueListForInsert.Add(objLabelStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LabelStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLabelStyleEN objLabelStyleEN)
{
 if (objLabelStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLabelStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objLabelStyleEN.LabelStyleId !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.LabelStyleId);
 var strLabelStyleId = objLabelStyleEN.LabelStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelStyleId + "'");
 }
 
 if (objLabelStyleEN.LabelStyleName !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.LabelStyleName);
 var strLabelStyleName = objLabelStyleEN.LabelStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelStyleName + "'");
 }
 
 if (objLabelStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Style);
 var strStyle = objLabelStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objLabelStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Runat);
 var strRunat = objLabelStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objLabelStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.FontSize);
 var strFontSize = objLabelStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objLabelStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.FontName);
 var strFontName = objLabelStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objLabelStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Width);
 arrValueListForInsert.Add(objLabelStyleEN.Width.ToString());
 }
 
 if (objLabelStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Height);
 arrValueListForInsert.Add(objLabelStyleEN.Height.ToString());
 }
 
 if (objLabelStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleZindex);
 arrValueListForInsert.Add(objLabelStyleEN.StyleZindex.ToString());
 }
 
 if (objLabelStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleLeft);
 arrValueListForInsert.Add(objLabelStyleEN.StyleLeft.ToString());
 }
 
 if (objLabelStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StylePosition);
 var strStylePosition = objLabelStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objLabelStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleTop);
 arrValueListForInsert.Add(objLabelStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LabelStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objLabelStyleEN.LabelStyleId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLabelStyleEN objLabelStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLabelStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLabelStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objLabelStyleEN.LabelStyleId !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.LabelStyleId);
 var strLabelStyleId = objLabelStyleEN.LabelStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelStyleId + "'");
 }
 
 if (objLabelStyleEN.LabelStyleName !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.LabelStyleName);
 var strLabelStyleName = objLabelStyleEN.LabelStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelStyleName + "'");
 }
 
 if (objLabelStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Style);
 var strStyle = objLabelStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objLabelStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Runat);
 var strRunat = objLabelStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objLabelStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.FontSize);
 var strFontSize = objLabelStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objLabelStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.FontName);
 var strFontName = objLabelStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objLabelStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Width);
 arrValueListForInsert.Add(objLabelStyleEN.Width.ToString());
 }
 
 if (objLabelStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Height);
 arrValueListForInsert.Add(objLabelStyleEN.Height.ToString());
 }
 
 if (objLabelStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleZindex);
 arrValueListForInsert.Add(objLabelStyleEN.StyleZindex.ToString());
 }
 
 if (objLabelStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleLeft);
 arrValueListForInsert.Add(objLabelStyleEN.StyleLeft.ToString());
 }
 
 if (objLabelStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StylePosition);
 var strStylePosition = objLabelStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objLabelStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleTop);
 arrValueListForInsert.Add(objLabelStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LabelStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objLabelStyleEN.LabelStyleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLabelStyleEN objLabelStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objLabelStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLabelStyleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objLabelStyleEN.LabelStyleId !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.LabelStyleId);
 var strLabelStyleId = objLabelStyleEN.LabelStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelStyleId + "'");
 }
 
 if (objLabelStyleEN.LabelStyleName !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.LabelStyleName);
 var strLabelStyleName = objLabelStyleEN.LabelStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelStyleName + "'");
 }
 
 if (objLabelStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Style);
 var strStyle = objLabelStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objLabelStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Runat);
 var strRunat = objLabelStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objLabelStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.FontSize);
 var strFontSize = objLabelStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objLabelStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.FontName);
 var strFontName = objLabelStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objLabelStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Width);
 arrValueListForInsert.Add(objLabelStyleEN.Width.ToString());
 }
 
 if (objLabelStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.Height);
 arrValueListForInsert.Add(objLabelStyleEN.Height.ToString());
 }
 
 if (objLabelStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleZindex);
 arrValueListForInsert.Add(objLabelStyleEN.StyleZindex.ToString());
 }
 
 if (objLabelStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleLeft);
 arrValueListForInsert.Add(objLabelStyleEN.StyleLeft.ToString());
 }
 
 if (objLabelStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StylePosition);
 var strStylePosition = objLabelStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objLabelStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conLabelStyle.StyleTop);
 arrValueListForInsert.Add(objLabelStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LabelStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewLabelStyles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = "Select * from LabelStyle where LabelStyleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "LabelStyle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strLabelStyleId = oRow[conLabelStyle.LabelStyleId].ToString().Trim();
if (IsExist(strLabelStyleId))
{
 string strResult = "关键字变量值为:" + string.Format("LabelStyleId = {0}", strLabelStyleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsLabelStyleEN._CurrTabName ].NewRow();
objRow[conLabelStyle.LabelStyleId] = oRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objRow[conLabelStyle.LabelStyleName] = oRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objRow[conLabelStyle.Style] = oRow[conLabelStyle.Style].ToString().Trim(); //类型
objRow[conLabelStyle.Runat] = oRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objRow[conLabelStyle.FontSize] = oRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objRow[conLabelStyle.FontName] = oRow[conLabelStyle.FontName].ToString().Trim(); //字体
objRow[conLabelStyle.Width] = oRow[conLabelStyle.Width].ToString().Trim(); //宽
objRow[conLabelStyle.Height] = oRow[conLabelStyle.Height].ToString().Trim(); //高度
objRow[conLabelStyle.StyleZindex] = oRow[conLabelStyle.StyleZindex].ToString().Trim(); //Style_Zindex
objRow[conLabelStyle.StyleLeft] = oRow[conLabelStyle.StyleLeft].ToString().Trim(); //Style_Left
objRow[conLabelStyle.StylePosition] = oRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objRow[conLabelStyle.StyleTop] = oRow[conLabelStyle.StyleTop].ToString().Trim(); //Style_Top
 objDS.Tables[clsLabelStyleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsLabelStyleEN._CurrTabName);
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
 /// <param name = "objLabelStyleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsLabelStyleEN objLabelStyleEN)
{
 if (objLabelStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLabelStyleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
strSQL = "Select * from LabelStyle where LabelStyleId = " + "'"+ objLabelStyleEN.LabelStyleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsLabelStyleEN._CurrTabName);
if (objDS.Tables[clsLabelStyleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:LabelStyleId = " + "'"+ objLabelStyleEN.LabelStyleId+"'");
return false;
}
objRow = objDS.Tables[clsLabelStyleEN._CurrTabName].Rows[0];
 if (objLabelStyleEN.IsUpdated(conLabelStyle.LabelStyleId))
 {
objRow[conLabelStyle.LabelStyleId] = objLabelStyleEN.LabelStyleId; //LabelStyleId
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.LabelStyleName))
 {
objRow[conLabelStyle.LabelStyleName] = objLabelStyleEN.LabelStyleName; //LabelStyleName
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Style))
 {
objRow[conLabelStyle.Style] = objLabelStyleEN.Style; //类型
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Runat))
 {
objRow[conLabelStyle.Runat] = objLabelStyleEN.Runat; //运行在
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.FontSize))
 {
objRow[conLabelStyle.FontSize] = objLabelStyleEN.FontSize; //字号
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.FontName))
 {
objRow[conLabelStyle.FontName] = objLabelStyleEN.FontName; //字体
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Width))
 {
objRow[conLabelStyle.Width] = objLabelStyleEN.Width; //宽
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Height))
 {
objRow[conLabelStyle.Height] = objLabelStyleEN.Height; //高度
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleZindex))
 {
objRow[conLabelStyle.StyleZindex] = objLabelStyleEN.StyleZindex; //Style_Zindex
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleLeft))
 {
objRow[conLabelStyle.StyleLeft] = objLabelStyleEN.StyleLeft; //Style_Left
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StylePosition))
 {
objRow[conLabelStyle.StylePosition] = objLabelStyleEN.StylePosition; //Style_Position
 }
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleTop))
 {
objRow[conLabelStyle.StyleTop] = objLabelStyleEN.StyleTop; //Style_Top
 }
try
{
objDA.Update(objDS, clsLabelStyleEN._CurrTabName);
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
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLabelStyleEN objLabelStyleEN)
{
 if (objLabelStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLabelStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update LabelStyle Set ");
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.LabelStyleName))
 {
 if (objLabelStyleEN.LabelStyleName !=  null)
 {
 var strLabelStyleName = objLabelStyleEN.LabelStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLabelStyleName, conLabelStyle.LabelStyleName); //LabelStyleName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.LabelStyleName); //LabelStyleName
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Style))
 {
 if (objLabelStyleEN.Style !=  null)
 {
 var strStyle = objLabelStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conLabelStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Style); //类型
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Runat))
 {
 if (objLabelStyleEN.Runat !=  null)
 {
 var strRunat = objLabelStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conLabelStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Runat); //运行在
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.FontSize))
 {
 if (objLabelStyleEN.FontSize !=  null)
 {
 var strFontSize = objLabelStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conLabelStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.FontSize); //字号
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.FontName))
 {
 if (objLabelStyleEN.FontName !=  null)
 {
 var strFontName = objLabelStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conLabelStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.FontName); //字体
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Width))
 {
 if (objLabelStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.Width, conLabelStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Width); //宽
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Height))
 {
 if (objLabelStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.Height, conLabelStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Height); //高度
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleZindex))
 {
 if (objLabelStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleZindex, conLabelStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleLeft))
 {
 if (objLabelStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleLeft, conLabelStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StylePosition))
 {
 if (objLabelStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objLabelStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conLabelStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StylePosition); //Style_Position
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleTop))
 {
 if (objLabelStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleTop, conLabelStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleTop); //Style_Top
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LabelStyleId = '{0}'", objLabelStyleEN.LabelStyleId); 
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
 /// <param name = "objLabelStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsLabelStyleEN objLabelStyleEN, string strCondition)
{
 if (objLabelStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLabelStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LabelStyle Set ");
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.LabelStyleName))
 {
 if (objLabelStyleEN.LabelStyleName !=  null)
 {
 var strLabelStyleName = objLabelStyleEN.LabelStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LabelStyleName = '{0}',", strLabelStyleName); //LabelStyleName
 }
 else
 {
 sbSQL.Append(" LabelStyleName = null,"); //LabelStyleName
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Style))
 {
 if (objLabelStyleEN.Style !=  null)
 {
 var strStyle = objLabelStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Runat))
 {
 if (objLabelStyleEN.Runat !=  null)
 {
 var strRunat = objLabelStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.FontSize))
 {
 if (objLabelStyleEN.FontSize !=  null)
 {
 var strFontSize = objLabelStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.FontName))
 {
 if (objLabelStyleEN.FontName !=  null)
 {
 var strFontName = objLabelStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Width))
 {
 if (objLabelStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.Width, conLabelStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Width); //宽
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Height))
 {
 if (objLabelStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.Height, conLabelStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Height); //高度
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleZindex))
 {
 if (objLabelStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleZindex, conLabelStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleLeft))
 {
 if (objLabelStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleLeft, conLabelStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StylePosition))
 {
 if (objLabelStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objLabelStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleTop))
 {
 if (objLabelStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleTop, conLabelStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleTop); //Style_Top
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
 /// <param name = "objLabelStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsLabelStyleEN objLabelStyleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLabelStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLabelStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LabelStyle Set ");
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.LabelStyleName))
 {
 if (objLabelStyleEN.LabelStyleName !=  null)
 {
 var strLabelStyleName = objLabelStyleEN.LabelStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LabelStyleName = '{0}',", strLabelStyleName); //LabelStyleName
 }
 else
 {
 sbSQL.Append(" LabelStyleName = null,"); //LabelStyleName
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Style))
 {
 if (objLabelStyleEN.Style !=  null)
 {
 var strStyle = objLabelStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Runat))
 {
 if (objLabelStyleEN.Runat !=  null)
 {
 var strRunat = objLabelStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.FontSize))
 {
 if (objLabelStyleEN.FontSize !=  null)
 {
 var strFontSize = objLabelStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.FontName))
 {
 if (objLabelStyleEN.FontName !=  null)
 {
 var strFontName = objLabelStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Width))
 {
 if (objLabelStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.Width, conLabelStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Width); //宽
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Height))
 {
 if (objLabelStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.Height, conLabelStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Height); //高度
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleZindex))
 {
 if (objLabelStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleZindex, conLabelStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleLeft))
 {
 if (objLabelStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleLeft, conLabelStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StylePosition))
 {
 if (objLabelStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objLabelStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleTop))
 {
 if (objLabelStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleTop, conLabelStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleTop); //Style_Top
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
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLabelStyleEN objLabelStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objLabelStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLabelStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LabelStyle Set ");
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.LabelStyleName))
 {
 if (objLabelStyleEN.LabelStyleName !=  null)
 {
 var strLabelStyleName = objLabelStyleEN.LabelStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLabelStyleName, conLabelStyle.LabelStyleName); //LabelStyleName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.LabelStyleName); //LabelStyleName
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Style))
 {
 if (objLabelStyleEN.Style !=  null)
 {
 var strStyle = objLabelStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conLabelStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Style); //类型
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Runat))
 {
 if (objLabelStyleEN.Runat !=  null)
 {
 var strRunat = objLabelStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conLabelStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Runat); //运行在
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.FontSize))
 {
 if (objLabelStyleEN.FontSize !=  null)
 {
 var strFontSize = objLabelStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conLabelStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.FontSize); //字号
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.FontName))
 {
 if (objLabelStyleEN.FontName !=  null)
 {
 var strFontName = objLabelStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conLabelStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.FontName); //字体
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Width))
 {
 if (objLabelStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.Width, conLabelStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Width); //宽
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.Height))
 {
 if (objLabelStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.Height, conLabelStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.Height); //高度
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleZindex))
 {
 if (objLabelStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleZindex, conLabelStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleLeft))
 {
 if (objLabelStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleLeft, conLabelStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StylePosition))
 {
 if (objLabelStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objLabelStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conLabelStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StylePosition); //Style_Position
 }
 }
 
 if (objLabelStyleEN.IsUpdated(conLabelStyle.StyleTop))
 {
 if (objLabelStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLabelStyleEN.StyleTop, conLabelStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLabelStyle.StyleTop); //Style_Top
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LabelStyleId = '{0}'", objLabelStyleEN.LabelStyleId); 
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
 /// <param name = "strLabelStyleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strLabelStyleId) 
{
CheckPrimaryKey(strLabelStyleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strLabelStyleId,
};
 objSQL.ExecSP("LabelStyle_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strLabelStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strLabelStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strLabelStyleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
//删除LabelStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LabelStyle where LabelStyleId = " + "'"+ strLabelStyleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelLabelStyle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
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
//删除LabelStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LabelStyle where LabelStyleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strLabelStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strLabelStyleId) 
{
CheckPrimaryKey(strLabelStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
//删除LabelStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LabelStyle where LabelStyleId = " + "'"+ strLabelStyleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelLabelStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsLabelStyleDA: DelLabelStyle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from LabelStyle where " + strCondition ;
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
public bool DelLabelStyleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsLabelStyleDA: DelLabelStyleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from LabelStyle where " + strCondition ;
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
 /// <param name = "objLabelStyleENS">源对象</param>
 /// <param name = "objLabelStyleENT">目标对象</param>
public void CopyTo(clsLabelStyleEN objLabelStyleENS, clsLabelStyleEN objLabelStyleENT)
{
objLabelStyleENT.LabelStyleId = objLabelStyleENS.LabelStyleId; //LabelStyleId
objLabelStyleENT.LabelStyleName = objLabelStyleENS.LabelStyleName; //LabelStyleName
objLabelStyleENT.Style = objLabelStyleENS.Style; //类型
objLabelStyleENT.Runat = objLabelStyleENS.Runat; //运行在
objLabelStyleENT.FontSize = objLabelStyleENS.FontSize; //字号
objLabelStyleENT.FontName = objLabelStyleENS.FontName; //字体
objLabelStyleENT.Width = objLabelStyleENS.Width; //宽
objLabelStyleENT.Height = objLabelStyleENS.Height; //高度
objLabelStyleENT.StyleZindex = objLabelStyleENS.StyleZindex; //Style_Zindex
objLabelStyleENT.StyleLeft = objLabelStyleENS.StyleLeft; //Style_Left
objLabelStyleENT.StylePosition = objLabelStyleENS.StylePosition; //Style_Position
objLabelStyleENT.StyleTop = objLabelStyleENS.StyleTop; //Style_Top
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsLabelStyleEN objLabelStyleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objLabelStyleEN.LabelStyleName, conLabelStyle.LabelStyleName);
//检查字段长度
clsCheckSql.CheckFieldLen(objLabelStyleEN.LabelStyleId, 4, conLabelStyle.LabelStyleId);
clsCheckSql.CheckFieldLen(objLabelStyleEN.LabelStyleName, 30, conLabelStyle.LabelStyleName);
clsCheckSql.CheckFieldLen(objLabelStyleEN.Style, 800, conLabelStyle.Style);
clsCheckSql.CheckFieldLen(objLabelStyleEN.Runat, 30, conLabelStyle.Runat);
clsCheckSql.CheckFieldLen(objLabelStyleEN.FontSize, 20, conLabelStyle.FontSize);
clsCheckSql.CheckFieldLen(objLabelStyleEN.FontName, 20, conLabelStyle.FontName);
clsCheckSql.CheckFieldLen(objLabelStyleEN.StylePosition, 20, conLabelStyle.StylePosition);
//检查字段外键固定长度
 objLabelStyleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsLabelStyleEN objLabelStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLabelStyleEN.LabelStyleName, 30, conLabelStyle.LabelStyleName);
clsCheckSql.CheckFieldLen(objLabelStyleEN.Style, 800, conLabelStyle.Style);
clsCheckSql.CheckFieldLen(objLabelStyleEN.Runat, 30, conLabelStyle.Runat);
clsCheckSql.CheckFieldLen(objLabelStyleEN.FontSize, 20, conLabelStyle.FontSize);
clsCheckSql.CheckFieldLen(objLabelStyleEN.FontName, 20, conLabelStyle.FontName);
clsCheckSql.CheckFieldLen(objLabelStyleEN.StylePosition, 20, conLabelStyle.StylePosition);
//检查外键字段长度
 objLabelStyleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsLabelStyleEN objLabelStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLabelStyleEN.LabelStyleId, 4, conLabelStyle.LabelStyleId);
clsCheckSql.CheckFieldLen(objLabelStyleEN.LabelStyleName, 30, conLabelStyle.LabelStyleName);
clsCheckSql.CheckFieldLen(objLabelStyleEN.Style, 800, conLabelStyle.Style);
clsCheckSql.CheckFieldLen(objLabelStyleEN.Runat, 30, conLabelStyle.Runat);
clsCheckSql.CheckFieldLen(objLabelStyleEN.FontSize, 20, conLabelStyle.FontSize);
clsCheckSql.CheckFieldLen(objLabelStyleEN.FontName, 20, conLabelStyle.FontName);
clsCheckSql.CheckFieldLen(objLabelStyleEN.StylePosition, 20, conLabelStyle.StylePosition);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objLabelStyleEN.LabelStyleId, conLabelStyle.LabelStyleId);
clsCheckSql.CheckSqlInjection4Field(objLabelStyleEN.LabelStyleName, conLabelStyle.LabelStyleName);
clsCheckSql.CheckSqlInjection4Field(objLabelStyleEN.Style, conLabelStyle.Style);
clsCheckSql.CheckSqlInjection4Field(objLabelStyleEN.Runat, conLabelStyle.Runat);
clsCheckSql.CheckSqlInjection4Field(objLabelStyleEN.FontSize, conLabelStyle.FontSize);
clsCheckSql.CheckSqlInjection4Field(objLabelStyleEN.FontName, conLabelStyle.FontName);
clsCheckSql.CheckSqlInjection4Field(objLabelStyleEN.StylePosition, conLabelStyle.StylePosition);
//检查外键字段长度
 objLabelStyleEN._IsCheckProperty = true;
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
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
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
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
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
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLabelStyleEN._CurrTabName);
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
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLabelStyleEN._CurrTabName, strCondition);
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
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
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
 objSQL = clsLabelStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}