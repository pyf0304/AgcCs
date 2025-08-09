
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewReferFilesDA
 表名:vViewReferFiles(00050466)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:40
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
 /// v界面引用文件(vViewReferFiles)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewReferFilesDA : clsCommBase4DA
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
 return clsvViewReferFilesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewReferFilesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewReferFilesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewReferFilesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewReferFilesEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vViewReferFiles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewReferFiles(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewReferFilesDA: GetDataTable_vViewReferFiles)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vViewReferFiles where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vViewReferFiles where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewReferFilesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewReferFilesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewReferFiles where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewReferFiles where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewReferFilesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewReferFiles where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewReferFilesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewReferFiles.* " + 
$"from vViewReferFiles " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewReferFiles.mId not in " + 
$"(Select top {intTop_In} vViewReferFiles.mId from vViewReferFiles " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewReferFiles where {1} and mId not in (Select top {2} mId from vViewReferFiles where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewReferFiles where {1} and mId not in (Select top {3} mId from vViewReferFiles where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewReferFilesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewReferFiles.* " + 
$"from vViewReferFiles " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewReferFiles.mId not in " + 
$"(Select top {intTop_In} vViewReferFiles.mId from vViewReferFiles " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewReferFiles where {1} and mId not in (Select top {2} mId from vViewReferFiles where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewReferFiles where {1} and mId not in (Select top {3} mId from vViewReferFiles where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewReferFilesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewReferFilesDA:GetObjLst)", objException.Message));
}
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vViewReferFiles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = TransNullToInt(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = TransNullToBool(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = TransNullToInt(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = TransNullToBool(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewReferFilesDA: GetObjLst)", objException.Message));
}
objvViewReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewReferFilesEN);
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
public List<clsvViewReferFilesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewReferFilesDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = TransNullToInt(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = TransNullToBool(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = TransNullToInt(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = TransNullToBool(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewReferFilesDA: GetObjLst)", objException.Message));
}
objvViewReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewReferFilesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewReferFiles(ref clsvViewReferFilesEN objvViewReferFilesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vViewReferFiles where mId = " + ""+ objvViewReferFilesEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewReferFilesEN.mId = TransNullToInt(objDT.Rows[0][convViewReferFiles.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvViewReferFilesEN.ViewId = objDT.Rows[0][convViewReferFiles.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewReferFilesEN.ViewName = objDT.Rows[0][convViewReferFiles.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewReferFilesEN.PrjId = objDT.Rows[0][convViewReferFiles.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewReferFilesEN.CodeTypeId = objDT.Rows[0][convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewReferFilesEN.CodeTypeName = objDT.Rows[0][convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewReferFilesEN.ReferFileId = objDT.Rows[0][convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewReferFilesEN.FileName = objDT.Rows[0][convViewReferFiles.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvViewReferFilesEN.ReferFileTypeId = objDT.Rows[0][convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvViewReferFilesEN.ReferFileTypeName = objDT.Rows[0][convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewReferFilesEN.FilePath = objDT.Rows[0][convViewReferFiles.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewReferFilesEN.InUse = TransNullToBool(objDT.Rows[0][convViewReferFiles.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvViewReferFilesEN.OrderNum = TransNullToInt(objDT.Rows[0][convViewReferFiles.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvViewReferFilesEN.IsTemplate = TransNullToBool(objDT.Rows[0][convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvViewReferFilesEN.UpdDate = objDT.Rows[0][convViewReferFiles.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewReferFilesEN.UpdUserId = objDT.Rows[0][convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewReferFilesEN.Memo = objDT.Rows[0][convViewReferFiles.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewReferFilesDA: GetvViewReferFiles)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewReferFilesEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vViewReferFiles where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
 objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewReferFilesDA: GetObjBymId)", objException.Message));
}
return objvViewReferFilesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewReferFilesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewReferFilesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
strSQL = "Select * from vViewReferFiles where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN()
{
mId = TransNullToInt(objRow[convViewReferFiles.mId].ToString().Trim()), //mId
ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(), //界面Id
ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(), //界面名称
PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(), //工程Id
CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(), //代码类型名
ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(), //引用文件Id
FileName = objRow[convViewReferFiles.FileName].ToString().Trim(), //文件名
ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(), //引用文件类型Id
ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(), //引用文件类型名
FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(), //文件路径
InUse = TransNullToBool(objRow[convViewReferFiles.InUse].ToString().Trim()), //是否在用
OrderNum = TransNullToInt(objRow[convViewReferFiles.OrderNum].ToString().Trim()), //序号
IsTemplate = TransNullToBool(objRow[convViewReferFiles.IsTemplate].ToString().Trim()), //是否模板
UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim() //说明
};
objvViewReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewReferFilesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewReferFilesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewReferFilesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = TransNullToInt(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = TransNullToBool(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = TransNullToInt(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = TransNullToBool(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewReferFilesDA: GetObjByDataRowvViewReferFiles)", objException.Message));
}
objvViewReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewReferFilesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewReferFilesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = TransNullToInt(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = TransNullToBool(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = TransNullToInt(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = TransNullToBool(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewReferFilesDA: GetObjByDataRow)", objException.Message));
}
objvViewReferFilesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewReferFilesEN;
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
objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewReferFilesEN._CurrTabName, convViewReferFiles.mId, 8, "");
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
objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewReferFilesEN._CurrTabName, convViewReferFiles.mId, 8, strPrefix);
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
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vViewReferFiles where " + strCondition;
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
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vViewReferFiles where " + strCondition;
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
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewReferFiles", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewReferFilesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewReferFiles", strCondition))
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
objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewReferFiles");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewReferFilesENS">源对象</param>
 /// <param name = "objvViewReferFilesENT">目标对象</param>
public void CopyTo(clsvViewReferFilesEN objvViewReferFilesENS, clsvViewReferFilesEN objvViewReferFilesENT)
{
objvViewReferFilesENT.mId = objvViewReferFilesENS.mId; //mId
objvViewReferFilesENT.ViewId = objvViewReferFilesENS.ViewId; //界面Id
objvViewReferFilesENT.ViewName = objvViewReferFilesENS.ViewName; //界面名称
objvViewReferFilesENT.PrjId = objvViewReferFilesENS.PrjId; //工程Id
objvViewReferFilesENT.CodeTypeId = objvViewReferFilesENS.CodeTypeId; //代码类型Id
objvViewReferFilesENT.CodeTypeName = objvViewReferFilesENS.CodeTypeName; //代码类型名
objvViewReferFilesENT.ReferFileId = objvViewReferFilesENS.ReferFileId; //引用文件Id
objvViewReferFilesENT.FileName = objvViewReferFilesENS.FileName; //文件名
objvViewReferFilesENT.ReferFileTypeId = objvViewReferFilesENS.ReferFileTypeId; //引用文件类型Id
objvViewReferFilesENT.ReferFileTypeName = objvViewReferFilesENS.ReferFileTypeName; //引用文件类型名
objvViewReferFilesENT.FilePath = objvViewReferFilesENS.FilePath; //文件路径
objvViewReferFilesENT.InUse = objvViewReferFilesENS.InUse; //是否在用
objvViewReferFilesENT.OrderNum = objvViewReferFilesENS.OrderNum; //序号
objvViewReferFilesENT.IsTemplate = objvViewReferFilesENS.IsTemplate; //是否模板
objvViewReferFilesENT.UpdDate = objvViewReferFilesENS.UpdDate; //修改日期
objvViewReferFilesENT.UpdUserId = objvViewReferFilesENS.UpdUserId; //修改用户Id
objvViewReferFilesENT.Memo = objvViewReferFilesENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewReferFilesEN objvViewReferFilesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.ViewId, 8, convViewReferFiles.ViewId);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.ViewName, 100, convViewReferFiles.ViewName);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.PrjId, 4, convViewReferFiles.PrjId);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.CodeTypeId, 4, convViewReferFiles.CodeTypeId);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.CodeTypeName, 50, convViewReferFiles.CodeTypeName);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.ReferFileId, 8, convViewReferFiles.ReferFileId);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.FileName, 150, convViewReferFiles.FileName);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.ReferFileTypeId, 2, convViewReferFiles.ReferFileTypeId);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.ReferFileTypeName, 50, convViewReferFiles.ReferFileTypeName);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.FilePath, 500, convViewReferFiles.FilePath);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.UpdDate, 20, convViewReferFiles.UpdDate);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.UpdUserId, 20, convViewReferFiles.UpdUserId);
clsCheckSql.CheckFieldLen(objvViewReferFilesEN.Memo, 1000, convViewReferFiles.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.ViewId, convViewReferFiles.ViewId);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.ViewName, convViewReferFiles.ViewName);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.PrjId, convViewReferFiles.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.CodeTypeId, convViewReferFiles.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.CodeTypeName, convViewReferFiles.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.ReferFileId, convViewReferFiles.ReferFileId);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.FileName, convViewReferFiles.FileName);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.ReferFileTypeId, convViewReferFiles.ReferFileTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.ReferFileTypeName, convViewReferFiles.ReferFileTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.FilePath, convViewReferFiles.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.UpdDate, convViewReferFiles.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.UpdUserId, convViewReferFiles.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvViewReferFilesEN.Memo, convViewReferFiles.Memo);
//检查外键字段长度
 objvViewReferFilesEN._IsCheckProperty = true;
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
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
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
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
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
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewReferFilesEN._CurrTabName);
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
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewReferFilesEN._CurrTabName, strCondition);
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
 objSQL = clsvViewReferFilesDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}