
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDict4GCDA
 表名:Dict4GC(00050351)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 生成代码字典(Dict4GC)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDict4GCDA : clsCommBase4DA
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
 return clsDict4GCEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDict4GCEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDict4GCEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDict4GCEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDict4GCEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDictId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDictId)
{
strDictId = strDictId.Replace("'", "''");
if (strDictId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:Dict4GC中,检查关键字,长度不正确!(clsDict4GCDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDictId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Dict4GC中,关键字不能为空 或 null!(clsDict4GCDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDictId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDict4GCDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDict4GCDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from Dict4GC where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Dict4GC(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDict4GCDA: GetDataTable_Dict4GC)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from Dict4GC where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDict4GCDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDict4GCDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from Dict4GC where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDict4GCDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDict4GCDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Dict4GC where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Dict4GC where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDict4GCDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Dict4GC where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDict4GCDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Dict4GC.* " + 
$"from Dict4GC " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Dict4GC.DictId not in " + 
$"(Select top {intTop_In} Dict4GC.DictId from Dict4GC " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Dict4GC where {1} and DictId not in (Select top {2} DictId from Dict4GC where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Dict4GC where {1} and DictId not in (Select top {3} DictId from Dict4GC where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDict4GCDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Dict4GC.* " + 
$"from Dict4GC " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Dict4GC.DictId not in " + 
$"(Select top {intTop_In} Dict4GC.DictId from Dict4GC " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Dict4GC where {1} and DictId not in (Select top {2} DictId from Dict4GC where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Dict4GC where {1} and DictId not in (Select top {3} DictId from Dict4GC where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDict4GCEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDict4GCDA:GetObjLst)", objException.Message));
}
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from Dict4GC where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDict4GCDA: GetObjLst)", objException.Message));
}
objDict4GCEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDict4GCEN);
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
public List<clsDict4GCEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDict4GCDA:GetObjLstByTabName)", objException.Message));
}
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDict4GCDA: GetObjLst)", objException.Message));
}
objDict4GCEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDict4GCEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDict4GCEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDict4GC(ref clsDict4GCEN objDict4GCEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from Dict4GC where DictId = " + "'"+ objDict4GCEN.DictId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDict4GCEN.DictId = objDT.Rows[0][conDict4GC.DictId].ToString().Trim(); //字典Id(字段类型:char,字段长度:8,是否可空:False)
 objDict4GCEN.DictValue = objDT.Rows[0][conDict4GC.DictValue].ToString().Trim(); //字典值(字段类型:varchar,字段长度:500,是否可空:False)
 objDict4GCEN.DictTypeId = objDT.Rows[0][conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id(字段类型:char,字段长度:4,是否可空:True)
 objDict4GCEN.DictKey1 = objDT.Rows[0][conDict4GC.DictKey1].ToString().Trim(); //字典关键字1(字段类型:varchar,字段长度:50,是否可空:False)
 objDict4GCEN.DictKey2 = objDT.Rows[0][conDict4GC.DictKey2].ToString().Trim(); //字典关键字2(字段类型:varchar,字段长度:50,是否可空:False)
 objDict4GCEN.UpdDate = objDT.Rows[0][conDict4GC.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDict4GCEN.UpdUser = objDT.Rows[0][conDict4GC.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDict4GCEN.Memo = objDT.Rows[0][conDict4GC.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDict4GCDA: GetDict4GC)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDictId">表关键字</param>
 /// <returns>表对象</returns>
public clsDict4GCEN GetObjByDictId(string strDictId)
{
CheckPrimaryKey(strDictId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from Dict4GC where DictId = " + "'"+ strDictId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
 objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id(字段类型:char,字段长度:8,是否可空:False)
 objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值(字段类型:varchar,字段长度:500,是否可空:False)
 objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id(字段类型:char,字段长度:4,是否可空:True)
 objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1(字段类型:varchar,字段长度:50,是否可空:False)
 objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2(字段类型:varchar,字段长度:50,是否可空:False)
 objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDict4GCDA: GetObjByDictId)", objException.Message));
}
return objDict4GCEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDict4GCEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDict4GCDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from Dict4GC where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN()
{
DictId = objRow[conDict4GC.DictId].ToString().Trim(), //字典Id
DictValue = objRow[conDict4GC.DictValue].ToString().Trim(), //字典值
DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(), //字典类型Id
DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(), //字典关键字1
DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(), //字典关键字2
UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim() //说明
};
objDict4GCEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDict4GCEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDict4GCDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDict4GCEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDict4GCDA: GetObjByDataRowDict4GC)", objException.Message));
}
objDict4GCEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDict4GCEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDict4GCEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDict4GCDA: GetObjByDataRow)", objException.Message));
}
objDict4GCEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDict4GCEN;
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
objSQL = clsDict4GCDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDict4GCEN._CurrTabName, conDict4GC.DictId, 8, "");
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
objSQL = clsDict4GCDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDict4GCEN._CurrTabName, conDict4GC.DictId, 8, strPrefix);
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
 objSQL = clsDict4GCDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DictId from Dict4GC where " + strCondition;
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
 objSQL = clsDict4GCDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DictId from Dict4GC where " + strCondition;
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
 /// <param name = "strDictId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDictId)
{
CheckPrimaryKey(strDictId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Dict4GC", "DictId = " + "'"+ strDictId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDict4GCDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Dict4GC", strCondition))
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
objSQL = clsDict4GCDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Dict4GC");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDict4GCEN objDict4GCEN)
 {
 objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDict4GCEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDict4GCEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from Dict4GC where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Dict4GC");
objRow = objDS.Tables["Dict4GC"].NewRow();
objRow[conDict4GC.DictId] = objDict4GCEN.DictId; //字典Id
objRow[conDict4GC.DictValue] = objDict4GCEN.DictValue; //字典值
 if (objDict4GCEN.DictTypeId !=  "")
 {
objRow[conDict4GC.DictTypeId] = objDict4GCEN.DictTypeId; //字典类型Id
 }
objRow[conDict4GC.DictKey1] = objDict4GCEN.DictKey1; //字典关键字1
 if (objDict4GCEN.DictKey2 !=  "")
 {
objRow[conDict4GC.DictKey2] = objDict4GCEN.DictKey2; //字典关键字2
 }
 if (objDict4GCEN.UpdDate !=  "")
 {
objRow[conDict4GC.UpdDate] = objDict4GCEN.UpdDate; //修改日期
 }
 if (objDict4GCEN.UpdUser !=  "")
 {
objRow[conDict4GC.UpdUser] = objDict4GCEN.UpdUser; //修改者
 }
 if (objDict4GCEN.Memo !=  "")
 {
objRow[conDict4GC.Memo] = objDict4GCEN.Memo; //说明
 }
objDS.Tables[clsDict4GCEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDict4GCEN._CurrTabName);
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDict4GCEN objDict4GCEN)
{
 objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDict4GCEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDict4GCEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDict4GCEN.DictId !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictId);
 var strDictId = objDict4GCEN.DictId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictId + "'");
 }
 
 if (objDict4GCEN.DictValue !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictValue);
 var strDictValue = objDict4GCEN.DictValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictValue + "'");
 }
 
 if (objDict4GCEN.DictTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictTypeId);
 var strDictTypeId = objDict4GCEN.DictTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictTypeId + "'");
 }
 
 if (objDict4GCEN.DictKey1 !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictKey1);
 var strDictKey1 = objDict4GCEN.DictKey1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictKey1 + "'");
 }
 
 if (objDict4GCEN.DictKey2 !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictKey2);
 var strDictKey2 = objDict4GCEN.DictKey2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictKey2 + "'");
 }
 
 if (objDict4GCEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.UpdDate);
 var strUpdDate = objDict4GCEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDict4GCEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.UpdUser);
 var strUpdUser = objDict4GCEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDict4GCEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.Memo);
 var strMemo = objDict4GCEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Dict4GC");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDict4GCEN objDict4GCEN)
{
 objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDict4GCEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDict4GCEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDict4GCEN.DictId !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictId);
 var strDictId = objDict4GCEN.DictId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictId + "'");
 }
 
 if (objDict4GCEN.DictValue !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictValue);
 var strDictValue = objDict4GCEN.DictValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictValue + "'");
 }
 
 if (objDict4GCEN.DictTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictTypeId);
 var strDictTypeId = objDict4GCEN.DictTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictTypeId + "'");
 }
 
 if (objDict4GCEN.DictKey1 !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictKey1);
 var strDictKey1 = objDict4GCEN.DictKey1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictKey1 + "'");
 }
 
 if (objDict4GCEN.DictKey2 !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictKey2);
 var strDictKey2 = objDict4GCEN.DictKey2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictKey2 + "'");
 }
 
 if (objDict4GCEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.UpdDate);
 var strUpdDate = objDict4GCEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDict4GCEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.UpdUser);
 var strUpdUser = objDict4GCEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDict4GCEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.Memo);
 var strMemo = objDict4GCEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Dict4GC");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDict4GCEN.DictId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDict4GCEN objDict4GCEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDict4GCEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDict4GCEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDict4GCEN.DictId !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictId);
 var strDictId = objDict4GCEN.DictId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictId + "'");
 }
 
 if (objDict4GCEN.DictValue !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictValue);
 var strDictValue = objDict4GCEN.DictValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictValue + "'");
 }
 
 if (objDict4GCEN.DictTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictTypeId);
 var strDictTypeId = objDict4GCEN.DictTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictTypeId + "'");
 }
 
 if (objDict4GCEN.DictKey1 !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictKey1);
 var strDictKey1 = objDict4GCEN.DictKey1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictKey1 + "'");
 }
 
 if (objDict4GCEN.DictKey2 !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictKey2);
 var strDictKey2 = objDict4GCEN.DictKey2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictKey2 + "'");
 }
 
 if (objDict4GCEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.UpdDate);
 var strUpdDate = objDict4GCEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDict4GCEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.UpdUser);
 var strUpdUser = objDict4GCEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDict4GCEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.Memo);
 var strMemo = objDict4GCEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Dict4GC");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDict4GCEN.DictId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDict4GCEN objDict4GCEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDict4GCEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDict4GCEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDict4GCEN.DictId !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictId);
 var strDictId = objDict4GCEN.DictId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictId + "'");
 }
 
 if (objDict4GCEN.DictValue !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictValue);
 var strDictValue = objDict4GCEN.DictValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictValue + "'");
 }
 
 if (objDict4GCEN.DictTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictTypeId);
 var strDictTypeId = objDict4GCEN.DictTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictTypeId + "'");
 }
 
 if (objDict4GCEN.DictKey1 !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictKey1);
 var strDictKey1 = objDict4GCEN.DictKey1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictKey1 + "'");
 }
 
 if (objDict4GCEN.DictKey2 !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.DictKey2);
 var strDictKey2 = objDict4GCEN.DictKey2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDictKey2 + "'");
 }
 
 if (objDict4GCEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.UpdDate);
 var strUpdDate = objDict4GCEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDict4GCEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.UpdUser);
 var strUpdUser = objDict4GCEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDict4GCEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDict4GC.Memo);
 var strMemo = objDict4GCEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Dict4GC");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDict4GCs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from Dict4GC where DictId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Dict4GC");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDictId = oRow[conDict4GC.DictId].ToString().Trim();
