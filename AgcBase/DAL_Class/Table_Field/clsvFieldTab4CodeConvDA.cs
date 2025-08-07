
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab4CodeConvDA
 表名:vFieldTab4CodeConv(00050594)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// vFieldTab4CodeConv(vFieldTab4CodeConv)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFieldTab4CodeConvDA : clsCommBase4DA
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
 return clsvFieldTab4CodeConvEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFieldTab4CodeConvEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFieldTab4CodeConvEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFieldTab4CodeConvEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFieldTab4CodeConvEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vFieldTab4CodeConv中,检查关键字,长度不正确!(clsvFieldTab4CodeConvDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFieldTab4CodeConv中,关键字不能为空 或 null!(clsvFieldTab4CodeConvDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFieldTab4CodeConvDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4CodeConv where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFieldTab4CodeConv(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA: GetDataTable_vFieldTab4CodeConv)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4CodeConv where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4CodeConv where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4CodeConv where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4CodeConv where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFieldTab4CodeConv where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFieldTab4CodeConv.* " + 
$"from vFieldTab4CodeConv " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFieldTab4CodeConv.FldId not in " + 
$"(Select top {intTop_In} vFieldTab4CodeConv.FldId from vFieldTab4CodeConv " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4CodeConv where {1} and FldId not in (Select top {2} FldId from vFieldTab4CodeConv where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4CodeConv where {1} and FldId not in (Select top {3} FldId from vFieldTab4CodeConv where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFieldTab4CodeConv.* " + 
$"from vFieldTab4CodeConv " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFieldTab4CodeConv.FldId not in " + 
$"(Select top {intTop_In} vFieldTab4CodeConv.FldId from vFieldTab4CodeConv " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4CodeConv where {1} and FldId not in (Select top {2} FldId from vFieldTab4CodeConv where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4CodeConv where {1} and FldId not in (Select top {3} FldId from vFieldTab4CodeConv where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFieldTab4CodeConvEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA:GetObjLst)", objException.Message));
}
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4CodeConv where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFieldTab4CodeConvDA: GetObjLst)", objException.Message));
}
objvFieldTab4CodeConvEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFieldTab4CodeConvEN);
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
public List<clsvFieldTab4CodeConvEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFieldTab4CodeConvDA: GetObjLst)", objException.Message));
}
objvFieldTab4CodeConvEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFieldTab4CodeConvEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFieldTab4CodeConv(ref clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4CodeConv where FldId = " + "'"+ objvFieldTab4CodeConvEN.FldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFieldTab4CodeConvEN.FldName = objDT.Rows[0][convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFieldTab4CodeConvEN.FldId = objDT.Rows[0][convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTab4CodeConvEN.PrjId = objDT.Rows[0][convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFieldTab4CodeConvEN.CodeTabId = objDT.Rows[0][convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4CodeConvEN.CodeTabNameId = objDT.Rows[0][convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4CodeConvEN.CodeTabCodeId = objDT.Rows[0][convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4CodeConvEN.UpdDate = objDT.Rows[0][convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab4CodeConvEN.UpdUser = objDT.Rows[0][convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab4CodeConvEN.Memo = objDT.Rows[0][convFieldTab4CodeConv.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFieldTab4CodeConvEN.CodeTab = objDT.Rows[0][convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab4CodeConvEN.CodeTabName = objDT.Rows[0][convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab4CodeConvEN.CodeTabCode = objDT.Rows[0][convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFieldTab4CodeConvDA: GetvFieldTab4CodeConv)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFieldTab4CodeConvEN GetObjByFldId(string strFldId)
{
CheckPrimaryKey(strFldId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4CodeConv where FldId = " + "'"+ strFldId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
 objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFieldTab4CodeConvDA: GetObjByFldId)", objException.Message));
}
return objvFieldTab4CodeConvEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFieldTab4CodeConvEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4CodeConv where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN()
{
FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(), //字段名
FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(), //字段Id
PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(), //工程Id
CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(), //代码表Id
CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(), //代码_名Id
CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(), //代码Id
UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(), //说明
CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(), //代码表
CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(), //表名
CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim() //代码表_代码
};
objvFieldTab4CodeConvEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab4CodeConvEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFieldTab4CodeConvDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFieldTab4CodeConvEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFieldTab4CodeConvDA: GetObjByDataRowvFieldTab4CodeConv)", objException.Message));
}
objvFieldTab4CodeConvEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab4CodeConvEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFieldTab4CodeConvEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFieldTab4CodeConvDA: GetObjByDataRow)", objException.Message));
}
objvFieldTab4CodeConvEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab4CodeConvEN;
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
objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFieldTab4CodeConvEN._CurrTabName, convFieldTab4CodeConv.FldId, 8, "");
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
objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFieldTab4CodeConvEN._CurrTabName, convFieldTab4CodeConv.FldId, 8, strPrefix);
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
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FldId from vFieldTab4CodeConv where " + strCondition;
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
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FldId from vFieldTab4CodeConv where " + strCondition;
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
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFieldTab4CodeConv", "FldId = " + "'"+ strFldId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFieldTab4CodeConvDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFieldTab4CodeConv", strCondition))
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
objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFieldTab4CodeConv");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvENS">源对象</param>
 /// <param name = "objvFieldTab4CodeConvENT">目标对象</param>
