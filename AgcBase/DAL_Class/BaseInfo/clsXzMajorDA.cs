
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorDA
 表名:XzMajor(00050536)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:基本信息(BaseInfo)
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
 /// 专业(XzMajor)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsXzMajorDA : clsCommBase4DA
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
 return clsXzMajorEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsXzMajorEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzMajorEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsXzMajorEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsXzMajorEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdMajor">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdMajor)
{
strIdMajor = strIdMajor.Replace("'", "''");
if (strIdMajor.Length > 8)
{
throw new Exception("(errid:Data000001)在表:XzMajor中,检查关键字,长度不正确!(clsXzMajorDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdMajor)  ==  true)
{
throw new Exception("(errid:Data000002)在表:XzMajor中,关键字不能为空 或 null!(clsXzMajorDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMajor);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsXzMajorDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsXzMajorDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from XzMajor where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_XzMajor(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsXzMajorDA: GetDataTable_XzMajor)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from XzMajor where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsXzMajorDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsXzMajorDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from XzMajor where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsXzMajorDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsXzMajorDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzMajor where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzMajor where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsXzMajorDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from XzMajor where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsXzMajorDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} XzMajor.* " + 
$"from XzMajor " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and XzMajor.IdMajor not in " + 
$"(Select top {intTop_In} XzMajor.IdMajor from XzMajor " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzMajor where {1} and IdMajor not in (Select top {2} IdMajor from XzMajor where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzMajor where {1} and IdMajor not in (Select top {3} IdMajor from XzMajor where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsXzMajorDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} XzMajor.* " + 
$"from XzMajor " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and XzMajor.IdMajor not in " + 
$"(Select top {intTop_In} XzMajor.IdMajor from XzMajor " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from XzMajor where {1} and IdMajor not in (Select top {2} IdMajor from XzMajor where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from XzMajor where {1} and IdMajor not in (Select top {3} IdMajor from XzMajor where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsXzMajorEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsXzMajorDA:GetObjLst)", objException.Message));
}
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from XzMajor where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdMajor = objRow[conXzMajor.IdMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = TransNullToBool(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = objRow[conXzMajor.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzMajor.OrderNum].ToString().Trim()); //序号
objXzMajorEN.InUse = TransNullToBool(objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzMajorDA: GetObjLst)", objException.Message));
}
objXzMajorEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzMajorEN);
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
public List<clsXzMajorEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsXzMajorDA:GetObjLstByTabName)", objException.Message));
}
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdMajor = objRow[conXzMajor.IdMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = TransNullToBool(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = objRow[conXzMajor.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzMajor.OrderNum].ToString().Trim()); //序号
objXzMajorEN.InUse = TransNullToBool(objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsXzMajorDA: GetObjLst)", objException.Message));
}
objXzMajorEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetXzMajor(ref clsXzMajorEN objXzMajorEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from XzMajor where IdMajor = " + "'"+ objXzMajorEN.IdMajor+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objXzMajorEN.IdMajor = objDT.Rows[0][conXzMajor.IdMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:True)
 objXzMajorEN.MajorID = objDT.Rows[0][conXzMajor.MajorID].ToString().Trim(); //MajorID(字段类型:char,字段长度:4,是否可空:False)
 objXzMajorEN.MajorName = objDT.Rows[0][conXzMajor.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:True)
 objXzMajorEN.IsMainMajor = TransNullToBool(objDT.Rows[0][conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业(字段类型:bit,字段长度:1,是否可空:False)
 objXzMajorEN.CollegeId = objDT.Rows[0][conXzMajor.CollegeId].ToString().Trim(); //学院Id(字段类型:varchar,字段长度:6,是否可空:False)
 objXzMajorEN.OrderNum = TransNullToInt(objDT.Rows[0][conXzMajor.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objXzMajorEN.InUse = TransNullToBool(objDT.Rows[0][conXzMajor.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objXzMajorEN.UpdDate = objDT.Rows[0][conXzMajor.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzMajorEN.UpdUser = objDT.Rows[0][conXzMajor.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsXzMajorDA: GetXzMajor)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdMajor">表关键字</param>
 /// <returns>表对象</returns>
public clsXzMajorEN GetObjByIdMajor(string strIdMajor)
{
CheckPrimaryKey(strIdMajor);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from XzMajor where IdMajor = " + "'"+ strIdMajor+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
 objXzMajorEN.IdMajor = objRow[conXzMajor.IdMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:True)
 objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID(字段类型:char,字段长度:4,是否可空:False)
 objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:True)
 objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业(字段类型:bit,字段长度:1,是否可空:False)
 objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id(字段类型:varchar,字段长度:6,是否可空:False)
 objXzMajorEN.OrderNum = objRow[conXzMajor.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsXzMajorDA: GetObjByIdMajor)", objException.Message));
}
return objXzMajorEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsXzMajorEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsXzMajorDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from XzMajor where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN()
{
IdMajor = objRow[conXzMajor.IdMajor].ToString().Trim(), //专业流水号
MajorID = objRow[conXzMajor.MajorID].ToString().Trim(), //MajorID
MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(), //专业名称
IsMainMajor = TransNullToBool(objRow[conXzMajor.IsMainMajor].ToString().Trim()), //是否重要专业
CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(), //学院Id
OrderNum = objRow[conXzMajor.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzMajor.OrderNum].ToString().Trim()), //序号
InUse = TransNullToBool(objRow[conXzMajor.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim() //修改者
};
objXzMajorEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzMajorEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsXzMajorDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsXzMajorEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdMajor = objRow[conXzMajor.IdMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = TransNullToBool(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = objRow[conXzMajor.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzMajor.OrderNum].ToString().Trim()); //序号
objXzMajorEN.InUse = TransNullToBool(objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsXzMajorDA: GetObjByDataRowXzMajor)", objException.Message));
}
objXzMajorEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzMajorEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsXzMajorEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdMajor = objRow[conXzMajor.IdMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = TransNullToBool(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = objRow[conXzMajor.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conXzMajor.OrderNum].ToString().Trim()); //序号
objXzMajorEN.InUse = TransNullToBool(objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsXzMajorDA: GetObjByDataRow)", objException.Message));
}
objXzMajorEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objXzMajorEN;
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
objSQL = clsXzMajorDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzMajorEN._CurrTabName, conXzMajor.IdMajor, 8, "");
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
objSQL = clsXzMajorDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsXzMajorEN._CurrTabName, conXzMajor.IdMajor, 8, strPrefix);
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
 objSQL = clsXzMajorDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMajor from XzMajor where " + strCondition;
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
 objSQL = clsXzMajorDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMajor from XzMajor where " + strCondition;
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
 /// <param name = "strIdMajor">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdMajor)
{
CheckPrimaryKey(strIdMajor);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzMajor", "IdMajor = " + "'"+ strIdMajor+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsXzMajorDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("XzMajor", strCondition))
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
objSQL = clsXzMajorDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("XzMajor");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsXzMajorEN objXzMajorEN)
 {
 objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzMajorEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from XzMajor where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzMajor");
objRow = objDS.Tables["XzMajor"].NewRow();
objRow[conXzMajor.IdMajor] = objXzMajorEN.IdMajor; //专业流水号
objRow[conXzMajor.MajorID] = objXzMajorEN.MajorID; //MajorID
 if (objXzMajorEN.MajorName !=  "")
 {
objRow[conXzMajor.MajorName] = objXzMajorEN.MajorName; //专业名称
 }
objRow[conXzMajor.IsMainMajor] = objXzMajorEN.IsMainMajor; //是否重要专业
objRow[conXzMajor.CollegeId] = objXzMajorEN.CollegeId; //学院Id
objRow[conXzMajor.OrderNum] = objXzMajorEN.OrderNum; //序号
objRow[conXzMajor.InUse] = objXzMajorEN.InUse; //是否在用
 if (objXzMajorEN.UpdDate !=  "")
 {
objRow[conXzMajor.UpdDate] = objXzMajorEN.UpdDate; //修改日期
 }
 if (objXzMajorEN.UpdUser !=  "")
 {
objRow[conXzMajor.UpdUser] = objXzMajorEN.UpdUser; //修改者
 }
objDS.Tables[clsXzMajorEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsXzMajorEN._CurrTabName);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzMajorEN objXzMajorEN)
{
 objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzMajorEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzMajorEN.IdMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.IdMajor);
 var strIdMajor = objXzMajorEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMajor + "'");
 }
 
 if (objXzMajorEN.MajorID !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.MajorID);
 var strMajorID = objXzMajorEN.MajorID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorID + "'");
 }
 
 if (objXzMajorEN.MajorName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.MajorName);
 var strMajorName = objXzMajorEN.MajorName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorName + "'");
 }
 
 arrFieldListForInsert.Add(conXzMajor.IsMainMajor);
 arrValueListForInsert.Add("'" + (objXzMajorEN.IsMainMajor  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.CollegeId);
 var strCollegeId = objXzMajorEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeId + "'");
 }
 
 if (objXzMajorEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.OrderNum);
 arrValueListForInsert.Add(objXzMajorEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conXzMajor.InUse);
 arrValueListForInsert.Add("'" + (objXzMajorEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.UpdDate);
 var strUpdDate = objXzMajorEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzMajorEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.UpdUser);
 var strUpdUser = objXzMajorEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzMajor");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzMajorEN objXzMajorEN)
{
 objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzMajorEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzMajorEN.IdMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.IdMajor);
 var strIdMajor = objXzMajorEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMajor + "'");
 }
 
 if (objXzMajorEN.MajorID !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.MajorID);
 var strMajorID = objXzMajorEN.MajorID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorID + "'");
 }
 
 if (objXzMajorEN.MajorName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.MajorName);
 var strMajorName = objXzMajorEN.MajorName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorName + "'");
 }
 
 arrFieldListForInsert.Add(conXzMajor.IsMainMajor);
 arrValueListForInsert.Add("'" + (objXzMajorEN.IsMainMajor  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.CollegeId);
 var strCollegeId = objXzMajorEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeId + "'");
 }
 
 if (objXzMajorEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.OrderNum);
 arrValueListForInsert.Add(objXzMajorEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conXzMajor.InUse);
 arrValueListForInsert.Add("'" + (objXzMajorEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.UpdDate);
 var strUpdDate = objXzMajorEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzMajorEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.UpdUser);
 var strUpdUser = objXzMajorEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzMajor");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objXzMajorEN.IdMajor;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsXzMajorEN objXzMajorEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzMajorEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzMajorEN.IdMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.IdMajor);
 var strIdMajor = objXzMajorEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMajor + "'");
 }
 
 if (objXzMajorEN.MajorID !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.MajorID);
 var strMajorID = objXzMajorEN.MajorID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorID + "'");
 }
 
 if (objXzMajorEN.MajorName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.MajorName);
 var strMajorName = objXzMajorEN.MajorName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorName + "'");
 }
 
 arrFieldListForInsert.Add(conXzMajor.IsMainMajor);
 arrValueListForInsert.Add("'" + (objXzMajorEN.IsMainMajor  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.CollegeId);
 var strCollegeId = objXzMajorEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeId + "'");
 }
 
 if (objXzMajorEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.OrderNum);
 arrValueListForInsert.Add(objXzMajorEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conXzMajor.InUse);
 arrValueListForInsert.Add("'" + (objXzMajorEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.UpdDate);
 var strUpdDate = objXzMajorEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzMajorEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.UpdUser);
 var strUpdUser = objXzMajorEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzMajor");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objXzMajorEN.IdMajor;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsXzMajorEN objXzMajorEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objXzMajorEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objXzMajorEN.IdMajor !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.IdMajor);
 var strIdMajor = objXzMajorEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMajor + "'");
 }
 
 if (objXzMajorEN.MajorID !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.MajorID);
 var strMajorID = objXzMajorEN.MajorID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorID + "'");
 }
 
 if (objXzMajorEN.MajorName !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.MajorName);
 var strMajorName = objXzMajorEN.MajorName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMajorName + "'");
 }
 
 arrFieldListForInsert.Add(conXzMajor.IsMainMajor);
 arrValueListForInsert.Add("'" + (objXzMajorEN.IsMainMajor  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorEN.CollegeId !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.CollegeId);
 var strCollegeId = objXzMajorEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCollegeId + "'");
 }
 
 if (objXzMajorEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.OrderNum);
 arrValueListForInsert.Add(objXzMajorEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conXzMajor.InUse);
 arrValueListForInsert.Add("'" + (objXzMajorEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objXzMajorEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.UpdDate);
 var strUpdDate = objXzMajorEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objXzMajorEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conXzMajor.UpdUser);
 var strUpdUser = objXzMajorEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into XzMajor");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewXzMajors(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from XzMajor where IdMajor = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "XzMajor");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdMajor = oRow[conXzMajor.IdMajor].ToString().Trim();
