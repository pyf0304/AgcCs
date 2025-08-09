
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_TemplateStyleDA
 表名:css_TemplateStyle(00050470)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:16
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
 /// css_TemplateStyle(css_TemplateStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscss_TemplateStyleDA : clsCommBase4DA
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
 return clscss_TemplateStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscss_TemplateStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscss_TemplateStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscss_TemplateStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscss_TemplateStyleEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_TemplateStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_css_TemplateStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA: GetDataTable_css_TemplateStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_TemplateStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_TemplateStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_TemplateStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_TemplateStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from css_TemplateStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscss_TemplateStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} css_TemplateStyle.* " + 
$"from css_TemplateStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and css_TemplateStyle.mId not in " + 
$"(Select top {intTop_In} css_TemplateStyle.mId from css_TemplateStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_TemplateStyle where {1} and mId not in (Select top {2} mId from css_TemplateStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_TemplateStyle where {1} and mId not in (Select top {3} mId from css_TemplateStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscss_TemplateStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} css_TemplateStyle.* " + 
$"from css_TemplateStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and css_TemplateStyle.mId not in " + 
$"(Select top {intTop_In} css_TemplateStyle.mId from css_TemplateStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_TemplateStyle where {1} and mId not in (Select top {2} mId from css_TemplateStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_TemplateStyle where {1} and mId not in (Select top {3} mId from css_TemplateStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscss_TemplateStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA:GetObjLst)", objException.Message));
}
List<clscss_TemplateStyleEN> arrObjLst = new List<clscss_TemplateStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_TemplateStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateStyleEN objcss_TemplateStyleEN = new clscss_TemplateStyleEN();
try
{
objcss_TemplateStyleEN.mId = TransNullToInt(objRow[concss_TemplateStyle.mId].ToString().Trim()); //mId
objcss_TemplateStyleEN.StyleId = objRow[concss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[concss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objcss_TemplateStyleEN.TemplateId = objRow[concss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateStyleEN.cssModuleAreaId = objRow[concss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objcss_TemplateStyleEN.TemplateStyleName = objRow[concss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objcss_TemplateStyleEN.UpdDate = objRow[concss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateStyleEN.UpdUser = objRow[concss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objcss_TemplateStyleEN.Memo = objRow[concss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[concss_TemplateStyle.Memo].ToString().Trim(); //说明
objcss_TemplateStyleEN.TemplateStyleNameEn = objRow[concss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objcss_TemplateStyleEN.IsDelete = TransNullToBool(objRow[concss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscss_TemplateStyleDA: GetObjLst)", objException.Message));
}
objcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcss_TemplateStyleEN);
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
public List<clscss_TemplateStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clscss_TemplateStyleEN> arrObjLst = new List<clscss_TemplateStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateStyleEN objcss_TemplateStyleEN = new clscss_TemplateStyleEN();
try
{
objcss_TemplateStyleEN.mId = TransNullToInt(objRow[concss_TemplateStyle.mId].ToString().Trim()); //mId
objcss_TemplateStyleEN.StyleId = objRow[concss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[concss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objcss_TemplateStyleEN.TemplateId = objRow[concss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateStyleEN.cssModuleAreaId = objRow[concss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objcss_TemplateStyleEN.TemplateStyleName = objRow[concss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objcss_TemplateStyleEN.UpdDate = objRow[concss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateStyleEN.UpdUser = objRow[concss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objcss_TemplateStyleEN.Memo = objRow[concss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[concss_TemplateStyle.Memo].ToString().Trim(); //说明
objcss_TemplateStyleEN.TemplateStyleNameEn = objRow[concss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objcss_TemplateStyleEN.IsDelete = TransNullToBool(objRow[concss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscss_TemplateStyleDA: GetObjLst)", objException.Message));
}
objcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcss_TemplateStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcss_TemplateStyle(ref clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_TemplateStyle where mId = " + ""+ objcss_TemplateStyleEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcss_TemplateStyleEN.mId = TransNullToInt(objDT.Rows[0][concss_TemplateStyle.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objcss_TemplateStyleEN.StyleId = objDT.Rows[0][concss_TemplateStyle.StyleId].ToString().Trim(); //样式ID(字段类型:char,字段长度:8,是否可空:False)
 objcss_TemplateStyleEN.TemplateId = objDT.Rows[0][concss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID(字段类型:char,字段长度:8,是否可空:False)
 objcss_TemplateStyleEN.cssModuleAreaId = objDT.Rows[0][concss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键(字段类型:char,字段长度:8,是否可空:False)
 objcss_TemplateStyleEN.TemplateStyleName = objDT.Rows[0][concss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_TemplateStyleEN.UpdDate = objDT.Rows[0][concss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_TemplateStyleEN.UpdUser = objDT.Rows[0][concss_TemplateStyle.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_TemplateStyleEN.Memo = objDT.Rows[0][concss_TemplateStyle.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objcss_TemplateStyleEN.TemplateStyleNameEn = objDT.Rows[0][concss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文(字段类型:varchar,字段长度:200,是否可空:True)
 objcss_TemplateStyleEN.IsDelete = TransNullToBool(objDT.Rows[0][concss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscss_TemplateStyleDA: Getcss_TemplateStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clscss_TemplateStyleEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_TemplateStyle where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscss_TemplateStyleEN objcss_TemplateStyleEN = new clscss_TemplateStyleEN();
try
{
 objcss_TemplateStyleEN.mId = Int32.Parse(objRow[concss_TemplateStyle.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objcss_TemplateStyleEN.StyleId = objRow[concss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[concss_TemplateStyle.StyleId].ToString().Trim(); //样式ID(字段类型:char,字段长度:8,是否可空:False)
 objcss_TemplateStyleEN.TemplateId = objRow[concss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID(字段类型:char,字段长度:8,是否可空:False)
 objcss_TemplateStyleEN.cssModuleAreaId = objRow[concss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键(字段类型:char,字段长度:8,是否可空:False)
 objcss_TemplateStyleEN.TemplateStyleName = objRow[concss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_TemplateStyleEN.UpdDate = objRow[concss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_TemplateStyleEN.UpdUser = objRow[concss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_TemplateStyleEN.Memo = objRow[concss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[concss_TemplateStyle.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objcss_TemplateStyleEN.TemplateStyleNameEn = objRow[concss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文(字段类型:varchar,字段长度:200,是否可空:True)
 objcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[concss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscss_TemplateStyleDA: GetObjBymId)", objException.Message));
}
return objcss_TemplateStyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscss_TemplateStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_TemplateStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscss_TemplateStyleEN objcss_TemplateStyleEN = new clscss_TemplateStyleEN()
{
mId = TransNullToInt(objRow[concss_TemplateStyle.mId].ToString().Trim()), //mId
StyleId = objRow[concss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[concss_TemplateStyle.StyleId].ToString().Trim(), //样式ID
TemplateId = objRow[concss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateId].ToString().Trim(), //模板ID
cssModuleAreaId = objRow[concss_TemplateStyle.cssModuleAreaId].ToString().Trim(), //区域主键
TemplateStyleName = objRow[concss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleName].ToString().Trim(), //模板样式名称
UpdDate = objRow[concss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[concss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdUser].ToString().Trim(), //修改者
Memo = objRow[concss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[concss_TemplateStyle.Memo].ToString().Trim(), //说明
TemplateStyleNameEn = objRow[concss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(), //模板样式英文
IsDelete = TransNullToBool(objRow[concss_TemplateStyle.IsDelete].ToString().Trim()) //IsDelete
};
objcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_TemplateStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscss_TemplateStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscss_TemplateStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscss_TemplateStyleEN objcss_TemplateStyleEN = new clscss_TemplateStyleEN();
try
{
objcss_TemplateStyleEN.mId = TransNullToInt(objRow[concss_TemplateStyle.mId].ToString().Trim()); //mId
objcss_TemplateStyleEN.StyleId = objRow[concss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[concss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objcss_TemplateStyleEN.TemplateId = objRow[concss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateStyleEN.cssModuleAreaId = objRow[concss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objcss_TemplateStyleEN.TemplateStyleName = objRow[concss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objcss_TemplateStyleEN.UpdDate = objRow[concss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateStyleEN.UpdUser = objRow[concss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objcss_TemplateStyleEN.Memo = objRow[concss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[concss_TemplateStyle.Memo].ToString().Trim(); //说明
objcss_TemplateStyleEN.TemplateStyleNameEn = objRow[concss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objcss_TemplateStyleEN.IsDelete = TransNullToBool(objRow[concss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscss_TemplateStyleDA: GetObjByDataRowcss_TemplateStyle)", objException.Message));
}
objcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_TemplateStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscss_TemplateStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscss_TemplateStyleEN objcss_TemplateStyleEN = new clscss_TemplateStyleEN();
try
{
objcss_TemplateStyleEN.mId = TransNullToInt(objRow[concss_TemplateStyle.mId].ToString().Trim()); //mId
objcss_TemplateStyleEN.StyleId = objRow[concss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[concss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objcss_TemplateStyleEN.TemplateId = objRow[concss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateStyleEN.cssModuleAreaId = objRow[concss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objcss_TemplateStyleEN.TemplateStyleName = objRow[concss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objcss_TemplateStyleEN.UpdDate = objRow[concss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateStyleEN.UpdUser = objRow[concss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[concss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objcss_TemplateStyleEN.Memo = objRow[concss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[concss_TemplateStyle.Memo].ToString().Trim(); //说明
objcss_TemplateStyleEN.TemplateStyleNameEn = objRow[concss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[concss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objcss_TemplateStyleEN.IsDelete = TransNullToBool(objRow[concss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscss_TemplateStyleDA: GetObjByDataRow)", objException.Message));
}
objcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_TemplateStyleEN;
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
objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscss_TemplateStyleEN._CurrTabName, concss_TemplateStyle.mId, 8, "");
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
objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscss_TemplateStyleEN._CurrTabName, concss_TemplateStyle.mId, 8, strPrefix);
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from css_TemplateStyle where " + strCondition;
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from css_TemplateStyle where " + strCondition;
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("css_TemplateStyle", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("css_TemplateStyle", strCondition))
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
objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("css_TemplateStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscss_TemplateStyleEN objcss_TemplateStyleEN)
 {
 objcss_TemplateStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_TemplateStyleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_TemplateStyle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "css_TemplateStyle");
objRow = objDS.Tables["css_TemplateStyle"].NewRow();
 if (objcss_TemplateStyleEN.StyleId !=  "")
 {
objRow[concss_TemplateStyle.StyleId] = objcss_TemplateStyleEN.StyleId; //样式ID
 }
 if (objcss_TemplateStyleEN.TemplateId !=  "")
 {
objRow[concss_TemplateStyle.TemplateId] = objcss_TemplateStyleEN.TemplateId; //模板ID
 }
objRow[concss_TemplateStyle.cssModuleAreaId] = objcss_TemplateStyleEN.cssModuleAreaId; //区域主键
 if (objcss_TemplateStyleEN.TemplateStyleName !=  "")
 {
objRow[concss_TemplateStyle.TemplateStyleName] = objcss_TemplateStyleEN.TemplateStyleName; //模板样式名称
 }
 if (objcss_TemplateStyleEN.UpdDate !=  "")
 {
objRow[concss_TemplateStyle.UpdDate] = objcss_TemplateStyleEN.UpdDate; //修改日期
 }
 if (objcss_TemplateStyleEN.UpdUser !=  "")
 {
objRow[concss_TemplateStyle.UpdUser] = objcss_TemplateStyleEN.UpdUser; //修改者
 }
 if (objcss_TemplateStyleEN.Memo !=  "")
 {
objRow[concss_TemplateStyle.Memo] = objcss_TemplateStyleEN.Memo; //说明
 }
 if (objcss_TemplateStyleEN.TemplateStyleNameEn !=  "")
 {
objRow[concss_TemplateStyle.TemplateStyleNameEn] = objcss_TemplateStyleEN.TemplateStyleNameEn; //模板样式英文
 }
objRow[concss_TemplateStyle.IsDelete] = objcss_TemplateStyleEN.IsDelete; //IsDelete
objDS.Tables[clscss_TemplateStyleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscss_TemplateStyleEN._CurrTabName);
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
 /// <param name = "objcss_TemplateStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
 objcss_TemplateStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_TemplateStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcss_TemplateStyleEN.StyleId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.StyleId);
 var strStyleId = objcss_TemplateStyleEN.StyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleId + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateId);
 var strTemplateId = objcss_TemplateStyleEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateId + "'");
 }
 
 if (objcss_TemplateStyleEN.cssModuleAreaId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.cssModuleAreaId);
 var strcssModuleAreaId = objcss_TemplateStyleEN.cssModuleAreaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcssModuleAreaId + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateStyleName !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateStyleName);
 var strTemplateStyleName = objcss_TemplateStyleEN.TemplateStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateStyleName + "'");
 }
 
 if (objcss_TemplateStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.UpdDate);
 var strUpdDate = objcss_TemplateStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_TemplateStyleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.UpdUser);
 var strUpdUser = objcss_TemplateStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_TemplateStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.Memo);
 var strMemo = objcss_TemplateStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateStyleNameEn !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateStyleNameEn);
 var strTemplateStyleNameEn = objcss_TemplateStyleEN.TemplateStyleNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateStyleNameEn + "'");
 }
 
 arrFieldListForInsert.Add(concss_TemplateStyle.IsDelete);
 arrValueListForInsert.Add("'" + (objcss_TemplateStyleEN.IsDelete  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_TemplateStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
 objcss_TemplateStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_TemplateStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcss_TemplateStyleEN.StyleId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.StyleId);
 var strStyleId = objcss_TemplateStyleEN.StyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleId + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateId);
 var strTemplateId = objcss_TemplateStyleEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateId + "'");
 }
 
 if (objcss_TemplateStyleEN.cssModuleAreaId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.cssModuleAreaId);
 var strcssModuleAreaId = objcss_TemplateStyleEN.cssModuleAreaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcssModuleAreaId + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateStyleName !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateStyleName);
 var strTemplateStyleName = objcss_TemplateStyleEN.TemplateStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateStyleName + "'");
 }
 
 if (objcss_TemplateStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.UpdDate);
 var strUpdDate = objcss_TemplateStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_TemplateStyleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.UpdUser);
 var strUpdUser = objcss_TemplateStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_TemplateStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.Memo);
 var strMemo = objcss_TemplateStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateStyleNameEn !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateStyleNameEn);
 var strTemplateStyleNameEn = objcss_TemplateStyleEN.TemplateStyleNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateStyleNameEn + "'");
 }
 
 arrFieldListForInsert.Add(concss_TemplateStyle.IsDelete);
 arrValueListForInsert.Add("'" + (objcss_TemplateStyleEN.IsDelete  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_TemplateStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscss_TemplateStyleEN objcss_TemplateStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcss_TemplateStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_TemplateStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcss_TemplateStyleEN.StyleId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.StyleId);
 var strStyleId = objcss_TemplateStyleEN.StyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleId + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateId);
 var strTemplateId = objcss_TemplateStyleEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateId + "'");
 }
 
 if (objcss_TemplateStyleEN.cssModuleAreaId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.cssModuleAreaId);
 var strcssModuleAreaId = objcss_TemplateStyleEN.cssModuleAreaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcssModuleAreaId + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateStyleName !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateStyleName);
 var strTemplateStyleName = objcss_TemplateStyleEN.TemplateStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateStyleName + "'");
 }
 
 if (objcss_TemplateStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.UpdDate);
 var strUpdDate = objcss_TemplateStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_TemplateStyleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.UpdUser);
 var strUpdUser = objcss_TemplateStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_TemplateStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.Memo);
 var strMemo = objcss_TemplateStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateStyleNameEn !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateStyleNameEn);
 var strTemplateStyleNameEn = objcss_TemplateStyleEN.TemplateStyleNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateStyleNameEn + "'");
 }
 
 arrFieldListForInsert.Add(concss_TemplateStyle.IsDelete);
 arrValueListForInsert.Add("'" + (objcss_TemplateStyleEN.IsDelete  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_TemplateStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscss_TemplateStyleEN objcss_TemplateStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcss_TemplateStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_TemplateStyleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcss_TemplateStyleEN.StyleId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.StyleId);
 var strStyleId = objcss_TemplateStyleEN.StyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyleId + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateId);
 var strTemplateId = objcss_TemplateStyleEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateId + "'");
 }
 
 if (objcss_TemplateStyleEN.cssModuleAreaId !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.cssModuleAreaId);
 var strcssModuleAreaId = objcss_TemplateStyleEN.cssModuleAreaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strcssModuleAreaId + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateStyleName !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateStyleName);
 var strTemplateStyleName = objcss_TemplateStyleEN.TemplateStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateStyleName + "'");
 }
 
 if (objcss_TemplateStyleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.UpdDate);
 var strUpdDate = objcss_TemplateStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_TemplateStyleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.UpdUser);
 var strUpdUser = objcss_TemplateStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_TemplateStyleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.Memo);
 var strMemo = objcss_TemplateStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objcss_TemplateStyleEN.TemplateStyleNameEn !=  null)
 {
 arrFieldListForInsert.Add(concss_TemplateStyle.TemplateStyleNameEn);
 var strTemplateStyleNameEn = objcss_TemplateStyleEN.TemplateStyleNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateStyleNameEn + "'");
 }
 
 arrFieldListForInsert.Add(concss_TemplateStyle.IsDelete);
 arrValueListForInsert.Add("'" + (objcss_TemplateStyleEN.IsDelete  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_TemplateStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcss_TemplateStyles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_TemplateStyle where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "css_TemplateStyle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[concss_TemplateStyle.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscss_TemplateStyleEN._CurrTabName ].NewRow();
objRow[concss_TemplateStyle.StyleId] = oRow[concss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objRow[concss_TemplateStyle.TemplateId] = oRow[concss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objRow[concss_TemplateStyle.cssModuleAreaId] = oRow[concss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objRow[concss_TemplateStyle.TemplateStyleName] = oRow[concss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objRow[concss_TemplateStyle.UpdDate] = oRow[concss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objRow[concss_TemplateStyle.UpdUser] = oRow[concss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objRow[concss_TemplateStyle.Memo] = oRow[concss_TemplateStyle.Memo].ToString().Trim(); //说明
objRow[concss_TemplateStyle.TemplateStyleNameEn] = oRow[concss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objRow[concss_TemplateStyle.IsDelete] = oRow[concss_TemplateStyle.IsDelete].ToString().Trim(); //IsDelete
 objDS.Tables[clscss_TemplateStyleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscss_TemplateStyleEN._CurrTabName);
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
 /// <param name = "objcss_TemplateStyleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
 objcss_TemplateStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_TemplateStyleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from css_TemplateStyle where mId = " + ""+ objcss_TemplateStyleEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscss_TemplateStyleEN._CurrTabName);
if (objDS.Tables[clscss_TemplateStyleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objcss_TemplateStyleEN.mId+"");
return false;
}
objRow = objDS.Tables[clscss_TemplateStyleEN._CurrTabName].Rows[0];
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.StyleId))
 {
objRow[concss_TemplateStyle.StyleId] = objcss_TemplateStyleEN.StyleId; //样式ID
 }
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateId))
 {
objRow[concss_TemplateStyle.TemplateId] = objcss_TemplateStyleEN.TemplateId; //模板ID
 }
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.cssModuleAreaId))
 {
objRow[concss_TemplateStyle.cssModuleAreaId] = objcss_TemplateStyleEN.cssModuleAreaId; //区域主键
 }
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateStyleName))
 {
objRow[concss_TemplateStyle.TemplateStyleName] = objcss_TemplateStyleEN.TemplateStyleName; //模板样式名称
 }
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.UpdDate))
 {
objRow[concss_TemplateStyle.UpdDate] = objcss_TemplateStyleEN.UpdDate; //修改日期
 }
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.UpdUser))
 {
objRow[concss_TemplateStyle.UpdUser] = objcss_TemplateStyleEN.UpdUser; //修改者
 }
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.Memo))
 {
objRow[concss_TemplateStyle.Memo] = objcss_TemplateStyleEN.Memo; //说明
 }
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateStyleNameEn))
 {
objRow[concss_TemplateStyle.TemplateStyleNameEn] = objcss_TemplateStyleEN.TemplateStyleNameEn; //模板样式英文
 }
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.IsDelete))
 {
objRow[concss_TemplateStyle.IsDelete] = objcss_TemplateStyleEN.IsDelete; //IsDelete
 }
try
{
objDA.Update(objDS, clscss_TemplateStyleEN._CurrTabName);
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
 /// <param name = "objcss_TemplateStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
 objcss_TemplateStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_TemplateStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update css_TemplateStyle Set ");
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.StyleId))
 {
 if (objcss_TemplateStyleEN.StyleId !=  null)
 {
 var strStyleId = objcss_TemplateStyleEN.StyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyleId, concss_TemplateStyle.StyleId); //样式ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.StyleId); //样式ID
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateId))
 {
 if (objcss_TemplateStyleEN.TemplateId !=  null)
 {
 var strTemplateId = objcss_TemplateStyleEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplateId, concss_TemplateStyle.TemplateId); //模板ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.TemplateId); //模板ID
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.cssModuleAreaId))
 {
 if (objcss_TemplateStyleEN.cssModuleAreaId !=  null)
 {
 var strcssModuleAreaId = objcss_TemplateStyleEN.cssModuleAreaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcssModuleAreaId, concss_TemplateStyle.cssModuleAreaId); //区域主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.cssModuleAreaId); //区域主键
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateStyleName))
 {
 if (objcss_TemplateStyleEN.TemplateStyleName !=  null)
 {
 var strTemplateStyleName = objcss_TemplateStyleEN.TemplateStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplateStyleName, concss_TemplateStyle.TemplateStyleName); //模板样式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.TemplateStyleName); //模板样式名称
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.UpdDate))
 {
 if (objcss_TemplateStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_TemplateStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concss_TemplateStyle.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.UpdDate); //修改日期
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.UpdUser))
 {
 if (objcss_TemplateStyleEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_TemplateStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concss_TemplateStyle.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.UpdUser); //修改者
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.Memo))
 {
 if (objcss_TemplateStyleEN.Memo !=  null)
 {
 var strMemo = objcss_TemplateStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concss_TemplateStyle.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.Memo); //说明
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateStyleNameEn))
 {
 if (objcss_TemplateStyleEN.TemplateStyleNameEn !=  null)
 {
 var strTemplateStyleNameEn = objcss_TemplateStyleEN.TemplateStyleNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplateStyleNameEn, concss_TemplateStyle.TemplateStyleNameEn); //模板样式英文
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.TemplateStyleNameEn); //模板样式英文
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcss_TemplateStyleEN.IsDelete == true?"1":"0", concss_TemplateStyle.IsDelete); //IsDelete
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objcss_TemplateStyleEN.mId); 
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
 /// <param name = "objcss_TemplateStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscss_TemplateStyleEN objcss_TemplateStyleEN, string strCondition)
{
 objcss_TemplateStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_TemplateStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_TemplateStyle Set ");
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.StyleId))
 {
 if (objcss_TemplateStyleEN.StyleId !=  null)
 {
 var strStyleId = objcss_TemplateStyleEN.StyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StyleId = '{0}',", strStyleId); //样式ID
 }
 else
 {
 sbSQL.Append(" StyleId = null,"); //样式ID
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateId))
 {
 if (objcss_TemplateStyleEN.TemplateId !=  null)
 {
 var strTemplateId = objcss_TemplateStyleEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplateId = '{0}',", strTemplateId); //模板ID
 }
 else
 {
 sbSQL.Append(" TemplateId = null,"); //模板ID
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.cssModuleAreaId))
 {
 if (objcss_TemplateStyleEN.cssModuleAreaId !=  null)
 {
 var strcssModuleAreaId = objcss_TemplateStyleEN.cssModuleAreaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" cssModuleAreaId = '{0}',", strcssModuleAreaId); //区域主键
 }
 else
 {
 sbSQL.Append(" cssModuleAreaId = null,"); //区域主键
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateStyleName))
 {
 if (objcss_TemplateStyleEN.TemplateStyleName !=  null)
 {
 var strTemplateStyleName = objcss_TemplateStyleEN.TemplateStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplateStyleName = '{0}',", strTemplateStyleName); //模板样式名称
 }
 else
 {
 sbSQL.Append(" TemplateStyleName = null,"); //模板样式名称
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.UpdDate))
 {
 if (objcss_TemplateStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_TemplateStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.UpdUser))
 {
 if (objcss_TemplateStyleEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_TemplateStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.Memo))
 {
 if (objcss_TemplateStyleEN.Memo !=  null)
 {
 var strMemo = objcss_TemplateStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateStyleNameEn))
 {
 if (objcss_TemplateStyleEN.TemplateStyleNameEn !=  null)
 {
 var strTemplateStyleNameEn = objcss_TemplateStyleEN.TemplateStyleNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplateStyleNameEn = '{0}',", strTemplateStyleNameEn); //模板样式英文
 }
 else
 {
 sbSQL.Append(" TemplateStyleNameEn = null,"); //模板样式英文
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objcss_TemplateStyleEN.IsDelete == true?"1":"0"); //IsDelete
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
 /// <param name = "objcss_TemplateStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscss_TemplateStyleEN objcss_TemplateStyleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcss_TemplateStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_TemplateStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_TemplateStyle Set ");
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.StyleId))
 {
 if (objcss_TemplateStyleEN.StyleId !=  null)
 {
 var strStyleId = objcss_TemplateStyleEN.StyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StyleId = '{0}',", strStyleId); //样式ID
 }
 else
 {
 sbSQL.Append(" StyleId = null,"); //样式ID
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateId))
 {
 if (objcss_TemplateStyleEN.TemplateId !=  null)
 {
 var strTemplateId = objcss_TemplateStyleEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplateId = '{0}',", strTemplateId); //模板ID
 }
 else
 {
 sbSQL.Append(" TemplateId = null,"); //模板ID
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.cssModuleAreaId))
 {
 if (objcss_TemplateStyleEN.cssModuleAreaId !=  null)
 {
 var strcssModuleAreaId = objcss_TemplateStyleEN.cssModuleAreaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" cssModuleAreaId = '{0}',", strcssModuleAreaId); //区域主键
 }
 else
 {
 sbSQL.Append(" cssModuleAreaId = null,"); //区域主键
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateStyleName))
 {
 if (objcss_TemplateStyleEN.TemplateStyleName !=  null)
 {
 var strTemplateStyleName = objcss_TemplateStyleEN.TemplateStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplateStyleName = '{0}',", strTemplateStyleName); //模板样式名称
 }
 else
 {
 sbSQL.Append(" TemplateStyleName = null,"); //模板样式名称
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.UpdDate))
 {
 if (objcss_TemplateStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_TemplateStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.UpdUser))
 {
 if (objcss_TemplateStyleEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_TemplateStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.Memo))
 {
 if (objcss_TemplateStyleEN.Memo !=  null)
 {
 var strMemo = objcss_TemplateStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateStyleNameEn))
 {
 if (objcss_TemplateStyleEN.TemplateStyleNameEn !=  null)
 {
 var strTemplateStyleNameEn = objcss_TemplateStyleEN.TemplateStyleNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplateStyleNameEn = '{0}',", strTemplateStyleNameEn); //模板样式英文
 }
 else
 {
 sbSQL.Append(" TemplateStyleNameEn = null,"); //模板样式英文
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objcss_TemplateStyleEN.IsDelete == true?"1":"0"); //IsDelete
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
 /// <param name = "objcss_TemplateStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscss_TemplateStyleEN objcss_TemplateStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcss_TemplateStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_TemplateStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_TemplateStyle Set ");
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.StyleId))
 {
 if (objcss_TemplateStyleEN.StyleId !=  null)
 {
 var strStyleId = objcss_TemplateStyleEN.StyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyleId, concss_TemplateStyle.StyleId); //样式ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.StyleId); //样式ID
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateId))
 {
 if (objcss_TemplateStyleEN.TemplateId !=  null)
 {
 var strTemplateId = objcss_TemplateStyleEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplateId, concss_TemplateStyle.TemplateId); //模板ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.TemplateId); //模板ID
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.cssModuleAreaId))
 {
 if (objcss_TemplateStyleEN.cssModuleAreaId !=  null)
 {
 var strcssModuleAreaId = objcss_TemplateStyleEN.cssModuleAreaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strcssModuleAreaId, concss_TemplateStyle.cssModuleAreaId); //区域主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.cssModuleAreaId); //区域主键
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateStyleName))
 {
 if (objcss_TemplateStyleEN.TemplateStyleName !=  null)
 {
 var strTemplateStyleName = objcss_TemplateStyleEN.TemplateStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplateStyleName, concss_TemplateStyle.TemplateStyleName); //模板样式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.TemplateStyleName); //模板样式名称
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.UpdDate))
 {
 if (objcss_TemplateStyleEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_TemplateStyleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concss_TemplateStyle.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.UpdDate); //修改日期
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.UpdUser))
 {
 if (objcss_TemplateStyleEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_TemplateStyleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concss_TemplateStyle.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.UpdUser); //修改者
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.Memo))
 {
 if (objcss_TemplateStyleEN.Memo !=  null)
 {
 var strMemo = objcss_TemplateStyleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concss_TemplateStyle.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.Memo); //说明
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.TemplateStyleNameEn))
 {
 if (objcss_TemplateStyleEN.TemplateStyleNameEn !=  null)
 {
 var strTemplateStyleNameEn = objcss_TemplateStyleEN.TemplateStyleNameEn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplateStyleNameEn, concss_TemplateStyle.TemplateStyleNameEn); //模板样式英文
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_TemplateStyle.TemplateStyleNameEn); //模板样式英文
 }
 }
 
 if (objcss_TemplateStyleEN.IsUpdated(concss_TemplateStyle.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcss_TemplateStyleEN.IsDelete == true?"1":"0", concss_TemplateStyle.IsDelete); //IsDelete
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objcss_TemplateStyleEN.mId); 
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("css_TemplateStyle_Delete", values);
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
//删除css_TemplateStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_TemplateStyle where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcss_TemplateStyle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
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
//删除css_TemplateStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_TemplateStyle where mId in (" + strKeyList + ")";
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
//删除css_TemplateStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_TemplateStyle where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcss_TemplateStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA: Delcss_TemplateStyle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from css_TemplateStyle where " + strCondition ;
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
public bool Delcss_TemplateStyleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscss_TemplateStyleDA: Delcss_TemplateStyleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from css_TemplateStyle where " + strCondition ;
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
 /// <param name = "objcss_TemplateStyleENS">源对象</param>
 /// <param name = "objcss_TemplateStyleENT">目标对象</param>
