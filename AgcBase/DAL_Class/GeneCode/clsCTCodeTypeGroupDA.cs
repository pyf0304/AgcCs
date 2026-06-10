
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCTCodeTypeGroupDA
 表名:CTCodeTypeGroup(00050648)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/06 11:43:46
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
 /// CTCodeTypeGroup(CTCodeTypeGroup)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCTCodeTypeGroupDA : clsCommBase4DA
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
 return clsCTCodeTypeGroupEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCTCodeTypeGroupEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCTCodeTypeGroupEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCTCodeTypeGroupEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCTCodeTypeGroupEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCtGroupId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCtGroupId)
{
strCtGroupId = strCtGroupId.Replace("'", "''");
if (strCtGroupId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:CTCodeTypeGroup中,检查关键字,长度不正确!(clsCTCodeTypeGroupDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCtGroupId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CTCodeTypeGroup中,关键字不能为空 或 null!(clsCTCodeTypeGroupDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCtGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCTCodeTypeGroupDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CTCodeTypeGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: GetDataTable_CTCodeTypeGroup)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroup where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroup where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroup where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CTCodeTypeGroup.* " + 
$"from CTCodeTypeGroup " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CTCodeTypeGroup.CtGroupId not in " + 
$"(Select top {intTop_In} CTCodeTypeGroup.CtGroupId from CTCodeTypeGroup " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroup where {1} and CtGroupId not in (Select top {2} CtGroupId from CTCodeTypeGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroup where {1} and CtGroupId not in (Select top {3} CtGroupId from CTCodeTypeGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CTCodeTypeGroup.* " + 
$"from CTCodeTypeGroup " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CTCodeTypeGroup.CtGroupId not in " + 
$"(Select top {intTop_In} CTCodeTypeGroup.CtGroupId from CTCodeTypeGroup " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroup where {1} and CtGroupId not in (Select top {2} CtGroupId from CTCodeTypeGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroup where {1} and CtGroupId not in (Select top {3} CtGroupId from CTCodeTypeGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCTCodeTypeGroupEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA:GetObjLst)", objException.Message));
}
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = TransNullToInt(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = TransNullToBool(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCTCodeTypeGroupDA: GetObjLst)", objException.Message));
}
objCTCodeTypeGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCTCodeTypeGroupEN);
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
public List<clsCTCodeTypeGroupEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA:GetObjLstByTabName)", objException.Message));
}
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = TransNullToInt(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = TransNullToBool(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCTCodeTypeGroupDA: GetObjLst)", objException.Message));
}
objCTCodeTypeGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCTCodeTypeGroupEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCTCodeTypeGroup(ref clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroup where CtGroupId = " + "'"+ objCTCodeTypeGroupEN.CtGroupId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCTCodeTypeGroupEN.CtGroupId = objDT.Rows[0][conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id(字段类型:char,字段长度:4,是否可空:True)
 objCTCodeTypeGroupEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objCTCodeTypeGroupEN.GroupName = objDT.Rows[0][conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objCTCodeTypeGroupEN.GroupENName = objDT.Rows[0][conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objCTCodeTypeGroupEN.Description = objDT.Rows[0][conCTCodeTypeGroup.Description].ToString().Trim(); //描述(字段类型:varchar,字段长度:300,是否可空:True)
 objCTCodeTypeGroupEN.OrderNum = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCTCodeTypeGroupEN.InUse = TransNullToBool(objDT.Rows[0][conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCTCodeTypeGroupEN.UpdDate = objDT.Rows[0][conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCTCodeTypeGroupEN.UpdUser = objDT.Rows[0][conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCTCodeTypeGroupDA: GetCTCodeTypeGroup)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCtGroupId">表关键字</param>
 /// <returns>表对象</returns>
public clsCTCodeTypeGroupEN GetObjByCtGroupId(string strCtGroupId)
{
CheckPrimaryKey(strCtGroupId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroup where CtGroupId = " + "'"+ strCtGroupId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
 objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id(字段类型:char,字段长度:4,是否可空:True)
 objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述(字段类型:varchar,字段长度:300,是否可空:True)
 objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCTCodeTypeGroupDA: GetObjByCtGroupId)", objException.Message));
}
return objCTCodeTypeGroupEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCTCodeTypeGroupEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN()
{
CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(), //Ct组Id
ApplicationTypeId = TransNullToInt(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(), //组名
GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(), //组英文名
Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(), //描述
OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()), //序号
InUse = TransNullToBool(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim() //修改者
};
objCTCodeTypeGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCTCodeTypeGroupEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCTCodeTypeGroupDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCTCodeTypeGroupEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = TransNullToInt(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = TransNullToBool(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCTCodeTypeGroupDA: GetObjByDataRowCTCodeTypeGroup)", objException.Message));
}
objCTCodeTypeGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCTCodeTypeGroupEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCTCodeTypeGroupEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = TransNullToInt(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = TransNullToBool(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCTCodeTypeGroupDA: GetObjByDataRow)", objException.Message));
}
objCTCodeTypeGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCTCodeTypeGroupEN;
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
objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCTCodeTypeGroupEN._CurrTabName, conCTCodeTypeGroup.CtGroupId, 4, "");
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
objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCTCodeTypeGroupEN._CurrTabName, conCTCodeTypeGroup.CtGroupId, 4, strPrefix);
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
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CtGroupId from CTCodeTypeGroup where " + strCondition;
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
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CtGroupId from CTCodeTypeGroup where " + strCondition;
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
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCtGroupId)
{
CheckPrimaryKey(strCtGroupId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CTCodeTypeGroup", "CtGroupId = " + "'"+ strCtGroupId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CTCodeTypeGroup", strCondition))
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
objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CTCodeTypeGroup");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
 {
 objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTCodeTypeGroupEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroup where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CTCodeTypeGroup");
objRow = objDS.Tables["CTCodeTypeGroup"].NewRow();
objRow[conCTCodeTypeGroup.CtGroupId] = objCTCodeTypeGroupEN.CtGroupId; //Ct组Id
objRow[conCTCodeTypeGroup.ApplicationTypeId] = objCTCodeTypeGroupEN.ApplicationTypeId; //应用程序类型ID
 if (objCTCodeTypeGroupEN.GroupName !=  "")
 {
objRow[conCTCodeTypeGroup.GroupName] = objCTCodeTypeGroupEN.GroupName; //组名
 }
 if (objCTCodeTypeGroupEN.GroupENName !=  "")
 {
objRow[conCTCodeTypeGroup.GroupENName] = objCTCodeTypeGroupEN.GroupENName; //组英文名
 }
 if (objCTCodeTypeGroupEN.Description !=  "")
 {
objRow[conCTCodeTypeGroup.Description] = objCTCodeTypeGroupEN.Description; //描述
 }
objRow[conCTCodeTypeGroup.OrderNum] = objCTCodeTypeGroupEN.OrderNum; //序号
objRow[conCTCodeTypeGroup.InUse] = objCTCodeTypeGroupEN.InUse; //是否在用
 if (objCTCodeTypeGroupEN.UpdDate !=  "")
 {
objRow[conCTCodeTypeGroup.UpdDate] = objCTCodeTypeGroupEN.UpdDate; //修改日期
 }
 if (objCTCodeTypeGroupEN.UpdUser !=  "")
 {
objRow[conCTCodeTypeGroup.UpdUser] = objCTCodeTypeGroupEN.UpdUser; //修改者
 }
objDS.Tables[clsCTCodeTypeGroupEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCTCodeTypeGroupEN._CurrTabName);
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
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
 objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTCodeTypeGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTCodeTypeGroupEN.CtGroupId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.CtGroupId);
 var strCtGroupId = objCTCodeTypeGroupEN.CtGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtGroupId + "'");
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroup.ApplicationTypeId);
 arrValueListForInsert.Add(objCTCodeTypeGroupEN.ApplicationTypeId.ToString());
 
 if (objCTCodeTypeGroupEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.GroupName);
 var strGroupName = objCTCodeTypeGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objCTCodeTypeGroupEN.GroupENName !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.GroupENName);
 var strGroupENName = objCTCodeTypeGroupEN.GroupENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupENName + "'");
 }
 
 if (objCTCodeTypeGroupEN.Description !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.Description);
 var strDescription = objCTCodeTypeGroupEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescription + "'");
 }
 
 if (objCTCodeTypeGroupEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.OrderNum);
 arrValueListForInsert.Add(objCTCodeTypeGroupEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroup.InUse);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.UpdDate);
 var strUpdDate = objCTCodeTypeGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTCodeTypeGroupEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.UpdUser);
 var strUpdUser = objCTCodeTypeGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTCodeTypeGroup");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
 objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTCodeTypeGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTCodeTypeGroupEN.CtGroupId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.CtGroupId);
 var strCtGroupId = objCTCodeTypeGroupEN.CtGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtGroupId + "'");
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroup.ApplicationTypeId);
 arrValueListForInsert.Add(objCTCodeTypeGroupEN.ApplicationTypeId.ToString());
 
 if (objCTCodeTypeGroupEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.GroupName);
 var strGroupName = objCTCodeTypeGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objCTCodeTypeGroupEN.GroupENName !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.GroupENName);
 var strGroupENName = objCTCodeTypeGroupEN.GroupENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupENName + "'");
 }
 
 if (objCTCodeTypeGroupEN.Description !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.Description);
 var strDescription = objCTCodeTypeGroupEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescription + "'");
 }
 
 if (objCTCodeTypeGroupEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.OrderNum);
 arrValueListForInsert.Add(objCTCodeTypeGroupEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroup.InUse);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.UpdDate);
 var strUpdDate = objCTCodeTypeGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTCodeTypeGroupEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.UpdUser);
 var strUpdUser = objCTCodeTypeGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTCodeTypeGroup");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCTCodeTypeGroupEN.CtGroupId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTCodeTypeGroupEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTCodeTypeGroupEN.CtGroupId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.CtGroupId);
 var strCtGroupId = objCTCodeTypeGroupEN.CtGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtGroupId + "'");
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroup.ApplicationTypeId);
 arrValueListForInsert.Add(objCTCodeTypeGroupEN.ApplicationTypeId.ToString());
 
 if (objCTCodeTypeGroupEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.GroupName);
 var strGroupName = objCTCodeTypeGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objCTCodeTypeGroupEN.GroupENName !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.GroupENName);
 var strGroupENName = objCTCodeTypeGroupEN.GroupENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupENName + "'");
 }
 
 if (objCTCodeTypeGroupEN.Description !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.Description);
 var strDescription = objCTCodeTypeGroupEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescription + "'");
 }
 
 if (objCTCodeTypeGroupEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.OrderNum);
 arrValueListForInsert.Add(objCTCodeTypeGroupEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroup.InUse);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.UpdDate);
 var strUpdDate = objCTCodeTypeGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTCodeTypeGroupEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.UpdUser);
 var strUpdUser = objCTCodeTypeGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTCodeTypeGroup");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCTCodeTypeGroupEN.CtGroupId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTCodeTypeGroupEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTCodeTypeGroupEN.CtGroupId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.CtGroupId);
 var strCtGroupId = objCTCodeTypeGroupEN.CtGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtGroupId + "'");
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroup.ApplicationTypeId);
 arrValueListForInsert.Add(objCTCodeTypeGroupEN.ApplicationTypeId.ToString());
 
 if (objCTCodeTypeGroupEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.GroupName);
 var strGroupName = objCTCodeTypeGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupName + "'");
 }
 
 if (objCTCodeTypeGroupEN.GroupENName !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.GroupENName);
 var strGroupENName = objCTCodeTypeGroupEN.GroupENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupENName + "'");
 }
 
 if (objCTCodeTypeGroupEN.Description !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.Description);
 var strDescription = objCTCodeTypeGroupEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescription + "'");
 }
 
 if (objCTCodeTypeGroupEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.OrderNum);
 arrValueListForInsert.Add(objCTCodeTypeGroupEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroup.InUse);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.UpdDate);
 var strUpdDate = objCTCodeTypeGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTCodeTypeGroupEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroup.UpdUser);
 var strUpdUser = objCTCodeTypeGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTCodeTypeGroup");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCTCodeTypeGroups(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroup where CtGroupId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CTCodeTypeGroup");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCtGroupId = oRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim();
