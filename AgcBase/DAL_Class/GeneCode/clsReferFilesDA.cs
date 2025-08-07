
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsReferFilesDA
 表名:ReferFiles(00050460)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 引用文件(ReferFiles)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsReferFilesDA : clsCommBase4DA
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
 return clsReferFilesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsReferFilesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsReferFilesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsReferFilesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsReferFilesEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strReferFileId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strReferFileId)
{
strReferFileId = strReferFileId.Replace("'", "''");
if (strReferFileId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:ReferFiles中,检查关键字,长度不正确!(clsReferFilesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strReferFileId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ReferFiles中,关键字不能为空 或 null!(clsReferFilesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReferFileId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsReferFilesDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from ReferFiles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ReferFiles(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsReferFilesDA: GetDataTable_ReferFiles)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from ReferFiles where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from ReferFiles where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsReferFilesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ReferFiles where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ReferFiles where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsReferFilesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ReferFiles where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsReferFilesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ReferFiles.* " + 
$"from ReferFiles " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ReferFiles.ReferFileId not in " + 
$"(Select top {intTop_In} ReferFiles.ReferFileId from ReferFiles " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ReferFiles where {1} and ReferFileId not in (Select top {2} ReferFileId from ReferFiles where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ReferFiles where {1} and ReferFileId not in (Select top {3} ReferFileId from ReferFiles where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsReferFilesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ReferFiles.* " + 
$"from ReferFiles " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ReferFiles.ReferFileId not in " + 
$"(Select top {intTop_In} ReferFiles.ReferFileId from ReferFiles " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ReferFiles where {1} and ReferFileId not in (Select top {2} ReferFileId from ReferFiles where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ReferFiles where {1} and ReferFileId not in (Select top {3} ReferFileId from ReferFiles where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsReferFilesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsReferFilesDA:GetObjLst)", objException.Message));
}
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from ReferFiles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = TransNullToBool(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = TransNullToBool(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = TransNullToInt(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsReferFilesDA: GetObjLst)", objException.Message));
}
objReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objReferFilesEN);
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
public List<clsReferFilesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsReferFilesDA:GetObjLstByTabName)", objException.Message));
}
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = TransNullToBool(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = TransNullToBool(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = TransNullToInt(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsReferFilesDA: GetObjLst)", objException.Message));
}
objReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objReferFilesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objReferFilesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetReferFiles(ref clsReferFilesEN objReferFilesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from ReferFiles where ReferFileId = " + "'"+ objReferFilesEN.ReferFileId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objReferFilesEN.ReferFileId = objDT.Rows[0][conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id(字段类型:char,字段长度:8,是否可空:True)
 objReferFilesEN.FileName = objDT.Rows[0][conReferFiles.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objReferFilesEN.ReferFileTypeId = objDT.Rows[0][conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id(字段类型:char,字段长度:2,是否可空:True)
 objReferFilesEN.FilePath = objDT.Rows[0][conReferFiles.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objReferFilesEN.IsNeedDownLoad = TransNullToBool(objDT.Rows[0][conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载(字段类型:bit,字段长度:1,是否可空:False)
 objReferFilesEN.Version = objDT.Rows[0][conReferFiles.Version].ToString().Trim(); //版本(字段类型:varchar,字段长度:30,是否可空:False)
 objReferFilesEN.InUse = TransNullToBool(objDT.Rows[0][conReferFiles.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objReferFilesEN.OrderNum = TransNullToInt(objDT.Rows[0][conReferFiles.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objReferFilesEN.UpdDate = objDT.Rows[0][conReferFiles.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objReferFilesEN.UpdUserId = objDT.Rows[0][conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objReferFilesEN.Memo = objDT.Rows[0][conReferFiles.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsReferFilesDA: GetReferFiles)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReferFileId">表关键字</param>
 /// <returns>表对象</returns>
public clsReferFilesEN GetObjByReferFileId(string strReferFileId)
{
CheckPrimaryKey(strReferFileId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from ReferFiles where ReferFileId = " + "'"+ strReferFileId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
 objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id(字段类型:char,字段长度:8,是否可空:True)
 objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id(字段类型:char,字段长度:2,是否可空:True)
 objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载(字段类型:bit,字段长度:1,是否可空:False)
 objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本(字段类型:varchar,字段长度:30,是否可空:False)
 objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsReferFilesDA: GetObjByReferFileId)", objException.Message));
}
return objReferFilesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsReferFilesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsReferFilesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from ReferFiles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN()
{
ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(), //引用文件Id
FileName = objRow[conReferFiles.FileName].ToString().Trim(), //文件名
ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(), //引用文件类型Id
FilePath = objRow[conReferFiles.FilePath].ToString().Trim(), //文件路径
IsNeedDownLoad = TransNullToBool(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()), //是否需要下载
Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(), //版本
InUse = TransNullToBool(objRow[conReferFiles.InUse].ToString().Trim()), //是否在用
OrderNum = TransNullToInt(objRow[conReferFiles.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim() //说明
};
objReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objReferFilesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsReferFilesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsReferFilesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = TransNullToBool(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = TransNullToBool(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = TransNullToInt(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsReferFilesDA: GetObjByDataRowReferFiles)", objException.Message));
}
objReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objReferFilesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsReferFilesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = TransNullToBool(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = TransNullToBool(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = TransNullToInt(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsReferFilesDA: GetObjByDataRow)", objException.Message));
}
objReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objReferFilesEN;
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
objSQL = clsReferFilesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsReferFilesEN._CurrTabName, conReferFiles.ReferFileId, 8, "");
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
objSQL = clsReferFilesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsReferFilesEN._CurrTabName, conReferFiles.ReferFileId, 8, strPrefix);
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
 objSQL = clsReferFilesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ReferFileId from ReferFiles where " + strCondition;
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
 objSQL = clsReferFilesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ReferFileId from ReferFiles where " + strCondition;
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
 /// <param name = "strReferFileId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strReferFileId)
{
CheckPrimaryKey(strReferFileId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ReferFiles", "ReferFileId = " + "'"+ strReferFileId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsReferFilesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ReferFiles", strCondition))
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
objSQL = clsReferFilesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ReferFiles");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsReferFilesEN objReferFilesEN)
 {
 objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFilesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objReferFilesEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from ReferFiles where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ReferFiles");
objRow = objDS.Tables["ReferFiles"].NewRow();
objRow[conReferFiles.ReferFileId] = objReferFilesEN.ReferFileId; //引用文件Id
objRow[conReferFiles.FileName] = objReferFilesEN.FileName; //文件名
 if (objReferFilesEN.ReferFileTypeId !=  "")
 {
objRow[conReferFiles.ReferFileTypeId] = objReferFilesEN.ReferFileTypeId; //引用文件类型Id
 }
objRow[conReferFiles.FilePath] = objReferFilesEN.FilePath; //文件路径
objRow[conReferFiles.IsNeedDownLoad] = objReferFilesEN.IsNeedDownLoad; //是否需要下载
 if (objReferFilesEN.Version !=  "")
 {
objRow[conReferFiles.Version] = objReferFilesEN.Version; //版本
 }
objRow[conReferFiles.InUse] = objReferFilesEN.InUse; //是否在用
objRow[conReferFiles.OrderNum] = objReferFilesEN.OrderNum; //序号
objRow[conReferFiles.UpdDate] = objReferFilesEN.UpdDate; //修改日期
objRow[conReferFiles.UpdUserId] = objReferFilesEN.UpdUserId; //修改用户Id
 if (objReferFilesEN.Memo !=  "")
 {
objRow[conReferFiles.Memo] = objReferFilesEN.Memo; //说明
 }
objDS.Tables[clsReferFilesEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsReferFilesEN._CurrTabName);
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
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsReferFilesEN objReferFilesEN)
{
 objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFilesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objReferFilesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objReferFilesEN.ReferFileId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.ReferFileId);
 var strReferFileId = objReferFilesEN.ReferFileId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileId + "'");
 }
 
 if (objReferFilesEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.FileName);
 var strFileName = objReferFilesEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objReferFilesEN.ReferFileTypeId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.ReferFileTypeId);
 var strReferFileTypeId = objReferFilesEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeId + "'");
 }
 
 if (objReferFilesEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.FilePath);
 var strFilePath = objReferFilesEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 arrFieldListForInsert.Add(conReferFiles.IsNeedDownLoad);
 arrValueListForInsert.Add("'" + (objReferFilesEN.IsNeedDownLoad  ==  false ? "0" : "1") + "'");
 
 if (objReferFilesEN.Version !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.Version);
 var strVersion = objReferFilesEN.Version.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersion + "'");
 }
 
 arrFieldListForInsert.Add(conReferFiles.InUse);
 arrValueListForInsert.Add("'" + (objReferFilesEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conReferFiles.OrderNum);
 arrValueListForInsert.Add(objReferFilesEN.OrderNum.ToString());
 
 if (objReferFilesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.UpdDate);
 var strUpdDate = objReferFilesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objReferFilesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.UpdUserId);
 var strUpdUserId = objReferFilesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objReferFilesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.Memo);
 var strMemo = objReferFilesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ReferFiles");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsReferFilesEN objReferFilesEN)
{
 objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFilesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objReferFilesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objReferFilesEN.ReferFileId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.ReferFileId);
 var strReferFileId = objReferFilesEN.ReferFileId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileId + "'");
 }
 
 if (objReferFilesEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.FileName);
 var strFileName = objReferFilesEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objReferFilesEN.ReferFileTypeId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.ReferFileTypeId);
 var strReferFileTypeId = objReferFilesEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeId + "'");
 }
 
 if (objReferFilesEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.FilePath);
 var strFilePath = objReferFilesEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 arrFieldListForInsert.Add(conReferFiles.IsNeedDownLoad);
 arrValueListForInsert.Add("'" + (objReferFilesEN.IsNeedDownLoad  ==  false ? "0" : "1") + "'");
 
 if (objReferFilesEN.Version !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.Version);
 var strVersion = objReferFilesEN.Version.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersion + "'");
 }
 
 arrFieldListForInsert.Add(conReferFiles.InUse);
 arrValueListForInsert.Add("'" + (objReferFilesEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conReferFiles.OrderNum);
 arrValueListForInsert.Add(objReferFilesEN.OrderNum.ToString());
 
 if (objReferFilesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.UpdDate);
 var strUpdDate = objReferFilesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objReferFilesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.UpdUserId);
 var strUpdUserId = objReferFilesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objReferFilesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.Memo);
 var strMemo = objReferFilesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ReferFiles");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objReferFilesEN.ReferFileId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsReferFilesEN objReferFilesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFilesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objReferFilesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objReferFilesEN.ReferFileId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.ReferFileId);
 var strReferFileId = objReferFilesEN.ReferFileId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileId + "'");
 }
 
 if (objReferFilesEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.FileName);
 var strFileName = objReferFilesEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objReferFilesEN.ReferFileTypeId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.ReferFileTypeId);
 var strReferFileTypeId = objReferFilesEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeId + "'");
 }
 
 if (objReferFilesEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.FilePath);
 var strFilePath = objReferFilesEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 arrFieldListForInsert.Add(conReferFiles.IsNeedDownLoad);
 arrValueListForInsert.Add("'" + (objReferFilesEN.IsNeedDownLoad  ==  false ? "0" : "1") + "'");
 
 if (objReferFilesEN.Version !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.Version);
 var strVersion = objReferFilesEN.Version.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersion + "'");
 }
 
 arrFieldListForInsert.Add(conReferFiles.InUse);
 arrValueListForInsert.Add("'" + (objReferFilesEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conReferFiles.OrderNum);
 arrValueListForInsert.Add(objReferFilesEN.OrderNum.ToString());
 
 if (objReferFilesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.UpdDate);
 var strUpdDate = objReferFilesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objReferFilesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.UpdUserId);
 var strUpdUserId = objReferFilesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objReferFilesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.Memo);
 var strMemo = objReferFilesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ReferFiles");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objReferFilesEN.ReferFileId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsReferFilesEN objReferFilesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFilesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objReferFilesEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objReferFilesEN.ReferFileId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.ReferFileId);
 var strReferFileId = objReferFilesEN.ReferFileId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileId + "'");
 }
 
 if (objReferFilesEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.FileName);
 var strFileName = objReferFilesEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objReferFilesEN.ReferFileTypeId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.ReferFileTypeId);
 var strReferFileTypeId = objReferFilesEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReferFileTypeId + "'");
 }
 
 if (objReferFilesEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.FilePath);
 var strFilePath = objReferFilesEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 arrFieldListForInsert.Add(conReferFiles.IsNeedDownLoad);
 arrValueListForInsert.Add("'" + (objReferFilesEN.IsNeedDownLoad  ==  false ? "0" : "1") + "'");
 
 if (objReferFilesEN.Version !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.Version);
 var strVersion = objReferFilesEN.Version.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersion + "'");
 }
 
 arrFieldListForInsert.Add(conReferFiles.InUse);
 arrValueListForInsert.Add("'" + (objReferFilesEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conReferFiles.OrderNum);
 arrValueListForInsert.Add(objReferFilesEN.OrderNum.ToString());
 
 if (objReferFilesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.UpdDate);
 var strUpdDate = objReferFilesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objReferFilesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.UpdUserId);
 var strUpdUserId = objReferFilesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objReferFilesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conReferFiles.Memo);
 var strMemo = objReferFilesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ReferFiles");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewReferFiless(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from ReferFiles where ReferFileId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ReferFiles");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strReferFileId = oRow[conReferFiles.ReferFileId].ToString().Trim();