if (IsExist(strIdMajor))
{
 string strResult = "关键字变量值为:" + string.Format("IdMajor = {0}", strIdMajor) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsXzMajorEN._CurrTabName ].NewRow();
objRow[conXzMajor.IdMajor] = oRow[conXzMajor.IdMajor].ToString().Trim(); //专业流水号
objRow[conXzMajor.MajorID] = oRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objRow[conXzMajor.MajorName] = oRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objRow[conXzMajor.IsMainMajor] = oRow[conXzMajor.IsMainMajor].ToString().Trim(); //是否重要专业
objRow[conXzMajor.CollegeId] = oRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objRow[conXzMajor.OrderNum] = oRow[conXzMajor.OrderNum].ToString().Trim(); //序号
objRow[conXzMajor.InUse] = oRow[conXzMajor.InUse].ToString().Trim(); //是否在用
objRow[conXzMajor.UpdDate] = oRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objRow[conXzMajor.UpdUser] = oRow[conXzMajor.UpdUser].ToString().Trim(); //修改者
 objDS.Tables[clsXzMajorEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsXzMajorEN._CurrTabName);
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
 /// <param name = "objXzMajorEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsXzMajorEN objXzMajorEN)
{
 objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzMajorEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
strSQL = "Select * from XzMajor where IdMajor = " + "'"+ objXzMajorEN.IdMajor+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsXzMajorEN._CurrTabName);
if (objDS.Tables[clsXzMajorEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdMajor = " + "'"+ objXzMajorEN.IdMajor+"'");
return false;
}
objRow = objDS.Tables[clsXzMajorEN._CurrTabName].Rows[0];
 if (objXzMajorEN.IsUpdated(conXzMajor.IdMajor))
 {
objRow[conXzMajor.IdMajor] = objXzMajorEN.IdMajor; //专业流水号
 }
 if (objXzMajorEN.IsUpdated(conXzMajor.MajorID))
 {
objRow[conXzMajor.MajorID] = objXzMajorEN.MajorID; //MajorID
 }
 if (objXzMajorEN.IsUpdated(conXzMajor.MajorName))
 {
objRow[conXzMajor.MajorName] = objXzMajorEN.MajorName; //专业名称
 }
 if (objXzMajorEN.IsUpdated(conXzMajor.IsMainMajor))
 {
objRow[conXzMajor.IsMainMajor] = objXzMajorEN.IsMainMajor; //是否重要专业
 }
 if (objXzMajorEN.IsUpdated(conXzMajor.CollegeId))
 {
objRow[conXzMajor.CollegeId] = objXzMajorEN.CollegeId; //学院Id
 }
 if (objXzMajorEN.IsUpdated(conXzMajor.OrderNum))
 {
objRow[conXzMajor.OrderNum] = objXzMajorEN.OrderNum; //序号
 }
 if (objXzMajorEN.IsUpdated(conXzMajor.InUse))
 {
objRow[conXzMajor.InUse] = objXzMajorEN.InUse; //是否在用
 }
 if (objXzMajorEN.IsUpdated(conXzMajor.UpdDate))
 {
objRow[conXzMajor.UpdDate] = objXzMajorEN.UpdDate; //修改日期
 }
 if (objXzMajorEN.IsUpdated(conXzMajor.UpdUser))
 {
objRow[conXzMajor.UpdUser] = objXzMajorEN.UpdUser; //修改者
 }
try
{
objDA.Update(objDS, clsXzMajorEN._CurrTabName);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzMajorEN objXzMajorEN)
{
 objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzMajorEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update XzMajor Set ");
 
 if (objXzMajorEN.IsUpdated(conXzMajor.MajorID))
 {
 if (objXzMajorEN.MajorID !=  null)
 {
 var strMajorID = objXzMajorEN.MajorID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajorID, conXzMajor.MajorID); //MajorID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.MajorID); //MajorID
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.MajorName))
 {
 if (objXzMajorEN.MajorName !=  null)
 {
 var strMajorName = objXzMajorEN.MajorName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajorName, conXzMajor.MajorName); //专业名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.MajorName); //专业名称
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.IsMainMajor))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzMajorEN.IsMainMajor == true?"1":"0", conXzMajor.IsMainMajor); //是否重要专业
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.CollegeId))
 {
 if (objXzMajorEN.CollegeId !=  null)
 {
 var strCollegeId = objXzMajorEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCollegeId, conXzMajor.CollegeId); //学院Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.CollegeId); //学院Id
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.OrderNum))
 {
 if (objXzMajorEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzMajorEN.OrderNum, conXzMajor.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.OrderNum); //序号
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzMajorEN.InUse == true?"1":"0", conXzMajor.InUse); //是否在用
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.UpdDate))
 {
 if (objXzMajorEN.UpdDate !=  null)
 {
 var strUpdDate = objXzMajorEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conXzMajor.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.UpdDate); //修改日期
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.UpdUser))
 {
 if (objXzMajorEN.UpdUser !=  null)
 {
 var strUpdUser = objXzMajorEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conXzMajor.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.UpdUser); //修改者
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdMajor = '{0}'", objXzMajorEN.IdMajor); 
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
 /// <param name = "objXzMajorEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsXzMajorEN objXzMajorEN, string strCondition)
{
 objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzMajorEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzMajor Set ");
 
 if (objXzMajorEN.IsUpdated(conXzMajor.MajorID))
 {
 if (objXzMajorEN.MajorID !=  null)
 {
 var strMajorID = objXzMajorEN.MajorID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MajorID = '{0}',", strMajorID); //MajorID
 }
 else
 {
 sbSQL.Append(" MajorID = null,"); //MajorID
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.MajorName))
 {
 if (objXzMajorEN.MajorName !=  null)
 {
 var strMajorName = objXzMajorEN.MajorName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MajorName = '{0}',", strMajorName); //专业名称
 }
 else
 {
 sbSQL.Append(" MajorName = null,"); //专业名称
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.IsMainMajor))
 {
 sbSQL.AppendFormat(" IsMainMajor = '{0}',", objXzMajorEN.IsMainMajor == true?"1":"0"); //是否重要专业
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.CollegeId))
 {
 if (objXzMajorEN.CollegeId !=  null)
 {
 var strCollegeId = objXzMajorEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeId = '{0}',", strCollegeId); //学院Id
 }
 else
 {
 sbSQL.Append(" CollegeId = null,"); //学院Id
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.OrderNum))
 {
 if (objXzMajorEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzMajorEN.OrderNum, conXzMajor.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.OrderNum); //序号
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objXzMajorEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.UpdDate))
 {
 if (objXzMajorEN.UpdDate !=  null)
 {
 var strUpdDate = objXzMajorEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.UpdUser))
 {
 if (objXzMajorEN.UpdUser !=  null)
 {
 var strUpdUser = objXzMajorEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzMajorEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsXzMajorEN objXzMajorEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzMajorEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzMajor Set ");
 
 if (objXzMajorEN.IsUpdated(conXzMajor.MajorID))
 {
 if (objXzMajorEN.MajorID !=  null)
 {
 var strMajorID = objXzMajorEN.MajorID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MajorID = '{0}',", strMajorID); //MajorID
 }
 else
 {
 sbSQL.Append(" MajorID = null,"); //MajorID
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.MajorName))
 {
 if (objXzMajorEN.MajorName !=  null)
 {
 var strMajorName = objXzMajorEN.MajorName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MajorName = '{0}',", strMajorName); //专业名称
 }
 else
 {
 sbSQL.Append(" MajorName = null,"); //专业名称
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.IsMainMajor))
 {
 sbSQL.AppendFormat(" IsMainMajor = '{0}',", objXzMajorEN.IsMainMajor == true?"1":"0"); //是否重要专业
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.CollegeId))
 {
 if (objXzMajorEN.CollegeId !=  null)
 {
 var strCollegeId = objXzMajorEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CollegeId = '{0}',", strCollegeId); //学院Id
 }
 else
 {
 sbSQL.Append(" CollegeId = null,"); //学院Id
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.OrderNum))
 {
 if (objXzMajorEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzMajorEN.OrderNum, conXzMajor.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.OrderNum); //序号
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objXzMajorEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.UpdDate))
 {
 if (objXzMajorEN.UpdDate !=  null)
 {
 var strUpdDate = objXzMajorEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.UpdUser))
 {
 if (objXzMajorEN.UpdUser !=  null)
 {
 var strUpdUser = objXzMajorEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsXzMajorEN objXzMajorEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objXzMajorEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objXzMajorEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update XzMajor Set ");
 
 if (objXzMajorEN.IsUpdated(conXzMajor.MajorID))
 {
 if (objXzMajorEN.MajorID !=  null)
 {
 var strMajorID = objXzMajorEN.MajorID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajorID, conXzMajor.MajorID); //MajorID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.MajorID); //MajorID
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.MajorName))
 {
 if (objXzMajorEN.MajorName !=  null)
 {
 var strMajorName = objXzMajorEN.MajorName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMajorName, conXzMajor.MajorName); //专业名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.MajorName); //专业名称
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.IsMainMajor))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzMajorEN.IsMainMajor == true?"1":"0", conXzMajor.IsMainMajor); //是否重要专业
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.CollegeId))
 {
 if (objXzMajorEN.CollegeId !=  null)
 {
 var strCollegeId = objXzMajorEN.CollegeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCollegeId, conXzMajor.CollegeId); //学院Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.CollegeId); //学院Id
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.OrderNum))
 {
 if (objXzMajorEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objXzMajorEN.OrderNum, conXzMajor.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.OrderNum); //序号
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objXzMajorEN.InUse == true?"1":"0", conXzMajor.InUse); //是否在用
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.UpdDate))
 {
 if (objXzMajorEN.UpdDate !=  null)
 {
 var strUpdDate = objXzMajorEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conXzMajor.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.UpdDate); //修改日期
 }
 }
 
 if (objXzMajorEN.IsUpdated(conXzMajor.UpdUser))
 {
 if (objXzMajorEN.UpdUser !=  null)
 {
 var strUpdUser = objXzMajorEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conXzMajor.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conXzMajor.UpdUser); //修改者
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdMajor = '{0}'", objXzMajorEN.IdMajor); 
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
 /// <param name = "strIdMajor">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdMajor) 
{
CheckPrimaryKey(strIdMajor);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdMajor,
};
 objSQL.ExecSP("XzMajor_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdMajor">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdMajor, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdMajor);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
//删除XzMajor本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzMajor where IdMajor = " + "'"+ strIdMajor+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelXzMajor(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
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
//删除XzMajor本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzMajor where IdMajor in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdMajor">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdMajor) 
{
CheckPrimaryKey(strIdMajor);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
//删除XzMajor本表中与当前对象有关的记录
strSQL = strSQL + "Delete from XzMajor where IdMajor = " + "'"+ strIdMajor+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelXzMajor(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsXzMajorDA: DelXzMajor)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzMajor where " + strCondition ;
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
public bool DelXzMajorWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsXzMajorDA: DelXzMajorWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsXzMajorDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from XzMajor where " + strCondition ;
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
 /// <param name = "objXzMajorENS">源对象</param>
 /// <param name = "objXzMajorENT">目标对象</param>
public void CopyTo(clsXzMajorEN objXzMajorENS, clsXzMajorEN objXzMajorENT)
{
objXzMajorENT.IdMajor = objXzMajorENS.IdMajor; //专业流水号
objXzMajorENT.MajorID = objXzMajorENS.MajorID; //MajorID
objXzMajorENT.MajorName = objXzMajorENS.MajorName; //专业名称
objXzMajorENT.IsMainMajor = objXzMajorENS.IsMainMajor; //是否重要专业
objXzMajorENT.CollegeId = objXzMajorENS.CollegeId; //学院Id
objXzMajorENT.OrderNum = objXzMajorENS.OrderNum; //序号
objXzMajorENT.InUse = objXzMajorENS.InUse; //是否在用
objXzMajorENT.UpdDate = objXzMajorENS.UpdDate; //修改日期
objXzMajorENT.UpdUser = objXzMajorENS.UpdUser; //修改者
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsXzMajorEN objXzMajorEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objXzMajorEN.MajorID, conXzMajor.MajorID);
clsCheckSql.CheckFieldNotNull(objXzMajorEN.CollegeId, conXzMajor.CollegeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objXzMajorEN.IdMajor, 8, conXzMajor.IdMajor);
clsCheckSql.CheckFieldLen(objXzMajorEN.MajorID, 4, conXzMajor.MajorID);
clsCheckSql.CheckFieldLen(objXzMajorEN.MajorName, 100, conXzMajor.MajorName);
clsCheckSql.CheckFieldLen(objXzMajorEN.CollegeId, 6, conXzMajor.CollegeId);
clsCheckSql.CheckFieldLen(objXzMajorEN.UpdDate, 20, conXzMajor.UpdDate);
clsCheckSql.CheckFieldLen(objXzMajorEN.UpdUser, 20, conXzMajor.UpdUser);
//检查字段外键固定长度
 objXzMajorEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsXzMajorEN objXzMajorEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzMajorEN.MajorID, 4, conXzMajor.MajorID);
clsCheckSql.CheckFieldLen(objXzMajorEN.MajorName, 100, conXzMajor.MajorName);
clsCheckSql.CheckFieldLen(objXzMajorEN.CollegeId, 6, conXzMajor.CollegeId);
clsCheckSql.CheckFieldLen(objXzMajorEN.UpdDate, 20, conXzMajor.UpdDate);
clsCheckSql.CheckFieldLen(objXzMajorEN.UpdUser, 20, conXzMajor.UpdUser);
//检查外键字段长度
 objXzMajorEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsXzMajorEN objXzMajorEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objXzMajorEN.IdMajor, 8, conXzMajor.IdMajor);