if (IsExist(strCtGroupId))
{
 string strResult = "关键字变量值为:" + string.Format("CtGroupId = {0}", strCtGroupId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCTCodeTypeGroupEN._CurrTabName ].NewRow();
objRow[conCTCodeTypeGroup.CtGroupId] = oRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objRow[conCTCodeTypeGroup.ApplicationTypeId] = oRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conCTCodeTypeGroup.GroupName] = oRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objRow[conCTCodeTypeGroup.GroupENName] = oRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objRow[conCTCodeTypeGroup.Description] = oRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objRow[conCTCodeTypeGroup.OrderNum] = oRow[conCTCodeTypeGroup.OrderNum].ToString().Trim(); //序号
objRow[conCTCodeTypeGroup.InUse] = oRow[conCTCodeTypeGroup.InUse].ToString().Trim(); //是否在用
objRow[conCTCodeTypeGroup.UpdDate] = oRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objRow[conCTCodeTypeGroup.UpdUser] = oRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
 objDS.Tables[clsCTCodeTypeGroupEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCTCodeTypeGroupEN._CurrTabName);
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
 /// <param name = "objCTCodeTypeGroupEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
 objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTCodeTypeGroupEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroup where CtGroupId = " + "'"+ objCTCodeTypeGroupEN.CtGroupId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCTCodeTypeGroupEN._CurrTabName);
