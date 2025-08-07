
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDetailRegionFldsDA
 表名:DetailRegionFlds(00050544)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:05
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
 /// 详细区域字段(DetailRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDetailRegionFldsDA : clsCommBase4DA
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
 return clsDetailRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDetailRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDetailRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDetailRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDetailRegionFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DetailRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DetailRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA: GetDataTable_DetailRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DetailRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DetailRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DetailRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DetailRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DetailRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDetailRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DetailRegionFlds.* " + 
$"from DetailRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DetailRegionFlds.mId not in " + 
$"(Select top {intTop_In} DetailRegionFlds.mId from DetailRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DetailRegionFlds where {1} and mId not in (Select top {2} mId from DetailRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DetailRegionFlds where {1} and mId not in (Select top {3} mId from DetailRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDetailRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DetailRegionFlds.* " + 
$"from DetailRegionFlds " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DetailRegionFlds.mId not in " + 
$"(Select top {intTop_In} DetailRegionFlds.mId from DetailRegionFlds " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DetailRegionFlds where {1} and mId not in (Select top {2} mId from DetailRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DetailRegionFlds where {1} and mId not in (Select top {3} mId from DetailRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDetailRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DetailRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = TransNullToInt(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = TransNullToBool(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = TransNullToBool(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDetailRegionFldsDA: GetObjLst)", objException.Message));
}
objDetailRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDetailRegionFldsEN);
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
public List<clsDetailRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = TransNullToInt(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = TransNullToBool(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = TransNullToBool(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDetailRegionFldsDA: GetObjLst)", objException.Message));
}
objDetailRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDetailRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDetailRegionFlds(ref clsDetailRegionFldsEN objDetailRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DetailRegionFlds where mId = " + ""+ objDetailRegionFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDetailRegionFldsEN.mId = TransNullToInt(objDT.Rows[0][conDetailRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objDetailRegionFldsEN.RegionId = objDT.Rows[0][conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objDetailRegionFldsEN.FldId = objDT.Rows[0][conDetailRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objDetailRegionFldsEN.OutFldId = objDT.Rows[0][conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId(字段类型:char,字段长度:8,是否可空:True)
 objDetailRegionFldsEN.LabelCaption = objDT.Rows[0][conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objDetailRegionFldsEN.CtlTypeId = objDT.Rows[0][conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objDetailRegionFldsEN.ColSpan = TransNullToInt(objDT.Rows[0][conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objDetailRegionFldsEN.ColIndex = TransNullToInt(objDT.Rows[0][conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号(字段类型:int,字段长度:4,是否可空:False)
 objDetailRegionFldsEN.Width = TransNullToInt(objDT.Rows[0][conDetailRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objDetailRegionFldsEN.IsMultiRow = TransNullToBool(objDT.Rows[0][conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行(字段类型:bit,字段长度:1,是否可空:True)
 objDetailRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objDetailRegionFldsEN.InOutTypeId = objDT.Rows[0][conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objDetailRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][conDetailRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objDetailRegionFldsEN.ChangeEvent = objDT.Rows[0][conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objDetailRegionFldsEN.ClickEvent = objDT.Rows[0][conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objDetailRegionFldsEN.VarId = objDT.Rows[0][conDetailRegionFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objDetailRegionFldsEN.ErrMsg = objDT.Rows[0][conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objDetailRegionFldsEN.PrjId = objDT.Rows[0][conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDetailRegionFldsEN.UpdUser = objDT.Rows[0][conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDetailRegionFldsEN.UpdDate = objDT.Rows[0][conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDetailRegionFldsEN.Memo = objDT.Rows[0][conDetailRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDetailRegionFldsDA: GetDetailRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsDetailRegionFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DetailRegionFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
 objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId(字段类型:char,字段长度:8,是否可空:True)
 objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号(字段类型:int,字段长度:4,是否可空:False)
 objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行(字段类型:bit,字段长度:1,是否可空:True)
 objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDetailRegionFldsDA: GetObjBymId)", objException.Message));
}
return objDetailRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDetailRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DetailRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN()
{
mId = TransNullToInt(objRow[conDetailRegionFlds.mId].ToString().Trim()), //mId
RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(), //区域Id
FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(), //字段Id
OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(), //OutFldId
LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(), //标签标题
CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(), //控件类型号
ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()), //跨列数
ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()), //列序号
Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.Width].ToString().Trim()), //宽
IsMultiRow = TransNullToBool(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()), //是否多行
SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()), //字段序号
InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(), //INOUT类型ID
InUse = TransNullToBool(objRow[conDetailRegionFlds.InUse].ToString().Trim()), //是否在用
ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(), //Change事件
ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(), //Click事件
VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(), //变量Id
ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim() //说明
};
objDetailRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDetailRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDetailRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDetailRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = TransNullToInt(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = TransNullToBool(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = TransNullToBool(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDetailRegionFldsDA: GetObjByDataRowDetailRegionFlds)", objException.Message));
}
objDetailRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDetailRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDetailRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = TransNullToInt(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = TransNullToBool(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = TransNullToBool(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDetailRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objDetailRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDetailRegionFldsEN;
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
objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDetailRegionFldsEN._CurrTabName, conDetailRegionFlds.mId, 8, "");
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
objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDetailRegionFldsEN._CurrTabName, conDetailRegionFlds.mId, 8, strPrefix);
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from DetailRegionFlds where " + strCondition;
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from DetailRegionFlds where " + strCondition;
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DetailRegionFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DetailRegionFlds", strCondition))
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
objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DetailRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDetailRegionFldsEN objDetailRegionFldsEN)
 {
 objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDetailRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDetailRegionFldsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DetailRegionFlds where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DetailRegionFlds");
objRow = objDS.Tables["DetailRegionFlds"].NewRow();
objRow[conDetailRegionFlds.RegionId] = objDetailRegionFldsEN.RegionId; //区域Id
 if (objDetailRegionFldsEN.FldId !=  "")
 {
objRow[conDetailRegionFlds.FldId] = objDetailRegionFldsEN.FldId; //字段Id
 }
 if (objDetailRegionFldsEN.OutFldId !=  "")
 {
objRow[conDetailRegionFlds.OutFldId] = objDetailRegionFldsEN.OutFldId; //OutFldId
 }
 if (objDetailRegionFldsEN.LabelCaption !=  "")
 {
objRow[conDetailRegionFlds.LabelCaption] = objDetailRegionFldsEN.LabelCaption; //标签标题
 }
objRow[conDetailRegionFlds.CtlTypeId] = objDetailRegionFldsEN.CtlTypeId; //控件类型号
objRow[conDetailRegionFlds.ColSpan] = objDetailRegionFldsEN.ColSpan; //跨列数
objRow[conDetailRegionFlds.ColIndex] = objDetailRegionFldsEN.ColIndex; //列序号
objRow[conDetailRegionFlds.Width] = objDetailRegionFldsEN.Width; //宽
objRow[conDetailRegionFlds.IsMultiRow] = objDetailRegionFldsEN.IsMultiRow; //是否多行
objRow[conDetailRegionFlds.SeqNum] = objDetailRegionFldsEN.SeqNum; //字段序号
 if (objDetailRegionFldsEN.InOutTypeId !=  "")
 {
objRow[conDetailRegionFlds.InOutTypeId] = objDetailRegionFldsEN.InOutTypeId; //INOUT类型ID
 }
objRow[conDetailRegionFlds.InUse] = objDetailRegionFldsEN.InUse; //是否在用
 if (objDetailRegionFldsEN.ChangeEvent !=  "")
 {
objRow[conDetailRegionFlds.ChangeEvent] = objDetailRegionFldsEN.ChangeEvent; //Change事件
 }
 if (objDetailRegionFldsEN.ClickEvent !=  "")
 {
objRow[conDetailRegionFlds.ClickEvent] = objDetailRegionFldsEN.ClickEvent; //Click事件
 }
 if (objDetailRegionFldsEN.VarId !=  "")
 {
objRow[conDetailRegionFlds.VarId] = objDetailRegionFldsEN.VarId; //变量Id
 }
 if (objDetailRegionFldsEN.ErrMsg !=  "")
 {
objRow[conDetailRegionFlds.ErrMsg] = objDetailRegionFldsEN.ErrMsg; //错误信息
 }
objRow[conDetailRegionFlds.PrjId] = objDetailRegionFldsEN.PrjId; //工程Id
objRow[conDetailRegionFlds.UpdUser] = objDetailRegionFldsEN.UpdUser; //修改者
 if (objDetailRegionFldsEN.UpdDate !=  "")
 {
objRow[conDetailRegionFlds.UpdDate] = objDetailRegionFldsEN.UpdDate; //修改日期
 }
 if (objDetailRegionFldsEN.Memo !=  "")
 {
objRow[conDetailRegionFlds.Memo] = objDetailRegionFldsEN.Memo; //说明
 }
objDS.Tables[clsDetailRegionFldsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDetailRegionFldsEN._CurrTabName);
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
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDetailRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDetailRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDetailRegionFldsEN.RegionId  ==  "")
 {
 objDetailRegionFldsEN.RegionId = null;
 }
 if (objDetailRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.RegionId);
 var strRegionId = objDetailRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objDetailRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.FldId);
 var strFldId = objDetailRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDetailRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.OutFldId);
 var strOutFldId = objDetailRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objDetailRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.LabelCaption);
 var strLabelCaption = objDetailRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objDetailRegionFldsEN.CtlTypeId  ==  "")
 {
 objDetailRegionFldsEN.CtlTypeId = null;
 }
 if (objDetailRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.CtlTypeId);
 var strCtlTypeId = objDetailRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objDetailRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ColSpan);
 arrValueListForInsert.Add(objDetailRegionFldsEN.ColSpan.ToString());
 }
 
 if (objDetailRegionFldsEN.ColIndex !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ColIndex);
 arrValueListForInsert.Add(objDetailRegionFldsEN.ColIndex.ToString());
 }
 
 if (objDetailRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.Width);
 arrValueListForInsert.Add(objDetailRegionFldsEN.Width.ToString());
 }
 
 arrFieldListForInsert.Add(conDetailRegionFlds.IsMultiRow);
 arrValueListForInsert.Add("'" + (objDetailRegionFldsEN.IsMultiRow  ==  false ? "0" : "1") + "'");
 
 if (objDetailRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.SeqNum);
 arrValueListForInsert.Add(objDetailRegionFldsEN.SeqNum.ToString());
 }
 
 if (objDetailRegionFldsEN.InOutTypeId  ==  "")
 {
 objDetailRegionFldsEN.InOutTypeId = null;
 }
 if (objDetailRegionFldsEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.InOutTypeId);
 var strInOutTypeId = objDetailRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conDetailRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objDetailRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objDetailRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ChangeEvent);
 var strChangeEvent = objDetailRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 if (objDetailRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ClickEvent);
 var strClickEvent = objDetailRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 if (objDetailRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.VarId);
 var strVarId = objDetailRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objDetailRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ErrMsg);
 var strErrMsg = objDetailRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDetailRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.PrjId);
 var strPrjId = objDetailRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDetailRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.UpdUser);
 var strUpdUser = objDetailRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDetailRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.UpdDate);
 var strUpdDate = objDetailRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDetailRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.Memo);
 var strMemo = objDetailRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DetailRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDetailRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDetailRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDetailRegionFldsEN.RegionId  ==  "")
 {
 objDetailRegionFldsEN.RegionId = null;
 }
 if (objDetailRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.RegionId);
 var strRegionId = objDetailRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objDetailRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.FldId);
 var strFldId = objDetailRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDetailRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.OutFldId);
 var strOutFldId = objDetailRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objDetailRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.LabelCaption);
 var strLabelCaption = objDetailRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objDetailRegionFldsEN.CtlTypeId  ==  "")
 {
 objDetailRegionFldsEN.CtlTypeId = null;
 }
 if (objDetailRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.CtlTypeId);
 var strCtlTypeId = objDetailRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objDetailRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ColSpan);
 arrValueListForInsert.Add(objDetailRegionFldsEN.ColSpan.ToString());
 }
 
 if (objDetailRegionFldsEN.ColIndex !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ColIndex);
 arrValueListForInsert.Add(objDetailRegionFldsEN.ColIndex.ToString());
 }
 
 if (objDetailRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.Width);
 arrValueListForInsert.Add(objDetailRegionFldsEN.Width.ToString());
 }
 
 arrFieldListForInsert.Add(conDetailRegionFlds.IsMultiRow);
 arrValueListForInsert.Add("'" + (objDetailRegionFldsEN.IsMultiRow  ==  false ? "0" : "1") + "'");
 
 if (objDetailRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.SeqNum);
 arrValueListForInsert.Add(objDetailRegionFldsEN.SeqNum.ToString());
 }
 
 if (objDetailRegionFldsEN.InOutTypeId  ==  "")
 {
 objDetailRegionFldsEN.InOutTypeId = null;
 }
 if (objDetailRegionFldsEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.InOutTypeId);
 var strInOutTypeId = objDetailRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conDetailRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objDetailRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objDetailRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ChangeEvent);
 var strChangeEvent = objDetailRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 if (objDetailRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ClickEvent);
 var strClickEvent = objDetailRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 if (objDetailRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.VarId);
 var strVarId = objDetailRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objDetailRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ErrMsg);
 var strErrMsg = objDetailRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDetailRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.PrjId);
 var strPrjId = objDetailRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDetailRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.UpdUser);
 var strUpdUser = objDetailRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDetailRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.UpdDate);
 var strUpdDate = objDetailRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDetailRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.Memo);
 var strMemo = objDetailRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DetailRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDetailRegionFldsEN objDetailRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDetailRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDetailRegionFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDetailRegionFldsEN.RegionId  ==  "")
 {
 objDetailRegionFldsEN.RegionId = null;
 }
 if (objDetailRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.RegionId);
 var strRegionId = objDetailRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objDetailRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.FldId);
 var strFldId = objDetailRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDetailRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.OutFldId);
 var strOutFldId = objDetailRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objDetailRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.LabelCaption);
 var strLabelCaption = objDetailRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objDetailRegionFldsEN.CtlTypeId  ==  "")
 {
 objDetailRegionFldsEN.CtlTypeId = null;
 }
 if (objDetailRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.CtlTypeId);
 var strCtlTypeId = objDetailRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objDetailRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ColSpan);
 arrValueListForInsert.Add(objDetailRegionFldsEN.ColSpan.ToString());
 }
 
 if (objDetailRegionFldsEN.ColIndex !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ColIndex);
 arrValueListForInsert.Add(objDetailRegionFldsEN.ColIndex.ToString());
 }
 
 if (objDetailRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.Width);
 arrValueListForInsert.Add(objDetailRegionFldsEN.Width.ToString());
 }
 
 arrFieldListForInsert.Add(conDetailRegionFlds.IsMultiRow);
 arrValueListForInsert.Add("'" + (objDetailRegionFldsEN.IsMultiRow  ==  false ? "0" : "1") + "'");
 
 if (objDetailRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.SeqNum);
 arrValueListForInsert.Add(objDetailRegionFldsEN.SeqNum.ToString());
 }
 
 if (objDetailRegionFldsEN.InOutTypeId  ==  "")
 {
 objDetailRegionFldsEN.InOutTypeId = null;
 }
 if (objDetailRegionFldsEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.InOutTypeId);
 var strInOutTypeId = objDetailRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conDetailRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objDetailRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objDetailRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ChangeEvent);
 var strChangeEvent = objDetailRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 if (objDetailRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ClickEvent);
 var strClickEvent = objDetailRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 if (objDetailRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.VarId);
 var strVarId = objDetailRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objDetailRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ErrMsg);
 var strErrMsg = objDetailRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDetailRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.PrjId);
 var strPrjId = objDetailRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDetailRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.UpdUser);
 var strUpdUser = objDetailRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDetailRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.UpdDate);
 var strUpdDate = objDetailRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDetailRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.Memo);
 var strMemo = objDetailRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DetailRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDetailRegionFldsEN objDetailRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDetailRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDetailRegionFldsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDetailRegionFldsEN.RegionId  ==  "")
 {
 objDetailRegionFldsEN.RegionId = null;
 }
 if (objDetailRegionFldsEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.RegionId);
 var strRegionId = objDetailRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objDetailRegionFldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.FldId);
 var strFldId = objDetailRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDetailRegionFldsEN.OutFldId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.OutFldId);
 var strOutFldId = objDetailRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldId + "'");
 }
 
 if (objDetailRegionFldsEN.LabelCaption !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.LabelCaption);
 var strLabelCaption = objDetailRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLabelCaption + "'");
 }
 
 if (objDetailRegionFldsEN.CtlTypeId  ==  "")
 {
 objDetailRegionFldsEN.CtlTypeId = null;
 }
 if (objDetailRegionFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.CtlTypeId);
 var strCtlTypeId = objDetailRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeId + "'");
 }
 
 if (objDetailRegionFldsEN.ColSpan !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ColSpan);
 arrValueListForInsert.Add(objDetailRegionFldsEN.ColSpan.ToString());
 }
 
 if (objDetailRegionFldsEN.ColIndex !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ColIndex);
 arrValueListForInsert.Add(objDetailRegionFldsEN.ColIndex.ToString());
 }
 
 if (objDetailRegionFldsEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.Width);
 arrValueListForInsert.Add(objDetailRegionFldsEN.Width.ToString());
 }
 
 arrFieldListForInsert.Add(conDetailRegionFlds.IsMultiRow);
 arrValueListForInsert.Add("'" + (objDetailRegionFldsEN.IsMultiRow  ==  false ? "0" : "1") + "'");
 
 if (objDetailRegionFldsEN.SeqNum !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.SeqNum);
 arrValueListForInsert.Add(objDetailRegionFldsEN.SeqNum.ToString());
 }
 
 if (objDetailRegionFldsEN.InOutTypeId  ==  "")
 {
 objDetailRegionFldsEN.InOutTypeId = null;
 }
 if (objDetailRegionFldsEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.InOutTypeId);
 var strInOutTypeId = objDetailRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conDetailRegionFlds.InUse);
 arrValueListForInsert.Add("'" + (objDetailRegionFldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objDetailRegionFldsEN.ChangeEvent !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ChangeEvent);
 var strChangeEvent = objDetailRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strChangeEvent + "'");
 }
 
 if (objDetailRegionFldsEN.ClickEvent !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ClickEvent);
 var strClickEvent = objDetailRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClickEvent + "'");
 }
 
 if (objDetailRegionFldsEN.VarId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.VarId);
 var strVarId = objDetailRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVarId + "'");
 }
 
 if (objDetailRegionFldsEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.ErrMsg);
 var strErrMsg = objDetailRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDetailRegionFldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.PrjId);
 var strPrjId = objDetailRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDetailRegionFldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.UpdUser);
 var strUpdUser = objDetailRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDetailRegionFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.UpdDate);
 var strUpdDate = objDetailRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDetailRegionFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDetailRegionFlds.Memo);
 var strMemo = objDetailRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DetailRegionFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDetailRegionFldss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DetailRegionFlds where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DetailRegionFlds");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conDetailRegionFlds.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDetailRegionFldsEN._CurrTabName ].NewRow();
