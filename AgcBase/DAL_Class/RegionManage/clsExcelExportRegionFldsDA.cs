
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExcelExportRegionFldsDA
 表名:ExcelExportRegionFlds(00050149)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:55
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
 /// Excel导出区域字段(ExcelExportRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsExcelExportRegionFldsDA : clsCommBase4DA
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
 return clsExcelExportRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsExcelExportRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsExcelExportRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsExcelExportRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsExcelExportRegionFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from ExcelExportRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ExcelExportRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: GetDataTable_ExcelExportRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from ExcelExportRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from ExcelExportRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ExcelExportRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ExcelExportRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ExcelExportRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ExcelExportRegionFlds.* " + 
$"from ExcelExportRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ExcelExportRegionFlds.mId not in " + 
$"(Select top {intTop_In} ExcelExportRegionFlds.mId from ExcelExportRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ExcelExportRegionFlds where {1} and mId not in (Select top {2} mId from ExcelExportRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ExcelExportRegionFlds where {1} and mId not in (Select top {3} mId from ExcelExportRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ExcelExportRegionFlds.* " + 
$"from ExcelExportRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ExcelExportRegionFlds.mId not in " + 
$"(Select top {intTop_In} ExcelExportRegionFlds.mId from ExcelExportRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ExcelExportRegionFlds where {1} and mId not in (Select top {2} mId from ExcelExportRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ExcelExportRegionFlds where {1} and mId not in (Select top {3} mId from ExcelExportRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsExcelExportRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from ExcelExportRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = TransNullToInt(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = TransNullToInt(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = TransNullToBool(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = TransNullToBool(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsExcelExportRegionFldsDA: GetObjLst)", objException.Message));
}
objExcelExportRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objExcelExportRegionFldsEN);
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
public List<clsExcelExportRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = TransNullToInt(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = TransNullToInt(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = TransNullToBool(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = TransNullToBool(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsExcelExportRegionFldsDA: GetObjLst)", objException.Message));
}
objExcelExportRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objExcelExportRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetExcelExportRegionFlds(ref clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from ExcelExportRegionFlds where mId = " + ""+ objExcelExportRegionFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objExcelExportRegionFldsEN.mId = TransNullToInt(objDT.Rows[0][conExcelExportRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objExcelExportRegionFldsEN.RegionId = objDT.Rows[0][conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objExcelExportRegionFldsEN.FldId = objDT.Rows[0][conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objExcelExportRegionFldsEN.OutFldId = objDT.Rows[0][conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId(字段类型:char,字段长度:8,是否可空:True)
 objExcelExportRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objExcelExportRegionFldsEN.ColCaption = objDT.Rows[0][conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题(字段类型:varchar,字段长度:100,是否可空:True)
 objExcelExportRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objExcelExportRegionFldsEN.ErrMsg = objDT.Rows[0][conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objExcelExportRegionFldsEN.PrjId = objDT.Rows[0][conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objExcelExportRegionFldsEN.UpdDate = objDT.Rows[0][conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objExcelExportRegionFldsEN.UpdUser = objDT.Rows[0][conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objExcelExportRegionFldsEN.Memo = objDT.Rows[0][conExcelExportRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objExcelExportRegionFldsEN.IsDefaultSort = TransNullToBool(objDT.Rows[0][conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序(字段类型:bit,字段长度:1,是否可空:False)
 objExcelExportRegionFldsEN.IsNeedSort = TransNullToBool(objDT.Rows[0][conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsExcelExportRegionFldsDA: GetExcelExportRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsExcelExportRegionFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from ExcelExportRegionFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
 objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId(字段类型:char,字段长度:8,是否可空:True)
 objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题(字段类型:varchar,字段长度:100,是否可空:True)
 objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序(字段类型:bit,字段长度:1,是否可空:False)
 objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsExcelExportRegionFldsDA: GetObjBymId)", objException.Message));
}
return objExcelExportRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsExcelExportRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from ExcelExportRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN()
{
mId = TransNullToInt(objRow[conExcelExportRegionFlds.mId].ToString().Trim()), //mId
RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(), //区域Id
FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(), //字段Id
OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(), //OutFldId
SeqNum = TransNullToInt(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()), //字段序号
ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(), //列标题
InUse = TransNullToBool(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()), //是否在用
ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(), //说明
IsDefaultSort = TransNullToBool(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()), //是否默认排序
IsNeedSort = TransNullToBool(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()) //是否需要排序
};
objExcelExportRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objExcelExportRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsExcelExportRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsExcelExportRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = TransNullToInt(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = TransNullToInt(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = TransNullToBool(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = TransNullToBool(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsExcelExportRegionFldsDA: GetObjByDataRowExcelExportRegionFlds)", objException.Message));
}
objExcelExportRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objExcelExportRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsExcelExportRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = TransNullToInt(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = TransNullToInt(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = TransNullToBool(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = TransNullToBool(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsExcelExportRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objExcelExportRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objExcelExportRegionFldsEN;
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
objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsExcelExportRegionFldsEN._CurrTabName, conExcelExportRegionFlds.mId, 8, "");
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
objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsExcelExportRegionFldsEN._CurrTabName, conExcelExportRegionFlds.mId, 8, strPrefix);
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
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ExcelExportRegionFlds where " + strCondition;
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
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ExcelExportRegionFlds where " + strCondition;
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
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ExcelExportRegionFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ExcelExportRegionFlds", strCondition))
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
objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ExcelExportRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
 {
 objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExcelExportRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExcelExportRegionFldsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from ExcelExportRegionFlds where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ExcelExportRegionFlds");
objRow = objDS.Tables["ExcelExportRegionFlds"].NewRow();
objRow[conExcelExportRegionFlds.RegionId] = objExcelExportRegionFldsEN.RegionId; //区域Id
 if (objExcelExportRegionFldsEN.FldId !=  "")
 {
objRow[conExcelExportRegionFlds.FldId] = objExcelExportRegionFldsEN.FldId; //字段Id
 }
 if (objExcelExportRegionFldsEN.OutFldId !=  "")
 {
objRow[conExcelExportRegionFlds.OutFldId] = objExcelExportRegionFldsEN.OutFldId; //OutFldId
 }
objRow[conExcelExportRegionFlds.SeqNum] = objExcelExportRegionFldsEN.SeqNum; //字段序号
 if (objExcelExportRegionFldsEN.ColCaption !=  "")
 {
objRow[conExcelExportRegionFlds.ColCaption] = objExcelExportRegionFldsEN.ColCaption; //列标题
 }
objRow[conExcelExportRegionFlds.InUse] = objExcelExportRegionFldsEN.InUse; //是否在用
 if (objExcelExportRegionFldsEN.ErrMsg !=  "")
 {
objRow[conExcelExportRegionFlds.ErrMsg] = objExcelExportRegionFldsEN.ErrMsg; //错误信息
 }
objRow[conExcelExportRegionFlds.PrjId] = objExcelExportRegionFldsEN.PrjId; //工程Id
 if (objExcelExportRegionFldsEN.UpdDate !=  "")
 {
objRow[conExcelExportRegionFlds.UpdDate] = objExcelExportRegionFldsEN.UpdDate; //修改日期
 }
objRow[conExcelExportRegionFlds.UpdUser] = objExcelExportRegionFldsEN.UpdUser; //修改者
 if (objExcelExportRegionFldsEN.Memo !=  "")
 {
objRow[conExcelExportRegionFlds.Memo] = objExcelExportRegionFldsEN.Memo; //说明
 }
objRow[conExcelExportRegionFlds.IsDefaultSort] = objExcelExportRegionFldsEN.IsDefaultSort; //是否默认排序
objRow[conExcelExportRegionFlds.IsNeedSort] = objExcelExportRegionFldsEN.IsNeedSort; //是否需要排序
objDS.Tables[clsExcelExportRegionFldsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsExcelExportRegionFldsEN._CurrTabName);
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
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExcelExportRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExcelExportRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objExcelExportRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.RegionId);
 var strRegionId = objExcelExportRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objExcelExportRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.FldId);
 var strFldId = objExcelExportRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objExcelExportRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.OutFldId);
 var strOutFldId = objExcelExportRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.SeqNum);
 arrValueListForInsert.Add(objExcelExportRegionFldsEN.SeqNum.ToString());
 
 if (objExcelExportRegionFldsEN.ColCaption !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.ColCaption);
 var strColCaption = objExcelExportRegionFldsEN.ColCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColCaption + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objExcelExportRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.ErrMsg);
 var strErrMsg = objExcelExportRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objExcelExportRegionFldsEN.PrjId  ==  "")
 {
 objExcelExportRegionFldsEN.PrjId = null;
 }
 if (objExcelExportRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.PrjId);
 var strPrjId = objExcelExportRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objExcelExportRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.UpdDate);
 var strUpdDate = objExcelExportRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExcelExportRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.UpdUser);
 var strUpdUser = objExcelExportRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objExcelExportRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.Memo);
 var strMemo = objExcelExportRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.IsDefaultSort);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.IsDefaultSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.IsNeedSort);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExcelExportRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExcelExportRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExcelExportRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objExcelExportRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.RegionId);
 var strRegionId = objExcelExportRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objExcelExportRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.FldId);
 var strFldId = objExcelExportRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objExcelExportRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.OutFldId);
 var strOutFldId = objExcelExportRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.SeqNum);
 arrValueListForInsert.Add(objExcelExportRegionFldsEN.SeqNum.ToString());
 
 if (objExcelExportRegionFldsEN.ColCaption !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.ColCaption);
 var strColCaption = objExcelExportRegionFldsEN.ColCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColCaption + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objExcelExportRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.ErrMsg);
 var strErrMsg = objExcelExportRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objExcelExportRegionFldsEN.PrjId  ==  "")
 {
 objExcelExportRegionFldsEN.PrjId = null;
 }
 if (objExcelExportRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.PrjId);
 var strPrjId = objExcelExportRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objExcelExportRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.UpdDate);
 var strUpdDate = objExcelExportRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExcelExportRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.UpdUser);
 var strUpdUser = objExcelExportRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objExcelExportRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.Memo);
 var strMemo = objExcelExportRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.IsDefaultSort);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.IsDefaultSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.IsNeedSort);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExcelExportRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExcelExportRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExcelExportRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objExcelExportRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.RegionId);
 var strRegionId = objExcelExportRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objExcelExportRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.FldId);
 var strFldId = objExcelExportRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objExcelExportRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.OutFldId);
 var strOutFldId = objExcelExportRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.SeqNum);
 arrValueListForInsert.Add(objExcelExportRegionFldsEN.SeqNum.ToString());
 
 if (objExcelExportRegionFldsEN.ColCaption !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.ColCaption);
 var strColCaption = objExcelExportRegionFldsEN.ColCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColCaption + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objExcelExportRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.ErrMsg);
 var strErrMsg = objExcelExportRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objExcelExportRegionFldsEN.PrjId  ==  "")
 {
 objExcelExportRegionFldsEN.PrjId = null;
 }
 if (objExcelExportRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.PrjId);
 var strPrjId = objExcelExportRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objExcelExportRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.UpdDate);
 var strUpdDate = objExcelExportRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExcelExportRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.UpdUser);
 var strUpdUser = objExcelExportRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objExcelExportRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.Memo);
 var strMemo = objExcelExportRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.IsDefaultSort);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.IsDefaultSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.IsNeedSort);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExcelExportRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExcelExportRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExcelExportRegionFldsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objExcelExportRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.RegionId);
 var strRegionId = objExcelExportRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objExcelExportRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.FldId);
 var strFldId = objExcelExportRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objExcelExportRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.OutFldId);
 var strOutFldId = objExcelExportRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.SeqNum);
 arrValueListForInsert.Add(objExcelExportRegionFldsEN.SeqNum.ToString());
 
 if (objExcelExportRegionFldsEN.ColCaption !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.ColCaption);
 var strColCaption = objExcelExportRegionFldsEN.ColCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColCaption + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objExcelExportRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.ErrMsg);
 var strErrMsg = objExcelExportRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objExcelExportRegionFldsEN.PrjId  ==  "")
 {
 objExcelExportRegionFldsEN.PrjId = null;
 }
 if (objExcelExportRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.PrjId);
 var strPrjId = objExcelExportRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objExcelExportRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.UpdDate);
 var strUpdDate = objExcelExportRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExcelExportRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.UpdUser);
 var strUpdUser = objExcelExportRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objExcelExportRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExcelExportRegionFlds.Memo);
 var strMemo = objExcelExportRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.IsDefaultSort);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.IsDefaultSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conExcelExportRegionFlds.IsNeedSort);
 arrValueListForInsert.Add("'" + (objExcelExportRegionFldsEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExcelExportRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewExcelExportRegionFldss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from ExcelExportRegionFlds where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ExcelExportRegionFlds");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conExcelExportRegionFlds.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsExcelExportRegionFldsEN._CurrTabName ].NewRow();
objRow[conExcelExportRegionFlds.RegionId] = oRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objRow[conExcelExportRegionFlds.FldId] = oRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objRow[conExcelExportRegionFlds.OutFldId] = oRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objRow[conExcelExportRegionFlds.SeqNum] = oRow[conExcelExportRegionFlds.SeqNum].ToString().Trim(); //字段序号
objRow[conExcelExportRegionFlds.ColCaption] = oRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objRow[conExcelExportRegionFlds.InUse] = oRow[conExcelExportRegionFlds.InUse].ToString().Trim(); //是否在用
objRow[conExcelExportRegionFlds.ErrMsg] = oRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objRow[conExcelExportRegionFlds.PrjId] = oRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objRow[conExcelExportRegionFlds.UpdDate] = oRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objRow[conExcelExportRegionFlds.UpdUser] = oRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objRow[conExcelExportRegionFlds.Memo] = oRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objRow[conExcelExportRegionFlds.IsDefaultSort] = oRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim(); //是否默认排序
objRow[conExcelExportRegionFlds.IsNeedSort] = oRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim(); //是否需要排序
 objDS.Tables[clsExcelExportRegionFldsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsExcelExportRegionFldsEN._CurrTabName);
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
 /// <param name = "objExcelExportRegionFldsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExcelExportRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExcelExportRegionFldsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from ExcelExportRegionFlds where mId = " + ""+ objExcelExportRegionFldsEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsExcelExportRegionFldsEN._CurrTabName);
if (objDS.Tables[clsExcelExportRegionFldsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objExcelExportRegionFldsEN.mId+"");
return false;
}
objRow = objDS.Tables[clsExcelExportRegionFldsEN._CurrTabName].Rows[0];
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.RegionId))
 {
objRow[conExcelExportRegionFlds.RegionId] = objExcelExportRegionFldsEN.RegionId; //区域Id
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.FldId))
 {
objRow[conExcelExportRegionFlds.FldId] = objExcelExportRegionFldsEN.FldId; //字段Id
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.OutFldId))
 {
objRow[conExcelExportRegionFlds.OutFldId] = objExcelExportRegionFldsEN.OutFldId; //OutFldId
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.SeqNum))
 {
objRow[conExcelExportRegionFlds.SeqNum] = objExcelExportRegionFldsEN.SeqNum; //字段序号
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.ColCaption))
 {
objRow[conExcelExportRegionFlds.ColCaption] = objExcelExportRegionFldsEN.ColCaption; //列标题
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.InUse))
 {
objRow[conExcelExportRegionFlds.InUse] = objExcelExportRegionFldsEN.InUse; //是否在用
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.ErrMsg))
 {
objRow[conExcelExportRegionFlds.ErrMsg] = objExcelExportRegionFldsEN.ErrMsg; //错误信息
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.PrjId))
 {
objRow[conExcelExportRegionFlds.PrjId] = objExcelExportRegionFldsEN.PrjId; //工程Id
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.UpdDate))
 {
objRow[conExcelExportRegionFlds.UpdDate] = objExcelExportRegionFldsEN.UpdDate; //修改日期
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.UpdUser))
 {
objRow[conExcelExportRegionFlds.UpdUser] = objExcelExportRegionFldsEN.UpdUser; //修改者
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.Memo))
 {
objRow[conExcelExportRegionFlds.Memo] = objExcelExportRegionFldsEN.Memo; //说明
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.IsDefaultSort))
 {
objRow[conExcelExportRegionFlds.IsDefaultSort] = objExcelExportRegionFldsEN.IsDefaultSort; //是否默认排序
 }
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.IsNeedSort))
 {
objRow[conExcelExportRegionFlds.IsNeedSort] = objExcelExportRegionFldsEN.IsNeedSort; //是否需要排序
 }
