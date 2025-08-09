
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVariableDA
 表名:GCVariable(00050559)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:32
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
 /// GC变量(GCVariable)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsGCVariableDA : clsCommBase4DA
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
 return clsGCVariableEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsGCVariableEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCVariableEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsGCVariableEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsGCVariableEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:GCVariable中,检查关键字,长度不正确!(clsGCVariableDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strVarId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:GCVariable中,关键字不能为空 或 null!(clsGCVariableDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strVarId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsGCVariableDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsGCVariableDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from GCVariable where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_GCVariable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsGCVariableDA: GetDataTable_GCVariable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from GCVariable where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsGCVariableDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsGCVariableDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from GCVariable where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsGCVariableDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsGCVariableDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCVariable where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCVariable where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsGCVariableDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from GCVariable where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsGCVariableDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} GCVariable.* " + 
$"from GCVariable " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and GCVariable.VarId not in " + 
$"(Select top {intTop_In} GCVariable.VarId from GCVariable " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCVariable where {1} and VarId not in (Select top {2} VarId from GCVariable where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCVariable where {1} and VarId not in (Select top {3} VarId from GCVariable where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsGCVariableDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} GCVariable.* " + 
$"from GCVariable " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and GCVariable.VarId not in " + 
$"(Select top {intTop_In} GCVariable.VarId from GCVariable " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GCVariable where {1} and VarId not in (Select top {2} VarId from GCVariable where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GCVariable where {1} and VarId not in (Select top {3} VarId from GCVariable where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsGCVariableEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsGCVariableDA:GetObjLst)", objException.Message));
}
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from GCVariable where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGCVariableDA: GetObjLst)", objException.Message));
}
objGCVariableEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGCVariableEN);
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
public List<clsGCVariableEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsGCVariableDA:GetObjLstByTabName)", objException.Message));
}
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGCVariableDA: GetObjLst)", objException.Message));
}
objGCVariableEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGCVariableEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objGCVariableEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetGCVariable(ref clsGCVariableEN objGCVariableEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from GCVariable where VarId = " + "'"+ objGCVariableEN.VarId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objGCVariableEN.VarId = objDT.Rows[0][conGCVariable.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objGCVariableEN.VarName = objDT.Rows[0][conGCVariable.VarName].ToString().Trim(); //变量名(字段类型:varchar,字段长度:50,是否可空:True)
 objGCVariableEN.VarExpression = objDT.Rows[0][conGCVariable.VarExpression].ToString().Trim(); //变量表达式(字段类型:varchar,字段长度:150,是否可空:True)
 objGCVariableEN.FilePath = objDT.Rows[0][conGCVariable.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objGCVariableEN.InitValue = objDT.Rows[0][conGCVariable.InitValue].ToString().Trim(); //初始值(字段类型:varchar,字段长度:1000,是否可空:True)
 objGCVariableEN.VarTypeId = objDT.Rows[0][conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id(字段类型:char,字段长度:4,是否可空:True)
 objGCVariableEN.DataTypeId = objDT.Rows[0][conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objGCVariableEN.VariableType = objDT.Rows[0][conGCVariable.VariableType].ToString().Trim(); //变量类型(字段类型:varchar,字段长度:100,是否可空:True)
 objGCVariableEN.VariableTypeFullName = objDT.Rows[0][conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objGCVariableEN.ClsName = objDT.Rows[0][conGCVariable.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
 objGCVariableEN.UpdDate = objDT.Rows[0][conGCVariable.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVariableEN.UpdUser = objDT.Rows[0][conGCVariable.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVariableEN.Memo = objDT.Rows[0][conGCVariable.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsGCVariableDA: GetGCVariable)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <returns>表对象</returns>
public clsGCVariableEN GetObjByVarId(string strVarId)
{
CheckPrimaryKey(strVarId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from GCVariable where VarId = " + "'"+ strVarId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
 objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名(字段类型:varchar,字段长度:50,是否可空:True)
 objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式(字段类型:varchar,字段长度:150,是否可空:True)
 objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值(字段类型:varchar,字段长度:1000,是否可空:True)
 objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id(字段类型:char,字段长度:4,是否可空:True)
 objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型(字段类型:varchar,字段长度:100,是否可空:True)
 objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
 objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsGCVariableDA: GetObjByVarId)", objException.Message));
}
return objGCVariableEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsGCVariableEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsGCVariableDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from GCVariable where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN()
{
VarId = objRow[conGCVariable.VarId].ToString().Trim(), //变量Id
VarName = objRow[conGCVariable.VarName].ToString().Trim(), //变量名
VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(), //变量表达式
FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(), //文件路径
InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(), //初始值
VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(), //变量类型Id
DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(), //数据类型Id
VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(), //变量类型
VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(), //变量类型全名
ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(), //类名
UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim() //说明
};
objGCVariableEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCVariableEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsGCVariableDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsGCVariableEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsGCVariableDA: GetObjByDataRowGCVariable)", objException.Message));
}
objGCVariableEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCVariableEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsGCVariableEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsGCVariableDA: GetObjByDataRow)", objException.Message));
}
objGCVariableEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGCVariableEN;
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
objSQL = clsGCVariableDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGCVariableEN._CurrTabName, conGCVariable.VarId, 8, "");
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
objSQL = clsGCVariableDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGCVariableEN._CurrTabName, conGCVariable.VarId, 8, strPrefix);
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
 objSQL = clsGCVariableDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select VarId from GCVariable where " + strCondition;
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
 objSQL = clsGCVariableDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select VarId from GCVariable where " + strCondition;
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
 objSQL = clsGCVariableDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GCVariable", "VarId = " + "'"+ strVarId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsGCVariableDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GCVariable", strCondition))
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
objSQL = clsGCVariableDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("GCVariable");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsGCVariableEN objGCVariableEN)
 {
 objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariableEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVariableEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from GCVariable where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GCVariable");
objRow = objDS.Tables["GCVariable"].NewRow();
objRow[conGCVariable.VarId] = objGCVariableEN.VarId; //变量Id
objRow[conGCVariable.VarName] = objGCVariableEN.VarName; //变量名
objRow[conGCVariable.VarExpression] = objGCVariableEN.VarExpression; //变量表达式
 if (objGCVariableEN.FilePath !=  "")
 {
objRow[conGCVariable.FilePath] = objGCVariableEN.FilePath; //文件路径
 }
 if (objGCVariableEN.InitValue !=  "")
 {
objRow[conGCVariable.InitValue] = objGCVariableEN.InitValue; //初始值
 }
objRow[conGCVariable.VarTypeId] = objGCVariableEN.VarTypeId; //变量类型Id
objRow[conGCVariable.DataTypeId] = objGCVariableEN.DataTypeId; //数据类型Id
 if (objGCVariableEN.VariableType !=  "")
 {
objRow[conGCVariable.VariableType] = objGCVariableEN.VariableType; //变量类型
 }
 if (objGCVariableEN.VariableTypeFullName !=  "")
 {
objRow[conGCVariable.VariableTypeFullName] = objGCVariableEN.VariableTypeFullName; //变量类型全名
 }
 if (objGCVariableEN.ClsName !=  "")
 {
objRow[conGCVariable.ClsName] = objGCVariableEN.ClsName; //类名
 }
 if (objGCVariableEN.UpdDate !=  "")
 {
objRow[conGCVariable.UpdDate] = objGCVariableEN.UpdDate; //修改日期
 }
 if (objGCVariableEN.UpdUser !=  "")
 {
objRow[conGCVariable.UpdUser] = objGCVariableEN.UpdUser; //修改者
 }
 if (objGCVariableEN.Memo !=  "")
 {
objRow[conGCVariable.Memo] = objGCVariableEN.Memo; //说明
 }
objDS.Tables[clsGCVariableEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsGCVariableEN._CurrTabName);
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGCVariableEN objGCVariableEN)
{
 objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariableEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVariableEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVariableEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarId);
 var strVarId = objGCVariableEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objGCVariableEN.VarName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarName);
 var strVarName = objGCVariableEN.VarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarName + "'");
 }
 
 if (objGCVariableEN.VarExpression !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarExpression);
 var strVarExpression = objGCVariableEN.VarExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarExpression + "'");
 }
 
 if (objGCVariableEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.FilePath);
 var strFilePath = objGCVariableEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objGCVariableEN.InitValue !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.InitValue);
 var strInitValue = objGCVariableEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInitValue + "'");
 }
 
 if (objGCVariableEN.VarTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarTypeId);
 var strVarTypeId = objGCVariableEN.VarTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarTypeId + "'");
 }
 
 if (objGCVariableEN.DataTypeId  ==  "")
 {
 objGCVariableEN.DataTypeId = null;
 }
 if (objGCVariableEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.DataTypeId);
 var strDataTypeId = objGCVariableEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objGCVariableEN.VariableType !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VariableType);
 var strVariableType = objGCVariableEN.VariableType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVariableType + "'");
 }
 
 if (objGCVariableEN.VariableTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VariableTypeFullName);
 var strVariableTypeFullName = objGCVariableEN.VariableTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVariableTypeFullName + "'");
 }
 
 if (objGCVariableEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.ClsName);
 var strClsName = objGCVariableEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 
 if (objGCVariableEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.UpdDate);
 var strUpdDate = objGCVariableEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVariableEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.UpdUser);
 var strUpdUser = objGCVariableEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVariableEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.Memo);
 var strMemo = objGCVariableEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVariable");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGCVariableEN objGCVariableEN)
{
 objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariableEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVariableEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVariableEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarId);
 var strVarId = objGCVariableEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objGCVariableEN.VarName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarName);
 var strVarName = objGCVariableEN.VarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarName + "'");
 }
 
 if (objGCVariableEN.VarExpression !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarExpression);
 var strVarExpression = objGCVariableEN.VarExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarExpression + "'");
 }
 
 if (objGCVariableEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.FilePath);
 var strFilePath = objGCVariableEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objGCVariableEN.InitValue !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.InitValue);
 var strInitValue = objGCVariableEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInitValue + "'");
 }
 
 if (objGCVariableEN.VarTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarTypeId);
 var strVarTypeId = objGCVariableEN.VarTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarTypeId + "'");
 }
 
 if (objGCVariableEN.DataTypeId  ==  "")
 {
 objGCVariableEN.DataTypeId = null;
 }
 if (objGCVariableEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.DataTypeId);
 var strDataTypeId = objGCVariableEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objGCVariableEN.VariableType !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VariableType);
 var strVariableType = objGCVariableEN.VariableType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVariableType + "'");
 }
 
 if (objGCVariableEN.VariableTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VariableTypeFullName);
 var strVariableTypeFullName = objGCVariableEN.VariableTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVariableTypeFullName + "'");
 }
 
 if (objGCVariableEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.ClsName);
 var strClsName = objGCVariableEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 
 if (objGCVariableEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.UpdDate);
 var strUpdDate = objGCVariableEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVariableEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.UpdUser);
 var strUpdUser = objGCVariableEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVariableEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.Memo);
 var strMemo = objGCVariableEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVariable");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objGCVariableEN.VarId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGCVariableEN objGCVariableEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariableEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVariableEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVariableEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarId);
 var strVarId = objGCVariableEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objGCVariableEN.VarName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarName);
 var strVarName = objGCVariableEN.VarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarName + "'");
 }
 
 if (objGCVariableEN.VarExpression !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarExpression);
 var strVarExpression = objGCVariableEN.VarExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarExpression + "'");
 }
 
 if (objGCVariableEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.FilePath);
 var strFilePath = objGCVariableEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objGCVariableEN.InitValue !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.InitValue);
 var strInitValue = objGCVariableEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInitValue + "'");
 }
 
 if (objGCVariableEN.VarTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarTypeId);
 var strVarTypeId = objGCVariableEN.VarTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarTypeId + "'");
 }
 
 if (objGCVariableEN.DataTypeId  ==  "")
 {
 objGCVariableEN.DataTypeId = null;
 }
 if (objGCVariableEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.DataTypeId);
 var strDataTypeId = objGCVariableEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objGCVariableEN.VariableType !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VariableType);
 var strVariableType = objGCVariableEN.VariableType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVariableType + "'");
 }
 
 if (objGCVariableEN.VariableTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VariableTypeFullName);
 var strVariableTypeFullName = objGCVariableEN.VariableTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVariableTypeFullName + "'");
 }
 
 if (objGCVariableEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.ClsName);
 var strClsName = objGCVariableEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 
 if (objGCVariableEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.UpdDate);
 var strUpdDate = objGCVariableEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVariableEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.UpdUser);
 var strUpdUser = objGCVariableEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVariableEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.Memo);
 var strMemo = objGCVariableEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVariable");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objGCVariableEN.VarId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGCVariableEN objGCVariableEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariableEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGCVariableEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGCVariableEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarId);
 var strVarId = objGCVariableEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objGCVariableEN.VarName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarName);
 var strVarName = objGCVariableEN.VarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarName + "'");
 }
 
 if (objGCVariableEN.VarExpression !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarExpression);
 var strVarExpression = objGCVariableEN.VarExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarExpression + "'");
 }
 
 if (objGCVariableEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.FilePath);
 var strFilePath = objGCVariableEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objGCVariableEN.InitValue !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.InitValue);
 var strInitValue = objGCVariableEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInitValue + "'");
 }
 
 if (objGCVariableEN.VarTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VarTypeId);
 var strVarTypeId = objGCVariableEN.VarTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarTypeId + "'");
 }
 
 if (objGCVariableEN.DataTypeId  ==  "")
 {
 objGCVariableEN.DataTypeId = null;
 }
 if (objGCVariableEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.DataTypeId);
 var strDataTypeId = objGCVariableEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objGCVariableEN.VariableType !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VariableType);
 var strVariableType = objGCVariableEN.VariableType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVariableType + "'");
 }
 
 if (objGCVariableEN.VariableTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.VariableTypeFullName);
 var strVariableTypeFullName = objGCVariableEN.VariableTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVariableTypeFullName + "'");
 }
 
 if (objGCVariableEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.ClsName);
 var strClsName = objGCVariableEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 
 if (objGCVariableEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.UpdDate);
 var strUpdDate = objGCVariableEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGCVariableEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.UpdUser);
 var strUpdUser = objGCVariableEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGCVariableEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGCVariable.Memo);
 var strMemo = objGCVariableEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GCVariable");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewGCVariables(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from GCVariable where VarId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GCVariable");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strVarId = oRow[conGCVariable.VarId].ToString().Trim();
