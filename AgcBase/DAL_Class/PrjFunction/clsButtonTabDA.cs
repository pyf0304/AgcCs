
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsButtonTabDA
 表名:ButtonTab(00050427)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:51
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 按钮(ButtonTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsButtonTabDA : clsCommBase4DA
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
 return clsButtonTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsButtonTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsButtonTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsButtonTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsButtonTabEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strButtonId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strButtonId)
{
strButtonId = strButtonId.Replace("'", "''");
if (strButtonId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:ButtonTab中,检查关键字,长度不正确!(clsButtonTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strButtonId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ButtonTab中,关键字不能为空 或 null!(clsButtonTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strButtonId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsButtonTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsButtonTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = "Select * from ButtonTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ButtonTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsButtonTabDA: GetDataTable_ButtonTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = "Select * from ButtonTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsButtonTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsButtonTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = "Select * from ButtonTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsButtonTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsButtonTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ButtonTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ButtonTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsButtonTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ButtonTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsButtonTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ButtonTab.* " + 
$"from ButtonTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ButtonTab.ButtonId not in " + 
$"(Select top {intTop_In} ButtonTab.ButtonId from ButtonTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ButtonTab where {1} and ButtonId not in (Select top {2} ButtonId from ButtonTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ButtonTab where {1} and ButtonId not in (Select top {3} ButtonId from ButtonTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsButtonTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ButtonTab.* " + 
$"from ButtonTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ButtonTab.ButtonId not in " + 
$"(Select top {intTop_In} ButtonTab.ButtonId from ButtonTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ButtonTab where {1} and ButtonId not in (Select top {2} ButtonId from ButtonTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ButtonTab where {1} and ButtonId not in (Select top {3} ButtonId from ButtonTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsButtonTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsButtonTabDA:GetObjLst)", objException.Message));
}
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = "Select * from ButtonTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = TransNullToBool(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsButtonTabDA: GetObjLst)", objException.Message));
}
objButtonTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objButtonTabEN);
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
public List<clsButtonTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsButtonTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = TransNullToBool(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsButtonTabDA: GetObjLst)", objException.Message));
}
objButtonTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objButtonTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objButtonTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetButtonTab(ref clsButtonTabEN objButtonTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = "Select * from ButtonTab where ButtonId = " + "'"+ objButtonTabEN.ButtonId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objButtonTabEN.ButtonId = objDT.Rows[0][conButtonTab.ButtonId].ToString().Trim(); //按钮Id(字段类型:char,字段长度:2,是否可空:False)
 objButtonTabEN.ButtonName = objDT.Rows[0][conButtonTab.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objButtonTabEN.Text = objDT.Rows[0][conButtonTab.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objButtonTabEN.CommandName = objDT.Rows[0][conButtonTab.CommandName].ToString().Trim(); //命令名(字段类型:varchar,字段长度:30,是否可空:True)
 objButtonTabEN.Height = TransNullToInt(objDT.Rows[0][conButtonTab.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objButtonTabEN.Width = TransNullToInt(objDT.Rows[0][conButtonTab.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objButtonTabEN.CssClass = objDT.Rows[0][conButtonTab.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objButtonTabEN.ImageUrl = objDT.Rows[0][conButtonTab.ImageUrl].ToString().Trim(); //图片资源(字段类型:varchar,字段长度:100,是否可空:True)
 objButtonTabEN.InUse = TransNullToBool(objDT.Rows[0][conButtonTab.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objButtonTabEN.OrderNum = TransNullToInt(objDT.Rows[0][conButtonTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objButtonTabEN.UpdUser = objDT.Rows[0][conButtonTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objButtonTabEN.UpdDate = objDT.Rows[0][conButtonTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objButtonTabEN.Memo = objDT.Rows[0][conButtonTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsButtonTabDA: GetButtonTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strButtonId">表关键字</param>
 /// <returns>表对象</returns>
public clsButtonTabEN GetObjByButtonId(string strButtonId)
{
CheckPrimaryKey(strButtonId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = "Select * from ButtonTab where ButtonId = " + "'"+ strButtonId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
 objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id(字段类型:char,字段长度:2,是否可空:False)
 objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名(字段类型:varchar,字段长度:30,是否可空:True)
 objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源(字段类型:varchar,字段长度:100,是否可空:True)
 objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsButtonTabDA: GetObjByButtonId)", objException.Message));
}
return objButtonTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsButtonTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsButtonTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = "Select * from ButtonTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN()
{
ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(), //按钮Id
ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(), //按钮名称
Text = objRow[conButtonTab.Text].ToString().Trim(), //文本
CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(), //命令名
Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.Height].ToString().Trim()), //高度
Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.Width].ToString().Trim()), //宽
CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(), //样式表
ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(), //图片资源
InUse = TransNullToBool(objRow[conButtonTab.InUse].ToString().Trim()), //是否在用
OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.OrderNum].ToString().Trim()), //序号
UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim() //说明
};
objButtonTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objButtonTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsButtonTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsButtonTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = TransNullToBool(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsButtonTabDA: GetObjByDataRowButtonTab)", objException.Message));
}
objButtonTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objButtonTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsButtonTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = TransNullToBool(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsButtonTabDA: GetObjByDataRow)", objException.Message));
}
objButtonTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objButtonTabEN;
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
objSQL = clsButtonTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsButtonTabEN._CurrTabName, conButtonTab.ButtonId, 2, "");
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
objSQL = clsButtonTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsButtonTabEN._CurrTabName, conButtonTab.ButtonId, 2, strPrefix);
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
 objSQL = clsButtonTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ButtonId from ButtonTab where " + strCondition;
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
 objSQL = clsButtonTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ButtonId from ButtonTab where " + strCondition;
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
 /// <param name = "strButtonId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strButtonId)
{
CheckPrimaryKey(strButtonId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ButtonTab", "ButtonId = " + "'"+ strButtonId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsButtonTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ButtonTab", strCondition))
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
objSQL = clsButtonTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ButtonTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsButtonTabEN objButtonTabEN)
 {
 objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objButtonTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objButtonTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = "Select * from ButtonTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ButtonTab");
objRow = objDS.Tables["ButtonTab"].NewRow();
objRow[conButtonTab.ButtonId] = objButtonTabEN.ButtonId; //按钮Id
objRow[conButtonTab.ButtonName] = objButtonTabEN.ButtonName; //按钮名称
objRow[conButtonTab.Text] = objButtonTabEN.Text; //文本
 if (objButtonTabEN.CommandName !=  "")
 {
objRow[conButtonTab.CommandName] = objButtonTabEN.CommandName; //命令名
 }
objRow[conButtonTab.Height] = objButtonTabEN.Height; //高度
objRow[conButtonTab.Width] = objButtonTabEN.Width; //宽
 if (objButtonTabEN.CssClass !=  "")
 {
objRow[conButtonTab.CssClass] = objButtonTabEN.CssClass; //样式表
 }
 if (objButtonTabEN.ImageUrl !=  "")
 {
objRow[conButtonTab.ImageUrl] = objButtonTabEN.ImageUrl; //图片资源
 }
objRow[conButtonTab.InUse] = objButtonTabEN.InUse; //是否在用
objRow[conButtonTab.OrderNum] = objButtonTabEN.OrderNum; //序号
objRow[conButtonTab.UpdUser] = objButtonTabEN.UpdUser; //修改者
 if (objButtonTabEN.UpdDate !=  "")
 {
objRow[conButtonTab.UpdDate] = objButtonTabEN.UpdDate; //修改日期
 }
 if (objButtonTabEN.Memo !=  "")
 {
objRow[conButtonTab.Memo] = objButtonTabEN.Memo; //说明
 }
objDS.Tables[clsButtonTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsButtonTabEN._CurrTabName);
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsButtonTabEN objButtonTabEN)
{
 objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objButtonTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objButtonTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objButtonTabEN.ButtonId !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ButtonId);
 var strButtonId = objButtonTabEN.ButtonId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonId + "'");
 }
 
 if (objButtonTabEN.ButtonName !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ButtonName);
 var strButtonName = objButtonTabEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName + "'");
 }
 
 if (objButtonTabEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Text);
 var strText = objButtonTabEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objButtonTabEN.CommandName !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.CommandName);
 var strCommandName = objButtonTabEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommandName + "'");
 }
 
 if (objButtonTabEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Height);
 arrValueListForInsert.Add(objButtonTabEN.Height.ToString());
 }
 
 if (objButtonTabEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Width);
 arrValueListForInsert.Add(objButtonTabEN.Width.ToString());
 }
 
 if (objButtonTabEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.CssClass);
 var strCssClass = objButtonTabEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objButtonTabEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ImageUrl);
 var strImageUrl = objButtonTabEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 arrFieldListForInsert.Add(conButtonTab.InUse);
 arrValueListForInsert.Add("'" + (objButtonTabEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objButtonTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.OrderNum);
 arrValueListForInsert.Add(objButtonTabEN.OrderNum.ToString());
 }
 
 if (objButtonTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.UpdUser);
 var strUpdUser = objButtonTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objButtonTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.UpdDate);
 var strUpdDate = objButtonTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objButtonTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Memo);
 var strMemo = objButtonTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ButtonTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsButtonTabEN objButtonTabEN)
{
 objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objButtonTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objButtonTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objButtonTabEN.ButtonId !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ButtonId);
 var strButtonId = objButtonTabEN.ButtonId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonId + "'");
 }
 
 if (objButtonTabEN.ButtonName !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ButtonName);
 var strButtonName = objButtonTabEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName + "'");
 }
 
 if (objButtonTabEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Text);
 var strText = objButtonTabEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objButtonTabEN.CommandName !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.CommandName);
 var strCommandName = objButtonTabEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommandName + "'");
 }
 
 if (objButtonTabEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Height);
 arrValueListForInsert.Add(objButtonTabEN.Height.ToString());
 }
 
 if (objButtonTabEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Width);
 arrValueListForInsert.Add(objButtonTabEN.Width.ToString());
 }
 
 if (objButtonTabEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.CssClass);
 var strCssClass = objButtonTabEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objButtonTabEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ImageUrl);
 var strImageUrl = objButtonTabEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 arrFieldListForInsert.Add(conButtonTab.InUse);
 arrValueListForInsert.Add("'" + (objButtonTabEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objButtonTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.OrderNum);
 arrValueListForInsert.Add(objButtonTabEN.OrderNum.ToString());
 }
 
 if (objButtonTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.UpdUser);
 var strUpdUser = objButtonTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objButtonTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.UpdDate);
 var strUpdDate = objButtonTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objButtonTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Memo);
 var strMemo = objButtonTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ButtonTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objButtonTabEN.ButtonId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsButtonTabEN objButtonTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objButtonTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objButtonTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objButtonTabEN.ButtonId !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ButtonId);
 var strButtonId = objButtonTabEN.ButtonId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonId + "'");
 }
 
 if (objButtonTabEN.ButtonName !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ButtonName);
 var strButtonName = objButtonTabEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName + "'");
 }
 
 if (objButtonTabEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Text);
 var strText = objButtonTabEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objButtonTabEN.CommandName !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.CommandName);
 var strCommandName = objButtonTabEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommandName + "'");
 }
 
 if (objButtonTabEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Height);
 arrValueListForInsert.Add(objButtonTabEN.Height.ToString());
 }
 
 if (objButtonTabEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Width);
 arrValueListForInsert.Add(objButtonTabEN.Width.ToString());
 }
 
 if (objButtonTabEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.CssClass);
 var strCssClass = objButtonTabEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objButtonTabEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ImageUrl);
 var strImageUrl = objButtonTabEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 arrFieldListForInsert.Add(conButtonTab.InUse);
 arrValueListForInsert.Add("'" + (objButtonTabEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objButtonTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.OrderNum);
 arrValueListForInsert.Add(objButtonTabEN.OrderNum.ToString());
 }
 
 if (objButtonTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.UpdUser);
 var strUpdUser = objButtonTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objButtonTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.UpdDate);
 var strUpdDate = objButtonTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objButtonTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Memo);
 var strMemo = objButtonTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ButtonTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objButtonTabEN.ButtonId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsButtonTabEN objButtonTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objButtonTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objButtonTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objButtonTabEN.ButtonId !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ButtonId);
 var strButtonId = objButtonTabEN.ButtonId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonId + "'");
 }
 
 if (objButtonTabEN.ButtonName !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ButtonName);
 var strButtonName = objButtonTabEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonName + "'");
 }
 
 if (objButtonTabEN.Text !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Text);
 var strText = objButtonTabEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strText + "'");
 }
 
 if (objButtonTabEN.CommandName !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.CommandName);
 var strCommandName = objButtonTabEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCommandName + "'");
 }
 
 if (objButtonTabEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Height);
 arrValueListForInsert.Add(objButtonTabEN.Height.ToString());
 }
 
 if (objButtonTabEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Width);
 arrValueListForInsert.Add(objButtonTabEN.Width.ToString());
 }
 
 if (objButtonTabEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.CssClass);
 var strCssClass = objButtonTabEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objButtonTabEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.ImageUrl);
 var strImageUrl = objButtonTabEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 arrFieldListForInsert.Add(conButtonTab.InUse);
 arrValueListForInsert.Add("'" + (objButtonTabEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objButtonTabEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.OrderNum);
 arrValueListForInsert.Add(objButtonTabEN.OrderNum.ToString());
 }
 
 if (objButtonTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.UpdUser);
 var strUpdUser = objButtonTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objButtonTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.UpdDate);
 var strUpdDate = objButtonTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objButtonTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conButtonTab.Memo);
 var strMemo = objButtonTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ButtonTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewButtonTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = "Select * from ButtonTab where ButtonId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ButtonTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strButtonId = oRow[conButtonTab.ButtonId].ToString().Trim();
