
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_FldDispUnitStyleDA
 表名:css_FldDispUnitStyle(00050615)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
 /// 字段显示单元样式(css_FldDispUnitStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscss_FldDispUnitStyleDA : clsCommBase4DA
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
 return clscss_FldDispUnitStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscss_FldDispUnitStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscss_FldDispUnitStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscss_FldDispUnitStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscss_FldDispUnitStyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFldDispUnitStyleId)
{
strFldDispUnitStyleId = strFldDispUnitStyleId.Replace("'", "''");
if (strFldDispUnitStyleId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:css_FldDispUnitStyle中,检查关键字,长度不正确!(clscss_FldDispUnitStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFldDispUnitStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:css_FldDispUnitStyle中,关键字不能为空 或 null!(clscss_FldDispUnitStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldDispUnitStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscss_FldDispUnitStyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_FldDispUnitStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_css_FldDispUnitStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: GetDataTable_css_FldDispUnitStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_FldDispUnitStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_FldDispUnitStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_FldDispUnitStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_FldDispUnitStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from css_FldDispUnitStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} css_FldDispUnitStyle.* " + 
$"from css_FldDispUnitStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and css_FldDispUnitStyle.FldDispUnitStyleId not in " + 
$"(Select top {intTop_In} css_FldDispUnitStyle.FldDispUnitStyleId from css_FldDispUnitStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_FldDispUnitStyle where {1} and FldDispUnitStyleId not in (Select top {2} FldDispUnitStyleId from css_FldDispUnitStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_FldDispUnitStyle where {1} and FldDispUnitStyleId not in (Select top {3} FldDispUnitStyleId from css_FldDispUnitStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} css_FldDispUnitStyle.* " + 
$"from css_FldDispUnitStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and css_FldDispUnitStyle.FldDispUnitStyleId not in " + 
$"(Select top {intTop_In} css_FldDispUnitStyle.FldDispUnitStyleId from css_FldDispUnitStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_FldDispUnitStyle where {1} and FldDispUnitStyleId not in (Select top {2} FldDispUnitStyleId from css_FldDispUnitStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_FldDispUnitStyle where {1} and FldDispUnitStyleId not in (Select top {3} FldDispUnitStyleId from css_FldDispUnitStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscss_FldDispUnitStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA:GetObjLst)", objException.Message));
}
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_FldDispUnitStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = TransNullToBool(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscss_FldDispUnitStyleDA: GetObjLst)", objException.Message));
}
objcss_FldDispUnitStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
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
public List<clscss_FldDispUnitStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = TransNullToBool(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscss_FldDispUnitStyleDA: GetObjLst)", objException.Message));
}
objcss_FldDispUnitStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcss_FldDispUnitStyle(ref clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_FldDispUnitStyle where FldDispUnitStyleId = " + "'"+ objcss_FldDispUnitStyleEN.FldDispUnitStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objDT.Rows[0][concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id(字段类型:char,字段长度:8,是否可空:False)
 objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objDT.Rows[0][concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objDT.Rows[0][concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述(字段类型:varchar,字段长度:1000,是否可空:True)
 objcss_FldDispUnitStyleEN.StyleIdContent = objDT.Rows[0][concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id(字段类型:char,字段长度:8,是否可空:False)
 objcss_FldDispUnitStyleEN.StyleIdTitle = objDT.Rows[0][concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id(字段类型:char,字段长度:8,是否可空:False)
 objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objDT.Rows[0][concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objcss_FldDispUnitStyleEN.FldDispUnitFormat = objDT.Rows[0][concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式(字段类型:varchar,字段长度:1000,是否可空:True)
 objcss_FldDispUnitStyleEN.CtlTypeId = objDT.Rows[0][concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objcss_FldDispUnitStyleEN.OrderNum = TransNullToInt(objDT.Rows[0][concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objcss_FldDispUnitStyleEN.DeletedDate = objDT.Rows[0][concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_FldDispUnitStyleEN.IsDeleted = TransNullToBool(objDT.Rows[0][concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objcss_FldDispUnitStyleEN.UpdDate = objDT.Rows[0][concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_FldDispUnitStyleEN.UpdUser = objDT.Rows[0][concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_FldDispUnitStyleEN.Memo = objDT.Rows[0][concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscss_FldDispUnitStyleDA: Getcss_FldDispUnitStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clscss_FldDispUnitStyleEN GetObjByFldDispUnitStyleId(string strFldDispUnitStyleId)
{
CheckPrimaryKey(strFldDispUnitStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_FldDispUnitStyle where FldDispUnitStyleId = " + "'"+ strFldDispUnitStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
 objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id(字段类型:char,字段长度:8,是否可空:False)
 objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述(字段类型:varchar,字段长度:1000,是否可空:True)
 objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id(字段类型:char,字段长度:8,是否可空:False)
 objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id(字段类型:char,字段长度:8,是否可空:False)
 objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式(字段类型:varchar,字段长度:1000,是否可空:True)
 objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscss_FldDispUnitStyleDA: GetObjByFldDispUnitStyleId)", objException.Message));
}
return objcss_FldDispUnitStyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscss_FldDispUnitStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_FldDispUnitStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN()
{
FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(), //字段显示单元样式Id
FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(), //字段显示单元样式名称
FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(), //样式描述
StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(), //内容样式Id
StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(), //标题样式Id
FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(), //样式内容
FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(), //字段显示单元格式
CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(), //控件类型号
OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()), //序号
DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(), //删除日期
IsDeleted = TransNullToBool(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()), //是否删除
UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(), //修改者
Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim() //说明
};
objcss_FldDispUnitStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_FldDispUnitStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscss_FldDispUnitStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscss_FldDispUnitStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = TransNullToBool(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscss_FldDispUnitStyleDA: GetObjByDataRowcss_FldDispUnitStyle)", objException.Message));
}
objcss_FldDispUnitStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_FldDispUnitStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscss_FldDispUnitStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = TransNullToBool(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscss_FldDispUnitStyleDA: GetObjByDataRow)", objException.Message));
}
objcss_FldDispUnitStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_FldDispUnitStyleEN;
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
objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscss_FldDispUnitStyleEN._CurrTabName, concss_FldDispUnitStyle.FldDispUnitStyleId, 8, "");
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
objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscss_FldDispUnitStyleEN._CurrTabName, concss_FldDispUnitStyle.FldDispUnitStyleId, 8, strPrefix);
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
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FldDispUnitStyleId from css_FldDispUnitStyle where " + strCondition;
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
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FldDispUnitStyleId from css_FldDispUnitStyle where " + strCondition;
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
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFldDispUnitStyleId)
{
CheckPrimaryKey(strFldDispUnitStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("css_FldDispUnitStyle", "FldDispUnitStyleId = " + "'"+ strFldDispUnitStyleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("css_FldDispUnitStyle", strCondition))
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
objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("css_FldDispUnitStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
 {
 objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_FldDispUnitStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_FldDispUnitStyleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_FldDispUnitStyle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "css_FldDispUnitStyle");
objRow = objDS.Tables["css_FldDispUnitStyle"].NewRow();
objRow[concss_FldDispUnitStyle.FldDispUnitStyleId] = objcss_FldDispUnitStyleEN.FldDispUnitStyleId; //字段显示单元样式Id
objRow[concss_FldDispUnitStyle.FldDispUnitStyleName] = objcss_FldDispUnitStyleEN.FldDispUnitStyleName; //字段显示单元样式名称
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc !=  "")
 {
objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc; //样式描述
 }
 if (objcss_FldDispUnitStyleEN.StyleIdContent !=  "")
 {
objRow[concss_FldDispUnitStyle.StyleIdContent] = objcss_FldDispUnitStyleEN.StyleIdContent; //内容样式Id
 }
 if (objcss_FldDispUnitStyleEN.StyleIdTitle !=  "")
 {
objRow[concss_FldDispUnitStyle.StyleIdTitle] = objcss_FldDispUnitStyleEN.StyleIdTitle; //标题样式Id
 }
objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent] = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent; //样式内容
 if (objcss_FldDispUnitStyleEN.FldDispUnitFormat !=  "")
 {
objRow[concss_FldDispUnitStyle.FldDispUnitFormat] = objcss_FldDispUnitStyleEN.FldDispUnitFormat; //字段显示单元格式
 }
objRow[concss_FldDispUnitStyle.CtlTypeId] = objcss_FldDispUnitStyleEN.CtlTypeId; //控件类型号
objRow[concss_FldDispUnitStyle.OrderNum] = objcss_FldDispUnitStyleEN.OrderNum; //序号
 if (objcss_FldDispUnitStyleEN.DeletedDate !=  "")
 {
objRow[concss_FldDispUnitStyle.DeletedDate] = objcss_FldDispUnitStyleEN.DeletedDate; //删除日期
 }
objRow[concss_FldDispUnitStyle.IsDeleted] = objcss_FldDispUnitStyleEN.IsDeleted; //是否删除
 if (objcss_FldDispUnitStyleEN.UpdDate !=  "")
 {
objRow[concss_FldDispUnitStyle.UpdDate] = objcss_FldDispUnitStyleEN.UpdDate; //修改日期
 }
 if (objcss_FldDispUnitStyleEN.UpdUser !=  "")
 {
objRow[concss_FldDispUnitStyle.UpdUser] = objcss_FldDispUnitStyleEN.UpdUser; //修改者
 }
 if (objcss_FldDispUnitStyleEN.Memo !=  "")
 {
objRow[concss_FldDispUnitStyle.Memo] = objcss_FldDispUnitStyleEN.Memo; //说明
 }
objDS.Tables[clscss_FldDispUnitStyleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscss_FldDispUnitStyleEN._CurrTabName);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_FldDispUnitStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_FldDispUnitStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleId !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleId);
 var strFldDispUnitStyleId = objcss_FldDispUnitStyleEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleId + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleName !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleName);
 var strFldDispUnitStyleName = objcss_FldDispUnitStyleEN.FldDispUnitStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleName + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleDesc);
 var strFldDispUnitStyleDesc = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleDesc + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.StyleIdContent  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdContent = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdContent !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.StyleIdContent);
 var strStyleIdContent = objcss_FldDispUnitStyleEN.StyleIdContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleIdContent + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.StyleIdTitle  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdTitle = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdTitle !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.StyleIdTitle);
 var strStyleIdTitle = objcss_FldDispUnitStyleEN.StyleIdTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleIdTitle + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleContent !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleContent);
 var strFldDispUnitStyleContent = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleContent + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitFormat !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitFormat);
 var strFldDispUnitFormat = objcss_FldDispUnitStyleEN.FldDispUnitFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitFormat + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.CtlTypeId  ==  "")
 {
 objcss_FldDispUnitStyleEN.CtlTypeId = null;
 }
 if (objcss_FldDispUnitStyleEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.CtlTypeId);
 var strCtlTypeId = objcss_FldDispUnitStyleEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.OrderNum);
 arrValueListForInsert.Add(objcss_FldDispUnitStyleEN.OrderNum.ToString());
 }
 
 if (objcss_FldDispUnitStyleEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.DeletedDate);
 var strDeletedDate = objcss_FldDispUnitStyleEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_FldDispUnitStyleEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_FldDispUnitStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.UpdDate);
 var strUpdDate = objcss_FldDispUnitStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.UpdUser);
 var strUpdUser = objcss_FldDispUnitStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.Memo);
 var strMemo = objcss_FldDispUnitStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_FldDispUnitStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_FldDispUnitStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_FldDispUnitStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleId !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleId);
 var strFldDispUnitStyleId = objcss_FldDispUnitStyleEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleId + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleName !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleName);
 var strFldDispUnitStyleName = objcss_FldDispUnitStyleEN.FldDispUnitStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleName + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleDesc);
 var strFldDispUnitStyleDesc = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleDesc + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.StyleIdContent  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdContent = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdContent !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.StyleIdContent);
 var strStyleIdContent = objcss_FldDispUnitStyleEN.StyleIdContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleIdContent + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.StyleIdTitle  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdTitle = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdTitle !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.StyleIdTitle);
 var strStyleIdTitle = objcss_FldDispUnitStyleEN.StyleIdTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleIdTitle + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleContent !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleContent);
 var strFldDispUnitStyleContent = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleContent + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitFormat !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitFormat);
 var strFldDispUnitFormat = objcss_FldDispUnitStyleEN.FldDispUnitFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitFormat + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.CtlTypeId  ==  "")
 {
 objcss_FldDispUnitStyleEN.CtlTypeId = null;
 }
 if (objcss_FldDispUnitStyleEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.CtlTypeId);
 var strCtlTypeId = objcss_FldDispUnitStyleEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.OrderNum);
 arrValueListForInsert.Add(objcss_FldDispUnitStyleEN.OrderNum.ToString());
 }
 
 if (objcss_FldDispUnitStyleEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.DeletedDate);
 var strDeletedDate = objcss_FldDispUnitStyleEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_FldDispUnitStyleEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_FldDispUnitStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.UpdDate);
 var strUpdDate = objcss_FldDispUnitStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.UpdUser);
 var strUpdUser = objcss_FldDispUnitStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.Memo);
 var strMemo = objcss_FldDispUnitStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_FldDispUnitStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcss_FldDispUnitStyleEN.FldDispUnitStyleId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_FldDispUnitStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_FldDispUnitStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleId !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleId);
 var strFldDispUnitStyleId = objcss_FldDispUnitStyleEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleId + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleName !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleName);
 var strFldDispUnitStyleName = objcss_FldDispUnitStyleEN.FldDispUnitStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleName + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleDesc);
 var strFldDispUnitStyleDesc = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleDesc + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.StyleIdContent  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdContent = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdContent !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.StyleIdContent);
 var strStyleIdContent = objcss_FldDispUnitStyleEN.StyleIdContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleIdContent + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.StyleIdTitle  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdTitle = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdTitle !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.StyleIdTitle);
 var strStyleIdTitle = objcss_FldDispUnitStyleEN.StyleIdTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleIdTitle + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleContent !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleContent);
 var strFldDispUnitStyleContent = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleContent + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitFormat !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitFormat);
 var strFldDispUnitFormat = objcss_FldDispUnitStyleEN.FldDispUnitFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitFormat + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.CtlTypeId  ==  "")
 {
 objcss_FldDispUnitStyleEN.CtlTypeId = null;
 }
 if (objcss_FldDispUnitStyleEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.CtlTypeId);
 var strCtlTypeId = objcss_FldDispUnitStyleEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.OrderNum);
 arrValueListForInsert.Add(objcss_FldDispUnitStyleEN.OrderNum.ToString());
 }
 
 if (objcss_FldDispUnitStyleEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.DeletedDate);
 var strDeletedDate = objcss_FldDispUnitStyleEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_FldDispUnitStyleEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_FldDispUnitStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.UpdDate);
 var strUpdDate = objcss_FldDispUnitStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.UpdUser);
 var strUpdUser = objcss_FldDispUnitStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.Memo);
 var strMemo = objcss_FldDispUnitStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_FldDispUnitStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcss_FldDispUnitStyleEN.FldDispUnitStyleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_FldDispUnitStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_FldDispUnitStyleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleId !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleId);
 var strFldDispUnitStyleId = objcss_FldDispUnitStyleEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleId + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleName !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleName);
 var strFldDispUnitStyleName = objcss_FldDispUnitStyleEN.FldDispUnitStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleName + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleDesc);
 var strFldDispUnitStyleDesc = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleDesc + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.StyleIdContent  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdContent = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdContent !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.StyleIdContent);
 var strStyleIdContent = objcss_FldDispUnitStyleEN.StyleIdContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleIdContent + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.StyleIdTitle  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdTitle = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdTitle !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.StyleIdTitle);
 var strStyleIdTitle = objcss_FldDispUnitStyleEN.StyleIdTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleIdTitle + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleContent !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitStyleContent);
 var strFldDispUnitStyleContent = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleContent + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.FldDispUnitFormat !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.FldDispUnitFormat);
 var strFldDispUnitFormat = objcss_FldDispUnitStyleEN.FldDispUnitFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitFormat + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.CtlTypeId  ==  "")
 {
 objcss_FldDispUnitStyleEN.CtlTypeId = null;
 }
 if (objcss_FldDispUnitStyleEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.CtlTypeId);
 var strCtlTypeId = objcss_FldDispUnitStyleEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.OrderNum);
 arrValueListForInsert.Add(objcss_FldDispUnitStyleEN.OrderNum.ToString());
 }
 
 if (objcss_FldDispUnitStyleEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.DeletedDate);
 var strDeletedDate = objcss_FldDispUnitStyleEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_FldDispUnitStyleEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_FldDispUnitStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.UpdDate);
 var strUpdDate = objcss_FldDispUnitStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.UpdUser);
 var strUpdUser = objcss_FldDispUnitStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_FldDispUnitStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_FldDispUnitStyle.Memo);
 var strMemo = objcss_FldDispUnitStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_FldDispUnitStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcss_FldDispUnitStyles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_FldDispUnitStyle where FldDispUnitStyleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "css_FldDispUnitStyle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFldDispUnitStyleId = oRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim();
