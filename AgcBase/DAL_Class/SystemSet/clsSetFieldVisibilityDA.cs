
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSetFieldVisibilityDA
 表名:SetFieldVisibility(00050242)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 设置字段可视性(SetFieldVisibility)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSetFieldVisibilityDA : clsCommBase4DA
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
 return clsSetFieldVisibilityEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSetFieldVisibilityEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSetFieldVisibilityEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSetFieldVisibilityEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSetFieldVisibilityEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from SetFieldVisibility where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SetFieldVisibility(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: GetDataTable_SetFieldVisibility)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from SetFieldVisibility where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from SetFieldVisibility where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SetFieldVisibility where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SetFieldVisibility where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SetFieldVisibility where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SetFieldVisibility.* " + 
$"from SetFieldVisibility " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SetFieldVisibility.mId not in " + 
$"(Select top {intTop_In} SetFieldVisibility.mId from SetFieldVisibility " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SetFieldVisibility where {1} and mId not in (Select top {2} mId from SetFieldVisibility where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SetFieldVisibility where {1} and mId not in (Select top {3} mId from SetFieldVisibility where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SetFieldVisibility.* " + 
$"from SetFieldVisibility " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SetFieldVisibility.mId not in " + 
$"(Select top {intTop_In} SetFieldVisibility.mId from SetFieldVisibility " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SetFieldVisibility where {1} and mId not in (Select top {2} mId from SetFieldVisibility where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SetFieldVisibility where {1} and mId not in (Select top {3} mId from SetFieldVisibility where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSetFieldVisibilityEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA:GetObjLst)", objException.Message));
}
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from SetFieldVisibility where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = TransNullToInt(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = TransNullToBool(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSetFieldVisibilityDA: GetObjLst)", objException.Message));
}
objSetFieldVisibilityEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSetFieldVisibilityEN);
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
public List<clsSetFieldVisibilityEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA:GetObjLstByTabName)", objException.Message));
}
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = TransNullToInt(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = TransNullToBool(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSetFieldVisibilityDA: GetObjLst)", objException.Message));
}
objSetFieldVisibilityEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSetFieldVisibilityEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSetFieldVisibility(ref clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from SetFieldVisibility where mId = " + ""+ objSetFieldVisibilityEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSetFieldVisibilityEN.mId = TransNullToInt(objDT.Rows[0][conSetFieldVisibility.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objSetFieldVisibilityEN.IdSchool = objDT.Rows[0][conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objSetFieldVisibilityEN.UserId = objDT.Rows[0][conSetFieldVisibility.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objSetFieldVisibilityEN.ViewName = objDT.Rows[0][conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objSetFieldVisibilityEN.FieldName = objDT.Rows[0][conSetFieldVisibility.FieldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objSetFieldVisibilityEN.Caption = objDT.Rows[0][conSetFieldVisibility.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objSetFieldVisibilityEN.CtrlType = objDT.Rows[0][conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型(字段类型:varchar,字段长度:50,是否可空:False)
 objSetFieldVisibilityEN.IsVisible = TransNullToBool(objDT.Rows[0][conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objSetFieldVisibilityEN.UpdDate = objDT.Rows[0][conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSetFieldVisibilityEN.UpdUserId = objDT.Rows[0][conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSetFieldVisibilityEN.Memo = objDT.Rows[0][conSetFieldVisibility.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objSetFieldVisibilityEN.FuncModuleId = objDT.Rows[0][conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSetFieldVisibilityDA: GetSetFieldVisibility)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsSetFieldVisibilityEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from SetFieldVisibility where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
 objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型(字段类型:varchar,字段长度:50,是否可空:False)
 objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSetFieldVisibilityDA: GetObjBymId)", objException.Message));
}
return objSetFieldVisibilityEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSetFieldVisibilityEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from SetFieldVisibility where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN()
{
mId = TransNullToInt(objRow[conSetFieldVisibility.mId].ToString().Trim()), //mId
IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(), //学校流水号
UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(), //用户Id
ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(), //界面名称
FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(), //字段名
Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(), //标题
CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(), //控件类型
IsVisible = TransNullToBool(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()), //是否显示
UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(), //说明
FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim() //FuncModuleId
};
objSetFieldVisibilityEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSetFieldVisibilityEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSetFieldVisibilityDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSetFieldVisibilityEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = TransNullToInt(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = TransNullToBool(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSetFieldVisibilityDA: GetObjByDataRowSetFieldVisibility)", objException.Message));
}
objSetFieldVisibilityEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSetFieldVisibilityEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSetFieldVisibilityEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = TransNullToInt(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = TransNullToBool(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSetFieldVisibilityDA: GetObjByDataRow)", objException.Message));
}
objSetFieldVisibilityEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSetFieldVisibilityEN;
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
objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSetFieldVisibilityEN._CurrTabName, conSetFieldVisibility.mId, 8, "");
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
objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSetFieldVisibilityEN._CurrTabName, conSetFieldVisibility.mId, 8, strPrefix);
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from SetFieldVisibility where " + strCondition;
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from SetFieldVisibility where " + strCondition;
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SetFieldVisibility", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SetFieldVisibility", strCondition))
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
objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SetFieldVisibility");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
 {
 objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSetFieldVisibilityEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSetFieldVisibilityEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from SetFieldVisibility where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SetFieldVisibility");
objRow = objDS.Tables["SetFieldVisibility"].NewRow();
 if (objSetFieldVisibilityEN.IdSchool !=  "")
 {
objRow[conSetFieldVisibility.IdSchool] = objSetFieldVisibilityEN.IdSchool; //学校流水号
 }
 if (objSetFieldVisibilityEN.UserId !=  "")
 {
objRow[conSetFieldVisibility.UserId] = objSetFieldVisibilityEN.UserId; //用户Id
 }
 if (objSetFieldVisibilityEN.ViewName !=  "")
 {
objRow[conSetFieldVisibility.ViewName] = objSetFieldVisibilityEN.ViewName; //界面名称
 }
objRow[conSetFieldVisibility.FieldName] = objSetFieldVisibilityEN.FieldName; //字段名
objRow[conSetFieldVisibility.Caption] = objSetFieldVisibilityEN.Caption; //标题
objRow[conSetFieldVisibility.CtrlType] = objSetFieldVisibilityEN.CtrlType; //控件类型
objRow[conSetFieldVisibility.IsVisible] = objSetFieldVisibilityEN.IsVisible; //是否显示
 if (objSetFieldVisibilityEN.UpdDate !=  "")
 {
objRow[conSetFieldVisibility.UpdDate] = objSetFieldVisibilityEN.UpdDate; //修改日期
 }
 if (objSetFieldVisibilityEN.UpdUserId !=  "")
 {
objRow[conSetFieldVisibility.UpdUserId] = objSetFieldVisibilityEN.UpdUserId; //修改用户Id
 }
 if (objSetFieldVisibilityEN.Memo !=  "")
 {
objRow[conSetFieldVisibility.Memo] = objSetFieldVisibilityEN.Memo; //说明
 }
 if (objSetFieldVisibilityEN.FuncModuleId !=  "")
 {
objRow[conSetFieldVisibility.FuncModuleId] = objSetFieldVisibilityEN.FuncModuleId; //FuncModuleId
 }
objDS.Tables[clsSetFieldVisibilityEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSetFieldVisibilityEN._CurrTabName);
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSetFieldVisibilityEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSetFieldVisibilityEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSetFieldVisibilityEN.IdSchool  ==  "")
 {
 objSetFieldVisibilityEN.IdSchool = null;
 }
 if (objSetFieldVisibilityEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.IdSchool);
 var strIdSchool = objSetFieldVisibilityEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objSetFieldVisibilityEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UserId);
 var strUserId = objSetFieldVisibilityEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSetFieldVisibilityEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.ViewName);
 var strViewName = objSetFieldVisibilityEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objSetFieldVisibilityEN.FieldName !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.FieldName);
 var strFieldName = objSetFieldVisibilityEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldName + "'");
 }
 
 if (objSetFieldVisibilityEN.Caption !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.Caption);
 var strCaption = objSetFieldVisibilityEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaption + "'");
 }
 
 if (objSetFieldVisibilityEN.CtrlType !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.CtrlType);
 var strCtrlType = objSetFieldVisibilityEN.CtrlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtrlType + "'");
 }
 
 arrFieldListForInsert.Add(conSetFieldVisibility.IsVisible);
 arrValueListForInsert.Add("'" + (objSetFieldVisibilityEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objSetFieldVisibilityEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UpdDate);
 var strUpdDate = objSetFieldVisibilityEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSetFieldVisibilityEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UpdUserId);
 var strUpdUserId = objSetFieldVisibilityEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSetFieldVisibilityEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.Memo);
 var strMemo = objSetFieldVisibilityEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSetFieldVisibilityEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.FuncModuleId);
 var strFuncModuleId = objSetFieldVisibilityEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SetFieldVisibility");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSetFieldVisibilityEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSetFieldVisibilityEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSetFieldVisibilityEN.IdSchool  ==  "")
 {
 objSetFieldVisibilityEN.IdSchool = null;
 }
 if (objSetFieldVisibilityEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.IdSchool);
 var strIdSchool = objSetFieldVisibilityEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objSetFieldVisibilityEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UserId);
 var strUserId = objSetFieldVisibilityEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSetFieldVisibilityEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.ViewName);
 var strViewName = objSetFieldVisibilityEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objSetFieldVisibilityEN.FieldName !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.FieldName);
 var strFieldName = objSetFieldVisibilityEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldName + "'");
 }
 
 if (objSetFieldVisibilityEN.Caption !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.Caption);
 var strCaption = objSetFieldVisibilityEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaption + "'");
 }
 
 if (objSetFieldVisibilityEN.CtrlType !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.CtrlType);
 var strCtrlType = objSetFieldVisibilityEN.CtrlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtrlType + "'");
 }
 
 arrFieldListForInsert.Add(conSetFieldVisibility.IsVisible);
 arrValueListForInsert.Add("'" + (objSetFieldVisibilityEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objSetFieldVisibilityEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UpdDate);
 var strUpdDate = objSetFieldVisibilityEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSetFieldVisibilityEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UpdUserId);
 var strUpdUserId = objSetFieldVisibilityEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSetFieldVisibilityEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.Memo);
 var strMemo = objSetFieldVisibilityEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSetFieldVisibilityEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.FuncModuleId);
 var strFuncModuleId = objSetFieldVisibilityEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SetFieldVisibility");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSetFieldVisibilityEN objSetFieldVisibilityEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSetFieldVisibilityEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSetFieldVisibilityEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSetFieldVisibilityEN.IdSchool  ==  "")
 {
 objSetFieldVisibilityEN.IdSchool = null;
 }
 if (objSetFieldVisibilityEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.IdSchool);
 var strIdSchool = objSetFieldVisibilityEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objSetFieldVisibilityEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UserId);
 var strUserId = objSetFieldVisibilityEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSetFieldVisibilityEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.ViewName);
 var strViewName = objSetFieldVisibilityEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objSetFieldVisibilityEN.FieldName !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.FieldName);
 var strFieldName = objSetFieldVisibilityEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldName + "'");
 }
 
 if (objSetFieldVisibilityEN.Caption !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.Caption);
 var strCaption = objSetFieldVisibilityEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaption + "'");
 }
 
 if (objSetFieldVisibilityEN.CtrlType !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.CtrlType);
 var strCtrlType = objSetFieldVisibilityEN.CtrlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtrlType + "'");
 }
 
 arrFieldListForInsert.Add(conSetFieldVisibility.IsVisible);
 arrValueListForInsert.Add("'" + (objSetFieldVisibilityEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objSetFieldVisibilityEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UpdDate);
 var strUpdDate = objSetFieldVisibilityEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSetFieldVisibilityEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UpdUserId);
 var strUpdUserId = objSetFieldVisibilityEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSetFieldVisibilityEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.Memo);
 var strMemo = objSetFieldVisibilityEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSetFieldVisibilityEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.FuncModuleId);
 var strFuncModuleId = objSetFieldVisibilityEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SetFieldVisibility");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSetFieldVisibilityEN objSetFieldVisibilityEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSetFieldVisibilityEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSetFieldVisibilityEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSetFieldVisibilityEN.IdSchool  ==  "")
 {
 objSetFieldVisibilityEN.IdSchool = null;
 }
 if (objSetFieldVisibilityEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.IdSchool);
 var strIdSchool = objSetFieldVisibilityEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objSetFieldVisibilityEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UserId);
 var strUserId = objSetFieldVisibilityEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSetFieldVisibilityEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.ViewName);
 var strViewName = objSetFieldVisibilityEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objSetFieldVisibilityEN.FieldName !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.FieldName);
 var strFieldName = objSetFieldVisibilityEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldName + "'");
 }
 
 if (objSetFieldVisibilityEN.Caption !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.Caption);
 var strCaption = objSetFieldVisibilityEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaption + "'");
 }
 
 if (objSetFieldVisibilityEN.CtrlType !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.CtrlType);
 var strCtrlType = objSetFieldVisibilityEN.CtrlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtrlType + "'");
 }
 
 arrFieldListForInsert.Add(conSetFieldVisibility.IsVisible);
 arrValueListForInsert.Add("'" + (objSetFieldVisibilityEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objSetFieldVisibilityEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UpdDate);
 var strUpdDate = objSetFieldVisibilityEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSetFieldVisibilityEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.UpdUserId);
 var strUpdUserId = objSetFieldVisibilityEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSetFieldVisibilityEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.Memo);
 var strMemo = objSetFieldVisibilityEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objSetFieldVisibilityEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conSetFieldVisibility.FuncModuleId);
 var strFuncModuleId = objSetFieldVisibilityEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SetFieldVisibility");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSetFieldVisibilitys(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from SetFieldVisibility where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SetFieldVisibility");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conSetFieldVisibility.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSetFieldVisibilityEN._CurrTabName ].NewRow();