public void CopyTo(clscss_TemplateStyleEN objcss_TemplateStyleENS, clscss_TemplateStyleEN objcss_TemplateStyleENT)
{
objcss_TemplateStyleENT.mId = objcss_TemplateStyleENS.mId; //mId
objcss_TemplateStyleENT.StyleId = objcss_TemplateStyleENS.StyleId; //样式ID
objcss_TemplateStyleENT.TemplateId = objcss_TemplateStyleENS.TemplateId; //模板ID
objcss_TemplateStyleENT.cssModuleAreaId = objcss_TemplateStyleENS.cssModuleAreaId; //区域主键
objcss_TemplateStyleENT.TemplateStyleName = objcss_TemplateStyleENS.TemplateStyleName; //模板样式名称
objcss_TemplateStyleENT.UpdDate = objcss_TemplateStyleENS.UpdDate; //修改日期
objcss_TemplateStyleENT.UpdUser = objcss_TemplateStyleENS.UpdUser; //修改者
objcss_TemplateStyleENT.Memo = objcss_TemplateStyleENS.Memo; //说明
objcss_TemplateStyleENT.TemplateStyleNameEn = objcss_TemplateStyleENS.TemplateStyleNameEn; //模板样式英文
objcss_TemplateStyleENT.IsDelete = objcss_TemplateStyleENS.IsDelete; //IsDelete
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcss_TemplateStyleEN.cssModuleAreaId, concss_TemplateStyle.cssModuleAreaId);
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.StyleId, 8, concss_TemplateStyle.StyleId);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.TemplateId, 8, concss_TemplateStyle.TemplateId);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.cssModuleAreaId, 8, concss_TemplateStyle.cssModuleAreaId);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.TemplateStyleName, 50, concss_TemplateStyle.TemplateStyleName);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.UpdDate, 20, concss_TemplateStyle.UpdDate);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.UpdUser, 20, concss_TemplateStyle.UpdUser);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.Memo, 1000, concss_TemplateStyle.Memo);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.TemplateStyleNameEn, 200, concss_TemplateStyle.TemplateStyleNameEn);
//检查字段外键固定长度
 objcss_TemplateStyleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.StyleId, 8, concss_TemplateStyle.StyleId);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.TemplateId, 8, concss_TemplateStyle.TemplateId);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.cssModuleAreaId, 8, concss_TemplateStyle.cssModuleAreaId);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.TemplateStyleName, 50, concss_TemplateStyle.TemplateStyleName);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.UpdDate, 20, concss_TemplateStyle.UpdDate);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.UpdUser, 20, concss_TemplateStyle.UpdUser);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.Memo, 1000, concss_TemplateStyle.Memo);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.TemplateStyleNameEn, 200, concss_TemplateStyle.TemplateStyleNameEn);
