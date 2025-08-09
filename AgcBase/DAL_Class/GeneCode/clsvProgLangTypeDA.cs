
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProgLangTypeDA
 表名:vProgLangType(00050405)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:57
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
 /// v编程语言类型(vProgLangType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvProgLangTypeDA : clsCommBase4DA
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
 return clsvProgLangTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvProgLangTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvProgLangTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvProgLangTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvProgLangTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strProgLangTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strProgLangTypeId)
{
strProgLangTypeId = strProgLangTypeId.Replace("'", "''");
if (strProgLangTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:vProgLangType中,检查关键字,长度不正确!(clsvProgLangTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strProgLangTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vProgLangType中,关键字不能为空 或 null!(clsvProgLangTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProgLangTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvProgLangTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvProgLangTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
strSQL = "Select * from vProgLangType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vProgLangType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvProgLangTypeDA: GetDataTable_vProgLangType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
strSQL = "Select * from vProgLangType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvProgLangTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvProgLangTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
strSQL = "Select * from vProgLangType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvProgLangTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvProgLangTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vProgLangType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vProgLangType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvProgLangTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vProgLangType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvProgLangTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vProgLangType.* " + 
$"from vProgLangType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vProgLangType.ProgLangTypeId not in " + 
$"(Select top {intTop_In} vProgLangType.ProgLangTypeId from vProgLangType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vProgLangType where {1} and ProgLangTypeId not in (Select top {2} ProgLangTypeId from vProgLangType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vProgLangType where {1} and ProgLangTypeId not in (Select top {3} ProgLangTypeId from vProgLangType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvProgLangTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vProgLangType.* " + 
$"from vProgLangType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vProgLangType.ProgLangTypeId not in " + 
$"(Select top {intTop_In} vProgLangType.ProgLangTypeId from vProgLangType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vProgLangType where {1} and ProgLangTypeId not in (Select top {2} ProgLangTypeId from vProgLangType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vProgLangType where {1} and ProgLangTypeId not in (Select top {3} ProgLangTypeId from vProgLangType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvProgLangTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvProgLangTypeDA:GetObjLst)", objException.Message));
}
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
strSQL = "Select * from vProgLangType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = TransNullToBool(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = TransNullToInt(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvProgLangTypeDA: GetObjLst)", objException.Message));
}
objvProgLangTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvProgLangTypeEN);
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
public List<clsvProgLangTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvProgLangTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = TransNullToBool(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = TransNullToInt(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvProgLangTypeDA: GetObjLst)", objException.Message));
}
objvProgLangTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvProgLangTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvProgLangType(ref clsvProgLangTypeEN objvProgLangTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
strSQL = "Select * from vProgLangType where ProgLangTypeId = " + "'"+ objvProgLangTypeEN.ProgLangTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvProgLangTypeEN.ProgLangTypeId = objDT.Rows[0][convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvProgLangTypeEN.ProgLangTypeName = objDT.Rows[0][convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvProgLangTypeEN.ProgLangTypeENName = objDT.Rows[0][convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvProgLangTypeEN.CharEncodingId = objDT.Rows[0][convProgLangType.CharEncodingId].ToString().Trim(); //字符编码(字段类型:varchar,字段长度:20,是否可空:False)
 objvProgLangTypeEN.CharEncodingName = objDT.Rows[0][convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvProgLangTypeEN.IsVisible = TransNullToBool(objDT.Rows[0][convProgLangType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvProgLangTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][convProgLangType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvProgLangTypeEN.UpdDate = objDT.Rows[0][convProgLangType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvProgLangTypeEN.UpdUserId = objDT.Rows[0][convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvProgLangTypeEN.Memo = objDT.Rows[0][convProgLangType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvProgLangTypeDA: GetvProgLangType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strProgLangTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsvProgLangTypeEN GetObjByProgLangTypeId(string strProgLangTypeId)
{
CheckPrimaryKey(strProgLangTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
strSQL = "Select * from vProgLangType where ProgLangTypeId = " + "'"+ strProgLangTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
 objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码(字段类型:varchar,字段长度:20,是否可空:False)
 objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvProgLangTypeDA: GetObjByProgLangTypeId)", objException.Message));
}
return objvProgLangTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvProgLangTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvProgLangTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
strSQL = "Select * from vProgLangType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN()
{
ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(), //编程语言类型名
ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(), //编程语言类型英文名
CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(), //字符编码
CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(), //字符编码名称
IsVisible = TransNullToBool(objRow[convProgLangType.IsVisible].ToString().Trim()), //是否显示
OrderNum = TransNullToInt(objRow[convProgLangType.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim() //说明
};
objvProgLangTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvProgLangTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvProgLangTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvProgLangTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = TransNullToBool(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = TransNullToInt(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvProgLangTypeDA: GetObjByDataRowvProgLangType)", objException.Message));
}
objvProgLangTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvProgLangTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvProgLangTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = TransNullToBool(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = TransNullToInt(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvProgLangTypeDA: GetObjByDataRow)", objException.Message));
}
objvProgLangTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvProgLangTypeEN;
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
objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvProgLangTypeEN._CurrTabName, convProgLangType.ProgLangTypeId, 2, "");
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
objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvProgLangTypeEN._CurrTabName, convProgLangType.ProgLangTypeId, 2, strPrefix);
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
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ProgLangTypeId from vProgLangType where " + strCondition;
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
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ProgLangTypeId from vProgLangType where " + strCondition;
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
 /// <param name = "strProgLangTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strProgLangTypeId)
{
CheckPrimaryKey(strProgLangTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vProgLangType", "ProgLangTypeId = " + "'"+ strProgLangTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvProgLangTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vProgLangType", strCondition))
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
objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vProgLangType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvProgLangTypeENS">源对象</param>
 /// <param name = "objvProgLangTypeENT">目标对象</param>
public void CopyTo(clsvProgLangTypeEN objvProgLangTypeENS, clsvProgLangTypeEN objvProgLangTypeENT)
{
objvProgLangTypeENT.ProgLangTypeId = objvProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objvProgLangTypeENT.ProgLangTypeName = objvProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objvProgLangTypeENT.ProgLangTypeENName = objvProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objvProgLangTypeENT.CharEncodingId = objvProgLangTypeENS.CharEncodingId; //字符编码
objvProgLangTypeENT.CharEncodingName = objvProgLangTypeENS.CharEncodingName; //字符编码名称
objvProgLangTypeENT.IsVisible = objvProgLangTypeENS.IsVisible; //是否显示
objvProgLangTypeENT.OrderNum = objvProgLangTypeENS.OrderNum; //序号
objvProgLangTypeENT.UpdDate = objvProgLangTypeENS.UpdDate; //修改日期
objvProgLangTypeENT.UpdUserId = objvProgLangTypeENS.UpdUserId; //修改用户Id
objvProgLangTypeENT.Memo = objvProgLangTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvProgLangTypeEN objvProgLangTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvProgLangTypeEN.ProgLangTypeId, 2, convProgLangType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvProgLangTypeEN.ProgLangTypeName, 30, convProgLangType.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvProgLangTypeEN.ProgLangTypeENName, 50, convProgLangType.ProgLangTypeENName);
clsCheckSql.CheckFieldLen(objvProgLangTypeEN.CharEncodingId, 20, convProgLangType.CharEncodingId);
clsCheckSql.CheckFieldLen(objvProgLangTypeEN.CharEncodingName, 100, convProgLangType.CharEncodingName);
clsCheckSql.CheckFieldLen(objvProgLangTypeEN.UpdDate, 20, convProgLangType.UpdDate);
clsCheckSql.CheckFieldLen(objvProgLangTypeEN.UpdUserId, 20, convProgLangType.UpdUserId);
clsCheckSql.CheckFieldLen(objvProgLangTypeEN.Memo, 1000, convProgLangType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvProgLangTypeEN.ProgLangTypeId, convProgLangType.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvProgLangTypeEN.ProgLangTypeName, convProgLangType.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvProgLangTypeEN.ProgLangTypeENName, convProgLangType.ProgLangTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvProgLangTypeEN.CharEncodingId, convProgLangType.CharEncodingId);
clsCheckSql.CheckSqlInjection4Field(objvProgLangTypeEN.CharEncodingName, convProgLangType.CharEncodingName);
clsCheckSql.CheckSqlInjection4Field(objvProgLangTypeEN.UpdDate, convProgLangType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvProgLangTypeEN.UpdUserId, convProgLangType.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvProgLangTypeEN.Memo, convProgLangType.Memo);
//检查外键字段长度
 objvProgLangTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetProgLangTypeId()
{
//获取某学院所有专业信息
string strSQL = "select ProgLangTypeId, ProgLangTypeName from vProgLangType ";
 clsSpecSQLforSql mySql = clsvProgLangTypeDA.GetSpecSQLObj();
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
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
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
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
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
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvProgLangTypeEN._CurrTabName);
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
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvProgLangTypeEN._CurrTabName, strCondition);
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
 objSQL = clsvProgLangTypeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}