if (IsExist(strFldDispUnitStyleId))
{
 string strResult = "关键字变量值为:" + string.Format("FldDispUnitStyleId = {0}", strFldDispUnitStyleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscss_FldDispUnitStyleEN._CurrTabName ].NewRow();
objRow[concss_FldDispUnitStyle.FldDispUnitStyleId] = oRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objRow[concss_FldDispUnitStyle.FldDispUnitStyleName] = oRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] = oRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objRow[concss_FldDispUnitStyle.StyleIdContent] = oRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objRow[concss_FldDispUnitStyle.StyleIdTitle] = oRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent] = oRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objRow[concss_FldDispUnitStyle.FldDispUnitFormat] = oRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objRow[concss_FldDispUnitStyle.CtlTypeId] = oRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objRow[concss_FldDispUnitStyle.OrderNum] = oRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim(); //序号
objRow[concss_FldDispUnitStyle.DeletedDate] = oRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objRow[concss_FldDispUnitStyle.IsDeleted] = oRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim(); //是否删除
objRow[concss_FldDispUnitStyle.UpdDate] = oRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objRow[concss_FldDispUnitStyle.UpdUser] = oRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objRow[concss_FldDispUnitStyle.Memo] = oRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
 objDS.Tables[clscss_FldDispUnitStyleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscss_FldDispUnitStyleEN._CurrTabName);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_FldDispUnitStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_FldDispUnitStyleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_FldDispUnitStyle where FldDispUnitStyleId = " + "'"+ objcss_FldDispUnitStyleEN.FldDispUnitStyleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscss_FldDispUnitStyleEN._CurrTabName);
