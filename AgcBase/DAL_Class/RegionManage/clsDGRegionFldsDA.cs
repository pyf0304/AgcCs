
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDGRegionFldsDA
 表名:DGRegionFlds(00050113)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:55
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
 /// DG区域字段(DGRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDGRegionFldsDA : clsCommBase4DA
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
 return clsDGRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDGRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDGRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDGRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDGRegionFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDGRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DGRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DGRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDGRegionFldsDA: GetDataTable_DGRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DGRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDGRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDGRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DGRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDGRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDGRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DGRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DGRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDGRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DGRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDGRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DGRegionFlds.* " + 
$"from DGRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DGRegionFlds.mId not in " + 
$"(Select top {intTop_In} DGRegionFlds.mId from DGRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DGRegionFlds where {1} and mId not in (Select top {2} mId from DGRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DGRegionFlds where {1} and mId not in (Select top {3} mId from DGRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDGRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DGRegionFlds.* " + 
$"from DGRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DGRegionFlds.mId not in " + 
$"(Select top {intTop_In} DGRegionFlds.mId from DGRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DGRegionFlds where {1} and mId not in (Select top {2} mId from DGRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DGRegionFlds where {1} and mId not in (Select top {3} mId from DGRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDGRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDGRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DGRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = TransNullToInt(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = TransNullToInt(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = TransNullToBool(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = TransNullToBool(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = TransNullToBool(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = TransNullToBool(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = TransNullToBool(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDGRegionFldsDA: GetObjLst)", objException.Message));
}
objDGRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDGRegionFldsEN);
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
public List<clsDGRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDGRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = TransNullToInt(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = TransNullToInt(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = TransNullToBool(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = TransNullToBool(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = TransNullToBool(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = TransNullToBool(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = TransNullToBool(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDGRegionFldsDA: GetObjLst)", objException.Message));
}
objDGRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDGRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDGRegionFlds(ref clsDGRegionFldsEN objDGRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DGRegionFlds where mId = " + ""+ objDGRegionFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDGRegionFldsEN.mId = TransNullToInt(objDT.Rows[0][conDGRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objDGRegionFldsEN.RegionId = objDT.Rows[0][conDGRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objDGRegionFldsEN.FldId = objDT.Rows[0][conDGRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objDGRegionFldsEN.OutFldId = objDT.Rows[0][conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId(字段类型:char,字段长度:8,是否可空:True)
 objDGRegionFldsEN.SortExpression = objDT.Rows[0][conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式(字段类型:varchar,字段长度:50,是否可空:False)
 objDGRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objDGRegionFldsEN.HeaderText = objDT.Rows[0][conDGRegionFlds.HeaderText].ToString().Trim(); //列头(字段类型:varchar,字段长度:100,是否可空:False)
 objDGRegionFldsEN.ToolTipText = objDT.Rows[0][conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字(字段类型:varchar,字段长度:150,是否可空:True)
 objDGRegionFldsEN.CtlTypeId = objDT.Rows[0][conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objDGRegionFldsEN.DgFuncTypeId = objDT.Rows[0][conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id(字段类型:char,字段长度:4,是否可空:False)
 objDGRegionFldsEN.IsNeedSort = TransNullToBool(objDT.Rows[0][conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objDGRegionFldsEN.IsDefaultSort = TransNullToBool(objDT.Rows[0][conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序(字段类型:bit,字段长度:1,是否可空:False)
 objDGRegionFldsEN.IsTransToChkBox = TransNullToBool(objDT.Rows[0][conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox(字段类型:bit,字段长度:1,是否可空:True)
 objDGRegionFldsEN.IsVisible = TransNullToBool(objDT.Rows[0][conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objDGRegionFldsEN.IsFuncFld = TransNullToBool(objDT.Rows[0][conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段(字段类型:bit,字段长度:1,是否可空:True)
 objDGRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][conDGRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objDGRegionFldsEN.ErrMsg = objDT.Rows[0][conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objDGRegionFldsEN.PrjId = objDT.Rows[0][conDGRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDGRegionFldsEN.UpdUser = objDT.Rows[0][conDGRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDGRegionFldsEN.UpdDate = objDT.Rows[0][conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDGRegionFldsEN.Memo = objDT.Rows[0][conDGRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDGRegionFldsDA: GetDGRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsDGRegionFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DGRegionFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
 objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId(字段类型:char,字段长度:8,是否可空:True)
 objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式(字段类型:varchar,字段长度:50,是否可空:False)
 objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头(字段类型:varchar,字段长度:100,是否可空:False)
 objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字(字段类型:varchar,字段长度:150,是否可空:True)
 objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id(字段类型:char,字段长度:4,是否可空:False)
 objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序(字段类型:bit,字段长度:1,是否可空:False)
 objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox(字段类型:bit,字段长度:1,是否可空:True)
 objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段(字段类型:bit,字段长度:1,是否可空:True)
 objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDGRegionFldsDA: GetObjBymId)", objException.Message));
}
return objDGRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDGRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDGRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DGRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN()
{
mId = TransNullToInt(objRow[conDGRegionFlds.mId].ToString().Trim()), //mId
RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(), //区域Id
FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(), //字段Id
OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(), //OutFldId
SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(), //排序表达式
SeqNum = TransNullToInt(objRow[conDGRegionFlds.SeqNum].ToString().Trim()), //字段序号
HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(), //列头
ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(), //提示文字
CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(), //控件类型号
DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(), //Dg功能类型Id
IsNeedSort = TransNullToBool(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()), //是否需要排序
IsDefaultSort = TransNullToBool(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()), //是否默认排序
IsTransToChkBox = TransNullToBool(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()), //是否转换成CheckBox
IsVisible = TransNullToBool(objRow[conDGRegionFlds.IsVisible].ToString().Trim()), //是否显示
IsFuncFld = TransNullToBool(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()), //是否功能字段
InUse = TransNullToBool(objRow[conDGRegionFlds.InUse].ToString().Trim()), //是否在用
ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim() //说明
};
objDGRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDGRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDGRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDGRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = TransNullToInt(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = TransNullToInt(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = TransNullToBool(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = TransNullToBool(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = TransNullToBool(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = TransNullToBool(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = TransNullToBool(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDGRegionFldsDA: GetObjByDataRowDGRegionFlds)", objException.Message));
}
objDGRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDGRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDGRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = TransNullToInt(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = TransNullToInt(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = TransNullToBool(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = TransNullToBool(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = TransNullToBool(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = TransNullToBool(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = TransNullToBool(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDGRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objDGRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDGRegionFldsEN;
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
objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDGRegionFldsEN._CurrTabName, conDGRegionFlds.mId, 8, "");
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
objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDGRegionFldsEN._CurrTabName, conDGRegionFlds.mId, 8, strPrefix);
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from DGRegionFlds where " + strCondition;
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from DGRegionFlds where " + strCondition;
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DGRegionFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDGRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DGRegionFlds", strCondition))
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
objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DGRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDGRegionFldsEN objDGRegionFldsEN)
 {
 objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDGRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDGRegionFldsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DGRegionFlds where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DGRegionFlds");
objRow = objDS.Tables["DGRegionFlds"].NewRow();
objRow[conDGRegionFlds.RegionId] = objDGRegionFldsEN.RegionId; //区域Id
 if (objDGRegionFldsEN.FldId !=  "")
 {
objRow[conDGRegionFlds.FldId] = objDGRegionFldsEN.FldId; //字段Id
 }
 if (objDGRegionFldsEN.OutFldId !=  "")
 {
objRow[conDGRegionFlds.OutFldId] = objDGRegionFldsEN.OutFldId; //OutFldId
 }
 if (objDGRegionFldsEN.SortExpression !=  "")
 {
objRow[conDGRegionFlds.SortExpression] = objDGRegionFldsEN.SortExpression; //排序表达式
 }
objRow[conDGRegionFlds.SeqNum] = objDGRegionFldsEN.SeqNum; //字段序号
 if (objDGRegionFldsEN.HeaderText !=  "")
 {
objRow[conDGRegionFlds.HeaderText] = objDGRegionFldsEN.HeaderText; //列头
 }
 if (objDGRegionFldsEN.ToolTipText !=  "")
 {
objRow[conDGRegionFlds.ToolTipText] = objDGRegionFldsEN.ToolTipText; //提示文字
 }
objRow[conDGRegionFlds.CtlTypeId] = objDGRegionFldsEN.CtlTypeId; //控件类型号
 if (objDGRegionFldsEN.DgFuncTypeId !=  "")
 {
objRow[conDGRegionFlds.DgFuncTypeId] = objDGRegionFldsEN.DgFuncTypeId; //Dg功能类型Id
 }
objRow[conDGRegionFlds.IsNeedSort] = objDGRegionFldsEN.IsNeedSort; //是否需要排序
objRow[conDGRegionFlds.IsDefaultSort] = objDGRegionFldsEN.IsDefaultSort; //是否默认排序
objRow[conDGRegionFlds.IsTransToChkBox] = objDGRegionFldsEN.IsTransToChkBox; //是否转换成CheckBox
objRow[conDGRegionFlds.IsVisible] = objDGRegionFldsEN.IsVisible; //是否显示
objRow[conDGRegionFlds.IsFuncFld] = objDGRegionFldsEN.IsFuncFld; //是否功能字段
objRow[conDGRegionFlds.InUse] = objDGRegionFldsEN.InUse; //是否在用
 if (objDGRegionFldsEN.ErrMsg !=  "")
 {
objRow[conDGRegionFlds.ErrMsg] = objDGRegionFldsEN.ErrMsg; //错误信息
 }
objRow[conDGRegionFlds.PrjId] = objDGRegionFldsEN.PrjId; //工程Id
objRow[conDGRegionFlds.UpdUser] = objDGRegionFldsEN.UpdUser; //修改者
 if (objDGRegionFldsEN.UpdDate !=  "")
 {
objRow[conDGRegionFlds.UpdDate] = objDGRegionFldsEN.UpdDate; //修改日期
 }
 if (objDGRegionFldsEN.Memo !=  "")
 {
objRow[conDGRegionFlds.Memo] = objDGRegionFldsEN.Memo; //说明
 }
objDS.Tables[clsDGRegionFldsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDGRegionFldsEN._CurrTabName);
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
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDGRegionFldsEN objDGRegionFldsEN)
{
 objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDGRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDGRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDGRegionFldsEN.RegionId  ==  "")
 {
 objDGRegionFldsEN.RegionId = null;
 }
 if (objDGRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.RegionId);
 var strRegionId = objDGRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objDGRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.FldId);
 var strFldId = objDGRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDGRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.OutFldId);
 var strOutFldId = objDGRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objDGRegionFldsEN.SortExpression !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.SortExpression);
 var strSortExpression = objDGRegionFldsEN.SortExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSortExpression + "'");
 }
 
 arrFieldListForInsert.Add(conDGRegionFlds.SeqNum);
 arrValueListForInsert.Add(objDGRegionFldsEN.SeqNum.ToString());
 
 if (objDGRegionFldsEN.HeaderText !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.HeaderText);
 var strHeaderText = objDGRegionFldsEN.HeaderText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeaderText + "'");
 }
 
 if (objDGRegionFldsEN.ToolTipText !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.ToolTipText);
 var strToolTipText = objDGRegionFldsEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strToolTipText + "'");
 }
 
 if (objDGRegionFldsEN.CtlTypeId  ==  "")
 {
 objDGRegionFldsEN.CtlTypeId = null;
 }
 if (objDGRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.CtlTypeId);
 var strCtlTypeId = objDGRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objDGRegionFldsEN.DgFuncTypeId  ==  "")
 {
 objDGRegionFldsEN.DgFuncTypeId = null;
 }
 if (objDGRegionFldsEN.DgFuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.DgFuncTypeId);
 var strDgFuncTypeId = objDGRegionFldsEN.DgFuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsNeedSort);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsDefaultSort);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsDefaultSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsTransToChkBox);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsTransToChkBox  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsVisible);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsFuncFld);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsFuncFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objDGRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.ErrMsg);
 var strErrMsg = objDGRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDGRegionFldsEN.PrjId  ==  "")
 {
 objDGRegionFldsEN.PrjId = null;
 }
 if (objDGRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.PrjId);
 var strPrjId = objDGRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDGRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.UpdUser);
 var strUpdUser = objDGRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDGRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.UpdDate);
 var strUpdDate = objDGRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDGRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.Memo);
 var strMemo = objDGRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DGRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDGRegionFldsEN objDGRegionFldsEN)
{
 objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDGRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDGRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDGRegionFldsEN.RegionId  ==  "")
 {
 objDGRegionFldsEN.RegionId = null;
 }
 if (objDGRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.RegionId);
 var strRegionId = objDGRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objDGRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.FldId);
 var strFldId = objDGRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDGRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.OutFldId);
 var strOutFldId = objDGRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objDGRegionFldsEN.SortExpression !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.SortExpression);
 var strSortExpression = objDGRegionFldsEN.SortExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSortExpression + "'");
 }
 
 arrFieldListForInsert.Add(conDGRegionFlds.SeqNum);
 arrValueListForInsert.Add(objDGRegionFldsEN.SeqNum.ToString());
 
 if (objDGRegionFldsEN.HeaderText !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.HeaderText);
 var strHeaderText = objDGRegionFldsEN.HeaderText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeaderText + "'");
 }
 
 if (objDGRegionFldsEN.ToolTipText !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.ToolTipText);
 var strToolTipText = objDGRegionFldsEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strToolTipText + "'");
 }
 
 if (objDGRegionFldsEN.CtlTypeId  ==  "")
 {
 objDGRegionFldsEN.CtlTypeId = null;
 }
 if (objDGRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.CtlTypeId);
 var strCtlTypeId = objDGRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objDGRegionFldsEN.DgFuncTypeId  ==  "")
 {
 objDGRegionFldsEN.DgFuncTypeId = null;
 }
 if (objDGRegionFldsEN.DgFuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.DgFuncTypeId);
 var strDgFuncTypeId = objDGRegionFldsEN.DgFuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsNeedSort);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsDefaultSort);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsDefaultSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsTransToChkBox);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsTransToChkBox  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsVisible);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsFuncFld);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsFuncFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objDGRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.ErrMsg);
 var strErrMsg = objDGRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDGRegionFldsEN.PrjId  ==  "")
 {
 objDGRegionFldsEN.PrjId = null;
 }
 if (objDGRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.PrjId);
 var strPrjId = objDGRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDGRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.UpdUser);
 var strUpdUser = objDGRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDGRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.UpdDate);
 var strUpdDate = objDGRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDGRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.Memo);
 var strMemo = objDGRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DGRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDGRegionFldsEN objDGRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDGRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDGRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDGRegionFldsEN.RegionId  ==  "")
 {
 objDGRegionFldsEN.RegionId = null;
 }
 if (objDGRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.RegionId);
 var strRegionId = objDGRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objDGRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.FldId);
 var strFldId = objDGRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDGRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.OutFldId);
 var strOutFldId = objDGRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objDGRegionFldsEN.SortExpression !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.SortExpression);
 var strSortExpression = objDGRegionFldsEN.SortExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSortExpression + "'");
 }
 
 arrFieldListForInsert.Add(conDGRegionFlds.SeqNum);
 arrValueListForInsert.Add(objDGRegionFldsEN.SeqNum.ToString());
 
 if (objDGRegionFldsEN.HeaderText !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.HeaderText);
 var strHeaderText = objDGRegionFldsEN.HeaderText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeaderText + "'");
 }
 
 if (objDGRegionFldsEN.ToolTipText !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.ToolTipText);
 var strToolTipText = objDGRegionFldsEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strToolTipText + "'");
 }
 
 if (objDGRegionFldsEN.CtlTypeId  ==  "")
 {
 objDGRegionFldsEN.CtlTypeId = null;
 }
 if (objDGRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.CtlTypeId);
 var strCtlTypeId = objDGRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objDGRegionFldsEN.DgFuncTypeId  ==  "")
 {
 objDGRegionFldsEN.DgFuncTypeId = null;
 }
 if (objDGRegionFldsEN.DgFuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.DgFuncTypeId);
 var strDgFuncTypeId = objDGRegionFldsEN.DgFuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsNeedSort);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsDefaultSort);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsDefaultSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsTransToChkBox);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsTransToChkBox  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsVisible);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsFuncFld);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsFuncFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objDGRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.ErrMsg);
 var strErrMsg = objDGRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDGRegionFldsEN.PrjId  ==  "")
 {
 objDGRegionFldsEN.PrjId = null;
 }
 if (objDGRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.PrjId);
 var strPrjId = objDGRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDGRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.UpdUser);
 var strUpdUser = objDGRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDGRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.UpdDate);
 var strUpdDate = objDGRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDGRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.Memo);
 var strMemo = objDGRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DGRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDGRegionFldsEN objDGRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDGRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDGRegionFldsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDGRegionFldsEN.RegionId  ==  "")
 {
 objDGRegionFldsEN.RegionId = null;
 }
 if (objDGRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.RegionId);
 var strRegionId = objDGRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objDGRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.FldId);
 var strFldId = objDGRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDGRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.OutFldId);
 var strOutFldId = objDGRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objDGRegionFldsEN.SortExpression !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.SortExpression);
 var strSortExpression = objDGRegionFldsEN.SortExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSortExpression + "'");
 }
 
 arrFieldListForInsert.Add(conDGRegionFlds.SeqNum);
 arrValueListForInsert.Add(objDGRegionFldsEN.SeqNum.ToString());
 
 if (objDGRegionFldsEN.HeaderText !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.HeaderText);
 var strHeaderText = objDGRegionFldsEN.HeaderText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeaderText + "'");
 }
 
 if (objDGRegionFldsEN.ToolTipText !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.ToolTipText);
 var strToolTipText = objDGRegionFldsEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strToolTipText + "'");
 }
 
 if (objDGRegionFldsEN.CtlTypeId  ==  "")
 {
 objDGRegionFldsEN.CtlTypeId = null;
 }
 if (objDGRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.CtlTypeId);
 var strCtlTypeId = objDGRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objDGRegionFldsEN.DgFuncTypeId  ==  "")
 {
 objDGRegionFldsEN.DgFuncTypeId = null;
 }
 if (objDGRegionFldsEN.DgFuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.DgFuncTypeId);
 var strDgFuncTypeId = objDGRegionFldsEN.DgFuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsNeedSort);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsDefaultSort);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsDefaultSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsTransToChkBox);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsTransToChkBox  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsVisible);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.IsFuncFld);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.IsFuncFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDGRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objDGRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objDGRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.ErrMsg);
 var strErrMsg = objDGRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDGRegionFldsEN.PrjId  ==  "")
 {
 objDGRegionFldsEN.PrjId = null;
 }
 if (objDGRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.PrjId);
 var strPrjId = objDGRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDGRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.UpdUser);
 var strUpdUser = objDGRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDGRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.UpdDate);
 var strUpdDate = objDGRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDGRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDGRegionFlds.Memo);
 var strMemo = objDGRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DGRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDGRegionFldss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DGRegionFlds where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DGRegionFlds");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conDGRegionFlds.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDGRegionFldsEN._CurrTabName ].NewRow();