objRow[conSetFieldVisibility.IdSchool] = oRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objRow[conSetFieldVisibility.UserId] = oRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objRow[conSetFieldVisibility.ViewName] = oRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objRow[conSetFieldVisibility.FieldName] = oRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objRow[conSetFieldVisibility.Caption] = oRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objRow[conSetFieldVisibility.CtrlType] = oRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objRow[conSetFieldVisibility.IsVisible] = oRow[conSetFieldVisibility.IsVisible].ToString().Trim(); //是否显示
objRow[conSetFieldVisibility.UpdDate] = oRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objRow[conSetFieldVisibility.UpdUserId] = oRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conSetFieldVisibility.Memo] = oRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objRow[conSetFieldVisibility.FuncModuleId] = oRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
 objDS.Tables[clsSetFieldVisibilityEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSetFieldVisibilityEN._CurrTabName);
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
 /// <param name = "objSetFieldVisibilityEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSetFieldVisibilityEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSetFieldVisibilityEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from SetFieldVisibility where mId = " + ""+ objSetFieldVisibilityEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSetFieldVisibilityEN._CurrTabName);
if (objDS.Tables[clsSetFieldVisibilityEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objSetFieldVisibilityEN.mId+"");
return false;
}
objRow = objDS.Tables[clsSetFieldVisibilityEN._CurrTabName].Rows[0];
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.IdSchool))
 {
objRow[conSetFieldVisibility.IdSchool] = objSetFieldVisibilityEN.IdSchool; //学校流水号
 }
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UserId))
 {
objRow[conSetFieldVisibility.UserId] = objSetFieldVisibilityEN.UserId; //用户Id
 }
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.ViewName))
 {
objRow[conSetFieldVisibility.ViewName] = objSetFieldVisibilityEN.ViewName; //界面名称
 }
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.FieldName))
 {
objRow[conSetFieldVisibility.FieldName] = objSetFieldVisibilityEN.FieldName; //字段名
 }
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.Caption))
 {
objRow[conSetFieldVisibility.Caption] = objSetFieldVisibilityEN.Caption; //标题
 }
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.CtrlType))
 {
objRow[conSetFieldVisibility.CtrlType] = objSetFieldVisibilityEN.CtrlType; //控件类型
 }
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.IsVisible))
 {
objRow[conSetFieldVisibility.IsVisible] = objSetFieldVisibilityEN.IsVisible; //是否显示
 }
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UpdDate))
 {
objRow[conSetFieldVisibility.UpdDate] = objSetFieldVisibilityEN.UpdDate; //修改日期
 }
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UpdUserId))
 {
objRow[conSetFieldVisibility.UpdUserId] = objSetFieldVisibilityEN.UpdUserId; //修改用户Id
 }
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.Memo))
 {
objRow[conSetFieldVisibility.Memo] = objSetFieldVisibilityEN.Memo; //说明
 }
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.FuncModuleId))
 {
objRow[conSetFieldVisibility.FuncModuleId] = objSetFieldVisibilityEN.FuncModuleId; //FuncModuleId
 }