clsCheckSql.CheckFieldLen(objXzMajorEN.MajorID, 4, conXzMajor.MajorID);
clsCheckSql.CheckFieldLen(objXzMajorEN.MajorName, 100, conXzMajor.MajorName);
clsCheckSql.CheckFieldLen(objXzMajorEN.CollegeId, 6, conXzMajor.CollegeId);
clsCheckSql.CheckFieldLen(objXzMajorEN.UpdDate, 20, conXzMajor.UpdDate);
clsCheckSql.CheckFieldLen(objXzMajorEN.UpdUser, 20, conXzMajor.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objXzMajorEN.IdMajor, conXzMajor.IdMajor);
clsCheckSql.CheckSqlInjection4Field(objXzMajorEN.MajorID, conXzMajor.MajorID);
clsCheckSql.CheckSqlInjection4Field(objXzMajorEN.MajorName, conXzMajor.MajorName);
clsCheckSql.CheckSqlInjection4Field(objXzMajorEN.CollegeId, conXzMajor.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objXzMajorEN.UpdDate, conXzMajor.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objXzMajorEN.UpdUser, conXzMajor.UpdUser);
//检查外键字段长度
 objXzMajorEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdMajor()
{
//获取某学院所有专业信息
string strSQL = "select IdMajor, MajorName from XzMajor ";
 clsSpecSQLforSql mySql = clsXzMajorDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--XzMajor(专业),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzMajorEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsXzMajorEN objXzMajorEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CollegeId = '{0}'", objXzMajorEN.CollegeId);
 if (objXzMajorEN.MajorName == null)
{
 sbCondition.AppendFormat(" and MajorName is null");
}
else
{
 sbCondition.AppendFormat(" and MajorName = '{0}'", objXzMajorEN.MajorName);
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
 objSQL = clsXzMajorDA.GetSpecSQLObj();
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
 objSQL = clsXzMajorDA.GetSpecSQLObj();
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
 objSQL = clsXzMajorDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzMajorEN._CurrTabName);
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
 objSQL = clsXzMajorDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsXzMajorEN._CurrTabName, strCondition);
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
 objSQL = clsXzMajorDA.GetSpecSQLObj();
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
 objSQL = clsXzMajorDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}