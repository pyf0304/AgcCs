
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCharEncodingDA
 表名:CharEncoding(00050263)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:34
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
 /// 字符编码(CharEncoding)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCharEncodingDA : clsCommBase4DA
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
 return clsCharEncodingEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCharEncodingEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCharEncodingEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCharEncodingEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCharEncodingEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCharEncodingId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCharEncodingId)
{
strCharEncodingId = strCharEncodingId.Replace("'", "''");
if (strCharEncodingId.Length > 20)
{
throw new Exception("(errid:Data000001)在表:CharEncoding中,检查关键字,长度不正确!(clsCharEncodingDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCharEncodingId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CharEncoding中,关键字不能为空 或 null!(clsCharEncodingDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCharEncodingId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCharEncodingDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCharEncodingDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = "Select * from CharEncoding where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CharEncoding(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCharEncodingDA: GetDataTable_CharEncoding)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = "Select * from CharEncoding where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCharEncodingDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCharEncodingDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = "Select * from CharEncoding where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCharEncodingDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCharEncodingDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CharEncoding where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CharEncoding where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCharEncodingDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CharEncoding where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCharEncodingDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CharEncoding.* " + 
$"from CharEncoding " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CharEncoding.CharEncodingId not in " + 
$"(Select top {intTop_In} CharEncoding.CharEncodingId from CharEncoding " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CharEncoding where {1} and CharEncodingId not in (Select top {2} CharEncodingId from CharEncoding where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CharEncoding where {1} and CharEncodingId not in (Select top {3} CharEncodingId from CharEncoding where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCharEncodingDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CharEncoding.* " + 
$"from CharEncoding " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CharEncoding.CharEncodingId not in " + 
$"(Select top {intTop_In} CharEncoding.CharEncodingId from CharEncoding " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CharEncoding where {1} and CharEncodingId not in (Select top {2} CharEncodingId from CharEncoding where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CharEncoding where {1} and CharEncodingId not in (Select top {3} CharEncodingId from CharEncoding where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCharEncodingEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCharEncodingDA:GetObjLst)", objException.Message));
}
List<clsCharEncodingEN> arrObjLst = new List<clsCharEncodingEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = "Select * from CharEncoding where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCharEncodingEN objCharEncodingEN = new clsCharEncodingEN();
try
{
objCharEncodingEN.CharEncodingId = objRow[conCharEncoding.CharEncodingId].ToString().Trim(); //字符编码
objCharEncodingEN.CharEncodingName = objRow[conCharEncoding.CharEncodingName].ToString().Trim(); //字符编码名称
objCharEncodingEN.IsDefault = TransNullToBool(objRow[conCharEncoding.IsDefault].ToString().Trim()); //是否默认
objCharEncodingEN.Memo = objRow[conCharEncoding.Memo] == DBNull.Value ? null : objRow[conCharEncoding.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCharEncodingDA: GetObjLst)", objException.Message));
}
objCharEncodingEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCharEncodingEN);
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
public List<clsCharEncodingEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCharEncodingDA:GetObjLstByTabName)", objException.Message));
}
List<clsCharEncodingEN> arrObjLst = new List<clsCharEncodingEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCharEncodingEN objCharEncodingEN = new clsCharEncodingEN();
try
{
objCharEncodingEN.CharEncodingId = objRow[conCharEncoding.CharEncodingId].ToString().Trim(); //字符编码
objCharEncodingEN.CharEncodingName = objRow[conCharEncoding.CharEncodingName].ToString().Trim(); //字符编码名称
objCharEncodingEN.IsDefault = TransNullToBool(objRow[conCharEncoding.IsDefault].ToString().Trim()); //是否默认
objCharEncodingEN.Memo = objRow[conCharEncoding.Memo] == DBNull.Value ? null : objRow[conCharEncoding.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCharEncodingDA: GetObjLst)", objException.Message));
}
objCharEncodingEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCharEncodingEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCharEncodingEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCharEncoding(ref clsCharEncodingEN objCharEncodingEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = "Select * from CharEncoding where CharEncodingId = " + "'"+ objCharEncodingEN.CharEncodingId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCharEncodingEN.CharEncodingId = objDT.Rows[0][conCharEncoding.CharEncodingId].ToString().Trim(); //字符编码(字段类型:varchar,字段长度:20,是否可空:False)
 objCharEncodingEN.CharEncodingName = objDT.Rows[0][conCharEncoding.CharEncodingName].ToString().Trim(); //字符编码名称(字段类型:varchar,字段长度:100,是否可空:False)
 objCharEncodingEN.IsDefault = TransNullToBool(objDT.Rows[0][conCharEncoding.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objCharEncodingEN.Memo = objDT.Rows[0][conCharEncoding.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCharEncodingDA: GetCharEncoding)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCharEncodingId">表关键字</param>
 /// <returns>表对象</returns>
public clsCharEncodingEN GetObjByCharEncodingId(string strCharEncodingId)
{
CheckPrimaryKey(strCharEncodingId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = "Select * from CharEncoding where CharEncodingId = " + "'"+ strCharEncodingId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCharEncodingEN objCharEncodingEN = new clsCharEncodingEN();
try
{
 objCharEncodingEN.CharEncodingId = objRow[conCharEncoding.CharEncodingId].ToString().Trim(); //字符编码(字段类型:varchar,字段长度:20,是否可空:False)
 objCharEncodingEN.CharEncodingName = objRow[conCharEncoding.CharEncodingName].ToString().Trim(); //字符编码名称(字段类型:varchar,字段长度:100,是否可空:False)
 objCharEncodingEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conCharEncoding.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objCharEncodingEN.Memo = objRow[conCharEncoding.Memo] == DBNull.Value ? null : objRow[conCharEncoding.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCharEncodingDA: GetObjByCharEncodingId)", objException.Message));
}
return objCharEncodingEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCharEncodingEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCharEncodingDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = "Select * from CharEncoding where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCharEncodingEN objCharEncodingEN = new clsCharEncodingEN()
{
CharEncodingId = objRow[conCharEncoding.CharEncodingId].ToString().Trim(), //字符编码
CharEncodingName = objRow[conCharEncoding.CharEncodingName].ToString().Trim(), //字符编码名称
IsDefault = TransNullToBool(objRow[conCharEncoding.IsDefault].ToString().Trim()), //是否默认
Memo = objRow[conCharEncoding.Memo] == DBNull.Value ? null : objRow[conCharEncoding.Memo].ToString().Trim() //说明
};
objCharEncodingEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCharEncodingEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCharEncodingDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCharEncodingEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCharEncodingEN objCharEncodingEN = new clsCharEncodingEN();
try
{
objCharEncodingEN.CharEncodingId = objRow[conCharEncoding.CharEncodingId].ToString().Trim(); //字符编码
objCharEncodingEN.CharEncodingName = objRow[conCharEncoding.CharEncodingName].ToString().Trim(); //字符编码名称
objCharEncodingEN.IsDefault = TransNullToBool(objRow[conCharEncoding.IsDefault].ToString().Trim()); //是否默认
objCharEncodingEN.Memo = objRow[conCharEncoding.Memo] == DBNull.Value ? null : objRow[conCharEncoding.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCharEncodingDA: GetObjByDataRowCharEncoding)", objException.Message));
}
objCharEncodingEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCharEncodingEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCharEncodingEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCharEncodingEN objCharEncodingEN = new clsCharEncodingEN();
try
{
objCharEncodingEN.CharEncodingId = objRow[conCharEncoding.CharEncodingId].ToString().Trim(); //字符编码
objCharEncodingEN.CharEncodingName = objRow[conCharEncoding.CharEncodingName].ToString().Trim(); //字符编码名称
objCharEncodingEN.IsDefault = TransNullToBool(objRow[conCharEncoding.IsDefault].ToString().Trim()); //是否默认
objCharEncodingEN.Memo = objRow[conCharEncoding.Memo] == DBNull.Value ? null : objRow[conCharEncoding.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCharEncodingDA: GetObjByDataRow)", objException.Message));
}
objCharEncodingEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCharEncodingEN;
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
objSQL = clsCharEncodingDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCharEncodingEN._CurrTabName, conCharEncoding.CharEncodingId, 20, "");
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
objSQL = clsCharEncodingDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCharEncodingEN._CurrTabName, conCharEncoding.CharEncodingId, 20, strPrefix);
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
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CharEncodingId from CharEncoding where " + strCondition;
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
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CharEncodingId from CharEncoding where " + strCondition;
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
 /// <param name = "strCharEncodingId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCharEncodingId)
{
CheckPrimaryKey(strCharEncodingId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CharEncoding", "CharEncodingId = " + "'"+ strCharEncodingId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCharEncodingDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CharEncoding", strCondition))
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
objSQL = clsCharEncodingDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CharEncoding");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCharEncodingEN objCharEncodingEN)
 {
 if (objCharEncodingEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCharEncodingEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = "Select * from CharEncoding where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CharEncoding");
objRow = objDS.Tables["CharEncoding"].NewRow();
objRow[conCharEncoding.CharEncodingId] = objCharEncodingEN.CharEncodingId; //字符编码
objRow[conCharEncoding.CharEncodingName] = objCharEncodingEN.CharEncodingName; //字符编码名称
objRow[conCharEncoding.IsDefault] = objCharEncodingEN.IsDefault; //是否默认
 if (objCharEncodingEN.Memo !=  "")
 {
objRow[conCharEncoding.Memo] = objCharEncodingEN.Memo; //说明
 }
objDS.Tables[clsCharEncodingEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCharEncodingEN._CurrTabName);
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
 /// <param name = "objCharEncodingEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCharEncodingEN objCharEncodingEN)
{
 if (objCharEncodingEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCharEncodingEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCharEncodingEN.CharEncodingId !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.CharEncodingId);
 var strCharEncodingId = objCharEncodingEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingId + "'");
 }
 
 if (objCharEncodingEN.CharEncodingName !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.CharEncodingName);
 var strCharEncodingName = objCharEncodingEN.CharEncodingName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingName + "'");
 }
 
 arrFieldListForInsert.Add(conCharEncoding.IsDefault);
 arrValueListForInsert.Add("'" + (objCharEncodingEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objCharEncodingEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.Memo);
 var strMemo = objCharEncodingEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CharEncoding");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCharEncodingEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCharEncodingEN objCharEncodingEN)
{
 if (objCharEncodingEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCharEncodingEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCharEncodingEN.CharEncodingId !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.CharEncodingId);
 var strCharEncodingId = objCharEncodingEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingId + "'");
 }
 
 if (objCharEncodingEN.CharEncodingName !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.CharEncodingName);
 var strCharEncodingName = objCharEncodingEN.CharEncodingName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingName + "'");
 }
 
 arrFieldListForInsert.Add(conCharEncoding.IsDefault);
 arrValueListForInsert.Add("'" + (objCharEncodingEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objCharEncodingEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.Memo);
 var strMemo = objCharEncodingEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CharEncoding");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCharEncodingEN.CharEncodingId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCharEncodingEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCharEncodingEN objCharEncodingEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCharEncodingEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCharEncodingEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCharEncodingEN.CharEncodingId !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.CharEncodingId);
 var strCharEncodingId = objCharEncodingEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingId + "'");
 }
 
 if (objCharEncodingEN.CharEncodingName !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.CharEncodingName);
 var strCharEncodingName = objCharEncodingEN.CharEncodingName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingName + "'");
 }
 
 arrFieldListForInsert.Add(conCharEncoding.IsDefault);
 arrValueListForInsert.Add("'" + (objCharEncodingEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objCharEncodingEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.Memo);
 var strMemo = objCharEncodingEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CharEncoding");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCharEncodingEN.CharEncodingId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCharEncodingEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCharEncodingEN objCharEncodingEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCharEncodingEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCharEncodingEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCharEncodingEN.CharEncodingId !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.CharEncodingId);
 var strCharEncodingId = objCharEncodingEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingId + "'");
 }
 
 if (objCharEncodingEN.CharEncodingName !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.CharEncodingName);
 var strCharEncodingName = objCharEncodingEN.CharEncodingName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingName + "'");
 }
 
 arrFieldListForInsert.Add(conCharEncoding.IsDefault);
 arrValueListForInsert.Add("'" + (objCharEncodingEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objCharEncodingEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCharEncoding.Memo);
 var strMemo = objCharEncodingEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CharEncoding");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCharEncodings(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = "Select * from CharEncoding where CharEncodingId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CharEncoding");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCharEncodingId = oRow[conCharEncoding.CharEncodingId].ToString().Trim();
if (IsExist(strCharEncodingId))
{
 string strResult = "关键字变量值为:" + string.Format("CharEncodingId = {0}", strCharEncodingId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCharEncodingEN._CurrTabName ].NewRow();
objRow[conCharEncoding.CharEncodingId] = oRow[conCharEncoding.CharEncodingId].ToString().Trim(); //字符编码
objRow[conCharEncoding.CharEncodingName] = oRow[conCharEncoding.CharEncodingName].ToString().Trim(); //字符编码名称
objRow[conCharEncoding.IsDefault] = oRow[conCharEncoding.IsDefault].ToString().Trim(); //是否默认
objRow[conCharEncoding.Memo] = oRow[conCharEncoding.Memo].ToString().Trim(); //说明
 objDS.Tables[clsCharEncodingEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCharEncodingEN._CurrTabName);
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
 /// <param name = "objCharEncodingEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCharEncodingEN objCharEncodingEN)
{
 if (objCharEncodingEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCharEncodingEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
strSQL = "Select * from CharEncoding where CharEncodingId = " + "'"+ objCharEncodingEN.CharEncodingId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCharEncodingEN._CurrTabName);
if (objDS.Tables[clsCharEncodingEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CharEncodingId = " + "'"+ objCharEncodingEN.CharEncodingId+"'");
return false;
}
objRow = objDS.Tables[clsCharEncodingEN._CurrTabName].Rows[0];
 if (objCharEncodingEN.IsUpdated(conCharEncoding.CharEncodingId))
 {
objRow[conCharEncoding.CharEncodingId] = objCharEncodingEN.CharEncodingId; //字符编码
 }
 if (objCharEncodingEN.IsUpdated(conCharEncoding.CharEncodingName))
 {
objRow[conCharEncoding.CharEncodingName] = objCharEncodingEN.CharEncodingName; //字符编码名称
 }
 if (objCharEncodingEN.IsUpdated(conCharEncoding.IsDefault))
 {
objRow[conCharEncoding.IsDefault] = objCharEncodingEN.IsDefault; //是否默认
 }
 if (objCharEncodingEN.IsUpdated(conCharEncoding.Memo))
 {
objRow[conCharEncoding.Memo] = objCharEncodingEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsCharEncodingEN._CurrTabName);
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
 /// <param name = "objCharEncodingEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCharEncodingEN objCharEncodingEN)
{
 if (objCharEncodingEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCharEncodingEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CharEncoding Set ");
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.CharEncodingName))
 {
 if (objCharEncodingEN.CharEncodingName !=  null)
 {
 var strCharEncodingName = objCharEncodingEN.CharEncodingName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCharEncodingName, conCharEncoding.CharEncodingName); //字符编码名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCharEncoding.CharEncodingName); //字符编码名称
 }
 }
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCharEncodingEN.IsDefault == true?"1":"0", conCharEncoding.IsDefault); //是否默认
 }
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.Memo))
 {
 if (objCharEncodingEN.Memo !=  null)
 {
 var strMemo = objCharEncodingEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCharEncoding.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCharEncoding.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CharEncodingId = '{0}'", objCharEncodingEN.CharEncodingId); 
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
 /// <param name = "objCharEncodingEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCharEncodingEN objCharEncodingEN, string strCondition)
{
 if (objCharEncodingEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCharEncodingEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CharEncoding Set ");
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.CharEncodingName))
 {
 if (objCharEncodingEN.CharEncodingName !=  null)
 {
 var strCharEncodingName = objCharEncodingEN.CharEncodingName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CharEncodingName = '{0}',", strCharEncodingName); //字符编码名称
 }
 else
 {
 sbSQL.Append(" CharEncodingName = null,"); //字符编码名称
 }
 }
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objCharEncodingEN.IsDefault == true?"1":"0"); //是否默认
 }
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.Memo))
 {
 if (objCharEncodingEN.Memo !=  null)
 {
 var strMemo = objCharEncodingEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCharEncodingEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCharEncodingEN objCharEncodingEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCharEncodingEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCharEncodingEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CharEncoding Set ");
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.CharEncodingName))
 {
 if (objCharEncodingEN.CharEncodingName !=  null)
 {
 var strCharEncodingName = objCharEncodingEN.CharEncodingName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CharEncodingName = '{0}',", strCharEncodingName); //字符编码名称
 }
 else
 {
 sbSQL.Append(" CharEncodingName = null,"); //字符编码名称
 }
 }
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objCharEncodingEN.IsDefault == true?"1":"0"); //是否默认
 }
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.Memo))
 {
 if (objCharEncodingEN.Memo !=  null)
 {
 var strMemo = objCharEncodingEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCharEncodingEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCharEncodingEN objCharEncodingEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCharEncodingEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCharEncodingEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CharEncoding Set ");
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.CharEncodingName))
 {
 if (objCharEncodingEN.CharEncodingName !=  null)
 {
 var strCharEncodingName = objCharEncodingEN.CharEncodingName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCharEncodingName, conCharEncoding.CharEncodingName); //字符编码名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCharEncoding.CharEncodingName); //字符编码名称
 }
 }
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCharEncodingEN.IsDefault == true?"1":"0", conCharEncoding.IsDefault); //是否默认
 }
 
 if (objCharEncodingEN.IsUpdated(conCharEncoding.Memo))
 {
 if (objCharEncodingEN.Memo !=  null)
 {
 var strMemo = objCharEncodingEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCharEncoding.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCharEncoding.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CharEncodingId = '{0}'", objCharEncodingEN.CharEncodingId); 
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
 /// <param name = "strCharEncodingId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCharEncodingId) 
{
CheckPrimaryKey(strCharEncodingId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCharEncodingId,
};
 objSQL.ExecSP("CharEncoding_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCharEncodingId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCharEncodingId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCharEncodingId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
//删除CharEncoding本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CharEncoding where CharEncodingId = " + "'"+ strCharEncodingId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCharEncoding(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
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
//删除CharEncoding本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CharEncoding where CharEncodingId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCharEncodingId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCharEncodingId) 
{
CheckPrimaryKey(strCharEncodingId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
//删除CharEncoding本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CharEncoding where CharEncodingId = " + "'"+ strCharEncodingId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCharEncoding(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCharEncodingDA: DelCharEncoding)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CharEncoding where " + strCondition ;
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
public bool DelCharEncodingWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCharEncodingDA: DelCharEncodingWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CharEncoding where " + strCondition ;
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
 /// <param name = "objCharEncodingENS">源对象</param>
 /// <param name = "objCharEncodingENT">目标对象</param>
public void CopyTo(clsCharEncodingEN objCharEncodingENS, clsCharEncodingEN objCharEncodingENT)
{
objCharEncodingENT.CharEncodingId = objCharEncodingENS.CharEncodingId; //字符编码
objCharEncodingENT.CharEncodingName = objCharEncodingENS.CharEncodingName; //字符编码名称
objCharEncodingENT.IsDefault = objCharEncodingENS.IsDefault; //是否默认
objCharEncodingENT.Memo = objCharEncodingENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCharEncodingEN objCharEncodingEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCharEncodingEN.CharEncodingName, conCharEncoding.CharEncodingName);
//检查字段长度
clsCheckSql.CheckFieldLen(objCharEncodingEN.CharEncodingId, 20, conCharEncoding.CharEncodingId);
clsCheckSql.CheckFieldLen(objCharEncodingEN.CharEncodingName, 100, conCharEncoding.CharEncodingName);
clsCheckSql.CheckFieldLen(objCharEncodingEN.Memo, 1000, conCharEncoding.Memo);
//检查字段外键固定长度
 objCharEncodingEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCharEncodingEN objCharEncodingEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCharEncodingEN.CharEncodingName, 100, conCharEncoding.CharEncodingName);
clsCheckSql.CheckFieldLen(objCharEncodingEN.Memo, 1000, conCharEncoding.Memo);
//检查外键字段长度
 objCharEncodingEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCharEncodingEN objCharEncodingEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCharEncodingEN.CharEncodingId, 20, conCharEncoding.CharEncodingId);
clsCheckSql.CheckFieldLen(objCharEncodingEN.CharEncodingName, 100, conCharEncoding.CharEncodingName);
clsCheckSql.CheckFieldLen(objCharEncodingEN.Memo, 1000, conCharEncoding.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCharEncodingEN.CharEncodingId, conCharEncoding.CharEncodingId);
clsCheckSql.CheckSqlInjection4Field(objCharEncodingEN.CharEncodingName, conCharEncoding.CharEncodingName);
clsCheckSql.CheckSqlInjection4Field(objCharEncodingEN.Memo, conCharEncoding.Memo);
//检查外键字段长度
 objCharEncodingEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCharEncodingId()
{
//获取某学院所有专业信息
string strSQL = "select CharEncodingId, CharEncodingName from CharEncoding ";
 clsSpecSQLforSql mySql = clsCharEncodingDA.GetSpecSQLObj();
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
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
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
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
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
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCharEncodingEN._CurrTabName);
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
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCharEncodingEN._CurrTabName, strCondition);
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
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
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
 objSQL = clsCharEncodingDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}