try
{
objDA.Update(objDS, clsSetFieldVisibilityEN._CurrTabName);
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSetFieldVisibilityEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSetFieldVisibilityEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SetFieldVisibility Set ");
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.IdSchool))
 {
 if (objSetFieldVisibilityEN.IdSchool  ==  "")
 {
 objSetFieldVisibilityEN.IdSchool = null;
 }
 if (objSetFieldVisibilityEN.IdSchool !=  null)
 {
 var strIdSchool = objSetFieldVisibilityEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conSetFieldVisibility.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.IdSchool); //学校流水号
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UserId))
 {
 if (objSetFieldVisibilityEN.UserId !=  null)
 {
 var strUserId = objSetFieldVisibilityEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conSetFieldVisibility.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.UserId); //用户Id
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.ViewName))
 {
 if (objSetFieldVisibilityEN.ViewName !=  null)
 {
 var strViewName = objSetFieldVisibilityEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewName, conSetFieldVisibility.ViewName); //界面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.ViewName); //界面名称
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.FieldName))
 {
 if (objSetFieldVisibilityEN.FieldName !=  null)
 {
 var strFieldName = objSetFieldVisibilityEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldName, conSetFieldVisibility.FieldName); //字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.FieldName); //字段名
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.Caption))
 {
 if (objSetFieldVisibilityEN.Caption !=  null)
 {
 var strCaption = objSetFieldVisibilityEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaption, conSetFieldVisibility.Caption); //标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.Caption); //标题
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.CtrlType))
 {
 if (objSetFieldVisibilityEN.CtrlType !=  null)
 {
 var strCtrlType = objSetFieldVisibilityEN.CtrlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtrlType, conSetFieldVisibility.CtrlType); //控件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.CtrlType); //控件类型
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSetFieldVisibilityEN.IsVisible == true?"1":"0", conSetFieldVisibility.IsVisible); //是否显示
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UpdDate))
 {
 if (objSetFieldVisibilityEN.UpdDate !=  null)
 {
 var strUpdDate = objSetFieldVisibilityEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSetFieldVisibility.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.UpdDate); //修改日期
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UpdUserId))
 {
 if (objSetFieldVisibilityEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSetFieldVisibilityEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSetFieldVisibility.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.UpdUserId); //修改用户Id
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.Memo))
 {
 if (objSetFieldVisibilityEN.Memo !=  null)
 {
 var strMemo = objSetFieldVisibilityEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSetFieldVisibility.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.Memo); //说明
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.FuncModuleId))
 {
 if (objSetFieldVisibilityEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objSetFieldVisibilityEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conSetFieldVisibility.FuncModuleId); //FuncModuleId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.FuncModuleId); //FuncModuleId
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objSetFieldVisibilityEN.mId); 
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
 /// <param name = "objSetFieldVisibilityEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strCondition)
{
 objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSetFieldVisibilityEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSetFieldVisibilityEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SetFieldVisibility Set ");
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.IdSchool))
 {
 if (objSetFieldVisibilityEN.IdSchool  ==  "")
 {
 objSetFieldVisibilityEN.IdSchool = null;
 }
 if (objSetFieldVisibilityEN.IdSchool !=  null)
 {
 var strIdSchool = objSetFieldVisibilityEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UserId))
 {
 if (objSetFieldVisibilityEN.UserId !=  null)
 {
 var strUserId = objSetFieldVisibilityEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.ViewName))
 {
 if (objSetFieldVisibilityEN.ViewName !=  null)
 {
 var strViewName = objSetFieldVisibilityEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewName = '{0}',", strViewName); //界面名称
 }
 else
 {
 sbSQL.Append(" ViewName = null,"); //界面名称
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.FieldName))
 {
 if (objSetFieldVisibilityEN.FieldName !=  null)
 {
 var strFieldName = objSetFieldVisibilityEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldName = '{0}',", strFieldName); //字段名
 }
 else
 {
 sbSQL.Append(" FieldName = null,"); //字段名
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.Caption))
 {
 if (objSetFieldVisibilityEN.Caption !=  null)
 {
 var strCaption = objSetFieldVisibilityEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Caption = '{0}',", strCaption); //标题
 }
 else
 {
 sbSQL.Append(" Caption = null,"); //标题
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.CtrlType))
 {
 if (objSetFieldVisibilityEN.CtrlType !=  null)
 {
 var strCtrlType = objSetFieldVisibilityEN.CtrlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtrlType = '{0}',", strCtrlType); //控件类型
 }
 else
 {
 sbSQL.Append(" CtrlType = null,"); //控件类型
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objSetFieldVisibilityEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UpdDate))
 {
 if (objSetFieldVisibilityEN.UpdDate !=  null)
 {
 var strUpdDate = objSetFieldVisibilityEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UpdUserId))
 {
 if (objSetFieldVisibilityEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSetFieldVisibilityEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.Memo))
 {
 if (objSetFieldVisibilityEN.Memo !=  null)
 {
 var strMemo = objSetFieldVisibilityEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.FuncModuleId))
 {
 if (objSetFieldVisibilityEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objSetFieldVisibilityEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //FuncModuleId
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //FuncModuleId
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
 /// <param name = "objSetFieldVisibilityEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSetFieldVisibilityEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSetFieldVisibilityEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SetFieldVisibility Set ");
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.IdSchool))
 {
 if (objSetFieldVisibilityEN.IdSchool  ==  "")
 {
 objSetFieldVisibilityEN.IdSchool = null;
 }
 if (objSetFieldVisibilityEN.IdSchool !=  null)
 {
 var strIdSchool = objSetFieldVisibilityEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UserId))
 {
 if (objSetFieldVisibilityEN.UserId !=  null)
 {
 var strUserId = objSetFieldVisibilityEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.ViewName))
 {
 if (objSetFieldVisibilityEN.ViewName !=  null)
 {
 var strViewName = objSetFieldVisibilityEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewName = '{0}',", strViewName); //界面名称
 }
 else
 {
 sbSQL.Append(" ViewName = null,"); //界面名称
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.FieldName))
 {
 if (objSetFieldVisibilityEN.FieldName !=  null)
 {
 var strFieldName = objSetFieldVisibilityEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldName = '{0}',", strFieldName); //字段名
 }
 else
 {
 sbSQL.Append(" FieldName = null,"); //字段名
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.Caption))
 {
 if (objSetFieldVisibilityEN.Caption !=  null)
 {
 var strCaption = objSetFieldVisibilityEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Caption = '{0}',", strCaption); //标题
 }
 else
 {
 sbSQL.Append(" Caption = null,"); //标题
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.CtrlType))
 {
 if (objSetFieldVisibilityEN.CtrlType !=  null)
 {
 var strCtrlType = objSetFieldVisibilityEN.CtrlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtrlType = '{0}',", strCtrlType); //控件类型
 }
 else
 {
 sbSQL.Append(" CtrlType = null,"); //控件类型
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objSetFieldVisibilityEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UpdDate))
 {
 if (objSetFieldVisibilityEN.UpdDate !=  null)
 {
 var strUpdDate = objSetFieldVisibilityEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UpdUserId))
 {
 if (objSetFieldVisibilityEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSetFieldVisibilityEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.Memo))
 {
 if (objSetFieldVisibilityEN.Memo !=  null)
 {
 var strMemo = objSetFieldVisibilityEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.FuncModuleId))
 {
 if (objSetFieldVisibilityEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objSetFieldVisibilityEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //FuncModuleId
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //FuncModuleId
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSetFieldVisibilityEN objSetFieldVisibilityEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSetFieldVisibilityEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSetFieldVisibilityEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SetFieldVisibility Set ");
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.IdSchool))
 {
 if (objSetFieldVisibilityEN.IdSchool  ==  "")
 {
 objSetFieldVisibilityEN.IdSchool = null;
 }
 if (objSetFieldVisibilityEN.IdSchool !=  null)
 {
 var strIdSchool = objSetFieldVisibilityEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conSetFieldVisibility.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.IdSchool); //学校流水号
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UserId))
 {
 if (objSetFieldVisibilityEN.UserId !=  null)
 {
 var strUserId = objSetFieldVisibilityEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conSetFieldVisibility.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.UserId); //用户Id
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.ViewName))
 {
 if (objSetFieldVisibilityEN.ViewName !=  null)
 {
 var strViewName = objSetFieldVisibilityEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewName, conSetFieldVisibility.ViewName); //界面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.ViewName); //界面名称
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.FieldName))
 {
 if (objSetFieldVisibilityEN.FieldName !=  null)
 {
 var strFieldName = objSetFieldVisibilityEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldName, conSetFieldVisibility.FieldName); //字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.FieldName); //字段名
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.Caption))
 {
 if (objSetFieldVisibilityEN.Caption !=  null)
 {
 var strCaption = objSetFieldVisibilityEN.Caption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaption, conSetFieldVisibility.Caption); //标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.Caption); //标题
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.CtrlType))
 {
 if (objSetFieldVisibilityEN.CtrlType !=  null)
 {
 var strCtrlType = objSetFieldVisibilityEN.CtrlType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtrlType, conSetFieldVisibility.CtrlType); //控件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.CtrlType); //控件类型
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSetFieldVisibilityEN.IsVisible == true?"1":"0", conSetFieldVisibility.IsVisible); //是否显示
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UpdDate))
 {
 if (objSetFieldVisibilityEN.UpdDate !=  null)
 {
 var strUpdDate = objSetFieldVisibilityEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSetFieldVisibility.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.UpdDate); //修改日期
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.UpdUserId))
 {
 if (objSetFieldVisibilityEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSetFieldVisibilityEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSetFieldVisibility.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.UpdUserId); //修改用户Id
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.Memo))
 {
 if (objSetFieldVisibilityEN.Memo !=  null)
 {
 var strMemo = objSetFieldVisibilityEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSetFieldVisibility.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.Memo); //说明
 }
 }
 
 if (objSetFieldVisibilityEN.IsUpdated(conSetFieldVisibility.FuncModuleId))
 {
 if (objSetFieldVisibilityEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objSetFieldVisibilityEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conSetFieldVisibility.FuncModuleId); //FuncModuleId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSetFieldVisibility.FuncModuleId); //FuncModuleId
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objSetFieldVisibilityEN.mId); 
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("SetFieldVisibility_Delete", values);
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
//删除SetFieldVisibility本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SetFieldVisibility where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSetFieldVisibility(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
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
//删除SetFieldVisibility本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SetFieldVisibility where mId in (" + strKeyList + ")";
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
//删除SetFieldVisibility本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SetFieldVisibility where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSetFieldVisibility(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: DelSetFieldVisibility)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SetFieldVisibility where " + strCondition ;
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
public bool DelSetFieldVisibilityWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSetFieldVisibilityDA: DelSetFieldVisibilityWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SetFieldVisibility where " + strCondition ;
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
 /// <param name = "objSetFieldVisibilityENS">源对象</param>
 /// <param name = "objSetFieldVisibilityENT">目标对象</param>
