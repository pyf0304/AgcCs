
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjConstraintDA
 表名:vPrjConstraint(00050333)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:41
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
 /// v约束(vPrjConstraint)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjConstraintDA : clsCommBase4DA
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
 return clsvPrjConstraintEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjConstraintEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjConstraintEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjConstraintEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjConstraintEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPrjConstraintId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPrjConstraintId)
{
strPrjConstraintId = strPrjConstraintId.Replace("'", "''");
if (strPrjConstraintId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vPrjConstraint中,检查关键字,长度不正确!(clsvPrjConstraintDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjConstraintId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPrjConstraint中,关键字不能为空 或 null!(clsvPrjConstraintDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjConstraintId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPrjConstraintDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjConstraintDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
strSQL = "Select * from vPrjConstraint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjConstraint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjConstraintDA: GetDataTable_vPrjConstraint)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
strSQL = "Select * from vPrjConstraint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjConstraintDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjConstraintDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
strSQL = "Select * from vPrjConstraint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjConstraintDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjConstraintDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjConstraint where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjConstraint where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjConstraintDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjConstraint where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjConstraintDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjConstraint.* " + 
$"from vPrjConstraint " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjConstraint.PrjConstraintId not in " + 
$"(Select top {intTop_In} vPrjConstraint.PrjConstraintId from vPrjConstraint " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjConstraint where {1} and PrjConstraintId not in (Select top {2} PrjConstraintId from vPrjConstraint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjConstraint where {1} and PrjConstraintId not in (Select top {3} PrjConstraintId from vPrjConstraint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjConstraintDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjConstraint.* " + 
$"from vPrjConstraint " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjConstraint.PrjConstraintId not in " + 
$"(Select top {intTop_In} vPrjConstraint.PrjConstraintId from vPrjConstraint " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjConstraint where {1} and PrjConstraintId not in (Select top {2} PrjConstraintId from vPrjConstraint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjConstraint where {1} and PrjConstraintId not in (Select top {3} PrjConstraintId from vPrjConstraint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjConstraintEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjConstraintDA:GetObjLst)", objException.Message));
}
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
strSQL = "Select * from vPrjConstraint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = TransNullToBool(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjConstraintDA: GetObjLst)", objException.Message));
}
objvPrjConstraintEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjConstraintEN);
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
public List<clsvPrjConstraintEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjConstraintDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjConstraintEN> arrObjLst = new List<clsvPrjConstraintEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = TransNullToBool(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjConstraintDA: GetObjLst)", objException.Message));
}
objvPrjConstraintEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjConstraintEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjConstraintEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjConstraint(ref clsvPrjConstraintEN objvPrjConstraintEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
strSQL = "Select * from vPrjConstraint where PrjConstraintId = " + "'"+ objvPrjConstraintEN.PrjConstraintId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjConstraintEN.PrjConstraintId = objDT.Rows[0][convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjConstraintEN.ConstraintName = objDT.Rows[0][convPrjConstraint.ConstraintName].ToString().Trim(); //约束名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjConstraintEN.PrjId = objDT.Rows[0][convPrjConstraint.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjConstraintEN.PrjName = objDT.Rows[0][convPrjConstraint.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjConstraintEN.TabId = objDT.Rows[0][convPrjConstraint.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjConstraintEN.TabName = objDT.Rows[0][convPrjConstraint.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjConstraintEN.TabCnName = objDT.Rows[0][convPrjConstraint.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjConstraintEN.ConstraintTypeId = objDT.Rows[0][convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjConstraintEN.ConstraintTypeName = objDT.Rows[0][convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjConstraintEN.ConstraintTypeNameEN = objDT.Rows[0][convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjConstraintEN.ConstraintDescription = objDT.Rows[0][convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明(字段类型:varchar,字段长度:500,是否可空:True)
 objvPrjConstraintEN.CreateUserId = objDT.Rows[0][convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvPrjConstraintEN.InUse = TransNullToBool(objDT.Rows[0][convPrjConstraint.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjConstraintEN.UpdDate = objDT.Rows[0][convPrjConstraint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjConstraintEN.UpdUser = objDT.Rows[0][convPrjConstraint.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjConstraintEN.Memo = objDT.Rows[0][convPrjConstraint.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjConstraintDA: GetvPrjConstraint)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjConstraintId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjConstraintEN GetObjByPrjConstraintId(string strPrjConstraintId)
{
CheckPrimaryKey(strPrjConstraintId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
strSQL = "Select * from vPrjConstraint where PrjConstraintId = " + "'"+ strPrjConstraintId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
 objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明(字段类型:varchar,字段长度:500,是否可空:True)
 objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjConstraintDA: GetObjByPrjConstraintId)", objException.Message));
}
return objvPrjConstraintEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjConstraintEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjConstraintDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
strSQL = "Select * from vPrjConstraint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN()
{
PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(), //约束表Id
ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(), //约束名
PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(), //工程名称
TabId = objRow[convPrjConstraint.TabId].ToString().Trim(), //表ID
TabName = objRow[convPrjConstraint.TabName].ToString().Trim(), //表名
TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(), //表中文名
ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(), //约束类型Id
ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(), //约束类型名
ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(), //约束类型英文名
ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(), //约束说明
CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(), //建立用户Id
InUse = TransNullToBool(objRow[convPrjConstraint.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim() //说明
};
objvPrjConstraintEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjConstraintEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjConstraintDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjConstraintEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = TransNullToBool(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjConstraintDA: GetObjByDataRowvPrjConstraint)", objException.Message));
}
objvPrjConstraintEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjConstraintEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjConstraintEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjConstraintEN objvPrjConstraintEN = new clsvPrjConstraintEN();
try
{
objvPrjConstraintEN.PrjConstraintId = objRow[convPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objvPrjConstraintEN.ConstraintName = objRow[convPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objvPrjConstraintEN.PrjId = objRow[convPrjConstraint.PrjId].ToString().Trim(); //工程Id
objvPrjConstraintEN.PrjName = objRow[convPrjConstraint.PrjName].ToString().Trim(); //工程名称
objvPrjConstraintEN.TabId = objRow[convPrjConstraint.TabId].ToString().Trim(); //表ID
objvPrjConstraintEN.TabName = objRow[convPrjConstraint.TabName].ToString().Trim(); //表名
objvPrjConstraintEN.TabCnName = objRow[convPrjConstraint.TabCnName] == DBNull.Value ? null : objRow[convPrjConstraint.TabCnName].ToString().Trim(); //表中文名
objvPrjConstraintEN.ConstraintTypeId = objRow[convPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvPrjConstraintEN.ConstraintTypeName = objRow[convPrjConstraint.ConstraintTypeName].ToString().Trim(); //约束类型名
objvPrjConstraintEN.ConstraintTypeNameEN = objRow[convPrjConstraint.ConstraintTypeNameEN] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintTypeNameEN].ToString().Trim(); //约束类型英文名
objvPrjConstraintEN.ConstraintDescription = objRow[convPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[convPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objvPrjConstraintEN.CreateUserId = objRow[convPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objvPrjConstraintEN.InUse = TransNullToBool(objRow[convPrjConstraint.InUse].ToString().Trim()); //是否在用
objvPrjConstraintEN.UpdDate = objRow[convPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[convPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objvPrjConstraintEN.UpdUser = objRow[convPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[convPrjConstraint.UpdUser].ToString().Trim(); //修改者
objvPrjConstraintEN.Memo = objRow[convPrjConstraint.Memo] == DBNull.Value ? null : objRow[convPrjConstraint.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjConstraintDA: GetObjByDataRow)", objException.Message));
}
objvPrjConstraintEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjConstraintEN;
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
objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjConstraintEN._CurrTabName, convPrjConstraint.PrjConstraintId, 8, "");
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
objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjConstraintEN._CurrTabName, convPrjConstraint.PrjConstraintId, 8, strPrefix);
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
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PrjConstraintId from vPrjConstraint where " + strCondition;
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
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PrjConstraintId from vPrjConstraint where " + strCondition;
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
 /// <param name = "strPrjConstraintId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPrjConstraintId)
{
CheckPrimaryKey(strPrjConstraintId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjConstraint", "PrjConstraintId = " + "'"+ strPrjConstraintId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjConstraintDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjConstraint", strCondition))
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
objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjConstraint");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjConstraintENS">源对象</param>
 /// <param name = "objvPrjConstraintENT">目标对象</param>
public void CopyTo(clsvPrjConstraintEN objvPrjConstraintENS, clsvPrjConstraintEN objvPrjConstraintENT)
{
objvPrjConstraintENT.PrjConstraintId = objvPrjConstraintENS.PrjConstraintId; //约束表Id
objvPrjConstraintENT.ConstraintName = objvPrjConstraintENS.ConstraintName; //约束名
objvPrjConstraintENT.PrjId = objvPrjConstraintENS.PrjId; //工程Id
objvPrjConstraintENT.PrjName = objvPrjConstraintENS.PrjName; //工程名称
objvPrjConstraintENT.TabId = objvPrjConstraintENS.TabId; //表ID
objvPrjConstraintENT.TabName = objvPrjConstraintENS.TabName; //表名
objvPrjConstraintENT.TabCnName = objvPrjConstraintENS.TabCnName; //表中文名
objvPrjConstraintENT.ConstraintTypeId = objvPrjConstraintENS.ConstraintTypeId; //约束类型Id
objvPrjConstraintENT.ConstraintTypeName = objvPrjConstraintENS.ConstraintTypeName; //约束类型名
objvPrjConstraintENT.ConstraintTypeNameEN = objvPrjConstraintENS.ConstraintTypeNameEN; //约束类型英文名
objvPrjConstraintENT.ConstraintDescription = objvPrjConstraintENS.ConstraintDescription; //约束说明
objvPrjConstraintENT.CreateUserId = objvPrjConstraintENS.CreateUserId; //建立用户Id
objvPrjConstraintENT.InUse = objvPrjConstraintENS.InUse; //是否在用
objvPrjConstraintENT.UpdDate = objvPrjConstraintENS.UpdDate; //修改日期
objvPrjConstraintENT.UpdUser = objvPrjConstraintENS.UpdUser; //修改者
objvPrjConstraintENT.Memo = objvPrjConstraintENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjConstraintEN objvPrjConstraintEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.PrjConstraintId, 8, convPrjConstraint.PrjConstraintId);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.ConstraintName, 100, convPrjConstraint.ConstraintName);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.PrjId, 4, convPrjConstraint.PrjId);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.PrjName, 30, convPrjConstraint.PrjName);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.TabId, 8, convPrjConstraint.TabId);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.TabName, 100, convPrjConstraint.TabName);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.TabCnName, 200, convPrjConstraint.TabCnName);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.ConstraintTypeId, 2, convPrjConstraint.ConstraintTypeId);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.ConstraintTypeName, 50, convPrjConstraint.ConstraintTypeName);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.ConstraintTypeNameEN, 50, convPrjConstraint.ConstraintTypeNameEN);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.ConstraintDescription, 500, convPrjConstraint.ConstraintDescription);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.CreateUserId, 18, convPrjConstraint.CreateUserId);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.UpdDate, 20, convPrjConstraint.UpdDate);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.UpdUser, 20, convPrjConstraint.UpdUser);
clsCheckSql.CheckFieldLen(objvPrjConstraintEN.Memo, 1000, convPrjConstraint.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.PrjConstraintId, convPrjConstraint.PrjConstraintId);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.ConstraintName, convPrjConstraint.ConstraintName);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.PrjId, convPrjConstraint.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.PrjName, convPrjConstraint.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.TabId, convPrjConstraint.TabId);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.TabName, convPrjConstraint.TabName);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.TabCnName, convPrjConstraint.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.ConstraintTypeId, convPrjConstraint.ConstraintTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.ConstraintTypeName, convPrjConstraint.ConstraintTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.ConstraintTypeNameEN, convPrjConstraint.ConstraintTypeNameEN);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.ConstraintDescription, convPrjConstraint.ConstraintDescription);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.CreateUserId, convPrjConstraint.CreateUserId);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.UpdDate, convPrjConstraint.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.UpdUser, convPrjConstraint.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvPrjConstraintEN.Memo, convPrjConstraint.Memo);
//检查外键字段长度
 objvPrjConstraintEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPrjConstraintId()
{
//获取某学院所有专业信息
string strSQL = "select PrjConstraintId, ConstraintName from vPrjConstraint ";
 clsSpecSQLforSql mySql = clsvPrjConstraintDA.GetSpecSQLObj();
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
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
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
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
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
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjConstraintEN._CurrTabName);
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
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjConstraintEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjConstraintDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}