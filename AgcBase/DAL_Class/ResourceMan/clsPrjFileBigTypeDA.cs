
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFileBigTypeDA
 表名:PrjFileBigType(00050650)
 * 版本:2026.05.30(服务器:WIN-SRV103-116)
 日期:2026/06/17 11:29:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:资源管理(ResourceMan)
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
 /// 工程文件主类型(PrjFileBigType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjFileBigTypeDA : clsCommBase4DA
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
 return clsPrjFileBigTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjFileBigTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjFileBigTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjFileBigTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjFileBigTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPrjFileBigTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPrjFileBigTypeId)
{
strPrjFileBigTypeId = strPrjFileBigTypeId.Replace("'", "''");
if (strPrjFileBigTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:PrjFileBigType中,检查关键字,长度不正确!(clsPrjFileBigTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjFileBigTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PrjFileBigType中,关键字不能为空 或 null!(clsPrjFileBigTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjFileBigTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPrjFileBigTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrjFileBigType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjFileBigType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: GetDataTable_PrjFileBigType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrjFileBigType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrjFileBigType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFileBigType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFileBigType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjFileBigType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjFileBigType.* " + 
$"from PrjFileBigType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjFileBigType.PrjFileBigTypeId not in " + 
$"(Select top {intTop_In} PrjFileBigType.PrjFileBigTypeId from PrjFileBigType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFileBigType where {1} and PrjFileBigTypeId not in (Select top {2} PrjFileBigTypeId from PrjFileBigType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFileBigType where {1} and PrjFileBigTypeId not in (Select top {3} PrjFileBigTypeId from PrjFileBigType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjFileBigType.* " + 
$"from PrjFileBigType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjFileBigType.PrjFileBigTypeId not in " + 
$"(Select top {intTop_In} PrjFileBigType.PrjFileBigTypeId from PrjFileBigType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFileBigType where {1} and PrjFileBigTypeId not in (Select top {2} PrjFileBigTypeId from PrjFileBigType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFileBigType where {1} and PrjFileBigTypeId not in (Select top {3} PrjFileBigTypeId from PrjFileBigType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjFileBigTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA:GetObjLst)", objException.Message));
}
List<clsPrjFileBigTypeEN> arrObjLst = new List<clsPrjFileBigTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrjFileBigType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileBigTypeEN objPrjFileBigTypeEN = new clsPrjFileBigTypeEN();
try
{
objPrjFileBigTypeEN.PrjFileBigTypeId = objRow[conPrjFileBigType.PrjFileBigTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileBigTypeEN.PrjFileBigTypeName = objRow[conPrjFileBigType.PrjFileBigTypeName].ToString().Trim(); //工程文件类型名
objPrjFileBigTypeEN.InUse = TransNullToBool(objRow[conPrjFileBigType.InUse].ToString().Trim()); //是否在用
objPrjFileBigTypeEN.UpdDate = objRow[conPrjFileBigType.UpdDate].ToString().Trim(); //修改日期
objPrjFileBigTypeEN.UpdUserId = objRow[conPrjFileBigType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileBigTypeEN.Memo = objRow[conPrjFileBigType.Memo] == DBNull.Value ? null : objRow[conPrjFileBigType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjFileBigTypeDA: GetObjLst)", objException.Message));
}
objPrjFileBigTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjFileBigTypeEN);
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
public List<clsPrjFileBigTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjFileBigTypeEN> arrObjLst = new List<clsPrjFileBigTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileBigTypeEN objPrjFileBigTypeEN = new clsPrjFileBigTypeEN();
try
{
objPrjFileBigTypeEN.PrjFileBigTypeId = objRow[conPrjFileBigType.PrjFileBigTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileBigTypeEN.PrjFileBigTypeName = objRow[conPrjFileBigType.PrjFileBigTypeName].ToString().Trim(); //工程文件类型名
objPrjFileBigTypeEN.InUse = TransNullToBool(objRow[conPrjFileBigType.InUse].ToString().Trim()); //是否在用
objPrjFileBigTypeEN.UpdDate = objRow[conPrjFileBigType.UpdDate].ToString().Trim(); //修改日期
objPrjFileBigTypeEN.UpdUserId = objRow[conPrjFileBigType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileBigTypeEN.Memo = objRow[conPrjFileBigType.Memo] == DBNull.Value ? null : objRow[conPrjFileBigType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjFileBigTypeDA: GetObjLst)", objException.Message));
}
objPrjFileBigTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjFileBigTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjFileBigTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjFileBigType(ref clsPrjFileBigTypeEN objPrjFileBigTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrjFileBigType where PrjFileBigTypeId = " + "'"+ objPrjFileBigTypeEN.PrjFileBigTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjFileBigTypeEN.PrjFileBigTypeId = objDT.Rows[0][conPrjFileBigType.PrjFileBigTypeId].ToString().Trim(); //项目文件类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPrjFileBigTypeEN.PrjFileBigTypeName = objDT.Rows[0][conPrjFileBigType.PrjFileBigTypeName].ToString().Trim(); //工程文件类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjFileBigTypeEN.InUse = TransNullToBool(objDT.Rows[0][conPrjFileBigType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objPrjFileBigTypeEN.UpdDate = objDT.Rows[0][conPrjFileBigType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFileBigTypeEN.UpdUserId = objDT.Rows[0][conPrjFileBigType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFileBigTypeEN.Memo = objDT.Rows[0][conPrjFileBigType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjFileBigTypeDA: GetPrjFileBigType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjFileBigTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjFileBigTypeEN GetObjByPrjFileBigTypeId(string strPrjFileBigTypeId)
{
CheckPrimaryKey(strPrjFileBigTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrjFileBigType where PrjFileBigTypeId = " + "'"+ strPrjFileBigTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjFileBigTypeEN objPrjFileBigTypeEN = new clsPrjFileBigTypeEN();
try
{
 objPrjFileBigTypeEN.PrjFileBigTypeId = objRow[conPrjFileBigType.PrjFileBigTypeId].ToString().Trim(); //项目文件类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPrjFileBigTypeEN.PrjFileBigTypeName = objRow[conPrjFileBigType.PrjFileBigTypeName].ToString().Trim(); //工程文件类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjFileBigTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileBigType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objPrjFileBigTypeEN.UpdDate = objRow[conPrjFileBigType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFileBigTypeEN.UpdUserId = objRow[conPrjFileBigType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFileBigTypeEN.Memo = objRow[conPrjFileBigType.Memo] == DBNull.Value ? null : objRow[conPrjFileBigType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjFileBigTypeDA: GetObjByPrjFileBigTypeId)", objException.Message));
}
return objPrjFileBigTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjFileBigTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrjFileBigType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjFileBigTypeEN objPrjFileBigTypeEN = new clsPrjFileBigTypeEN()
{
PrjFileBigTypeId = objRow[conPrjFileBigType.PrjFileBigTypeId].ToString().Trim(), //项目文件类型Id
PrjFileBigTypeName = objRow[conPrjFileBigType.PrjFileBigTypeName].ToString().Trim(), //工程文件类型名
InUse = TransNullToBool(objRow[conPrjFileBigType.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[conPrjFileBigType.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conPrjFileBigType.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conPrjFileBigType.Memo] == DBNull.Value ? null : objRow[conPrjFileBigType.Memo].ToString().Trim() //说明
};
objPrjFileBigTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFileBigTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjFileBigTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjFileBigTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjFileBigTypeEN objPrjFileBigTypeEN = new clsPrjFileBigTypeEN();
try
{
objPrjFileBigTypeEN.PrjFileBigTypeId = objRow[conPrjFileBigType.PrjFileBigTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileBigTypeEN.PrjFileBigTypeName = objRow[conPrjFileBigType.PrjFileBigTypeName].ToString().Trim(); //工程文件类型名
objPrjFileBigTypeEN.InUse = TransNullToBool(objRow[conPrjFileBigType.InUse].ToString().Trim()); //是否在用
objPrjFileBigTypeEN.UpdDate = objRow[conPrjFileBigType.UpdDate].ToString().Trim(); //修改日期
objPrjFileBigTypeEN.UpdUserId = objRow[conPrjFileBigType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileBigTypeEN.Memo = objRow[conPrjFileBigType.Memo] == DBNull.Value ? null : objRow[conPrjFileBigType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjFileBigTypeDA: GetObjByDataRowPrjFileBigType)", objException.Message));
}
objPrjFileBigTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFileBigTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjFileBigTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjFileBigTypeEN objPrjFileBigTypeEN = new clsPrjFileBigTypeEN();
try
{
objPrjFileBigTypeEN.PrjFileBigTypeId = objRow[conPrjFileBigType.PrjFileBigTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileBigTypeEN.PrjFileBigTypeName = objRow[conPrjFileBigType.PrjFileBigTypeName].ToString().Trim(); //工程文件类型名
objPrjFileBigTypeEN.InUse = TransNullToBool(objRow[conPrjFileBigType.InUse].ToString().Trim()); //是否在用
objPrjFileBigTypeEN.UpdDate = objRow[conPrjFileBigType.UpdDate].ToString().Trim(); //修改日期
objPrjFileBigTypeEN.UpdUserId = objRow[conPrjFileBigType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileBigTypeEN.Memo = objRow[conPrjFileBigType.Memo] == DBNull.Value ? null : objRow[conPrjFileBigType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjFileBigTypeDA: GetObjByDataRow)", objException.Message));
}
objPrjFileBigTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFileBigTypeEN;
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
objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjFileBigTypeEN._CurrTabName, conPrjFileBigType.PrjFileBigTypeId, 2, "");
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
objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjFileBigTypeEN._CurrTabName, conPrjFileBigType.PrjFileBigTypeId, 2, strPrefix);
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
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PrjFileBigTypeId from PrjFileBigType where " + strCondition;
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
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PrjFileBigTypeId from PrjFileBigType where " + strCondition;
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
 /// <param name = "strPrjFileBigTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPrjFileBigTypeId)
{
CheckPrimaryKey(strPrjFileBigTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjFileBigType", "PrjFileBigTypeId = " + "'"+ strPrjFileBigTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjFileBigType", strCondition))
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
objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjFileBigType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjFileBigTypeEN objPrjFileBigTypeEN)
 {
 objPrjFileBigTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFileBigTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFileBigTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrjFileBigType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjFileBigType");
objRow = objDS.Tables["PrjFileBigType"].NewRow();
objRow[conPrjFileBigType.PrjFileBigTypeId] = objPrjFileBigTypeEN.PrjFileBigTypeId; //项目文件类型Id
objRow[conPrjFileBigType.PrjFileBigTypeName] = objPrjFileBigTypeEN.PrjFileBigTypeName; //工程文件类型名
objRow[conPrjFileBigType.InUse] = objPrjFileBigTypeEN.InUse; //是否在用
objRow[conPrjFileBigType.UpdDate] = objPrjFileBigTypeEN.UpdDate; //修改日期
objRow[conPrjFileBigType.UpdUserId] = objPrjFileBigTypeEN.UpdUserId; //修改用户Id
 if (objPrjFileBigTypeEN.Memo !=  "")
 {
objRow[conPrjFileBigType.Memo] = objPrjFileBigTypeEN.Memo; //说明
 }
objDS.Tables[clsPrjFileBigTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjFileBigTypeEN._CurrTabName);
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
 /// <param name = "objPrjFileBigTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjFileBigTypeEN objPrjFileBigTypeEN)
{
 objPrjFileBigTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFileBigTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFileBigTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFileBigTypeEN.PrjFileBigTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.PrjFileBigTypeId);
 var strPrjFileBigTypeId = objPrjFileBigTypeEN.PrjFileBigTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileBigTypeId + "'");
 }
 
 if (objPrjFileBigTypeEN.PrjFileBigTypeName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.PrjFileBigTypeName);
 var strPrjFileBigTypeName = objPrjFileBigTypeEN.PrjFileBigTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileBigTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFileBigType.InUse);
 arrValueListForInsert.Add("'" + (objPrjFileBigTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objPrjFileBigTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.UpdDate);
 var strUpdDate = objPrjFileBigTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFileBigTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.UpdUserId);
 var strUpdUserId = objPrjFileBigTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjFileBigTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.Memo);
 var strMemo = objPrjFileBigTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFileBigType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjFileBigTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjFileBigTypeEN objPrjFileBigTypeEN)
{
 objPrjFileBigTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFileBigTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFileBigTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFileBigTypeEN.PrjFileBigTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.PrjFileBigTypeId);
 var strPrjFileBigTypeId = objPrjFileBigTypeEN.PrjFileBigTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileBigTypeId + "'");
 }
 
 if (objPrjFileBigTypeEN.PrjFileBigTypeName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.PrjFileBigTypeName);
 var strPrjFileBigTypeName = objPrjFileBigTypeEN.PrjFileBigTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileBigTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFileBigType.InUse);
 arrValueListForInsert.Add("'" + (objPrjFileBigTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objPrjFileBigTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.UpdDate);
 var strUpdDate = objPrjFileBigTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFileBigTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.UpdUserId);
 var strUpdUserId = objPrjFileBigTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjFileBigTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.Memo);
 var strMemo = objPrjFileBigTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFileBigType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPrjFileBigTypeEN.PrjFileBigTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPrjFileBigTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjFileBigTypeEN objPrjFileBigTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjFileBigTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFileBigTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFileBigTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFileBigTypeEN.PrjFileBigTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.PrjFileBigTypeId);
 var strPrjFileBigTypeId = objPrjFileBigTypeEN.PrjFileBigTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileBigTypeId + "'");
 }
 
 if (objPrjFileBigTypeEN.PrjFileBigTypeName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.PrjFileBigTypeName);
 var strPrjFileBigTypeName = objPrjFileBigTypeEN.PrjFileBigTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileBigTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFileBigType.InUse);
 arrValueListForInsert.Add("'" + (objPrjFileBigTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objPrjFileBigTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.UpdDate);
 var strUpdDate = objPrjFileBigTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFileBigTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.UpdUserId);
 var strUpdUserId = objPrjFileBigTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjFileBigTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.Memo);
 var strMemo = objPrjFileBigTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFileBigType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPrjFileBigTypeEN.PrjFileBigTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjFileBigTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjFileBigTypeEN objPrjFileBigTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjFileBigTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFileBigTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFileBigTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjFileBigTypeEN.PrjFileBigTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.PrjFileBigTypeId);
 var strPrjFileBigTypeId = objPrjFileBigTypeEN.PrjFileBigTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileBigTypeId + "'");
 }
 
 if (objPrjFileBigTypeEN.PrjFileBigTypeName !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.PrjFileBigTypeName);
 var strPrjFileBigTypeName = objPrjFileBigTypeEN.PrjFileBigTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjFileBigTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conPrjFileBigType.InUse);
 arrValueListForInsert.Add("'" + (objPrjFileBigTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objPrjFileBigTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.UpdDate);
 var strUpdDate = objPrjFileBigTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFileBigTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.UpdUserId);
 var strUpdUserId = objPrjFileBigTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjFileBigTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFileBigType.Memo);
 var strMemo = objPrjFileBigTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFileBigType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjFileBigTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrjFileBigType where PrjFileBigTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjFileBigType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPrjFileBigTypeId = oRow[conPrjFileBigType.PrjFileBigTypeId].ToString().Trim();