if (IsExist(strVarId))
{
 string strResult = "关键字变量值为:" + string.Format("VarId = {0}", strVarId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsGCVariableEN._CurrTabName ].NewRow();
objRow[conGCVariable.VarId] = oRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objRow[conGCVariable.VarName] = oRow[conGCVariable.VarName].ToString().Trim(); //变量名
objRow[conGCVariable.VarExpression] = oRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objRow[conGCVariable.FilePath] = oRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objRow[conGCVariable.InitValue] = oRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objRow[conGCVariable.VarTypeId] = oRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objRow[conGCVariable.DataTypeId] = oRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objRow[conGCVariable.VariableType] = oRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objRow[conGCVariable.VariableTypeFullName] = oRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objRow[conGCVariable.ClsName] = oRow[conGCVariable.ClsName].ToString().Trim(); //类名
objRow[conGCVariable.UpdDate] = oRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objRow[conGCVariable.UpdUser] = oRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objRow[conGCVariable.Memo] = oRow[conGCVariable.Memo].ToString().Trim(); //说明
 objDS.Tables[clsGCVariableEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsGCVariableEN._CurrTabName);
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
 /// <param name = "objGCVariableEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsGCVariableEN objGCVariableEN)
{
 objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariableEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVariableEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
strSQL = "Select * from GCVariable where VarId = " + "'"+ objGCVariableEN.VarId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsGCVariableEN._CurrTabName);
if (objDS.Tables[clsGCVariableEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:VarId = " + "'"+ objGCVariableEN.VarId+"'");
return false;
}
objRow = objDS.Tables[clsGCVariableEN._CurrTabName].Rows[0];
 if (objGCVariableEN.IsUpdated(conGCVariable.VarId))
 {
objRow[conGCVariable.VarId] = objGCVariableEN.VarId; //变量Id
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.VarName))
 {
objRow[conGCVariable.VarName] = objGCVariableEN.VarName; //变量名
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.VarExpression))
 {
objRow[conGCVariable.VarExpression] = objGCVariableEN.VarExpression; //变量表达式
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.FilePath))
 {
objRow[conGCVariable.FilePath] = objGCVariableEN.FilePath; //文件路径
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.InitValue))
 {
objRow[conGCVariable.InitValue] = objGCVariableEN.InitValue; //初始值
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.VarTypeId))
 {
objRow[conGCVariable.VarTypeId] = objGCVariableEN.VarTypeId; //变量类型Id
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.DataTypeId))
 {
objRow[conGCVariable.DataTypeId] = objGCVariableEN.DataTypeId; //数据类型Id
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.VariableType))
 {
objRow[conGCVariable.VariableType] = objGCVariableEN.VariableType; //变量类型
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.VariableTypeFullName))
 {
objRow[conGCVariable.VariableTypeFullName] = objGCVariableEN.VariableTypeFullName; //变量类型全名
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.ClsName))
 {
objRow[conGCVariable.ClsName] = objGCVariableEN.ClsName; //类名
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.UpdDate))
 {
objRow[conGCVariable.UpdDate] = objGCVariableEN.UpdDate; //修改日期
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.UpdUser))
 {
objRow[conGCVariable.UpdUser] = objGCVariableEN.UpdUser; //修改者
 }
 if (objGCVariableEN.IsUpdated(conGCVariable.Memo))
 {
objRow[conGCVariable.Memo] = objGCVariableEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsGCVariableEN._CurrTabName);
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGCVariableEN objGCVariableEN)
{
 objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariableEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVariableEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update GCVariable Set ");
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarName))
 {
 if (objGCVariableEN.VarName !=  null)
 {
 var strVarName = objGCVariableEN.VarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarName, conGCVariable.VarName); //变量名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.VarName); //变量名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarExpression))
 {
 if (objGCVariableEN.VarExpression !=  null)
 {
 var strVarExpression = objGCVariableEN.VarExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarExpression, conGCVariable.VarExpression); //变量表达式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.VarExpression); //变量表达式
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.FilePath))
 {
 if (objGCVariableEN.FilePath !=  null)
 {
 var strFilePath = objGCVariableEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conGCVariable.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.FilePath); //文件路径
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.InitValue))
 {
 if (objGCVariableEN.InitValue !=  null)
 {
 var strInitValue = objGCVariableEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInitValue, conGCVariable.InitValue); //初始值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.InitValue); //初始值
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarTypeId))
 {
 if (objGCVariableEN.VarTypeId !=  null)
 {
 var strVarTypeId = objGCVariableEN.VarTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarTypeId, conGCVariable.VarTypeId); //变量类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.VarTypeId); //变量类型Id
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.DataTypeId))
 {
 if (objGCVariableEN.DataTypeId  ==  "")
 {
 objGCVariableEN.DataTypeId = null;
 }
 if (objGCVariableEN.DataTypeId !=  null)
 {
 var strDataTypeId = objGCVariableEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conGCVariable.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.DataTypeId); //数据类型Id
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VariableType))
 {
 if (objGCVariableEN.VariableType !=  null)
 {
 var strVariableType = objGCVariableEN.VariableType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVariableType, conGCVariable.VariableType); //变量类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.VariableType); //变量类型
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VariableTypeFullName))
 {
 if (objGCVariableEN.VariableTypeFullName !=  null)
 {
 var strVariableTypeFullName = objGCVariableEN.VariableTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVariableTypeFullName, conGCVariable.VariableTypeFullName); //变量类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.VariableTypeFullName); //变量类型全名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.ClsName))
 {
 if (objGCVariableEN.ClsName !=  null)
 {
 var strClsName = objGCVariableEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsName, conGCVariable.ClsName); //类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.ClsName); //类名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.UpdDate))
 {
 if (objGCVariableEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVariableEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conGCVariable.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.UpdDate); //修改日期
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.UpdUser))
 {
 if (objGCVariableEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVariableEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conGCVariable.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.UpdUser); //修改者
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.Memo))
 {
 if (objGCVariableEN.Memo !=  null)
 {
 var strMemo = objGCVariableEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGCVariable.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where VarId = '{0}'", objGCVariableEN.VarId); 
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
 /// <param name = "objGCVariableEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsGCVariableEN objGCVariableEN, string strCondition)
{
 objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariableEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVariableEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCVariable Set ");
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarName))
 {
 if (objGCVariableEN.VarName !=  null)
 {
 var strVarName = objGCVariableEN.VarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarName = '{0}',", strVarName); //变量名
 }
 else
 {
 sbSQL.Append(" VarName = null,"); //变量名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarExpression))
 {
 if (objGCVariableEN.VarExpression !=  null)
 {
 var strVarExpression = objGCVariableEN.VarExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarExpression = '{0}',", strVarExpression); //变量表达式
 }
 else
 {
 sbSQL.Append(" VarExpression = null,"); //变量表达式
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.FilePath))
 {
 if (objGCVariableEN.FilePath !=  null)
 {
 var strFilePath = objGCVariableEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.InitValue))
 {
 if (objGCVariableEN.InitValue !=  null)
 {
 var strInitValue = objGCVariableEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InitValue = '{0}',", strInitValue); //初始值
 }
 else
 {
 sbSQL.Append(" InitValue = null,"); //初始值
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarTypeId))
 {
 if (objGCVariableEN.VarTypeId !=  null)
 {
 var strVarTypeId = objGCVariableEN.VarTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarTypeId = '{0}',", strVarTypeId); //变量类型Id
 }
 else
 {
 sbSQL.Append(" VarTypeId = null,"); //变量类型Id
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.DataTypeId))
 {
 if (objGCVariableEN.DataTypeId  ==  "")
 {
 objGCVariableEN.DataTypeId = null;
 }
 if (objGCVariableEN.DataTypeId !=  null)
 {
 var strDataTypeId = objGCVariableEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VariableType))
 {
 if (objGCVariableEN.VariableType !=  null)
 {
 var strVariableType = objGCVariableEN.VariableType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VariableType = '{0}',", strVariableType); //变量类型
 }
 else
 {
 sbSQL.Append(" VariableType = null,"); //变量类型
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VariableTypeFullName))
 {
 if (objGCVariableEN.VariableTypeFullName !=  null)
 {
 var strVariableTypeFullName = objGCVariableEN.VariableTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VariableTypeFullName = '{0}',", strVariableTypeFullName); //变量类型全名
 }
 else
 {
 sbSQL.Append(" VariableTypeFullName = null,"); //变量类型全名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.ClsName))
 {
 if (objGCVariableEN.ClsName !=  null)
 {
 var strClsName = objGCVariableEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsName = '{0}',", strClsName); //类名
 }
 else
 {
 sbSQL.Append(" ClsName = null,"); //类名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.UpdDate))
 {
 if (objGCVariableEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVariableEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.UpdUser))
 {
 if (objGCVariableEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVariableEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.Memo))
 {
 if (objGCVariableEN.Memo !=  null)
 {
 var strMemo = objGCVariableEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGCVariableEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsGCVariableEN objGCVariableEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariableEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVariableEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCVariable Set ");
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarName))
 {
 if (objGCVariableEN.VarName !=  null)
 {
 var strVarName = objGCVariableEN.VarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarName = '{0}',", strVarName); //变量名
 }
 else
 {
 sbSQL.Append(" VarName = null,"); //变量名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarExpression))
 {
 if (objGCVariableEN.VarExpression !=  null)
 {
 var strVarExpression = objGCVariableEN.VarExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarExpression = '{0}',", strVarExpression); //变量表达式
 }
 else
 {
 sbSQL.Append(" VarExpression = null,"); //变量表达式
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.FilePath))
 {
 if (objGCVariableEN.FilePath !=  null)
 {
 var strFilePath = objGCVariableEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.InitValue))
 {
 if (objGCVariableEN.InitValue !=  null)
 {
 var strInitValue = objGCVariableEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InitValue = '{0}',", strInitValue); //初始值
 }
 else
 {
 sbSQL.Append(" InitValue = null,"); //初始值
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarTypeId))
 {
 if (objGCVariableEN.VarTypeId !=  null)
 {
 var strVarTypeId = objGCVariableEN.VarTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarTypeId = '{0}',", strVarTypeId); //变量类型Id
 }
 else
 {
 sbSQL.Append(" VarTypeId = null,"); //变量类型Id
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.DataTypeId))
 {
 if (objGCVariableEN.DataTypeId  ==  "")
 {
 objGCVariableEN.DataTypeId = null;
 }
 if (objGCVariableEN.DataTypeId !=  null)
 {
 var strDataTypeId = objGCVariableEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VariableType))
 {
 if (objGCVariableEN.VariableType !=  null)
 {
 var strVariableType = objGCVariableEN.VariableType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VariableType = '{0}',", strVariableType); //变量类型
 }
 else
 {
 sbSQL.Append(" VariableType = null,"); //变量类型
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VariableTypeFullName))
 {
 if (objGCVariableEN.VariableTypeFullName !=  null)
 {
 var strVariableTypeFullName = objGCVariableEN.VariableTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VariableTypeFullName = '{0}',", strVariableTypeFullName); //变量类型全名
 }
 else
 {
 sbSQL.Append(" VariableTypeFullName = null,"); //变量类型全名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.ClsName))
 {
 if (objGCVariableEN.ClsName !=  null)
 {
 var strClsName = objGCVariableEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsName = '{0}',", strClsName); //类名
 }
 else
 {
 sbSQL.Append(" ClsName = null,"); //类名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.UpdDate))
 {
 if (objGCVariableEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVariableEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.UpdUser))
 {
 if (objGCVariableEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVariableEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.Memo))
 {
 if (objGCVariableEN.Memo !=  null)
 {
 var strMemo = objGCVariableEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGCVariableEN objGCVariableEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGCVariableEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGCVariableEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GCVariable Set ");
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarName))
 {
 if (objGCVariableEN.VarName !=  null)
 {
 var strVarName = objGCVariableEN.VarName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarName, conGCVariable.VarName); //变量名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.VarName); //变量名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarExpression))
 {
 if (objGCVariableEN.VarExpression !=  null)
 {
 var strVarExpression = objGCVariableEN.VarExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarExpression, conGCVariable.VarExpression); //变量表达式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.VarExpression); //变量表达式
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.FilePath))
 {
 if (objGCVariableEN.FilePath !=  null)
 {
 var strFilePath = objGCVariableEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conGCVariable.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.FilePath); //文件路径
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.InitValue))
 {
 if (objGCVariableEN.InitValue !=  null)
 {
 var strInitValue = objGCVariableEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInitValue, conGCVariable.InitValue); //初始值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.InitValue); //初始值
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VarTypeId))
 {
 if (objGCVariableEN.VarTypeId !=  null)
 {
 var strVarTypeId = objGCVariableEN.VarTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarTypeId, conGCVariable.VarTypeId); //变量类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.VarTypeId); //变量类型Id
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.DataTypeId))
 {
 if (objGCVariableEN.DataTypeId  ==  "")
 {
 objGCVariableEN.DataTypeId = null;
 }
 if (objGCVariableEN.DataTypeId !=  null)
 {
 var strDataTypeId = objGCVariableEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conGCVariable.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.DataTypeId); //数据类型Id
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VariableType))
 {
 if (objGCVariableEN.VariableType !=  null)
 {
 var strVariableType = objGCVariableEN.VariableType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVariableType, conGCVariable.VariableType); //变量类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.VariableType); //变量类型
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.VariableTypeFullName))
 {
 if (objGCVariableEN.VariableTypeFullName !=  null)
 {
 var strVariableTypeFullName = objGCVariableEN.VariableTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVariableTypeFullName, conGCVariable.VariableTypeFullName); //变量类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.VariableTypeFullName); //变量类型全名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.ClsName))
 {
 if (objGCVariableEN.ClsName !=  null)
 {
 var strClsName = objGCVariableEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsName, conGCVariable.ClsName); //类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.ClsName); //类名
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.UpdDate))
 {
 if (objGCVariableEN.UpdDate !=  null)
 {
 var strUpdDate = objGCVariableEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conGCVariable.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.UpdDate); //修改日期
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.UpdUser))
 {
 if (objGCVariableEN.UpdUser !=  null)
 {
 var strUpdUser = objGCVariableEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conGCVariable.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.UpdUser); //修改者
 }
 }
 
 if (objGCVariableEN.IsUpdated(conGCVariable.Memo))
 {
 if (objGCVariableEN.Memo !=  null)
 {
 var strMemo = objGCVariableEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGCVariable.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGCVariable.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where VarId = '{0}'", objGCVariableEN.VarId); 
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
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strVarId) 
{
CheckPrimaryKey(strVarId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strVarId,
};
 objSQL.ExecSP("GCVariable_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strVarId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strVarId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strVarId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
//删除GCVariable本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCVariable where VarId = " + "'"+ strVarId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelGCVariable(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
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
//删除GCVariable本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCVariable where VarId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strVarId) 
{
CheckPrimaryKey(strVarId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
//删除GCVariable本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GCVariable where VarId = " + "'"+ strVarId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelGCVariable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsGCVariableDA: DelGCVariable)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GCVariable where " + strCondition ;
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
public bool DelGCVariableWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsGCVariableDA: DelGCVariableWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGCVariableDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GCVariable where " + strCondition ;
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
 /// <param name = "objGCVariableENS">源对象</param>
 /// <param name = "objGCVariableENT">目标对象</param>
public void CopyTo(clsGCVariableEN objGCVariableENS, clsGCVariableEN objGCVariableENT)
{
objGCVariableENT.VarId = objGCVariableENS.VarId; //变量Id
objGCVariableENT.VarName = objGCVariableENS.VarName; //变量名
objGCVariableENT.VarExpression = objGCVariableENS.VarExpression; //变量表达式
objGCVariableENT.FilePath = objGCVariableENS.FilePath; //文件路径
objGCVariableENT.InitValue = objGCVariableENS.InitValue; //初始值
objGCVariableENT.VarTypeId = objGCVariableENS.VarTypeId; //变量类型Id
objGCVariableENT.DataTypeId = objGCVariableENS.DataTypeId; //数据类型Id
objGCVariableENT.VariableType = objGCVariableENS.VariableType; //变量类型
objGCVariableENT.VariableTypeFullName = objGCVariableENS.VariableTypeFullName; //变量类型全名
objGCVariableENT.ClsName = objGCVariableENS.ClsName; //类名
objGCVariableENT.UpdDate = objGCVariableENS.UpdDate; //修改日期
objGCVariableENT.UpdUser = objGCVariableENS.UpdUser; //修改者
objGCVariableENT.Memo = objGCVariableENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsGCVariableEN objGCVariableEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objGCVariableEN.VarName, conGCVariable.VarName);
clsCheckSql.CheckFieldNotNull(objGCVariableEN.VarExpression, conGCVariable.VarExpression);
clsCheckSql.CheckFieldNotNull(objGCVariableEN.VarTypeId, conGCVariable.VarTypeId);
clsCheckSql.CheckFieldNotNull(objGCVariableEN.DataTypeId, conGCVariable.DataTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objGCVariableEN.VarId, 8, conGCVariable.VarId);
clsCheckSql.CheckFieldLen(objGCVariableEN.VarName, 50, conGCVariable.VarName);
clsCheckSql.CheckFieldLen(objGCVariableEN.VarExpression, 150, conGCVariable.VarExpression);
clsCheckSql.CheckFieldLen(objGCVariableEN.FilePath, 500, conGCVariable.FilePath);
clsCheckSql.CheckFieldLen(objGCVariableEN.InitValue, 1000, conGCVariable.InitValue);
clsCheckSql.CheckFieldLen(objGCVariableEN.VarTypeId, 4, conGCVariable.VarTypeId);
clsCheckSql.CheckFieldLen(objGCVariableEN.DataTypeId, 2, conGCVariable.DataTypeId);
clsCheckSql.CheckFieldLen(objGCVariableEN.VariableType, 100, conGCVariable.VariableType);
clsCheckSql.CheckFieldLen(objGCVariableEN.VariableTypeFullName, 500, conGCVariable.VariableTypeFullName);
clsCheckSql.CheckFieldLen(objGCVariableEN.ClsName, 100, conGCVariable.ClsName);
clsCheckSql.CheckFieldLen(objGCVariableEN.UpdDate, 20, conGCVariable.UpdDate);
clsCheckSql.CheckFieldLen(objGCVariableEN.UpdUser, 20, conGCVariable.UpdUser);
clsCheckSql.CheckFieldLen(objGCVariableEN.Memo, 1000, conGCVariable.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objGCVariableEN.DataTypeId, 2, conGCVariable.DataTypeId);
 objGCVariableEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsGCVariableEN objGCVariableEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGCVariableEN.VarName, 50, conGCVariable.VarName);
clsCheckSql.CheckFieldLen(objGCVariableEN.VarExpression, 150, conGCVariable.VarExpression);
clsCheckSql.CheckFieldLen(objGCVariableEN.FilePath, 500, conGCVariable.FilePath);
clsCheckSql.CheckFieldLen(objGCVariableEN.InitValue, 1000, conGCVariable.InitValue);
clsCheckSql.CheckFieldLen(objGCVariableEN.VarTypeId, 4, conGCVariable.VarTypeId);
clsCheckSql.CheckFieldLen(objGCVariableEN.DataTypeId, 2, conGCVariable.DataTypeId);
clsCheckSql.CheckFieldLen(objGCVariableEN.VariableType, 100, conGCVariable.VariableType);
clsCheckSql.CheckFieldLen(objGCVariableEN.VariableTypeFullName, 500, conGCVariable.VariableTypeFullName);
clsCheckSql.CheckFieldLen(objGCVariableEN.ClsName, 100, conGCVariable.ClsName);
clsCheckSql.CheckFieldLen(objGCVariableEN.UpdDate, 20, conGCVariable.UpdDate);
clsCheckSql.CheckFieldLen(objGCVariableEN.UpdUser, 20, conGCVariable.UpdUser);
clsCheckSql.CheckFieldLen(objGCVariableEN.Memo, 1000, conGCVariable.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objGCVariableEN.DataTypeId, 2, conGCVariable.DataTypeId);
 objGCVariableEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsGCVariableEN objGCVariableEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGCVariableEN.VarId, 8, conGCVariable.VarId);
clsCheckSql.CheckFieldLen(objGCVariableEN.VarName, 50, conGCVariable.VarName);
clsCheckSql.CheckFieldLen(objGCVariableEN.VarExpression, 150, conGCVariable.VarExpression);
clsCheckSql.CheckFieldLen(objGCVariableEN.FilePath, 500, conGCVariable.FilePath);
clsCheckSql.CheckFieldLen(objGCVariableEN.InitValue, 1000, conGCVariable.InitValue);
clsCheckSql.CheckFieldLen(objGCVariableEN.VarTypeId, 4, conGCVariable.VarTypeId);
clsCheckSql.CheckFieldLen(objGCVariableEN.DataTypeId, 2, conGCVariable.DataTypeId);
clsCheckSql.CheckFieldLen(objGCVariableEN.VariableType, 100, conGCVariable.VariableType);
clsCheckSql.CheckFieldLen(objGCVariableEN.VariableTypeFullName, 500, conGCVariable.VariableTypeFullName);
clsCheckSql.CheckFieldLen(objGCVariableEN.ClsName, 100, conGCVariable.ClsName);
clsCheckSql.CheckFieldLen(objGCVariableEN.UpdDate, 20, conGCVariable.UpdDate);
clsCheckSql.CheckFieldLen(objGCVariableEN.UpdUser, 20, conGCVariable.UpdUser);
clsCheckSql.CheckFieldLen(objGCVariableEN.Memo, 1000, conGCVariable.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.VarId, conGCVariable.VarId);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.VarName, conGCVariable.VarName);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.VarExpression, conGCVariable.VarExpression);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.FilePath, conGCVariable.FilePath);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.InitValue, conGCVariable.InitValue);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.VarTypeId, conGCVariable.VarTypeId);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.DataTypeId, conGCVariable.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.VariableType, conGCVariable.VariableType);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.VariableTypeFullName, conGCVariable.VariableTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.ClsName, conGCVariable.ClsName);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.UpdDate, conGCVariable.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.UpdUser, conGCVariable.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objGCVariableEN.Memo, conGCVariable.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objGCVariableEN.DataTypeId, 2, conGCVariable.DataTypeId);
 objGCVariableEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetVarId()
{
//获取某学院所有专业信息
string strSQL = "select VarId, VarName from GCVariable ";
 clsSpecSQLforSql mySql = clsGCVariableDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--GCVariable(GC变量),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGCVariableEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsGCVariableEN objGCVariableEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and VarName = '{0}'", objGCVariableEN.VarName);
 sbCondition.AppendFormat(" and VarTypeId = '{0}'", objGCVariableEN.VarTypeId);
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
 objSQL = clsGCVariableDA.GetSpecSQLObj();
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
 objSQL = clsGCVariableDA.GetSpecSQLObj();
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
 objSQL = clsGCVariableDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGCVariableEN._CurrTabName);
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
 objSQL = clsGCVariableDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGCVariableEN._CurrTabName, strCondition);
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
 objSQL = clsGCVariableDA.GetSpecSQLObj();
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
 objSQL = clsGCVariableDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}