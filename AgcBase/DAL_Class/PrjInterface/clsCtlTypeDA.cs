
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCtlTypeDA
 表名:CtlType(00050058)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:24:12
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 控件类型缩写(CtlType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCtlTypeDA : clsCommBase4DA
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
 return clsCtlTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCtlTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCtlTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCtlTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCtlTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCtlTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCtlTypeId)
{
strCtlTypeId = strCtlTypeId.Replace("'", "''");
if (strCtlTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:CtlType中,检查关键字,长度不正确!(clsCtlTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCtlTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CtlType中,关键字不能为空 或 null!(clsCtlTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCtlTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCtlTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCtlTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = "Select * from CtlType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CtlType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCtlTypeDA: GetDataTable_CtlType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = "Select * from CtlType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCtlTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCtlTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = "Select * from CtlType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCtlTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCtlTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CtlType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CtlType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCtlTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CtlType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCtlTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CtlType.* " + 
$"from CtlType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CtlType.CtlTypeId not in " + 
$"(Select top {intTop_In} CtlType.CtlTypeId from CtlType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CtlType where {1} and CtlTypeId not in (Select top {2} CtlTypeId from CtlType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CtlType where {1} and CtlTypeId not in (Select top {3} CtlTypeId from CtlType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCtlTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CtlType.* " + 
$"from CtlType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CtlType.CtlTypeId not in " + 
$"(Select top {intTop_In} CtlType.CtlTypeId from CtlType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CtlType where {1} and CtlTypeId not in (Select top {2} CtlTypeId from CtlType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CtlType where {1} and CtlTypeId not in (Select top {3} CtlTypeId from CtlType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCtlTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCtlTypeDA:GetObjLst)", objException.Message));
}
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = "Select * from CtlType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = TransNullToBool(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = TransNullToBool(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = TransNullToBool(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCtlTypeDA: GetObjLst)", objException.Message));
}
objCtlTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCtlTypeEN);
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
public List<clsCtlTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCtlTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = TransNullToBool(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = TransNullToBool(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = TransNullToBool(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCtlTypeDA: GetObjLst)", objException.Message));
}
objCtlTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCtlTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCtlType(ref clsCtlTypeEN objCtlTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = "Select * from CtlType where CtlTypeId = " + "'"+ objCtlTypeEN.CtlTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCtlTypeEN.CtlTypeId = objDT.Rows[0][conCtlType.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objCtlTypeEN.CtlTypeName = objDT.Rows[0][conCtlType.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objCtlTypeEN.CtlTypeENName = objDT.Rows[0][conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objCtlTypeEN.CtlCnName = objDT.Rows[0][conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objCtlTypeEN.CtlTypeAbbr = objDT.Rows[0][conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objCtlTypeEN.HtmlCtrlTypeName = objDT.Rows[0][conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName(字段类型:varchar,字段长度:50,是否可空:True)
 objCtlTypeEN.IsForApple = TransNullToBool(objDT.Rows[0][conCtlType.IsForApple].ToString().Trim()); //IsForApple(字段类型:bit,字段长度:1,是否可空:True)
 objCtlTypeEN.InUse = TransNullToBool(objDT.Rows[0][conCtlType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCtlTypeEN.IsVisible = TransNullToBool(objDT.Rows[0][conCtlType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objCtlTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conCtlType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCtlTypeEN.UpdDate = objDT.Rows[0][conCtlType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCtlTypeEN.UpdUser = objDT.Rows[0][conCtlType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCtlTypeEN.Memo = objDT.Rows[0][conCtlType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCtlTypeDA: GetCtlType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCtlTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsCtlTypeEN GetObjByCtlTypeId(string strCtlTypeId)
{
CheckPrimaryKey(strCtlTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = "Select * from CtlType where CtlTypeId = " + "'"+ strCtlTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
 objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName(字段类型:varchar,字段长度:50,是否可空:True)
 objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple(字段类型:bit,字段长度:1,是否可空:True)
 objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCtlTypeDA: GetObjByCtlTypeId)", objException.Message));
}
return objCtlTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCtlTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCtlTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = "Select * from CtlType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN()
{
CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(), //控件类型号
CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(), //控件类型名
CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(), //控件类型英文名
CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(), //控件类型中文名
CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(), //控件类型缩写
HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(), //HtmlCtrlTypeName
IsForApple = TransNullToBool(objRow[conCtlType.IsForApple].ToString().Trim()), //IsForApple
InUse = TransNullToBool(objRow[conCtlType.InUse].ToString().Trim()), //是否在用
IsVisible = TransNullToBool(objRow[conCtlType.IsVisible].ToString().Trim()), //是否显示
OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCtlType.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim() //说明
};
objCtlTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCtlTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCtlTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCtlTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = TransNullToBool(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = TransNullToBool(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = TransNullToBool(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCtlTypeDA: GetObjByDataRowCtlType)", objException.Message));
}
objCtlTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCtlTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCtlTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = TransNullToBool(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = TransNullToBool(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = TransNullToBool(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCtlTypeDA: GetObjByDataRow)", objException.Message));
}
objCtlTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCtlTypeEN;
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
objSQL = clsCtlTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCtlTypeEN._CurrTabName, conCtlType.CtlTypeId, 2, "");
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
objSQL = clsCtlTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCtlTypeEN._CurrTabName, conCtlType.CtlTypeId, 2, strPrefix);
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
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CtlTypeId from CtlType where " + strCondition;
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
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CtlTypeId from CtlType where " + strCondition;
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
 /// <param name = "strCtlTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCtlTypeId)
{
CheckPrimaryKey(strCtlTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CtlType", "CtlTypeId = " + "'"+ strCtlTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCtlTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CtlType", strCondition))
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
objSQL = clsCtlTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CtlType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCtlTypeEN objCtlTypeEN)
 {
 objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCtlTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCtlTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = "Select * from CtlType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CtlType");
objRow = objDS.Tables["CtlType"].NewRow();
objRow[conCtlType.CtlTypeId] = objCtlTypeEN.CtlTypeId; //控件类型号
objRow[conCtlType.CtlTypeName] = objCtlTypeEN.CtlTypeName; //控件类型名
 if (objCtlTypeEN.CtlTypeENName !=  "")
 {
objRow[conCtlType.CtlTypeENName] = objCtlTypeEN.CtlTypeENName; //控件类型英文名
 }
objRow[conCtlType.CtlCnName] = objCtlTypeEN.CtlCnName; //控件类型中文名
objRow[conCtlType.CtlTypeAbbr] = objCtlTypeEN.CtlTypeAbbr; //控件类型缩写
 if (objCtlTypeEN.HtmlCtrlTypeName !=  "")
 {
objRow[conCtlType.HtmlCtrlTypeName] = objCtlTypeEN.HtmlCtrlTypeName; //HtmlCtrlTypeName
 }
objRow[conCtlType.IsForApple] = objCtlTypeEN.IsForApple; //IsForApple
objRow[conCtlType.InUse] = objCtlTypeEN.InUse; //是否在用
objRow[conCtlType.IsVisible] = objCtlTypeEN.IsVisible; //是否显示
objRow[conCtlType.OrderNum] = objCtlTypeEN.OrderNum; //序号
 if (objCtlTypeEN.UpdDate !=  "")
 {
objRow[conCtlType.UpdDate] = objCtlTypeEN.UpdDate; //修改日期
 }
 if (objCtlTypeEN.UpdUser !=  "")
 {
objRow[conCtlType.UpdUser] = objCtlTypeEN.UpdUser; //修改者
 }
 if (objCtlTypeEN.Memo !=  "")
 {
objRow[conCtlType.Memo] = objCtlTypeEN.Memo; //说明
 }
objDS.Tables[clsCtlTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCtlTypeEN._CurrTabName);
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCtlTypeEN objCtlTypeEN)
{
 objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCtlTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCtlTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCtlTypeEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeId);
 var strCtlTypeId = objCtlTypeEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objCtlTypeEN.CtlTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeName);
 var strCtlTypeName = objCtlTypeEN.CtlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeName + "'");
 }
 
 if (objCtlTypeEN.CtlTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeENName);
 var strCtlTypeENName = objCtlTypeEN.CtlTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeENName + "'");
 }
 
 if (objCtlTypeEN.CtlCnName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlCnName);
 var strCtlCnName = objCtlTypeEN.CtlCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlCnName + "'");
 }
 
 if (objCtlTypeEN.CtlTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeAbbr);
 var strCtlTypeAbbr = objCtlTypeEN.CtlTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeAbbr + "'");
 }
 
 if (objCtlTypeEN.HtmlCtrlTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.HtmlCtrlTypeName);
 var strHtmlCtrlTypeName = objCtlTypeEN.HtmlCtrlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHtmlCtrlTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conCtlType.IsForApple);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.IsForApple  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCtlType.InUse);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCtlType.IsVisible);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objCtlTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.OrderNum);
 arrValueListForInsert.Add(objCtlTypeEN.OrderNum.ToString());
 }
 
 if (objCtlTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.UpdDate);
 var strUpdDate = objCtlTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCtlTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.UpdUser);
 var strUpdUser = objCtlTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCtlTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.Memo);
 var strMemo = objCtlTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CtlType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCtlTypeEN objCtlTypeEN)
{
 objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCtlTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCtlTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCtlTypeEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeId);
 var strCtlTypeId = objCtlTypeEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objCtlTypeEN.CtlTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeName);
 var strCtlTypeName = objCtlTypeEN.CtlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeName + "'");
 }
 
 if (objCtlTypeEN.CtlTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeENName);
 var strCtlTypeENName = objCtlTypeEN.CtlTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeENName + "'");
 }
 
 if (objCtlTypeEN.CtlCnName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlCnName);
 var strCtlCnName = objCtlTypeEN.CtlCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlCnName + "'");
 }
 
 if (objCtlTypeEN.CtlTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeAbbr);
 var strCtlTypeAbbr = objCtlTypeEN.CtlTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeAbbr + "'");
 }
 
 if (objCtlTypeEN.HtmlCtrlTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.HtmlCtrlTypeName);
 var strHtmlCtrlTypeName = objCtlTypeEN.HtmlCtrlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHtmlCtrlTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conCtlType.IsForApple);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.IsForApple  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCtlType.InUse);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCtlType.IsVisible);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objCtlTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.OrderNum);
 arrValueListForInsert.Add(objCtlTypeEN.OrderNum.ToString());
 }
 
 if (objCtlTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.UpdDate);
 var strUpdDate = objCtlTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCtlTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.UpdUser);
 var strUpdUser = objCtlTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCtlTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.Memo);
 var strMemo = objCtlTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CtlType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCtlTypeEN.CtlTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCtlTypeEN objCtlTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCtlTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCtlTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCtlTypeEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeId);
 var strCtlTypeId = objCtlTypeEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objCtlTypeEN.CtlTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeName);
 var strCtlTypeName = objCtlTypeEN.CtlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeName + "'");
 }
 
 if (objCtlTypeEN.CtlTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeENName);
 var strCtlTypeENName = objCtlTypeEN.CtlTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeENName + "'");
 }
 
 if (objCtlTypeEN.CtlCnName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlCnName);
 var strCtlCnName = objCtlTypeEN.CtlCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlCnName + "'");
 }
 
 if (objCtlTypeEN.CtlTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeAbbr);
 var strCtlTypeAbbr = objCtlTypeEN.CtlTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeAbbr + "'");
 }
 
 if (objCtlTypeEN.HtmlCtrlTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.HtmlCtrlTypeName);
 var strHtmlCtrlTypeName = objCtlTypeEN.HtmlCtrlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHtmlCtrlTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conCtlType.IsForApple);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.IsForApple  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCtlType.InUse);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCtlType.IsVisible);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objCtlTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.OrderNum);
 arrValueListForInsert.Add(objCtlTypeEN.OrderNum.ToString());
 }
 
 if (objCtlTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.UpdDate);
 var strUpdDate = objCtlTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCtlTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.UpdUser);
 var strUpdUser = objCtlTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCtlTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.Memo);
 var strMemo = objCtlTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CtlType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCtlTypeEN.CtlTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCtlTypeEN objCtlTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCtlTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCtlTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCtlTypeEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeId);
 var strCtlTypeId = objCtlTypeEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objCtlTypeEN.CtlTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeName);
 var strCtlTypeName = objCtlTypeEN.CtlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeName + "'");
 }
 
 if (objCtlTypeEN.CtlTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeENName);
 var strCtlTypeENName = objCtlTypeEN.CtlTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeENName + "'");
 }
 
 if (objCtlTypeEN.CtlCnName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlCnName);
 var strCtlCnName = objCtlTypeEN.CtlCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlCnName + "'");
 }
 
 if (objCtlTypeEN.CtlTypeAbbr !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.CtlTypeAbbr);
 var strCtlTypeAbbr = objCtlTypeEN.CtlTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeAbbr + "'");
 }
 
 if (objCtlTypeEN.HtmlCtrlTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.HtmlCtrlTypeName);
 var strHtmlCtrlTypeName = objCtlTypeEN.HtmlCtrlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHtmlCtrlTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conCtlType.IsForApple);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.IsForApple  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCtlType.InUse);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCtlType.IsVisible);
 arrValueListForInsert.Add("'" + (objCtlTypeEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objCtlTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.OrderNum);
 arrValueListForInsert.Add(objCtlTypeEN.OrderNum.ToString());
 }
 
 if (objCtlTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.UpdDate);
 var strUpdDate = objCtlTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCtlTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.UpdUser);
 var strUpdUser = objCtlTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCtlTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCtlType.Memo);
 var strMemo = objCtlTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CtlType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCtlTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = "Select * from CtlType where CtlTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CtlType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCtlTypeId = oRow[conCtlType.CtlTypeId].ToString().Trim();
