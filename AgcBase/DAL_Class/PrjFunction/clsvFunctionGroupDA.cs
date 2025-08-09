
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionGroupDA
 表名:vFunctionGroup(00050326)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// v函数组(vFunctionGroup)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFunctionGroupDA : clsCommBase4DA
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
 return clsvFunctionGroupEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFunctionGroupEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunctionGroupEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFunctionGroupEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFunctionGroupEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFunctionGroupId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFunctionGroupId)
{
strFunctionGroupId = strFunctionGroupId.Replace("'", "''");
if (strFunctionGroupId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vFunctionGroup中,检查关键字,长度不正确!(clsvFunctionGroupDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFunctionGroupId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFunctionGroup中,关键字不能为空 或 null!(clsvFunctionGroupDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFunctionGroupDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFunctionGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFunctionGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFunctionGroupDA: GetDataTable_vFunctionGroup)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFunctionGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFunctionGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFunctionGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFunctionGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunctionGroup where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunctionGroup where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFunctionGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFunctionGroup where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFunctionGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFunctionGroup.* " + 
$"from vFunctionGroup " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunctionGroup.FunctionGroupId not in " + 
$"(Select top {intTop_In} vFunctionGroup.FunctionGroupId from vFunctionGroup " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunctionGroup where {1} and FunctionGroupId not in (Select top {2} FunctionGroupId from vFunctionGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunctionGroup where {1} and FunctionGroupId not in (Select top {3} FunctionGroupId from vFunctionGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFunctionGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFunctionGroup.* " + 
$"from vFunctionGroup " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunctionGroup.FunctionGroupId not in " + 
$"(Select top {intTop_In} vFunctionGroup.FunctionGroupId from vFunctionGroup " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunctionGroup where {1} and FunctionGroupId not in (Select top {2} FunctionGroupId from vFunctionGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunctionGroup where {1} and FunctionGroupId not in (Select top {3} FunctionGroupId from vFunctionGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFunctionGroupEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFunctionGroupDA:GetObjLst)", objException.Message));
}
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunctionGroupDA: GetObjLst)", objException.Message));
}
objvFunctionGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunctionGroupEN);
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
public List<clsvFunctionGroupEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFunctionGroupDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunctionGroupDA: GetObjLst)", objException.Message));
}
objvFunctionGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunctionGroupEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFunctionGroup(ref clsvFunctionGroupEN objvFunctionGroupEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionGroup where FunctionGroupId = " + "'"+ objvFunctionGroupEN.FunctionGroupId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFunctionGroupEN.FunctionGroupId = objDT.Rows[0][convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunctionGroupEN.FunctionGroupName = objDT.Rows[0][convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvFunctionGroupEN.ProgLangTypeId = objDT.Rows[0][convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunctionGroupEN.ProgLangTypeName = objDT.Rows[0][convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunctionGroupEN.CreateUserId = objDT.Rows[0][convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvFunctionGroupEN.UpdDate = objDT.Rows[0][convFunctionGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionGroupEN.UpdUser = objDT.Rows[0][convFunctionGroup.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionGroupEN.Memo = objDT.Rows[0][convFunctionGroup.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFunctionGroupDA: GetvFunctionGroup)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionGroupId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFunctionGroupEN GetObjByFunctionGroupId(string strFunctionGroupId)
{
CheckPrimaryKey(strFunctionGroupId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionGroup where FunctionGroupId = " + "'"+ strFunctionGroupId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
 objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFunctionGroupDA: GetObjByFunctionGroupId)", objException.Message));
}
return objvFunctionGroupEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFunctionGroupEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFunctionGroupDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
strSQL = "Select * from vFunctionGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN()
{
FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(), //函数组Id
FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(), //函数组名称
ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(), //编程语言类型名
CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(), //建立用户Id
UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim() //说明
};
objvFunctionGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunctionGroupEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFunctionGroupDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFunctionGroupEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFunctionGroupDA: GetObjByDataRowvFunctionGroup)", objException.Message));
}
objvFunctionGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunctionGroupEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFunctionGroupEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFunctionGroupDA: GetObjByDataRow)", objException.Message));
}
objvFunctionGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunctionGroupEN;
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
objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunctionGroupEN._CurrTabName, convFunctionGroup.FunctionGroupId, 4, "");
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
objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunctionGroupEN._CurrTabName, convFunctionGroup.FunctionGroupId, 4, strPrefix);
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
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FunctionGroupId from vFunctionGroup where " + strCondition;
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
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FunctionGroupId from vFunctionGroup where " + strCondition;
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
 /// <param name = "strFunctionGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFunctionGroupId)
{
CheckPrimaryKey(strFunctionGroupId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunctionGroup", "FunctionGroupId = " + "'"+ strFunctionGroupId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFunctionGroupDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunctionGroup", strCondition))
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
objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFunctionGroup");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFunctionGroupENS">源对象</param>
 /// <param name = "objvFunctionGroupENT">目标对象</param>
public void CopyTo(clsvFunctionGroupEN objvFunctionGroupENS, clsvFunctionGroupEN objvFunctionGroupENT)
{
objvFunctionGroupENT.FunctionGroupId = objvFunctionGroupENS.FunctionGroupId; //函数组Id
objvFunctionGroupENT.FunctionGroupName = objvFunctionGroupENS.FunctionGroupName; //函数组名称
objvFunctionGroupENT.ProgLangTypeId = objvFunctionGroupENS.ProgLangTypeId; //编程语言类型Id
objvFunctionGroupENT.ProgLangTypeName = objvFunctionGroupENS.ProgLangTypeName; //编程语言类型名
objvFunctionGroupENT.CreateUserId = objvFunctionGroupENS.CreateUserId; //建立用户Id
objvFunctionGroupENT.UpdDate = objvFunctionGroupENS.UpdDate; //修改日期
objvFunctionGroupENT.UpdUser = objvFunctionGroupENS.UpdUser; //修改者
objvFunctionGroupENT.Memo = objvFunctionGroupENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFunctionGroupEN objvFunctionGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFunctionGroupEN.FunctionGroupId, 4, convFunctionGroup.FunctionGroupId);
clsCheckSql.CheckFieldLen(objvFunctionGroupEN.FunctionGroupName, 50, convFunctionGroup.FunctionGroupName);
clsCheckSql.CheckFieldLen(objvFunctionGroupEN.ProgLangTypeId, 2, convFunctionGroup.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvFunctionGroupEN.ProgLangTypeName, 30, convFunctionGroup.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvFunctionGroupEN.CreateUserId, 18, convFunctionGroup.CreateUserId);
clsCheckSql.CheckFieldLen(objvFunctionGroupEN.UpdDate, 20, convFunctionGroup.UpdDate);
clsCheckSql.CheckFieldLen(objvFunctionGroupEN.UpdUser, 20, convFunctionGroup.UpdUser);
clsCheckSql.CheckFieldLen(objvFunctionGroupEN.Memo, 1000, convFunctionGroup.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFunctionGroupEN.FunctionGroupId, convFunctionGroup.FunctionGroupId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionGroupEN.FunctionGroupName, convFunctionGroup.FunctionGroupName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionGroupEN.ProgLangTypeId, convFunctionGroup.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionGroupEN.ProgLangTypeName, convFunctionGroup.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunctionGroupEN.CreateUserId, convFunctionGroup.CreateUserId);
clsCheckSql.CheckSqlInjection4Field(objvFunctionGroupEN.UpdDate, convFunctionGroup.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFunctionGroupEN.UpdUser, convFunctionGroup.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFunctionGroupEN.Memo, convFunctionGroup.Memo);
//检查外键字段长度
 objvFunctionGroupEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFunctionGroupId()
{
//获取某学院所有专业信息
string strSQL = "select FunctionGroupId, FunctionGroupName from vFunctionGroup ";
 clsSpecSQLforSql mySql = clsvFunctionGroupDA.GetSpecSQLObj();
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
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
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
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
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
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunctionGroupEN._CurrTabName);
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
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunctionGroupEN._CurrTabName, strCondition);
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
 objSQL = clsvFunctionGroupDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}