if (objDS.Tables[clsCTCodeTypeGroupEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CtGroupId = " + "'"+ objCTCodeTypeGroupEN.CtGroupId+"'");
return false;
}
objRow = objDS.Tables[clsCTCodeTypeGroupEN._CurrTabName].Rows[0];
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.CtGroupId))
 {
objRow[conCTCodeTypeGroup.CtGroupId] = objCTCodeTypeGroupEN.CtGroupId; //Ct组Id
 }
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.ApplicationTypeId))
 {
objRow[conCTCodeTypeGroup.ApplicationTypeId] = objCTCodeTypeGroupEN.ApplicationTypeId; //应用程序类型ID
 }
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.GroupName))
 {
objRow[conCTCodeTypeGroup.GroupName] = objCTCodeTypeGroupEN.GroupName; //组名
 }
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.GroupENName))
 {
objRow[conCTCodeTypeGroup.GroupENName] = objCTCodeTypeGroupEN.GroupENName; //组英文名
 }
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.Description))
 {
objRow[conCTCodeTypeGroup.Description] = objCTCodeTypeGroupEN.Description; //描述
 }
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.OrderNum))
 {
objRow[conCTCodeTypeGroup.OrderNum] = objCTCodeTypeGroupEN.OrderNum; //序号
 }
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.InUse))
 {
objRow[conCTCodeTypeGroup.InUse] = objCTCodeTypeGroupEN.InUse; //是否在用
 }
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.UpdDate))
 {
objRow[conCTCodeTypeGroup.UpdDate] = objCTCodeTypeGroupEN.UpdDate; //修改日期
 }
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.UpdUser))
 {
objRow[conCTCodeTypeGroup.UpdUser] = objCTCodeTypeGroupEN.UpdUser; //修改者
 }
