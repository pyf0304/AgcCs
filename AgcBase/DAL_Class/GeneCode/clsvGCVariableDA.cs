
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvGCVariableDA
 表名:vGCVariable(00050561)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:42
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
 /// vGCVariable(vGCVariable)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvGCVariableDA : clsCommBase4DA
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
 return clsvGCVariableEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvGCVariableEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvGCVariableEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvGCVariableEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvGCVariableEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strVarId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strVarId)
{
strVarId = strVarId.Replace("'", "''");
if (strVarId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vGCVariable中,检查关键字,长度不正确!(clsvGCVariableDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strVarId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vGCVariable中,关键字不能为空 或 null!(clsvGCVariableDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strVarId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvGCVariableDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvGCVariableDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from vGCVariable where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vGCVariable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvGCVariableDA: GetDataTable_vGCVariable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from vGCVariable where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvGCVariableDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvGCVariableDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from vGCVariable where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvGCVariableDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvGCVariableDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vGCVariable where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vGCVariable where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvGCVariableDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vGCVariable where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvGCVariableDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vGCVariable.* " + 
$"from vGCVariable " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vGCVariable.VarId not in " + 
$"(Select top {intTop_In} vGCVariable.VarId from vGCVariable " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vGCVariable where {1} and VarId not in (Select top {2} VarId from vGCVariable where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vGCVariable where {1} and VarId not in (Select top {3} VarId from vGCVariable where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvGCVariableDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vGCVariable.* " + 
$"from vGCVariable " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vGCVariable.VarId not in " + 
$"(Select top {intTop_In} vGCVariable.VarId from vGCVariable " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vGCVariable where {1} and VarId not in (Select top {2} VarId from vGCVariable where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vGCVariable where {1} and VarId not in (Select top {3} VarId from vGCVariable where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvGCVariableEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvGCVariableDA:GetObjLst)", objException.Message));
}
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from vGCVariable where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvGCVariableDA: GetObjLst)", objException.Message));
}
objvGCVariableEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvGCVariableEN);
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
public List<clsvGCVariableEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvGCVariableDA:GetObjLstByTabName)", objException.Message));
}
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvGCVariableDA: GetObjLst)", objException.Message));
}
objvGCVariableEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvGCVariableEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvGCVariable(ref clsvGCVariableEN objvGCVariableEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from vGCVariable where VarId = " + "'"+ objvGCVariableEN.VarId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvGCVariableEN.VarId = objDT.Rows[0][convGCVariable.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objvGCVariableEN.VarName = objDT.Rows[0][convGCVariable.VarName].ToString().Trim(); //变量名(字段类型:varchar,字段长度:50,是否可空:True)
 objvGCVariableEN.VarExpression = objDT.Rows[0][convGCVariable.VarExpression].ToString().Trim(); //变量表达式(字段类型:varchar,字段长度:150,是否可空:True)
 objvGCVariableEN.InitValue = objDT.Rows[0][convGCVariable.InitValue].ToString().Trim(); //初始值(字段类型:varchar,字段长度:1000,是否可空:True)
 objvGCVariableEN.VarTypeId = objDT.Rows[0][convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvGCVariableEN.VarTypeName = objDT.Rows[0][convGCVariable.VarTypeName].ToString().Trim(); //变量类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvGCVariableEN.PrjId = objDT.Rows[0][convGCVariable.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvGCVariableEN.UpdDate = objDT.Rows[0][convGCVariable.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvGCVariableEN.UpdUser = objDT.Rows[0][convGCVariable.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvGCVariableEN.Memo = objDT.Rows[0][convGCVariable.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvGCVariableDA: GetvGCVariable)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <returns>表对象</returns>
public clsvGCVariableEN GetObjByVarId(string strVarId)
{
CheckPrimaryKey(strVarId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from vGCVariable where VarId = " + "'"+ strVarId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
 objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名(字段类型:varchar,字段长度:50,是否可空:True)
 objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式(字段类型:varchar,字段长度:150,是否可空:True)
 objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值(字段类型:varchar,字段长度:1000,是否可空:True)
 objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvGCVariableDA: GetObjByVarId)", objException.Message));
}
return objvGCVariableEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvGCVariableEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvGCVariableDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from vGCVariable where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN()
{
VarId = objRow[convGCVariable.VarId].ToString().Trim(), //变量Id
VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(), //变量名
VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(), //变量表达式
InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(), //初始值
VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(), //变量类型Id
VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(), //变量类型名
PrjId = objRow[convGCVariable.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim() //说明
};
objvGCVariableEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvGCVariableEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvGCVariableDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvGCVariableEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvGCVariableDA: GetObjByDataRowvGCVariable)", objException.Message));
}
objvGCVariableEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvGCVariableEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvGCVariableEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvGCVariableDA: GetObjByDataRow)", objException.Message));
}
objvGCVariableEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvGCVariableEN;
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
objSQL = clsvGCVariableDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvGCVariableEN._CurrTabName, convGCVariable.VarId, 8, "");
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
objSQL = clsvGCVariableDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvGCVariableEN._CurrTabName, convGCVariable.VarId, 8, strPrefix);
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
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select VarId from vGCVariable where " + strCondition;
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
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select VarId from vGCVariable where " + strCondition;
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
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strVarId)
{
CheckPrimaryKey(strVarId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vGCVariable", "VarId = " + "'"+ strVarId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvGCVariableDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vGCVariable", strCondition))
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
objSQL = clsvGCVariableDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vGCVariable");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvGCVariableENS">源对象</param>
 /// <param name = "objvGCVariableENT">目标对象</param>
public void CopyTo(clsvGCVariableEN objvGCVariableENS, clsvGCVariableEN objvGCVariableENT)
{
objvGCVariableENT.VarId = objvGCVariableENS.VarId; //变量Id
objvGCVariableENT.VarName = objvGCVariableENS.VarName; //变量名
objvGCVariableENT.VarExpression = objvGCVariableENS.VarExpression; //变量表达式
objvGCVariableENT.InitValue = objvGCVariableENS.InitValue; //初始值
objvGCVariableENT.VarTypeId = objvGCVariableENS.VarTypeId; //变量类型Id
objvGCVariableENT.VarTypeName = objvGCVariableENS.VarTypeName; //变量类型名
objvGCVariableENT.PrjId = objvGCVariableENS.PrjId; //工程Id
objvGCVariableENT.UpdDate = objvGCVariableENS.UpdDate; //修改日期
objvGCVariableENT.UpdUser = objvGCVariableENS.UpdUser; //修改者
objvGCVariableENT.Memo = objvGCVariableENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvGCVariableEN objvGCVariableEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvGCVariableEN.VarId, 8, convGCVariable.VarId);
clsCheckSql.CheckFieldLen(objvGCVariableEN.VarName, 50, convGCVariable.VarName);
clsCheckSql.CheckFieldLen(objvGCVariableEN.VarExpression, 150, convGCVariable.VarExpression);
clsCheckSql.CheckFieldLen(objvGCVariableEN.InitValue, 1000, convGCVariable.InitValue);
clsCheckSql.CheckFieldLen(objvGCVariableEN.VarTypeId, 4, convGCVariable.VarTypeId);
clsCheckSql.CheckFieldLen(objvGCVariableEN.VarTypeName, 50, convGCVariable.VarTypeName);
clsCheckSql.CheckFieldLen(objvGCVariableEN.PrjId, 4, convGCVariable.PrjId);
clsCheckSql.CheckFieldLen(objvGCVariableEN.UpdDate, 20, convGCVariable.UpdDate);
clsCheckSql.CheckFieldLen(objvGCVariableEN.UpdUser, 20, convGCVariable.UpdUser);
clsCheckSql.CheckFieldLen(objvGCVariableEN.Memo, 1000, convGCVariable.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvGCVariableEN.VarId, convGCVariable.VarId);
clsCheckSql.CheckSqlInjection4Field(objvGCVariableEN.VarName, convGCVariable.VarName);
clsCheckSql.CheckSqlInjection4Field(objvGCVariableEN.VarExpression, convGCVariable.VarExpression);
clsCheckSql.CheckSqlInjection4Field(objvGCVariableEN.InitValue, convGCVariable.InitValue);
clsCheckSql.CheckSqlInjection4Field(objvGCVariableEN.VarTypeId, convGCVariable.VarTypeId);
clsCheckSql.CheckSqlInjection4Field(objvGCVariableEN.VarTypeName, convGCVariable.VarTypeName);
clsCheckSql.CheckSqlInjection4Field(objvGCVariableEN.PrjId, convGCVariable.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvGCVariableEN.UpdDate, convGCVariable.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvGCVariableEN.UpdUser, convGCVariable.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvGCVariableEN.Memo, convGCVariable.Memo);
//检查外键字段长度
 objvGCVariableEN._IsCheckProperty = true;
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
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
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
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
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
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvGCVariableEN._CurrTabName);
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
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvGCVariableEN._CurrTabName, strCondition);
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
 objSQL = clsvGCVariableDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}