objRow[conDGRegionFlds.RegionId] = oRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objRow[conDGRegionFlds.FldId] = oRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objRow[conDGRegionFlds.OutFldId] = oRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objRow[conDGRegionFlds.SortExpression] = oRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objRow[conDGRegionFlds.SeqNum] = oRow[conDGRegionFlds.SeqNum].ToString().Trim(); //字段序号
objRow[conDGRegionFlds.HeaderText] = oRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objRow[conDGRegionFlds.ToolTipText] = oRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objRow[conDGRegionFlds.CtlTypeId] = oRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objRow[conDGRegionFlds.DgFuncTypeId] = oRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objRow[conDGRegionFlds.IsNeedSort] = oRow[conDGRegionFlds.IsNeedSort].ToString().Trim(); //是否需要排序
objRow[conDGRegionFlds.IsDefaultSort] = oRow[conDGRegionFlds.IsDefaultSort].ToString().Trim(); //是否默认排序
objRow[conDGRegionFlds.IsTransToChkBox] = oRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim(); //是否转换成CheckBox
objRow[conDGRegionFlds.IsVisible] = oRow[conDGRegionFlds.IsVisible].ToString().Trim(); //是否显示
objRow[conDGRegionFlds.IsFuncFld] = oRow[conDGRegionFlds.IsFuncFld].ToString().Trim(); //是否功能字段
objRow[conDGRegionFlds.InUse] = oRow[conDGRegionFlds.InUse].ToString().Trim(); //是否在用
objRow[conDGRegionFlds.ErrMsg] = oRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objRow[conDGRegionFlds.PrjId] = oRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objRow[conDGRegionFlds.UpdUser] = oRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objRow[conDGRegionFlds.UpdDate] = oRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objRow[conDGRegionFlds.Memo] = oRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDGRegionFldsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDGRegionFldsEN._CurrTabName);
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
 /// <param name = "objDGRegionFldsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDGRegionFldsEN objDGRegionFldsEN)
{
 objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDGRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDGRegionFldsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DGRegionFlds where mId = " + ""+ objDGRegionFldsEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDGRegionFldsEN._CurrTabName);
if (objDS.Tables[clsDGRegionFldsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objDGRegionFldsEN.mId+"");
return false;
}
objRow = objDS.Tables[clsDGRegionFldsEN._CurrTabName].Rows[0];
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.RegionId))
 {
objRow[conDGRegionFlds.RegionId] = objDGRegionFldsEN.RegionId; //区域Id
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.FldId))
 {
objRow[conDGRegionFlds.FldId] = objDGRegionFldsEN.FldId; //字段Id
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.OutFldId))
 {
objRow[conDGRegionFlds.OutFldId] = objDGRegionFldsEN.OutFldId; //OutFldId
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.SortExpression))
 {
objRow[conDGRegionFlds.SortExpression] = objDGRegionFldsEN.SortExpression; //排序表达式
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.SeqNum))
 {
objRow[conDGRegionFlds.SeqNum] = objDGRegionFldsEN.SeqNum; //字段序号
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.HeaderText))
 {
objRow[conDGRegionFlds.HeaderText] = objDGRegionFldsEN.HeaderText; //列头
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.ToolTipText))
 {
objRow[conDGRegionFlds.ToolTipText] = objDGRegionFldsEN.ToolTipText; //提示文字
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.CtlTypeId))
 {
objRow[conDGRegionFlds.CtlTypeId] = objDGRegionFldsEN.CtlTypeId; //控件类型号
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.DgFuncTypeId))
 {
objRow[conDGRegionFlds.DgFuncTypeId] = objDGRegionFldsEN.DgFuncTypeId; //Dg功能类型Id
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsNeedSort))
 {
objRow[conDGRegionFlds.IsNeedSort] = objDGRegionFldsEN.IsNeedSort; //是否需要排序
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsDefaultSort))
 {
objRow[conDGRegionFlds.IsDefaultSort] = objDGRegionFldsEN.IsDefaultSort; //是否默认排序
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsTransToChkBox))
 {
objRow[conDGRegionFlds.IsTransToChkBox] = objDGRegionFldsEN.IsTransToChkBox; //是否转换成CheckBox
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsVisible))
 {
objRow[conDGRegionFlds.IsVisible] = objDGRegionFldsEN.IsVisible; //是否显示
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsFuncFld))
 {
objRow[conDGRegionFlds.IsFuncFld] = objDGRegionFldsEN.IsFuncFld; //是否功能字段
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.InUse))
 {
objRow[conDGRegionFlds.InUse] = objDGRegionFldsEN.InUse; //是否在用
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.ErrMsg))
 {
objRow[conDGRegionFlds.ErrMsg] = objDGRegionFldsEN.ErrMsg; //错误信息
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.PrjId))
 {
objRow[conDGRegionFlds.PrjId] = objDGRegionFldsEN.PrjId; //工程Id
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.UpdUser))
 {
objRow[conDGRegionFlds.UpdUser] = objDGRegionFldsEN.UpdUser; //修改者
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.UpdDate))
 {
objRow[conDGRegionFlds.UpdDate] = objDGRegionFldsEN.UpdDate; //修改日期
 }
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.Memo))
 {
objRow[conDGRegionFlds.Memo] = objDGRegionFldsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDGRegionFldsEN._CurrTabName);
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
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDGRegionFldsEN objDGRegionFldsEN)
{
 objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDGRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDGRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DGRegionFlds Set ");
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.RegionId))
 {
 if (objDGRegionFldsEN.RegionId  ==  "")
 {
 objDGRegionFldsEN.RegionId = null;
 }
 if (objDGRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objDGRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conDGRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.FldId))
 {
 if (objDGRegionFldsEN.FldId !=  null)
 {
 var strFldId = objDGRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conDGRegionFlds.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.FldId); //字段Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.OutFldId))
 {
 if (objDGRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objDGRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldId, conDGRegionFlds.OutFldId); //OutFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.OutFldId); //OutFldId
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.SortExpression))
 {
 if (objDGRegionFldsEN.SortExpression !=  null)
 {
 var strSortExpression = objDGRegionFldsEN.SortExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSortExpression, conDGRegionFlds.SortExpression); //排序表达式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.SortExpression); //排序表达式
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.SeqNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objDGRegionFldsEN.SeqNum, conDGRegionFlds.SeqNum); //字段序号
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.HeaderText))
 {
 if (objDGRegionFldsEN.HeaderText !=  null)
 {
 var strHeaderText = objDGRegionFldsEN.HeaderText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHeaderText, conDGRegionFlds.HeaderText); //列头
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.HeaderText); //列头
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.ToolTipText))
 {
 if (objDGRegionFldsEN.ToolTipText !=  null)
 {
 var strToolTipText = objDGRegionFldsEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strToolTipText, conDGRegionFlds.ToolTipText); //提示文字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.ToolTipText); //提示文字
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.CtlTypeId))
 {
 if (objDGRegionFldsEN.CtlTypeId  ==  "")
 {
 objDGRegionFldsEN.CtlTypeId = null;
 }
 if (objDGRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objDGRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conDGRegionFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.DgFuncTypeId))
 {
 if (objDGRegionFldsEN.DgFuncTypeId  ==  "")
 {
 objDGRegionFldsEN.DgFuncTypeId = null;
 }
 if (objDGRegionFldsEN.DgFuncTypeId !=  null)
 {
 var strDgFuncTypeId = objDGRegionFldsEN.DgFuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDgFuncTypeId, conDGRegionFlds.DgFuncTypeId); //Dg功能类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.DgFuncTypeId); //Dg功能类型Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsNeedSort))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.IsNeedSort == true?"1":"0", conDGRegionFlds.IsNeedSort); //是否需要排序
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsDefaultSort))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.IsDefaultSort == true?"1":"0", conDGRegionFlds.IsDefaultSort); //是否默认排序
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsTransToChkBox))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.IsTransToChkBox == true?"1":"0", conDGRegionFlds.IsTransToChkBox); //是否转换成CheckBox
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.IsVisible == true?"1":"0", conDGRegionFlds.IsVisible); //是否显示
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsFuncFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.IsFuncFld == true?"1":"0", conDGRegionFlds.IsFuncFld); //是否功能字段
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.InUse == true?"1":"0", conDGRegionFlds.InUse); //是否在用
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.ErrMsg))
 {
 if (objDGRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objDGRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conDGRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.PrjId))
 {
 if (objDGRegionFldsEN.PrjId  ==  "")
 {
 objDGRegionFldsEN.PrjId = null;
 }
 if (objDGRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objDGRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDGRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.UpdUser))
 {
 if (objDGRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objDGRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDGRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.UpdDate))
 {
 if (objDGRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objDGRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDGRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.Memo))
 {
 if (objDGRegionFldsEN.Memo !=  null)
 {
 var strMemo = objDGRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDGRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objDGRegionFldsEN.mId); 
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
 /// <param name = "objDGRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDGRegionFldsEN objDGRegionFldsEN, string strCondition)
{
 objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDGRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDGRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DGRegionFlds Set ");
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.RegionId))
 {
 if (objDGRegionFldsEN.RegionId  ==  "")
 {
 objDGRegionFldsEN.RegionId = null;
 }
 if (objDGRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objDGRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.FldId))
 {
 if (objDGRegionFldsEN.FldId !=  null)
 {
 var strFldId = objDGRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.OutFldId))
 {
 if (objDGRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objDGRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldId = '{0}',", strOutFldId); //OutFldId
 }
 else
 {
 sbSQL.Append(" OutFldId = null,"); //OutFldId
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.SortExpression))
 {
 if (objDGRegionFldsEN.SortExpression !=  null)
 {
 var strSortExpression = objDGRegionFldsEN.SortExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SortExpression = '{0}',", strSortExpression); //排序表达式
 }
 else
 {
 sbSQL.Append(" SortExpression = null,"); //排序表达式
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.SeqNum))
 {
 sbSQL.AppendFormat(" SeqNum = {0},", objDGRegionFldsEN.SeqNum); //字段序号
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.HeaderText))
 {
 if (objDGRegionFldsEN.HeaderText !=  null)
 {
 var strHeaderText = objDGRegionFldsEN.HeaderText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HeaderText = '{0}',", strHeaderText); //列头
 }
 else
 {
 sbSQL.Append(" HeaderText = null,"); //列头
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.ToolTipText))
 {
 if (objDGRegionFldsEN.ToolTipText !=  null)
 {
 var strToolTipText = objDGRegionFldsEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ToolTipText = '{0}',", strToolTipText); //提示文字
 }
 else
 {
 sbSQL.Append(" ToolTipText = null,"); //提示文字
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.CtlTypeId))
 {
 if (objDGRegionFldsEN.CtlTypeId  ==  "")
 {
 objDGRegionFldsEN.CtlTypeId = null;
 }
 if (objDGRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objDGRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.DgFuncTypeId))
 {
 if (objDGRegionFldsEN.DgFuncTypeId  ==  "")
 {
 objDGRegionFldsEN.DgFuncTypeId = null;
 }
 if (objDGRegionFldsEN.DgFuncTypeId !=  null)
 {
 var strDgFuncTypeId = objDGRegionFldsEN.DgFuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DgFuncTypeId = '{0}',", strDgFuncTypeId); //Dg功能类型Id
 }
 else
 {
 sbSQL.Append(" DgFuncTypeId = null,"); //Dg功能类型Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsNeedSort))
 {
 sbSQL.AppendFormat(" IsNeedSort = '{0}',", objDGRegionFldsEN.IsNeedSort == true?"1":"0"); //是否需要排序
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsDefaultSort))
 {
 sbSQL.AppendFormat(" IsDefaultSort = '{0}',", objDGRegionFldsEN.IsDefaultSort == true?"1":"0"); //是否默认排序
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsTransToChkBox))
 {
 sbSQL.AppendFormat(" IsTransToChkBox = '{0}',", objDGRegionFldsEN.IsTransToChkBox == true?"1":"0"); //是否转换成CheckBox
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objDGRegionFldsEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsFuncFld))
 {
 sbSQL.AppendFormat(" IsFuncFld = '{0}',", objDGRegionFldsEN.IsFuncFld == true?"1":"0"); //是否功能字段
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objDGRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.ErrMsg))
 {
 if (objDGRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objDGRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.PrjId))
 {
 if (objDGRegionFldsEN.PrjId  ==  "")
 {
 objDGRegionFldsEN.PrjId = null;
 }
 if (objDGRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objDGRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.UpdUser))
 {
 if (objDGRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objDGRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.UpdDate))
 {
 if (objDGRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objDGRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.Memo))
 {
 if (objDGRegionFldsEN.Memo !=  null)
 {
 var strMemo = objDGRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDGRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDGRegionFldsEN objDGRegionFldsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDGRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDGRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DGRegionFlds Set ");
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.RegionId))
 {
 if (objDGRegionFldsEN.RegionId  ==  "")
 {
 objDGRegionFldsEN.RegionId = null;
 }
 if (objDGRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objDGRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.FldId))
 {
 if (objDGRegionFldsEN.FldId !=  null)
 {
 var strFldId = objDGRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.OutFldId))
 {
 if (objDGRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objDGRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldId = '{0}',", strOutFldId); //OutFldId
 }
 else
 {
 sbSQL.Append(" OutFldId = null,"); //OutFldId
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.SortExpression))
 {
 if (objDGRegionFldsEN.SortExpression !=  null)
 {
 var strSortExpression = objDGRegionFldsEN.SortExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SortExpression = '{0}',", strSortExpression); //排序表达式
 }
 else
 {
 sbSQL.Append(" SortExpression = null,"); //排序表达式
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.SeqNum))
 {
 sbSQL.AppendFormat(" SeqNum = {0},", objDGRegionFldsEN.SeqNum); //字段序号
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.HeaderText))
 {
 if (objDGRegionFldsEN.HeaderText !=  null)
 {
 var strHeaderText = objDGRegionFldsEN.HeaderText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HeaderText = '{0}',", strHeaderText); //列头
 }
 else
 {
 sbSQL.Append(" HeaderText = null,"); //列头
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.ToolTipText))
 {
 if (objDGRegionFldsEN.ToolTipText !=  null)
 {
 var strToolTipText = objDGRegionFldsEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ToolTipText = '{0}',", strToolTipText); //提示文字
 }
 else
 {
 sbSQL.Append(" ToolTipText = null,"); //提示文字
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.CtlTypeId))
 {
 if (objDGRegionFldsEN.CtlTypeId  ==  "")
 {
 objDGRegionFldsEN.CtlTypeId = null;
 }
 if (objDGRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objDGRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.DgFuncTypeId))
 {
 if (objDGRegionFldsEN.DgFuncTypeId  ==  "")
 {
 objDGRegionFldsEN.DgFuncTypeId = null;
 }
 if (objDGRegionFldsEN.DgFuncTypeId !=  null)
 {
 var strDgFuncTypeId = objDGRegionFldsEN.DgFuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DgFuncTypeId = '{0}',", strDgFuncTypeId); //Dg功能类型Id
 }
 else
 {
 sbSQL.Append(" DgFuncTypeId = null,"); //Dg功能类型Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsNeedSort))
 {
 sbSQL.AppendFormat(" IsNeedSort = '{0}',", objDGRegionFldsEN.IsNeedSort == true?"1":"0"); //是否需要排序
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsDefaultSort))
 {
 sbSQL.AppendFormat(" IsDefaultSort = '{0}',", objDGRegionFldsEN.IsDefaultSort == true?"1":"0"); //是否默认排序
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsTransToChkBox))
 {
 sbSQL.AppendFormat(" IsTransToChkBox = '{0}',", objDGRegionFldsEN.IsTransToChkBox == true?"1":"0"); //是否转换成CheckBox
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objDGRegionFldsEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsFuncFld))
 {
 sbSQL.AppendFormat(" IsFuncFld = '{0}',", objDGRegionFldsEN.IsFuncFld == true?"1":"0"); //是否功能字段
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objDGRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.ErrMsg))
 {
 if (objDGRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objDGRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.PrjId))
 {
 if (objDGRegionFldsEN.PrjId  ==  "")
 {
 objDGRegionFldsEN.PrjId = null;
 }
 if (objDGRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objDGRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.UpdUser))
 {
 if (objDGRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objDGRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.UpdDate))
 {
 if (objDGRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objDGRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.Memo))
 {
 if (objDGRegionFldsEN.Memo !=  null)
 {
 var strMemo = objDGRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDGRegionFldsEN objDGRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDGRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDGRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DGRegionFlds Set ");
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.RegionId))
 {
 if (objDGRegionFldsEN.RegionId  ==  "")
 {
 objDGRegionFldsEN.RegionId = null;
 }
 if (objDGRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objDGRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conDGRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.FldId))
 {
 if (objDGRegionFldsEN.FldId !=  null)
 {
 var strFldId = objDGRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conDGRegionFlds.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.FldId); //字段Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.OutFldId))
 {
 if (objDGRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objDGRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldId, conDGRegionFlds.OutFldId); //OutFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.OutFldId); //OutFldId
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.SortExpression))
 {
 if (objDGRegionFldsEN.SortExpression !=  null)
 {
 var strSortExpression = objDGRegionFldsEN.SortExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSortExpression, conDGRegionFlds.SortExpression); //排序表达式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.SortExpression); //排序表达式
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.SeqNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objDGRegionFldsEN.SeqNum, conDGRegionFlds.SeqNum); //字段序号
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.HeaderText))
 {
 if (objDGRegionFldsEN.HeaderText !=  null)
 {
 var strHeaderText = objDGRegionFldsEN.HeaderText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHeaderText, conDGRegionFlds.HeaderText); //列头
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.HeaderText); //列头
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.ToolTipText))
 {
 if (objDGRegionFldsEN.ToolTipText !=  null)
 {
 var strToolTipText = objDGRegionFldsEN.ToolTipText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strToolTipText, conDGRegionFlds.ToolTipText); //提示文字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.ToolTipText); //提示文字
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.CtlTypeId))
 {
 if (objDGRegionFldsEN.CtlTypeId  ==  "")
 {
 objDGRegionFldsEN.CtlTypeId = null;
 }
 if (objDGRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objDGRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conDGRegionFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.DgFuncTypeId))
 {
 if (objDGRegionFldsEN.DgFuncTypeId  ==  "")
 {
 objDGRegionFldsEN.DgFuncTypeId = null;
 }
 if (objDGRegionFldsEN.DgFuncTypeId !=  null)
 {
 var strDgFuncTypeId = objDGRegionFldsEN.DgFuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDgFuncTypeId, conDGRegionFlds.DgFuncTypeId); //Dg功能类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.DgFuncTypeId); //Dg功能类型Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsNeedSort))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.IsNeedSort == true?"1":"0", conDGRegionFlds.IsNeedSort); //是否需要排序
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsDefaultSort))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.IsDefaultSort == true?"1":"0", conDGRegionFlds.IsDefaultSort); //是否默认排序
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsTransToChkBox))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.IsTransToChkBox == true?"1":"0", conDGRegionFlds.IsTransToChkBox); //是否转换成CheckBox
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.IsVisible == true?"1":"0", conDGRegionFlds.IsVisible); //是否显示
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.IsFuncFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.IsFuncFld == true?"1":"0", conDGRegionFlds.IsFuncFld); //是否功能字段
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDGRegionFldsEN.InUse == true?"1":"0", conDGRegionFlds.InUse); //是否在用
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.ErrMsg))
 {
 if (objDGRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objDGRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conDGRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.PrjId))
 {
 if (objDGRegionFldsEN.PrjId  ==  "")
 {
 objDGRegionFldsEN.PrjId = null;
 }
 if (objDGRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objDGRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDGRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.UpdUser))
 {
 if (objDGRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objDGRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDGRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.UpdDate))
 {
 if (objDGRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objDGRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDGRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objDGRegionFldsEN.IsUpdated(conDGRegionFlds.Memo))
 {
 if (objDGRegionFldsEN.Memo !=  null)
 {
 var strMemo = objDGRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDGRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDGRegionFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objDGRegionFldsEN.mId); 
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("DGRegionFlds_Delete", values);
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
//删除DGRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DGRegionFlds where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDGRegionFlds(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
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
//删除DGRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DGRegionFlds where mId in (" + strKeyList + ")";
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
//删除DGRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DGRegionFlds where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDGRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDGRegionFldsDA: DelDGRegionFlds)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DGRegionFlds where " + strCondition ;
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
public bool DelDGRegionFldsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDGRegionFldsDA: DelDGRegionFldsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DGRegionFlds where " + strCondition ;
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
 /// <param name = "objDGRegionFldsENS">源对象</param>
 /// <param name = "objDGRegionFldsENT">目标对象</param>
public void CopyTo(clsDGRegionFldsEN objDGRegionFldsENS, clsDGRegionFldsEN objDGRegionFldsENT)
{
objDGRegionFldsENT.mId = objDGRegionFldsENS.mId; //mId
objDGRegionFldsENT.RegionId = objDGRegionFldsENS.RegionId; //区域Id
objDGRegionFldsENT.FldId = objDGRegionFldsENS.FldId; //字段Id
objDGRegionFldsENT.OutFldId = objDGRegionFldsENS.OutFldId; //OutFldId
objDGRegionFldsENT.SortExpression = objDGRegionFldsENS.SortExpression; //排序表达式
objDGRegionFldsENT.SeqNum = objDGRegionFldsENS.SeqNum; //字段序号
objDGRegionFldsENT.HeaderText = objDGRegionFldsENS.HeaderText; //列头
objDGRegionFldsENT.ToolTipText = objDGRegionFldsENS.ToolTipText; //提示文字
objDGRegionFldsENT.CtlTypeId = objDGRegionFldsENS.CtlTypeId; //控件类型号
objDGRegionFldsENT.DgFuncTypeId = objDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objDGRegionFldsENT.IsNeedSort = objDGRegionFldsENS.IsNeedSort; //是否需要排序
objDGRegionFldsENT.IsDefaultSort = objDGRegionFldsENS.IsDefaultSort; //是否默认排序
objDGRegionFldsENT.IsTransToChkBox = objDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objDGRegionFldsENT.IsVisible = objDGRegionFldsENS.IsVisible; //是否显示
objDGRegionFldsENT.IsFuncFld = objDGRegionFldsENS.IsFuncFld; //是否功能字段
objDGRegionFldsENT.InUse = objDGRegionFldsENS.InUse; //是否在用
objDGRegionFldsENT.ErrMsg = objDGRegionFldsENS.ErrMsg; //错误信息
objDGRegionFldsENT.PrjId = objDGRegionFldsENS.PrjId; //工程Id
objDGRegionFldsENT.UpdUser = objDGRegionFldsENS.UpdUser; //修改者
objDGRegionFldsENT.UpdDate = objDGRegionFldsENS.UpdDate; //修改日期
objDGRegionFldsENT.Memo = objDGRegionFldsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDGRegionFldsEN objDGRegionFldsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDGRegionFldsEN.RegionId, conDGRegionFlds.RegionId);
clsCheckSql.CheckFieldNotNull(objDGRegionFldsEN.SeqNum, conDGRegionFlds.SeqNum);
clsCheckSql.CheckFieldNotNull(objDGRegionFldsEN.CtlTypeId, conDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldNotNull(objDGRegionFldsEN.IsNeedSort, conDGRegionFlds.IsNeedSort);
clsCheckSql.CheckFieldNotNull(objDGRegionFldsEN.PrjId, conDGRegionFlds.PrjId);
clsCheckSql.CheckFieldNotNull(objDGRegionFldsEN.UpdUser, conDGRegionFlds.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.RegionId, 10, conDGRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.FldId, 8, conDGRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.OutFldId, 8, conDGRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.SortExpression, 50, conDGRegionFlds.SortExpression);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.HeaderText, 100, conDGRegionFlds.HeaderText);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.ToolTipText, 150, conDGRegionFlds.ToolTipText);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.CtlTypeId, 2, conDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.DgFuncTypeId, 4, conDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.ErrMsg, 2000, conDGRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.PrjId, 4, conDGRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.UpdUser, 20, conDGRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.UpdDate, 20, conDGRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.Memo, 1000, conDGRegionFlds.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.RegionId, 10, conDGRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.CtlTypeId, 2, conDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.DgFuncTypeId, 4, conDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.PrjId, 4, conDGRegionFlds.PrjId);
 objDGRegionFldsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDGRegionFldsEN objDGRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.RegionId, 10, conDGRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.FldId, 8, conDGRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.OutFldId, 8, conDGRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.SortExpression, 50, conDGRegionFlds.SortExpression);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.HeaderText, 100, conDGRegionFlds.HeaderText);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.ToolTipText, 150, conDGRegionFlds.ToolTipText);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.CtlTypeId, 2, conDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.DgFuncTypeId, 4, conDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.ErrMsg, 2000, conDGRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.PrjId, 4, conDGRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.UpdUser, 20, conDGRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.UpdDate, 20, conDGRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.Memo, 1000, conDGRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.RegionId, 10, conDGRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.CtlTypeId, 2, conDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.DgFuncTypeId, 4, conDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.PrjId, 4, conDGRegionFlds.PrjId);
 objDGRegionFldsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDGRegionFldsEN objDGRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.RegionId, 10, conDGRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.FldId, 8, conDGRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.OutFldId, 8, conDGRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.SortExpression, 50, conDGRegionFlds.SortExpression);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.HeaderText, 100, conDGRegionFlds.HeaderText);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.ToolTipText, 150, conDGRegionFlds.ToolTipText);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.CtlTypeId, 2, conDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.DgFuncTypeId, 4, conDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.ErrMsg, 2000, conDGRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.PrjId, 4, conDGRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.UpdUser, 20, conDGRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.UpdDate, 20, conDGRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objDGRegionFldsEN.Memo, 1000, conDGRegionFlds.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.RegionId, conDGRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.FldId, conDGRegionFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.OutFldId, conDGRegionFlds.OutFldId);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.SortExpression, conDGRegionFlds.SortExpression);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.HeaderText, conDGRegionFlds.HeaderText);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.ToolTipText, conDGRegionFlds.ToolTipText);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.CtlTypeId, conDGRegionFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.DgFuncTypeId, conDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.ErrMsg, conDGRegionFlds.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.PrjId, conDGRegionFlds.PrjId);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.UpdUser, conDGRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.UpdDate, conDGRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDGRegionFldsEN.Memo, conDGRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.RegionId, 10, conDGRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.CtlTypeId, 2, conDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.DgFuncTypeId, 4, conDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckFieldForeignKey(objDGRegionFldsEN.PrjId, 4, conDGRegionFlds.PrjId);
 objDGRegionFldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DGRegionFlds(DG区域字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDGRegionFldsEN objDGRegionFldsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDGRegionFldsEN.RegionId);
 if (objDGRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null");
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objDGRegionFldsEN.FldId);
}
 if (objDGRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null");
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDGRegionFldsEN.OutFldId);
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDGRegionFldsEN._CurrTabName);
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDGRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}