if (objDS.Tables[clscss_FldDispUnitStyleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FldDispUnitStyleId = " + "'"+ objcss_FldDispUnitStyleEN.FldDispUnitStyleId+"'");
return false;
}
objRow = objDS.Tables[clscss_FldDispUnitStyleEN._CurrTabName].Rows[0];
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleId))
 {
objRow[concss_FldDispUnitStyle.FldDispUnitStyleId] = objcss_FldDispUnitStyleEN.FldDispUnitStyleId; //字段显示单元样式Id
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleName))
 {
objRow[concss_FldDispUnitStyle.FldDispUnitStyleName] = objcss_FldDispUnitStyleEN.FldDispUnitStyleName; //字段显示单元样式名称
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleDesc))
 {
objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc; //样式描述
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.StyleIdContent))
 {
objRow[concss_FldDispUnitStyle.StyleIdContent] = objcss_FldDispUnitStyleEN.StyleIdContent; //内容样式Id
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.StyleIdTitle))
 {
objRow[concss_FldDispUnitStyle.StyleIdTitle] = objcss_FldDispUnitStyleEN.StyleIdTitle; //标题样式Id
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleContent))
 {
objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent] = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent; //样式内容
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitFormat))
 {
objRow[concss_FldDispUnitStyle.FldDispUnitFormat] = objcss_FldDispUnitStyleEN.FldDispUnitFormat; //字段显示单元格式
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.CtlTypeId))
 {
objRow[concss_FldDispUnitStyle.CtlTypeId] = objcss_FldDispUnitStyleEN.CtlTypeId; //控件类型号
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.OrderNum))
 {
objRow[concss_FldDispUnitStyle.OrderNum] = objcss_FldDispUnitStyleEN.OrderNum; //序号
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.DeletedDate))
 {
objRow[concss_FldDispUnitStyle.DeletedDate] = objcss_FldDispUnitStyleEN.DeletedDate; //删除日期
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.IsDeleted))
 {
objRow[concss_FldDispUnitStyle.IsDeleted] = objcss_FldDispUnitStyleEN.IsDeleted; //是否删除
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.UpdDate))
 {
objRow[concss_FldDispUnitStyle.UpdDate] = objcss_FldDispUnitStyleEN.UpdDate; //修改日期
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.UpdUser))
 {
objRow[concss_FldDispUnitStyle.UpdUser] = objcss_FldDispUnitStyleEN.UpdUser; //修改者
 }
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.Memo))
 {
objRow[concss_FldDispUnitStyle.Memo] = objcss_FldDispUnitStyleEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clscss_FldDispUnitStyleEN._CurrTabName);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_FldDispUnitStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_FldDispUnitStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update css_FldDispUnitStyle Set ");
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleName))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleName !=  null)
 {
 var strFldDispUnitStyleName = objcss_FldDispUnitStyleEN.FldDispUnitStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldDispUnitStyleName, concss_FldDispUnitStyle.FldDispUnitStyleName); //字段显示单元样式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.FldDispUnitStyleName); //字段显示单元样式名称
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleDesc))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc !=  null)
 {
 var strFldDispUnitStyleDesc = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldDispUnitStyleDesc, concss_FldDispUnitStyle.FldDispUnitStyleDesc); //样式描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.FldDispUnitStyleDesc); //样式描述
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.StyleIdContent))
 {
 if (objcss_FldDispUnitStyleEN.StyleIdContent  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdContent = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdContent !=  null)
 {
 var strStyleIdContent = objcss_FldDispUnitStyleEN.StyleIdContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyleIdContent, concss_FldDispUnitStyle.StyleIdContent); //内容样式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.StyleIdContent); //内容样式Id
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.StyleIdTitle))
 {
 if (objcss_FldDispUnitStyleEN.StyleIdTitle  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdTitle = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdTitle !=  null)
 {
 var strStyleIdTitle = objcss_FldDispUnitStyleEN.StyleIdTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyleIdTitle, concss_FldDispUnitStyle.StyleIdTitle); //标题样式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.StyleIdTitle); //标题样式Id
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleContent))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleContent !=  null)
 {
 var strFldDispUnitStyleContent = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldDispUnitStyleContent, concss_FldDispUnitStyle.FldDispUnitStyleContent); //样式内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.FldDispUnitStyleContent); //样式内容
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitFormat))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitFormat !=  null)
 {
 var strFldDispUnitFormat = objcss_FldDispUnitStyleEN.FldDispUnitFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldDispUnitFormat, concss_FldDispUnitStyle.FldDispUnitFormat); //字段显示单元格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.FldDispUnitFormat); //字段显示单元格式
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.CtlTypeId))
 {
 if (objcss_FldDispUnitStyleEN.CtlTypeId  ==  "")
 {
 objcss_FldDispUnitStyleEN.CtlTypeId = null;
 }
 if (objcss_FldDispUnitStyleEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objcss_FldDispUnitStyleEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, concss_FldDispUnitStyle.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.CtlTypeId); //控件类型号
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.OrderNum))
 {
 if (objcss_FldDispUnitStyleEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcss_FldDispUnitStyleEN.OrderNum, concss_FldDispUnitStyle.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.OrderNum); //序号
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.DeletedDate))
 {
 if (objcss_FldDispUnitStyleEN.DeletedDate !=  null)
 {
 var strDeletedDate = objcss_FldDispUnitStyleEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDeletedDate, concss_FldDispUnitStyle.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.DeletedDate); //删除日期
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcss_FldDispUnitStyleEN.IsDeleted == true?"1":"0", concss_FldDispUnitStyle.IsDeleted); //是否删除
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.UpdDate))
 {
 if (objcss_FldDispUnitStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_FldDispUnitStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concss_FldDispUnitStyle.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.UpdDate); //修改日期
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.UpdUser))
 {
 if (objcss_FldDispUnitStyleEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_FldDispUnitStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concss_FldDispUnitStyle.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.UpdUser); //修改者
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.Memo))
 {
 if (objcss_FldDispUnitStyleEN.Memo !=  null)
 {
 var strMemo = objcss_FldDispUnitStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concss_FldDispUnitStyle.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FldDispUnitStyleId = '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleId); 
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strCondition)
{
 objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_FldDispUnitStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_FldDispUnitStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_FldDispUnitStyle Set ");
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleName))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleName !=  null)
 {
 var strFldDispUnitStyleName = objcss_FldDispUnitStyleEN.FldDispUnitStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldDispUnitStyleName = '{0}',", strFldDispUnitStyleName); //字段显示单元样式名称
 }
 else
 {
 sbSQL.Append(" FldDispUnitStyleName = null,"); //字段显示单元样式名称
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleDesc))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc !=  null)
 {
 var strFldDispUnitStyleDesc = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldDispUnitStyleDesc = '{0}',", strFldDispUnitStyleDesc); //样式描述
 }
 else
 {
 sbSQL.Append(" FldDispUnitStyleDesc = null,"); //样式描述
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.StyleIdContent))
 {
 if (objcss_FldDispUnitStyleEN.StyleIdContent  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdContent = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdContent !=  null)
 {
 var strStyleIdContent = objcss_FldDispUnitStyleEN.StyleIdContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StyleIdContent = '{0}',", strStyleIdContent); //内容样式Id
 }
 else
 {
 sbSQL.Append(" StyleIdContent = null,"); //内容样式Id
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.StyleIdTitle))
 {
 if (objcss_FldDispUnitStyleEN.StyleIdTitle  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdTitle = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdTitle !=  null)
 {
 var strStyleIdTitle = objcss_FldDispUnitStyleEN.StyleIdTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StyleIdTitle = '{0}',", strStyleIdTitle); //标题样式Id
 }
 else
 {
 sbSQL.Append(" StyleIdTitle = null,"); //标题样式Id
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleContent))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleContent !=  null)
 {
 var strFldDispUnitStyleContent = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldDispUnitStyleContent = '{0}',", strFldDispUnitStyleContent); //样式内容
 }
 else
 {
 sbSQL.Append(" FldDispUnitStyleContent = null,"); //样式内容
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitFormat))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitFormat !=  null)
 {
 var strFldDispUnitFormat = objcss_FldDispUnitStyleEN.FldDispUnitFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldDispUnitFormat = '{0}',", strFldDispUnitFormat); //字段显示单元格式
 }
 else
 {
 sbSQL.Append(" FldDispUnitFormat = null,"); //字段显示单元格式
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.CtlTypeId))
 {
 if (objcss_FldDispUnitStyleEN.CtlTypeId  ==  "")
 {
 objcss_FldDispUnitStyleEN.CtlTypeId = null;
 }
 if (objcss_FldDispUnitStyleEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objcss_FldDispUnitStyleEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.OrderNum))
 {
 if (objcss_FldDispUnitStyleEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcss_FldDispUnitStyleEN.OrderNum, concss_FldDispUnitStyle.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.OrderNum); //序号
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.DeletedDate))
 {
 if (objcss_FldDispUnitStyleEN.DeletedDate !=  null)
 {
 var strDeletedDate = objcss_FldDispUnitStyleEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DeletedDate = '{0}',", strDeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" DeletedDate = null,"); //删除日期
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.IsDeleted))
 {
 sbSQL.AppendFormat(" IsDeleted = '{0}',", objcss_FldDispUnitStyleEN.IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.UpdDate))
 {
 if (objcss_FldDispUnitStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_FldDispUnitStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.UpdUser))
 {
 if (objcss_FldDispUnitStyleEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_FldDispUnitStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.Memo))
 {
 if (objcss_FldDispUnitStyleEN.Memo !=  null)
 {
 var strMemo = objcss_FldDispUnitStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_FldDispUnitStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_FldDispUnitStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_FldDispUnitStyle Set ");
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleName))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleName !=  null)
 {
 var strFldDispUnitStyleName = objcss_FldDispUnitStyleEN.FldDispUnitStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldDispUnitStyleName = '{0}',", strFldDispUnitStyleName); //字段显示单元样式名称
 }
 else
 {
 sbSQL.Append(" FldDispUnitStyleName = null,"); //字段显示单元样式名称
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleDesc))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc !=  null)
 {
 var strFldDispUnitStyleDesc = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldDispUnitStyleDesc = '{0}',", strFldDispUnitStyleDesc); //样式描述
 }
 else
 {
 sbSQL.Append(" FldDispUnitStyleDesc = null,"); //样式描述
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.StyleIdContent))
 {
 if (objcss_FldDispUnitStyleEN.StyleIdContent  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdContent = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdContent !=  null)
 {
 var strStyleIdContent = objcss_FldDispUnitStyleEN.StyleIdContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StyleIdContent = '{0}',", strStyleIdContent); //内容样式Id
 }
 else
 {
 sbSQL.Append(" StyleIdContent = null,"); //内容样式Id
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.StyleIdTitle))
 {
 if (objcss_FldDispUnitStyleEN.StyleIdTitle  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdTitle = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdTitle !=  null)
 {
 var strStyleIdTitle = objcss_FldDispUnitStyleEN.StyleIdTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StyleIdTitle = '{0}',", strStyleIdTitle); //标题样式Id
 }
 else
 {
 sbSQL.Append(" StyleIdTitle = null,"); //标题样式Id
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleContent))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleContent !=  null)
 {
 var strFldDispUnitStyleContent = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldDispUnitStyleContent = '{0}',", strFldDispUnitStyleContent); //样式内容
 }
 else
 {
 sbSQL.Append(" FldDispUnitStyleContent = null,"); //样式内容
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitFormat))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitFormat !=  null)
 {
 var strFldDispUnitFormat = objcss_FldDispUnitStyleEN.FldDispUnitFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldDispUnitFormat = '{0}',", strFldDispUnitFormat); //字段显示单元格式
 }
 else
 {
 sbSQL.Append(" FldDispUnitFormat = null,"); //字段显示单元格式
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.CtlTypeId))
 {
 if (objcss_FldDispUnitStyleEN.CtlTypeId  ==  "")
 {
 objcss_FldDispUnitStyleEN.CtlTypeId = null;
 }
 if (objcss_FldDispUnitStyleEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objcss_FldDispUnitStyleEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.OrderNum))
 {
 if (objcss_FldDispUnitStyleEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcss_FldDispUnitStyleEN.OrderNum, concss_FldDispUnitStyle.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.OrderNum); //序号
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.DeletedDate))
 {
 if (objcss_FldDispUnitStyleEN.DeletedDate !=  null)
 {
 var strDeletedDate = objcss_FldDispUnitStyleEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DeletedDate = '{0}',", strDeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" DeletedDate = null,"); //删除日期
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.IsDeleted))
 {
 sbSQL.AppendFormat(" IsDeleted = '{0}',", objcss_FldDispUnitStyleEN.IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.UpdDate))
 {
 if (objcss_FldDispUnitStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_FldDispUnitStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.UpdUser))
 {
 if (objcss_FldDispUnitStyleEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_FldDispUnitStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.Memo))
 {
 if (objcss_FldDispUnitStyleEN.Memo !=  null)
 {
 var strMemo = objcss_FldDispUnitStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_FldDispUnitStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_FldDispUnitStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_FldDispUnitStyle Set ");
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleName))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleName !=  null)
 {
 var strFldDispUnitStyleName = objcss_FldDispUnitStyleEN.FldDispUnitStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldDispUnitStyleName, concss_FldDispUnitStyle.FldDispUnitStyleName); //字段显示单元样式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.FldDispUnitStyleName); //字段显示单元样式名称
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleDesc))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc !=  null)
 {
 var strFldDispUnitStyleDesc = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldDispUnitStyleDesc, concss_FldDispUnitStyle.FldDispUnitStyleDesc); //样式描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.FldDispUnitStyleDesc); //样式描述
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.StyleIdContent))
 {
 if (objcss_FldDispUnitStyleEN.StyleIdContent  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdContent = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdContent !=  null)
 {
 var strStyleIdContent = objcss_FldDispUnitStyleEN.StyleIdContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyleIdContent, concss_FldDispUnitStyle.StyleIdContent); //内容样式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.StyleIdContent); //内容样式Id
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.StyleIdTitle))
 {
 if (objcss_FldDispUnitStyleEN.StyleIdTitle  ==  "")
 {
 objcss_FldDispUnitStyleEN.StyleIdTitle = null;
 }
 if (objcss_FldDispUnitStyleEN.StyleIdTitle !=  null)
 {
 var strStyleIdTitle = objcss_FldDispUnitStyleEN.StyleIdTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyleIdTitle, concss_FldDispUnitStyle.StyleIdTitle); //标题样式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.StyleIdTitle); //标题样式Id
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleContent))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitStyleContent !=  null)
 {
 var strFldDispUnitStyleContent = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldDispUnitStyleContent, concss_FldDispUnitStyle.FldDispUnitStyleContent); //样式内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.FldDispUnitStyleContent); //样式内容
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.FldDispUnitFormat))
 {
 if (objcss_FldDispUnitStyleEN.FldDispUnitFormat !=  null)
 {
 var strFldDispUnitFormat = objcss_FldDispUnitStyleEN.FldDispUnitFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldDispUnitFormat, concss_FldDispUnitStyle.FldDispUnitFormat); //字段显示单元格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.FldDispUnitFormat); //字段显示单元格式
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.CtlTypeId))
 {
 if (objcss_FldDispUnitStyleEN.CtlTypeId  ==  "")
 {
 objcss_FldDispUnitStyleEN.CtlTypeId = null;
 }
 if (objcss_FldDispUnitStyleEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objcss_FldDispUnitStyleEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, concss_FldDispUnitStyle.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.CtlTypeId); //控件类型号
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.OrderNum))
 {
 if (objcss_FldDispUnitStyleEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcss_FldDispUnitStyleEN.OrderNum, concss_FldDispUnitStyle.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.OrderNum); //序号
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.DeletedDate))
 {
 if (objcss_FldDispUnitStyleEN.DeletedDate !=  null)
 {
 var strDeletedDate = objcss_FldDispUnitStyleEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDeletedDate, concss_FldDispUnitStyle.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.DeletedDate); //删除日期
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcss_FldDispUnitStyleEN.IsDeleted == true?"1":"0", concss_FldDispUnitStyle.IsDeleted); //是否删除
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.UpdDate))
 {
 if (objcss_FldDispUnitStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_FldDispUnitStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concss_FldDispUnitStyle.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.UpdDate); //修改日期
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.UpdUser))
 {
 if (objcss_FldDispUnitStyleEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_FldDispUnitStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concss_FldDispUnitStyle.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.UpdUser); //修改者
 }
 }
 
 if (objcss_FldDispUnitStyleEN.IsUpdated(concss_FldDispUnitStyle.Memo))
 {
 if (objcss_FldDispUnitStyleEN.Memo !=  null)
 {
 var strMemo = objcss_FldDispUnitStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concss_FldDispUnitStyle.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_FldDispUnitStyle.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FldDispUnitStyleId = '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleId); 
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
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFldDispUnitStyleId) 
{
CheckPrimaryKey(strFldDispUnitStyleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFldDispUnitStyleId,
};
 objSQL.ExecSP("css_FldDispUnitStyle_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFldDispUnitStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFldDispUnitStyleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
//删除css_FldDispUnitStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_FldDispUnitStyle where FldDispUnitStyleId = " + "'"+ strFldDispUnitStyleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcss_FldDispUnitStyle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
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
//删除css_FldDispUnitStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_FldDispUnitStyle where FldDispUnitStyleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFldDispUnitStyleId) 
{
CheckPrimaryKey(strFldDispUnitStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
//删除css_FldDispUnitStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_FldDispUnitStyle where FldDispUnitStyleId = " + "'"+ strFldDispUnitStyleId+"'";
 return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:根据标志删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySign)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecordBySign(string strFldDispUnitStyleId) 
{
CheckPrimaryKey(strFldDispUnitStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
//删除css_FldDispUnitStyle本表中与当前对象有关的记录
strSQL = strSQL + string.Format("Update css_FldDispUnitStyle Set {0}='1', {1} = '{2}' where FldDispUnitStyleId = '{3}'",
concss_FldDispUnitStyle.IsDeleted, concss_FldDispUnitStyle.DeletedDate, clsDateTime.getTodayDateTimeStr(0), strFldDispUnitStyleId);
 return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:恢复被删除的记录,针对有删除标志的表
 /// (AutoGCLib.DALCode4CSharp:GenUnDelRecordBySign)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <returns>返回恢复删除的记录数</returns>
public int UnDelRecordBySign(string strFldDispUnitStyleId) 
{
CheckPrimaryKey(strFldDispUnitStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
//删除css_FldDispUnitStyle本表中与当前对象有关的记录
strSQL = strSQL + string.Format("Update css_FldDispUnitStyle Set {0}='0', {1} = '{2}' where FldDispUnitStyleId = '{3}'",
concss_FldDispUnitStyle.IsDeleted, concss_FldDispUnitStyle.DeletedDate, clsDateTime.getTodayDateTimeStr(0), strFldDispUnitStyleId);
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcss_FldDispUnitStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: Delcss_FldDispUnitStyle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from css_FldDispUnitStyle where " + strCondition ;
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
public bool Delcss_FldDispUnitStyleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscss_FldDispUnitStyleDA: Delcss_FldDispUnitStyleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from css_FldDispUnitStyle where " + strCondition ;
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
 /// <param name = "objcss_FldDispUnitStyleENS">源对象</param>
 /// <param name = "objcss_FldDispUnitStyleENT">目标对象</param>
public void CopyTo(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENS, clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENT)
{
objcss_FldDispUnitStyleENT.FldDispUnitStyleId = objcss_FldDispUnitStyleENS.FldDispUnitStyleId; //字段显示单元样式Id
objcss_FldDispUnitStyleENT.FldDispUnitStyleName = objcss_FldDispUnitStyleENS.FldDispUnitStyleName; //字段显示单元样式名称
objcss_FldDispUnitStyleENT.FldDispUnitStyleDesc = objcss_FldDispUnitStyleENS.FldDispUnitStyleDesc; //样式描述
objcss_FldDispUnitStyleENT.StyleIdContent = objcss_FldDispUnitStyleENS.StyleIdContent; //内容样式Id
objcss_FldDispUnitStyleENT.StyleIdTitle = objcss_FldDispUnitStyleENS.StyleIdTitle; //标题样式Id
objcss_FldDispUnitStyleENT.FldDispUnitStyleContent = objcss_FldDispUnitStyleENS.FldDispUnitStyleContent; //样式内容
objcss_FldDispUnitStyleENT.FldDispUnitFormat = objcss_FldDispUnitStyleENS.FldDispUnitFormat; //字段显示单元格式
objcss_FldDispUnitStyleENT.CtlTypeId = objcss_FldDispUnitStyleENS.CtlTypeId; //控件类型号
objcss_FldDispUnitStyleENT.OrderNum = objcss_FldDispUnitStyleENS.OrderNum; //序号
objcss_FldDispUnitStyleENT.DeletedDate = objcss_FldDispUnitStyleENS.DeletedDate; //删除日期
objcss_FldDispUnitStyleENT.IsDeleted = objcss_FldDispUnitStyleENS.IsDeleted; //是否删除
objcss_FldDispUnitStyleENT.UpdDate = objcss_FldDispUnitStyleENS.UpdDate; //修改日期
objcss_FldDispUnitStyleENT.UpdUser = objcss_FldDispUnitStyleENS.UpdUser; //修改者
objcss_FldDispUnitStyleENT.Memo = objcss_FldDispUnitStyleENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcss_FldDispUnitStyleEN.FldDispUnitStyleName, concss_FldDispUnitStyle.FldDispUnitStyleName);
clsCheckSql.CheckFieldNotNull(objcss_FldDispUnitStyleEN.FldDispUnitStyleContent, concss_FldDispUnitStyle.FldDispUnitStyleContent);
clsCheckSql.CheckFieldNotNull(objcss_FldDispUnitStyleEN.CtlTypeId, concss_FldDispUnitStyle.CtlTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, 8, concss_FldDispUnitStyle.FldDispUnitStyleId);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleName, 50, concss_FldDispUnitStyle.FldDispUnitStyleName);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc, 1000, concss_FldDispUnitStyle.FldDispUnitStyleDesc);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.StyleIdContent, 8, concss_FldDispUnitStyle.StyleIdContent);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.StyleIdTitle, 8, concss_FldDispUnitStyle.StyleIdTitle);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleContent, 1000, concss_FldDispUnitStyle.FldDispUnitStyleContent);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitFormat, 1000, concss_FldDispUnitStyle.FldDispUnitFormat);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.CtlTypeId, 2, concss_FldDispUnitStyle.CtlTypeId);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.DeletedDate, 50, concss_FldDispUnitStyle.DeletedDate);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.UpdDate, 20, concss_FldDispUnitStyle.UpdDate);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.UpdUser, 20, concss_FldDispUnitStyle.UpdUser);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.Memo, 1000, concss_FldDispUnitStyle.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objcss_FldDispUnitStyleEN.StyleIdContent, 8, concss_FldDispUnitStyle.StyleIdContent);
clsCheckSql.CheckFieldForeignKey(objcss_FldDispUnitStyleEN.StyleIdTitle, 8, concss_FldDispUnitStyle.StyleIdTitle);
clsCheckSql.CheckFieldForeignKey(objcss_FldDispUnitStyleEN.CtlTypeId, 2, concss_FldDispUnitStyle.CtlTypeId);
 objcss_FldDispUnitStyleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleName, 50, concss_FldDispUnitStyle.FldDispUnitStyleName);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc, 1000, concss_FldDispUnitStyle.FldDispUnitStyleDesc);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.StyleIdContent, 8, concss_FldDispUnitStyle.StyleIdContent);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.StyleIdTitle, 8, concss_FldDispUnitStyle.StyleIdTitle);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleContent, 1000, concss_FldDispUnitStyle.FldDispUnitStyleContent);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitFormat, 1000, concss_FldDispUnitStyle.FldDispUnitFormat);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.CtlTypeId, 2, concss_FldDispUnitStyle.CtlTypeId);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.DeletedDate, 50, concss_FldDispUnitStyle.DeletedDate);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.UpdDate, 20, concss_FldDispUnitStyle.UpdDate);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.UpdUser, 20, concss_FldDispUnitStyle.UpdUser);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.Memo, 1000, concss_FldDispUnitStyle.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcss_FldDispUnitStyleEN.StyleIdContent, 8, concss_FldDispUnitStyle.StyleIdContent);
