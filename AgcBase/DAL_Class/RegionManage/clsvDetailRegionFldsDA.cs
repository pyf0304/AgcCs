
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDetailRegionFldsDA
 表名:vDetailRegionFlds(00050546)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// v详细区域字段(vDetailRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDetailRegionFldsDA : clsCommBase4DA
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
 return clsvDetailRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDetailRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDetailRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDetailRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDetailRegionFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDetailRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDetailRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA: GetDataTable_vDetailRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDetailRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDetailRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDetailRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDetailRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDetailRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDetailRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDetailRegionFlds.* " + 
$"from vDetailRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDetailRegionFlds.mId not in " + 
$"(Select top {intTop_In} vDetailRegionFlds.mId from vDetailRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDetailRegionFlds where {1} and mId not in (Select top {2} mId from vDetailRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDetailRegionFlds where {1} and mId not in (Select top {3} mId from vDetailRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDetailRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDetailRegionFlds.* " + 
$"from vDetailRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDetailRegionFlds.mId not in " + 
$"(Select top {intTop_In} vDetailRegionFlds.mId from vDetailRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDetailRegionFlds where {1} and mId not in (Select top {2} mId from vDetailRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDetailRegionFlds where {1} and mId not in (Select top {3} mId from vDetailRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDetailRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDetailRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = TransNullToInt(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = TransNullToBool(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = TransNullToBool(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = TransNullToInt(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = TransNullToBool(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDetailRegionFldsDA: GetObjLst)", objException.Message));
}
objvDetailRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDetailRegionFldsEN);
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
public List<clsvDetailRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDetailRegionFldsEN> arrObjLst = new List<clsvDetailRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = TransNullToInt(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = TransNullToBool(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = TransNullToBool(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = TransNullToInt(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = TransNullToBool(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDetailRegionFldsDA: GetObjLst)", objException.Message));
}
objvDetailRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDetailRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDetailRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDetailRegionFlds(ref clsvDetailRegionFldsEN objvDetailRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDetailRegionFlds where mId = " + ""+ objvDetailRegionFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDetailRegionFldsEN.mId = TransNullToInt(objDT.Rows[0][convDetailRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvDetailRegionFldsEN.RegionId = objDT.Rows[0][convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvDetailRegionFldsEN.RegionTypeId = objDT.Rows[0][convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvDetailRegionFldsEN.TabId = objDT.Rows[0][convDetailRegionFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDetailRegionFldsEN.TabName = objDT.Rows[0][convDetailRegionFlds.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvDetailRegionFldsEN.FldId = objDT.Rows[0][convDetailRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvDetailRegionFldsEN.FldName = objDT.Rows[0][convDetailRegionFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDetailRegionFldsEN.OutDataNodeId = TransNullToInt(objDT.Rows[0][convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDetailRegionFldsEN.DataNodeName = objDT.Rows[0][convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvDetailRegionFldsEN.IsUseFunc = TransNullToBool(objDT.Rows[0][convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射(字段类型:bit,字段长度:1,是否可空:True)
 objvDetailRegionFldsEN.DataPropertyName = objDT.Rows[0][convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDetailRegionFldsEN.LabelCaption = objDT.Rows[0][convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objvDetailRegionFldsEN.CtlTypeId = objDT.Rows[0][convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvDetailRegionFldsEN.CtlTypeName = objDT.Rows[0][convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvDetailRegionFldsEN.CtlCnName = objDT.Rows[0][convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDetailRegionFldsEN.CtlTypeAbbr = objDT.Rows[0][convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvDetailRegionFldsEN.ColSpan = TransNullToInt(objDT.Rows[0][convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objvDetailRegionFldsEN.ColIndex = TransNullToInt(objDT.Rows[0][convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号(字段类型:int,字段长度:4,是否可空:False)
 objvDetailRegionFldsEN.Width = TransNullToInt(objDT.Rows[0][convDetailRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvDetailRegionFldsEN.IsMultiRow = TransNullToBool(objDT.Rows[0][convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行(字段类型:bit,字段长度:1,是否可空:True)
 objvDetailRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvDetailRegionFldsEN.InOutTypeId = objDT.Rows[0][convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvDetailRegionFldsEN.InOutTypeName = objDT.Rows[0][convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvDetailRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][convDetailRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvDetailRegionFldsEN.ChangeEvent = objDT.Rows[0][convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvDetailRegionFldsEN.ClickEvent = objDT.Rows[0][convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvDetailRegionFldsEN.UpdUser = objDT.Rows[0][convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDetailRegionFldsEN.UpdDate = objDT.Rows[0][convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDetailRegionFldsEN.Memo = objDT.Rows[0][convDetailRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDetailRegionFldsEN.PrjId = objDT.Rows[0][convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDetailRegionFldsDA: GetvDetailRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDetailRegionFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDetailRegionFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
 objvDetailRegionFldsEN.mId = Int32.Parse(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvDetailRegionFldsEN.IsUseFunc = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射(字段类型:bit,字段长度:1,是否可空:True)
 objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号(字段类型:int,字段长度:4,是否可空:False)
 objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行(字段类型:bit,字段长度:1,是否可空:True)
 objvDetailRegionFldsEN.SeqNum = Int32.Parse(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDetailRegionFldsDA: GetObjBymId)", objException.Message));
}
return objvDetailRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDetailRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDetailRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN()
{
mId = TransNullToInt(objRow[convDetailRegionFlds.mId].ToString().Trim()), //mId
RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(), //区域Id
RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(), //区域类型Id
TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(), //表ID
TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(), //表名
FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(), //字段Id
FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(), //字段名
OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()), //Out数据结点Id
DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(), //数据结点名
IsUseFunc = TransNullToBool(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()), //使用函数映射
DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(), //数据属性名
LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(), //标签标题
CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(), //控件类型号
CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(), //控件类型名
CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(), //控件类型中文名
CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(), //控件类型缩写
ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()), //跨列数
ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()), //列序号
Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.Width].ToString().Trim()), //宽
IsMultiRow = TransNullToBool(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()), //是否多行
SeqNum = TransNullToInt(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()), //字段序号
InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(), //INOUT类型ID
InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(), //INOUT类型名称
InUse = TransNullToBool(objRow[convDetailRegionFlds.InUse].ToString().Trim()), //是否在用
ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(), //Change事件
ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(), //Click事件
UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(), //说明
PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim() //工程Id
};
objvDetailRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDetailRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDetailRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDetailRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = TransNullToInt(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = TransNullToBool(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = TransNullToBool(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = TransNullToInt(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = TransNullToBool(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDetailRegionFldsDA: GetObjByDataRowvDetailRegionFlds)", objException.Message));
}
objvDetailRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDetailRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDetailRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDetailRegionFldsEN objvDetailRegionFldsEN = new clsvDetailRegionFldsEN();
try
{
objvDetailRegionFldsEN.mId = TransNullToInt(objRow[convDetailRegionFlds.mId].ToString().Trim()); //mId
objvDetailRegionFldsEN.RegionId = objRow[convDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDetailRegionFldsEN.RegionTypeId = objRow[convDetailRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvDetailRegionFldsEN.TabId = objRow[convDetailRegionFlds.TabId].ToString().Trim(); //表ID
objvDetailRegionFldsEN.TabName = objRow[convDetailRegionFlds.TabName].ToString().Trim(); //表名
objvDetailRegionFldsEN.FldId = objRow[convDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objvDetailRegionFldsEN.FldName = objRow[convDetailRegionFlds.FldName].ToString().Trim(); //字段名
objvDetailRegionFldsEN.OutDataNodeId = objRow[convDetailRegionFlds.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDetailRegionFlds.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDetailRegionFldsEN.DataNodeName = objRow[convDetailRegionFlds.DataNodeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataNodeName].ToString().Trim(); //数据结点名
objvDetailRegionFldsEN.IsUseFunc = TransNullToBool(objRow[convDetailRegionFlds.IsUseFunc].ToString().Trim()); //使用函数映射
objvDetailRegionFldsEN.DataPropertyName = objRow[convDetailRegionFlds.DataPropertyName] == DBNull.Value ? null : objRow[convDetailRegionFlds.DataPropertyName].ToString().Trim(); //数据属性名
objvDetailRegionFldsEN.LabelCaption = objRow[convDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvDetailRegionFldsEN.CtlTypeId = objRow[convDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDetailRegionFldsEN.CtlTypeName = objRow[convDetailRegionFlds.CtlTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDetailRegionFldsEN.CtlCnName = objRow[convDetailRegionFlds.CtlCnName] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDetailRegionFldsEN.CtlTypeAbbr = objRow[convDetailRegionFlds.CtlTypeAbbr] == DBNull.Value ? null : objRow[convDetailRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvDetailRegionFldsEN.ColSpan = objRow[convDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvDetailRegionFldsEN.ColIndex = objRow[convDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objvDetailRegionFldsEN.Width = objRow[convDetailRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDetailRegionFlds.Width].ToString().Trim()); //宽
objvDetailRegionFldsEN.IsMultiRow = TransNullToBool(objRow[convDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objvDetailRegionFldsEN.SeqNum = TransNullToInt(objRow[convDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDetailRegionFldsEN.InOutTypeId = objRow[convDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objvDetailRegionFldsEN.InOutTypeName = objRow[convDetailRegionFlds.InOutTypeName] == DBNull.Value ? null : objRow[convDetailRegionFlds.InOutTypeName].ToString().Trim(); //INOUT类型名称
objvDetailRegionFldsEN.InUse = TransNullToBool(objRow[convDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objvDetailRegionFldsEN.ChangeEvent = objRow[convDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvDetailRegionFldsEN.ClickEvent = objRow[convDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvDetailRegionFldsEN.UpdUser = objRow[convDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDetailRegionFldsEN.UpdDate = objRow[convDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDetailRegionFldsEN.Memo = objRow[convDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[convDetailRegionFlds.Memo].ToString().Trim(); //说明
objvDetailRegionFldsEN.PrjId = objRow[convDetailRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDetailRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objvDetailRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDetailRegionFldsEN;
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
objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDetailRegionFldsEN._CurrTabName, convDetailRegionFlds.mId, 8, "");
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
objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDetailRegionFldsEN._CurrTabName, convDetailRegionFlds.mId, 8, strPrefix);
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
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vDetailRegionFlds where " + strCondition;
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
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vDetailRegionFlds where " + strCondition;
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
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDetailRegionFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDetailRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDetailRegionFlds", strCondition))
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
objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDetailRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDetailRegionFldsENS">源对象</param>
 /// <param name = "objvDetailRegionFldsENT">目标对象</param>
public void CopyTo(clsvDetailRegionFldsEN objvDetailRegionFldsENS, clsvDetailRegionFldsEN objvDetailRegionFldsENT)
{
objvDetailRegionFldsENT.mId = objvDetailRegionFldsENS.mId; //mId
objvDetailRegionFldsENT.RegionId = objvDetailRegionFldsENS.RegionId; //区域Id
objvDetailRegionFldsENT.RegionTypeId = objvDetailRegionFldsENS.RegionTypeId; //区域类型Id
objvDetailRegionFldsENT.TabId = objvDetailRegionFldsENS.TabId; //表ID
objvDetailRegionFldsENT.TabName = objvDetailRegionFldsENS.TabName; //表名
objvDetailRegionFldsENT.FldId = objvDetailRegionFldsENS.FldId; //字段Id
objvDetailRegionFldsENT.FldName = objvDetailRegionFldsENS.FldName; //字段名
objvDetailRegionFldsENT.OutDataNodeId = objvDetailRegionFldsENS.OutDataNodeId; //Out数据结点Id
objvDetailRegionFldsENT.DataNodeName = objvDetailRegionFldsENS.DataNodeName; //数据结点名
objvDetailRegionFldsENT.IsUseFunc = objvDetailRegionFldsENS.IsUseFunc; //使用函数映射
objvDetailRegionFldsENT.DataPropertyName = objvDetailRegionFldsENS.DataPropertyName; //数据属性名
objvDetailRegionFldsENT.LabelCaption = objvDetailRegionFldsENS.LabelCaption; //标签标题
objvDetailRegionFldsENT.CtlTypeId = objvDetailRegionFldsENS.CtlTypeId; //控件类型号
objvDetailRegionFldsENT.CtlTypeName = objvDetailRegionFldsENS.CtlTypeName; //控件类型名
objvDetailRegionFldsENT.CtlCnName = objvDetailRegionFldsENS.CtlCnName; //控件类型中文名
objvDetailRegionFldsENT.CtlTypeAbbr = objvDetailRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvDetailRegionFldsENT.ColSpan = objvDetailRegionFldsENS.ColSpan; //跨列数
objvDetailRegionFldsENT.ColIndex = objvDetailRegionFldsENS.ColIndex; //列序号
objvDetailRegionFldsENT.Width = objvDetailRegionFldsENS.Width; //宽
objvDetailRegionFldsENT.IsMultiRow = objvDetailRegionFldsENS.IsMultiRow; //是否多行
objvDetailRegionFldsENT.SeqNum = objvDetailRegionFldsENS.SeqNum; //字段序号
objvDetailRegionFldsENT.InOutTypeId = objvDetailRegionFldsENS.InOutTypeId; //INOUT类型ID
objvDetailRegionFldsENT.InOutTypeName = objvDetailRegionFldsENS.InOutTypeName; //INOUT类型名称
objvDetailRegionFldsENT.InUse = objvDetailRegionFldsENS.InUse; //是否在用
objvDetailRegionFldsENT.ChangeEvent = objvDetailRegionFldsENS.ChangeEvent; //Change事件
objvDetailRegionFldsENT.ClickEvent = objvDetailRegionFldsENS.ClickEvent; //Click事件
objvDetailRegionFldsENT.UpdUser = objvDetailRegionFldsENS.UpdUser; //修改者
objvDetailRegionFldsENT.UpdDate = objvDetailRegionFldsENS.UpdDate; //修改日期
objvDetailRegionFldsENT.Memo = objvDetailRegionFldsENS.Memo; //说明
objvDetailRegionFldsENT.PrjId = objvDetailRegionFldsENS.PrjId; //工程Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDetailRegionFldsEN objvDetailRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.RegionId, 10, convDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.RegionTypeId, 4, convDetailRegionFlds.RegionTypeId);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.TabId, 8, convDetailRegionFlds.TabId);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.TabName, 100, convDetailRegionFlds.TabName);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.FldId, 8, convDetailRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.FldName, 50, convDetailRegionFlds.FldName);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.DataNodeName, 100, convDetailRegionFlds.DataNodeName);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.DataPropertyName, 50, convDetailRegionFlds.DataPropertyName);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.LabelCaption, 150, convDetailRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.CtlTypeId, 2, convDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.CtlTypeName, 30, convDetailRegionFlds.CtlTypeName);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.CtlCnName, 50, convDetailRegionFlds.CtlCnName);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.CtlTypeAbbr, 5, convDetailRegionFlds.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.InOutTypeId, 2, convDetailRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.InOutTypeName, 30, convDetailRegionFlds.InOutTypeName);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.ChangeEvent, 50, convDetailRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.ClickEvent, 50, convDetailRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.UpdUser, 20, convDetailRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.UpdDate, 20, convDetailRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.Memo, 1000, convDetailRegionFlds.Memo);
clsCheckSql.CheckFieldLen(objvDetailRegionFldsEN.PrjId, 4, convDetailRegionFlds.PrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.RegionId, convDetailRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.RegionTypeId, convDetailRegionFlds.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.TabId, convDetailRegionFlds.TabId);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.TabName, convDetailRegionFlds.TabName);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.FldId, convDetailRegionFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.FldName, convDetailRegionFlds.FldName);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.DataNodeName, convDetailRegionFlds.DataNodeName);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.DataPropertyName, convDetailRegionFlds.DataPropertyName);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.LabelCaption, convDetailRegionFlds.LabelCaption);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.CtlTypeId, convDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.CtlTypeName, convDetailRegionFlds.CtlTypeName);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.CtlCnName, convDetailRegionFlds.CtlCnName);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.CtlTypeAbbr, convDetailRegionFlds.CtlTypeAbbr);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.InOutTypeId, convDetailRegionFlds.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.InOutTypeName, convDetailRegionFlds.InOutTypeName);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.ChangeEvent, convDetailRegionFlds.ChangeEvent);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.ClickEvent, convDetailRegionFlds.ClickEvent);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.UpdUser, convDetailRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.UpdDate, convDetailRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.Memo, convDetailRegionFlds.Memo);
clsCheckSql.CheckSqlInjection4Field(objvDetailRegionFldsEN.PrjId, convDetailRegionFlds.PrjId);
//检查外键字段长度
 objvDetailRegionFldsEN._IsCheckProperty = true;
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
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDetailRegionFldsEN._CurrTabName);
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
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDetailRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsvDetailRegionFldsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}