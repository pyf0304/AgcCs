
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeDictTabDA
 表名:CodeDictTab(00050542)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:11
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// CodeDictTab(CodeDictTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCodeDictTabDA : clsCommBase4DA
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
 return clsCodeDictTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCodeDictTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCodeDictTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCodeDictTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCodeDictTabEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCodeTabCodeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCodeTabCodeId)
{
strCodeTabCodeId = strCodeTabCodeId.Replace("'", "''");
if (strCodeTabCodeId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CodeDictTab中,检查关键字,长度不正确!(clsCodeDictTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCodeTabCodeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CodeDictTab中,关键字不能为空 或 null!(clsCodeDictTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeTabCodeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCodeDictTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCodeDictTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = "Select * from CodeDictTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CodeDictTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCodeDictTabDA: GetDataTable_CodeDictTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = "Select * from CodeDictTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCodeDictTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCodeDictTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = "Select * from CodeDictTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCodeDictTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCodeDictTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodeDictTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodeDictTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCodeDictTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CodeDictTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCodeDictTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CodeDictTab.* " + 
$"from CodeDictTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CodeDictTab.CodeTabCodeId not in " + 
$"(Select top {intTop_In} CodeDictTab.CodeTabCodeId from CodeDictTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodeDictTab where {1} and CodeTabCodeId not in (Select top {2} CodeTabCodeId from CodeDictTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodeDictTab where {1} and CodeTabCodeId not in (Select top {3} CodeTabCodeId from CodeDictTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCodeDictTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CodeDictTab.* " + 
$"from CodeDictTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CodeDictTab.CodeTabCodeId not in " + 
$"(Select top {intTop_In} CodeDictTab.CodeTabCodeId from CodeDictTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodeDictTab where {1} and CodeTabCodeId not in (Select top {2} CodeTabCodeId from CodeDictTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodeDictTab where {1} and CodeTabCodeId not in (Select top {3} CodeTabCodeId from CodeDictTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCodeDictTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCodeDictTabDA:GetObjLst)", objException.Message));
}
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = "Select * from CodeDictTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCodeDictTabDA: GetObjLst)", objException.Message));
}
objCodeDictTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCodeDictTabEN);
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
public List<clsCodeDictTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCodeDictTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCodeDictTabDA: GetObjLst)", objException.Message));
}
objCodeDictTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCodeDictTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCodeDictTab(ref clsCodeDictTabEN objCodeDictTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = "Select * from CodeDictTab where CodeTabCodeId = " + "'"+ objCodeDictTabEN.CodeTabCodeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCodeDictTabEN.CodeTabCodeId = objDT.Rows[0][conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id(字段类型:char,字段长度:8,是否可空:True)
 objCodeDictTabEN.CodeTabId = objDT.Rows[0][conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id(字段类型:char,字段长度:8,是否可空:True)
 objCodeDictTabEN.CodeTabNameId = objDT.Rows[0][conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id(字段类型:char,字段长度:8,是否可空:True)
 objCodeDictTabEN.PrjId = objDT.Rows[0][conCodeDictTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCodeDictTabEN.UpdUser = objDT.Rows[0][conCodeDictTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeDictTabEN.UpdDate = objDT.Rows[0][conCodeDictTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeDictTabEN.Memo = objDT.Rows[0][conCodeDictTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCodeDictTabDA: GetCodeDictTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeTabCodeId">表关键字</param>
 /// <returns>表对象</returns>
public clsCodeDictTabEN GetObjByCodeTabCodeId(string strCodeTabCodeId)
{
CheckPrimaryKey(strCodeTabCodeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = "Select * from CodeDictTab where CodeTabCodeId = " + "'"+ strCodeTabCodeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
 objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id(字段类型:char,字段长度:8,是否可空:True)
 objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id(字段类型:char,字段长度:8,是否可空:True)
 objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id(字段类型:char,字段长度:8,是否可空:True)
 objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCodeDictTabDA: GetObjByCodeTabCodeId)", objException.Message));
}
return objCodeDictTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCodeDictTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCodeDictTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = "Select * from CodeDictTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN()
{
CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(), //代码Id
CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(), //代码表Id
CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(), //代码_名Id
PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim() //说明
};
objCodeDictTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeDictTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCodeDictTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCodeDictTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCodeDictTabDA: GetObjByDataRowCodeDictTab)", objException.Message));
}
objCodeDictTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeDictTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCodeDictTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCodeDictTabDA: GetObjByDataRow)", objException.Message));
}
objCodeDictTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeDictTabEN;
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
objSQL = clsCodeDictTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCodeDictTabEN._CurrTabName, conCodeDictTab.CodeTabCodeId, 8, "");
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
objSQL = clsCodeDictTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCodeDictTabEN._CurrTabName, conCodeDictTab.CodeTabCodeId, 8, strPrefix);
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
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CodeTabCodeId from CodeDictTab where " + strCondition;
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
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CodeTabCodeId from CodeDictTab where " + strCondition;
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
 /// <param name = "strCodeTabCodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCodeTabCodeId)
{
CheckPrimaryKey(strCodeTabCodeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CodeDictTab", "CodeTabCodeId = " + "'"+ strCodeTabCodeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCodeDictTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CodeDictTab", strCondition))
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
objSQL = clsCodeDictTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CodeDictTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCodeDictTabEN objCodeDictTabEN)
 {
 objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeDictTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeDictTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = "Select * from CodeDictTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CodeDictTab");
objRow = objDS.Tables["CodeDictTab"].NewRow();
objRow[conCodeDictTab.CodeTabCodeId] = objCodeDictTabEN.CodeTabCodeId; //代码Id
objRow[conCodeDictTab.CodeTabId] = objCodeDictTabEN.CodeTabId; //代码表Id
objRow[conCodeDictTab.CodeTabNameId] = objCodeDictTabEN.CodeTabNameId; //代码_名Id
objRow[conCodeDictTab.PrjId] = objCodeDictTabEN.PrjId; //工程Id
 if (objCodeDictTabEN.UpdUser !=  "")
 {
objRow[conCodeDictTab.UpdUser] = objCodeDictTabEN.UpdUser; //修改者
 }
objRow[conCodeDictTab.UpdDate] = objCodeDictTabEN.UpdDate; //修改日期
 if (objCodeDictTabEN.Memo !=  "")
 {
objRow[conCodeDictTab.Memo] = objCodeDictTabEN.Memo; //说明
 }
objDS.Tables[clsCodeDictTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCodeDictTabEN._CurrTabName);
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
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCodeDictTabEN objCodeDictTabEN)
{
 objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeDictTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeDictTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeDictTabEN.CodeTabCodeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabCodeId);
 var strCodeTabCodeId = objCodeDictTabEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCodeId + "'");
 }
 
 if (objCodeDictTabEN.CodeTabId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabId);
 var strCodeTabId = objCodeDictTabEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabId + "'");
 }
 
 if (objCodeDictTabEN.CodeTabNameId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabNameId);
 var strCodeTabNameId = objCodeDictTabEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabNameId + "'");
 }
 
 if (objCodeDictTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.PrjId);
 var strPrjId = objCodeDictTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCodeDictTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.UpdUser);
 var strUpdUser = objCodeDictTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeDictTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.UpdDate);
 var strUpdDate = objCodeDictTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeDictTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.Memo);
 var strMemo = objCodeDictTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeDictTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCodeDictTabEN objCodeDictTabEN)
{
 objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeDictTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeDictTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeDictTabEN.CodeTabCodeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabCodeId);
 var strCodeTabCodeId = objCodeDictTabEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCodeId + "'");
 }
 
 if (objCodeDictTabEN.CodeTabId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabId);
 var strCodeTabId = objCodeDictTabEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabId + "'");
 }
 
 if (objCodeDictTabEN.CodeTabNameId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabNameId);
 var strCodeTabNameId = objCodeDictTabEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabNameId + "'");
 }
 
 if (objCodeDictTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.PrjId);
 var strPrjId = objCodeDictTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCodeDictTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.UpdUser);
 var strUpdUser = objCodeDictTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeDictTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.UpdDate);
 var strUpdDate = objCodeDictTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeDictTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.Memo);
 var strMemo = objCodeDictTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeDictTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCodeDictTabEN.CodeTabCodeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCodeDictTabEN objCodeDictTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeDictTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeDictTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeDictTabEN.CodeTabCodeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabCodeId);
 var strCodeTabCodeId = objCodeDictTabEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCodeId + "'");
 }
 
 if (objCodeDictTabEN.CodeTabId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabId);
 var strCodeTabId = objCodeDictTabEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabId + "'");
 }
 
 if (objCodeDictTabEN.CodeTabNameId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabNameId);
 var strCodeTabNameId = objCodeDictTabEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabNameId + "'");
 }
 
 if (objCodeDictTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.PrjId);
 var strPrjId = objCodeDictTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCodeDictTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.UpdUser);
 var strUpdUser = objCodeDictTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeDictTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.UpdDate);
 var strUpdDate = objCodeDictTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeDictTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.Memo);
 var strMemo = objCodeDictTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeDictTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCodeDictTabEN.CodeTabCodeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCodeDictTabEN objCodeDictTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeDictTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeDictTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeDictTabEN.CodeTabCodeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabCodeId);
 var strCodeTabCodeId = objCodeDictTabEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCodeId + "'");
 }
 
 if (objCodeDictTabEN.CodeTabId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabId);
 var strCodeTabId = objCodeDictTabEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabId + "'");
 }
 
 if (objCodeDictTabEN.CodeTabNameId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.CodeTabNameId);
 var strCodeTabNameId = objCodeDictTabEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabNameId + "'");
 }
 
 if (objCodeDictTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.PrjId);
 var strPrjId = objCodeDictTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objCodeDictTabEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.UpdUser);
 var strUpdUser = objCodeDictTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeDictTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.UpdDate);
 var strUpdDate = objCodeDictTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeDictTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeDictTab.Memo);
 var strMemo = objCodeDictTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeDictTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCodeDictTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = "Select * from CodeDictTab where CodeTabCodeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CodeDictTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCodeTabCodeId = oRow[conCodeDictTab.CodeTabCodeId].ToString().Trim();