try
{
objDA.Update(objDS, clsCTCodeTypeGroupEN._CurrTabName);
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
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
 objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTCodeTypeGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CTCodeTypeGroup Set ");
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupEN.ApplicationTypeId, conCTCodeTypeGroup.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.GroupName))
 {
 if (objCTCodeTypeGroupEN.GroupName !=  null)
 {
 var strGroupName = objCTCodeTypeGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupName, conCTCodeTypeGroup.GroupName); //组名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.GroupName); //组名
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.GroupENName))
 {
 if (objCTCodeTypeGroupEN.GroupENName !=  null)
 {
 var strGroupENName = objCTCodeTypeGroupEN.GroupENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupENName, conCTCodeTypeGroup.GroupENName); //组英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.GroupENName); //组英文名
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.Description))
 {
 if (objCTCodeTypeGroupEN.Description !=  null)
 {
 var strDescription = objCTCodeTypeGroupEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDescription, conCTCodeTypeGroup.Description); //描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.Description); //描述
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.OrderNum))
 {
 if (objCTCodeTypeGroupEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupEN.OrderNum, conCTCodeTypeGroup.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.OrderNum); //序号
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCTCodeTypeGroupEN.InUse == true?"1":"0", conCTCodeTypeGroup.InUse); //是否在用
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.UpdDate))
 {
 if (objCTCodeTypeGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objCTCodeTypeGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCTCodeTypeGroup.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.UpdDate); //修改日期
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.UpdUser))
 {
 if (objCTCodeTypeGroupEN.UpdUser !=  null)
 {
 var strUpdUser = objCTCodeTypeGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCTCodeTypeGroup.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.UpdUser); //修改者
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CtGroupId = '{0}'", objCTCodeTypeGroupEN.CtGroupId); 
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
 /// <param name = "objCTCodeTypeGroupEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, string strCondition)
{
 objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTCodeTypeGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CTCodeTypeGroup Set ");
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objCTCodeTypeGroupEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.GroupName))
 {
 if (objCTCodeTypeGroupEN.GroupName !=  null)
 {
 var strGroupName = objCTCodeTypeGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupName = '{0}',", strGroupName); //组名
 }
 else
 {
 sbSQL.Append(" GroupName = null,"); //组名
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.GroupENName))
 {
 if (objCTCodeTypeGroupEN.GroupENName !=  null)
 {
 var strGroupENName = objCTCodeTypeGroupEN.GroupENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupENName = '{0}',", strGroupENName); //组英文名
 }
 else
 {
 sbSQL.Append(" GroupENName = null,"); //组英文名
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.Description))
 {
 if (objCTCodeTypeGroupEN.Description !=  null)
 {
 var strDescription = objCTCodeTypeGroupEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Description = '{0}',", strDescription); //描述
 }
 else
 {
 sbSQL.Append(" Description = null,"); //描述
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.OrderNum))
 {
 if (objCTCodeTypeGroupEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupEN.OrderNum, conCTCodeTypeGroup.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.OrderNum); //序号
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCTCodeTypeGroupEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.UpdDate))
 {
 if (objCTCodeTypeGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objCTCodeTypeGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.UpdUser))
 {
 if (objCTCodeTypeGroupEN.UpdUser !=  null)
 {
 var strUpdUser = objCTCodeTypeGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
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
 /// <param name = "objCTCodeTypeGroupEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTCodeTypeGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CTCodeTypeGroup Set ");
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objCTCodeTypeGroupEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.GroupName))
 {
 if (objCTCodeTypeGroupEN.GroupName !=  null)
 {
 var strGroupName = objCTCodeTypeGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupName = '{0}',", strGroupName); //组名
 }
 else
 {
 sbSQL.Append(" GroupName = null,"); //组名
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.GroupENName))
 {
 if (objCTCodeTypeGroupEN.GroupENName !=  null)
 {
 var strGroupENName = objCTCodeTypeGroupEN.GroupENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupENName = '{0}',", strGroupENName); //组英文名
 }
 else
 {
 sbSQL.Append(" GroupENName = null,"); //组英文名
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.Description))
 {
 if (objCTCodeTypeGroupEN.Description !=  null)
 {
 var strDescription = objCTCodeTypeGroupEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Description = '{0}',", strDescription); //描述
 }
 else
 {
 sbSQL.Append(" Description = null,"); //描述
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.OrderNum))
 {
 if (objCTCodeTypeGroupEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupEN.OrderNum, conCTCodeTypeGroup.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.OrderNum); //序号
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCTCodeTypeGroupEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.UpdDate))
 {
 if (objCTCodeTypeGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objCTCodeTypeGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.UpdUser))
 {
 if (objCTCodeTypeGroupEN.UpdUser !=  null)
 {
 var strUpdUser = objCTCodeTypeGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
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
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTCodeTypeGroupEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CTCodeTypeGroup Set ");
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupEN.ApplicationTypeId, conCTCodeTypeGroup.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.GroupName))
 {
 if (objCTCodeTypeGroupEN.GroupName !=  null)
 {
 var strGroupName = objCTCodeTypeGroupEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupName, conCTCodeTypeGroup.GroupName); //组名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.GroupName); //组名
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.GroupENName))
 {
 if (objCTCodeTypeGroupEN.GroupENName !=  null)
 {
 var strGroupENName = objCTCodeTypeGroupEN.GroupENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupENName, conCTCodeTypeGroup.GroupENName); //组英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.GroupENName); //组英文名
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.Description))
 {
 if (objCTCodeTypeGroupEN.Description !=  null)
 {
 var strDescription = objCTCodeTypeGroupEN.Description.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDescription, conCTCodeTypeGroup.Description); //描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.Description); //描述
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.OrderNum))
 {
 if (objCTCodeTypeGroupEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupEN.OrderNum, conCTCodeTypeGroup.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.OrderNum); //序号
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCTCodeTypeGroupEN.InUse == true?"1":"0", conCTCodeTypeGroup.InUse); //是否在用
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.UpdDate))
 {
 if (objCTCodeTypeGroupEN.UpdDate !=  null)
 {
 var strUpdDate = objCTCodeTypeGroupEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCTCodeTypeGroup.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.UpdDate); //修改日期
 }
 }
 
 if (objCTCodeTypeGroupEN.IsUpdated(conCTCodeTypeGroup.UpdUser))
 {
 if (objCTCodeTypeGroupEN.UpdUser !=  null)
 {
 var strUpdUser = objCTCodeTypeGroupEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCTCodeTypeGroup.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroup.UpdUser); //修改者
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CtGroupId = '{0}'", objCTCodeTypeGroupEN.CtGroupId); 
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
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCtGroupId) 
{
CheckPrimaryKey(strCtGroupId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCtGroupId,
};
 objSQL.ExecSP("CTCodeTypeGroup_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCtGroupId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCtGroupId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
//删除CTCodeTypeGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CTCodeTypeGroup where CtGroupId = " + "'"+ strCtGroupId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCTCodeTypeGroup(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
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
//删除CTCodeTypeGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CTCodeTypeGroup where CtGroupId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCtGroupId) 
{
CheckPrimaryKey(strCtGroupId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
//删除CTCodeTypeGroup本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CTCodeTypeGroup where CtGroupId = " + "'"+ strCtGroupId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCTCodeTypeGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: DelCTCodeTypeGroup)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CTCodeTypeGroup where " + strCondition ;
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
public bool DelCTCodeTypeGroupWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupDA: DelCTCodeTypeGroupWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CTCodeTypeGroup where " + strCondition ;
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
 /// <param name = "objCTCodeTypeGroupENS">源对象</param>
 /// <param name = "objCTCodeTypeGroupENT">目标对象</param>
public void CopyTo(clsCTCodeTypeGroupEN objCTCodeTypeGroupENS, clsCTCodeTypeGroupEN objCTCodeTypeGroupENT)
{
objCTCodeTypeGroupENT.CtGroupId = objCTCodeTypeGroupENS.CtGroupId; //Ct组Id
objCTCodeTypeGroupENT.ApplicationTypeId = objCTCodeTypeGroupENS.ApplicationTypeId; //应用程序类型ID
objCTCodeTypeGroupENT.GroupName = objCTCodeTypeGroupENS.GroupName; //组名
objCTCodeTypeGroupENT.GroupENName = objCTCodeTypeGroupENS.GroupENName; //组英文名
objCTCodeTypeGroupENT.Description = objCTCodeTypeGroupENS.Description; //描述
objCTCodeTypeGroupENT.OrderNum = objCTCodeTypeGroupENS.OrderNum; //序号
objCTCodeTypeGroupENT.InUse = objCTCodeTypeGroupENS.InUse; //是否在用
objCTCodeTypeGroupENT.UpdDate = objCTCodeTypeGroupENS.UpdDate; //修改日期
objCTCodeTypeGroupENT.UpdUser = objCTCodeTypeGroupENS.UpdUser; //修改者
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCTCodeTypeGroupEN.ApplicationTypeId, conCTCodeTypeGroup.ApplicationTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.CtGroupId, 4, conCTCodeTypeGroup.CtGroupId);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.GroupName, 30, conCTCodeTypeGroup.GroupName);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.GroupENName, 100, conCTCodeTypeGroup.GroupENName);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.Description, 300, conCTCodeTypeGroup.Description);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.UpdDate, 20, conCTCodeTypeGroup.UpdDate);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.UpdUser, 20, conCTCodeTypeGroup.UpdUser);
//检查字段外键固定长度
 objCTCodeTypeGroupEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.GroupName, 30, conCTCodeTypeGroup.GroupName);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.GroupENName, 100, conCTCodeTypeGroup.GroupENName);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.Description, 300, conCTCodeTypeGroup.Description);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.UpdDate, 20, conCTCodeTypeGroup.UpdDate);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.UpdUser, 20, conCTCodeTypeGroup.UpdUser);