if (IsExist(strPrjFileBigTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("PrjFileBigTypeId = {0}", strPrjFileBigTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjFileBigTypeEN._CurrTabName ].NewRow();
objRow[conPrjFileBigType.PrjFileBigTypeId] = oRow[conPrjFileBigType.PrjFileBigTypeId].ToString().Trim(); //项目文件类型Id
objRow[conPrjFileBigType.PrjFileBigTypeName] = oRow[conPrjFileBigType.PrjFileBigTypeName].ToString().Trim(); //工程文件类型名
objRow[conPrjFileBigType.InUse] = oRow[conPrjFileBigType.InUse].ToString().Trim(); //是否在用
objRow[conPrjFileBigType.UpdDate] = oRow[conPrjFileBigType.UpdDate].ToString().Trim(); //修改日期
objRow[conPrjFileBigType.UpdUserId] = oRow[conPrjFileBigType.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conPrjFileBigType.Memo] = oRow[conPrjFileBigType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsPrjFileBigTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjFileBigTypeEN._CurrTabName);
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
 /// <param name = "objPrjFileBigTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjFileBigTypeEN objPrjFileBigTypeEN)
{
 objPrjFileBigTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFileBigTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFileBigTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
strSQL = "Select * from PrjFileBigType where PrjFileBigTypeId = " + "'"+ objPrjFileBigTypeEN.PrjFileBigTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjFileBigTypeEN._CurrTabName);
if (objDS.Tables[clsPrjFileBigTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PrjFileBigTypeId = " + "'"+ objPrjFileBigTypeEN.PrjFileBigTypeId+"'");
return false;
}
objRow = objDS.Tables[clsPrjFileBigTypeEN._CurrTabName].Rows[0];
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.PrjFileBigTypeId))
 {
objRow[conPrjFileBigType.PrjFileBigTypeId] = objPrjFileBigTypeEN.PrjFileBigTypeId; //项目文件类型Id
 }
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.PrjFileBigTypeName))
 {
objRow[conPrjFileBigType.PrjFileBigTypeName] = objPrjFileBigTypeEN.PrjFileBigTypeName; //工程文件类型名
 }
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.InUse))
 {
objRow[conPrjFileBigType.InUse] = objPrjFileBigTypeEN.InUse; //是否在用
 }
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.UpdDate))
 {
objRow[conPrjFileBigType.UpdDate] = objPrjFileBigTypeEN.UpdDate; //修改日期
 }
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.UpdUserId))
 {
objRow[conPrjFileBigType.UpdUserId] = objPrjFileBigTypeEN.UpdUserId; //修改用户Id
 }
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.Memo))
 {
objRow[conPrjFileBigType.Memo] = objPrjFileBigTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsPrjFileBigTypeEN._CurrTabName);
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
 /// <param name = "objPrjFileBigTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjFileBigTypeEN objPrjFileBigTypeEN)
{
 objPrjFileBigTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFileBigTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFileBigTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjFileBigType Set ");
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.PrjFileBigTypeName))
 {
 if (objPrjFileBigTypeEN.PrjFileBigTypeName !=  null)
 {
 var strPrjFileBigTypeName = objPrjFileBigTypeEN.PrjFileBigTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjFileBigTypeName, conPrjFileBigType.PrjFileBigTypeName); //工程文件类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFileBigType.PrjFileBigTypeName); //工程文件类型名
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjFileBigTypeEN.InUse == true?"1":"0", conPrjFileBigType.InUse); //是否在用
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.UpdDate))
 {
 if (objPrjFileBigTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFileBigTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjFileBigType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFileBigType.UpdDate); //修改日期
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.UpdUserId))
 {
 if (objPrjFileBigTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjFileBigTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conPrjFileBigType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFileBigType.UpdUserId); //修改用户Id
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.Memo))
 {
 if (objPrjFileBigTypeEN.Memo !=  null)
 {
 var strMemo = objPrjFileBigTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjFileBigType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFileBigType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrjFileBigTypeId = '{0}'", objPrjFileBigTypeEN.PrjFileBigTypeId); 
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
 /// <param name = "objPrjFileBigTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjFileBigTypeEN objPrjFileBigTypeEN, string strCondition)
{
 objPrjFileBigTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFileBigTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFileBigTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFileBigType Set ");
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.PrjFileBigTypeName))
 {
 if (objPrjFileBigTypeEN.PrjFileBigTypeName !=  null)
 {
 var strPrjFileBigTypeName = objPrjFileBigTypeEN.PrjFileBigTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjFileBigTypeName = '{0}',", strPrjFileBigTypeName); //工程文件类型名
 }
 else
 {
 sbSQL.Append(" PrjFileBigTypeName = null,"); //工程文件类型名
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objPrjFileBigTypeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.UpdDate))
 {
 if (objPrjFileBigTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFileBigTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.UpdUserId))
 {
 if (objPrjFileBigTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjFileBigTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.Memo))
 {
 if (objPrjFileBigTypeEN.Memo !=  null)
 {
 var strMemo = objPrjFileBigTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjFileBigTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjFileBigTypeEN objPrjFileBigTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjFileBigTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFileBigTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFileBigTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFileBigType Set ");
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.PrjFileBigTypeName))
 {
 if (objPrjFileBigTypeEN.PrjFileBigTypeName !=  null)
 {
 var strPrjFileBigTypeName = objPrjFileBigTypeEN.PrjFileBigTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjFileBigTypeName = '{0}',", strPrjFileBigTypeName); //工程文件类型名
 }
 else
 {
 sbSQL.Append(" PrjFileBigTypeName = null,"); //工程文件类型名
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objPrjFileBigTypeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.UpdDate))
 {
 if (objPrjFileBigTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFileBigTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.UpdUserId))
 {
 if (objPrjFileBigTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjFileBigTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.Memo))
 {
 if (objPrjFileBigTypeEN.Memo !=  null)
 {
 var strMemo = objPrjFileBigTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjFileBigTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjFileBigTypeEN objPrjFileBigTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjFileBigTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFileBigTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFileBigTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFileBigType Set ");
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.PrjFileBigTypeName))
 {
 if (objPrjFileBigTypeEN.PrjFileBigTypeName !=  null)
 {
 var strPrjFileBigTypeName = objPrjFileBigTypeEN.PrjFileBigTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjFileBigTypeName, conPrjFileBigType.PrjFileBigTypeName); //工程文件类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFileBigType.PrjFileBigTypeName); //工程文件类型名
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjFileBigTypeEN.InUse == true?"1":"0", conPrjFileBigType.InUse); //是否在用
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.UpdDate))
 {
 if (objPrjFileBigTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFileBigTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjFileBigType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFileBigType.UpdDate); //修改日期
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.UpdUserId))
 {
 if (objPrjFileBigTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjFileBigTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conPrjFileBigType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFileBigType.UpdUserId); //修改用户Id
 }
 }
 
 if (objPrjFileBigTypeEN.IsUpdated(conPrjFileBigType.Memo))
 {
 if (objPrjFileBigTypeEN.Memo !=  null)
 {
 var strMemo = objPrjFileBigTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjFileBigType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFileBigType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrjFileBigTypeId = '{0}'", objPrjFileBigTypeEN.PrjFileBigTypeId); 
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
 /// <param name = "strPrjFileBigTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPrjFileBigTypeId) 
{
CheckPrimaryKey(strPrjFileBigTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPrjFileBigTypeId,
};
 objSQL.ExecSP("PrjFileBigType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPrjFileBigTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPrjFileBigTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPrjFileBigTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
//删除PrjFileBigType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFileBigType where PrjFileBigTypeId = " + "'"+ strPrjFileBigTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjFileBigType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
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
//删除PrjFileBigType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFileBigType where PrjFileBigTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPrjFileBigTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPrjFileBigTypeId) 
{
CheckPrimaryKey(strPrjFileBigTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
//删除PrjFileBigType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFileBigType where PrjFileBigTypeId = " + "'"+ strPrjFileBigTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjFileBigType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: DelPrjFileBigType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjFileBigType where " + strCondition ;
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
public bool DelPrjFileBigTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjFileBigTypeDA: DelPrjFileBigTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjFileBigType where " + strCondition ;
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
 /// <param name = "objPrjFileBigTypeENS">源对象</param>
 /// <param name = "objPrjFileBigTypeENT">目标对象</param>
public void CopyTo(clsPrjFileBigTypeEN objPrjFileBigTypeENS, clsPrjFileBigTypeEN objPrjFileBigTypeENT)
{
objPrjFileBigTypeENT.PrjFileBigTypeId = objPrjFileBigTypeENS.PrjFileBigTypeId; //项目文件类型Id
objPrjFileBigTypeENT.PrjFileBigTypeName = objPrjFileBigTypeENS.PrjFileBigTypeName; //工程文件类型名
objPrjFileBigTypeENT.InUse = objPrjFileBigTypeENS.InUse; //是否在用
objPrjFileBigTypeENT.UpdDate = objPrjFileBigTypeENS.UpdDate; //修改日期
objPrjFileBigTypeENT.UpdUserId = objPrjFileBigTypeENS.UpdUserId; //修改用户Id
objPrjFileBigTypeENT.Memo = objPrjFileBigTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjFileBigTypeEN objPrjFileBigTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjFileBigTypeEN.PrjFileBigTypeName, conPrjFileBigType.PrjFileBigTypeName);
clsCheckSql.CheckFieldNotNull(objPrjFileBigTypeEN.UpdDate, conPrjFileBigType.UpdDate);
clsCheckSql.CheckFieldNotNull(objPrjFileBigTypeEN.UpdUserId, conPrjFileBigType.UpdUserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.PrjFileBigTypeId, 2, conPrjFileBigType.PrjFileBigTypeId);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.PrjFileBigTypeName, 50, conPrjFileBigType.PrjFileBigTypeName);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.UpdDate, 20, conPrjFileBigType.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.UpdUserId, 20, conPrjFileBigType.UpdUserId);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.Memo, 1000, conPrjFileBigType.Memo);
//检查字段外键固定长度
 objPrjFileBigTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjFileBigTypeEN objPrjFileBigTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.PrjFileBigTypeName, 50, conPrjFileBigType.PrjFileBigTypeName);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.UpdDate, 20, conPrjFileBigType.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.UpdUserId, 20, conPrjFileBigType.UpdUserId);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.Memo, 1000, conPrjFileBigType.Memo);