try
{
objDA.Update(objDS, clsExcelExportRegionFldsEN._CurrTabName);
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
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExcelExportRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExcelExportRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ExcelExportRegionFlds Set ");
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.RegionId))
 {
 if (objExcelExportRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objExcelExportRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conExcelExportRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.FldId))
 {
 if (objExcelExportRegionFldsEN.FldId !=  null)
 {
 var strFldId = objExcelExportRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conExcelExportRegionFlds.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.FldId); //字段Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.OutFldId))
 {
 if (objExcelExportRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objExcelExportRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldId, conExcelExportRegionFlds.OutFldId); //OutFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.OutFldId); //OutFldId
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.SeqNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objExcelExportRegionFldsEN.SeqNum, conExcelExportRegionFlds.SeqNum); //字段序号
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.ColCaption))
 {
 if (objExcelExportRegionFldsEN.ColCaption !=  null)
 {
 var strColCaption = objExcelExportRegionFldsEN.ColCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strColCaption, conExcelExportRegionFlds.ColCaption); //列标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.ColCaption); //列标题
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objExcelExportRegionFldsEN.InUse == true?"1":"0", conExcelExportRegionFlds.InUse); //是否在用
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.ErrMsg))
 {
 if (objExcelExportRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objExcelExportRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conExcelExportRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.PrjId))
 {
 if (objExcelExportRegionFldsEN.PrjId  ==  "")
 {
 objExcelExportRegionFldsEN.PrjId = null;
 }
 if (objExcelExportRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objExcelExportRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conExcelExportRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.UpdDate))
 {
 if (objExcelExportRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objExcelExportRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conExcelExportRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.UpdUser))
 {
 if (objExcelExportRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objExcelExportRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conExcelExportRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.Memo))
 {
 if (objExcelExportRegionFldsEN.Memo !=  null)
 {
 var strMemo = objExcelExportRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conExcelExportRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.Memo); //说明
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.IsDefaultSort))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objExcelExportRegionFldsEN.IsDefaultSort == true?"1":"0", conExcelExportRegionFlds.IsDefaultSort); //是否默认排序
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.IsNeedSort))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objExcelExportRegionFldsEN.IsNeedSort == true?"1":"0", conExcelExportRegionFlds.IsNeedSort); //是否需要排序
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objExcelExportRegionFldsEN.mId); 
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
 /// <param name = "objExcelExportRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strCondition)
{
 objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExcelExportRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExcelExportRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ExcelExportRegionFlds Set ");
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.RegionId))
 {
 if (objExcelExportRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objExcelExportRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.FldId))
 {
 if (objExcelExportRegionFldsEN.FldId !=  null)
 {
 var strFldId = objExcelExportRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.OutFldId))
 {
 if (objExcelExportRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objExcelExportRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldId = '{0}',", strOutFldId); //OutFldId
 }
 else
 {
 sbSQL.Append(" OutFldId = null,"); //OutFldId
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.SeqNum))
 {
 sbSQL.AppendFormat(" SeqNum = {0},", objExcelExportRegionFldsEN.SeqNum); //字段序号
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.ColCaption))
 {
 if (objExcelExportRegionFldsEN.ColCaption !=  null)
 {
 var strColCaption = objExcelExportRegionFldsEN.ColCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ColCaption = '{0}',", strColCaption); //列标题
 }
 else
 {
 sbSQL.Append(" ColCaption = null,"); //列标题
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objExcelExportRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.ErrMsg))
 {
 if (objExcelExportRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objExcelExportRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.PrjId))
 {
 if (objExcelExportRegionFldsEN.PrjId  ==  "")
 {
 objExcelExportRegionFldsEN.PrjId = null;
 }
 if (objExcelExportRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objExcelExportRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.UpdDate))
 {
 if (objExcelExportRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objExcelExportRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.UpdUser))
 {
 if (objExcelExportRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objExcelExportRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.Memo))
 {
 if (objExcelExportRegionFldsEN.Memo !=  null)
 {
 var strMemo = objExcelExportRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.IsDefaultSort))
 {
 sbSQL.AppendFormat(" IsDefaultSort = '{0}',", objExcelExportRegionFldsEN.IsDefaultSort == true?"1":"0"); //是否默认排序
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.IsNeedSort))
 {
 sbSQL.AppendFormat(" IsNeedSort = '{0}',", objExcelExportRegionFldsEN.IsNeedSort == true?"1":"0"); //是否需要排序
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
 /// <param name = "objExcelExportRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExcelExportRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExcelExportRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ExcelExportRegionFlds Set ");
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.RegionId))
 {
 if (objExcelExportRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objExcelExportRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.FldId))
 {
 if (objExcelExportRegionFldsEN.FldId !=  null)
 {
 var strFldId = objExcelExportRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.OutFldId))
 {
 if (objExcelExportRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objExcelExportRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldId = '{0}',", strOutFldId); //OutFldId
 }
 else
 {
 sbSQL.Append(" OutFldId = null,"); //OutFldId
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.SeqNum))
 {
 sbSQL.AppendFormat(" SeqNum = {0},", objExcelExportRegionFldsEN.SeqNum); //字段序号
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.ColCaption))
 {
 if (objExcelExportRegionFldsEN.ColCaption !=  null)
 {
 var strColCaption = objExcelExportRegionFldsEN.ColCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ColCaption = '{0}',", strColCaption); //列标题
 }
 else
 {
 sbSQL.Append(" ColCaption = null,"); //列标题
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objExcelExportRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.ErrMsg))
 {
 if (objExcelExportRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objExcelExportRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.PrjId))
 {
 if (objExcelExportRegionFldsEN.PrjId  ==  "")
 {
 objExcelExportRegionFldsEN.PrjId = null;
 }
 if (objExcelExportRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objExcelExportRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.UpdDate))
 {
 if (objExcelExportRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objExcelExportRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.UpdUser))
 {
 if (objExcelExportRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objExcelExportRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.Memo))
 {
 if (objExcelExportRegionFldsEN.Memo !=  null)
 {
 var strMemo = objExcelExportRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.IsDefaultSort))
 {
 sbSQL.AppendFormat(" IsDefaultSort = '{0}',", objExcelExportRegionFldsEN.IsDefaultSort == true?"1":"0"); //是否默认排序
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.IsNeedSort))
 {
 sbSQL.AppendFormat(" IsNeedSort = '{0}',", objExcelExportRegionFldsEN.IsNeedSort == true?"1":"0"); //是否需要排序
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
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExcelExportRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExcelExportRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ExcelExportRegionFlds Set ");
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.RegionId))
 {
 if (objExcelExportRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objExcelExportRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conExcelExportRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.FldId))
 {
 if (objExcelExportRegionFldsEN.FldId !=  null)
 {
 var strFldId = objExcelExportRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conExcelExportRegionFlds.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.FldId); //字段Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.OutFldId))
 {
 if (objExcelExportRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objExcelExportRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldId, conExcelExportRegionFlds.OutFldId); //OutFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.OutFldId); //OutFldId
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.SeqNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objExcelExportRegionFldsEN.SeqNum, conExcelExportRegionFlds.SeqNum); //字段序号
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.ColCaption))
 {
 if (objExcelExportRegionFldsEN.ColCaption !=  null)
 {
 var strColCaption = objExcelExportRegionFldsEN.ColCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strColCaption, conExcelExportRegionFlds.ColCaption); //列标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.ColCaption); //列标题
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objExcelExportRegionFldsEN.InUse == true?"1":"0", conExcelExportRegionFlds.InUse); //是否在用
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.ErrMsg))
 {
 if (objExcelExportRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objExcelExportRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conExcelExportRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.PrjId))
 {
 if (objExcelExportRegionFldsEN.PrjId  ==  "")
 {
 objExcelExportRegionFldsEN.PrjId = null;
 }
 if (objExcelExportRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objExcelExportRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conExcelExportRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.UpdDate))
 {
 if (objExcelExportRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objExcelExportRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conExcelExportRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.UpdUser))
 {
 if (objExcelExportRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objExcelExportRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conExcelExportRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.Memo))
 {
 if (objExcelExportRegionFldsEN.Memo !=  null)
 {
 var strMemo = objExcelExportRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conExcelExportRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExcelExportRegionFlds.Memo); //说明
 }
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.IsDefaultSort))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objExcelExportRegionFldsEN.IsDefaultSort == true?"1":"0", conExcelExportRegionFlds.IsDefaultSort); //是否默认排序
 }
 
 if (objExcelExportRegionFldsEN.IsUpdated(conExcelExportRegionFlds.IsNeedSort))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objExcelExportRegionFldsEN.IsNeedSort == true?"1":"0", conExcelExportRegionFlds.IsNeedSort); //是否需要排序
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objExcelExportRegionFldsEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ExcelExportRegionFlds_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
//删除ExcelExportRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ExcelExportRegionFlds where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelExcelExportRegionFlds(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除ExcelExportRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ExcelExportRegionFlds where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
//删除ExcelExportRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ExcelExportRegionFlds where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelExcelExportRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: DelExcelExportRegionFlds)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ExcelExportRegionFlds where " + strCondition ;
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
public bool DelExcelExportRegionFldsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsExcelExportRegionFldsDA: DelExcelExportRegionFldsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ExcelExportRegionFlds where " + strCondition ;
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
 /// <param name = "objExcelExportRegionFldsENS">源对象</param>
 /// <param name = "objExcelExportRegionFldsENT">目标对象</param>