if (IsExist(strDictId))
{
 string strResult = "关键字变量值为:" + string.Format("DictId = {0}", strDictId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDict4GCEN._CurrTabName ].NewRow();
objRow[conDict4GC.DictId] = oRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objRow[conDict4GC.DictValue] = oRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objRow[conDict4GC.DictTypeId] = oRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objRow[conDict4GC.DictKey1] = oRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objRow[conDict4GC.DictKey2] = oRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objRow[conDict4GC.UpdDate] = oRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objRow[conDict4GC.UpdUser] = oRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objRow[conDict4GC.Memo] = oRow[conDict4GC.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDict4GCEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDict4GCEN._CurrTabName);
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
 /// <param name = "objDict4GCEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDict4GCEN objDict4GCEN)
{
 objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDict4GCEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDict4GCEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
strSQL = "Select * from Dict4GC where DictId = " + "'"+ objDict4GCEN.DictId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDict4GCEN._CurrTabName);
if (objDS.Tables[clsDict4GCEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DictId = " + "'"+ objDict4GCEN.DictId+"'");
return false;
}
objRow = objDS.Tables[clsDict4GCEN._CurrTabName].Rows[0];
 if (objDict4GCEN.IsUpdated(conDict4GC.DictId))
 {
objRow[conDict4GC.DictId] = objDict4GCEN.DictId; //字典Id
 }
 if (objDict4GCEN.IsUpdated(conDict4GC.DictValue))
 {
objRow[conDict4GC.DictValue] = objDict4GCEN.DictValue; //字典值
 }
 if (objDict4GCEN.IsUpdated(conDict4GC.DictTypeId))
 {
objRow[conDict4GC.DictTypeId] = objDict4GCEN.DictTypeId; //字典类型Id
 }
 if (objDict4GCEN.IsUpdated(conDict4GC.DictKey1))
 {
objRow[conDict4GC.DictKey1] = objDict4GCEN.DictKey1; //字典关键字1
 }
 if (objDict4GCEN.IsUpdated(conDict4GC.DictKey2))
 {
objRow[conDict4GC.DictKey2] = objDict4GCEN.DictKey2; //字典关键字2
 }
 if (objDict4GCEN.IsUpdated(conDict4GC.UpdDate))
 {
objRow[conDict4GC.UpdDate] = objDict4GCEN.UpdDate; //修改日期
 }
 if (objDict4GCEN.IsUpdated(conDict4GC.UpdUser))
 {
objRow[conDict4GC.UpdUser] = objDict4GCEN.UpdUser; //修改者
 }
 if (objDict4GCEN.IsUpdated(conDict4GC.Memo))
 {
objRow[conDict4GC.Memo] = objDict4GCEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDict4GCEN._CurrTabName);
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDict4GCEN objDict4GCEN)
{
 objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDict4GCEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDict4GCEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Dict4GC Set ");
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictValue))
 {
 if (objDict4GCEN.DictValue !=  null)
 {
 var strDictValue = objDict4GCEN.DictValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDictValue, conDict4GC.DictValue); //字典值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.DictValue); //字典值
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictTypeId))
 {
 if (objDict4GCEN.DictTypeId !=  null)
 {
 var strDictTypeId = objDict4GCEN.DictTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDictTypeId, conDict4GC.DictTypeId); //字典类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.DictTypeId); //字典类型Id
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictKey1))
 {
 if (objDict4GCEN.DictKey1 !=  null)
 {
 var strDictKey1 = objDict4GCEN.DictKey1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDictKey1, conDict4GC.DictKey1); //字典关键字1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.DictKey1); //字典关键字1
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictKey2))
 {
 if (objDict4GCEN.DictKey2 !=  null)
 {
 var strDictKey2 = objDict4GCEN.DictKey2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDictKey2, conDict4GC.DictKey2); //字典关键字2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.DictKey2); //字典关键字2
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.UpdDate))
 {
 if (objDict4GCEN.UpdDate !=  null)
 {
 var strUpdDate = objDict4GCEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDict4GC.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.UpdDate); //修改日期
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.UpdUser))
 {
 if (objDict4GCEN.UpdUser !=  null)
 {
 var strUpdUser = objDict4GCEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDict4GC.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.UpdUser); //修改者
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.Memo))
 {
 if (objDict4GCEN.Memo !=  null)
 {
 var strMemo = objDict4GCEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDict4GC.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DictId = '{0}'", objDict4GCEN.DictId); 
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
 /// <param name = "objDict4GCEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDict4GCEN objDict4GCEN, string strCondition)
{
 objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDict4GCEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDict4GCEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Dict4GC Set ");
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictValue))
 {
 if (objDict4GCEN.DictValue !=  null)
 {
 var strDictValue = objDict4GCEN.DictValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DictValue = '{0}',", strDictValue); //字典值
 }
 else
 {
 sbSQL.Append(" DictValue = null,"); //字典值
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictTypeId))
 {
 if (objDict4GCEN.DictTypeId !=  null)
 {
 var strDictTypeId = objDict4GCEN.DictTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DictTypeId = '{0}',", strDictTypeId); //字典类型Id
 }
 else
 {
 sbSQL.Append(" DictTypeId = null,"); //字典类型Id
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictKey1))
 {
 if (objDict4GCEN.DictKey1 !=  null)
 {
 var strDictKey1 = objDict4GCEN.DictKey1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DictKey1 = '{0}',", strDictKey1); //字典关键字1
 }
 else
 {
 sbSQL.Append(" DictKey1 = null,"); //字典关键字1
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictKey2))
 {
 if (objDict4GCEN.DictKey2 !=  null)
 {
 var strDictKey2 = objDict4GCEN.DictKey2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DictKey2 = '{0}',", strDictKey2); //字典关键字2
 }
 else
 {
 sbSQL.Append(" DictKey2 = null,"); //字典关键字2
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.UpdDate))
 {
 if (objDict4GCEN.UpdDate !=  null)
 {
 var strUpdDate = objDict4GCEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.UpdUser))
 {
 if (objDict4GCEN.UpdUser !=  null)
 {
 var strUpdUser = objDict4GCEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.Memo))
 {
 if (objDict4GCEN.Memo !=  null)
 {
 var strMemo = objDict4GCEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDict4GCEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDict4GCEN objDict4GCEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDict4GCEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDict4GCEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Dict4GC Set ");
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictValue))
 {
 if (objDict4GCEN.DictValue !=  null)
 {
 var strDictValue = objDict4GCEN.DictValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DictValue = '{0}',", strDictValue); //字典值
 }
 else
 {
 sbSQL.Append(" DictValue = null,"); //字典值
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictTypeId))
 {
 if (objDict4GCEN.DictTypeId !=  null)
 {
 var strDictTypeId = objDict4GCEN.DictTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DictTypeId = '{0}',", strDictTypeId); //字典类型Id
 }
 else
 {
 sbSQL.Append(" DictTypeId = null,"); //字典类型Id
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictKey1))
 {
 if (objDict4GCEN.DictKey1 !=  null)
 {
 var strDictKey1 = objDict4GCEN.DictKey1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DictKey1 = '{0}',", strDictKey1); //字典关键字1
 }
 else
 {
 sbSQL.Append(" DictKey1 = null,"); //字典关键字1
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictKey2))
 {
 if (objDict4GCEN.DictKey2 !=  null)
 {
 var strDictKey2 = objDict4GCEN.DictKey2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DictKey2 = '{0}',", strDictKey2); //字典关键字2
 }
 else
 {
 sbSQL.Append(" DictKey2 = null,"); //字典关键字2
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.UpdDate))
 {
 if (objDict4GCEN.UpdDate !=  null)
 {
 var strUpdDate = objDict4GCEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.UpdUser))
 {
 if (objDict4GCEN.UpdUser !=  null)
 {
 var strUpdUser = objDict4GCEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.Memo))
 {
 if (objDict4GCEN.Memo !=  null)
 {
 var strMemo = objDict4GCEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDict4GCEN objDict4GCEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDict4GCEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDict4GCEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Dict4GC Set ");
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictValue))
 {
 if (objDict4GCEN.DictValue !=  null)
 {
 var strDictValue = objDict4GCEN.DictValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDictValue, conDict4GC.DictValue); //字典值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.DictValue); //字典值
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictTypeId))
 {
 if (objDict4GCEN.DictTypeId !=  null)
 {
 var strDictTypeId = objDict4GCEN.DictTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDictTypeId, conDict4GC.DictTypeId); //字典类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.DictTypeId); //字典类型Id
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictKey1))
 {
 if (objDict4GCEN.DictKey1 !=  null)
 {
 var strDictKey1 = objDict4GCEN.DictKey1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDictKey1, conDict4GC.DictKey1); //字典关键字1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.DictKey1); //字典关键字1
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.DictKey2))
 {
 if (objDict4GCEN.DictKey2 !=  null)
 {
 var strDictKey2 = objDict4GCEN.DictKey2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDictKey2, conDict4GC.DictKey2); //字典关键字2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.DictKey2); //字典关键字2
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.UpdDate))
 {
 if (objDict4GCEN.UpdDate !=  null)
 {
 var strUpdDate = objDict4GCEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDict4GC.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.UpdDate); //修改日期
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.UpdUser))
 {
 if (objDict4GCEN.UpdUser !=  null)
 {
 var strUpdUser = objDict4GCEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDict4GC.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.UpdUser); //修改者
 }
 }
 
 if (objDict4GCEN.IsUpdated(conDict4GC.Memo))
 {
 if (objDict4GCEN.Memo !=  null)
 {
 var strMemo = objDict4GCEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDict4GC.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDict4GC.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DictId = '{0}'", objDict4GCEN.DictId); 
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
 /// <param name = "strDictId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDictId) 
{
CheckPrimaryKey(strDictId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDictId,
};
 objSQL.ExecSP("Dict4GC_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDictId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDictId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDictId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
//删除Dict4GC本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Dict4GC where DictId = " + "'"+ strDictId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDict4GC(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
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
//删除Dict4GC本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Dict4GC where DictId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDictId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDictId) 
{
CheckPrimaryKey(strDictId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
//删除Dict4GC本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Dict4GC where DictId = " + "'"+ strDictId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDict4GC(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDict4GCDA: DelDict4GC)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Dict4GC where " + strCondition ;
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
public bool DelDict4GCWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDict4GCDA: DelDict4GCWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDict4GCDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Dict4GC where " + strCondition ;
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
 /// <param name = "objDict4GCENS">源对象</param>
 /// <param name = "objDict4GCENT">目标对象</param>
public void CopyTo(clsDict4GCEN objDict4GCENS, clsDict4GCEN objDict4GCENT)
{
objDict4GCENT.DictId = objDict4GCENS.DictId; //字典Id
objDict4GCENT.DictValue = objDict4GCENS.DictValue; //字典值
objDict4GCENT.DictTypeId = objDict4GCENS.DictTypeId; //字典类型Id
objDict4GCENT.DictKey1 = objDict4GCENS.DictKey1; //字典关键字1
objDict4GCENT.DictKey2 = objDict4GCENS.DictKey2; //字典关键字2
objDict4GCENT.UpdDate = objDict4GCENS.UpdDate; //修改日期
objDict4GCENT.UpdUser = objDict4GCENS.UpdUser; //修改者
objDict4GCENT.Memo = objDict4GCENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDict4GCEN objDict4GCEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDict4GCEN.DictValue, conDict4GC.DictValue);
clsCheckSql.CheckFieldNotNull(objDict4GCEN.DictKey1, conDict4GC.DictKey1);
//检查字段长度
clsCheckSql.CheckFieldLen(objDict4GCEN.DictId, 8, conDict4GC.DictId);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictValue, 500, conDict4GC.DictValue);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictTypeId, 4, conDict4GC.DictTypeId);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictKey1, 50, conDict4GC.DictKey1);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictKey2, 50, conDict4GC.DictKey2);
clsCheckSql.CheckFieldLen(objDict4GCEN.UpdDate, 20, conDict4GC.UpdDate);
clsCheckSql.CheckFieldLen(objDict4GCEN.UpdUser, 20, conDict4GC.UpdUser);
clsCheckSql.CheckFieldLen(objDict4GCEN.Memo, 1000, conDict4GC.Memo);
//检查字段外键固定长度
 objDict4GCEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDict4GCEN objDict4GCEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDict4GCEN.DictValue, 500, conDict4GC.DictValue);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictTypeId, 4, conDict4GC.DictTypeId);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictKey1, 50, conDict4GC.DictKey1);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictKey2, 50, conDict4GC.DictKey2);