if (IsExist(strCodeTabCodeId))
{
 string strResult = "关键字变量值为:" + string.Format("CodeTabCodeId = {0}", strCodeTabCodeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCodeDictTabEN._CurrTabName ].NewRow();
objRow[conCodeDictTab.CodeTabCodeId] = oRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objRow[conCodeDictTab.CodeTabId] = oRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objRow[conCodeDictTab.CodeTabNameId] = oRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objRow[conCodeDictTab.PrjId] = oRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objRow[conCodeDictTab.UpdUser] = oRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objRow[conCodeDictTab.UpdDate] = oRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objRow[conCodeDictTab.Memo] = oRow[conCodeDictTab.Memo].ToString().Trim(); //说明
 objDS.Tables[clsCodeDictTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCodeDictTabEN._CurrTabName);
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
 /// <param name = "objCodeDictTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCodeDictTabEN objCodeDictTabEN)
{
 objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeDictTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeDictTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
strSQL = "Select * from CodeDictTab where CodeTabCodeId = " + "'"+ objCodeDictTabEN.CodeTabCodeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCodeDictTabEN._CurrTabName);
if (objDS.Tables[clsCodeDictTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CodeTabCodeId = " + "'"+ objCodeDictTabEN.CodeTabCodeId+"'");
return false;
}
objRow = objDS.Tables[clsCodeDictTabEN._CurrTabName].Rows[0];
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabCodeId))
 {
objRow[conCodeDictTab.CodeTabCodeId] = objCodeDictTabEN.CodeTabCodeId; //代码Id
 }
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabId))
 {
objRow[conCodeDictTab.CodeTabId] = objCodeDictTabEN.CodeTabId; //代码表Id
 }
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabNameId))
 {
objRow[conCodeDictTab.CodeTabNameId] = objCodeDictTabEN.CodeTabNameId; //代码_名Id
 }
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.PrjId))
 {
objRow[conCodeDictTab.PrjId] = objCodeDictTabEN.PrjId; //工程Id
 }
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.UpdUser))
 {
objRow[conCodeDictTab.UpdUser] = objCodeDictTabEN.UpdUser; //修改者
 }
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.UpdDate))
 {
objRow[conCodeDictTab.UpdDate] = objCodeDictTabEN.UpdDate; //修改日期
 }
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.Memo))
 {
objRow[conCodeDictTab.Memo] = objCodeDictTabEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsCodeDictTabEN._CurrTabName);
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
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCodeDictTabEN objCodeDictTabEN)
{
 objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeDictTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeDictTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CodeDictTab Set ");
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabId))
 {
 if (objCodeDictTabEN.CodeTabId !=  null)
 {
 var strCodeTabId = objCodeDictTabEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabId, conCodeDictTab.CodeTabId); //代码表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.CodeTabId); //代码表Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabNameId))
 {
 if (objCodeDictTabEN.CodeTabNameId !=  null)
 {
 var strCodeTabNameId = objCodeDictTabEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabNameId, conCodeDictTab.CodeTabNameId); //代码_名Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.CodeTabNameId); //代码_名Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.PrjId))
 {
 if (objCodeDictTabEN.PrjId !=  null)
 {
 var strPrjId = objCodeDictTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCodeDictTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.PrjId); //工程Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.UpdUser))
 {
 if (objCodeDictTabEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeDictTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCodeDictTab.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.UpdUser); //修改者
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.UpdDate))
 {
 if (objCodeDictTabEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeDictTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCodeDictTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.UpdDate); //修改日期
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.Memo))
 {
 if (objCodeDictTabEN.Memo !=  null)
 {
 var strMemo = objCodeDictTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCodeDictTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CodeTabCodeId = '{0}'", objCodeDictTabEN.CodeTabCodeId); 
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
 /// <param name = "objCodeDictTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCodeDictTabEN objCodeDictTabEN, string strCondition)
{
 objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeDictTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeDictTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodeDictTab Set ");
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabId))
 {
 if (objCodeDictTabEN.CodeTabId !=  null)
 {
 var strCodeTabId = objCodeDictTabEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabId = '{0}',", strCodeTabId); //代码表Id
 }
 else
 {
 sbSQL.Append(" CodeTabId = null,"); //代码表Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabNameId))
 {
 if (objCodeDictTabEN.CodeTabNameId !=  null)
 {
 var strCodeTabNameId = objCodeDictTabEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabNameId = '{0}',", strCodeTabNameId); //代码_名Id
 }
 else
 {
 sbSQL.Append(" CodeTabNameId = null,"); //代码_名Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.PrjId))
 {
 if (objCodeDictTabEN.PrjId !=  null)
 {
 var strPrjId = objCodeDictTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.UpdUser))
 {
 if (objCodeDictTabEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeDictTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.UpdDate))
 {
 if (objCodeDictTabEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeDictTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.Memo))
 {
 if (objCodeDictTabEN.Memo !=  null)
 {
 var strMemo = objCodeDictTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCodeDictTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCodeDictTabEN objCodeDictTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeDictTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeDictTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodeDictTab Set ");
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabId))
 {
 if (objCodeDictTabEN.CodeTabId !=  null)
 {
 var strCodeTabId = objCodeDictTabEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabId = '{0}',", strCodeTabId); //代码表Id
 }
 else
 {
 sbSQL.Append(" CodeTabId = null,"); //代码表Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabNameId))
 {
 if (objCodeDictTabEN.CodeTabNameId !=  null)
 {
 var strCodeTabNameId = objCodeDictTabEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabNameId = '{0}',", strCodeTabNameId); //代码_名Id
 }
 else
 {
 sbSQL.Append(" CodeTabNameId = null,"); //代码_名Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.PrjId))
 {
 if (objCodeDictTabEN.PrjId !=  null)
 {
 var strPrjId = objCodeDictTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.UpdUser))
 {
 if (objCodeDictTabEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeDictTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.UpdDate))
 {
 if (objCodeDictTabEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeDictTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.Memo))
 {
 if (objCodeDictTabEN.Memo !=  null)
 {
 var strMemo = objCodeDictTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCodeDictTabEN objCodeDictTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeDictTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeDictTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodeDictTab Set ");
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabId))
 {
 if (objCodeDictTabEN.CodeTabId !=  null)
 {
 var strCodeTabId = objCodeDictTabEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabId, conCodeDictTab.CodeTabId); //代码表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.CodeTabId); //代码表Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.CodeTabNameId))
 {
 if (objCodeDictTabEN.CodeTabNameId !=  null)
 {
 var strCodeTabNameId = objCodeDictTabEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabNameId, conCodeDictTab.CodeTabNameId); //代码_名Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.CodeTabNameId); //代码_名Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.PrjId))
 {
 if (objCodeDictTabEN.PrjId !=  null)
 {
 var strPrjId = objCodeDictTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conCodeDictTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.PrjId); //工程Id
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.UpdUser))
 {
 if (objCodeDictTabEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeDictTabEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCodeDictTab.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.UpdUser); //修改者
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.UpdDate))
 {
 if (objCodeDictTabEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeDictTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCodeDictTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.UpdDate); //修改日期
 }
 }
 
 if (objCodeDictTabEN.IsUpdated(conCodeDictTab.Memo))
 {
 if (objCodeDictTabEN.Memo !=  null)
 {
 var strMemo = objCodeDictTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCodeDictTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeDictTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CodeTabCodeId = '{0}'", objCodeDictTabEN.CodeTabCodeId); 
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
 /// <param name = "strCodeTabCodeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCodeTabCodeId) 
{
CheckPrimaryKey(strCodeTabCodeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCodeTabCodeId,
};
 objSQL.ExecSP("CodeDictTab_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCodeTabCodeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCodeTabCodeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCodeTabCodeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
//删除CodeDictTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodeDictTab where CodeTabCodeId = " + "'"+ strCodeTabCodeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCodeDictTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
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
//删除CodeDictTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodeDictTab where CodeTabCodeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCodeTabCodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCodeTabCodeId) 
{
CheckPrimaryKey(strCodeTabCodeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
//删除CodeDictTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodeDictTab where CodeTabCodeId = " + "'"+ strCodeTabCodeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCodeDictTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCodeDictTabDA: DelCodeDictTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CodeDictTab where " + strCondition ;
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
public bool DelCodeDictTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCodeDictTabDA: DelCodeDictTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CodeDictTab where " + strCondition ;
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
 /// <param name = "objCodeDictTabENS">源对象</param>
 /// <param name = "objCodeDictTabENT">目标对象</param>
public void CopyTo(clsCodeDictTabEN objCodeDictTabENS, clsCodeDictTabEN objCodeDictTabENT)
{
objCodeDictTabENT.CodeTabCodeId = objCodeDictTabENS.CodeTabCodeId; //代码Id
objCodeDictTabENT.CodeTabId = objCodeDictTabENS.CodeTabId; //代码表Id
objCodeDictTabENT.CodeTabNameId = objCodeDictTabENS.CodeTabNameId; //代码_名Id
objCodeDictTabENT.PrjId = objCodeDictTabENS.PrjId; //工程Id
objCodeDictTabENT.UpdUser = objCodeDictTabENS.UpdUser; //修改者
objCodeDictTabENT.UpdDate = objCodeDictTabENS.UpdDate; //修改日期
objCodeDictTabENT.Memo = objCodeDictTabENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCodeDictTabEN objCodeDictTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCodeDictTabEN.CodeTabId, conCodeDictTab.CodeTabId);
clsCheckSql.CheckFieldNotNull(objCodeDictTabEN.CodeTabNameId, conCodeDictTab.CodeTabNameId);
clsCheckSql.CheckFieldNotNull(objCodeDictTabEN.PrjId, conCodeDictTab.PrjId);
clsCheckSql.CheckFieldNotNull(objCodeDictTabEN.UpdDate, conCodeDictTab.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeDictTabEN.CodeTabCodeId, 8, conCodeDictTab.CodeTabCodeId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.CodeTabId, 8, conCodeDictTab.CodeTabId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.CodeTabNameId, 8, conCodeDictTab.CodeTabNameId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.PrjId, 4, conCodeDictTab.PrjId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.UpdUser, 20, conCodeDictTab.UpdUser);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.UpdDate, 20, conCodeDictTab.UpdDate);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.Memo, 1000, conCodeDictTab.Memo);
//检查字段外键固定长度
 objCodeDictTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCodeDictTabEN objCodeDictTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeDictTabEN.CodeTabId, 8, conCodeDictTab.CodeTabId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.CodeTabNameId, 8, conCodeDictTab.CodeTabNameId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.PrjId, 4, conCodeDictTab.PrjId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.UpdUser, 20, conCodeDictTab.UpdUser);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.UpdDate, 20, conCodeDictTab.UpdDate);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.Memo, 1000, conCodeDictTab.Memo);
//检查外键字段长度
 objCodeDictTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCodeDictTabEN objCodeDictTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeDictTabEN.CodeTabCodeId, 8, conCodeDictTab.CodeTabCodeId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.CodeTabId, 8, conCodeDictTab.CodeTabId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.CodeTabNameId, 8, conCodeDictTab.CodeTabNameId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.PrjId, 4, conCodeDictTab.PrjId);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.UpdUser, 20, conCodeDictTab.UpdUser);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.UpdDate, 20, conCodeDictTab.UpdDate);
clsCheckSql.CheckFieldLen(objCodeDictTabEN.Memo, 1000, conCodeDictTab.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCodeDictTabEN.CodeTabCodeId, conCodeDictTab.CodeTabCodeId);
clsCheckSql.CheckSqlInjection4Field(objCodeDictTabEN.CodeTabId, conCodeDictTab.CodeTabId);
clsCheckSql.CheckSqlInjection4Field(objCodeDictTabEN.CodeTabNameId, conCodeDictTab.CodeTabNameId);
clsCheckSql.CheckSqlInjection4Field(objCodeDictTabEN.PrjId, conCodeDictTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objCodeDictTabEN.UpdUser, conCodeDictTab.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCodeDictTabEN.UpdDate, conCodeDictTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCodeDictTabEN.Memo, conCodeDictTab.Memo);
//检查外键字段长度
 objCodeDictTabEN._IsCheckProperty = true;
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
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
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
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
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
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCodeDictTabEN._CurrTabName);
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
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCodeDictTabEN._CurrTabName, strCondition);
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
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
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
 objSQL = clsCodeDictTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}