//检查外键字段长度
 objcss_TemplateStyleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.StyleId, 8, concss_TemplateStyle.StyleId);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.TemplateId, 8, concss_TemplateStyle.TemplateId);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.cssModuleAreaId, 8, concss_TemplateStyle.cssModuleAreaId);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.TemplateStyleName, 50, concss_TemplateStyle.TemplateStyleName);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.UpdDate, 20, concss_TemplateStyle.UpdDate);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.UpdUser, 20, concss_TemplateStyle.UpdUser);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.Memo, 1000, concss_TemplateStyle.Memo);
clsCheckSql.CheckFieldLen(objcss_TemplateStyleEN.TemplateStyleNameEn, 200, concss_TemplateStyle.TemplateStyleNameEn);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateStyleEN.StyleId, concss_TemplateStyle.StyleId);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateStyleEN.TemplateId, concss_TemplateStyle.TemplateId);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateStyleEN.cssModuleAreaId, concss_TemplateStyle.cssModuleAreaId);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateStyleEN.TemplateStyleName, concss_TemplateStyle.TemplateStyleName);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateStyleEN.UpdDate, concss_TemplateStyle.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateStyleEN.UpdUser, concss_TemplateStyle.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateStyleEN.Memo, concss_TemplateStyle.Memo);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateStyleEN.TemplateStyleNameEn, concss_TemplateStyle.TemplateStyleNameEn);
//检查外键字段长度
 objcss_TemplateStyleEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--css_TemplateStyle(css_TemplateStyle),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objcss_TemplateStyleEN.TemplateStyleName == null)
{
 sbCondition.AppendFormat(" and TemplateStyleName is null");
}
else
{
 sbCondition.AppendFormat(" and TemplateStyleName = '{0}'", objcss_TemplateStyleEN.TemplateStyleName);
}
 if (objcss_TemplateStyleEN.TemplateId == null)
{
 sbCondition.AppendFormat(" and TemplateId is null");
}
else
{
 sbCondition.AppendFormat(" and TemplateId = '{0}'", objcss_TemplateStyleEN.TemplateId);
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscss_TemplateStyleEN._CurrTabName);
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscss_TemplateStyleEN._CurrTabName, strCondition);
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
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
 objSQL = clscss_TemplateStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}