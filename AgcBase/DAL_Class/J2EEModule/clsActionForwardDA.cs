
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsActionForwardDA
 表名:ActionForward(00050143)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:J2EE模块(J2EEModule)
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
 /// ActionForward(ActionForward)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsActionForwardDA : clsCommBase4DA
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
 return clsActionForwardEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsActionForwardEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsActionForwardEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsActionForwardEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsActionForwardEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsActionForwardDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = "Select * from ActionForward where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ActionForward(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsActionForwardDA: GetDataTable_ActionForward)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = "Select * from ActionForward where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsActionForwardDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsActionForwardDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = "Select * from ActionForward where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsActionForwardDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsActionForwardDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ActionForward where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ActionForward where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsActionForwardDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ActionForward where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsActionForwardDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ActionForward.* " + 
$"from ActionForward " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ActionForward.ActionForwardId not in " + 
$"(Select top {intTop_In} ActionForward.ActionForwardId from ActionForward " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ActionForward where {1} and ActionForwardId not in (Select top {2} ActionForwardId from ActionForward where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ActionForward where {1} and ActionForwardId not in (Select top {3} ActionForwardId from ActionForward where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsActionForwardDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ActionForward.* " + 
$"from ActionForward " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ActionForward.ActionForwardId not in " + 
$"(Select top {intTop_In} ActionForward.ActionForwardId from ActionForward " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ActionForward where {1} and ActionForwardId not in (Select top {2} ActionForwardId from ActionForward where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ActionForward where {1} and ActionForwardId not in (Select top {3} ActionForwardId from ActionForward where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsActionForwardEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsActionForwardDA:GetObjLst)", objException.Message));
}
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = "Select * from ActionForward where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = TransNullToInt(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsActionForwardDA: GetObjLst)", objException.Message));
}
objActionForwardEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objActionForwardEN);
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
public List<clsActionForwardEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsActionForwardDA:GetObjLstByTabName)", objException.Message));
}
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = TransNullToInt(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsActionForwardDA: GetObjLst)", objException.Message));
}
objActionForwardEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objActionForwardEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objActionForwardEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetActionForward(ref clsActionForwardEN objActionForwardEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = "Select * from ActionForward where ActionForwardId = " + ""+ objActionForwardEN.ActionForwardId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objActionForwardEN.ActionForwardId = TransNullToInt(objDT.Rows[0][conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId(字段类型:bigint,字段长度:8,是否可空:False)
 objActionForwardEN.ActionId = objDT.Rows[0][conActionForward.ActionId].ToString().Trim(); //ActionId(字段类型:char,字段长度:10,是否可空:False)
 objActionForwardEN.ForwardName = objDT.Rows[0][conActionForward.ForwardName].ToString().Trim(); //Forward名称(字段类型:varchar,字段长度:50,是否可空:False)
 objActionForwardEN.ForwardPath = objDT.Rows[0][conActionForward.ForwardPath].ToString().Trim(); //Forward路径(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsActionForwardDA: GetActionForward)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngActionForwardId">表关键字</param>
 /// <returns>表对象</returns>
public clsActionForwardEN GetObjByActionForwardId(long lngActionForwardId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = "Select * from ActionForward where ActionForwardId = " + ""+ lngActionForwardId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
 objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId(字段类型:bigint,字段长度:8,是否可空:False)
 objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId(字段类型:char,字段长度:10,是否可空:False)
 objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称(字段类型:varchar,字段长度:50,是否可空:False)
 objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsActionForwardDA: GetObjByActionForwardId)", objException.Message));
}
return objActionForwardEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsActionForwardEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsActionForwardDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = "Select * from ActionForward where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN()
{
ActionForwardId = TransNullToInt(objRow[conActionForward.ActionForwardId].ToString().Trim()), //ActionForwardId
ActionId = objRow[conActionForward.ActionId].ToString().Trim(), //ActionId
ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(), //Forward名称
ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim() //Forward路径
};
objActionForwardEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objActionForwardEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsActionForwardDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsActionForwardEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = TransNullToInt(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsActionForwardDA: GetObjByDataRowActionForward)", objException.Message));
}
objActionForwardEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objActionForwardEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsActionForwardEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = TransNullToInt(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsActionForwardDA: GetObjByDataRow)", objException.Message));
}
objActionForwardEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objActionForwardEN;
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
objSQL = clsActionForwardDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsActionForwardEN._CurrTabName, conActionForward.ActionForwardId, 8, "");
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
objSQL = clsActionForwardDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsActionForwardEN._CurrTabName, conActionForward.ActionForwardId, 8, strPrefix);
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
 objSQL = clsActionForwardDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ActionForwardId from ActionForward where " + strCondition;
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
 objSQL = clsActionForwardDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ActionForwardId from ActionForward where " + strCondition;
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
 /// <param name = "lngActionForwardId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngActionForwardId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ActionForward", "ActionForwardId = " + ""+ lngActionForwardId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsActionForwardDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ActionForward", strCondition))
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
objSQL = clsActionForwardDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ActionForward");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsActionForwardEN objActionForwardEN)
 {
 if (objActionForwardEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objActionForwardEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = "Select * from ActionForward where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ActionForward");
objRow = objDS.Tables["ActionForward"].NewRow();
objRow[conActionForward.ActionId] = objActionForwardEN.ActionId; //ActionId
objRow[conActionForward.ForwardName] = objActionForwardEN.ForwardName; //Forward名称
 if (objActionForwardEN.ForwardPath !=  "")
 {
objRow[conActionForward.ForwardPath] = objActionForwardEN.ForwardPath; //Forward路径
 }
objDS.Tables[clsActionForwardEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsActionForwardEN._CurrTabName);
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
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsActionForwardEN objActionForwardEN)
{
 if (objActionForwardEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objActionForwardEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objActionForwardEN.ActionId !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ActionId);
 var strActionId = objActionForwardEN.ActionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActionId + "'");
 }
 
 if (objActionForwardEN.ForwardName !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ForwardName);
 var strForwardName = objActionForwardEN.ForwardName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForwardName + "'");
 }
 
 if (objActionForwardEN.ForwardPath !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ForwardPath);
 var strForwardPath = objActionForwardEN.ForwardPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForwardPath + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ActionForward");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsActionForwardEN objActionForwardEN)
{
 if (objActionForwardEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objActionForwardEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objActionForwardEN.ActionId !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ActionId);
 var strActionId = objActionForwardEN.ActionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActionId + "'");
 }
 
 if (objActionForwardEN.ForwardName !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ForwardName);
 var strForwardName = objActionForwardEN.ForwardName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForwardName + "'");
 }
 
 if (objActionForwardEN.ForwardPath !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ForwardPath);
 var strForwardPath = objActionForwardEN.ForwardPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForwardPath + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ActionForward");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsActionForwardEN objActionForwardEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objActionForwardEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objActionForwardEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objActionForwardEN.ActionId !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ActionId);
 var strActionId = objActionForwardEN.ActionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActionId + "'");
 }
 
 if (objActionForwardEN.ForwardName !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ForwardName);
 var strForwardName = objActionForwardEN.ForwardName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForwardName + "'");
 }
 
 if (objActionForwardEN.ForwardPath !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ForwardPath);
 var strForwardPath = objActionForwardEN.ForwardPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForwardPath + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ActionForward");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsActionForwardEN objActionForwardEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objActionForwardEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objActionForwardEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objActionForwardEN.ActionId !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ActionId);
 var strActionId = objActionForwardEN.ActionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActionId + "'");
 }
 
 if (objActionForwardEN.ForwardName !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ForwardName);
 var strForwardName = objActionForwardEN.ForwardName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForwardName + "'");
 }
 
 if (objActionForwardEN.ForwardPath !=  null)
 {
 arrFieldListForInsert.Add(conActionForward.ForwardPath);
 var strForwardPath = objActionForwardEN.ForwardPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForwardPath + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ActionForward");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewActionForwards(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = "Select * from ActionForward where ActionForwardId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ActionForward");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsActionForwardEN._CurrTabName ].NewRow();
objRow[conActionForward.ActionId] = oRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objRow[conActionForward.ForwardName] = oRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objRow[conActionForward.ForwardPath] = oRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
 objDS.Tables[clsActionForwardEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsActionForwardEN._CurrTabName);
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
 /// <param name = "objActionForwardEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsActionForwardEN objActionForwardEN)
{
 if (objActionForwardEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objActionForwardEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
strSQL = "Select * from ActionForward where ActionForwardId = " + ""+ objActionForwardEN.ActionForwardId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsActionForwardEN._CurrTabName);
if (objDS.Tables[clsActionForwardEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ActionForwardId = " + ""+ objActionForwardEN.ActionForwardId+"");
return false;
}
objRow = objDS.Tables[clsActionForwardEN._CurrTabName].Rows[0];
 if (objActionForwardEN.IsUpdated(conActionForward.ActionId))
 {
objRow[conActionForward.ActionId] = objActionForwardEN.ActionId; //ActionId
 }
 if (objActionForwardEN.IsUpdated(conActionForward.ForwardName))
 {
objRow[conActionForward.ForwardName] = objActionForwardEN.ForwardName; //Forward名称
 }
 if (objActionForwardEN.IsUpdated(conActionForward.ForwardPath))
 {
objRow[conActionForward.ForwardPath] = objActionForwardEN.ForwardPath; //Forward路径
 }
try
{
objDA.Update(objDS, clsActionForwardEN._CurrTabName);
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
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsActionForwardEN objActionForwardEN)
{
 if (objActionForwardEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objActionForwardEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ActionForward Set ");
 
 if (objActionForwardEN.IsUpdated(conActionForward.ActionId))
 {
 if (objActionForwardEN.ActionId !=  null)
 {
 var strActionId = objActionForwardEN.ActionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strActionId, conActionForward.ActionId); //ActionId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conActionForward.ActionId); //ActionId
 }
 }
 
 if (objActionForwardEN.IsUpdated(conActionForward.ForwardName))
 {
 if (objActionForwardEN.ForwardName !=  null)
 {
 var strForwardName = objActionForwardEN.ForwardName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForwardName, conActionForward.ForwardName); //Forward名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conActionForward.ForwardName); //Forward名称
 }
 }
 
 if (objActionForwardEN.IsUpdated(conActionForward.ForwardPath))
 {
 if (objActionForwardEN.ForwardPath !=  null)
 {
 var strForwardPath = objActionForwardEN.ForwardPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForwardPath, conActionForward.ForwardPath); //Forward路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conActionForward.ForwardPath); //Forward路径
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ActionForwardId = {0}", objActionForwardEN.ActionForwardId); 
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
 /// <param name = "objActionForwardEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsActionForwardEN objActionForwardEN, string strCondition)
{
 if (objActionForwardEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objActionForwardEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ActionForward Set ");
 
 if (objActionForwardEN.IsUpdated(conActionForward.ActionId))
 {
 if (objActionForwardEN.ActionId !=  null)
 {
 var strActionId = objActionForwardEN.ActionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ActionId = '{0}',", strActionId); //ActionId
 }
 else
 {
 sbSQL.Append(" ActionId = null,"); //ActionId
 }
 }
 
 if (objActionForwardEN.IsUpdated(conActionForward.ForwardName))
 {
 if (objActionForwardEN.ForwardName !=  null)
 {
 var strForwardName = objActionForwardEN.ForwardName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForwardName = '{0}',", strForwardName); //Forward名称
 }
 else
 {
 sbSQL.Append(" ForwardName = null,"); //Forward名称
 }
 }
 
 if (objActionForwardEN.IsUpdated(conActionForward.ForwardPath))
 {
 if (objActionForwardEN.ForwardPath !=  null)
 {
 var strForwardPath = objActionForwardEN.ForwardPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForwardPath = '{0}',", strForwardPath); //Forward路径
 }
 else
 {
 sbSQL.Append(" ForwardPath = null,"); //Forward路径
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
 /// <param name = "objActionForwardEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsActionForwardEN objActionForwardEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objActionForwardEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objActionForwardEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ActionForward Set ");
 
 if (objActionForwardEN.IsUpdated(conActionForward.ActionId))
 {
 if (objActionForwardEN.ActionId !=  null)
 {
 var strActionId = objActionForwardEN.ActionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ActionId = '{0}',", strActionId); //ActionId
 }
 else
 {
 sbSQL.Append(" ActionId = null,"); //ActionId
 }
 }
 
 if (objActionForwardEN.IsUpdated(conActionForward.ForwardName))
 {
 if (objActionForwardEN.ForwardName !=  null)
 {
 var strForwardName = objActionForwardEN.ForwardName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForwardName = '{0}',", strForwardName); //Forward名称
 }
 else
 {
 sbSQL.Append(" ForwardName = null,"); //Forward名称
 }
 }
 
 if (objActionForwardEN.IsUpdated(conActionForward.ForwardPath))
 {
 if (objActionForwardEN.ForwardPath !=  null)
 {
 var strForwardPath = objActionForwardEN.ForwardPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForwardPath = '{0}',", strForwardPath); //Forward路径
 }
 else
 {
 sbSQL.Append(" ForwardPath = null,"); //Forward路径
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
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsActionForwardEN objActionForwardEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objActionForwardEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objActionForwardEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ActionForward Set ");
 
 if (objActionForwardEN.IsUpdated(conActionForward.ActionId))
 {
 if (objActionForwardEN.ActionId !=  null)
 {
 var strActionId = objActionForwardEN.ActionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strActionId, conActionForward.ActionId); //ActionId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conActionForward.ActionId); //ActionId
 }
 }
 
 if (objActionForwardEN.IsUpdated(conActionForward.ForwardName))
 {
 if (objActionForwardEN.ForwardName !=  null)
 {
 var strForwardName = objActionForwardEN.ForwardName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForwardName, conActionForward.ForwardName); //Forward名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conActionForward.ForwardName); //Forward名称
 }
 }
 
 if (objActionForwardEN.IsUpdated(conActionForward.ForwardPath))
 {
 if (objActionForwardEN.ForwardPath !=  null)
 {
 var strForwardPath = objActionForwardEN.ForwardPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForwardPath, conActionForward.ForwardPath); //Forward路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conActionForward.ForwardPath); //Forward路径
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ActionForwardId = {0}", objActionForwardEN.ActionForwardId); 
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
 /// <param name = "lngActionForwardId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngActionForwardId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngActionForwardId,
};
 objSQL.ExecSP("ActionForward_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngActionForwardId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngActionForwardId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
//删除ActionForward本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ActionForward where ActionForwardId = " + ""+ lngActionForwardId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelActionForward(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
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
//删除ActionForward本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ActionForward where ActionForwardId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngActionForwardId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngActionForwardId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
//删除ActionForward本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ActionForward where ActionForwardId = " + ""+ lngActionForwardId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelActionForward(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsActionForwardDA: DelActionForward)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ActionForward where " + strCondition ;
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
public bool DelActionForwardWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsActionForwardDA: DelActionForwardWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsActionForwardDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ActionForward where " + strCondition ;
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
 /// <param name = "objActionForwardENS">源对象</param>
 /// <param name = "objActionForwardENT">目标对象</param>
public void CopyTo(clsActionForwardEN objActionForwardENS, clsActionForwardEN objActionForwardENT)
{
objActionForwardENT.ActionForwardId = objActionForwardENS.ActionForwardId; //ActionForwardId
objActionForwardENT.ActionId = objActionForwardENS.ActionId; //ActionId
objActionForwardENT.ForwardName = objActionForwardENS.ForwardName; //Forward名称
objActionForwardENT.ForwardPath = objActionForwardENS.ForwardPath; //Forward路径
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsActionForwardEN objActionForwardEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objActionForwardEN.ActionId, conActionForward.ActionId);
clsCheckSql.CheckFieldNotNull(objActionForwardEN.ForwardName, conActionForward.ForwardName);
//检查字段长度
clsCheckSql.CheckFieldLen(objActionForwardEN.ActionId, 10, conActionForward.ActionId);
clsCheckSql.CheckFieldLen(objActionForwardEN.ForwardName, 50, conActionForward.ForwardName);
clsCheckSql.CheckFieldLen(objActionForwardEN.ForwardPath, 50, conActionForward.ForwardPath);
//检查字段外键固定长度
 objActionForwardEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsActionForwardEN objActionForwardEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objActionForwardEN.ActionId, 10, conActionForward.ActionId);
clsCheckSql.CheckFieldLen(objActionForwardEN.ForwardName, 50, conActionForward.ForwardName);
clsCheckSql.CheckFieldLen(objActionForwardEN.ForwardPath, 50, conActionForward.ForwardPath);
//检查外键字段长度
 objActionForwardEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsActionForwardEN objActionForwardEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objActionForwardEN.ActionId, 10, conActionForward.ActionId);
clsCheckSql.CheckFieldLen(objActionForwardEN.ForwardName, 50, conActionForward.ForwardName);
clsCheckSql.CheckFieldLen(objActionForwardEN.ForwardPath, 50, conActionForward.ForwardPath);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objActionForwardEN.ActionId, conActionForward.ActionId);
clsCheckSql.CheckSqlInjection4Field(objActionForwardEN.ForwardName, conActionForward.ForwardName);
clsCheckSql.CheckSqlInjection4Field(objActionForwardEN.ForwardPath, conActionForward.ForwardPath);
//检查外键字段长度
 objActionForwardEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ActionForward(ActionForward),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objActionForwardEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsActionForwardEN objActionForwardEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ActionId = '{0}'", objActionForwardEN.ActionId);
 sbCondition.AppendFormat(" and ForwardName = '{0}'", objActionForwardEN.ForwardName);
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
 objSQL = clsActionForwardDA.GetSpecSQLObj();
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
 objSQL = clsActionForwardDA.GetSpecSQLObj();
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
 objSQL = clsActionForwardDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsActionForwardEN._CurrTabName);
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
 objSQL = clsActionForwardDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsActionForwardEN._CurrTabName, strCondition);
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
 objSQL = clsActionForwardDA.GetSpecSQLObj();
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
 objSQL = clsActionForwardDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}