clsCheckSql.CheckFieldForeignKey(objcss_FldDispUnitStyleEN.StyleIdTitle, 8, concss_FldDispUnitStyle.StyleIdTitle);
clsCheckSql.CheckFieldForeignKey(objcss_FldDispUnitStyleEN.CtlTypeId, 2, concss_FldDispUnitStyle.CtlTypeId);
 objcss_FldDispUnitStyleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, 8, concss_FldDispUnitStyle.FldDispUnitStyleId);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleName, 50, concss_FldDispUnitStyle.FldDispUnitStyleName);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc, 1000, concss_FldDispUnitStyle.FldDispUnitStyleDesc);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.StyleIdContent, 8, concss_FldDispUnitStyle.StyleIdContent);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.StyleIdTitle, 8, concss_FldDispUnitStyle.StyleIdTitle);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleContent, 1000, concss_FldDispUnitStyle.FldDispUnitStyleContent);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.FldDispUnitFormat, 1000, concss_FldDispUnitStyle.FldDispUnitFormat);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.CtlTypeId, 2, concss_FldDispUnitStyle.CtlTypeId);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.DeletedDate, 50, concss_FldDispUnitStyle.DeletedDate);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.UpdDate, 20, concss_FldDispUnitStyle.UpdDate);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.UpdUser, 20, concss_FldDispUnitStyle.UpdUser);