objRow[conDetailRegionFlds.RegionId] = oRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objRow[conDetailRegionFlds.FldId] = oRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objRow[conDetailRegionFlds.OutFldId] = oRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objRow[conDetailRegionFlds.LabelCaption] = oRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objRow[conDetailRegionFlds.CtlTypeId] = oRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objRow[conDetailRegionFlds.ColSpan] = oRow[conDetailRegionFlds.ColSpan].ToString().Trim(); //跨列数
objRow[conDetailRegionFlds.ColIndex] = oRow[conDetailRegionFlds.ColIndex].ToString().Trim(); //列序号
objRow[conDetailRegionFlds.Width] = oRow[conDetailRegionFlds.Width].ToString().Trim(); //宽
objRow[conDetailRegionFlds.IsMultiRow] = oRow[conDetailRegionFlds.IsMultiRow].ToString().Trim(); //是否多行
objRow[conDetailRegionFlds.SeqNum] = oRow[conDetailRegionFlds.SeqNum].ToString().Trim(); //字段序号
objRow[conDetailRegionFlds.InOutTypeId] = oRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objRow[conDetailRegionFlds.InUse] = oRow[conDetailRegionFlds.InUse].ToString().Trim(); //是否在用
objRow[conDetailRegionFlds.ChangeEvent] = oRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objRow[conDetailRegionFlds.ClickEvent] = oRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objRow[conDetailRegionFlds.VarId] = oRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objRow[conDetailRegionFlds.ErrMsg] = oRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objRow[conDetailRegionFlds.PrjId] = oRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objRow[conDetailRegionFlds.UpdUser] = oRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objRow[conDetailRegionFlds.UpdDate] = oRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objRow[conDetailRegionFlds.Memo] = oRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDetailRegionFldsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDetailRegionFldsEN._CurrTabName);
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
 /// <param name = "objDetailRegionFldsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDetailRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDetailRegionFldsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from DetailRegionFlds where mId = " + ""+ objDetailRegionFldsEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDetailRegionFldsEN._CurrTabName);
