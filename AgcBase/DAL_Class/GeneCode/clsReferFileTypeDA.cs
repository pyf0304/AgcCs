
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsReferFileTypeDA
 表名:ReferFileType(00050473)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:28
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
 /// 引用文件类型(ReferFileType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsReferFileTypeDA : clsCommBase4DA
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
 return clsReferFileTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsReferFileTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsReferFileTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsReferFileTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsReferFileTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strReferFileTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strReferFileTypeId)
{
strReferFileTypeId = strReferFileTypeId.Replace("'", "''");
if (strReferFileTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:ReferFileType中,检查关键字,长度不正确!(clsReferFileTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strReferFileTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ReferFileType中,关键字不能为空 或 null!(clsReferFileTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReferFileTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsReferFileTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsReferFileTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = "Select * from ReferFileType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ReferFileType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsReferFileTypeDA: GetDataTable_ReferFileType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = "Select * from ReferFileType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsReferFileTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsReferFileTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = "Select * from ReferFileType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsReferFileTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsReferFileTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ReferFileType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ReferFileType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsReferFileTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ReferFileType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsReferFileTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ReferFileType.* " + 
$"from ReferFileType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ReferFileType.ReferFileTypeId not in " + 
$"(Select top {intTop_In} ReferFileType.ReferFileTypeId from ReferFileType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ReferFileType where {1} and ReferFileTypeId not in (Select top {2} ReferFileTypeId from ReferFileType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ReferFileType where {1} and ReferFileTypeId not in (Select top {3} ReferFileTypeId from ReferFileType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsReferFileTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ReferFileType.* " + 
$"from ReferFileType " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ReferFileType.ReferFileTypeId not in " + 
$"(Select top {intTop_In} ReferFileType.ReferFileTypeId from ReferFileType " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ReferFileType where {1} and ReferFileTypeId not in (Select top {2} ReferFileTypeId from ReferFileType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ReferFileType where {1} and ReferFileTypeId not in (Select top {3} ReferFileTypeId from ReferFileType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsReferFileTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsReferFileTypeDA:GetObjLst)", objException.Message));
}
List<clsReferFileTypeEN> arrObjLst = new List<clsReferFileTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = "Select * from ReferFileType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFileTypeEN objReferFileTypeEN = new clsReferFileTypeEN();
try
{
objReferFileTypeEN.ReferFileTypeId = objRow[conReferFileType.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFileTypeEN.ReferFileTypeName = objRow[conReferFileType.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objReferFileTypeEN.ReferFileTypeENName = objRow[conReferFileType.ReferFileTypeENName] == DBNull.Value ? null : objRow[conReferFileType.ReferFileTypeENName].ToString().Trim(); //引用文件类型英文名
objReferFileTypeEN.InUse = TransNullToBool(objRow[conReferFileType.InUse].ToString().Trim()); //是否在用
objReferFileTypeEN.OrderNum = TransNullToInt(objRow[conReferFileType.OrderNum].ToString().Trim()); //序号
objReferFileTypeEN.UpdDate = objRow[conReferFileType.UpdDate].ToString().Trim(); //修改日期
objReferFileTypeEN.UpdUserId = objRow[conReferFileType.UpdUserId].ToString().Trim(); //修改用户Id
objReferFileTypeEN.Memo = objRow[conReferFileType.Memo] == DBNull.Value ? null : objRow[conReferFileType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsReferFileTypeDA: GetObjLst)", objException.Message));
}
objReferFileTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objReferFileTypeEN);
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
public List<clsReferFileTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsReferFileTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsReferFileTypeEN> arrObjLst = new List<clsReferFileTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFileTypeEN objReferFileTypeEN = new clsReferFileTypeEN();
try
{
objReferFileTypeEN.ReferFileTypeId = objRow[conReferFileType.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFileTypeEN.ReferFileTypeName = objRow[conReferFileType.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objReferFileTypeEN.ReferFileTypeENName = objRow[conReferFileType.ReferFileTypeENName] == DBNull.Value ? null : objRow[conReferFileType.ReferFileTypeENName].ToString().Trim(); //引用文件类型英文名
objReferFileTypeEN.InUse = TransNullToBool(objRow[conReferFileType.InUse].ToString().Trim()); //是否在用
objReferFileTypeEN.OrderNum = TransNullToInt(objRow[conReferFileType.OrderNum].ToString().Trim()); //序号
objReferFileTypeEN.UpdDate = objRow[conReferFileType.UpdDate].ToString().Trim(); //修改日期
objReferFileTypeEN.UpdUserId = objRow[conReferFileType.UpdUserId].ToString().Trim(); //修改用户Id
objReferFileTypeEN.Memo = objRow[conReferFileType.Memo] == DBNull.Value ? null : objRow[conReferFileType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsReferFileTypeDA: GetObjLst)", objException.Message));
}
objReferFileTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objReferFileTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objReferFileTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetReferFileType(ref clsReferFileTypeEN objReferFileTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = "Select * from ReferFileType where ReferFileTypeId = " + "'"+ objReferFileTypeEN.ReferFileTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objReferFileTypeEN.ReferFileTypeId = objDT.Rows[0][conReferFileType.ReferFileTypeId].ToString().Trim(); //引用文件类型Id(字段类型:char,字段长度:2,是否可空:True)
 objReferFileTypeEN.ReferFileTypeName = objDT.Rows[0][conReferFileType.ReferFileTypeName].ToString().Trim(); //引用文件类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objReferFileTypeEN.ReferFileTypeENName = objDT.Rows[0][conReferFileType.ReferFileTypeENName].ToString().Trim(); //引用文件类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objReferFileTypeEN.InUse = TransNullToBool(objDT.Rows[0][conReferFileType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objReferFileTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conReferFileType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objReferFileTypeEN.UpdDate = objDT.Rows[0][conReferFileType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objReferFileTypeEN.UpdUserId = objDT.Rows[0][conReferFileType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objReferFileTypeEN.Memo = objDT.Rows[0][conReferFileType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsReferFileTypeDA: GetReferFileType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReferFileTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsReferFileTypeEN GetObjByReferFileTypeId(string strReferFileTypeId)
{
CheckPrimaryKey(strReferFileTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = "Select * from ReferFileType where ReferFileTypeId = " + "'"+ strReferFileTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsReferFileTypeEN objReferFileTypeEN = new clsReferFileTypeEN();
try
{
 objReferFileTypeEN.ReferFileTypeId = objRow[conReferFileType.ReferFileTypeId].ToString().Trim(); //引用文件类型Id(字段类型:char,字段长度:2,是否可空:True)
 objReferFileTypeEN.ReferFileTypeName = objRow[conReferFileType.ReferFileTypeName].ToString().Trim(); //引用文件类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objReferFileTypeEN.ReferFileTypeENName = objRow[conReferFileType.ReferFileTypeENName] == DBNull.Value ? null : objRow[conReferFileType.ReferFileTypeENName].ToString().Trim(); //引用文件类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objReferFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFileType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objReferFileTypeEN.OrderNum = Int32.Parse(objRow[conReferFileType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objReferFileTypeEN.UpdDate = objRow[conReferFileType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objReferFileTypeEN.UpdUserId = objRow[conReferFileType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objReferFileTypeEN.Memo = objRow[conReferFileType.Memo] == DBNull.Value ? null : objRow[conReferFileType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsReferFileTypeDA: GetObjByReferFileTypeId)", objException.Message));
}
return objReferFileTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsReferFileTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsReferFileTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = "Select * from ReferFileType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsReferFileTypeEN objReferFileTypeEN = new clsReferFileTypeEN()
{
ReferFileTypeId = objRow[conReferFileType.ReferFileTypeId].ToString().Trim(), //引用文件类型Id
ReferFileTypeName = objRow[conReferFileType.ReferFileTypeName].ToString().Trim(), //引用文件类型名
ReferFileTypeENName = objRow[conReferFileType.ReferFileTypeENName] == DBNull.Value ? null : objRow[conReferFileType.ReferFileTypeENName].ToString().Trim(), //引用文件类型英文名
InUse = TransNullToBool(objRow[conReferFileType.InUse].ToString().Trim()), //是否在用
OrderNum = TransNullToInt(objRow[conReferFileType.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conReferFileType.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conReferFileType.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conReferFileType.Memo] == DBNull.Value ? null : objRow[conReferFileType.Memo].ToString().Trim() //说明
};
objReferFileTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objReferFileTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsReferFileTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsReferFileTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsReferFileTypeEN objReferFileTypeEN = new clsReferFileTypeEN();
try
{
objReferFileTypeEN.ReferFileTypeId = objRow[conReferFileType.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFileTypeEN.ReferFileTypeName = objRow[conReferFileType.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objReferFileTypeEN.ReferFileTypeENName = objRow[conReferFileType.ReferFileTypeENName] == DBNull.Value ? null : objRow[conReferFileType.ReferFileTypeENName].ToString().Trim(); //引用文件类型英文名
objReferFileTypeEN.InUse = TransNullToBool(objRow[conReferFileType.InUse].ToString().Trim()); //是否在用
objReferFileTypeEN.OrderNum = TransNullToInt(objRow[conReferFileType.OrderNum].ToString().Trim()); //序号
objReferFileTypeEN.UpdDate = objRow[conReferFileType.UpdDate].ToString().Trim(); //修改日期
objReferFileTypeEN.UpdUserId = objRow[conReferFileType.UpdUserId].ToString().Trim(); //修改用户Id
objReferFileTypeEN.Memo = objRow[conReferFileType.Memo] == DBNull.Value ? null : objRow[conReferFileType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsReferFileTypeDA: GetObjByDataRowReferFileType)", objException.Message));
}
objReferFileTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objReferFileTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsReferFileTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsReferFileTypeEN objReferFileTypeEN = new clsReferFileTypeEN();
try
{
objReferFileTypeEN.ReferFileTypeId = objRow[conReferFileType.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFileTypeEN.ReferFileTypeName = objRow[conReferFileType.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objReferFileTypeEN.ReferFileTypeENName = objRow[conReferFileType.ReferFileTypeENName] == DBNull.Value ? null : objRow[conReferFileType.ReferFileTypeENName].ToString().Trim(); //引用文件类型英文名
objReferFileTypeEN.InUse = TransNullToBool(objRow[conReferFileType.InUse].ToString().Trim()); //是否在用
objReferFileTypeEN.OrderNum = TransNullToInt(objRow[conReferFileType.OrderNum].ToString().Trim()); //序号
objReferFileTypeEN.UpdDate = objRow[conReferFileType.UpdDate].ToString().Trim(); //修改日期
objReferFileTypeEN.UpdUserId = objRow[conReferFileType.UpdUserId].ToString().Trim(); //修改用户Id
objReferFileTypeEN.Memo = objRow[conReferFileType.Memo] == DBNull.Value ? null : objRow[conReferFileType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsReferFileTypeDA: GetObjByDataRow)", objException.Message));
}
objReferFileTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objReferFileTypeEN;
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
objSQL = clsReferFileTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsReferFileTypeEN._CurrTabName, conReferFileType.ReferFileTypeId, 2, "");
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
objSQL = clsReferFileTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsReferFileTypeEN._CurrTabName, conReferFileType.ReferFileTypeId, 2, strPrefix);
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
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ReferFileTypeId from ReferFileType where " + strCondition;
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
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ReferFileTypeId from ReferFileType where " + strCondition;
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
 /// <param name = "strReferFileTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strReferFileTypeId)
{
CheckPrimaryKey(strReferFileTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ReferFileType", "ReferFileTypeId = " + "'"+ strReferFileTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsReferFileTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ReferFileType", strCondition))
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
objSQL = clsReferFileTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ReferFileType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsReferFileTypeEN objReferFileTypeEN)
 {
 objReferFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFileTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objReferFileTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = "Select * from ReferFileType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ReferFileType");
objRow = objDS.Tables["ReferFileType"].NewRow();
objRow[conReferFileType.ReferFileTypeId] = objReferFileTypeEN.ReferFileTypeId; //引用文件类型Id
objRow[conReferFileType.ReferFileTypeName] = objReferFileTypeEN.ReferFileTypeName; //引用文件类型名
 if (objReferFileTypeEN.ReferFileTypeENName !=  "")
 {
objRow[conReferFileType.ReferFileTypeENName] = objReferFileTypeEN.ReferFileTypeENName; //引用文件类型英文名
 }
objRow[conReferFileType.InUse] = objReferFileTypeEN.InUse; //是否在用
objRow[conReferFileType.OrderNum] = objReferFileTypeEN.OrderNum; //序号
objRow[conReferFileType.UpdDate] = objReferFileTypeEN.UpdDate; //修改日期
objRow[conReferFileType.UpdUserId] = objReferFileTypeEN.UpdUserId; //修改用户Id
 if (objReferFileTypeEN.Memo !=  "")
 {
objRow[conReferFileType.Memo] = objReferFileTypeEN.Memo; //说明
 }
objDS.Tables[clsReferFileTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsReferFileTypeEN._CurrTabName);
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
 /// <param name = "objReferFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsReferFileTypeEN objReferFileTypeEN)
{
 objReferFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFileTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objReferFileTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objReferFileTypeEN.ReferFileTypeId !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeId);
 var strReferFileTypeId = objReferFileTypeEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeId + "'");
 }
 
 if (objReferFileTypeEN.ReferFileTypeName !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeName);
 var strReferFileTypeName = objReferFileTypeEN.ReferFileTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeName + "'");
 }
 
 if (objReferFileTypeEN.ReferFileTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeENName);
 var strReferFileTypeENName = objReferFileTypeEN.ReferFileTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeENName + "'");
 }
 
 arrFieldListForInsert.Add(conReferFileType.InUse);
 arrValueListForInsert.Add("'" + (objReferFileTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conReferFileType.OrderNum);
 arrValueListForInsert.Add(objReferFileTypeEN.OrderNum.ToString());
 
 if (objReferFileTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.UpdDate);
 var strUpdDate = objReferFileTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objReferFileTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.UpdUserId);
 var strUpdUserId = objReferFileTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objReferFileTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.Memo);
 var strMemo = objReferFileTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ReferFileType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objReferFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsReferFileTypeEN objReferFileTypeEN)
{
 objReferFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFileTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objReferFileTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objReferFileTypeEN.ReferFileTypeId !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeId);
 var strReferFileTypeId = objReferFileTypeEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeId + "'");
 }
 
 if (objReferFileTypeEN.ReferFileTypeName !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeName);
 var strReferFileTypeName = objReferFileTypeEN.ReferFileTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeName + "'");
 }
 
 if (objReferFileTypeEN.ReferFileTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeENName);
 var strReferFileTypeENName = objReferFileTypeEN.ReferFileTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeENName + "'");
 }
 
 arrFieldListForInsert.Add(conReferFileType.InUse);
 arrValueListForInsert.Add("'" + (objReferFileTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conReferFileType.OrderNum);
 arrValueListForInsert.Add(objReferFileTypeEN.OrderNum.ToString());
 
 if (objReferFileTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.UpdDate);
 var strUpdDate = objReferFileTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objReferFileTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.UpdUserId);
 var strUpdUserId = objReferFileTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objReferFileTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.Memo);
 var strMemo = objReferFileTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ReferFileType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objReferFileTypeEN.ReferFileTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objReferFileTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsReferFileTypeEN objReferFileTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objReferFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFileTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objReferFileTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objReferFileTypeEN.ReferFileTypeId !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeId);
 var strReferFileTypeId = objReferFileTypeEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeId + "'");
 }
 
 if (objReferFileTypeEN.ReferFileTypeName !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeName);
 var strReferFileTypeName = objReferFileTypeEN.ReferFileTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeName + "'");
 }
 
 if (objReferFileTypeEN.ReferFileTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeENName);
 var strReferFileTypeENName = objReferFileTypeEN.ReferFileTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeENName + "'");
 }
 
 arrFieldListForInsert.Add(conReferFileType.InUse);
 arrValueListForInsert.Add("'" + (objReferFileTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conReferFileType.OrderNum);
 arrValueListForInsert.Add(objReferFileTypeEN.OrderNum.ToString());
 
 if (objReferFileTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.UpdDate);
 var strUpdDate = objReferFileTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objReferFileTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.UpdUserId);
 var strUpdUserId = objReferFileTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objReferFileTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.Memo);
 var strMemo = objReferFileTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ReferFileType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objReferFileTypeEN.ReferFileTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objReferFileTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsReferFileTypeEN objReferFileTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objReferFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFileTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objReferFileTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objReferFileTypeEN.ReferFileTypeId !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeId);
 var strReferFileTypeId = objReferFileTypeEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeId + "'");
 }
 
 if (objReferFileTypeEN.ReferFileTypeName !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeName);
 var strReferFileTypeName = objReferFileTypeEN.ReferFileTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeName + "'");
 }
 
 if (objReferFileTypeEN.ReferFileTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.ReferFileTypeENName);
 var strReferFileTypeENName = objReferFileTypeEN.ReferFileTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeENName + "'");
 }
 
 arrFieldListForInsert.Add(conReferFileType.InUse);
 arrValueListForInsert.Add("'" + (objReferFileTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conReferFileType.OrderNum);
 arrValueListForInsert.Add(objReferFileTypeEN.OrderNum.ToString());
 
 if (objReferFileTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.UpdDate);
 var strUpdDate = objReferFileTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objReferFileTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.UpdUserId);
 var strUpdUserId = objReferFileTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objReferFileTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conReferFileType.Memo);
 var strMemo = objReferFileTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ReferFileType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewReferFileTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = "Select * from ReferFileType where ReferFileTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ReferFileType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strReferFileTypeId = oRow[conReferFileType.ReferFileTypeId].ToString().Trim();