clsCheckSql.CheckFieldLen(objcss_FldDispUnitStyleEN.Memo, 1000, concss_FldDispUnitStyle.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, concss_FldDispUnitStyle.FldDispUnitStyleId);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.FldDispUnitStyleName, concss_FldDispUnitStyle.FldDispUnitStyleName);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc, concss_FldDispUnitStyle.FldDispUnitStyleDesc);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.StyleIdContent, concss_FldDispUnitStyle.StyleIdContent);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.StyleIdTitle, concss_FldDispUnitStyle.StyleIdTitle);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.FldDispUnitStyleContent, concss_FldDispUnitStyle.FldDispUnitStyleContent);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.FldDispUnitFormat, concss_FldDispUnitStyle.FldDispUnitFormat);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.CtlTypeId, concss_FldDispUnitStyle.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.DeletedDate, concss_FldDispUnitStyle.DeletedDate);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.UpdDate, concss_FldDispUnitStyle.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.UpdUser, concss_FldDispUnitStyle.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objcss_FldDispUnitStyleEN.Memo, concss_FldDispUnitStyle.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcss_FldDispUnitStyleEN.StyleIdContent, 8, concss_FldDispUnitStyle.StyleIdContent);
clsCheckSql.CheckFieldForeignKey(objcss_FldDispUnitStyleEN.StyleIdTitle, 8, concss_FldDispUnitStyle.StyleIdTitle);
clsCheckSql.CheckFieldForeignKey(objcss_FldDispUnitStyleEN.CtlTypeId, 2, concss_FldDispUnitStyle.CtlTypeId);
 objcss_FldDispUnitStyleEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFldDispUnitStyleId()
{
//获取某学院所有专业信息
string strSQL = "select FldDispUnitStyleId, FldDispUnitStyleName from css_FldDispUnitStyle ";
 clsSpecSQLforSql mySql = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--css_FldDispUnitStyle(字段显示单元样式),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldDispUnitStyleName = '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleName);
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_FldDispUnitStyleEN.CtlTypeId);
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
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
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
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
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
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscss_FldDispUnitStyleEN._CurrTabName);
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
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscss_FldDispUnitStyleEN._CurrTabName, strCondition);
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
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
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
 objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}