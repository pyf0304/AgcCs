
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSetFieldVisibilityDA
 表名:vSetFieldVisibility(00050243)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// v设置字段可视性(vSetFieldVisibility)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSetFieldVisibilityDA : clsCommBase4DA
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
 return clsvSetFieldVisibilityEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSetFieldVisibilityEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSetFieldVisibilityEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSetFieldVisibilityEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSetFieldVisibilityEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from vSetFieldVisibility where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSetFieldVisibility(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA: GetDataTable_vSetFieldVisibility)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from vSetFieldVisibility where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from vSetFieldVisibility where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSetFieldVisibility where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSetFieldVisibility where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSetFieldVisibility where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSetFieldVisibility.* " + 
$"from vSetFieldVisibility " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSetFieldVisibility.mId not in " + 
$"(Select top {intTop_In} vSetFieldVisibility.mId from vSetFieldVisibility " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSetFieldVisibility where {1} and mId not in (Select top {2} mId from vSetFieldVisibility where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSetFieldVisibility where {1} and mId not in (Select top {3} mId from vSetFieldVisibility where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSetFieldVisibility.* " + 
$"from vSetFieldVisibility " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSetFieldVisibility.mId not in " + 
$"(Select top {intTop_In} vSetFieldVisibility.mId from vSetFieldVisibility " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSetFieldVisibility where {1} and mId not in (Select top {2} mId from vSetFieldVisibility where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSetFieldVisibility where {1} and mId not in (Select top {3} mId from vSetFieldVisibility where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSetFieldVisibilityEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA:GetObjLst)", objException.Message));
}
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from vSetFieldVisibility where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = TransNullToInt(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = TransNullToBool(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSetFieldVisibilityDA: GetObjLst)", objException.Message));
}
objvSetFieldVisibilityEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSetFieldVisibilityEN);
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
public List<clsvSetFieldVisibilityEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = TransNullToInt(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = TransNullToBool(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSetFieldVisibilityDA: GetObjLst)", objException.Message));
}
objvSetFieldVisibilityEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSetFieldVisibilityEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSetFieldVisibility(ref clsvSetFieldVisibilityEN objvSetFieldVisibilityEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from vSetFieldVisibility where mId = " + ""+ objvSetFieldVisibilityEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSetFieldVisibilityEN.FuncModuleEnName = objDT.Rows[0][convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvSetFieldVisibilityEN.FuncModuleNameSim = objDT.Rows[0][convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvSetFieldVisibilityEN.mId = TransNullToInt(objDT.Rows[0][convSetFieldVisibility.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvSetFieldVisibilityEN.IdSchool = objDT.Rows[0][convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvSetFieldVisibilityEN.SchoolId = objDT.Rows[0][convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvSetFieldVisibilityEN.SchoolName = objDT.Rows[0][convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvSetFieldVisibilityEN.ViewName = objDT.Rows[0][convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSetFieldVisibilityEN.FieldName = objDT.Rows[0][convSetFieldVisibility.FieldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSetFieldVisibilityEN.Caption = objDT.Rows[0][convSetFieldVisibility.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvSetFieldVisibilityEN.CtrlType = objDT.Rows[0][convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型(字段类型:varchar,字段长度:50,是否可空:False)
 objvSetFieldVisibilityEN.IsVisible = TransNullToBool(objDT.Rows[0][convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvSetFieldVisibilityEN.UpdDate = objDT.Rows[0][convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSetFieldVisibilityEN.UpdUserId = objDT.Rows[0][convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSetFieldVisibilityEN.Memo = objDT.Rows[0][convSetFieldVisibility.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSetFieldVisibilityEN.FuncModuleId = objDT.Rows[0][convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId(字段类型:char,字段长度:8,是否可空:True)
 objvSetFieldVisibilityEN.FuncModuleName = objDT.Rows[0][convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSetFieldVisibilityDA: GetvSetFieldVisibility)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSetFieldVisibilityEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from vSetFieldVisibility where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
 objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型(字段类型:varchar,字段长度:50,是否可空:False)
 objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId(字段类型:char,字段长度:8,是否可空:True)
 objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSetFieldVisibilityDA: GetObjBymId)", objException.Message));
}
return objvSetFieldVisibilityEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSetFieldVisibilityEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
strSQL = "Select * from vSetFieldVisibility where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN()
{
FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(), //功能模块简称
mId = TransNullToInt(objRow[convSetFieldVisibility.mId].ToString().Trim()), //mId
IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(), //学校流水号
SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(), //学校Id
SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(), //学校名称
ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(), //界面名称
FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(), //字段名
Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(), //标题
CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(), //控件类型
IsVisible = TransNullToBool(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()), //是否显示
UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(), //说明
FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(), //FuncModuleId
FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim() //功能模块名称
};
objvSetFieldVisibilityEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSetFieldVisibilityEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSetFieldVisibilityDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSetFieldVisibilityEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = TransNullToInt(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = TransNullToBool(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSetFieldVisibilityDA: GetObjByDataRowvSetFieldVisibility)", objException.Message));
}
objvSetFieldVisibilityEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSetFieldVisibilityEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSetFieldVisibilityEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = TransNullToInt(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = TransNullToBool(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSetFieldVisibilityDA: GetObjByDataRow)", objException.Message));
}
objvSetFieldVisibilityEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSetFieldVisibilityEN;
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
objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSetFieldVisibilityEN._CurrTabName, convSetFieldVisibility.mId, 8, "");
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
objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSetFieldVisibilityEN._CurrTabName, convSetFieldVisibility.mId, 8, strPrefix);
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
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vSetFieldVisibility where " + strCondition;
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
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vSetFieldVisibility where " + strCondition;
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
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSetFieldVisibility", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSetFieldVisibilityDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSetFieldVisibility", strCondition))
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
objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSetFieldVisibility");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityENS">源对象</param>
 /// <param name = "objvSetFieldVisibilityENT">目标对象</param>
public void CopyTo(clsvSetFieldVisibilityEN objvSetFieldVisibilityENS, clsvSetFieldVisibilityEN objvSetFieldVisibilityENT)
{
objvSetFieldVisibilityENT.FuncModuleEnName = objvSetFieldVisibilityENS.FuncModuleEnName; //功能模块英文名称
objvSetFieldVisibilityENT.FuncModuleNameSim = objvSetFieldVisibilityENS.FuncModuleNameSim; //功能模块简称
objvSetFieldVisibilityENT.mId = objvSetFieldVisibilityENS.mId; //mId
objvSetFieldVisibilityENT.IdSchool = objvSetFieldVisibilityENS.IdSchool; //学校流水号
objvSetFieldVisibilityENT.SchoolId = objvSetFieldVisibilityENS.SchoolId; //学校Id
objvSetFieldVisibilityENT.SchoolName = objvSetFieldVisibilityENS.SchoolName; //学校名称
objvSetFieldVisibilityENT.ViewName = objvSetFieldVisibilityENS.ViewName; //界面名称
objvSetFieldVisibilityENT.FieldName = objvSetFieldVisibilityENS.FieldName; //字段名
objvSetFieldVisibilityENT.Caption = objvSetFieldVisibilityENS.Caption; //标题
objvSetFieldVisibilityENT.CtrlType = objvSetFieldVisibilityENS.CtrlType; //控件类型
objvSetFieldVisibilityENT.IsVisible = objvSetFieldVisibilityENS.IsVisible; //是否显示
objvSetFieldVisibilityENT.UpdDate = objvSetFieldVisibilityENS.UpdDate; //修改日期
objvSetFieldVisibilityENT.UpdUserId = objvSetFieldVisibilityENS.UpdUserId; //修改用户Id
objvSetFieldVisibilityENT.Memo = objvSetFieldVisibilityENS.Memo; //说明
objvSetFieldVisibilityENT.FuncModuleId = objvSetFieldVisibilityENS.FuncModuleId; //FuncModuleId
objvSetFieldVisibilityENT.FuncModuleName = objvSetFieldVisibilityENS.FuncModuleName; //功能模块名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSetFieldVisibilityEN objvSetFieldVisibilityEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.FuncModuleEnName, 30, convSetFieldVisibility.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.FuncModuleNameSim, 30, convSetFieldVisibility.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.IdSchool, 4, convSetFieldVisibility.IdSchool);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.SchoolId, 20, convSetFieldVisibility.SchoolId);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.SchoolName, 50, convSetFieldVisibility.SchoolName);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.ViewName, 100, convSetFieldVisibility.ViewName);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.FieldName, 50, convSetFieldVisibility.FieldName);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.Caption, 200, convSetFieldVisibility.Caption);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.CtrlType, 50, convSetFieldVisibility.CtrlType);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.UpdDate, 20, convSetFieldVisibility.UpdDate);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.UpdUserId, 20, convSetFieldVisibility.UpdUserId);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.Memo, 1000, convSetFieldVisibility.Memo);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.FuncModuleId, 8, convSetFieldVisibility.FuncModuleId);
clsCheckSql.CheckFieldLen(objvSetFieldVisibilityEN.FuncModuleName, 30, convSetFieldVisibility.FuncModuleName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.FuncModuleEnName, convSetFieldVisibility.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.FuncModuleNameSim, convSetFieldVisibility.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.IdSchool, convSetFieldVisibility.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.SchoolId, convSetFieldVisibility.SchoolId);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.SchoolName, convSetFieldVisibility.SchoolName);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.ViewName, convSetFieldVisibility.ViewName);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.FieldName, convSetFieldVisibility.FieldName);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.Caption, convSetFieldVisibility.Caption);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.CtrlType, convSetFieldVisibility.CtrlType);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.UpdDate, convSetFieldVisibility.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.UpdUserId, convSetFieldVisibility.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.Memo, convSetFieldVisibility.Memo);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.FuncModuleId, convSetFieldVisibility.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvSetFieldVisibilityEN.FuncModuleName, convSetFieldVisibility.FuncModuleName);
//检查外键字段长度
 objvSetFieldVisibilityEN._IsCheckProperty = true;
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
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
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
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
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
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSetFieldVisibilityEN._CurrTabName);
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
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSetFieldVisibilityEN._CurrTabName, strCondition);
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
 objSQL = clsvSetFieldVisibilityDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}