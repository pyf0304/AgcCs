
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTab4CodeConvDA
 表名:FieldTab4CodeConv(00050593)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:33
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
 /// 字段4代码转换(FieldTab4CodeConv)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFieldTab4CodeConvDA : clsCommBase4DA
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
 return clsFieldTab4CodeConvEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFieldTab4CodeConvEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFieldTab4CodeConvEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFieldTab4CodeConvEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFieldTab4CodeConvEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFldId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFldId)
{
strFldId = strFldId.Replace("'", "''");
if (strFldId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:FieldTab4CodeConv中,检查关键字,长度不正确!(clsFieldTab4CodeConvDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FieldTab4CodeConv中,关键字不能为空 或 null!(clsFieldTab4CodeConvDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFieldTab4CodeConvDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4CodeConv where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FieldTab4CodeConv(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: GetDataTable_FieldTab4CodeConv)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4CodeConv where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4CodeConv where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4CodeConv where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4CodeConv where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FieldTab4CodeConv where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FieldTab4CodeConv.* " + 
$"from FieldTab4CodeConv " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FieldTab4CodeConv.FldId not in " + 
$"(Select top {intTop_In} FieldTab4CodeConv.FldId from FieldTab4CodeConv " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4CodeConv where {1} and FldId not in (Select top {2} FldId from FieldTab4CodeConv where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4CodeConv where {1} and FldId not in (Select top {3} FldId from FieldTab4CodeConv where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FieldTab4CodeConv.* " + 
$"from FieldTab4CodeConv " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FieldTab4CodeConv.FldId not in " + 
$"(Select top {intTop_In} FieldTab4CodeConv.FldId from FieldTab4CodeConv " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4CodeConv where {1} and FldId not in (Select top {2} FldId from FieldTab4CodeConv where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4CodeConv where {1} and FldId not in (Select top {3} FldId from FieldTab4CodeConv where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFieldTab4CodeConvEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA:GetObjLst)", objException.Message));
}
List<clsFieldTab4CodeConvEN> arrObjLst = new List<clsFieldTab4CodeConvEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4CodeConv where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4CodeConvEN objFieldTab4CodeConvEN = new clsFieldTab4CodeConvEN();
try
{
objFieldTab4CodeConvEN.FldId = objRow[conFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objFieldTab4CodeConvEN.PrjId = objRow[conFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objFieldTab4CodeConvEN.CodeTabId = objRow[conFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objFieldTab4CodeConvEN.CodeTabNameId = objRow[conFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objFieldTab4CodeConvEN.CodeTabCodeId = objRow[conFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objFieldTab4CodeConvEN.UpdDate = objRow[conFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objFieldTab4CodeConvEN.UpdUser = objRow[conFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objFieldTab4CodeConvEN.Memo = objRow[conFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFieldTab4CodeConvDA: GetObjLst)", objException.Message));
}
objFieldTab4CodeConvEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFieldTab4CodeConvEN);
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
public List<clsFieldTab4CodeConvEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA:GetObjLstByTabName)", objException.Message));
}
List<clsFieldTab4CodeConvEN> arrObjLst = new List<clsFieldTab4CodeConvEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4CodeConvEN objFieldTab4CodeConvEN = new clsFieldTab4CodeConvEN();
try
{
objFieldTab4CodeConvEN.FldId = objRow[conFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objFieldTab4CodeConvEN.PrjId = objRow[conFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objFieldTab4CodeConvEN.CodeTabId = objRow[conFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objFieldTab4CodeConvEN.CodeTabNameId = objRow[conFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objFieldTab4CodeConvEN.CodeTabCodeId = objRow[conFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objFieldTab4CodeConvEN.UpdDate = objRow[conFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objFieldTab4CodeConvEN.UpdUser = objRow[conFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objFieldTab4CodeConvEN.Memo = objRow[conFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFieldTab4CodeConvDA: GetObjLst)", objException.Message));
}
objFieldTab4CodeConvEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFieldTab4CodeConvEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFieldTab4CodeConv(ref clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4CodeConv where FldId = " + "'"+ objFieldTab4CodeConvEN.FldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFieldTab4CodeConvEN.FldId = objDT.Rows[0][conFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objFieldTab4CodeConvEN.PrjId = objDT.Rows[0][conFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFieldTab4CodeConvEN.CodeTabId = objDT.Rows[0][conFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4CodeConvEN.CodeTabNameId = objDT.Rows[0][conFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4CodeConvEN.CodeTabCodeId = objDT.Rows[0][conFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4CodeConvEN.UpdDate = objDT.Rows[0][conFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTab4CodeConvEN.UpdUser = objDT.Rows[0][conFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTab4CodeConvEN.Memo = objDT.Rows[0][conFieldTab4CodeConv.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFieldTab4CodeConvDA: GetFieldTab4CodeConv)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public clsFieldTab4CodeConvEN GetObjByFldId(string strFldId)
{
CheckPrimaryKey(strFldId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4CodeConv where FldId = " + "'"+ strFldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFieldTab4CodeConvEN objFieldTab4CodeConvEN = new clsFieldTab4CodeConvEN();
try
{
 objFieldTab4CodeConvEN.FldId = objRow[conFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objFieldTab4CodeConvEN.PrjId = objRow[conFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFieldTab4CodeConvEN.CodeTabId = objRow[conFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4CodeConvEN.CodeTabNameId = objRow[conFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4CodeConvEN.CodeTabCodeId = objRow[conFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4CodeConvEN.UpdDate = objRow[conFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTab4CodeConvEN.UpdUser = objRow[conFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTab4CodeConvEN.Memo = objRow[conFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFieldTab4CodeConvDA: GetObjByFldId)", objException.Message));
}
return objFieldTab4CodeConvEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFieldTab4CodeConvEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4CodeConv where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFieldTab4CodeConvEN objFieldTab4CodeConvEN = new clsFieldTab4CodeConvEN()
{
FldId = objRow[conFieldTab4CodeConv.FldId].ToString().Trim(), //字段Id
PrjId = objRow[conFieldTab4CodeConv.PrjId].ToString().Trim(), //工程Id
CodeTabId = objRow[conFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabId].ToString().Trim(), //代码表Id
CodeTabNameId = objRow[conFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabNameId].ToString().Trim(), //代码_名Id
CodeTabCodeId = objRow[conFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(), //代码Id
UpdDate = objRow[conFieldTab4CodeConv.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.Memo].ToString().Trim() //说明
};
objFieldTab4CodeConvEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFieldTab4CodeConvEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFieldTab4CodeConvDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFieldTab4CodeConvEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFieldTab4CodeConvEN objFieldTab4CodeConvEN = new clsFieldTab4CodeConvEN();
try
{
objFieldTab4CodeConvEN.FldId = objRow[conFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objFieldTab4CodeConvEN.PrjId = objRow[conFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objFieldTab4CodeConvEN.CodeTabId = objRow[conFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objFieldTab4CodeConvEN.CodeTabNameId = objRow[conFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objFieldTab4CodeConvEN.CodeTabCodeId = objRow[conFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objFieldTab4CodeConvEN.UpdDate = objRow[conFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objFieldTab4CodeConvEN.UpdUser = objRow[conFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objFieldTab4CodeConvEN.Memo = objRow[conFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFieldTab4CodeConvDA: GetObjByDataRowFieldTab4CodeConv)", objException.Message));
}
objFieldTab4CodeConvEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFieldTab4CodeConvEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFieldTab4CodeConvEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFieldTab4CodeConvEN objFieldTab4CodeConvEN = new clsFieldTab4CodeConvEN();
try
{
objFieldTab4CodeConvEN.FldId = objRow[conFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objFieldTab4CodeConvEN.PrjId = objRow[conFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objFieldTab4CodeConvEN.CodeTabId = objRow[conFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objFieldTab4CodeConvEN.CodeTabNameId = objRow[conFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objFieldTab4CodeConvEN.CodeTabCodeId = objRow[conFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objFieldTab4CodeConvEN.UpdDate = objRow[conFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objFieldTab4CodeConvEN.UpdUser = objRow[conFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objFieldTab4CodeConvEN.Memo = objRow[conFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[conFieldTab4CodeConv.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFieldTab4CodeConvDA: GetObjByDataRow)", objException.Message));
}
objFieldTab4CodeConvEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFieldTab4CodeConvEN;
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
objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFieldTab4CodeConvEN._CurrTabName, conFieldTab4CodeConv.FldId, 8, "");
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
objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFieldTab4CodeConvEN._CurrTabName, conFieldTab4CodeConv.FldId, 8, strPrefix);
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
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FldId from FieldTab4CodeConv where " + strCondition;
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
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FldId from FieldTab4CodeConv where " + strCondition;
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
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFldId)
{
CheckPrimaryKey(strFldId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FieldTab4CodeConv", "FldId = " + "'"+ strFldId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FieldTab4CodeConv", strCondition))
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
objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FieldTab4CodeConv");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
 {
 objFieldTab4CodeConvEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4CodeConvEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTab4CodeConvEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4CodeConv where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FieldTab4CodeConv");
objRow = objDS.Tables["FieldTab4CodeConv"].NewRow();
objRow[conFieldTab4CodeConv.FldId] = objFieldTab4CodeConvEN.FldId; //字段Id
objRow[conFieldTab4CodeConv.PrjId] = objFieldTab4CodeConvEN.PrjId; //工程Id
 if (objFieldTab4CodeConvEN.CodeTabId !=  "")
 {
objRow[conFieldTab4CodeConv.CodeTabId] = objFieldTab4CodeConvEN.CodeTabId; //代码表Id
 }
 if (objFieldTab4CodeConvEN.CodeTabNameId !=  "")
 {
objRow[conFieldTab4CodeConv.CodeTabNameId] = objFieldTab4CodeConvEN.CodeTabNameId; //代码_名Id
 }
 if (objFieldTab4CodeConvEN.CodeTabCodeId !=  "")
 {
objRow[conFieldTab4CodeConv.CodeTabCodeId] = objFieldTab4CodeConvEN.CodeTabCodeId; //代码Id
 }
objRow[conFieldTab4CodeConv.UpdDate] = objFieldTab4CodeConvEN.UpdDate; //修改日期
 if (objFieldTab4CodeConvEN.UpdUser !=  "")
 {
objRow[conFieldTab4CodeConv.UpdUser] = objFieldTab4CodeConvEN.UpdUser; //修改者
 }
 if (objFieldTab4CodeConvEN.Memo !=  "")
 {
objRow[conFieldTab4CodeConv.Memo] = objFieldTab4CodeConvEN.Memo; //说明
 }
objDS.Tables[clsFieldTab4CodeConvEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFieldTab4CodeConvEN._CurrTabName);
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
 /// <param name = "objFieldTab4CodeConvEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
 objFieldTab4CodeConvEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4CodeConvEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTab4CodeConvEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFieldTab4CodeConvEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.FldId);
 var strFldId = objFieldTab4CodeConvEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objFieldTab4CodeConvEN.PrjId  ==  "")
 {
 objFieldTab4CodeConvEN.PrjId = null;
 }
 if (objFieldTab4CodeConvEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.PrjId);
 var strPrjId = objFieldTab4CodeConvEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabId);
 var strCodeTabId = objFieldTab4CodeConvEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabNameId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabNameId);
 var strCodeTabNameId = objFieldTab4CodeConvEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabNameId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabCodeId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabCodeId);
 var strCodeTabCodeId = objFieldTab4CodeConvEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCodeId + "'");
 }
 
 if (objFieldTab4CodeConvEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.UpdDate);
 var strUpdDate = objFieldTab4CodeConvEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTab4CodeConvEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.UpdUser);
 var strUpdUser = objFieldTab4CodeConvEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTab4CodeConvEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.Memo);
 var strMemo = objFieldTab4CodeConvEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab4CodeConv");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
 objFieldTab4CodeConvEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4CodeConvEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTab4CodeConvEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFieldTab4CodeConvEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.FldId);
 var strFldId = objFieldTab4CodeConvEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objFieldTab4CodeConvEN.PrjId  ==  "")
 {
 objFieldTab4CodeConvEN.PrjId = null;
 }
 if (objFieldTab4CodeConvEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.PrjId);
 var strPrjId = objFieldTab4CodeConvEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabId);
 var strCodeTabId = objFieldTab4CodeConvEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabNameId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabNameId);
 var strCodeTabNameId = objFieldTab4CodeConvEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabNameId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabCodeId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabCodeId);
 var strCodeTabCodeId = objFieldTab4CodeConvEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCodeId + "'");
 }
 
 if (objFieldTab4CodeConvEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.UpdDate);
 var strUpdDate = objFieldTab4CodeConvEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTab4CodeConvEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.UpdUser);
 var strUpdUser = objFieldTab4CodeConvEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTab4CodeConvEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.Memo);
 var strMemo = objFieldTab4CodeConvEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab4CodeConv");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFieldTab4CodeConvEN.FldId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFieldTab4CodeConvEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4CodeConvEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTab4CodeConvEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFieldTab4CodeConvEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.FldId);
 var strFldId = objFieldTab4CodeConvEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objFieldTab4CodeConvEN.PrjId  ==  "")
 {
 objFieldTab4CodeConvEN.PrjId = null;
 }
 if (objFieldTab4CodeConvEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.PrjId);
 var strPrjId = objFieldTab4CodeConvEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabId);
 var strCodeTabId = objFieldTab4CodeConvEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabNameId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabNameId);
 var strCodeTabNameId = objFieldTab4CodeConvEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabNameId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabCodeId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabCodeId);
 var strCodeTabCodeId = objFieldTab4CodeConvEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCodeId + "'");
 }
 
 if (objFieldTab4CodeConvEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.UpdDate);
 var strUpdDate = objFieldTab4CodeConvEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTab4CodeConvEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.UpdUser);
 var strUpdUser = objFieldTab4CodeConvEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTab4CodeConvEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.Memo);
 var strMemo = objFieldTab4CodeConvEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab4CodeConv");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFieldTab4CodeConvEN.FldId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFieldTab4CodeConvEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4CodeConvEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTab4CodeConvEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFieldTab4CodeConvEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.FldId);
 var strFldId = objFieldTab4CodeConvEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objFieldTab4CodeConvEN.PrjId  ==  "")
 {
 objFieldTab4CodeConvEN.PrjId = null;
 }
 if (objFieldTab4CodeConvEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.PrjId);
 var strPrjId = objFieldTab4CodeConvEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabId);
 var strCodeTabId = objFieldTab4CodeConvEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabNameId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabNameId);
 var strCodeTabNameId = objFieldTab4CodeConvEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabNameId + "'");
 }
 
 if (objFieldTab4CodeConvEN.CodeTabCodeId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.CodeTabCodeId);
 var strCodeTabCodeId = objFieldTab4CodeConvEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCodeId + "'");
 }
 
 if (objFieldTab4CodeConvEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.UpdDate);
 var strUpdDate = objFieldTab4CodeConvEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTab4CodeConvEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.UpdUser);
 var strUpdUser = objFieldTab4CodeConvEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTab4CodeConvEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4CodeConv.Memo);
 var strMemo = objFieldTab4CodeConvEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab4CodeConv");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFieldTab4CodeConvs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4CodeConv where FldId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FieldTab4CodeConv");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFldId = oRow[conFieldTab4CodeConv.FldId].ToString().Trim();
if (IsExist(strFldId))
{
 string strResult = "关键字变量值为:" + string.Format("FldId = {0}", strFldId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFieldTab4CodeConvEN._CurrTabName ].NewRow();
objRow[conFieldTab4CodeConv.FldId] = oRow[conFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objRow[conFieldTab4CodeConv.PrjId] = oRow[conFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objRow[conFieldTab4CodeConv.CodeTabId] = oRow[conFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objRow[conFieldTab4CodeConv.CodeTabNameId] = oRow[conFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objRow[conFieldTab4CodeConv.CodeTabCodeId] = oRow[conFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objRow[conFieldTab4CodeConv.UpdDate] = oRow[conFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objRow[conFieldTab4CodeConv.UpdUser] = oRow[conFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objRow[conFieldTab4CodeConv.Memo] = oRow[conFieldTab4CodeConv.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFieldTab4CodeConvEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFieldTab4CodeConvEN._CurrTabName);
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
 /// <param name = "objFieldTab4CodeConvEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
 objFieldTab4CodeConvEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4CodeConvEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTab4CodeConvEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4CodeConv where FldId = " + "'"+ objFieldTab4CodeConvEN.FldId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFieldTab4CodeConvEN._CurrTabName);
if (objDS.Tables[clsFieldTab4CodeConvEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FldId = " + "'"+ objFieldTab4CodeConvEN.FldId+"'");
return false;
}
objRow = objDS.Tables[clsFieldTab4CodeConvEN._CurrTabName].Rows[0];
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.FldId))
 {
objRow[conFieldTab4CodeConv.FldId] = objFieldTab4CodeConvEN.FldId; //字段Id
 }
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.PrjId))
 {
objRow[conFieldTab4CodeConv.PrjId] = objFieldTab4CodeConvEN.PrjId; //工程Id
 }
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabId))
 {
objRow[conFieldTab4CodeConv.CodeTabId] = objFieldTab4CodeConvEN.CodeTabId; //代码表Id
 }
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabNameId))
 {
objRow[conFieldTab4CodeConv.CodeTabNameId] = objFieldTab4CodeConvEN.CodeTabNameId; //代码_名Id
 }
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabCodeId))
 {
objRow[conFieldTab4CodeConv.CodeTabCodeId] = objFieldTab4CodeConvEN.CodeTabCodeId; //代码Id
 }
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.UpdDate))
 {
objRow[conFieldTab4CodeConv.UpdDate] = objFieldTab4CodeConvEN.UpdDate; //修改日期
 }
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.UpdUser))
 {
objRow[conFieldTab4CodeConv.UpdUser] = objFieldTab4CodeConvEN.UpdUser; //修改者
 }
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.Memo))
 {
objRow[conFieldTab4CodeConv.Memo] = objFieldTab4CodeConvEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFieldTab4CodeConvEN._CurrTabName);
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
 /// <param name = "objFieldTab4CodeConvEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
 objFieldTab4CodeConvEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4CodeConvEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTab4CodeConvEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FieldTab4CodeConv Set ");
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.PrjId))
 {
 if (objFieldTab4CodeConvEN.PrjId  ==  "")
 {
 objFieldTab4CodeConvEN.PrjId = null;
 }
 if (objFieldTab4CodeConvEN.PrjId !=  null)
 {
 var strPrjId = objFieldTab4CodeConvEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFieldTab4CodeConv.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.PrjId); //工程Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabId))
 {
 if (objFieldTab4CodeConvEN.CodeTabId !=  null)
 {
 var strCodeTabId = objFieldTab4CodeConvEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabId, conFieldTab4CodeConv.CodeTabId); //代码表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.CodeTabId); //代码表Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabNameId))
 {
 if (objFieldTab4CodeConvEN.CodeTabNameId !=  null)
 {
 var strCodeTabNameId = objFieldTab4CodeConvEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabNameId, conFieldTab4CodeConv.CodeTabNameId); //代码_名Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.CodeTabNameId); //代码_名Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabCodeId))
 {
 if (objFieldTab4CodeConvEN.CodeTabCodeId !=  null)
 {
 var strCodeTabCodeId = objFieldTab4CodeConvEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabCodeId, conFieldTab4CodeConv.CodeTabCodeId); //代码Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.CodeTabCodeId); //代码Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.UpdDate))
 {
 if (objFieldTab4CodeConvEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTab4CodeConvEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFieldTab4CodeConv.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.UpdDate); //修改日期
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.UpdUser))
 {
 if (objFieldTab4CodeConvEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTab4CodeConvEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFieldTab4CodeConv.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.UpdUser); //修改者
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.Memo))
 {
 if (objFieldTab4CodeConvEN.Memo !=  null)
 {
 var strMemo = objFieldTab4CodeConvEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFieldTab4CodeConv.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FldId = '{0}'", objFieldTab4CodeConvEN.FldId); 
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
 /// <param name = "objFieldTab4CodeConvEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strCondition)
{
 objFieldTab4CodeConvEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4CodeConvEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTab4CodeConvEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FieldTab4CodeConv Set ");
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.PrjId))
 {
 if (objFieldTab4CodeConvEN.PrjId  ==  "")
 {
 objFieldTab4CodeConvEN.PrjId = null;
 }
 if (objFieldTab4CodeConvEN.PrjId !=  null)
 {
 var strPrjId = objFieldTab4CodeConvEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabId))
 {
 if (objFieldTab4CodeConvEN.CodeTabId !=  null)
 {
 var strCodeTabId = objFieldTab4CodeConvEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabId = '{0}',", strCodeTabId); //代码表Id
 }
 else
 {
 sbSQL.Append(" CodeTabId = null,"); //代码表Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabNameId))
 {
 if (objFieldTab4CodeConvEN.CodeTabNameId !=  null)
 {
 var strCodeTabNameId = objFieldTab4CodeConvEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabNameId = '{0}',", strCodeTabNameId); //代码_名Id
 }
 else
 {
 sbSQL.Append(" CodeTabNameId = null,"); //代码_名Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabCodeId))
 {
 if (objFieldTab4CodeConvEN.CodeTabCodeId !=  null)
 {
 var strCodeTabCodeId = objFieldTab4CodeConvEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabCodeId = '{0}',", strCodeTabCodeId); //代码Id
 }
 else
 {
 sbSQL.Append(" CodeTabCodeId = null,"); //代码Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.UpdDate))
 {
 if (objFieldTab4CodeConvEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTab4CodeConvEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.UpdUser))
 {
 if (objFieldTab4CodeConvEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTab4CodeConvEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.Memo))
 {
 if (objFieldTab4CodeConvEN.Memo !=  null)
 {
 var strMemo = objFieldTab4CodeConvEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFieldTab4CodeConvEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFieldTab4CodeConvEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4CodeConvEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTab4CodeConvEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FieldTab4CodeConv Set ");
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.PrjId))
 {
 if (objFieldTab4CodeConvEN.PrjId  ==  "")
 {
 objFieldTab4CodeConvEN.PrjId = null;
 }
 if (objFieldTab4CodeConvEN.PrjId !=  null)
 {
 var strPrjId = objFieldTab4CodeConvEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabId))
 {
 if (objFieldTab4CodeConvEN.CodeTabId !=  null)
 {
 var strCodeTabId = objFieldTab4CodeConvEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabId = '{0}',", strCodeTabId); //代码表Id
 }
 else
 {
 sbSQL.Append(" CodeTabId = null,"); //代码表Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabNameId))
 {
 if (objFieldTab4CodeConvEN.CodeTabNameId !=  null)
 {
 var strCodeTabNameId = objFieldTab4CodeConvEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabNameId = '{0}',", strCodeTabNameId); //代码_名Id
 }
 else
 {
 sbSQL.Append(" CodeTabNameId = null,"); //代码_名Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabCodeId))
 {
 if (objFieldTab4CodeConvEN.CodeTabCodeId !=  null)
 {
 var strCodeTabCodeId = objFieldTab4CodeConvEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabCodeId = '{0}',", strCodeTabCodeId); //代码Id
 }
 else
 {
 sbSQL.Append(" CodeTabCodeId = null,"); //代码Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.UpdDate))
 {
 if (objFieldTab4CodeConvEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTab4CodeConvEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.UpdUser))
 {
 if (objFieldTab4CodeConvEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTab4CodeConvEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.Memo))
 {
 if (objFieldTab4CodeConvEN.Memo !=  null)
 {
 var strMemo = objFieldTab4CodeConvEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFieldTab4CodeConvEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFieldTab4CodeConvEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4CodeConvEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTab4CodeConvEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FieldTab4CodeConv Set ");
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.PrjId))
 {
 if (objFieldTab4CodeConvEN.PrjId  ==  "")
 {
 objFieldTab4CodeConvEN.PrjId = null;
 }
 if (objFieldTab4CodeConvEN.PrjId !=  null)
 {
 var strPrjId = objFieldTab4CodeConvEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFieldTab4CodeConv.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.PrjId); //工程Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabId))
 {
 if (objFieldTab4CodeConvEN.CodeTabId !=  null)
 {
 var strCodeTabId = objFieldTab4CodeConvEN.CodeTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabId, conFieldTab4CodeConv.CodeTabId); //代码表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.CodeTabId); //代码表Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabNameId))
 {
 if (objFieldTab4CodeConvEN.CodeTabNameId !=  null)
 {
 var strCodeTabNameId = objFieldTab4CodeConvEN.CodeTabNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabNameId, conFieldTab4CodeConv.CodeTabNameId); //代码_名Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.CodeTabNameId); //代码_名Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.CodeTabCodeId))
 {
 if (objFieldTab4CodeConvEN.CodeTabCodeId !=  null)
 {
 var strCodeTabCodeId = objFieldTab4CodeConvEN.CodeTabCodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabCodeId, conFieldTab4CodeConv.CodeTabCodeId); //代码Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.CodeTabCodeId); //代码Id
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.UpdDate))
 {
 if (objFieldTab4CodeConvEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTab4CodeConvEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFieldTab4CodeConv.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.UpdDate); //修改日期
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.UpdUser))
 {
 if (objFieldTab4CodeConvEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTab4CodeConvEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFieldTab4CodeConv.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.UpdUser); //修改者
 }
 }
 
 if (objFieldTab4CodeConvEN.IsUpdated(conFieldTab4CodeConv.Memo))
 {
 if (objFieldTab4CodeConvEN.Memo !=  null)
 {
 var strMemo = objFieldTab4CodeConvEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFieldTab4CodeConv.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4CodeConv.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FldId = '{0}'", objFieldTab4CodeConvEN.FldId); 
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
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFldId) 
{
CheckPrimaryKey(strFldId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFldId,
};
 objSQL.ExecSP("FieldTab4CodeConv_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFldId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFldId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFldId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
//删除FieldTab4CodeConv本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FieldTab4CodeConv where FldId = " + "'"+ strFldId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFieldTab4CodeConv(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
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
//删除FieldTab4CodeConv本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FieldTab4CodeConv where FldId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFldId) 
{
CheckPrimaryKey(strFldId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
//删除FieldTab4CodeConv本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FieldTab4CodeConv where FldId = " + "'"+ strFldId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFieldTab4CodeConv(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: DelFieldTab4CodeConv)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FieldTab4CodeConv where " + strCondition ;
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
public bool DelFieldTab4CodeConvWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFieldTab4CodeConvDA: DelFieldTab4CodeConvWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FieldTab4CodeConv where " + strCondition ;
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
 /// <param name = "objFieldTab4CodeConvENS">源对象</param>
 /// <param name = "objFieldTab4CodeConvENT">目标对象</param>
public void CopyTo(clsFieldTab4CodeConvEN objFieldTab4CodeConvENS, clsFieldTab4CodeConvEN objFieldTab4CodeConvENT)
{
objFieldTab4CodeConvENT.FldId = objFieldTab4CodeConvENS.FldId; //字段Id
objFieldTab4CodeConvENT.PrjId = objFieldTab4CodeConvENS.PrjId; //工程Id
objFieldTab4CodeConvENT.CodeTabId = objFieldTab4CodeConvENS.CodeTabId; //代码表Id
objFieldTab4CodeConvENT.CodeTabNameId = objFieldTab4CodeConvENS.CodeTabNameId; //代码_名Id
objFieldTab4CodeConvENT.CodeTabCodeId = objFieldTab4CodeConvENS.CodeTabCodeId; //代码Id
objFieldTab4CodeConvENT.UpdDate = objFieldTab4CodeConvENS.UpdDate; //修改日期
objFieldTab4CodeConvENT.UpdUser = objFieldTab4CodeConvENS.UpdUser; //修改者
objFieldTab4CodeConvENT.Memo = objFieldTab4CodeConvENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFieldTab4CodeConvEN.PrjId, conFieldTab4CodeConv.PrjId);
clsCheckSql.CheckFieldNotNull(objFieldTab4CodeConvEN.UpdDate, conFieldTab4CodeConv.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.FldId, 8, conFieldTab4CodeConv.FldId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.PrjId, 4, conFieldTab4CodeConv.PrjId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.CodeTabId, 8, conFieldTab4CodeConv.CodeTabId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.CodeTabNameId, 8, conFieldTab4CodeConv.CodeTabNameId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.CodeTabCodeId, 8, conFieldTab4CodeConv.CodeTabCodeId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.UpdDate, 20, conFieldTab4CodeConv.UpdDate);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.UpdUser, 20, conFieldTab4CodeConv.UpdUser);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.Memo, 1000, conFieldTab4CodeConv.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objFieldTab4CodeConvEN.PrjId, 4, conFieldTab4CodeConv.PrjId);
 objFieldTab4CodeConvEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.PrjId, 4, conFieldTab4CodeConv.PrjId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.CodeTabId, 8, conFieldTab4CodeConv.CodeTabId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.CodeTabNameId, 8, conFieldTab4CodeConv.CodeTabNameId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.CodeTabCodeId, 8, conFieldTab4CodeConv.CodeTabCodeId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.UpdDate, 20, conFieldTab4CodeConv.UpdDate);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.UpdUser, 20, conFieldTab4CodeConv.UpdUser);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.Memo, 1000, conFieldTab4CodeConv.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objFieldTab4CodeConvEN.PrjId, 4, conFieldTab4CodeConv.PrjId);
 objFieldTab4CodeConvEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.FldId, 8, conFieldTab4CodeConv.FldId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.PrjId, 4, conFieldTab4CodeConv.PrjId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.CodeTabId, 8, conFieldTab4CodeConv.CodeTabId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.CodeTabNameId, 8, conFieldTab4CodeConv.CodeTabNameId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.CodeTabCodeId, 8, conFieldTab4CodeConv.CodeTabCodeId);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.UpdDate, 20, conFieldTab4CodeConv.UpdDate);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.UpdUser, 20, conFieldTab4CodeConv.UpdUser);
clsCheckSql.CheckFieldLen(objFieldTab4CodeConvEN.Memo, 1000, conFieldTab4CodeConv.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFieldTab4CodeConvEN.FldId, conFieldTab4CodeConv.FldId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4CodeConvEN.PrjId, conFieldTab4CodeConv.PrjId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4CodeConvEN.CodeTabId, conFieldTab4CodeConv.CodeTabId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4CodeConvEN.CodeTabNameId, conFieldTab4CodeConv.CodeTabNameId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4CodeConvEN.CodeTabCodeId, conFieldTab4CodeConv.CodeTabCodeId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4CodeConvEN.UpdDate, conFieldTab4CodeConv.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4CodeConvEN.UpdUser, conFieldTab4CodeConv.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4CodeConvEN.Memo, conFieldTab4CodeConv.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objFieldTab4CodeConvEN.PrjId, 4, conFieldTab4CodeConv.PrjId);
 objFieldTab4CodeConvEN._IsCheckProperty = true;
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
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
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
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
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
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFieldTab4CodeConvEN._CurrTabName);
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
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFieldTab4CodeConvEN._CurrTabName, strCondition);
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
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
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
 objSQL = clsFieldTab4CodeConvDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}