public void CopyTo(clsExcelExportRegionFldsEN objExcelExportRegionFldsENS, clsExcelExportRegionFldsEN objExcelExportRegionFldsENT)
{
objExcelExportRegionFldsENT.mId = objExcelExportRegionFldsENS.mId; //mId
objExcelExportRegionFldsENT.RegionId = objExcelExportRegionFldsENS.RegionId; //区域Id
objExcelExportRegionFldsENT.FldId = objExcelExportRegionFldsENS.FldId; //字段Id
objExcelExportRegionFldsENT.OutFldId = objExcelExportRegionFldsENS.OutFldId; //OutFldId
objExcelExportRegionFldsENT.SeqNum = objExcelExportRegionFldsENS.SeqNum; //字段序号
objExcelExportRegionFldsENT.ColCaption = objExcelExportRegionFldsENS.ColCaption; //列标题
objExcelExportRegionFldsENT.InUse = objExcelExportRegionFldsENS.InUse; //是否在用
objExcelExportRegionFldsENT.ErrMsg = objExcelExportRegionFldsENS.ErrMsg; //错误信息
objExcelExportRegionFldsENT.PrjId = objExcelExportRegionFldsENS.PrjId; //工程Id
objExcelExportRegionFldsENT.UpdDate = objExcelExportRegionFldsENS.UpdDate; //修改日期
objExcelExportRegionFldsENT.UpdUser = objExcelExportRegionFldsENS.UpdUser; //修改者
objExcelExportRegionFldsENT.Memo = objExcelExportRegionFldsENS.Memo; //说明
objExcelExportRegionFldsENT.IsDefaultSort = objExcelExportRegionFldsENS.IsDefaultSort; //是否默认排序
objExcelExportRegionFldsENT.IsNeedSort = objExcelExportRegionFldsENS.IsNeedSort; //是否需要排序
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objExcelExportRegionFldsEN.RegionId, conExcelExportRegionFlds.RegionId);
clsCheckSql.CheckFieldNotNull(objExcelExportRegionFldsEN.SeqNum, conExcelExportRegionFlds.SeqNum);
clsCheckSql.CheckFieldNotNull(objExcelExportRegionFldsEN.PrjId, conExcelExportRegionFlds.PrjId);
clsCheckSql.CheckFieldNotNull(objExcelExportRegionFldsEN.UpdUser, conExcelExportRegionFlds.UpdUser);
clsCheckSql.CheckFieldNotNull(objExcelExportRegionFldsEN.IsDefaultSort, conExcelExportRegionFlds.IsDefaultSort);
clsCheckSql.CheckFieldNotNull(objExcelExportRegionFldsEN.IsNeedSort, conExcelExportRegionFlds.IsNeedSort);
//检查字段长度
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.RegionId, 10, conExcelExportRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.FldId, 8, conExcelExportRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.OutFldId, 8, conExcelExportRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.ColCaption, 100, conExcelExportRegionFlds.ColCaption);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.ErrMsg, 2000, conExcelExportRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.PrjId, 4, conExcelExportRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.UpdDate, 20, conExcelExportRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.UpdUser, 20, conExcelExportRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.Memo, 1000, conExcelExportRegionFlds.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objExcelExportRegionFldsEN.PrjId, 4, conExcelExportRegionFlds.PrjId);
 objExcelExportRegionFldsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.RegionId, 10, conExcelExportRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.FldId, 8, conExcelExportRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.OutFldId, 8, conExcelExportRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.ColCaption, 100, conExcelExportRegionFlds.ColCaption);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.ErrMsg, 2000, conExcelExportRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.PrjId, 4, conExcelExportRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.UpdDate, 20, conExcelExportRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.UpdUser, 20, conExcelExportRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.Memo, 1000, conExcelExportRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objExcelExportRegionFldsEN.PrjId, 4, conExcelExportRegionFlds.PrjId);
 objExcelExportRegionFldsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.RegionId, 10, conExcelExportRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.FldId, 8, conExcelExportRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.OutFldId, 8, conExcelExportRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.ColCaption, 100, conExcelExportRegionFlds.ColCaption);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.ErrMsg, 2000, conExcelExportRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.PrjId, 4, conExcelExportRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.UpdDate, 20, conExcelExportRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.UpdUser, 20, conExcelExportRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objExcelExportRegionFldsEN.Memo, 1000, conExcelExportRegionFlds.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objExcelExportRegionFldsEN.RegionId, conExcelExportRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objExcelExportRegionFldsEN.FldId, conExcelExportRegionFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objExcelExportRegionFldsEN.OutFldId, conExcelExportRegionFlds.OutFldId);
clsCheckSql.CheckSqlInjection4Field(objExcelExportRegionFldsEN.ColCaption, conExcelExportRegionFlds.ColCaption);
clsCheckSql.CheckSqlInjection4Field(objExcelExportRegionFldsEN.ErrMsg, conExcelExportRegionFlds.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objExcelExportRegionFldsEN.PrjId, conExcelExportRegionFlds.PrjId);
clsCheckSql.CheckSqlInjection4Field(objExcelExportRegionFldsEN.UpdDate, conExcelExportRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objExcelExportRegionFldsEN.UpdUser, conExcelExportRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objExcelExportRegionFldsEN.Memo, conExcelExportRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objExcelExportRegionFldsEN.PrjId, 4, conExcelExportRegionFlds.PrjId);
 objExcelExportRegionFldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ExcelExportRegionFlds(Excel导出区域字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objExcelExportRegionFldsEN.RegionId);
 if (objExcelExportRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null");
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objExcelExportRegionFldsEN.FldId);
}
 if (objExcelExportRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null");
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objExcelExportRegionFldsEN.OutFldId);
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
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsExcelExportRegionFldsEN._CurrTabName);
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
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsExcelExportRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}