public void CopyTo(clsSetFieldVisibilityEN objSetFieldVisibilityENS, clsSetFieldVisibilityEN objSetFieldVisibilityENT)
{
objSetFieldVisibilityENT.mId = objSetFieldVisibilityENS.mId; //mId
objSetFieldVisibilityENT.IdSchool = objSetFieldVisibilityENS.IdSchool; //学校流水号
objSetFieldVisibilityENT.UserId = objSetFieldVisibilityENS.UserId; //用户Id
objSetFieldVisibilityENT.ViewName = objSetFieldVisibilityENS.ViewName; //界面名称
objSetFieldVisibilityENT.FieldName = objSetFieldVisibilityENS.FieldName; //字段名
objSetFieldVisibilityENT.Caption = objSetFieldVisibilityENS.Caption; //标题
objSetFieldVisibilityENT.CtrlType = objSetFieldVisibilityENS.CtrlType; //控件类型
objSetFieldVisibilityENT.IsVisible = objSetFieldVisibilityENS.IsVisible; //是否显示
objSetFieldVisibilityENT.UpdDate = objSetFieldVisibilityENS.UpdDate; //修改日期
objSetFieldVisibilityENT.UpdUserId = objSetFieldVisibilityENS.UpdUserId; //修改用户Id
objSetFieldVisibilityENT.Memo = objSetFieldVisibilityENS.Memo; //说明
objSetFieldVisibilityENT.FuncModuleId = objSetFieldVisibilityENS.FuncModuleId; //FuncModuleId
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSetFieldVisibilityEN.FieldName, conSetFieldVisibility.FieldName);
clsCheckSql.CheckFieldNotNull(objSetFieldVisibilityEN.Caption, conSetFieldVisibility.Caption);
clsCheckSql.CheckFieldNotNull(objSetFieldVisibilityEN.CtrlType, conSetFieldVisibility.CtrlType);
//检查字段长度
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.IdSchool, 4, conSetFieldVisibility.IdSchool);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.UserId, 18, conSetFieldVisibility.UserId);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.ViewName, 100, conSetFieldVisibility.ViewName);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.FieldName, 50, conSetFieldVisibility.FieldName);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.Caption, 200, conSetFieldVisibility.Caption);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.CtrlType, 50, conSetFieldVisibility.CtrlType);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.UpdDate, 20, conSetFieldVisibility.UpdDate);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.UpdUserId, 20, conSetFieldVisibility.UpdUserId);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.Memo, 1000, conSetFieldVisibility.Memo);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.FuncModuleId, 8, conSetFieldVisibility.FuncModuleId);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objSetFieldVisibilityEN.IdSchool, 4, conSetFieldVisibility.IdSchool);
 objSetFieldVisibilityEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.IdSchool, 4, conSetFieldVisibility.IdSchool);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.UserId, 18, conSetFieldVisibility.UserId);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.ViewName, 100, conSetFieldVisibility.ViewName);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.FieldName, 50, conSetFieldVisibility.FieldName);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.Caption, 200, conSetFieldVisibility.Caption);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.CtrlType, 50, conSetFieldVisibility.CtrlType);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.UpdDate, 20, conSetFieldVisibility.UpdDate);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.UpdUserId, 20, conSetFieldVisibility.UpdUserId);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.Memo, 1000, conSetFieldVisibility.Memo);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.FuncModuleId, 8, conSetFieldVisibility.FuncModuleId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objSetFieldVisibilityEN.IdSchool, 4, conSetFieldVisibility.IdSchool);
 objSetFieldVisibilityEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.IdSchool, 4, conSetFieldVisibility.IdSchool);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.UserId, 18, conSetFieldVisibility.UserId);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.ViewName, 100, conSetFieldVisibility.ViewName);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.FieldName, 50, conSetFieldVisibility.FieldName);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.Caption, 200, conSetFieldVisibility.Caption);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.CtrlType, 50, conSetFieldVisibility.CtrlType);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.UpdDate, 20, conSetFieldVisibility.UpdDate);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.UpdUserId, 20, conSetFieldVisibility.UpdUserId);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.Memo, 1000, conSetFieldVisibility.Memo);
