
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTitleStyleDA
 表名:TitleStyle(00050004)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:02
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
 /// 标题模式(TitleStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTitleStyleDA : clsCommBase4DA
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
 return clsTitleStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTitleStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTitleStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTitleStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTitleStyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTitleStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTitleStyleId)
{
strTitleStyleId = strTitleStyleId.Replace("'", "''");
if (strTitleStyleId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:TitleStyle中,检查关键字,长度不正确!(clsTitleStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTitleStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TitleStyle中,关键字不能为空 或 null!(clsTitleStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTitleStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTitleStyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTitleStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from TitleStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TitleStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTitleStyleDA: GetDataTable_TitleStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from TitleStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTitleStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTitleStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from TitleStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTitleStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTitleStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TitleStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TitleStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTitleStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TitleStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTitleStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TitleStyle.* " + 
$"from TitleStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TitleStyle.TitleStyleId not in " + 
$"(Select top {intTop_In} TitleStyle.TitleStyleId from TitleStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TitleStyle where {1} and TitleStyleId not in (Select top {2} TitleStyleId from TitleStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TitleStyle where {1} and TitleStyleId not in (Select top {3} TitleStyleId from TitleStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTitleStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TitleStyle.* " + 
$"from TitleStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TitleStyle.TitleStyleId not in " + 
$"(Select top {intTop_In} TitleStyle.TitleStyleId from TitleStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TitleStyle where {1} and TitleStyleId not in (Select top {2} TitleStyleId from TitleStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TitleStyle where {1} and TitleStyleId not in (Select top {3} TitleStyleId from TitleStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTitleStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTitleStyleDA:GetObjLst)", objException.Message));
}
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from TitleStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = TransNullToInt(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = TransNullToInt(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = TransNullToBool(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTitleStyleDA: GetObjLst)", objException.Message));
}
objTitleStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTitleStyleEN);
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
public List<clsTitleStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTitleStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = TransNullToInt(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = TransNullToInt(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = TransNullToBool(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTitleStyleDA: GetObjLst)", objException.Message));
}
objTitleStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTitleStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTitleStyle(ref clsTitleStyleEN objTitleStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from TitleStyle where TitleStyleId = " + "'"+ objTitleStyleEN.TitleStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTitleStyleEN.TitleStyleId = objDT.Rows[0][conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id(字段类型:varchar,字段长度:8,是否可空:False)
 objTitleStyleEN.TitleStyleName = objDT.Rows[0][conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objTitleStyleEN.PrjId = objDT.Rows[0][conTitleStyle.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objTitleStyleEN.TabHeight = TransNullToInt(objDT.Rows[0][conTitleStyle.TabHeight].ToString().Trim()); //表格高度(字段类型:int,字段长度:4,是否可空:False)
 objTitleStyleEN.ImgFile = objDT.Rows[0][conTitleStyle.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:200,是否可空:True)
 objTitleStyleEN.BackColor = objDT.Rows[0][conTitleStyle.BackColor].ToString().Trim(); //背景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objTitleStyleEN.TabWidth = TransNullToInt(objDT.Rows[0][conTitleStyle.TabWidth].ToString().Trim()); //表格宽度(字段类型:int,字段长度:4,是否可空:False)
 objTitleStyleEN.ForeColor = objDT.Rows[0][conTitleStyle.ForeColor].ToString().Trim(); //前景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objTitleStyleEN.FontSize = objDT.Rows[0][conTitleStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objTitleStyleEN.FontName = objDT.Rows[0][conTitleStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objTitleStyleEN.IsDefault = TransNullToBool(objDT.Rows[0][conTitleStyle.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objTitleStyleEN.TitleTypeId = objDT.Rows[0][conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID(字段类型:varchar,字段长度:2,是否可空:False)
 objTitleStyleEN.UpdDate = objDT.Rows[0][conTitleStyle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTitleStyleEN.UpdUserId = objDT.Rows[0][conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTitleStyleEN.Memo = objDT.Rows[0][conTitleStyle.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTitleStyleDA: GetTitleStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTitleStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clsTitleStyleEN GetObjByTitleStyleId(string strTitleStyleId)
{
CheckPrimaryKey(strTitleStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from TitleStyle where TitleStyleId = " + "'"+ strTitleStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
 objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id(字段类型:varchar,字段长度:8,是否可空:False)
 objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度(字段类型:int,字段长度:4,是否可空:False)
 objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:200,是否可空:True)
 objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度(字段类型:int,字段长度:4,是否可空:False)
 objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID(字段类型:varchar,字段长度:2,是否可空:False)
 objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTitleStyleDA: GetObjByTitleStyleId)", objException.Message));
}
return objTitleStyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTitleStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTitleStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from TitleStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN()
{
TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(), //标题类型Id
TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(), //标题类型名
PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(), //工程Id
TabHeight = TransNullToInt(objRow[conTitleStyle.TabHeight].ToString().Trim()), //表格高度
ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(), //图像文件
BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(), //背景颜色
TabWidth = TransNullToInt(objRow[conTitleStyle.TabWidth].ToString().Trim()), //表格宽度
ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(), //前景颜色
FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(), //字号
FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(), //字体
IsDefault = TransNullToBool(objRow[conTitleStyle.IsDefault].ToString().Trim()), //是否默认
TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(), //标题类型ID
UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim() //说明
};
objTitleStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTitleStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTitleStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTitleStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = TransNullToInt(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = TransNullToInt(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = TransNullToBool(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTitleStyleDA: GetObjByDataRowTitleStyle)", objException.Message));
}
objTitleStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTitleStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTitleStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = TransNullToInt(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = TransNullToInt(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = TransNullToBool(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTitleStyleDA: GetObjByDataRow)", objException.Message));
}
objTitleStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTitleStyleEN;
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
objSQL = clsTitleStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTitleStyleEN._CurrTabName, conTitleStyle.TitleStyleId, 8, "");
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
objSQL = clsTitleStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTitleStyleEN._CurrTabName, conTitleStyle.TitleStyleId, 8, strPrefix);
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
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TitleStyleId from TitleStyle where " + strCondition;
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
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TitleStyleId from TitleStyle where " + strCondition;
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
 /// <param name = "strTitleStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTitleStyleId)
{
CheckPrimaryKey(strTitleStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TitleStyle", "TitleStyleId = " + "'"+ strTitleStyleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTitleStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TitleStyle", strCondition))
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
objSQL = clsTitleStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TitleStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTitleStyleEN objTitleStyleEN)
 {
 objTitleStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTitleStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTitleStyleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from TitleStyle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TitleStyle");
objRow = objDS.Tables["TitleStyle"].NewRow();
objRow[conTitleStyle.TitleStyleId] = objTitleStyleEN.TitleStyleId; //标题类型Id
objRow[conTitleStyle.TitleStyleName] = objTitleStyleEN.TitleStyleName; //标题类型名
objRow[conTitleStyle.PrjId] = objTitleStyleEN.PrjId; //工程Id
objRow[conTitleStyle.TabHeight] = objTitleStyleEN.TabHeight; //表格高度
objRow[conTitleStyle.ImgFile] = objTitleStyleEN.ImgFile; //图像文件
objRow[conTitleStyle.BackColor] = objTitleStyleEN.BackColor; //背景颜色
objRow[conTitleStyle.TabWidth] = objTitleStyleEN.TabWidth; //表格宽度
objRow[conTitleStyle.ForeColor] = objTitleStyleEN.ForeColor; //前景颜色
 if (objTitleStyleEN.FontSize !=  "")
 {
objRow[conTitleStyle.FontSize] = objTitleStyleEN.FontSize; //字号
 }
 if (objTitleStyleEN.FontName !=  "")
 {
objRow[conTitleStyle.FontName] = objTitleStyleEN.FontName; //字体
 }
objRow[conTitleStyle.IsDefault] = objTitleStyleEN.IsDefault; //是否默认
objRow[conTitleStyle.TitleTypeId] = objTitleStyleEN.TitleTypeId; //标题类型ID
 if (objTitleStyleEN.UpdDate !=  "")
 {
objRow[conTitleStyle.UpdDate] = objTitleStyleEN.UpdDate; //修改日期
 }
 if (objTitleStyleEN.UpdUserId !=  "")
 {
objRow[conTitleStyle.UpdUserId] = objTitleStyleEN.UpdUserId; //修改用户Id
 }
 if (objTitleStyleEN.Memo !=  "")
 {
objRow[conTitleStyle.Memo] = objTitleStyleEN.Memo; //说明
 }
objDS.Tables[clsTitleStyleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTitleStyleEN._CurrTabName);
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTitleStyleEN objTitleStyleEN)
{
 objTitleStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTitleStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTitleStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTitleStyleEN.TitleStyleId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.TitleStyleId);
 var strTitleStyleId = objTitleStyleEN.TitleStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleStyleId + "'");
 }
 
 if (objTitleStyleEN.TitleStyleName !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.TitleStyleName);
 var strTitleStyleName = objTitleStyleEN.TitleStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleStyleName + "'");
 }
 
 if (objTitleStyleEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.PrjId);
 var strPrjId = objTitleStyleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conTitleStyle.TabHeight);
 arrValueListForInsert.Add(objTitleStyleEN.TabHeight.ToString());
 
 if (objTitleStyleEN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.ImgFile);
 var strImgFile = objTitleStyleEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 if (objTitleStyleEN.BackColor !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.BackColor);
 var strBackColor = objTitleStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBackColor + "'");
 }
 
 arrFieldListForInsert.Add(conTitleStyle.TabWidth);
 arrValueListForInsert.Add(objTitleStyleEN.TabWidth.ToString());
 
 if (objTitleStyleEN.ForeColor !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.ForeColor);
 var strForeColor = objTitleStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeColor + "'");
 }
 
 if (objTitleStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.FontSize);
 var strFontSize = objTitleStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objTitleStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.FontName);
 var strFontName = objTitleStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conTitleStyle.IsDefault);
 arrValueListForInsert.Add("'" + (objTitleStyleEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objTitleStyleEN.TitleTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.TitleTypeId);
 var strTitleTypeId = objTitleStyleEN.TitleTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleTypeId + "'");
 }
 
 if (objTitleStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.UpdDate);
 var strUpdDate = objTitleStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTitleStyleEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.UpdUserId);
 var strUpdUserId = objTitleStyleEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTitleStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.Memo);
 var strMemo = objTitleStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TitleStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTitleStyleEN objTitleStyleEN)
{
 objTitleStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTitleStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTitleStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTitleStyleEN.TitleStyleId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.TitleStyleId);
 var strTitleStyleId = objTitleStyleEN.TitleStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleStyleId + "'");
 }
 
 if (objTitleStyleEN.TitleStyleName !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.TitleStyleName);
 var strTitleStyleName = objTitleStyleEN.TitleStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleStyleName + "'");
 }
 
 if (objTitleStyleEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.PrjId);
 var strPrjId = objTitleStyleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conTitleStyle.TabHeight);
 arrValueListForInsert.Add(objTitleStyleEN.TabHeight.ToString());
 
 if (objTitleStyleEN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.ImgFile);
 var strImgFile = objTitleStyleEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 if (objTitleStyleEN.BackColor !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.BackColor);
 var strBackColor = objTitleStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBackColor + "'");
 }
 
 arrFieldListForInsert.Add(conTitleStyle.TabWidth);
 arrValueListForInsert.Add(objTitleStyleEN.TabWidth.ToString());
 
 if (objTitleStyleEN.ForeColor !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.ForeColor);
 var strForeColor = objTitleStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeColor + "'");
 }
 
 if (objTitleStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.FontSize);
 var strFontSize = objTitleStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objTitleStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.FontName);
 var strFontName = objTitleStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conTitleStyle.IsDefault);
 arrValueListForInsert.Add("'" + (objTitleStyleEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objTitleStyleEN.TitleTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.TitleTypeId);
 var strTitleTypeId = objTitleStyleEN.TitleTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleTypeId + "'");
 }
 
 if (objTitleStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.UpdDate);
 var strUpdDate = objTitleStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTitleStyleEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.UpdUserId);
 var strUpdUserId = objTitleStyleEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTitleStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.Memo);
 var strMemo = objTitleStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TitleStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTitleStyleEN.TitleStyleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTitleStyleEN objTitleStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTitleStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTitleStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTitleStyleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTitleStyleEN.TitleStyleId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.TitleStyleId);
 var strTitleStyleId = objTitleStyleEN.TitleStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleStyleId + "'");
 }
 
 if (objTitleStyleEN.TitleStyleName !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.TitleStyleName);
 var strTitleStyleName = objTitleStyleEN.TitleStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleStyleName + "'");
 }
 
 if (objTitleStyleEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.PrjId);
 var strPrjId = objTitleStyleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conTitleStyle.TabHeight);
 arrValueListForInsert.Add(objTitleStyleEN.TabHeight.ToString());
 
 if (objTitleStyleEN.ImgFile !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.ImgFile);
 var strImgFile = objTitleStyleEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImgFile + "'");
 }
 
 if (objTitleStyleEN.BackColor !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.BackColor);
 var strBackColor = objTitleStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBackColor + "'");
 }
 
 arrFieldListForInsert.Add(conTitleStyle.TabWidth);
 arrValueListForInsert.Add(objTitleStyleEN.TabWidth.ToString());
 
 if (objTitleStyleEN.ForeColor !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.ForeColor);
 var strForeColor = objTitleStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeColor + "'");
 }
 
 if (objTitleStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.FontSize);
 var strFontSize = objTitleStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objTitleStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.FontName);
 var strFontName = objTitleStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conTitleStyle.IsDefault);
 arrValueListForInsert.Add("'" + (objTitleStyleEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objTitleStyleEN.TitleTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.TitleTypeId);
 var strTitleTypeId = objTitleStyleEN.TitleTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleTypeId + "'");
 }
 
 if (objTitleStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.UpdDate);
 var strUpdDate = objTitleStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTitleStyleEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.UpdUserId);
 var strUpdUserId = objTitleStyleEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTitleStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTitleStyle.Memo);
 var strMemo = objTitleStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TitleStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTitleStyles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from TitleStyle where TitleStyleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TitleStyle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTitleStyleId = oRow[conTitleStyle.TitleStyleId].ToString().Trim();