//检查外键字段长度
 objPrjFileBigTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjFileBigTypeEN objPrjFileBigTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.PrjFileBigTypeId, 2, conPrjFileBigType.PrjFileBigTypeId);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.PrjFileBigTypeName, 50, conPrjFileBigType.PrjFileBigTypeName);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.UpdDate, 20, conPrjFileBigType.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.UpdUserId, 20, conPrjFileBigType.UpdUserId);
clsCheckSql.CheckFieldLen(objPrjFileBigTypeEN.Memo, 1000, conPrjFileBigType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjFileBigTypeEN.PrjFileBigTypeId, conPrjFileBigType.PrjFileBigTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjFileBigTypeEN.PrjFileBigTypeName, conPrjFileBigType.PrjFileBigTypeName);
clsCheckSql.CheckSqlInjection4Field(objPrjFileBigTypeEN.UpdDate, conPrjFileBigType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPrjFileBigTypeEN.UpdUserId, conPrjFileBigType.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objPrjFileBigTypeEN.Memo, conPrjFileBigType.Memo);
//检查外键字段长度
 objPrjFileBigTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPrjFileBigTypeId()
{
//获取某学院所有专业信息
string strSQL = "select PrjFileBigTypeId, PrjFileBigTypeName from PrjFileBigType ";
 clsSpecSQLforSql mySql = clsPrjFileBigTypeDA.GetSpecSQLObj();
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
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
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
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
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
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjFileBigTypeEN._CurrTabName);
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
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjFileBigTypeEN._CurrTabName, strCondition);
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
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
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
 objSQL = clsPrjFileBigTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}