if (IsExist(strReferFileTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("ReferFileTypeId = {0}", strReferFileTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsReferFileTypeEN._CurrTabName ].NewRow();
objRow[conReferFileType.ReferFileTypeId] = oRow[conReferFileType.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objRow[conReferFileType.ReferFileTypeName] = oRow[conReferFileType.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objRow[conReferFileType.ReferFileTypeENName] = oRow[conReferFileType.ReferFileTypeENName].ToString().Trim(); //引用文件类型英文名
objRow[conReferFileType.InUse] = oRow[conReferFileType.InUse].ToString().Trim(); //是否在用
objRow[conReferFileType.OrderNum] = oRow[conReferFileType.OrderNum].ToString().Trim(); //序号
objRow[conReferFileType.UpdDate] = oRow[conReferFileType.UpdDate].ToString().Trim(); //修改日期
objRow[conReferFileType.UpdUserId] = oRow[conReferFileType.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conReferFileType.Memo] = oRow[conReferFileType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsReferFileTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsReferFileTypeEN._CurrTabName);
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
 /// <param name = "objReferFileTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsReferFileTypeEN objReferFileTypeEN)
{
 objReferFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFileTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objReferFileTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
strSQL = "Select * from ReferFileType where ReferFileTypeId = " + "'"+ objReferFileTypeEN.ReferFileTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsReferFileTypeEN._CurrTabName);
if (objDS.Tables[clsReferFileTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ReferFileTypeId = " + "'"+ objReferFileTypeEN.ReferFileTypeId+"'");
return false;
}
objRow = objDS.Tables[clsReferFileTypeEN._CurrTabName].Rows[0];
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeId))
 {
objRow[conReferFileType.ReferFileTypeId] = objReferFileTypeEN.ReferFileTypeId; //引用文件类型Id
 }
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeName))
 {
objRow[conReferFileType.ReferFileTypeName] = objReferFileTypeEN.ReferFileTypeName; //引用文件类型名
 }
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeENName))
 {
objRow[conReferFileType.ReferFileTypeENName] = objReferFileTypeEN.ReferFileTypeENName; //引用文件类型英文名
 }
 if (objReferFileTypeEN.IsUpdated(conReferFileType.InUse))
 {
objRow[conReferFileType.InUse] = objReferFileTypeEN.InUse; //是否在用
 }
 if (objReferFileTypeEN.IsUpdated(conReferFileType.OrderNum))
 {
objRow[conReferFileType.OrderNum] = objReferFileTypeEN.OrderNum; //序号
 }
 if (objReferFileTypeEN.IsUpdated(conReferFileType.UpdDate))
 {
objRow[conReferFileType.UpdDate] = objReferFileTypeEN.UpdDate; //修改日期
 }
 if (objReferFileTypeEN.IsUpdated(conReferFileType.UpdUserId))
 {
objRow[conReferFileType.UpdUserId] = objReferFileTypeEN.UpdUserId; //修改用户Id
 }
 if (objReferFileTypeEN.IsUpdated(conReferFileType.Memo))
 {
objRow[conReferFileType.Memo] = objReferFileTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsReferFileTypeEN._CurrTabName);
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
 /// <param name = "objReferFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsReferFileTypeEN objReferFileTypeEN)
{
 objReferFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFileTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objReferFileTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ReferFileType Set ");
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeName))
 {
 if (objReferFileTypeEN.ReferFileTypeName !=  null)
 {
 var strReferFileTypeName = objReferFileTypeEN.ReferFileTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReferFileTypeName, conReferFileType.ReferFileTypeName); //引用文件类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFileType.ReferFileTypeName); //引用文件类型名
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeENName))
 {
 if (objReferFileTypeEN.ReferFileTypeENName !=  null)
 {
 var strReferFileTypeENName = objReferFileTypeEN.ReferFileTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReferFileTypeENName, conReferFileType.ReferFileTypeENName); //引用文件类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFileType.ReferFileTypeENName); //引用文件类型英文名
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objReferFileTypeEN.InUse == true?"1":"0", conReferFileType.InUse); //是否在用
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objReferFileTypeEN.OrderNum, conReferFileType.OrderNum); //序号
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.UpdDate))
 {
 if (objReferFileTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objReferFileTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conReferFileType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFileType.UpdDate); //修改日期
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.UpdUserId))
 {
 if (objReferFileTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objReferFileTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conReferFileType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFileType.UpdUserId); //修改用户Id
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.Memo))
 {
 if (objReferFileTypeEN.Memo !=  null)
 {
 var strMemo = objReferFileTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conReferFileType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFileType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ReferFileTypeId = '{0}'", objReferFileTypeEN.ReferFileTypeId); 
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
 /// <param name = "objReferFileTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsReferFileTypeEN objReferFileTypeEN, string strCondition)
{
 objReferFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFileTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objReferFileTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ReferFileType Set ");
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeName))
 {
 if (objReferFileTypeEN.ReferFileTypeName !=  null)
 {
 var strReferFileTypeName = objReferFileTypeEN.ReferFileTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReferFileTypeName = '{0}',", strReferFileTypeName); //引用文件类型名
 }
 else
 {
 sbSQL.Append(" ReferFileTypeName = null,"); //引用文件类型名
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeENName))
 {
 if (objReferFileTypeEN.ReferFileTypeENName !=  null)
 {
 var strReferFileTypeENName = objReferFileTypeEN.ReferFileTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReferFileTypeENName = '{0}',", strReferFileTypeENName); //引用文件类型英文名
 }
 else
 {
 sbSQL.Append(" ReferFileTypeENName = null,"); //引用文件类型英文名
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objReferFileTypeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objReferFileTypeEN.OrderNum); //序号
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.UpdDate))
 {
 if (objReferFileTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objReferFileTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.UpdUserId))
 {
 if (objReferFileTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objReferFileTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.Memo))
 {
 if (objReferFileTypeEN.Memo !=  null)
 {
 var strMemo = objReferFileTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objReferFileTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsReferFileTypeEN objReferFileTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objReferFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFileTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objReferFileTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ReferFileType Set ");
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeName))
 {
 if (objReferFileTypeEN.ReferFileTypeName !=  null)
 {
 var strReferFileTypeName = objReferFileTypeEN.ReferFileTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReferFileTypeName = '{0}',", strReferFileTypeName); //引用文件类型名
 }
 else
 {
 sbSQL.Append(" ReferFileTypeName = null,"); //引用文件类型名
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeENName))
 {
 if (objReferFileTypeEN.ReferFileTypeENName !=  null)
 {
 var strReferFileTypeENName = objReferFileTypeEN.ReferFileTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReferFileTypeENName = '{0}',", strReferFileTypeENName); //引用文件类型英文名
 }
 else
 {
 sbSQL.Append(" ReferFileTypeENName = null,"); //引用文件类型英文名
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objReferFileTypeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objReferFileTypeEN.OrderNum); //序号
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.UpdDate))
 {
 if (objReferFileTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objReferFileTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.UpdUserId))
 {
 if (objReferFileTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objReferFileTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.Memo))
 {
 if (objReferFileTypeEN.Memo !=  null)
 {
 var strMemo = objReferFileTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objReferFileTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsReferFileTypeEN objReferFileTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objReferFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFileTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objReferFileTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ReferFileType Set ");
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeName))
 {
 if (objReferFileTypeEN.ReferFileTypeName !=  null)
 {
 var strReferFileTypeName = objReferFileTypeEN.ReferFileTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReferFileTypeName, conReferFileType.ReferFileTypeName); //引用文件类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFileType.ReferFileTypeName); //引用文件类型名
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.ReferFileTypeENName))
 {
 if (objReferFileTypeEN.ReferFileTypeENName !=  null)
 {
 var strReferFileTypeENName = objReferFileTypeEN.ReferFileTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReferFileTypeENName, conReferFileType.ReferFileTypeENName); //引用文件类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFileType.ReferFileTypeENName); //引用文件类型英文名
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objReferFileTypeEN.InUse == true?"1":"0", conReferFileType.InUse); //是否在用
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objReferFileTypeEN.OrderNum, conReferFileType.OrderNum); //序号
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.UpdDate))
 {
 if (objReferFileTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objReferFileTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conReferFileType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFileType.UpdDate); //修改日期
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.UpdUserId))
 {
 if (objReferFileTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objReferFileTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conReferFileType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFileType.UpdUserId); //修改用户Id
 }
 }
 
 if (objReferFileTypeEN.IsUpdated(conReferFileType.Memo))
 {
 if (objReferFileTypeEN.Memo !=  null)
 {
 var strMemo = objReferFileTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conReferFileType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFileType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ReferFileTypeId = '{0}'", objReferFileTypeEN.ReferFileTypeId); 
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
 /// <param name = "strReferFileTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strReferFileTypeId) 
{
CheckPrimaryKey(strReferFileTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strReferFileTypeId,
};
 objSQL.ExecSP("ReferFileType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strReferFileTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strReferFileTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strReferFileTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
//删除ReferFileType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ReferFileType where ReferFileTypeId = " + "'"+ strReferFileTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelReferFileType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
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
//删除ReferFileType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ReferFileType where ReferFileTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strReferFileTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strReferFileTypeId) 
{
CheckPrimaryKey(strReferFileTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
//删除ReferFileType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ReferFileType where ReferFileTypeId = " + "'"+ strReferFileTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelReferFileType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsReferFileTypeDA: DelReferFileType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ReferFileType where " + strCondition ;
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
public bool DelReferFileTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsReferFileTypeDA: DelReferFileTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ReferFileType where " + strCondition ;
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
 /// <param name = "objReferFileTypeENS">源对象</param>
 /// <param name = "objReferFileTypeENT">目标对象</param>
public void CopyTo(clsReferFileTypeEN objReferFileTypeENS, clsReferFileTypeEN objReferFileTypeENT)
{
objReferFileTypeENT.ReferFileTypeId = objReferFileTypeENS.ReferFileTypeId; //引用文件类型Id
objReferFileTypeENT.ReferFileTypeName = objReferFileTypeENS.ReferFileTypeName; //引用文件类型名
objReferFileTypeENT.ReferFileTypeENName = objReferFileTypeENS.ReferFileTypeENName; //引用文件类型英文名
objReferFileTypeENT.InUse = objReferFileTypeENS.InUse; //是否在用
objReferFileTypeENT.OrderNum = objReferFileTypeENS.OrderNum; //序号
objReferFileTypeENT.UpdDate = objReferFileTypeENS.UpdDate; //修改日期
objReferFileTypeENT.UpdUserId = objReferFileTypeENS.UpdUserId; //修改用户Id
objReferFileTypeENT.Memo = objReferFileTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsReferFileTypeEN objReferFileTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objReferFileTypeEN.ReferFileTypeName, conReferFileType.ReferFileTypeName);
clsCheckSql.CheckFieldNotNull(objReferFileTypeEN.OrderNum, conReferFileType.OrderNum);
clsCheckSql.CheckFieldNotNull(objReferFileTypeEN.UpdDate, conReferFileType.UpdDate);
clsCheckSql.CheckFieldNotNull(objReferFileTypeEN.UpdUserId, conReferFileType.UpdUserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objReferFileTypeEN.ReferFileTypeId, 2, conReferFileType.ReferFileTypeId);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.ReferFileTypeName, 50, conReferFileType.ReferFileTypeName);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.ReferFileTypeENName, 50, conReferFileType.ReferFileTypeENName);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.UpdDate, 20, conReferFileType.UpdDate);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.UpdUserId, 20, conReferFileType.UpdUserId);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.Memo, 1000, conReferFileType.Memo);
//检查字段外键固定长度
 objReferFileTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsReferFileTypeEN objReferFileTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objReferFileTypeEN.ReferFileTypeName, 50, conReferFileType.ReferFileTypeName);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.ReferFileTypeENName, 50, conReferFileType.ReferFileTypeENName);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.UpdDate, 20, conReferFileType.UpdDate);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.UpdUserId, 20, conReferFileType.UpdUserId);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.Memo, 1000, conReferFileType.Memo);