//检查外键字段长度
 objCTCodeTypeGroupEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.CtGroupId, 4, conCTCodeTypeGroup.CtGroupId);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.GroupName, 30, conCTCodeTypeGroup.GroupName);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.GroupENName, 100, conCTCodeTypeGroup.GroupENName);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.Description, 300, conCTCodeTypeGroup.Description);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.UpdDate, 20, conCTCodeTypeGroup.UpdDate);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupEN.UpdUser, 20, conCTCodeTypeGroup.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupEN.CtGroupId, conCTCodeTypeGroup.CtGroupId);
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupEN.GroupName, conCTCodeTypeGroup.GroupName);
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupEN.GroupENName, conCTCodeTypeGroup.GroupENName);
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupEN.Description, conCTCodeTypeGroup.Description);
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupEN.UpdDate, conCTCodeTypeGroup.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupEN.UpdUser, conCTCodeTypeGroup.UpdUser);
//检查外键字段长度
 objCTCodeTypeGroupEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCtGroupId()
{
//获取某学院所有专业信息
string strSQL = "select CtGroupId, GroupName from CTCodeTypeGroup ";
 clsSpecSQLforSql mySql = clsCTCodeTypeGroupDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CTCodeTypeGroup(CTCodeTypeGroup),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCTCodeTypeGroupEN.ApplicationTypeId);
 if (objCTCodeTypeGroupEN.GroupName == null)
{
 sbCondition.AppendFormat(" and GroupName is null");
}
else
{
 sbCondition.AppendFormat(" and GroupName = '{0}'", objCTCodeTypeGroupEN.GroupName);
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
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
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
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
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
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCTCodeTypeGroupEN._CurrTabName);
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
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCTCodeTypeGroupEN._CurrTabName, strCondition);
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
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
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
 objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}