public void CopyTo(clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENS, clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENT)
{
objvFieldTab4CodeConvENT.FldName = objvFieldTab4CodeConvENS.FldName; //字段名
objvFieldTab4CodeConvENT.FldId = objvFieldTab4CodeConvENS.FldId; //字段Id
objvFieldTab4CodeConvENT.PrjId = objvFieldTab4CodeConvENS.PrjId; //工程Id
objvFieldTab4CodeConvENT.CodeTabId = objvFieldTab4CodeConvENS.CodeTabId; //代码表Id
objvFieldTab4CodeConvENT.CodeTabNameId = objvFieldTab4CodeConvENS.CodeTabNameId; //代码_名Id
objvFieldTab4CodeConvENT.CodeTabCodeId = objvFieldTab4CodeConvENS.CodeTabCodeId; //代码Id
objvFieldTab4CodeConvENT.UpdDate = objvFieldTab4CodeConvENS.UpdDate; //修改日期
objvFieldTab4CodeConvENT.UpdUser = objvFieldTab4CodeConvENS.UpdUser; //修改者
objvFieldTab4CodeConvENT.Memo = objvFieldTab4CodeConvENS.Memo; //说明
objvFieldTab4CodeConvENT.CodeTab = objvFieldTab4CodeConvENS.CodeTab; //代码表
objvFieldTab4CodeConvENT.CodeTabName = objvFieldTab4CodeConvENS.CodeTabName; //表名
objvFieldTab4CodeConvENT.CodeTabCode = objvFieldTab4CodeConvENS.CodeTabCode; //代码表_代码
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.FldName, 50, convFieldTab4CodeConv.FldName);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.FldId, 8, convFieldTab4CodeConv.FldId);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.PrjId, 4, convFieldTab4CodeConv.PrjId);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.CodeTabId, 8, convFieldTab4CodeConv.CodeTabId);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.CodeTabNameId, 8, convFieldTab4CodeConv.CodeTabNameId);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.CodeTabCodeId, 8, convFieldTab4CodeConv.CodeTabCodeId);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.UpdDate, 20, convFieldTab4CodeConv.UpdDate);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.UpdUser, 20, convFieldTab4CodeConv.UpdUser);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.Memo, 1000, convFieldTab4CodeConv.Memo);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.CodeTab, 50, convFieldTab4CodeConv.CodeTab);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.CodeTabName, 100, convFieldTab4CodeConv.CodeTabName);
clsCheckSql.CheckFieldLen(objvFieldTab4CodeConvEN.CodeTabCode, 50, convFieldTab4CodeConv.CodeTabCode);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.FldName, convFieldTab4CodeConv.FldName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.FldId, convFieldTab4CodeConv.FldId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.PrjId, convFieldTab4CodeConv.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.CodeTabId, convFieldTab4CodeConv.CodeTabId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.CodeTabNameId, convFieldTab4CodeConv.CodeTabNameId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.CodeTabCodeId, convFieldTab4CodeConv.CodeTabCodeId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.UpdDate, convFieldTab4CodeConv.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.UpdUser, convFieldTab4CodeConv.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.Memo, convFieldTab4CodeConv.Memo);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.CodeTab, convFieldTab4CodeConv.CodeTab);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.CodeTabName, convFieldTab4CodeConv.CodeTabName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4CodeConvEN.CodeTabCode, convFieldTab4CodeConv.CodeTabCode);
//检查外键字段长度
 objvFieldTab4CodeConvEN._IsCheckProperty = true;
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
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
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
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
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
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFieldTab4CodeConvEN._CurrTabName);
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
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFieldTab4CodeConvEN._CurrTabName, strCondition);
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
 objSQL = clsvFieldTab4CodeConvDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}