if (IsExist(strCtlTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("CtlTypeId = {0}", strCtlTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCtlTypeEN._CurrTabName ].NewRow();
objRow[conCtlType.CtlTypeId] = oRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objRow[conCtlType.CtlTypeName] = oRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objRow[conCtlType.CtlTypeENName] = oRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objRow[conCtlType.CtlCnName] = oRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objRow[conCtlType.CtlTypeAbbr] = oRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objRow[conCtlType.HtmlCtrlTypeName] = oRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objRow[conCtlType.IsForApple] = oRow[conCtlType.IsForApple].ToString().Trim(); //IsForApple
objRow[conCtlType.InUse] = oRow[conCtlType.InUse].ToString().Trim(); //是否在用
objRow[conCtlType.IsVisible] = oRow[conCtlType.IsVisible].ToString().Trim(); //是否显示
objRow[conCtlType.OrderNum] = oRow[conCtlType.OrderNum].ToString().Trim(); //序号
objRow[conCtlType.UpdDate] = oRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objRow[conCtlType.UpdUser] = oRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objRow[conCtlType.Memo] = oRow[conCtlType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsCtlTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCtlTypeEN._CurrTabName);
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
 /// <param name = "objCtlTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCtlTypeEN objCtlTypeEN)
{
 objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCtlTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCtlTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
strSQL = "Select * from CtlType where CtlTypeId = " + "'"+ objCtlTypeEN.CtlTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCtlTypeEN._CurrTabName);
if (objDS.Tables[clsCtlTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CtlTypeId = " + "'"+ objCtlTypeEN.CtlTypeId+"'");
return false;
}
objRow = objDS.Tables[clsCtlTypeEN._CurrTabName].Rows[0];
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeId))
 {
objRow[conCtlType.CtlTypeId] = objCtlTypeEN.CtlTypeId; //控件类型号
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeName))
 {
objRow[conCtlType.CtlTypeName] = objCtlTypeEN.CtlTypeName; //控件类型名
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeENName))
 {
objRow[conCtlType.CtlTypeENName] = objCtlTypeEN.CtlTypeENName; //控件类型英文名
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlCnName))
 {
objRow[conCtlType.CtlCnName] = objCtlTypeEN.CtlCnName; //控件类型中文名
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeAbbr))
 {
objRow[conCtlType.CtlTypeAbbr] = objCtlTypeEN.CtlTypeAbbr; //控件类型缩写
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.HtmlCtrlTypeName))
 {
objRow[conCtlType.HtmlCtrlTypeName] = objCtlTypeEN.HtmlCtrlTypeName; //HtmlCtrlTypeName
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.IsForApple))
 {
objRow[conCtlType.IsForApple] = objCtlTypeEN.IsForApple; //IsForApple
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.InUse))
 {
objRow[conCtlType.InUse] = objCtlTypeEN.InUse; //是否在用
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.IsVisible))
 {
objRow[conCtlType.IsVisible] = objCtlTypeEN.IsVisible; //是否显示
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.OrderNum))
 {
objRow[conCtlType.OrderNum] = objCtlTypeEN.OrderNum; //序号
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.UpdDate))
 {
objRow[conCtlType.UpdDate] = objCtlTypeEN.UpdDate; //修改日期
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.UpdUser))
 {
objRow[conCtlType.UpdUser] = objCtlTypeEN.UpdUser; //修改者
 }
 if (objCtlTypeEN.IsUpdated(conCtlType.Memo))
 {
objRow[conCtlType.Memo] = objCtlTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsCtlTypeEN._CurrTabName);
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCtlTypeEN objCtlTypeEN)
{
 objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCtlTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCtlTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CtlType Set ");
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeName))
 {
 if (objCtlTypeEN.CtlTypeName !=  null)
 {
 var strCtlTypeName = objCtlTypeEN.CtlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeName, conCtlType.CtlTypeName); //控件类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.CtlTypeName); //控件类型名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeENName))
 {
 if (objCtlTypeEN.CtlTypeENName !=  null)
 {
 var strCtlTypeENName = objCtlTypeEN.CtlTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeENName, conCtlType.CtlTypeENName); //控件类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.CtlTypeENName); //控件类型英文名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlCnName))
 {
 if (objCtlTypeEN.CtlCnName !=  null)
 {
 var strCtlCnName = objCtlTypeEN.CtlCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlCnName, conCtlType.CtlCnName); //控件类型中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.CtlCnName); //控件类型中文名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeAbbr))
 {
 if (objCtlTypeEN.CtlTypeAbbr !=  null)
 {
 var strCtlTypeAbbr = objCtlTypeEN.CtlTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeAbbr, conCtlType.CtlTypeAbbr); //控件类型缩写
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.CtlTypeAbbr); //控件类型缩写
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.HtmlCtrlTypeName))
 {
 if (objCtlTypeEN.HtmlCtrlTypeName !=  null)
 {
 var strHtmlCtrlTypeName = objCtlTypeEN.HtmlCtrlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHtmlCtrlTypeName, conCtlType.HtmlCtrlTypeName); //HtmlCtrlTypeName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.HtmlCtrlTypeName); //HtmlCtrlTypeName
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.IsForApple))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCtlTypeEN.IsForApple == true?"1":"0", conCtlType.IsForApple); //IsForApple
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCtlTypeEN.InUse == true?"1":"0", conCtlType.InUse); //是否在用
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCtlTypeEN.IsVisible == true?"1":"0", conCtlType.IsVisible); //是否显示
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.OrderNum))
 {
 if (objCtlTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCtlTypeEN.OrderNum, conCtlType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.OrderNum); //序号
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.UpdDate))
 {
 if (objCtlTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objCtlTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCtlType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.UpdDate); //修改日期
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.UpdUser))
 {
 if (objCtlTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objCtlTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCtlType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.UpdUser); //修改者
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.Memo))
 {
 if (objCtlTypeEN.Memo !=  null)
 {
 var strMemo = objCtlTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCtlType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CtlTypeId = '{0}'", objCtlTypeEN.CtlTypeId); 
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
 /// <param name = "objCtlTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCtlTypeEN objCtlTypeEN, string strCondition)
{
 objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCtlTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCtlTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CtlType Set ");
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeName))
 {
 if (objCtlTypeEN.CtlTypeName !=  null)
 {
 var strCtlTypeName = objCtlTypeEN.CtlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeName = '{0}',", strCtlTypeName); //控件类型名
 }
 else
 {
 sbSQL.Append(" CtlTypeName = null,"); //控件类型名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeENName))
 {
 if (objCtlTypeEN.CtlTypeENName !=  null)
 {
 var strCtlTypeENName = objCtlTypeEN.CtlTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeENName = '{0}',", strCtlTypeENName); //控件类型英文名
 }
 else
 {
 sbSQL.Append(" CtlTypeENName = null,"); //控件类型英文名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlCnName))
 {
 if (objCtlTypeEN.CtlCnName !=  null)
 {
 var strCtlCnName = objCtlTypeEN.CtlCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlCnName = '{0}',", strCtlCnName); //控件类型中文名
 }
 else
 {
 sbSQL.Append(" CtlCnName = null,"); //控件类型中文名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeAbbr))
 {
 if (objCtlTypeEN.CtlTypeAbbr !=  null)
 {
 var strCtlTypeAbbr = objCtlTypeEN.CtlTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeAbbr = '{0}',", strCtlTypeAbbr); //控件类型缩写
 }
 else
 {
 sbSQL.Append(" CtlTypeAbbr = null,"); //控件类型缩写
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.HtmlCtrlTypeName))
 {
 if (objCtlTypeEN.HtmlCtrlTypeName !=  null)
 {
 var strHtmlCtrlTypeName = objCtlTypeEN.HtmlCtrlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HtmlCtrlTypeName = '{0}',", strHtmlCtrlTypeName); //HtmlCtrlTypeName
 }
 else
 {
 sbSQL.Append(" HtmlCtrlTypeName = null,"); //HtmlCtrlTypeName
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.IsForApple))
 {
 sbSQL.AppendFormat(" IsForApple = '{0}',", objCtlTypeEN.IsForApple == true?"1":"0"); //IsForApple
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCtlTypeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objCtlTypeEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.OrderNum))
 {
 if (objCtlTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCtlTypeEN.OrderNum, conCtlType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.OrderNum); //序号
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.UpdDate))
 {
 if (objCtlTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objCtlTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.UpdUser))
 {
 if (objCtlTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objCtlTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.Memo))
 {
 if (objCtlTypeEN.Memo !=  null)
 {
 var strMemo = objCtlTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCtlTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCtlTypeEN objCtlTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCtlTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCtlTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CtlType Set ");
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeName))
 {
 if (objCtlTypeEN.CtlTypeName !=  null)
 {
 var strCtlTypeName = objCtlTypeEN.CtlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeName = '{0}',", strCtlTypeName); //控件类型名
 }
 else
 {
 sbSQL.Append(" CtlTypeName = null,"); //控件类型名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeENName))
 {
 if (objCtlTypeEN.CtlTypeENName !=  null)
 {
 var strCtlTypeENName = objCtlTypeEN.CtlTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeENName = '{0}',", strCtlTypeENName); //控件类型英文名
 }
 else
 {
 sbSQL.Append(" CtlTypeENName = null,"); //控件类型英文名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlCnName))
 {
 if (objCtlTypeEN.CtlCnName !=  null)
 {
 var strCtlCnName = objCtlTypeEN.CtlCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlCnName = '{0}',", strCtlCnName); //控件类型中文名
 }
 else
 {
 sbSQL.Append(" CtlCnName = null,"); //控件类型中文名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeAbbr))
 {
 if (objCtlTypeEN.CtlTypeAbbr !=  null)
 {
 var strCtlTypeAbbr = objCtlTypeEN.CtlTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeAbbr = '{0}',", strCtlTypeAbbr); //控件类型缩写
 }
 else
 {
 sbSQL.Append(" CtlTypeAbbr = null,"); //控件类型缩写
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.HtmlCtrlTypeName))
 {
 if (objCtlTypeEN.HtmlCtrlTypeName !=  null)
 {
 var strHtmlCtrlTypeName = objCtlTypeEN.HtmlCtrlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HtmlCtrlTypeName = '{0}',", strHtmlCtrlTypeName); //HtmlCtrlTypeName
 }
 else
 {
 sbSQL.Append(" HtmlCtrlTypeName = null,"); //HtmlCtrlTypeName
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.IsForApple))
 {
 sbSQL.AppendFormat(" IsForApple = '{0}',", objCtlTypeEN.IsForApple == true?"1":"0"); //IsForApple
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCtlTypeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objCtlTypeEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.OrderNum))
 {
 if (objCtlTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCtlTypeEN.OrderNum, conCtlType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.OrderNum); //序号
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.UpdDate))
 {
 if (objCtlTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objCtlTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.UpdUser))
 {
 if (objCtlTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objCtlTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.Memo))
 {
 if (objCtlTypeEN.Memo !=  null)
 {
 var strMemo = objCtlTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCtlTypeEN objCtlTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCtlTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCtlTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CtlType Set ");
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeName))
 {
 if (objCtlTypeEN.CtlTypeName !=  null)
 {
 var strCtlTypeName = objCtlTypeEN.CtlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeName, conCtlType.CtlTypeName); //控件类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.CtlTypeName); //控件类型名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeENName))
 {
 if (objCtlTypeEN.CtlTypeENName !=  null)
 {
 var strCtlTypeENName = objCtlTypeEN.CtlTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeENName, conCtlType.CtlTypeENName); //控件类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.CtlTypeENName); //控件类型英文名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlCnName))
 {
 if (objCtlTypeEN.CtlCnName !=  null)
 {
 var strCtlCnName = objCtlTypeEN.CtlCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlCnName, conCtlType.CtlCnName); //控件类型中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.CtlCnName); //控件类型中文名
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.CtlTypeAbbr))
 {
 if (objCtlTypeEN.CtlTypeAbbr !=  null)
 {
 var strCtlTypeAbbr = objCtlTypeEN.CtlTypeAbbr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeAbbr, conCtlType.CtlTypeAbbr); //控件类型缩写
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.CtlTypeAbbr); //控件类型缩写
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.HtmlCtrlTypeName))
 {
 if (objCtlTypeEN.HtmlCtrlTypeName !=  null)
 {
 var strHtmlCtrlTypeName = objCtlTypeEN.HtmlCtrlTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHtmlCtrlTypeName, conCtlType.HtmlCtrlTypeName); //HtmlCtrlTypeName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.HtmlCtrlTypeName); //HtmlCtrlTypeName
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.IsForApple))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCtlTypeEN.IsForApple == true?"1":"0", conCtlType.IsForApple); //IsForApple
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCtlTypeEN.InUse == true?"1":"0", conCtlType.InUse); //是否在用
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCtlTypeEN.IsVisible == true?"1":"0", conCtlType.IsVisible); //是否显示
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.OrderNum))
 {
 if (objCtlTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCtlTypeEN.OrderNum, conCtlType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.OrderNum); //序号
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.UpdDate))
 {
 if (objCtlTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objCtlTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCtlType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.UpdDate); //修改日期
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.UpdUser))
 {
 if (objCtlTypeEN.UpdUser !=  null)
 {
 var strUpdUser = objCtlTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCtlType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.UpdUser); //修改者
 }
 }
 
 if (objCtlTypeEN.IsUpdated(conCtlType.Memo))
 {
 if (objCtlTypeEN.Memo !=  null)
 {
 var strMemo = objCtlTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCtlType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCtlType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CtlTypeId = '{0}'", objCtlTypeEN.CtlTypeId); 
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
 /// <param name = "strCtlTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCtlTypeId) 
{
CheckPrimaryKey(strCtlTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCtlTypeId,
};
 objSQL.ExecSP("CtlType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCtlTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCtlTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCtlTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
//删除CtlType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CtlType where CtlTypeId = " + "'"+ strCtlTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCtlType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
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
//删除CtlType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CtlType where CtlTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCtlTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCtlTypeId) 
{
CheckPrimaryKey(strCtlTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
//删除CtlType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CtlType where CtlTypeId = " + "'"+ strCtlTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCtlType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCtlTypeDA: DelCtlType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CtlType where " + strCondition ;
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
public bool DelCtlTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCtlTypeDA: DelCtlTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CtlType where " + strCondition ;
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
 /// <param name = "objCtlTypeENS">源对象</param>
 /// <param name = "objCtlTypeENT">目标对象</param>
public void CopyTo(clsCtlTypeEN objCtlTypeENS, clsCtlTypeEN objCtlTypeENT)
{
objCtlTypeENT.CtlTypeId = objCtlTypeENS.CtlTypeId; //控件类型号
objCtlTypeENT.CtlTypeName = objCtlTypeENS.CtlTypeName; //控件类型名
objCtlTypeENT.CtlTypeENName = objCtlTypeENS.CtlTypeENName; //控件类型英文名
objCtlTypeENT.CtlCnName = objCtlTypeENS.CtlCnName; //控件类型中文名
objCtlTypeENT.CtlTypeAbbr = objCtlTypeENS.CtlTypeAbbr; //控件类型缩写
objCtlTypeENT.HtmlCtrlTypeName = objCtlTypeENS.HtmlCtrlTypeName; //HtmlCtrlTypeName
objCtlTypeENT.IsForApple = objCtlTypeENS.IsForApple; //IsForApple
objCtlTypeENT.InUse = objCtlTypeENS.InUse; //是否在用
objCtlTypeENT.IsVisible = objCtlTypeENS.IsVisible; //是否显示
objCtlTypeENT.OrderNum = objCtlTypeENS.OrderNum; //序号
objCtlTypeENT.UpdDate = objCtlTypeENS.UpdDate; //修改日期
objCtlTypeENT.UpdUser = objCtlTypeENS.UpdUser; //修改者
objCtlTypeENT.Memo = objCtlTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCtlTypeEN objCtlTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCtlTypeEN.CtlTypeName, conCtlType.CtlTypeName);
clsCheckSql.CheckFieldNotNull(objCtlTypeEN.CtlCnName, conCtlType.CtlCnName);
clsCheckSql.CheckFieldNotNull(objCtlTypeEN.CtlTypeAbbr, conCtlType.CtlTypeAbbr);
//检查字段长度
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeId, 2, conCtlType.CtlTypeId);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeName, 30, conCtlType.CtlTypeName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeENName, 50, conCtlType.CtlTypeENName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlCnName, 50, conCtlType.CtlCnName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeAbbr, 5, conCtlType.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(objCtlTypeEN.HtmlCtrlTypeName, 50, conCtlType.HtmlCtrlTypeName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.UpdDate, 20, conCtlType.UpdDate);
clsCheckSql.CheckFieldLen(objCtlTypeEN.UpdUser, 20, conCtlType.UpdUser);
clsCheckSql.CheckFieldLen(objCtlTypeEN.Memo, 1000, conCtlType.Memo);
//检查字段外键固定长度
 objCtlTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCtlTypeEN objCtlTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeName, 30, conCtlType.CtlTypeName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeENName, 50, conCtlType.CtlTypeENName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlCnName, 50, conCtlType.CtlCnName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeAbbr, 5, conCtlType.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(objCtlTypeEN.HtmlCtrlTypeName, 50, conCtlType.HtmlCtrlTypeName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.UpdDate, 20, conCtlType.UpdDate);
clsCheckSql.CheckFieldLen(objCtlTypeEN.UpdUser, 20, conCtlType.UpdUser);
clsCheckSql.CheckFieldLen(objCtlTypeEN.Memo, 1000, conCtlType.Memo);
//检查外键字段长度
 objCtlTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCtlTypeEN objCtlTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeId, 2, conCtlType.CtlTypeId);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeName, 30, conCtlType.CtlTypeName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeENName, 50, conCtlType.CtlTypeENName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlCnName, 50, conCtlType.CtlCnName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.CtlTypeAbbr, 5, conCtlType.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(objCtlTypeEN.HtmlCtrlTypeName, 50, conCtlType.HtmlCtrlTypeName);
clsCheckSql.CheckFieldLen(objCtlTypeEN.UpdDate, 20, conCtlType.UpdDate);
clsCheckSql.CheckFieldLen(objCtlTypeEN.UpdUser, 20, conCtlType.UpdUser);
clsCheckSql.CheckFieldLen(objCtlTypeEN.Memo, 1000, conCtlType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCtlTypeEN.CtlTypeId, conCtlType.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objCtlTypeEN.CtlTypeName, conCtlType.CtlTypeName);
clsCheckSql.CheckSqlInjection4Field(objCtlTypeEN.CtlTypeENName, conCtlType.CtlTypeENName);
clsCheckSql.CheckSqlInjection4Field(objCtlTypeEN.CtlCnName, conCtlType.CtlCnName);
clsCheckSql.CheckSqlInjection4Field(objCtlTypeEN.CtlTypeAbbr, conCtlType.CtlTypeAbbr);
clsCheckSql.CheckSqlInjection4Field(objCtlTypeEN.HtmlCtrlTypeName, conCtlType.HtmlCtrlTypeName);
clsCheckSql.CheckSqlInjection4Field(objCtlTypeEN.UpdDate, conCtlType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCtlTypeEN.UpdUser, conCtlType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCtlTypeEN.Memo, conCtlType.Memo);
//检查外键字段长度
 objCtlTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCtlTypeId()
{
//获取某学院所有专业信息
string strSQL = "select CtlTypeId, CtlTypeName from CtlType ";
 clsSpecSQLforSql mySql = clsCtlTypeDA.GetSpecSQLObj();
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
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
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
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
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
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCtlTypeEN._CurrTabName);
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
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCtlTypeEN._CurrTabName, strCondition);
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
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
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
 objSQL = clsCtlTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}