if (IsExist(strReferFileId))
{
 string strResult = "关键字变量值为:" + string.Format("ReferFileId = {0}", strReferFileId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsReferFilesEN._CurrTabName ].NewRow();
objRow[conReferFiles.ReferFileId] = oRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objRow[conReferFiles.FileName] = oRow[conReferFiles.FileName].ToString().Trim(); //文件名
objRow[conReferFiles.ReferFileTypeId] = oRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objRow[conReferFiles.FilePath] = oRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objRow[conReferFiles.IsNeedDownLoad] = oRow[conReferFiles.IsNeedDownLoad].ToString().Trim(); //是否需要下载
objRow[conReferFiles.Version] = oRow[conReferFiles.Version].ToString().Trim(); //版本
objRow[conReferFiles.InUse] = oRow[conReferFiles.InUse].ToString().Trim(); //是否在用
objRow[conReferFiles.OrderNum] = oRow[conReferFiles.OrderNum].ToString().Trim(); //序号
objRow[conReferFiles.UpdDate] = oRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objRow[conReferFiles.UpdUserId] = oRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conReferFiles.Memo] = oRow[conReferFiles.Memo].ToString().Trim(); //说明
 objDS.Tables[clsReferFilesEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsReferFilesEN._CurrTabName);
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
 /// <param name = "objReferFilesEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsReferFilesEN objReferFilesEN)
{
 objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFilesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objReferFilesEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from ReferFiles where ReferFileId = " + "'"+ objReferFilesEN.ReferFileId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsReferFilesEN._CurrTabName);
if (objDS.Tables[clsReferFilesEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ReferFileId = " + "'"+ objReferFilesEN.ReferFileId+"'");
return false;
}
objRow = objDS.Tables[clsReferFilesEN._CurrTabName].Rows[0];
 if (objReferFilesEN.IsUpdated(conReferFiles.ReferFileId))
 {
objRow[conReferFiles.ReferFileId] = objReferFilesEN.ReferFileId; //引用文件Id
 }
 if (objReferFilesEN.IsUpdated(conReferFiles.FileName))
 {
objRow[conReferFiles.FileName] = objReferFilesEN.FileName; //文件名
 }
 if (objReferFilesEN.IsUpdated(conReferFiles.ReferFileTypeId))
 {
objRow[conReferFiles.ReferFileTypeId] = objReferFilesEN.ReferFileTypeId; //引用文件类型Id
 }
 if (objReferFilesEN.IsUpdated(conReferFiles.FilePath))
 {
objRow[conReferFiles.FilePath] = objReferFilesEN.FilePath; //文件路径
 }
 if (objReferFilesEN.IsUpdated(conReferFiles.IsNeedDownLoad))
 {
objRow[conReferFiles.IsNeedDownLoad] = objReferFilesEN.IsNeedDownLoad; //是否需要下载
 }
 if (objReferFilesEN.IsUpdated(conReferFiles.Version))
 {
objRow[conReferFiles.Version] = objReferFilesEN.Version; //版本
 }
 if (objReferFilesEN.IsUpdated(conReferFiles.InUse))
 {
objRow[conReferFiles.InUse] = objReferFilesEN.InUse; //是否在用
 }
 if (objReferFilesEN.IsUpdated(conReferFiles.OrderNum))
 {
objRow[conReferFiles.OrderNum] = objReferFilesEN.OrderNum; //序号
 }
 if (objReferFilesEN.IsUpdated(conReferFiles.UpdDate))
 {
objRow[conReferFiles.UpdDate] = objReferFilesEN.UpdDate; //修改日期
 }
 if (objReferFilesEN.IsUpdated(conReferFiles.UpdUserId))
 {
objRow[conReferFiles.UpdUserId] = objReferFilesEN.UpdUserId; //修改用户Id
 }
 if (objReferFilesEN.IsUpdated(conReferFiles.Memo))
 {
objRow[conReferFiles.Memo] = objReferFilesEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsReferFilesEN._CurrTabName);
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
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsReferFilesEN objReferFilesEN)
{
 objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFilesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objReferFilesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ReferFiles Set ");
 
 if (objReferFilesEN.IsUpdated(conReferFiles.FileName))
 {
 if (objReferFilesEN.FileName !=  null)
 {
 var strFileName = objReferFilesEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conReferFiles.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.FileName); //文件名
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.ReferFileTypeId))
 {
 if (objReferFilesEN.ReferFileTypeId !=  null)
 {
 var strReferFileTypeId = objReferFilesEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReferFileTypeId, conReferFiles.ReferFileTypeId); //引用文件类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.ReferFileTypeId); //引用文件类型Id
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.FilePath))
 {
 if (objReferFilesEN.FilePath !=  null)
 {
 var strFilePath = objReferFilesEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conReferFiles.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.FilePath); //文件路径
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.IsNeedDownLoad))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objReferFilesEN.IsNeedDownLoad == true?"1":"0", conReferFiles.IsNeedDownLoad); //是否需要下载
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.Version))
 {
 if (objReferFilesEN.Version !=  null)
 {
 var strVersion = objReferFilesEN.Version.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersion, conReferFiles.Version); //版本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.Version); //版本
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objReferFilesEN.InUse == true?"1":"0", conReferFiles.InUse); //是否在用
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objReferFilesEN.OrderNum, conReferFiles.OrderNum); //序号
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.UpdDate))
 {
 if (objReferFilesEN.UpdDate !=  null)
 {
 var strUpdDate = objReferFilesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conReferFiles.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.UpdDate); //修改日期
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.UpdUserId))
 {
 if (objReferFilesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objReferFilesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conReferFiles.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.UpdUserId); //修改用户Id
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.Memo))
 {
 if (objReferFilesEN.Memo !=  null)
 {
 var strMemo = objReferFilesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conReferFiles.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ReferFileId = '{0}'", objReferFilesEN.ReferFileId); 
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
 /// <param name = "objReferFilesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsReferFilesEN objReferFilesEN, string strCondition)
{
 objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFilesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objReferFilesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ReferFiles Set ");
 
 if (objReferFilesEN.IsUpdated(conReferFiles.FileName))
 {
 if (objReferFilesEN.FileName !=  null)
 {
 var strFileName = objReferFilesEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.ReferFileTypeId))
 {
 if (objReferFilesEN.ReferFileTypeId !=  null)
 {
 var strReferFileTypeId = objReferFilesEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReferFileTypeId = '{0}',", strReferFileTypeId); //引用文件类型Id
 }
 else
 {
 sbSQL.Append(" ReferFileTypeId = null,"); //引用文件类型Id
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.FilePath))
 {
 if (objReferFilesEN.FilePath !=  null)
 {
 var strFilePath = objReferFilesEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.IsNeedDownLoad))
 {
 sbSQL.AppendFormat(" IsNeedDownLoad = '{0}',", objReferFilesEN.IsNeedDownLoad == true?"1":"0"); //是否需要下载
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.Version))
 {
 if (objReferFilesEN.Version !=  null)
 {
 var strVersion = objReferFilesEN.Version.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Version = '{0}',", strVersion); //版本
 }
 else
 {
 sbSQL.Append(" Version = null,"); //版本
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objReferFilesEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objReferFilesEN.OrderNum); //序号
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.UpdDate))
 {
 if (objReferFilesEN.UpdDate !=  null)
 {
 var strUpdDate = objReferFilesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.UpdUserId))
 {
 if (objReferFilesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objReferFilesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.Memo))
 {
 if (objReferFilesEN.Memo !=  null)
 {
 var strMemo = objReferFilesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objReferFilesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsReferFilesEN objReferFilesEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFilesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objReferFilesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ReferFiles Set ");
 
 if (objReferFilesEN.IsUpdated(conReferFiles.FileName))
 {
 if (objReferFilesEN.FileName !=  null)
 {
 var strFileName = objReferFilesEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.ReferFileTypeId))
 {
 if (objReferFilesEN.ReferFileTypeId !=  null)
 {
 var strReferFileTypeId = objReferFilesEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReferFileTypeId = '{0}',", strReferFileTypeId); //引用文件类型Id
 }
 else
 {
 sbSQL.Append(" ReferFileTypeId = null,"); //引用文件类型Id
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.FilePath))
 {
 if (objReferFilesEN.FilePath !=  null)
 {
 var strFilePath = objReferFilesEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.IsNeedDownLoad))
 {
 sbSQL.AppendFormat(" IsNeedDownLoad = '{0}',", objReferFilesEN.IsNeedDownLoad == true?"1":"0"); //是否需要下载
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.Version))
 {
 if (objReferFilesEN.Version !=  null)
 {
 var strVersion = objReferFilesEN.Version.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Version = '{0}',", strVersion); //版本
 }
 else
 {
 sbSQL.Append(" Version = null,"); //版本
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objReferFilesEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objReferFilesEN.OrderNum); //序号
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.UpdDate))
 {
 if (objReferFilesEN.UpdDate !=  null)
 {
 var strUpdDate = objReferFilesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.UpdUserId))
 {
 if (objReferFilesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objReferFilesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.Memo))
 {
 if (objReferFilesEN.Memo !=  null)
 {
 var strMemo = objReferFilesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsReferFilesEN objReferFilesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objReferFilesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objReferFilesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ReferFiles Set ");
 
 if (objReferFilesEN.IsUpdated(conReferFiles.FileName))
 {
 if (objReferFilesEN.FileName !=  null)
 {
 var strFileName = objReferFilesEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conReferFiles.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.FileName); //文件名
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.ReferFileTypeId))
 {
 if (objReferFilesEN.ReferFileTypeId !=  null)
 {
 var strReferFileTypeId = objReferFilesEN.ReferFileTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReferFileTypeId, conReferFiles.ReferFileTypeId); //引用文件类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.ReferFileTypeId); //引用文件类型Id
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.FilePath))
 {
 if (objReferFilesEN.FilePath !=  null)
 {
 var strFilePath = objReferFilesEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conReferFiles.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.FilePath); //文件路径
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.IsNeedDownLoad))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objReferFilesEN.IsNeedDownLoad == true?"1":"0", conReferFiles.IsNeedDownLoad); //是否需要下载
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.Version))
 {
 if (objReferFilesEN.Version !=  null)
 {
 var strVersion = objReferFilesEN.Version.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersion, conReferFiles.Version); //版本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.Version); //版本
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objReferFilesEN.InUse == true?"1":"0", conReferFiles.InUse); //是否在用
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objReferFilesEN.OrderNum, conReferFiles.OrderNum); //序号
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.UpdDate))
 {
 if (objReferFilesEN.UpdDate !=  null)
 {
 var strUpdDate = objReferFilesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conReferFiles.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.UpdDate); //修改日期
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.UpdUserId))
 {
 if (objReferFilesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objReferFilesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conReferFiles.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.UpdUserId); //修改用户Id
 }
 }
 
 if (objReferFilesEN.IsUpdated(conReferFiles.Memo))
 {
 if (objReferFilesEN.Memo !=  null)
 {
 var strMemo = objReferFilesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conReferFiles.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conReferFiles.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ReferFileId = '{0}'", objReferFilesEN.ReferFileId); 
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
 /// <param name = "strReferFileId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strReferFileId) 
{
CheckPrimaryKey(strReferFileId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strReferFileId,
};
 objSQL.ExecSP("ReferFiles_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strReferFileId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strReferFileId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strReferFileId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
//删除ReferFiles本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ReferFiles where ReferFileId = " + "'"+ strReferFileId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelReferFiles(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
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
//删除ReferFiles本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ReferFiles where ReferFileId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strReferFileId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strReferFileId) 
{
CheckPrimaryKey(strReferFileId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
//删除ReferFiles本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ReferFiles where ReferFileId = " + "'"+ strReferFileId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelReferFiles(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsReferFilesDA: DelReferFiles)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ReferFiles where " + strCondition ;
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
public bool DelReferFilesWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsReferFilesDA: DelReferFilesWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsReferFilesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ReferFiles where " + strCondition ;
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
 /// <param name = "objReferFilesENS">源对象</param>
 /// <param name = "objReferFilesENT">目标对象</param>
public void CopyTo(clsReferFilesEN objReferFilesENS, clsReferFilesEN objReferFilesENT)
{
objReferFilesENT.ReferFileId = objReferFilesENS.ReferFileId; //引用文件Id
objReferFilesENT.FileName = objReferFilesENS.FileName; //文件名
objReferFilesENT.ReferFileTypeId = objReferFilesENS.ReferFileTypeId; //引用文件类型Id
objReferFilesENT.FilePath = objReferFilesENS.FilePath; //文件路径
objReferFilesENT.IsNeedDownLoad = objReferFilesENS.IsNeedDownLoad; //是否需要下载
objReferFilesENT.Version = objReferFilesENS.Version; //版本
objReferFilesENT.InUse = objReferFilesENS.InUse; //是否在用
objReferFilesENT.OrderNum = objReferFilesENS.OrderNum; //序号
objReferFilesENT.UpdDate = objReferFilesENS.UpdDate; //修改日期
objReferFilesENT.UpdUserId = objReferFilesENS.UpdUserId; //修改用户Id
objReferFilesENT.Memo = objReferFilesENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsReferFilesEN objReferFilesEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objReferFilesEN.FileName, conReferFiles.FileName);
clsCheckSql.CheckFieldNotNull(objReferFilesEN.FilePath, conReferFiles.FilePath);
clsCheckSql.CheckFieldNotNull(objReferFilesEN.OrderNum, conReferFiles.OrderNum);
clsCheckSql.CheckFieldNotNull(objReferFilesEN.UpdDate, conReferFiles.UpdDate);
clsCheckSql.CheckFieldNotNull(objReferFilesEN.UpdUserId, conReferFiles.UpdUserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objReferFilesEN.ReferFileId, 8, conReferFiles.ReferFileId);
clsCheckSql.CheckFieldLen(objReferFilesEN.FileName, 150, conReferFiles.FileName);
clsCheckSql.CheckFieldLen(objReferFilesEN.ReferFileTypeId, 2, conReferFiles.ReferFileTypeId);
clsCheckSql.CheckFieldLen(objReferFilesEN.FilePath, 500, conReferFiles.FilePath);
clsCheckSql.CheckFieldLen(objReferFilesEN.Version, 30, conReferFiles.Version);
clsCheckSql.CheckFieldLen(objReferFilesEN.UpdDate, 20, conReferFiles.UpdDate);
clsCheckSql.CheckFieldLen(objReferFilesEN.UpdUserId, 20, conReferFiles.UpdUserId);
clsCheckSql.CheckFieldLen(objReferFilesEN.Memo, 1000, conReferFiles.Memo);
//检查字段外键固定长度
 objReferFilesEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsReferFilesEN objReferFilesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objReferFilesEN.FileName, 150, conReferFiles.FileName);
clsCheckSql.CheckFieldLen(objReferFilesEN.ReferFileTypeId, 2, conReferFiles.ReferFileTypeId);
clsCheckSql.CheckFieldLen(objReferFilesEN.FilePath, 500, conReferFiles.FilePath);
clsCheckSql.CheckFieldLen(objReferFilesEN.Version, 30, conReferFiles.Version);
clsCheckSql.CheckFieldLen(objReferFilesEN.UpdDate, 20, conReferFiles.UpdDate);
clsCheckSql.CheckFieldLen(objReferFilesEN.UpdUserId, 20, conReferFiles.UpdUserId);
clsCheckSql.CheckFieldLen(objReferFilesEN.Memo, 1000, conReferFiles.Memo);
//检查外键字段长度
 objReferFilesEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsReferFilesEN objReferFilesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objReferFilesEN.ReferFileId, 8, conReferFiles.ReferFileId);
clsCheckSql.CheckFieldLen(objReferFilesEN.FileName, 150, conReferFiles.FileName);
clsCheckSql.CheckFieldLen(objReferFilesEN.ReferFileTypeId, 2, conReferFiles.ReferFileTypeId);
clsCheckSql.CheckFieldLen(objReferFilesEN.FilePath, 500, conReferFiles.FilePath);
clsCheckSql.CheckFieldLen(objReferFilesEN.Version, 30, conReferFiles.Version);
clsCheckSql.CheckFieldLen(objReferFilesEN.UpdDate, 20, conReferFiles.UpdDate);
clsCheckSql.CheckFieldLen(objReferFilesEN.UpdUserId, 20, conReferFiles.UpdUserId);
clsCheckSql.CheckFieldLen(objReferFilesEN.Memo, 1000, conReferFiles.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objReferFilesEN.ReferFileId, conReferFiles.ReferFileId);
clsCheckSql.CheckSqlInjection4Field(objReferFilesEN.FileName, conReferFiles.FileName);
clsCheckSql.CheckSqlInjection4Field(objReferFilesEN.ReferFileTypeId, conReferFiles.ReferFileTypeId);
clsCheckSql.CheckSqlInjection4Field(objReferFilesEN.FilePath, conReferFiles.FilePath);
clsCheckSql.CheckSqlInjection4Field(objReferFilesEN.Version, conReferFiles.Version);
clsCheckSql.CheckSqlInjection4Field(objReferFilesEN.UpdDate, conReferFiles.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objReferFilesEN.UpdUserId, conReferFiles.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objReferFilesEN.Memo, conReferFiles.Memo);
//检查外键字段长度
 objReferFilesEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetReferFileId()
{
//获取某学院所有专业信息
string strSQL = "select ReferFileId, FileName from ReferFiles ";
 clsSpecSQLforSql mySql = clsReferFilesDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ReferFiles(引用文件),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objReferFilesEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsReferFilesEN objReferFilesEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objReferFilesEN.FileName);
 if (objReferFilesEN.ReferFileTypeId == null)
{
 sbCondition.AppendFormat(" and ReferFileTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and ReferFileTypeId = '{0}'", objReferFilesEN.ReferFileTypeId);
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
 objSQL = clsReferFilesDA.GetSpecSQLObj();
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
 objSQL = clsReferFilesDA.GetSpecSQLObj();
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
 objSQL = clsReferFilesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsReferFilesEN._CurrTabName);
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
 objSQL = clsReferFilesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsReferFilesEN._CurrTabName, strCondition);
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
 objSQL = clsReferFilesDA.GetSpecSQLObj();
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
 objSQL = clsReferFilesDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}