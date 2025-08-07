
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvReferFilesDA
 表名:vReferFiles(00050461)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:14
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
 /// v引用文件(vReferFiles)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvReferFilesDA : clsCommBase4DA
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
 return clsvReferFilesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvReferFilesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvReferFilesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvReferFilesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvReferFilesEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vReferFiles中,检查关键字,长度不正确!(clsvReferFilesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strReferFileId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vReferFiles中,关键字不能为空 或 null!(clsvReferFilesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReferFileId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvReferFilesDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vReferFiles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vReferFiles(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvReferFilesDA: GetDataTable_vReferFiles)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vReferFiles where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vReferFiles where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvReferFilesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vReferFiles where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vReferFiles where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvReferFilesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vReferFiles where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvReferFilesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vReferFiles.* " + 
$"from vReferFiles " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vReferFiles.ReferFileId not in " + 
$"(Select top {intTop_In} vReferFiles.ReferFileId from vReferFiles " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vReferFiles where {1} and ReferFileId not in (Select top {2} ReferFileId from vReferFiles where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vReferFiles where {1} and ReferFileId not in (Select top {3} ReferFileId from vReferFiles where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvReferFilesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vReferFiles.* " + 
$"from vReferFiles " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vReferFiles.ReferFileId not in " + 
$"(Select top {intTop_In} vReferFiles.ReferFileId from vReferFiles " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vReferFiles where {1} and ReferFileId not in (Select top {2} ReferFileId from vReferFiles where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vReferFiles where {1} and ReferFileId not in (Select top {3} ReferFileId from vReferFiles where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvReferFilesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvReferFilesDA:GetObjLst)", objException.Message));
}
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vReferFiles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = TransNullToBool(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = TransNullToBool(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = TransNullToInt(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvReferFilesDA: GetObjLst)", objException.Message));
}
objvReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvReferFilesEN);
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
public List<clsvReferFilesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvReferFilesDA:GetObjLstByTabName)", objException.Message));
}
List<clsvReferFilesEN> arrObjLst = new List<clsvReferFilesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = TransNullToBool(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = TransNullToBool(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = TransNullToInt(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvReferFilesDA: GetObjLst)", objException.Message));
}
objvReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvReferFilesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvReferFiles(ref clsvReferFilesEN objvReferFilesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vReferFiles where ReferFileId = " + "'"+ objvReferFilesEN.ReferFileId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvReferFilesEN.ReferFileId = objDT.Rows[0][convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id(字段类型:char,字段长度:8,是否可空:True)
 objvReferFilesEN.FileName = objDT.Rows[0][convReferFiles.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvReferFilesEN.ReferFileTypeId = objDT.Rows[0][convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvReferFilesEN.ReferFileTypeName = objDT.Rows[0][convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvReferFilesEN.FilePath = objDT.Rows[0][convReferFiles.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvReferFilesEN.IsNeedDownLoad = TransNullToBool(objDT.Rows[0][convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载(字段类型:bit,字段长度:1,是否可空:False)
 objvReferFilesEN.Version = objDT.Rows[0][convReferFiles.Version].ToString().Trim(); //版本(字段类型:varchar,字段长度:30,是否可空:False)
 objvReferFilesEN.InUse = TransNullToBool(objDT.Rows[0][convReferFiles.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvReferFilesEN.OrderNum = TransNullToInt(objDT.Rows[0][convReferFiles.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvReferFilesEN.UpdDate = objDT.Rows[0][convReferFiles.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvReferFilesEN.UpdUserId = objDT.Rows[0][convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvReferFilesEN.Memo = objDT.Rows[0][convReferFiles.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvReferFilesDA: GetvReferFiles)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReferFileId">表关键字</param>
 /// <returns>表对象</returns>
public clsvReferFilesEN GetObjByReferFileId(string strReferFileId)
{
CheckPrimaryKey(strReferFileId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vReferFiles where ReferFileId = " + "'"+ strReferFileId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
 objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id(字段类型:char,字段长度:8,是否可空:True)
 objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载(字段类型:bit,字段长度:1,是否可空:False)
 objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本(字段类型:varchar,字段长度:30,是否可空:False)
 objvReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvReferFilesEN.OrderNum = Int32.Parse(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvReferFilesDA: GetObjByReferFileId)", objException.Message));
}
return objvReferFilesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvReferFilesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvReferFilesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vReferFiles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN()
{
ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(), //引用文件Id
FileName = objRow[convReferFiles.FileName].ToString().Trim(), //文件名
ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(), //引用文件类型Id
ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(), //引用文件类型名
FilePath = objRow[convReferFiles.FilePath].ToString().Trim(), //文件路径
IsNeedDownLoad = TransNullToBool(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()), //是否需要下载
Version = objRow[convReferFiles.Version].ToString().Trim(), //版本
InUse = TransNullToBool(objRow[convReferFiles.InUse].ToString().Trim()), //是否在用
OrderNum = TransNullToInt(objRow[convReferFiles.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim() //说明
};
objvReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvReferFilesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvReferFilesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvReferFilesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = TransNullToBool(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = TransNullToBool(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = TransNullToInt(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvReferFilesDA: GetObjByDataRowvReferFiles)", objException.Message));
}
objvReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvReferFilesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvReferFilesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvReferFilesEN objvReferFilesEN = new clsvReferFilesEN();
try
{
objvReferFilesEN.ReferFileId = objRow[convReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvReferFilesEN.FileName = objRow[convReferFiles.FileName].ToString().Trim(); //文件名
objvReferFilesEN.ReferFileTypeId = objRow[convReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvReferFilesEN.ReferFileTypeName = objRow[convReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvReferFilesEN.FilePath = objRow[convReferFiles.FilePath].ToString().Trim(); //文件路径
objvReferFilesEN.IsNeedDownLoad = TransNullToBool(objRow[convReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objvReferFilesEN.Version = objRow[convReferFiles.Version].ToString().Trim(); //版本
objvReferFilesEN.InUse = TransNullToBool(objRow[convReferFiles.InUse].ToString().Trim()); //是否在用
objvReferFilesEN.OrderNum = TransNullToInt(objRow[convReferFiles.OrderNum].ToString().Trim()); //序号
objvReferFilesEN.UpdDate = objRow[convReferFiles.UpdDate] == DBNull.Value ? null : objRow[convReferFiles.UpdDate].ToString().Trim(); //修改日期
objvReferFilesEN.UpdUserId = objRow[convReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvReferFilesEN.Memo = objRow[convReferFiles.Memo] == DBNull.Value ? null : objRow[convReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvReferFilesDA: GetObjByDataRow)", objException.Message));
}
objvReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvReferFilesEN;
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
objSQL = clsvReferFilesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvReferFilesEN._CurrTabName, convReferFiles.ReferFileId, 8, "");
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
objSQL = clsvReferFilesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvReferFilesEN._CurrTabName, convReferFiles.ReferFileId, 8, strPrefix);
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
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ReferFileId from vReferFiles where " + strCondition;
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
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ReferFileId from vReferFiles where " + strCondition;
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
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vReferFiles", "ReferFileId = " + "'"+ strReferFileId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvReferFilesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vReferFiles", strCondition))
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
objSQL = clsvReferFilesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vReferFiles");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvReferFilesENS">源对象</param>
 /// <param name = "objvReferFilesENT">目标对象</param>
public void CopyTo(clsvReferFilesEN objvReferFilesENS, clsvReferFilesEN objvReferFilesENT)
{
objvReferFilesENT.ReferFileId = objvReferFilesENS.ReferFileId; //引用文件Id
objvReferFilesENT.FileName = objvReferFilesENS.FileName; //文件名
objvReferFilesENT.ReferFileTypeId = objvReferFilesENS.ReferFileTypeId; //引用文件类型Id
objvReferFilesENT.ReferFileTypeName = objvReferFilesENS.ReferFileTypeName; //引用文件类型名
objvReferFilesENT.FilePath = objvReferFilesENS.FilePath; //文件路径
objvReferFilesENT.IsNeedDownLoad = objvReferFilesENS.IsNeedDownLoad; //是否需要下载
objvReferFilesENT.Version = objvReferFilesENS.Version; //版本
objvReferFilesENT.InUse = objvReferFilesENS.InUse; //是否在用
objvReferFilesENT.OrderNum = objvReferFilesENS.OrderNum; //序号
objvReferFilesENT.UpdDate = objvReferFilesENS.UpdDate; //修改日期
objvReferFilesENT.UpdUserId = objvReferFilesENS.UpdUserId; //修改用户Id
objvReferFilesENT.Memo = objvReferFilesENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvReferFilesEN objvReferFilesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvReferFilesEN.ReferFileId, 8, convReferFiles.ReferFileId);
clsCheckSql.CheckFieldLen(objvReferFilesEN.FileName, 150, convReferFiles.FileName);
clsCheckSql.CheckFieldLen(objvReferFilesEN.ReferFileTypeId, 2, convReferFiles.ReferFileTypeId);
clsCheckSql.CheckFieldLen(objvReferFilesEN.ReferFileTypeName, 50, convReferFiles.ReferFileTypeName);
clsCheckSql.CheckFieldLen(objvReferFilesEN.FilePath, 500, convReferFiles.FilePath);
clsCheckSql.CheckFieldLen(objvReferFilesEN.Version, 30, convReferFiles.Version);
clsCheckSql.CheckFieldLen(objvReferFilesEN.UpdDate, 20, convReferFiles.UpdDate);
clsCheckSql.CheckFieldLen(objvReferFilesEN.UpdUserId, 20, convReferFiles.UpdUserId);
clsCheckSql.CheckFieldLen(objvReferFilesEN.Memo, 1000, convReferFiles.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvReferFilesEN.ReferFileId, convReferFiles.ReferFileId);
clsCheckSql.CheckSqlInjection4Field(objvReferFilesEN.FileName, convReferFiles.FileName);
clsCheckSql.CheckSqlInjection4Field(objvReferFilesEN.ReferFileTypeId, convReferFiles.ReferFileTypeId);
clsCheckSql.CheckSqlInjection4Field(objvReferFilesEN.ReferFileTypeName, convReferFiles.ReferFileTypeName);
clsCheckSql.CheckSqlInjection4Field(objvReferFilesEN.FilePath, convReferFiles.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvReferFilesEN.Version, convReferFiles.Version);
clsCheckSql.CheckSqlInjection4Field(objvReferFilesEN.UpdDate, convReferFiles.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvReferFilesEN.UpdUserId, convReferFiles.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvReferFilesEN.Memo, convReferFiles.Memo);
//检查外键字段长度
 objvReferFilesEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vReferFiles(v引用文件),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvReferFilesEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvReferFilesEN objvReferFilesEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objvReferFilesEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objvReferFilesEN.FilePath);
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
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
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
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
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
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvReferFilesEN._CurrTabName);
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
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvReferFilesEN._CurrTabName, strCondition);
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
 objSQL = clsvReferFilesDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}