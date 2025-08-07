
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDGRegionFldsDA
 表名:vDGRegionFlds(00050201)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:14
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
 /// vDG区域字段(vDGRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDGRegionFldsDA : clsCommBase4DA
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
 return clsvDGRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDGRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDGRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDGRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDGRegionFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDGRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDGRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA: GetDataTable_vDGRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDGRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDGRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDGRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDGRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDGRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDGRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDGRegionFlds.* " + 
$"from vDGRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDGRegionFlds.mId not in " + 
$"(Select top {intTop_In} vDGRegionFlds.mId from vDGRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDGRegionFlds where {1} and mId not in (Select top {2} mId from vDGRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDGRegionFlds where {1} and mId not in (Select top {3} mId from vDGRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDGRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDGRegionFlds.* " + 
$"from vDGRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDGRegionFlds.mId not in " + 
$"(Select top {intTop_In} vDGRegionFlds.mId from vDGRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDGRegionFlds where {1} and mId not in (Select top {2} mId from vDGRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDGRegionFlds where {1} and mId not in (Select top {3} mId from vDGRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDGRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDGRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = TransNullToInt(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = TransNullToInt(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = TransNullToBool(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = TransNullToBool(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = TransNullToBool(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = TransNullToBool(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = TransNullToBool(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDGRegionFldsDA: GetObjLst)", objException.Message));
}
objvDGRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDGRegionFldsEN);
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
public List<clsvDGRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDGRegionFldsEN> arrObjLst = new List<clsvDGRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = TransNullToInt(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = TransNullToInt(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = TransNullToBool(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = TransNullToBool(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = TransNullToBool(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = TransNullToBool(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = TransNullToBool(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDGRegionFldsDA: GetObjLst)", objException.Message));
}
objvDGRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDGRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDGRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDGRegionFlds(ref clsvDGRegionFldsEN objvDGRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDGRegionFlds where mId = " + ""+ objvDGRegionFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDGRegionFldsEN.mId = TransNullToInt(objDT.Rows[0][convDGRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvDGRegionFldsEN.RegionId = objDT.Rows[0][convDGRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvDGRegionFldsEN.RegionName = objDT.Rows[0][convDGRegionFlds.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvDGRegionFldsEN.TabId = objDT.Rows[0][convDGRegionFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDGRegionFldsEN.FldId = objDT.Rows[0][convDGRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvDGRegionFldsEN.FldName = objDT.Rows[0][convDGRegionFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDGRegionFldsEN.SortExpression = objDT.Rows[0][convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式(字段类型:varchar,字段长度:50,是否可空:False)
 objvDGRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvDGRegionFldsEN.HeaderText = objDT.Rows[0][convDGRegionFlds.HeaderText].ToString().Trim(); //列头(字段类型:varchar,字段长度:100,是否可空:False)
 objvDGRegionFldsEN.ToolTipText = objDT.Rows[0][convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字(字段类型:varchar,字段长度:150,是否可空:True)
 objvDGRegionFldsEN.CtlTypeId = objDT.Rows[0][convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvDGRegionFldsEN.CtlTypeName = objDT.Rows[0][convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvDGRegionFldsEN.CtlCnName = objDT.Rows[0][convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDGRegionFldsEN.DgFuncTypeId = objDT.Rows[0][convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvDGRegionFldsEN.DgFuncTypeName = objDT.Rows[0][convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvDGRegionFldsEN.IsNeedSort = TransNullToBool(objDT.Rows[0][convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objvDGRegionFldsEN.IsDefaultSort = TransNullToBool(objDT.Rows[0][convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序(字段类型:bit,字段长度:1,是否可空:False)
 objvDGRegionFldsEN.IsTransToChkBox = TransNullToBool(objDT.Rows[0][convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox(字段类型:bit,字段长度:1,是否可空:True)
 objvDGRegionFldsEN.IsVisible = TransNullToBool(objDT.Rows[0][convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvDGRegionFldsEN.IsFuncFld = TransNullToBool(objDT.Rows[0][convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段(字段类型:bit,字段长度:1,是否可空:True)
 objvDGRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][convDGRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvDGRegionFldsEN.UpdUser = objDT.Rows[0][convDGRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDGRegionFldsEN.UpdDate = objDT.Rows[0][convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDGRegionFldsEN.Memo = objDT.Rows[0][convDGRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDGRegionFldsEN.PrjId = objDT.Rows[0][convDGRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDGRegionFldsDA: GetvDGRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDGRegionFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDGRegionFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
 objvDGRegionFldsEN.mId = Int32.Parse(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式(字段类型:varchar,字段长度:50,是否可空:False)
 objvDGRegionFldsEN.SeqNum = Int32.Parse(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头(字段类型:varchar,字段长度:100,是否可空:False)
 objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字(字段类型:varchar,字段长度:150,是否可空:True)
 objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objvDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序(字段类型:bit,字段长度:1,是否可空:False)
 objvDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox(字段类型:bit,字段长度:1,是否可空:True)
 objvDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段(字段类型:bit,字段长度:1,是否可空:True)
 objvDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDGRegionFldsDA: GetObjBymId)", objException.Message));
}
return objvDGRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDGRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vDGRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN()
{
mId = TransNullToInt(objRow[convDGRegionFlds.mId].ToString().Trim()), //mId
RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(), //区域Id
RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(), //区域名称
TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(), //表ID
FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(), //字段Id
FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(), //字段名
SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(), //排序表达式
SeqNum = TransNullToInt(objRow[convDGRegionFlds.SeqNum].ToString().Trim()), //字段序号
HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(), //列头
ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(), //提示文字
CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(), //控件类型号
CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(), //控件类型名
CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(), //控件类型中文名
DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(), //Dg功能类型Id
DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(), //Dg功能类型名
IsNeedSort = TransNullToBool(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()), //是否需要排序
IsDefaultSort = TransNullToBool(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()), //是否默认排序
IsTransToChkBox = TransNullToBool(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()), //是否转换成CheckBox
IsVisible = TransNullToBool(objRow[convDGRegionFlds.IsVisible].ToString().Trim()), //是否显示
IsFuncFld = TransNullToBool(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()), //是否功能字段
InUse = TransNullToBool(objRow[convDGRegionFlds.InUse].ToString().Trim()), //是否在用
UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(), //说明
PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim() //工程Id
};
objvDGRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDGRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDGRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDGRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = TransNullToInt(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = TransNullToInt(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = TransNullToBool(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = TransNullToBool(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = TransNullToBool(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = TransNullToBool(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = TransNullToBool(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDGRegionFldsDA: GetObjByDataRowvDGRegionFlds)", objException.Message));
}
objvDGRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDGRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDGRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDGRegionFldsEN objvDGRegionFldsEN = new clsvDGRegionFldsEN();
try
{
objvDGRegionFldsEN.mId = TransNullToInt(objRow[convDGRegionFlds.mId].ToString().Trim()); //mId
objvDGRegionFldsEN.RegionId = objRow[convDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objvDGRegionFldsEN.RegionName = objRow[convDGRegionFlds.RegionName] == DBNull.Value ? null : objRow[convDGRegionFlds.RegionName].ToString().Trim(); //区域名称
objvDGRegionFldsEN.TabId = objRow[convDGRegionFlds.TabId] == DBNull.Value ? null : objRow[convDGRegionFlds.TabId].ToString().Trim(); //表ID
objvDGRegionFldsEN.FldId = objRow[convDGRegionFlds.FldId] == DBNull.Value ? null : objRow[convDGRegionFlds.FldId].ToString().Trim(); //字段Id
objvDGRegionFldsEN.FldName = objRow[convDGRegionFlds.FldName].ToString().Trim(); //字段名
objvDGRegionFldsEN.SortExpression = objRow[convDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[convDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objvDGRegionFldsEN.SeqNum = TransNullToInt(objRow[convDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvDGRegionFldsEN.HeaderText = objRow[convDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[convDGRegionFlds.HeaderText].ToString().Trim(); //列头
objvDGRegionFldsEN.ToolTipText = objRow[convDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[convDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objvDGRegionFldsEN.CtlTypeId = objRow[convDGRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvDGRegionFldsEN.CtlTypeName = objRow[convDGRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvDGRegionFldsEN.CtlCnName = objRow[convDGRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvDGRegionFldsEN.DgFuncTypeId = objRow[convDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objvDGRegionFldsEN.DgFuncTypeName = objRow[convDGRegionFlds.DgFuncTypeName].ToString().Trim(); //Dg功能类型名
objvDGRegionFldsEN.IsNeedSort = TransNullToBool(objRow[convDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objvDGRegionFldsEN.IsDefaultSort = TransNullToBool(objRow[convDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objvDGRegionFldsEN.IsTransToChkBox = TransNullToBool(objRow[convDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objvDGRegionFldsEN.IsVisible = TransNullToBool(objRow[convDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objvDGRegionFldsEN.IsFuncFld = TransNullToBool(objRow[convDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objvDGRegionFldsEN.InUse = TransNullToBool(objRow[convDGRegionFlds.InUse].ToString().Trim()); //是否在用
objvDGRegionFldsEN.UpdUser = objRow[convDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objvDGRegionFldsEN.UpdDate = objRow[convDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvDGRegionFldsEN.Memo = objRow[convDGRegionFlds.Memo] == DBNull.Value ? null : objRow[convDGRegionFlds.Memo].ToString().Trim(); //说明
objvDGRegionFldsEN.PrjId = objRow[convDGRegionFlds.PrjId] == DBNull.Value ? null : objRow[convDGRegionFlds.PrjId].ToString().Trim(); //工程Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDGRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objvDGRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDGRegionFldsEN;
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
objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDGRegionFldsEN._CurrTabName, convDGRegionFlds.mId, 8, "");
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
objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDGRegionFldsEN._CurrTabName, convDGRegionFlds.mId, 8, strPrefix);
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
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vDGRegionFlds where " + strCondition;
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
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vDGRegionFlds where " + strCondition;
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
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDGRegionFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDGRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDGRegionFlds", strCondition))
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
objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDGRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDGRegionFldsENS">源对象</param>
 /// <param name = "objvDGRegionFldsENT">目标对象</param>
public void CopyTo(clsvDGRegionFldsEN objvDGRegionFldsENS, clsvDGRegionFldsEN objvDGRegionFldsENT)
{
objvDGRegionFldsENT.mId = objvDGRegionFldsENS.mId; //mId
objvDGRegionFldsENT.RegionId = objvDGRegionFldsENS.RegionId; //区域Id
objvDGRegionFldsENT.RegionName = objvDGRegionFldsENS.RegionName; //区域名称
objvDGRegionFldsENT.TabId = objvDGRegionFldsENS.TabId; //表ID
objvDGRegionFldsENT.FldId = objvDGRegionFldsENS.FldId; //字段Id
objvDGRegionFldsENT.FldName = objvDGRegionFldsENS.FldName; //字段名
objvDGRegionFldsENT.SortExpression = objvDGRegionFldsENS.SortExpression; //排序表达式
objvDGRegionFldsENT.SeqNum = objvDGRegionFldsENS.SeqNum; //字段序号
objvDGRegionFldsENT.HeaderText = objvDGRegionFldsENS.HeaderText; //列头
objvDGRegionFldsENT.ToolTipText = objvDGRegionFldsENS.ToolTipText; //提示文字
objvDGRegionFldsENT.CtlTypeId = objvDGRegionFldsENS.CtlTypeId; //控件类型号
objvDGRegionFldsENT.CtlTypeName = objvDGRegionFldsENS.CtlTypeName; //控件类型名
objvDGRegionFldsENT.CtlCnName = objvDGRegionFldsENS.CtlCnName; //控件类型中文名
objvDGRegionFldsENT.DgFuncTypeId = objvDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objvDGRegionFldsENT.DgFuncTypeName = objvDGRegionFldsENS.DgFuncTypeName; //Dg功能类型名
objvDGRegionFldsENT.IsNeedSort = objvDGRegionFldsENS.IsNeedSort; //是否需要排序
objvDGRegionFldsENT.IsDefaultSort = objvDGRegionFldsENS.IsDefaultSort; //是否默认排序
objvDGRegionFldsENT.IsTransToChkBox = objvDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objvDGRegionFldsENT.IsVisible = objvDGRegionFldsENS.IsVisible; //是否显示
objvDGRegionFldsENT.IsFuncFld = objvDGRegionFldsENS.IsFuncFld; //是否功能字段
objvDGRegionFldsENT.InUse = objvDGRegionFldsENS.InUse; //是否在用
objvDGRegionFldsENT.UpdUser = objvDGRegionFldsENS.UpdUser; //修改者
objvDGRegionFldsENT.UpdDate = objvDGRegionFldsENS.UpdDate; //修改日期
objvDGRegionFldsENT.Memo = objvDGRegionFldsENS.Memo; //说明
objvDGRegionFldsENT.PrjId = objvDGRegionFldsENS.PrjId; //工程Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDGRegionFldsEN objvDGRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.RegionId, 10, convDGRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.RegionName, 50, convDGRegionFlds.RegionName);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.TabId, 8, convDGRegionFlds.TabId);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.FldId, 8, convDGRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.FldName, 50, convDGRegionFlds.FldName);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.SortExpression, 50, convDGRegionFlds.SortExpression);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.HeaderText, 100, convDGRegionFlds.HeaderText);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.ToolTipText, 150, convDGRegionFlds.ToolTipText);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.CtlTypeId, 2, convDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.CtlTypeName, 30, convDGRegionFlds.CtlTypeName);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.CtlCnName, 50, convDGRegionFlds.CtlCnName);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.DgFuncTypeId, 4, convDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.DgFuncTypeName, 30, convDGRegionFlds.DgFuncTypeName);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.UpdUser, 20, convDGRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.UpdDate, 20, convDGRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.Memo, 1000, convDGRegionFlds.Memo);
clsCheckSql.CheckFieldLen(objvDGRegionFldsEN.PrjId, 4, convDGRegionFlds.PrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.RegionId, convDGRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.RegionName, convDGRegionFlds.RegionName);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.TabId, convDGRegionFlds.TabId);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.FldId, convDGRegionFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.FldName, convDGRegionFlds.FldName);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.SortExpression, convDGRegionFlds.SortExpression);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.HeaderText, convDGRegionFlds.HeaderText);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.ToolTipText, convDGRegionFlds.ToolTipText);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.CtlTypeId, convDGRegionFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.CtlTypeName, convDGRegionFlds.CtlTypeName);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.CtlCnName, convDGRegionFlds.CtlCnName);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.DgFuncTypeId, convDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.DgFuncTypeName, convDGRegionFlds.DgFuncTypeName);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.UpdUser, convDGRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.UpdDate, convDGRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.Memo, convDGRegionFlds.Memo);
clsCheckSql.CheckSqlInjection4Field(objvDGRegionFldsEN.PrjId, convDGRegionFlds.PrjId);
//检查外键字段长度
 objvDGRegionFldsEN._IsCheckProperty = true;
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
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDGRegionFldsEN._CurrTabName);
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
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDGRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsvDGRegionFldsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}