//检查外键字段长度
 objReferFileTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsReferFileTypeEN objReferFileTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objReferFileTypeEN.ReferFileTypeId, 2, conReferFileType.ReferFileTypeId);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.ReferFileTypeName, 50, conReferFileType.ReferFileTypeName);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.ReferFileTypeENName, 50, conReferFileType.ReferFileTypeENName);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.UpdDate, 20, conReferFileType.UpdDate);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.UpdUserId, 20, conReferFileType.UpdUserId);
clsCheckSql.CheckFieldLen(objReferFileTypeEN.Memo, 1000, conReferFileType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objReferFileTypeEN.ReferFileTypeId, conReferFileType.ReferFileTypeId);
clsCheckSql.CheckSqlInjection4Field(objReferFileTypeEN.ReferFileTypeName, conReferFileType.ReferFileTypeName);
clsCheckSql.CheckSqlInjection4Field(objReferFileTypeEN.ReferFileTypeENName, conReferFileType.ReferFileTypeENName);
clsCheckSql.CheckSqlInjection4Field(objReferFileTypeEN.UpdDate, conReferFileType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objReferFileTypeEN.UpdUserId, conReferFileType.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objReferFileTypeEN.Memo, conReferFileType.Memo);
//检查外键字段长度
 objReferFileTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetReferFileTypeId()
{
//获取某学院所有专业信息
string strSQL = "select ReferFileTypeId, ReferFileTypeName from ReferFileType ";
 clsSpecSQLforSql mySql = clsReferFileTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ReferFileType(引用文件类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objReferFileTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsReferFileTypeEN objReferFileTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ReferFileTypeName = '{0}'", objReferFileTypeEN.ReferFileTypeName);
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
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
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
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
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
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsReferFileTypeEN._CurrTabName);
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
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsReferFileTypeEN._CurrTabName, strCondition);
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
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
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
 objSQL = clsReferFileTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}