if (IsExist(strButtonId))
{
 string strResult = "关键字变量值为:" + string.Format("ButtonId = {0}", strButtonId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsButtonTabEN._CurrTabName ].NewRow();
objRow[conButtonTab.ButtonId] = oRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objRow[conButtonTab.ButtonName] = oRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objRow[conButtonTab.Text] = oRow[conButtonTab.Text].ToString().Trim(); //文本
objRow[conButtonTab.CommandName] = oRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objRow[conButtonTab.Height] = oRow[conButtonTab.Height].ToString().Trim(); //高度
objRow[conButtonTab.Width] = oRow[conButtonTab.Width].ToString().Trim(); //宽
objRow[conButtonTab.CssClass] = oRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objRow[conButtonTab.ImageUrl] = oRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objRow[conButtonTab.InUse] = oRow[conButtonTab.InUse].ToString().Trim(); //是否在用
objRow[conButtonTab.OrderNum] = oRow[conButtonTab.OrderNum].ToString().Trim(); //序号
objRow[conButtonTab.UpdUser] = oRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objRow[conButtonTab.UpdDate] = oRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objRow[conButtonTab.Memo] = oRow[conButtonTab.Memo].ToString().Trim(); //说明
 objDS.Tables[clsButtonTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsButtonTabEN._CurrTabName);
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
 /// <param name = "objButtonTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsButtonTabEN objButtonTabEN)
{
 objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objButtonTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objButtonTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
strSQL = "Select * from ButtonTab where ButtonId = " + "'"+ objButtonTabEN.ButtonId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsButtonTabEN._CurrTabName);
if (objDS.Tables[clsButtonTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ButtonId = " + "'"+ objButtonTabEN.ButtonId+"'");
return false;
}
objRow = objDS.Tables[clsButtonTabEN._CurrTabName].Rows[0];
 if (objButtonTabEN.IsUpdated(conButtonTab.ButtonId))
 {
objRow[conButtonTab.ButtonId] = objButtonTabEN.ButtonId; //按钮Id
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.ButtonName))
 {
objRow[conButtonTab.ButtonName] = objButtonTabEN.ButtonName; //按钮名称
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.Text))
 {
objRow[conButtonTab.Text] = objButtonTabEN.Text; //文本
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.CommandName))
 {
objRow[conButtonTab.CommandName] = objButtonTabEN.CommandName; //命令名
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.Height))
 {
objRow[conButtonTab.Height] = objButtonTabEN.Height; //高度
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.Width))
 {
objRow[conButtonTab.Width] = objButtonTabEN.Width; //宽
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.CssClass))
 {
objRow[conButtonTab.CssClass] = objButtonTabEN.CssClass; //样式表
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.ImageUrl))
 {
objRow[conButtonTab.ImageUrl] = objButtonTabEN.ImageUrl; //图片资源
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.InUse))
 {
objRow[conButtonTab.InUse] = objButtonTabEN.InUse; //是否在用
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.OrderNum))
 {
objRow[conButtonTab.OrderNum] = objButtonTabEN.OrderNum; //序号
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.UpdUser))
 {
objRow[conButtonTab.UpdUser] = objButtonTabEN.UpdUser; //修改者
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.UpdDate))
 {
objRow[conButtonTab.UpdDate] = objButtonTabEN.UpdDate; //修改日期
 }
 if (objButtonTabEN.IsUpdated(conButtonTab.Memo))
 {
objRow[conButtonTab.Memo] = objButtonTabEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsButtonTabEN._CurrTabName);
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsButtonTabEN objButtonTabEN)
{
 objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objButtonTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objButtonTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ButtonTab Set ");
 
 if (objButtonTabEN.IsUpdated(conButtonTab.ButtonName))
 {
 if (objButtonTabEN.ButtonName !=  null)
 {
 var strButtonName = objButtonTabEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strButtonName, conButtonTab.ButtonName); //按钮名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.ButtonName); //按钮名称
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Text))
 {
 if (objButtonTabEN.Text !=  null)
 {
 var strText = objButtonTabEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strText, conButtonTab.Text); //文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Text); //文本
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.CommandName))
 {
 if (objButtonTabEN.CommandName !=  null)
 {
 var strCommandName = objButtonTabEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCommandName, conButtonTab.CommandName); //命令名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.CommandName); //命令名
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Height))
 {
 if (objButtonTabEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.Height, conButtonTab.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Height); //高度
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Width))
 {
 if (objButtonTabEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.Width, conButtonTab.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Width); //宽
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.CssClass))
 {
 if (objButtonTabEN.CssClass !=  null)
 {
 var strCssClass = objButtonTabEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCssClass, conButtonTab.CssClass); //样式表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.CssClass); //样式表
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.ImageUrl))
 {
 if (objButtonTabEN.ImageUrl !=  null)
 {
 var strImageUrl = objButtonTabEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImageUrl, conButtonTab.ImageUrl); //图片资源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.ImageUrl); //图片资源
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objButtonTabEN.InUse == true?"1":"0", conButtonTab.InUse); //是否在用
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.OrderNum))
 {
 if (objButtonTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.OrderNum, conButtonTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.OrderNum); //序号
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.UpdUser))
 {
 if (objButtonTabEN.UpdUser !=  null)
 {
 var strUpdUser = objButtonTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conButtonTab.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.UpdUser); //修改者
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.UpdDate))
 {
 if (objButtonTabEN.UpdDate !=  null)
 {
 var strUpdDate = objButtonTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conButtonTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.UpdDate); //修改日期
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Memo))
 {
 if (objButtonTabEN.Memo !=  null)
 {
 var strMemo = objButtonTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conButtonTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ButtonId = '{0}'", objButtonTabEN.ButtonId); 
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
 /// <param name = "objButtonTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsButtonTabEN objButtonTabEN, string strCondition)
{
 objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objButtonTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objButtonTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ButtonTab Set ");
 
 if (objButtonTabEN.IsUpdated(conButtonTab.ButtonName))
 {
 if (objButtonTabEN.ButtonName !=  null)
 {
 var strButtonName = objButtonTabEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ButtonName = '{0}',", strButtonName); //按钮名称
 }
 else
 {
 sbSQL.Append(" ButtonName = null,"); //按钮名称
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Text))
 {
 if (objButtonTabEN.Text !=  null)
 {
 var strText = objButtonTabEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Text = '{0}',", strText); //文本
 }
 else
 {
 sbSQL.Append(" Text = null,"); //文本
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.CommandName))
 {
 if (objButtonTabEN.CommandName !=  null)
 {
 var strCommandName = objButtonTabEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CommandName = '{0}',", strCommandName); //命令名
 }
 else
 {
 sbSQL.Append(" CommandName = null,"); //命令名
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Height))
 {
 if (objButtonTabEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.Height, conButtonTab.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Height); //高度
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Width))
 {
 if (objButtonTabEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.Width, conButtonTab.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Width); //宽
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.CssClass))
 {
 if (objButtonTabEN.CssClass !=  null)
 {
 var strCssClass = objButtonTabEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CssClass = '{0}',", strCssClass); //样式表
 }
 else
 {
 sbSQL.Append(" CssClass = null,"); //样式表
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.ImageUrl))
 {
 if (objButtonTabEN.ImageUrl !=  null)
 {
 var strImageUrl = objButtonTabEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImageUrl = '{0}',", strImageUrl); //图片资源
 }
 else
 {
 sbSQL.Append(" ImageUrl = null,"); //图片资源
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objButtonTabEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.OrderNum))
 {
 if (objButtonTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.OrderNum, conButtonTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.OrderNum); //序号
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.UpdUser))
 {
 if (objButtonTabEN.UpdUser !=  null)
 {
 var strUpdUser = objButtonTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.UpdDate))
 {
 if (objButtonTabEN.UpdDate !=  null)
 {
 var strUpdDate = objButtonTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Memo))
 {
 if (objButtonTabEN.Memo !=  null)
 {
 var strMemo = objButtonTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objButtonTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsButtonTabEN objButtonTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objButtonTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objButtonTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ButtonTab Set ");
 
 if (objButtonTabEN.IsUpdated(conButtonTab.ButtonName))
 {
 if (objButtonTabEN.ButtonName !=  null)
 {
 var strButtonName = objButtonTabEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ButtonName = '{0}',", strButtonName); //按钮名称
 }
 else
 {
 sbSQL.Append(" ButtonName = null,"); //按钮名称
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Text))
 {
 if (objButtonTabEN.Text !=  null)
 {
 var strText = objButtonTabEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Text = '{0}',", strText); //文本
 }
 else
 {
 sbSQL.Append(" Text = null,"); //文本
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.CommandName))
 {
 if (objButtonTabEN.CommandName !=  null)
 {
 var strCommandName = objButtonTabEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CommandName = '{0}',", strCommandName); //命令名
 }
 else
 {
 sbSQL.Append(" CommandName = null,"); //命令名
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Height))
 {
 if (objButtonTabEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.Height, conButtonTab.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Height); //高度
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Width))
 {
 if (objButtonTabEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.Width, conButtonTab.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Width); //宽
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.CssClass))
 {
 if (objButtonTabEN.CssClass !=  null)
 {
 var strCssClass = objButtonTabEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CssClass = '{0}',", strCssClass); //样式表
 }
 else
 {
 sbSQL.Append(" CssClass = null,"); //样式表
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.ImageUrl))
 {
 if (objButtonTabEN.ImageUrl !=  null)
 {
 var strImageUrl = objButtonTabEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImageUrl = '{0}',", strImageUrl); //图片资源
 }
 else
 {
 sbSQL.Append(" ImageUrl = null,"); //图片资源
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objButtonTabEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.OrderNum))
 {
 if (objButtonTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.OrderNum, conButtonTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.OrderNum); //序号
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.UpdUser))
 {
 if (objButtonTabEN.UpdUser !=  null)
 {
 var strUpdUser = objButtonTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.UpdDate))
 {
 if (objButtonTabEN.UpdDate !=  null)
 {
 var strUpdDate = objButtonTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Memo))
 {
 if (objButtonTabEN.Memo !=  null)
 {
 var strMemo = objButtonTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsButtonTabEN objButtonTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objButtonTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objButtonTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ButtonTab Set ");
 
 if (objButtonTabEN.IsUpdated(conButtonTab.ButtonName))
 {
 if (objButtonTabEN.ButtonName !=  null)
 {
 var strButtonName = objButtonTabEN.ButtonName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strButtonName, conButtonTab.ButtonName); //按钮名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.ButtonName); //按钮名称
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Text))
 {
 if (objButtonTabEN.Text !=  null)
 {
 var strText = objButtonTabEN.Text.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strText, conButtonTab.Text); //文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Text); //文本
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.CommandName))
 {
 if (objButtonTabEN.CommandName !=  null)
 {
 var strCommandName = objButtonTabEN.CommandName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCommandName, conButtonTab.CommandName); //命令名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.CommandName); //命令名
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Height))
 {
 if (objButtonTabEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.Height, conButtonTab.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Height); //高度
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Width))
 {
 if (objButtonTabEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.Width, conButtonTab.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Width); //宽
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.CssClass))
 {
 if (objButtonTabEN.CssClass !=  null)
 {
 var strCssClass = objButtonTabEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCssClass, conButtonTab.CssClass); //样式表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.CssClass); //样式表
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.ImageUrl))
 {
 if (objButtonTabEN.ImageUrl !=  null)
 {
 var strImageUrl = objButtonTabEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImageUrl, conButtonTab.ImageUrl); //图片资源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.ImageUrl); //图片资源
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objButtonTabEN.InUse == true?"1":"0", conButtonTab.InUse); //是否在用
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.OrderNum))
 {
 if (objButtonTabEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonTabEN.OrderNum, conButtonTab.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.OrderNum); //序号
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.UpdUser))
 {
 if (objButtonTabEN.UpdUser !=  null)
 {
 var strUpdUser = objButtonTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conButtonTab.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.UpdUser); //修改者
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.UpdDate))
 {
 if (objButtonTabEN.UpdDate !=  null)
 {
 var strUpdDate = objButtonTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conButtonTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.UpdDate); //修改日期
 }
 }
 
 if (objButtonTabEN.IsUpdated(conButtonTab.Memo))
 {
 if (objButtonTabEN.Memo !=  null)
 {
 var strMemo = objButtonTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conButtonTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ButtonId = '{0}'", objButtonTabEN.ButtonId); 
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
 /// <param name = "strButtonId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strButtonId) 
{
CheckPrimaryKey(strButtonId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strButtonId,
};
 objSQL.ExecSP("ButtonTab_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strButtonId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strButtonId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strButtonId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
//删除ButtonTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ButtonTab where ButtonId = " + "'"+ strButtonId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelButtonTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
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
//删除ButtonTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ButtonTab where ButtonId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strButtonId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strButtonId) 
{
CheckPrimaryKey(strButtonId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
//删除ButtonTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ButtonTab where ButtonId = " + "'"+ strButtonId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelButtonTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsButtonTabDA: DelButtonTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ButtonTab where " + strCondition ;
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
public bool DelButtonTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsButtonTabDA: DelButtonTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ButtonTab where " + strCondition ;
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
 /// <param name = "objButtonTabENS">源对象</param>
 /// <param name = "objButtonTabENT">目标对象</param>
public void CopyTo(clsButtonTabEN objButtonTabENS, clsButtonTabEN objButtonTabENT)
{
objButtonTabENT.ButtonId = objButtonTabENS.ButtonId; //按钮Id
objButtonTabENT.ButtonName = objButtonTabENS.ButtonName; //按钮名称
objButtonTabENT.Text = objButtonTabENS.Text; //文本
objButtonTabENT.CommandName = objButtonTabENS.CommandName; //命令名
objButtonTabENT.Height = objButtonTabENS.Height; //高度
objButtonTabENT.Width = objButtonTabENS.Width; //宽
objButtonTabENT.CssClass = objButtonTabENS.CssClass; //样式表
objButtonTabENT.ImageUrl = objButtonTabENS.ImageUrl; //图片资源
objButtonTabENT.InUse = objButtonTabENS.InUse; //是否在用
objButtonTabENT.OrderNum = objButtonTabENS.OrderNum; //序号
objButtonTabENT.UpdUser = objButtonTabENS.UpdUser; //修改者
objButtonTabENT.UpdDate = objButtonTabENS.UpdDate; //修改日期
objButtonTabENT.Memo = objButtonTabENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsButtonTabEN objButtonTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objButtonTabEN.ButtonName, conButtonTab.ButtonName);
clsCheckSql.CheckFieldNotNull(objButtonTabEN.Text, conButtonTab.Text);
clsCheckSql.CheckFieldNotNull(objButtonTabEN.UpdUser, conButtonTab.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objButtonTabEN.ButtonId, 2, conButtonTab.ButtonId);
clsCheckSql.CheckFieldLen(objButtonTabEN.ButtonName, 30, conButtonTab.ButtonName);
clsCheckSql.CheckFieldLen(objButtonTabEN.Text, 30, conButtonTab.Text);
clsCheckSql.CheckFieldLen(objButtonTabEN.CommandName, 30, conButtonTab.CommandName);
clsCheckSql.CheckFieldLen(objButtonTabEN.CssClass, 50, conButtonTab.CssClass);
clsCheckSql.CheckFieldLen(objButtonTabEN.ImageUrl, 100, conButtonTab.ImageUrl);
clsCheckSql.CheckFieldLen(objButtonTabEN.UpdUser, 20, conButtonTab.UpdUser);
clsCheckSql.CheckFieldLen(objButtonTabEN.UpdDate, 20, conButtonTab.UpdDate);
clsCheckSql.CheckFieldLen(objButtonTabEN.Memo, 1000, conButtonTab.Memo);
//检查字段外键固定长度
 objButtonTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsButtonTabEN objButtonTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objButtonTabEN.ButtonName, 30, conButtonTab.ButtonName);
clsCheckSql.CheckFieldLen(objButtonTabEN.Text, 30, conButtonTab.Text);
clsCheckSql.CheckFieldLen(objButtonTabEN.CommandName, 30, conButtonTab.CommandName);
clsCheckSql.CheckFieldLen(objButtonTabEN.CssClass, 50, conButtonTab.CssClass);
clsCheckSql.CheckFieldLen(objButtonTabEN.ImageUrl, 100, conButtonTab.ImageUrl);
clsCheckSql.CheckFieldLen(objButtonTabEN.UpdUser, 20, conButtonTab.UpdUser);
clsCheckSql.CheckFieldLen(objButtonTabEN.UpdDate, 20, conButtonTab.UpdDate);
clsCheckSql.CheckFieldLen(objButtonTabEN.Memo, 1000, conButtonTab.Memo);
//检查外键字段长度
 objButtonTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsButtonTabEN objButtonTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objButtonTabEN.ButtonId, 2, conButtonTab.ButtonId);
clsCheckSql.CheckFieldLen(objButtonTabEN.ButtonName, 30, conButtonTab.ButtonName);
clsCheckSql.CheckFieldLen(objButtonTabEN.Text, 30, conButtonTab.Text);
clsCheckSql.CheckFieldLen(objButtonTabEN.CommandName, 30, conButtonTab.CommandName);
clsCheckSql.CheckFieldLen(objButtonTabEN.CssClass, 50, conButtonTab.CssClass);
clsCheckSql.CheckFieldLen(objButtonTabEN.ImageUrl, 100, conButtonTab.ImageUrl);
clsCheckSql.CheckFieldLen(objButtonTabEN.UpdUser, 20, conButtonTab.UpdUser);
clsCheckSql.CheckFieldLen(objButtonTabEN.UpdDate, 20, conButtonTab.UpdDate);
clsCheckSql.CheckFieldLen(objButtonTabEN.Memo, 1000, conButtonTab.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objButtonTabEN.ButtonId, conButtonTab.ButtonId);
clsCheckSql.CheckSqlInjection4Field(objButtonTabEN.ButtonName, conButtonTab.ButtonName);
clsCheckSql.CheckSqlInjection4Field(objButtonTabEN.Text, conButtonTab.Text);
clsCheckSql.CheckSqlInjection4Field(objButtonTabEN.CommandName, conButtonTab.CommandName);
clsCheckSql.CheckSqlInjection4Field(objButtonTabEN.CssClass, conButtonTab.CssClass);
clsCheckSql.CheckSqlInjection4Field(objButtonTabEN.ImageUrl, conButtonTab.ImageUrl);
clsCheckSql.CheckSqlInjection4Field(objButtonTabEN.UpdUser, conButtonTab.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objButtonTabEN.UpdDate, conButtonTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objButtonTabEN.Memo, conButtonTab.Memo);
//检查外键字段长度
 objButtonTabEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetButtonId()
{
//获取某学院所有专业信息
string strSQL = "select ButtonId, ButtonName from ButtonTab ";
 clsSpecSQLforSql mySql = clsButtonTabDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ButtonTab(按钮),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objButtonTabEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsButtonTabEN objButtonTabEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objButtonTabEN.ButtonName);
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
 objSQL = clsButtonTabDA.GetSpecSQLObj();
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
 objSQL = clsButtonTabDA.GetSpecSQLObj();
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
 objSQL = clsButtonTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsButtonTabEN._CurrTabName);
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
 objSQL = clsButtonTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsButtonTabEN._CurrTabName, strCondition);
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
 objSQL = clsButtonTabDA.GetSpecSQLObj();
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
 objSQL = clsButtonTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}