if (objDS.Tables[clsDetailRegionFldsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objDetailRegionFldsEN.mId+"");
return false;
}
objRow = objDS.Tables[clsDetailRegionFldsEN._CurrTabName].Rows[0];
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.RegionId))
 {
objRow[conDetailRegionFlds.RegionId] = objDetailRegionFldsEN.RegionId; //区域Id
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.FldId))
 {
objRow[conDetailRegionFlds.FldId] = objDetailRegionFldsEN.FldId; //字段Id
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.OutFldId))
 {
objRow[conDetailRegionFlds.OutFldId] = objDetailRegionFldsEN.OutFldId; //OutFldId
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.LabelCaption))
 {
objRow[conDetailRegionFlds.LabelCaption] = objDetailRegionFldsEN.LabelCaption; //标签标题
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.CtlTypeId))
 {
objRow[conDetailRegionFlds.CtlTypeId] = objDetailRegionFldsEN.CtlTypeId; //控件类型号
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ColSpan))
 {
objRow[conDetailRegionFlds.ColSpan] = objDetailRegionFldsEN.ColSpan; //跨列数
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ColIndex))
 {
objRow[conDetailRegionFlds.ColIndex] = objDetailRegionFldsEN.ColIndex; //列序号
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.Width))
 {
objRow[conDetailRegionFlds.Width] = objDetailRegionFldsEN.Width; //宽
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.IsMultiRow))
 {
objRow[conDetailRegionFlds.IsMultiRow] = objDetailRegionFldsEN.IsMultiRow; //是否多行
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.SeqNum))
 {
objRow[conDetailRegionFlds.SeqNum] = objDetailRegionFldsEN.SeqNum; //字段序号
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.InOutTypeId))
 {
objRow[conDetailRegionFlds.InOutTypeId] = objDetailRegionFldsEN.InOutTypeId; //INOUT类型ID
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.InUse))
 {
objRow[conDetailRegionFlds.InUse] = objDetailRegionFldsEN.InUse; //是否在用
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ChangeEvent))
 {
objRow[conDetailRegionFlds.ChangeEvent] = objDetailRegionFldsEN.ChangeEvent; //Change事件
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ClickEvent))
 {
objRow[conDetailRegionFlds.ClickEvent] = objDetailRegionFldsEN.ClickEvent; //Click事件
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.VarId))
 {
objRow[conDetailRegionFlds.VarId] = objDetailRegionFldsEN.VarId; //变量Id
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ErrMsg))
 {
objRow[conDetailRegionFlds.ErrMsg] = objDetailRegionFldsEN.ErrMsg; //错误信息
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.PrjId))
 {
objRow[conDetailRegionFlds.PrjId] = objDetailRegionFldsEN.PrjId; //工程Id
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.UpdUser))
 {
objRow[conDetailRegionFlds.UpdUser] = objDetailRegionFldsEN.UpdUser; //修改者
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.UpdDate))
 {
objRow[conDetailRegionFlds.UpdDate] = objDetailRegionFldsEN.UpdDate; //修改日期
 }
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.Memo))
 {
objRow[conDetailRegionFlds.Memo] = objDetailRegionFldsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDetailRegionFldsEN._CurrTabName);
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
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDetailRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDetailRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DetailRegionFlds Set ");
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.RegionId))
 {
 if (objDetailRegionFldsEN.RegionId  ==  "")
 {
 objDetailRegionFldsEN.RegionId = null;
 }
 if (objDetailRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objDetailRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conDetailRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.FldId))
 {
 if (objDetailRegionFldsEN.FldId !=  null)
 {
 var strFldId = objDetailRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conDetailRegionFlds.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.FldId); //字段Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.OutFldId))
 {
 if (objDetailRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objDetailRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldId, conDetailRegionFlds.OutFldId); //OutFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.OutFldId); //OutFldId
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.LabelCaption))
 {
 if (objDetailRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objDetailRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLabelCaption, conDetailRegionFlds.LabelCaption); //标签标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.LabelCaption); //标签标题
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.CtlTypeId))
 {
 if (objDetailRegionFldsEN.CtlTypeId  ==  "")
 {
 objDetailRegionFldsEN.CtlTypeId = null;
 }
 if (objDetailRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objDetailRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conDetailRegionFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ColSpan))
 {
 if (objDetailRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.ColSpan, conDetailRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ColIndex))
 {
 if (objDetailRegionFldsEN.ColIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.ColIndex, conDetailRegionFlds.ColIndex); //列序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ColIndex); //列序号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.Width))
 {
 if (objDetailRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.Width, conDetailRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.Width); //宽
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.IsMultiRow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDetailRegionFldsEN.IsMultiRow == true?"1":"0", conDetailRegionFlds.IsMultiRow); //是否多行
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.SeqNum))
 {
 if (objDetailRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.SeqNum, conDetailRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.InOutTypeId))
 {
 if (objDetailRegionFldsEN.InOutTypeId  ==  "")
 {
 objDetailRegionFldsEN.InOutTypeId = null;
 }
 if (objDetailRegionFldsEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objDetailRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, conDetailRegionFlds.InOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.InOutTypeId); //INOUT类型ID
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDetailRegionFldsEN.InUse == true?"1":"0", conDetailRegionFlds.InUse); //是否在用
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ChangeEvent))
 {
 if (objDetailRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objDetailRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChangeEvent, conDetailRegionFlds.ChangeEvent); //Change事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ChangeEvent); //Change事件
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ClickEvent))
 {
 if (objDetailRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objDetailRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClickEvent, conDetailRegionFlds.ClickEvent); //Click事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ClickEvent); //Click事件
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.VarId))
 {
 if (objDetailRegionFldsEN.VarId !=  null)
 {
 var strVarId = objDetailRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarId, conDetailRegionFlds.VarId); //变量Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.VarId); //变量Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ErrMsg))
 {
 if (objDetailRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objDetailRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conDetailRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.PrjId))
 {
 if (objDetailRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objDetailRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDetailRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.UpdUser))
 {
 if (objDetailRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objDetailRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDetailRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.UpdDate))
 {
 if (objDetailRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objDetailRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDetailRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.Memo))
 {
 if (objDetailRegionFldsEN.Memo !=  null)
 {
 var strMemo = objDetailRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDetailRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objDetailRegionFldsEN.mId); 
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
 /// <param name = "objDetailRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDetailRegionFldsEN objDetailRegionFldsEN, string strCondition)
{
 objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDetailRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDetailRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DetailRegionFlds Set ");
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.RegionId))
 {
 if (objDetailRegionFldsEN.RegionId  ==  "")
 {
 objDetailRegionFldsEN.RegionId = null;
 }
 if (objDetailRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objDetailRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.FldId))
 {
 if (objDetailRegionFldsEN.FldId !=  null)
 {
 var strFldId = objDetailRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.OutFldId))
 {
 if (objDetailRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objDetailRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldId = '{0}',", strOutFldId); //OutFldId
 }
 else
 {
 sbSQL.Append(" OutFldId = null,"); //OutFldId
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.LabelCaption))
 {
 if (objDetailRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objDetailRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LabelCaption = '{0}',", strLabelCaption); //标签标题
 }
 else
 {
 sbSQL.Append(" LabelCaption = null,"); //标签标题
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.CtlTypeId))
 {
 if (objDetailRegionFldsEN.CtlTypeId  ==  "")
 {
 objDetailRegionFldsEN.CtlTypeId = null;
 }
 if (objDetailRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objDetailRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ColSpan))
 {
 if (objDetailRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.ColSpan, conDetailRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ColIndex))
 {
 if (objDetailRegionFldsEN.ColIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.ColIndex, conDetailRegionFlds.ColIndex); //列序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ColIndex); //列序号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.Width))
 {
 if (objDetailRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.Width, conDetailRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.Width); //宽
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.IsMultiRow))
 {
 sbSQL.AppendFormat(" IsMultiRow = '{0}',", objDetailRegionFldsEN.IsMultiRow == true?"1":"0"); //是否多行
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.SeqNum))
 {
 if (objDetailRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.SeqNum, conDetailRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.InOutTypeId))
 {
 if (objDetailRegionFldsEN.InOutTypeId  ==  "")
 {
 objDetailRegionFldsEN.InOutTypeId = null;
 }
 if (objDetailRegionFldsEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objDetailRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //INOUT类型ID
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objDetailRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ChangeEvent))
 {
 if (objDetailRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objDetailRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChangeEvent = '{0}',", strChangeEvent); //Change事件
 }
 else
 {
 sbSQL.Append(" ChangeEvent = null,"); //Change事件
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ClickEvent))
 {
 if (objDetailRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objDetailRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClickEvent = '{0}',", strClickEvent); //Click事件
 }
 else
 {
 sbSQL.Append(" ClickEvent = null,"); //Click事件
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.VarId))
 {
 if (objDetailRegionFldsEN.VarId !=  null)
 {
 var strVarId = objDetailRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarId = '{0}',", strVarId); //变量Id
 }
 else
 {
 sbSQL.Append(" VarId = null,"); //变量Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ErrMsg))
 {
 if (objDetailRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objDetailRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.PrjId))
 {
 if (objDetailRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objDetailRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.UpdUser))
 {
 if (objDetailRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objDetailRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.UpdDate))
 {
 if (objDetailRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objDetailRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.Memo))
 {
 if (objDetailRegionFldsEN.Memo !=  null)
 {
 var strMemo = objDetailRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDetailRegionFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDetailRegionFldsEN objDetailRegionFldsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDetailRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDetailRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DetailRegionFlds Set ");
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.RegionId))
 {
 if (objDetailRegionFldsEN.RegionId  ==  "")
 {
 objDetailRegionFldsEN.RegionId = null;
 }
 if (objDetailRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objDetailRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionId = '{0}',", strRegionId); //区域Id
 }
 else
 {
 sbSQL.Append(" RegionId = null,"); //区域Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.FldId))
 {
 if (objDetailRegionFldsEN.FldId !=  null)
 {
 var strFldId = objDetailRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.OutFldId))
 {
 if (objDetailRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objDetailRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldId = '{0}',", strOutFldId); //OutFldId
 }
 else
 {
 sbSQL.Append(" OutFldId = null,"); //OutFldId
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.LabelCaption))
 {
 if (objDetailRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objDetailRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LabelCaption = '{0}',", strLabelCaption); //标签标题
 }
 else
 {
 sbSQL.Append(" LabelCaption = null,"); //标签标题
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.CtlTypeId))
 {
 if (objDetailRegionFldsEN.CtlTypeId  ==  "")
 {
 objDetailRegionFldsEN.CtlTypeId = null;
 }
 if (objDetailRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objDetailRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", strCtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ColSpan))
 {
 if (objDetailRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.ColSpan, conDetailRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ColIndex))
 {
 if (objDetailRegionFldsEN.ColIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.ColIndex, conDetailRegionFlds.ColIndex); //列序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ColIndex); //列序号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.Width))
 {
 if (objDetailRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.Width, conDetailRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.Width); //宽
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.IsMultiRow))
 {
 sbSQL.AppendFormat(" IsMultiRow = '{0}',", objDetailRegionFldsEN.IsMultiRow == true?"1":"0"); //是否多行
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.SeqNum))
 {
 if (objDetailRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.SeqNum, conDetailRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.InOutTypeId))
 {
 if (objDetailRegionFldsEN.InOutTypeId  ==  "")
 {
 objDetailRegionFldsEN.InOutTypeId = null;
 }
 if (objDetailRegionFldsEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objDetailRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //INOUT类型ID
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objDetailRegionFldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ChangeEvent))
 {
 if (objDetailRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objDetailRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ChangeEvent = '{0}',", strChangeEvent); //Change事件
 }
 else
 {
 sbSQL.Append(" ChangeEvent = null,"); //Change事件
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ClickEvent))
 {
 if (objDetailRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objDetailRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClickEvent = '{0}',", strClickEvent); //Click事件
 }
 else
 {
 sbSQL.Append(" ClickEvent = null,"); //Click事件
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.VarId))
 {
 if (objDetailRegionFldsEN.VarId !=  null)
 {
 var strVarId = objDetailRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VarId = '{0}',", strVarId); //变量Id
 }
 else
 {
 sbSQL.Append(" VarId = null,"); //变量Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ErrMsg))
 {
 if (objDetailRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objDetailRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.PrjId))
 {
 if (objDetailRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objDetailRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.UpdUser))
 {
 if (objDetailRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objDetailRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.UpdDate))
 {
 if (objDetailRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objDetailRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.Memo))
 {
 if (objDetailRegionFldsEN.Memo !=  null)
 {
 var strMemo = objDetailRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDetailRegionFldsEN objDetailRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDetailRegionFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDetailRegionFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DetailRegionFlds Set ");
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.RegionId))
 {
 if (objDetailRegionFldsEN.RegionId  ==  "")
 {
 objDetailRegionFldsEN.RegionId = null;
 }
 if (objDetailRegionFldsEN.RegionId !=  null)
 {
 var strRegionId = objDetailRegionFldsEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionId, conDetailRegionFlds.RegionId); //区域Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.RegionId); //区域Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.FldId))
 {
 if (objDetailRegionFldsEN.FldId !=  null)
 {
 var strFldId = objDetailRegionFldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conDetailRegionFlds.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.FldId); //字段Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.OutFldId))
 {
 if (objDetailRegionFldsEN.OutFldId !=  null)
 {
 var strOutFldId = objDetailRegionFldsEN.OutFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldId, conDetailRegionFlds.OutFldId); //OutFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.OutFldId); //OutFldId
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.LabelCaption))
 {
 if (objDetailRegionFldsEN.LabelCaption !=  null)
 {
 var strLabelCaption = objDetailRegionFldsEN.LabelCaption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLabelCaption, conDetailRegionFlds.LabelCaption); //标签标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.LabelCaption); //标签标题
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.CtlTypeId))
 {
 if (objDetailRegionFldsEN.CtlTypeId  ==  "")
 {
 objDetailRegionFldsEN.CtlTypeId = null;
 }
 if (objDetailRegionFldsEN.CtlTypeId !=  null)
 {
 var strCtlTypeId = objDetailRegionFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeId, conDetailRegionFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ColSpan))
 {
 if (objDetailRegionFldsEN.ColSpan !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.ColSpan, conDetailRegionFlds.ColSpan); //跨列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ColSpan); //跨列数
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ColIndex))
 {
 if (objDetailRegionFldsEN.ColIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.ColIndex, conDetailRegionFlds.ColIndex); //列序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ColIndex); //列序号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.Width))
 {
 if (objDetailRegionFldsEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.Width, conDetailRegionFlds.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.Width); //宽
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.IsMultiRow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDetailRegionFldsEN.IsMultiRow == true?"1":"0", conDetailRegionFlds.IsMultiRow); //是否多行
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.SeqNum))
 {
 if (objDetailRegionFldsEN.SeqNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDetailRegionFldsEN.SeqNum, conDetailRegionFlds.SeqNum); //字段序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.SeqNum); //字段序号
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.InOutTypeId))
 {
 if (objDetailRegionFldsEN.InOutTypeId  ==  "")
 {
 objDetailRegionFldsEN.InOutTypeId = null;
 }
 if (objDetailRegionFldsEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objDetailRegionFldsEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, conDetailRegionFlds.InOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.InOutTypeId); //INOUT类型ID
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDetailRegionFldsEN.InUse == true?"1":"0", conDetailRegionFlds.InUse); //是否在用
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ChangeEvent))
 {
 if (objDetailRegionFldsEN.ChangeEvent !=  null)
 {
 var strChangeEvent = objDetailRegionFldsEN.ChangeEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strChangeEvent, conDetailRegionFlds.ChangeEvent); //Change事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ChangeEvent); //Change事件
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ClickEvent))
 {
 if (objDetailRegionFldsEN.ClickEvent !=  null)
 {
 var strClickEvent = objDetailRegionFldsEN.ClickEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClickEvent, conDetailRegionFlds.ClickEvent); //Click事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ClickEvent); //Click事件
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.VarId))
 {
 if (objDetailRegionFldsEN.VarId !=  null)
 {
 var strVarId = objDetailRegionFldsEN.VarId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVarId, conDetailRegionFlds.VarId); //变量Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.VarId); //变量Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.ErrMsg))
 {
 if (objDetailRegionFldsEN.ErrMsg !=  null)
 {
 var strErrMsg = objDetailRegionFldsEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conDetailRegionFlds.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.ErrMsg); //错误信息
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.PrjId))
 {
 if (objDetailRegionFldsEN.PrjId !=  null)
 {
 var strPrjId = objDetailRegionFldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDetailRegionFlds.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.PrjId); //工程Id
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.UpdUser))
 {
 if (objDetailRegionFldsEN.UpdUser !=  null)
 {
 var strUpdUser = objDetailRegionFldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDetailRegionFlds.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.UpdUser); //修改者
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.UpdDate))
 {
 if (objDetailRegionFldsEN.UpdDate !=  null)
 {
 var strUpdDate = objDetailRegionFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDetailRegionFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.UpdDate); //修改日期
 }
 }
 
 if (objDetailRegionFldsEN.IsUpdated(conDetailRegionFlds.Memo))
 {
 if (objDetailRegionFldsEN.Memo !=  null)
 {
 var strMemo = objDetailRegionFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDetailRegionFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDetailRegionFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objDetailRegionFldsEN.mId); 
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("DetailRegionFlds_Delete", values);
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
//删除DetailRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DetailRegionFlds where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDetailRegionFlds(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
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
//删除DetailRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DetailRegionFlds where mId in (" + strKeyList + ")";
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
//删除DetailRegionFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DetailRegionFlds where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDetailRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA: DelDetailRegionFlds)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DetailRegionFlds where " + strCondition ;
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
public bool DelDetailRegionFldsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDetailRegionFldsDA: DelDetailRegionFldsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DetailRegionFlds where " + strCondition ;
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
 /// <param name = "objDetailRegionFldsENS">源对象</param>
 /// <param name = "objDetailRegionFldsENT">目标对象</param>
public void CopyTo(clsDetailRegionFldsEN objDetailRegionFldsENS, clsDetailRegionFldsEN objDetailRegionFldsENT)
{
objDetailRegionFldsENT.mId = objDetailRegionFldsENS.mId; //mId
objDetailRegionFldsENT.RegionId = objDetailRegionFldsENS.RegionId; //区域Id
objDetailRegionFldsENT.FldId = objDetailRegionFldsENS.FldId; //字段Id
objDetailRegionFldsENT.OutFldId = objDetailRegionFldsENS.OutFldId; //OutFldId
objDetailRegionFldsENT.LabelCaption = objDetailRegionFldsENS.LabelCaption; //标签标题
objDetailRegionFldsENT.CtlTypeId = objDetailRegionFldsENS.CtlTypeId; //控件类型号
objDetailRegionFldsENT.ColSpan = objDetailRegionFldsENS.ColSpan; //跨列数
objDetailRegionFldsENT.ColIndex = objDetailRegionFldsENS.ColIndex; //列序号
objDetailRegionFldsENT.Width = objDetailRegionFldsENS.Width; //宽
objDetailRegionFldsENT.IsMultiRow = objDetailRegionFldsENS.IsMultiRow; //是否多行
objDetailRegionFldsENT.SeqNum = objDetailRegionFldsENS.SeqNum; //字段序号
objDetailRegionFldsENT.InOutTypeId = objDetailRegionFldsENS.InOutTypeId; //INOUT类型ID
objDetailRegionFldsENT.InUse = objDetailRegionFldsENS.InUse; //是否在用
objDetailRegionFldsENT.ChangeEvent = objDetailRegionFldsENS.ChangeEvent; //Change事件
objDetailRegionFldsENT.ClickEvent = objDetailRegionFldsENS.ClickEvent; //Click事件
objDetailRegionFldsENT.VarId = objDetailRegionFldsENS.VarId; //变量Id
objDetailRegionFldsENT.ErrMsg = objDetailRegionFldsENS.ErrMsg; //错误信息
objDetailRegionFldsENT.PrjId = objDetailRegionFldsENS.PrjId; //工程Id
objDetailRegionFldsENT.UpdUser = objDetailRegionFldsENS.UpdUser; //修改者
objDetailRegionFldsENT.UpdDate = objDetailRegionFldsENS.UpdDate; //修改日期
objDetailRegionFldsENT.Memo = objDetailRegionFldsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDetailRegionFldsEN.RegionId, conDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldNotNull(objDetailRegionFldsEN.CtlTypeId, conDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldNotNull(objDetailRegionFldsEN.PrjId, conDetailRegionFlds.PrjId);
clsCheckSql.CheckFieldNotNull(objDetailRegionFldsEN.UpdUser, conDetailRegionFlds.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.RegionId, 10, conDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.FldId, 8, conDetailRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.OutFldId, 8, conDetailRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.LabelCaption, 150, conDetailRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.CtlTypeId, 2, conDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.InOutTypeId, 2, conDetailRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.ChangeEvent, 50, conDetailRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.ClickEvent, 50, conDetailRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.VarId, 8, conDetailRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.ErrMsg, 2000, conDetailRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.PrjId, 4, conDetailRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.UpdUser, 20, conDetailRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.UpdDate, 20, conDetailRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.Memo, 1000, conDetailRegionFlds.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objDetailRegionFldsEN.RegionId, 10, conDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objDetailRegionFldsEN.CtlTypeId, 2, conDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objDetailRegionFldsEN.InOutTypeId, 2, conDetailRegionFlds.InOutTypeId);
 objDetailRegionFldsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.RegionId, 10, conDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.FldId, 8, conDetailRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.OutFldId, 8, conDetailRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.LabelCaption, 150, conDetailRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.CtlTypeId, 2, conDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.InOutTypeId, 2, conDetailRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.ChangeEvent, 50, conDetailRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.ClickEvent, 50, conDetailRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.VarId, 8, conDetailRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.ErrMsg, 2000, conDetailRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.PrjId, 4, conDetailRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.UpdUser, 20, conDetailRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.UpdDate, 20, conDetailRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.Memo, 1000, conDetailRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objDetailRegionFldsEN.RegionId, 10, conDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objDetailRegionFldsEN.CtlTypeId, 2, conDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objDetailRegionFldsEN.InOutTypeId, 2, conDetailRegionFlds.InOutTypeId);
 objDetailRegionFldsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.RegionId, 10, conDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.FldId, 8, conDetailRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.OutFldId, 8, conDetailRegionFlds.OutFldId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.LabelCaption, 150, conDetailRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.CtlTypeId, 2, conDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.InOutTypeId, 2, conDetailRegionFlds.InOutTypeId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.ChangeEvent, 50, conDetailRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.ClickEvent, 50, conDetailRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.VarId, 8, conDetailRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.ErrMsg, 2000, conDetailRegionFlds.ErrMsg);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.PrjId, 4, conDetailRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.UpdUser, 20, conDetailRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.UpdDate, 20, conDetailRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objDetailRegionFldsEN.Memo, 1000, conDetailRegionFlds.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.RegionId, conDetailRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.FldId, conDetailRegionFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.OutFldId, conDetailRegionFlds.OutFldId);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.LabelCaption, conDetailRegionFlds.LabelCaption);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.CtlTypeId, conDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.InOutTypeId, conDetailRegionFlds.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.ChangeEvent, conDetailRegionFlds.ChangeEvent);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.ClickEvent, conDetailRegionFlds.ClickEvent);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.VarId, conDetailRegionFlds.VarId);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.ErrMsg, conDetailRegionFlds.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.PrjId, conDetailRegionFlds.PrjId);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.UpdUser, conDetailRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.UpdDate, conDetailRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDetailRegionFldsEN.Memo, conDetailRegionFlds.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objDetailRegionFldsEN.RegionId, 10, conDetailRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(objDetailRegionFldsEN.CtlTypeId, 2, conDetailRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(objDetailRegionFldsEN.InOutTypeId, 2, conDetailRegionFlds.InOutTypeId);
 objDetailRegionFldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DetailRegionFlds(详细区域字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDetailRegionFldsEN.RegionId);
 if (objDetailRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null");
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objDetailRegionFldsEN.FldId);
}
 if (objDetailRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null");
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDetailRegionFldsEN.OutFldId);
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDetailRegionFldsEN._CurrTabName);
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDetailRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}