if (IsExist(strTitleStyleId))
{
 string strResult = "关键字变量值为:" + string.Format("TitleStyleId = {0}", strTitleStyleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTitleStyleEN._CurrTabName ].NewRow();
objRow[conTitleStyle.TitleStyleId] = oRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objRow[conTitleStyle.TitleStyleName] = oRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objRow[conTitleStyle.PrjId] = oRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objRow[conTitleStyle.TabHeight] = oRow[conTitleStyle.TabHeight].ToString().Trim(); //表格高度
objRow[conTitleStyle.ImgFile] = oRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objRow[conTitleStyle.BackColor] = oRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objRow[conTitleStyle.TabWidth] = oRow[conTitleStyle.TabWidth].ToString().Trim(); //表格宽度
objRow[conTitleStyle.ForeColor] = oRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objRow[conTitleStyle.FontSize] = oRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objRow[conTitleStyle.FontName] = oRow[conTitleStyle.FontName].ToString().Trim(); //字体
objRow[conTitleStyle.IsDefault] = oRow[conTitleStyle.IsDefault].ToString().Trim(); //是否默认
objRow[conTitleStyle.TitleTypeId] = oRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objRow[conTitleStyle.UpdDate] = oRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objRow[conTitleStyle.UpdUserId] = oRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conTitleStyle.Memo] = oRow[conTitleStyle.Memo].ToString().Trim(); //说明
 objDS.Tables[clsTitleStyleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTitleStyleEN._CurrTabName);
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
 /// <param name = "objTitleStyleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTitleStyleEN objTitleStyleEN)
{
 objTitleStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTitleStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTitleStyleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from TitleStyle where TitleStyleId = " + "'"+ objTitleStyleEN.TitleStyleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTitleStyleEN._CurrTabName);
if (objDS.Tables[clsTitleStyleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TitleStyleId = " + "'"+ objTitleStyleEN.TitleStyleId+"'");
return false;
}
objRow = objDS.Tables[clsTitleStyleEN._CurrTabName].Rows[0];
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleStyleId))
 {
objRow[conTitleStyle.TitleStyleId] = objTitleStyleEN.TitleStyleId; //标题类型Id
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleStyleName))
 {
objRow[conTitleStyle.TitleStyleName] = objTitleStyleEN.TitleStyleName; //标题类型名
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.PrjId))
 {
objRow[conTitleStyle.PrjId] = objTitleStyleEN.PrjId; //工程Id
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TabHeight))
 {
objRow[conTitleStyle.TabHeight] = objTitleStyleEN.TabHeight; //表格高度
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.ImgFile))
 {
objRow[conTitleStyle.ImgFile] = objTitleStyleEN.ImgFile; //图像文件
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.BackColor))
 {
objRow[conTitleStyle.BackColor] = objTitleStyleEN.BackColor; //背景颜色
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TabWidth))
 {
objRow[conTitleStyle.TabWidth] = objTitleStyleEN.TabWidth; //表格宽度
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.ForeColor))
 {
objRow[conTitleStyle.ForeColor] = objTitleStyleEN.ForeColor; //前景颜色
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.FontSize))
 {
objRow[conTitleStyle.FontSize] = objTitleStyleEN.FontSize; //字号
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.FontName))
 {
objRow[conTitleStyle.FontName] = objTitleStyleEN.FontName; //字体
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.IsDefault))
 {
objRow[conTitleStyle.IsDefault] = objTitleStyleEN.IsDefault; //是否默认
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleTypeId))
 {
objRow[conTitleStyle.TitleTypeId] = objTitleStyleEN.TitleTypeId; //标题类型ID
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.UpdDate))
 {
objRow[conTitleStyle.UpdDate] = objTitleStyleEN.UpdDate; //修改日期
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.UpdUserId))
 {
objRow[conTitleStyle.UpdUserId] = objTitleStyleEN.UpdUserId; //修改用户Id
 }
 if (objTitleStyleEN.IsUpdated(conTitleStyle.Memo))
 {
objRow[conTitleStyle.Memo] = objTitleStyleEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsTitleStyleEN._CurrTabName);
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTitleStyleEN objTitleStyleEN)
{
 objTitleStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTitleStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTitleStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TitleStyle Set ");
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleStyleName))
 {
 if (objTitleStyleEN.TitleStyleName !=  null)
 {
 var strTitleStyleName = objTitleStyleEN.TitleStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTitleStyleName, conTitleStyle.TitleStyleName); //标题类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.TitleStyleName); //标题类型名
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.PrjId))
 {
 if (objTitleStyleEN.PrjId !=  null)
 {
 var strPrjId = objTitleStyleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conTitleStyle.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.PrjId); //工程Id
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TabHeight))
 {
 sbSQL.AppendFormat("{1} = {0},",objTitleStyleEN.TabHeight, conTitleStyle.TabHeight); //表格高度
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.ImgFile))
 {
 if (objTitleStyleEN.ImgFile !=  null)
 {
 var strImgFile = objTitleStyleEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImgFile, conTitleStyle.ImgFile); //图像文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.ImgFile); //图像文件
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.BackColor))
 {
 if (objTitleStyleEN.BackColor !=  null)
 {
 var strBackColor = objTitleStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBackColor, conTitleStyle.BackColor); //背景颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.BackColor); //背景颜色
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TabWidth))
 {
 sbSQL.AppendFormat("{1} = {0},",objTitleStyleEN.TabWidth, conTitleStyle.TabWidth); //表格宽度
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.ForeColor))
 {
 if (objTitleStyleEN.ForeColor !=  null)
 {
 var strForeColor = objTitleStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeColor, conTitleStyle.ForeColor); //前景颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.ForeColor); //前景颜色
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.FontSize))
 {
 if (objTitleStyleEN.FontSize !=  null)
 {
 var strFontSize = objTitleStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conTitleStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.FontSize); //字号
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.FontName))
 {
 if (objTitleStyleEN.FontName !=  null)
 {
 var strFontName = objTitleStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conTitleStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.FontName); //字体
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTitleStyleEN.IsDefault == true?"1":"0", conTitleStyle.IsDefault); //是否默认
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleTypeId))
 {
 if (objTitleStyleEN.TitleTypeId !=  null)
 {
 var strTitleTypeId = objTitleStyleEN.TitleTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTitleTypeId, conTitleStyle.TitleTypeId); //标题类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.TitleTypeId); //标题类型ID
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.UpdDate))
 {
 if (objTitleStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objTitleStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTitleStyle.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.UpdDate); //修改日期
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.UpdUserId))
 {
 if (objTitleStyleEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTitleStyleEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTitleStyle.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.UpdUserId); //修改用户Id
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.Memo))
 {
 if (objTitleStyleEN.Memo !=  null)
 {
 var strMemo = objTitleStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTitleStyle.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TitleStyleId = '{0}'", objTitleStyleEN.TitleStyleId); 
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
 /// <param name = "objTitleStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTitleStyleEN objTitleStyleEN, string strCondition)
{
 objTitleStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTitleStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTitleStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TitleStyle Set ");
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleStyleName))
 {
 if (objTitleStyleEN.TitleStyleName !=  null)
 {
 var strTitleStyleName = objTitleStyleEN.TitleStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TitleStyleName = '{0}',", strTitleStyleName); //标题类型名
 }
 else
 {
 sbSQL.Append(" TitleStyleName = null,"); //标题类型名
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.PrjId))
 {
 if (objTitleStyleEN.PrjId !=  null)
 {
 var strPrjId = objTitleStyleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TabHeight))
 {
 sbSQL.AppendFormat(" TabHeight = {0},", objTitleStyleEN.TabHeight); //表格高度
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.ImgFile))
 {
 if (objTitleStyleEN.ImgFile !=  null)
 {
 var strImgFile = objTitleStyleEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImgFile = '{0}',", strImgFile); //图像文件
 }
 else
 {
 sbSQL.Append(" ImgFile = null,"); //图像文件
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.BackColor))
 {
 if (objTitleStyleEN.BackColor !=  null)
 {
 var strBackColor = objTitleStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BackColor = '{0}',", strBackColor); //背景颜色
 }
 else
 {
 sbSQL.Append(" BackColor = null,"); //背景颜色
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TabWidth))
 {
 sbSQL.AppendFormat(" TabWidth = {0},", objTitleStyleEN.TabWidth); //表格宽度
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.ForeColor))
 {
 if (objTitleStyleEN.ForeColor !=  null)
 {
 var strForeColor = objTitleStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeColor = '{0}',", strForeColor); //前景颜色
 }
 else
 {
 sbSQL.Append(" ForeColor = null,"); //前景颜色
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.FontSize))
 {
 if (objTitleStyleEN.FontSize !=  null)
 {
 var strFontSize = objTitleStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.FontName))
 {
 if (objTitleStyleEN.FontName !=  null)
 {
 var strFontName = objTitleStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objTitleStyleEN.IsDefault == true?"1":"0"); //是否默认
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleTypeId))
 {
 if (objTitleStyleEN.TitleTypeId !=  null)
 {
 var strTitleTypeId = objTitleStyleEN.TitleTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TitleTypeId = '{0}',", strTitleTypeId); //标题类型ID
 }
 else
 {
 sbSQL.Append(" TitleTypeId = null,"); //标题类型ID
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.UpdDate))
 {
 if (objTitleStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objTitleStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.UpdUserId))
 {
 if (objTitleStyleEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTitleStyleEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.Memo))
 {
 if (objTitleStyleEN.Memo !=  null)
 {
 var strMemo = objTitleStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTitleStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTitleStyleEN objTitleStyleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTitleStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTitleStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTitleStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TitleStyle Set ");
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleStyleName))
 {
 if (objTitleStyleEN.TitleStyleName !=  null)
 {
 var strTitleStyleName = objTitleStyleEN.TitleStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TitleStyleName = '{0}',", strTitleStyleName); //标题类型名
 }
 else
 {
 sbSQL.Append(" TitleStyleName = null,"); //标题类型名
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.PrjId))
 {
 if (objTitleStyleEN.PrjId !=  null)
 {
 var strPrjId = objTitleStyleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TabHeight))
 {
 sbSQL.AppendFormat(" TabHeight = {0},", objTitleStyleEN.TabHeight); //表格高度
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.ImgFile))
 {
 if (objTitleStyleEN.ImgFile !=  null)
 {
 var strImgFile = objTitleStyleEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImgFile = '{0}',", strImgFile); //图像文件
 }
 else
 {
 sbSQL.Append(" ImgFile = null,"); //图像文件
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.BackColor))
 {
 if (objTitleStyleEN.BackColor !=  null)
 {
 var strBackColor = objTitleStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BackColor = '{0}',", strBackColor); //背景颜色
 }
 else
 {
 sbSQL.Append(" BackColor = null,"); //背景颜色
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TabWidth))
 {
 sbSQL.AppendFormat(" TabWidth = {0},", objTitleStyleEN.TabWidth); //表格宽度
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.ForeColor))
 {
 if (objTitleStyleEN.ForeColor !=  null)
 {
 var strForeColor = objTitleStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeColor = '{0}',", strForeColor); //前景颜色
 }
 else
 {
 sbSQL.Append(" ForeColor = null,"); //前景颜色
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.FontSize))
 {
 if (objTitleStyleEN.FontSize !=  null)
 {
 var strFontSize = objTitleStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.FontName))
 {
 if (objTitleStyleEN.FontName !=  null)
 {
 var strFontName = objTitleStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objTitleStyleEN.IsDefault == true?"1":"0"); //是否默认
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleTypeId))
 {
 if (objTitleStyleEN.TitleTypeId !=  null)
 {
 var strTitleTypeId = objTitleStyleEN.TitleTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TitleTypeId = '{0}',", strTitleTypeId); //标题类型ID
 }
 else
 {
 sbSQL.Append(" TitleTypeId = null,"); //标题类型ID
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.UpdDate))
 {
 if (objTitleStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objTitleStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.UpdUserId))
 {
 if (objTitleStyleEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTitleStyleEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.Memo))
 {
 if (objTitleStyleEN.Memo !=  null)
 {
 var strMemo = objTitleStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTitleStyleEN objTitleStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTitleStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTitleStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTitleStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TitleStyle Set ");
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleStyleName))
 {
 if (objTitleStyleEN.TitleStyleName !=  null)
 {
 var strTitleStyleName = objTitleStyleEN.TitleStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTitleStyleName, conTitleStyle.TitleStyleName); //标题类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.TitleStyleName); //标题类型名
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.PrjId))
 {
 if (objTitleStyleEN.PrjId !=  null)
 {
 var strPrjId = objTitleStyleEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conTitleStyle.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.PrjId); //工程Id
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TabHeight))
 {
 sbSQL.AppendFormat("{1} = {0},",objTitleStyleEN.TabHeight, conTitleStyle.TabHeight); //表格高度
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.ImgFile))
 {
 if (objTitleStyleEN.ImgFile !=  null)
 {
 var strImgFile = objTitleStyleEN.ImgFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImgFile, conTitleStyle.ImgFile); //图像文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.ImgFile); //图像文件
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.BackColor))
 {
 if (objTitleStyleEN.BackColor !=  null)
 {
 var strBackColor = objTitleStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBackColor, conTitleStyle.BackColor); //背景颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.BackColor); //背景颜色
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TabWidth))
 {
 sbSQL.AppendFormat("{1} = {0},",objTitleStyleEN.TabWidth, conTitleStyle.TabWidth); //表格宽度
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.ForeColor))
 {
 if (objTitleStyleEN.ForeColor !=  null)
 {
 var strForeColor = objTitleStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeColor, conTitleStyle.ForeColor); //前景颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.ForeColor); //前景颜色
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.FontSize))
 {
 if (objTitleStyleEN.FontSize !=  null)
 {
 var strFontSize = objTitleStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conTitleStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.FontSize); //字号
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.FontName))
 {
 if (objTitleStyleEN.FontName !=  null)
 {
 var strFontName = objTitleStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conTitleStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.FontName); //字体
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTitleStyleEN.IsDefault == true?"1":"0", conTitleStyle.IsDefault); //是否默认
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.TitleTypeId))
 {
 if (objTitleStyleEN.TitleTypeId !=  null)
 {
 var strTitleTypeId = objTitleStyleEN.TitleTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTitleTypeId, conTitleStyle.TitleTypeId); //标题类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.TitleTypeId); //标题类型ID
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.UpdDate))
 {
 if (objTitleStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objTitleStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTitleStyle.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.UpdDate); //修改日期
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.UpdUserId))
 {
 if (objTitleStyleEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTitleStyleEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTitleStyle.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.UpdUserId); //修改用户Id
 }
 }
 
 if (objTitleStyleEN.IsUpdated(conTitleStyle.Memo))
 {
 if (objTitleStyleEN.Memo !=  null)
 {
 var strMemo = objTitleStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTitleStyle.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTitleStyle.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TitleStyleId = '{0}'", objTitleStyleEN.TitleStyleId); 
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
 /// <param name = "strTitleStyleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTitleStyleId) 
{
CheckPrimaryKey(strTitleStyleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTitleStyleId,
};
 objSQL.ExecSP("TitleStyle_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTitleStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTitleStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTitleStyleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
//删除TitleStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TitleStyle where TitleStyleId = " + "'"+ strTitleStyleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTitleStyle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
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
//删除TitleStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TitleStyle where TitleStyleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTitleStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTitleStyleId) 
{
CheckPrimaryKey(strTitleStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
//删除TitleStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TitleStyle where TitleStyleId = " + "'"+ strTitleStyleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTitleStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTitleStyleDA: DelTitleStyle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TitleStyle where " + strCondition ;
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
public bool DelTitleStyleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTitleStyleDA: DelTitleStyleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TitleStyle where " + strCondition ;
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
 /// <param name = "objTitleStyleENS">源对象</param>
 /// <param name = "objTitleStyleENT">目标对象</param>
public void CopyTo(clsTitleStyleEN objTitleStyleENS, clsTitleStyleEN objTitleStyleENT)
{
objTitleStyleENT.TitleStyleId = objTitleStyleENS.TitleStyleId; //标题类型Id
objTitleStyleENT.TitleStyleName = objTitleStyleENS.TitleStyleName; //标题类型名
objTitleStyleENT.PrjId = objTitleStyleENS.PrjId; //工程Id
objTitleStyleENT.TabHeight = objTitleStyleENS.TabHeight; //表格高度
objTitleStyleENT.ImgFile = objTitleStyleENS.ImgFile; //图像文件
objTitleStyleENT.BackColor = objTitleStyleENS.BackColor; //背景颜色
objTitleStyleENT.TabWidth = objTitleStyleENS.TabWidth; //表格宽度
objTitleStyleENT.ForeColor = objTitleStyleENS.ForeColor; //前景颜色
objTitleStyleENT.FontSize = objTitleStyleENS.FontSize; //字号
objTitleStyleENT.FontName = objTitleStyleENS.FontName; //字体
objTitleStyleENT.IsDefault = objTitleStyleENS.IsDefault; //是否默认
objTitleStyleENT.TitleTypeId = objTitleStyleENS.TitleTypeId; //标题类型ID
objTitleStyleENT.UpdDate = objTitleStyleENS.UpdDate; //修改日期
objTitleStyleENT.UpdUserId = objTitleStyleENS.UpdUserId; //修改用户Id
objTitleStyleENT.Memo = objTitleStyleENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTitleStyleEN objTitleStyleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTitleStyleEN.TitleStyleName, conTitleStyle.TitleStyleName);
clsCheckSql.CheckFieldNotNull(objTitleStyleEN.PrjId, conTitleStyle.PrjId);
clsCheckSql.CheckFieldNotNull(objTitleStyleEN.TabHeight, conTitleStyle.TabHeight);
clsCheckSql.CheckFieldNotNull(objTitleStyleEN.ImgFile, conTitleStyle.ImgFile);
clsCheckSql.CheckFieldNotNull(objTitleStyleEN.BackColor, conTitleStyle.BackColor);
clsCheckSql.CheckFieldNotNull(objTitleStyleEN.TabWidth, conTitleStyle.TabWidth);
clsCheckSql.CheckFieldNotNull(objTitleStyleEN.ForeColor, conTitleStyle.ForeColor);
clsCheckSql.CheckFieldNotNull(objTitleStyleEN.TitleTypeId, conTitleStyle.TitleTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objTitleStyleEN.TitleStyleId, 8, conTitleStyle.TitleStyleId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.TitleStyleName, 20, conTitleStyle.TitleStyleName);
clsCheckSql.CheckFieldLen(objTitleStyleEN.PrjId, 4, conTitleStyle.PrjId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.ImgFile, 200, conTitleStyle.ImgFile);
clsCheckSql.CheckFieldLen(objTitleStyleEN.BackColor, 30, conTitleStyle.BackColor);
clsCheckSql.CheckFieldLen(objTitleStyleEN.ForeColor, 30, conTitleStyle.ForeColor);
clsCheckSql.CheckFieldLen(objTitleStyleEN.FontSize, 20, conTitleStyle.FontSize);
clsCheckSql.CheckFieldLen(objTitleStyleEN.FontName, 20, conTitleStyle.FontName);
clsCheckSql.CheckFieldLen(objTitleStyleEN.TitleTypeId, 2, conTitleStyle.TitleTypeId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.UpdDate, 20, conTitleStyle.UpdDate);
clsCheckSql.CheckFieldLen(objTitleStyleEN.UpdUserId, 20, conTitleStyle.UpdUserId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.Memo, 1000, conTitleStyle.Memo);
//检查字段外键固定长度
 objTitleStyleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTitleStyleEN objTitleStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTitleStyleEN.TitleStyleName, 20, conTitleStyle.TitleStyleName);
clsCheckSql.CheckFieldLen(objTitleStyleEN.PrjId, 4, conTitleStyle.PrjId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.ImgFile, 200, conTitleStyle.ImgFile);
clsCheckSql.CheckFieldLen(objTitleStyleEN.BackColor, 30, conTitleStyle.BackColor);
clsCheckSql.CheckFieldLen(objTitleStyleEN.ForeColor, 30, conTitleStyle.ForeColor);
clsCheckSql.CheckFieldLen(objTitleStyleEN.FontSize, 20, conTitleStyle.FontSize);
clsCheckSql.CheckFieldLen(objTitleStyleEN.FontName, 20, conTitleStyle.FontName);
clsCheckSql.CheckFieldLen(objTitleStyleEN.TitleTypeId, 2, conTitleStyle.TitleTypeId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.UpdDate, 20, conTitleStyle.UpdDate);
clsCheckSql.CheckFieldLen(objTitleStyleEN.UpdUserId, 20, conTitleStyle.UpdUserId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.Memo, 1000, conTitleStyle.Memo);
//检查外键字段长度
 objTitleStyleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTitleStyleEN objTitleStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTitleStyleEN.TitleStyleId, 8, conTitleStyle.TitleStyleId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.TitleStyleName, 20, conTitleStyle.TitleStyleName);
clsCheckSql.CheckFieldLen(objTitleStyleEN.PrjId, 4, conTitleStyle.PrjId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.ImgFile, 200, conTitleStyle.ImgFile);
clsCheckSql.CheckFieldLen(objTitleStyleEN.BackColor, 30, conTitleStyle.BackColor);
clsCheckSql.CheckFieldLen(objTitleStyleEN.ForeColor, 30, conTitleStyle.ForeColor);
clsCheckSql.CheckFieldLen(objTitleStyleEN.FontSize, 20, conTitleStyle.FontSize);
clsCheckSql.CheckFieldLen(objTitleStyleEN.FontName, 20, conTitleStyle.FontName);
clsCheckSql.CheckFieldLen(objTitleStyleEN.TitleTypeId, 2, conTitleStyle.TitleTypeId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.UpdDate, 20, conTitleStyle.UpdDate);
clsCheckSql.CheckFieldLen(objTitleStyleEN.UpdUserId, 20, conTitleStyle.UpdUserId);
clsCheckSql.CheckFieldLen(objTitleStyleEN.Memo, 1000, conTitleStyle.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.TitleStyleId, conTitleStyle.TitleStyleId);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.TitleStyleName, conTitleStyle.TitleStyleName);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.PrjId, conTitleStyle.PrjId);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.ImgFile, conTitleStyle.ImgFile);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.BackColor, conTitleStyle.BackColor);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.ForeColor, conTitleStyle.ForeColor);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.FontSize, conTitleStyle.FontSize);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.FontName, conTitleStyle.FontName);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.TitleTypeId, conTitleStyle.TitleTypeId);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.UpdDate, conTitleStyle.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.UpdUserId, conTitleStyle.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objTitleStyleEN.Memo, conTitleStyle.Memo);
//检查外键字段长度
 objTitleStyleEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTitleStyleId()
{
//获取某学院所有专业信息
string strSQL = "select TitleStyleId, TitleStyleName from TitleStyle ";
 clsSpecSQLforSql mySql = clsTitleStyleDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TitleStyle(标题模式),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTitleStyleEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTitleStyleEN objTitleStyleEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TitleStyleName = '{0}'", objTitleStyleEN.TitleStyleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTitleStyleEN.PrjId);
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
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
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
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
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
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTitleStyleEN._CurrTabName);
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
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTitleStyleEN._CurrTabName, strCondition);
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
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
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
 objSQL = clsTitleStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}