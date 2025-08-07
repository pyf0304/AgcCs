
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExcelExportRegionFldsDA
 表名:vExcelExportRegionFlds(00050150)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:09
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
 /// vExcel导出区域字段(vExcelExportRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvExcelExportRegionFldsDA : clsCommBase4DA
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
 return clsvExcelExportRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvExcelExportRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvExcelExportRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvExcelExportRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvExcelExportRegionFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vExcelExportRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vExcelExportRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA: GetDataTable_vExcelExportRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vExcelExportRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vExcelExportRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vExcelExportRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vExcelExportRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vExcelExportRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vExcelExportRegionFlds.* " + 
$"from vExcelExportRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vExcelExportRegionFlds.mId not in " + 
$"(Select top {intTop_In} vExcelExportRegionFlds.mId from vExcelExportRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vExcelExportRegionFlds where {1} and mId not in (Select top {2} mId from vExcelExportRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vExcelExportRegionFlds where {1} and mId not in (Select top {3} mId from vExcelExportRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vExcelExportRegionFlds.* " + 
$"from vExcelExportRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vExcelExportRegionFlds.mId not in " + 
$"(Select top {intTop_In} vExcelExportRegionFlds.mId from vExcelExportRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vExcelExportRegionFlds where {1} and mId not in (Select top {2} mId from vExcelExportRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vExcelExportRegionFlds where {1} and mId not in (Select top {3} mId from vExcelExportRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvExcelExportRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vExcelExportRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = TransNullToInt(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = TransNullToInt(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = TransNullToBool(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = TransNullToBool(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvExcelExportRegionFldsDA: GetObjLst)", objException.Message));
}
objvExcelExportRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvExcelExportRegionFldsEN);
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
public List<clsvExcelExportRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvExcelExportRegionFldsEN> arrObjLst = new List<clsvExcelExportRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = TransNullToInt(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = TransNullToInt(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = TransNullToBool(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = TransNullToBool(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvExcelExportRegionFldsDA: GetObjLst)", objException.Message));
}
objvExcelExportRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvExcelExportRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvExcelExportRegionFlds(ref clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vExcelExportRegionFlds where mId = " + ""+ objvExcelExportRegionFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvExcelExportRegionFldsEN.mId = TransNullToInt(objDT.Rows[0][convExcelExportRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvExcelExportRegionFldsEN.RegionId = objDT.Rows[0][convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvExcelExportRegionFldsEN.RegionName = objDT.Rows[0][convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvExcelExportRegionFldsEN.TabId = objDT.Rows[0][convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvExcelExportRegionFldsEN.TabName = objDT.Rows[0][convExcelExportRegionFlds.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvExcelExportRegionFldsEN.FldId = objDT.Rows[0][convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvExcelExportRegionFldsEN.FldName = objDT.Rows[0][convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvExcelExportRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvExcelExportRegionFldsEN.ColCaption = objDT.Rows[0][convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题(字段类型:varchar,字段长度:100,是否可空:True)
 objvExcelExportRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvExcelExportRegionFldsEN.UpdDate = objDT.Rows[0][convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvExcelExportRegionFldsEN.UpdUser = objDT.Rows[0][convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvExcelExportRegionFldsEN.Memo = objDT.Rows[0][convExcelExportRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvExcelExportRegionFldsEN.IsDefaultSort = TransNullToBool(objDT.Rows[0][convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序(字段类型:bit,字段长度:1,是否可空:False)
 objvExcelExportRegionFldsEN.IsNeedSort = TransNullToBool(objDT.Rows[0][convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objvExcelExportRegionFldsEN.PrjId = objDT.Rows[0][convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvExcelExportRegionFldsDA: GetvExcelExportRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvExcelExportRegionFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vExcelExportRegionFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
 objvExcelExportRegionFldsEN.mId = Int32.Parse(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题(字段类型:varchar,字段长度:100,是否可空:True)
 objvExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序(字段类型:bit,字段长度:1,是否可空:False)
 objvExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvExcelExportRegionFldsDA: GetObjBymId)", objException.Message));
}
return objvExcelExportRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvExcelExportRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vExcelExportRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN()
{
mId = TransNullToInt(objRow[convExcelExportRegionFlds.mId].ToString().Trim()), //mId
RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(), //区域Id
RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(), //区域名称
TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(), //表ID
TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(), //表名
FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(), //字段Id
FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(), //字段名
SeqNum = TransNullToInt(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()), //字段序号
ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(), //列标题
InUse = TransNullToBool(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(), //说明
IsDefaultSort = TransNullToBool(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()), //是否默认排序
IsNeedSort = TransNullToBool(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()), //是否需要排序
PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim() //工程Id
};
objvExcelExportRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvExcelExportRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvExcelExportRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvExcelExportRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = TransNullToInt(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = TransNullToInt(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = TransNullToBool(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = TransNullToBool(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvExcelExportRegionFldsDA: GetObjByDataRowvExcelExportRegionFlds)", objException.Message));
}
objvExcelExportRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvExcelExportRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvExcelExportRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN = new clsvExcelExportRegionFldsEN();
try
{
objvExcelExportRegionFldsEN.mId = TransNullToInt(objRow[convExcelExportRegionFlds.mId].ToString().Trim()); //mId
objvExcelExportRegionFldsEN.RegionId = objRow[convExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objvExcelExportRegionFldsEN.RegionName = objRow[convExcelExportRegionFlds.RegionName] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.RegionName].ToString().Trim(); //区域名称
objvExcelExportRegionFldsEN.TabId = objRow[convExcelExportRegionFlds.TabId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.TabId].ToString().Trim(); //表ID
objvExcelExportRegionFldsEN.TabName = objRow[convExcelExportRegionFlds.TabName].ToString().Trim(); //表名
objvExcelExportRegionFldsEN.FldId = objRow[convExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objvExcelExportRegionFldsEN.FldName = objRow[convExcelExportRegionFlds.FldName].ToString().Trim(); //字段名
objvExcelExportRegionFldsEN.SeqNum = TransNullToInt(objRow[convExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvExcelExportRegionFldsEN.ColCaption = objRow[convExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objvExcelExportRegionFldsEN.InUse = TransNullToBool(objRow[convExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objvExcelExportRegionFldsEN.UpdDate = objRow[convExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvExcelExportRegionFldsEN.UpdUser = objRow[convExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objvExcelExportRegionFldsEN.Memo = objRow[convExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objvExcelExportRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[convExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvExcelExportRegionFldsEN.IsNeedSort = TransNullToBool(objRow[convExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvExcelExportRegionFldsEN.PrjId = objRow[convExcelExportRegionFlds.PrjId] == DBNull.Value ? null : objRow[convExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvExcelExportRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objvExcelExportRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvExcelExportRegionFldsEN;
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
objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvExcelExportRegionFldsEN._CurrTabName, convExcelExportRegionFlds.mId, 8, "");
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
objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvExcelExportRegionFldsEN._CurrTabName, convExcelExportRegionFlds.mId, 8, strPrefix);
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
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vExcelExportRegionFlds where " + strCondition;
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
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vExcelExportRegionFlds where " + strCondition;
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
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vExcelExportRegionFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvExcelExportRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vExcelExportRegionFlds", strCondition))
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
objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vExcelExportRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvExcelExportRegionFldsENS">源对象</param>
 /// <param name = "objvExcelExportRegionFldsENT">目标对象</param>
public void CopyTo(clsvExcelExportRegionFldsEN objvExcelExportRegionFldsENS, clsvExcelExportRegionFldsEN objvExcelExportRegionFldsENT)
{
objvExcelExportRegionFldsENT.mId = objvExcelExportRegionFldsENS.mId; //mId
objvExcelExportRegionFldsENT.RegionId = objvExcelExportRegionFldsENS.RegionId; //区域Id
objvExcelExportRegionFldsENT.RegionName = objvExcelExportRegionFldsENS.RegionName; //区域名称
objvExcelExportRegionFldsENT.TabId = objvExcelExportRegionFldsENS.TabId; //表ID
objvExcelExportRegionFldsENT.TabName = objvExcelExportRegionFldsENS.TabName; //表名
objvExcelExportRegionFldsENT.FldId = objvExcelExportRegionFldsENS.FldId; //字段Id
objvExcelExportRegionFldsENT.FldName = objvExcelExportRegionFldsENS.FldName; //字段名
objvExcelExportRegionFldsENT.SeqNum = objvExcelExportRegionFldsENS.SeqNum; //字段序号
objvExcelExportRegionFldsENT.ColCaption = objvExcelExportRegionFldsENS.ColCaption; //列标题
objvExcelExportRegionFldsENT.InUse = objvExcelExportRegionFldsENS.InUse; //是否在用
objvExcelExportRegionFldsENT.UpdDate = objvExcelExportRegionFldsENS.UpdDate; //修改日期
objvExcelExportRegionFldsENT.UpdUser = objvExcelExportRegionFldsENS.UpdUser; //修改者
objvExcelExportRegionFldsENT.Memo = objvExcelExportRegionFldsENS.Memo; //说明
objvExcelExportRegionFldsENT.IsDefaultSort = objvExcelExportRegionFldsENS.IsDefaultSort; //是否默认排序
objvExcelExportRegionFldsENT.IsNeedSort = objvExcelExportRegionFldsENS.IsNeedSort; //是否需要排序
objvExcelExportRegionFldsENT.PrjId = objvExcelExportRegionFldsENS.PrjId; //工程Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvExcelExportRegionFldsEN objvExcelExportRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.RegionId, 10, convExcelExportRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.RegionName, 50, convExcelExportRegionFlds.RegionName);
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.TabId, 8, convExcelExportRegionFlds.TabId);
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.TabName, 100, convExcelExportRegionFlds.TabName);
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.FldId, 8, convExcelExportRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.FldName, 50, convExcelExportRegionFlds.FldName);
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.ColCaption, 100, convExcelExportRegionFlds.ColCaption);
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.UpdDate, 20, convExcelExportRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.UpdUser, 20, convExcelExportRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.Memo, 1000, convExcelExportRegionFlds.Memo);
clsCheckSql.CheckFieldLen(objvExcelExportRegionFldsEN.PrjId, 4, convExcelExportRegionFlds.PrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.RegionId, convExcelExportRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.RegionName, convExcelExportRegionFlds.RegionName);
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.TabId, convExcelExportRegionFlds.TabId);
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.TabName, convExcelExportRegionFlds.TabName);
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.FldId, convExcelExportRegionFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.FldName, convExcelExportRegionFlds.FldName);
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.ColCaption, convExcelExportRegionFlds.ColCaption);
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.UpdDate, convExcelExportRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.UpdUser, convExcelExportRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.Memo, convExcelExportRegionFlds.Memo);
clsCheckSql.CheckSqlInjection4Field(objvExcelExportRegionFldsEN.PrjId, convExcelExportRegionFlds.PrjId);
//检查外键字段长度
 objvExcelExportRegionFldsEN._IsCheckProperty = true;
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
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvExcelExportRegionFldsEN._CurrTabName);
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
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvExcelExportRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsvExcelExportRegionFldsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}