clsCheckSql.CheckFieldLen(objDict4GCEN.UpdDate, 20, conDict4GC.UpdDate);
clsCheckSql.CheckFieldLen(objDict4GCEN.UpdUser, 20, conDict4GC.UpdUser);
clsCheckSql.CheckFieldLen(objDict4GCEN.Memo, 1000, conDict4GC.Memo);
//检查外键字段长度
 objDict4GCEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDict4GCEN objDict4GCEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDict4GCEN.DictId, 8, conDict4GC.DictId);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictValue, 500, conDict4GC.DictValue);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictTypeId, 4, conDict4GC.DictTypeId);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictKey1, 50, conDict4GC.DictKey1);
clsCheckSql.CheckFieldLen(objDict4GCEN.DictKey2, 50, conDict4GC.DictKey2);
clsCheckSql.CheckFieldLen(objDict4GCEN.UpdDate, 20, conDict4GC.UpdDate);
clsCheckSql.CheckFieldLen(objDict4GCEN.UpdUser, 20, conDict4GC.UpdUser);
clsCheckSql.CheckFieldLen(objDict4GCEN.Memo, 1000, conDict4GC.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDict4GCEN.DictId, conDict4GC.DictId);
clsCheckSql.CheckSqlInjection4Field(objDict4GCEN.DictValue, conDict4GC.DictValue);
clsCheckSql.CheckSqlInjection4Field(objDict4GCEN.DictTypeId, conDict4GC.DictTypeId);
clsCheckSql.CheckSqlInjection4Field(objDict4GCEN.DictKey1, conDict4GC.DictKey1);
clsCheckSql.CheckSqlInjection4Field(objDict4GCEN.DictKey2, conDict4GC.DictKey2);
clsCheckSql.CheckSqlInjection4Field(objDict4GCEN.UpdDate, conDict4GC.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDict4GCEN.UpdUser, conDict4GC.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDict4GCEN.Memo, conDict4GC.Memo);
//检查外键字段长度
 objDict4GCEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Dict4GC(生成代码字典),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDict4GCEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDict4GCEN objDict4GCEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DictValue = '{0}'", objDict4GCEN.DictValue);
 if (objDict4GCEN.DictTypeId == null)
{
 sbCondition.AppendFormat(" and DictTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and DictTypeId = '{0}'", objDict4GCEN.DictTypeId);
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
 objSQL = clsDict4GCDA.GetSpecSQLObj();
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
 objSQL = clsDict4GCDA.GetSpecSQLObj();
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
 objSQL = clsDict4GCDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDict4GCEN._CurrTabName);
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
 objSQL = clsDict4GCDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDict4GCEN._CurrTabName, strCondition);
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
 objSQL = clsDict4GCDA.GetSpecSQLObj();
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
 objSQL = clsDict4GCDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}