clsCheckSql.CheckFieldLen(objSetFieldVisibilityEN.FuncModuleId, 8, conSetFieldVisibility.FuncModuleId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSetFieldVisibilityEN.IdSchool, conSetFieldVisibility.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objSetFieldVisibilityEN.UserId, conSetFieldVisibility.UserId);
clsCheckSql.CheckSqlInjection4Field(objSetFieldVisibilityEN.ViewName, conSetFieldVisibility.ViewName);
clsCheckSql.CheckSqlInjection4Field(objSetFieldVisibilityEN.FieldName, conSetFieldVisibility.FieldName);
clsCheckSql.CheckSqlInjection4Field(objSetFieldVisibilityEN.Caption, conSetFieldVisibility.Caption);
clsCheckSql.CheckSqlInjection4Field(objSetFieldVisibilityEN.CtrlType, conSetFieldVisibility.CtrlType);
clsCheckSql.CheckSqlInjection4Field(objSetFieldVisibilityEN.UpdDate, conSetFieldVisibility.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSetFieldVisibilityEN.UpdUserId, conSetFieldVisibility.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objSetFieldVisibilityEN.Memo, conSetFieldVisibility.Memo);
clsCheckSql.CheckSqlInjection4Field(objSetFieldVisibilityEN.FuncModuleId, conSetFieldVisibility.FuncModuleId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objSetFieldVisibilityEN.IdSchool, 4, conSetFieldVisibility.IdSchool);
 objSetFieldVisibilityEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SetFieldVisibility(设置字段可视性),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objSetFieldVisibilityEN.IdSchool == null)
{
 sbCondition.AppendFormat(" and IdSchool is null");
}
else
{
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objSetFieldVisibilityEN.IdSchool);
}
 if (objSetFieldVisibilityEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objSetFieldVisibilityEN.UserId);
}
 if (objSetFieldVisibilityEN.ViewName == null)
{
 sbCondition.AppendFormat(" and ViewName is null");
}
else
{
 sbCondition.AppendFormat(" and ViewName = '{0}'", objSetFieldVisibilityEN.ViewName);
}
 sbCondition.AppendFormat(" and FieldName = '{0}'", objSetFieldVisibilityEN.FieldName);
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSetFieldVisibilityEN._CurrTabName);
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSetFieldVisibilityEN._CurrTabName, strCondition);
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
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
 objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}