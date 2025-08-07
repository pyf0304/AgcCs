
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionDA
 表名:ViewRegion(00050099)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:15
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
 /// 界面区域(ViewRegion)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewRegionDA : clsCommBase4DA
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
 return clsViewRegionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewRegionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewRegionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewRegionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewRegionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strRegionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strRegionId)
{
strRegionId = strRegionId.Replace("'", "''");
if (strRegionId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:ViewRegion中,检查关键字,长度不正确!(clsViewRegionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRegionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ViewRegion中,关键字不能为空 或 null!(clsViewRegionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRegionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsViewRegionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewRegion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewRegionDA: GetDataTable_ViewRegion)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewRegionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRegion where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRegion where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewRegionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewRegion where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewRegionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewRegion.* " + 
$"from ViewRegion " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewRegion.RegionId not in " + 
$"(Select top {intTop_In} ViewRegion.RegionId from ViewRegion " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRegion where {1} and RegionId not in (Select top {2} RegionId from ViewRegion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRegion where {1} and RegionId not in (Select top {3} RegionId from ViewRegion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewRegionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewRegion.* " + 
$"from ViewRegion " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewRegion.RegionId not in " + 
$"(Select top {intTop_In} ViewRegion.RegionId from ViewRegion " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewRegion where {1} and RegionId not in (Select top {2} RegionId from ViewRegion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewRegion where {1} and RegionId not in (Select top {3} RegionId from ViewRegion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewRegionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewRegionDA:GetObjLst)", objException.Message));
}
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewRegionDA: GetObjLst)", objException.Message));
}
objViewRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewRegionEN);
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
public List<clsViewRegionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewRegionDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewRegionDA: GetObjLst)", objException.Message));
}
objViewRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewRegionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewRegionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewRegion(ref clsViewRegionEN objViewRegionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegion where RegionId = " + "'"+ objViewRegionEN.RegionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewRegionEN.RegionId = objDT.Rows[0][conViewRegion.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objViewRegionEN.RegionName = objDT.Rows[0][conViewRegion.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objViewRegionEN.RegionTypeId = objDT.Rows[0][conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objViewRegionEN.FileName = objDT.Rows[0][conViewRegion.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objViewRegionEN.Height = TransNullToInt(objDT.Rows[0][conViewRegion.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objViewRegionEN.Width = TransNullToInt(objDT.Rows[0][conViewRegion.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objViewRegionEN.ColNum = TransNullToInt(objDT.Rows[0][conViewRegion.ColNum].ToString().Trim()); //列数(字段类型:int,字段长度:4,是否可空:False)
 objViewRegionEN.ContainerTypeId = objDT.Rows[0][conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id(字段类型:char,字段长度:4,是否可空:True)
 objViewRegionEN.PageDispModeId = objDT.Rows[0][conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objViewRegionEN.InOutTypeId = objDT.Rows[0][conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objViewRegionEN.TabId = objDT.Rows[0][conViewRegion.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewRegionEN.KeyId4Test = objDT.Rows[0][conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objViewRegionEN.ErrMsg = objDT.Rows[0][conViewRegion.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objViewRegionEN.PrjId = objDT.Rows[0][conViewRegion.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewRegionEN.UpdUser = objDT.Rows[0][conViewRegion.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionEN.UpdDate = objDT.Rows[0][conViewRegion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionEN.Memo = objDT.Rows[0][conViewRegion.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewRegionEN.ClsName = objDT.Rows[0][conViewRegion.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewRegionDA: GetViewRegion)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewRegionEN GetObjByRegionId(string strRegionId)
{
CheckPrimaryKey(strRegionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegion where RegionId = " + "'"+ strRegionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
 objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数(字段类型:int,字段长度:4,是否可空:False)
 objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id(字段类型:char,字段长度:4,是否可空:True)
 objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID(字段类型:char,字段长度:2,是否可空:False)
 objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewRegionDA: GetObjByRegionId)", objException.Message));
}
return objViewRegionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewRegionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewRegionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN()
{
RegionId = objRow[conViewRegion.RegionId].ToString().Trim(), //区域Id
RegionName = objRow[conViewRegion.RegionName].ToString().Trim(), //区域名称
RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(), //区域类型Id
FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(), //文件名
Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.Height].ToString().Trim()), //高度
Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.Width].ToString().Trim()), //宽
ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.ColNum].ToString().Trim()), //列数
ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(), //容器类型Id
PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(), //页面显示模式Id
InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(), //INOUT类型ID
TabId = objRow[conViewRegion.TabId].ToString().Trim(), //表ID
KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(), //测试关键字Id
ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conViewRegion.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(), //说明
ClsName = objRow[conViewRegion.ClsName].ToString().Trim() //类名
};
objViewRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRegionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewRegionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewRegionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewRegionDA: GetObjByDataRowViewRegion)", objException.Message));
}
objViewRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRegionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewRegionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewRegionDA: GetObjByDataRow)", objException.Message));
}
objViewRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewRegionEN;
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
objSQL = clsViewRegionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewRegionEN._CurrTabName, conViewRegion.RegionId, 10, "");
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
objSQL = clsViewRegionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewRegionEN._CurrTabName, conViewRegion.RegionId, 10, strPrefix);
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
 objSQL = clsViewRegionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RegionId from ViewRegion where " + strCondition;
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
 objSQL = clsViewRegionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RegionId from ViewRegion where " + strCondition;
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strRegionId)
{
CheckPrimaryKey(strRegionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewRegion", "RegionId = " + "'"+ strRegionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewRegionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewRegion", strCondition))
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
objSQL = clsViewRegionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewRegion");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewRegionEN objViewRegionEN)
 {
 objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegion where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewRegion");
objRow = objDS.Tables["ViewRegion"].NewRow();
objRow[conViewRegion.RegionId] = objViewRegionEN.RegionId; //区域Id
objRow[conViewRegion.RegionName] = objViewRegionEN.RegionName; //区域名称
objRow[conViewRegion.RegionTypeId] = objViewRegionEN.RegionTypeId; //区域类型Id
 if (objViewRegionEN.FileName !=  "")
 {
objRow[conViewRegion.FileName] = objViewRegionEN.FileName; //文件名
 }
objRow[conViewRegion.Height] = objViewRegionEN.Height; //高度
objRow[conViewRegion.Width] = objViewRegionEN.Width; //宽
objRow[conViewRegion.ColNum] = objViewRegionEN.ColNum; //列数
 if (objViewRegionEN.ContainerTypeId !=  "")
 {
objRow[conViewRegion.ContainerTypeId] = objViewRegionEN.ContainerTypeId; //容器类型Id
 }
 if (objViewRegionEN.PageDispModeId !=  "")
 {
objRow[conViewRegion.PageDispModeId] = objViewRegionEN.PageDispModeId; //页面显示模式Id
 }
objRow[conViewRegion.InOutTypeId] = objViewRegionEN.InOutTypeId; //INOUT类型ID
objRow[conViewRegion.TabId] = objViewRegionEN.TabId; //表ID
 if (objViewRegionEN.KeyId4Test !=  "")
 {
objRow[conViewRegion.KeyId4Test] = objViewRegionEN.KeyId4Test; //测试关键字Id
 }
 if (objViewRegionEN.ErrMsg !=  "")
 {
objRow[conViewRegion.ErrMsg] = objViewRegionEN.ErrMsg; //错误信息
 }
objRow[conViewRegion.PrjId] = objViewRegionEN.PrjId; //工程Id
 if (objViewRegionEN.UpdUser !=  "")
 {
objRow[conViewRegion.UpdUser] = objViewRegionEN.UpdUser; //修改者
 }
 if (objViewRegionEN.UpdDate !=  "")
 {
objRow[conViewRegion.UpdDate] = objViewRegionEN.UpdDate; //修改日期
 }
 if (objViewRegionEN.Memo !=  "")
 {
objRow[conViewRegion.Memo] = objViewRegionEN.Memo; //说明
 }
objRow[conViewRegion.ClsName] = objViewRegionEN.ClsName; //类名
objDS.Tables[clsViewRegionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewRegionEN._CurrTabName);
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
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewRegionEN objViewRegionEN)
{
 objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewRegionEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionId);
 var strRegionId = objViewRegionEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionEN.RegionName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionName);
 var strRegionName = objViewRegionEN.RegionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionName + "'");
 }
 
 if (objViewRegionEN.RegionTypeId  ==  "")
 {
 objViewRegionEN.RegionTypeId = null;
 }
 if (objViewRegionEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionTypeId);
 var strRegionTypeId = objViewRegionEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeId + "'");
 }
 
 if (objViewRegionEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.FileName);
 var strFileName = objViewRegionEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objViewRegionEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Height);
 arrValueListForInsert.Add(objViewRegionEN.Height.ToString());
 }
 
 if (objViewRegionEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Width);
 arrValueListForInsert.Add(objViewRegionEN.Width.ToString());
 }
 
 if (objViewRegionEN.ColNum !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ColNum);
 arrValueListForInsert.Add(objViewRegionEN.ColNum.ToString());
 }
 
 if (objViewRegionEN.ContainerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ContainerTypeId);
 var strContainerTypeId = objViewRegionEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeId + "'");
 }
 
 if (objViewRegionEN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.PageDispModeId);
 var strPageDispModeId = objViewRegionEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 if (objViewRegionEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.InOutTypeId);
 var strInOutTypeId = objViewRegionEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objViewRegionEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.TabId);
 var strTabId = objViewRegionEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objViewRegionEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.KeyId4Test);
 var strKeyId4Test = objViewRegionEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objViewRegionEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ErrMsg);
 var strErrMsg = objViewRegionEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewRegionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.PrjId);
 var strPrjId = objViewRegionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRegionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.UpdUser);
 var strUpdUser = objViewRegionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.UpdDate);
 var strUpdDate = objViewRegionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Memo);
 var strMemo = objViewRegionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objViewRegionEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ClsName);
 var strClsName = objViewRegionEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewRegionEN objViewRegionEN)
{
 objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewRegionEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionId);
 var strRegionId = objViewRegionEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionEN.RegionName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionName);
 var strRegionName = objViewRegionEN.RegionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionName + "'");
 }
 
 if (objViewRegionEN.RegionTypeId  ==  "")
 {
 objViewRegionEN.RegionTypeId = null;
 }
 if (objViewRegionEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionTypeId);
 var strRegionTypeId = objViewRegionEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeId + "'");
 }
 
 if (objViewRegionEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.FileName);
 var strFileName = objViewRegionEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objViewRegionEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Height);
 arrValueListForInsert.Add(objViewRegionEN.Height.ToString());
 }
 
 if (objViewRegionEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Width);
 arrValueListForInsert.Add(objViewRegionEN.Width.ToString());
 }
 
 if (objViewRegionEN.ColNum !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ColNum);
 arrValueListForInsert.Add(objViewRegionEN.ColNum.ToString());
 }
 
 if (objViewRegionEN.ContainerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ContainerTypeId);
 var strContainerTypeId = objViewRegionEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeId + "'");
 }
 
 if (objViewRegionEN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.PageDispModeId);
 var strPageDispModeId = objViewRegionEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 if (objViewRegionEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.InOutTypeId);
 var strInOutTypeId = objViewRegionEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objViewRegionEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.TabId);
 var strTabId = objViewRegionEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objViewRegionEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.KeyId4Test);
 var strKeyId4Test = objViewRegionEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objViewRegionEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ErrMsg);
 var strErrMsg = objViewRegionEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewRegionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.PrjId);
 var strPrjId = objViewRegionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRegionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.UpdUser);
 var strUpdUser = objViewRegionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.UpdDate);
 var strUpdDate = objViewRegionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Memo);
 var strMemo = objViewRegionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objViewRegionEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ClsName);
 var strClsName = objViewRegionEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objViewRegionEN.RegionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewRegionEN objViewRegionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewRegionEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionId);
 var strRegionId = objViewRegionEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionEN.RegionName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionName);
 var strRegionName = objViewRegionEN.RegionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionName + "'");
 }
 
 if (objViewRegionEN.RegionTypeId  ==  "")
 {
 objViewRegionEN.RegionTypeId = null;
 }
 if (objViewRegionEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionTypeId);
 var strRegionTypeId = objViewRegionEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeId + "'");
 }
 
 if (objViewRegionEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.FileName);
 var strFileName = objViewRegionEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objViewRegionEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Height);
 arrValueListForInsert.Add(objViewRegionEN.Height.ToString());
 }
 
 if (objViewRegionEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Width);
 arrValueListForInsert.Add(objViewRegionEN.Width.ToString());
 }
 
 if (objViewRegionEN.ColNum !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ColNum);
 arrValueListForInsert.Add(objViewRegionEN.ColNum.ToString());
 }
 
 if (objViewRegionEN.ContainerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ContainerTypeId);
 var strContainerTypeId = objViewRegionEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeId + "'");
 }
 
 if (objViewRegionEN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.PageDispModeId);
 var strPageDispModeId = objViewRegionEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 if (objViewRegionEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.InOutTypeId);
 var strInOutTypeId = objViewRegionEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objViewRegionEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.TabId);
 var strTabId = objViewRegionEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objViewRegionEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.KeyId4Test);
 var strKeyId4Test = objViewRegionEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objViewRegionEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ErrMsg);
 var strErrMsg = objViewRegionEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewRegionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.PrjId);
 var strPrjId = objViewRegionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRegionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.UpdUser);
 var strUpdUser = objViewRegionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.UpdDate);
 var strUpdDate = objViewRegionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Memo);
 var strMemo = objViewRegionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objViewRegionEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ClsName);
 var strClsName = objViewRegionEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objViewRegionEN.RegionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewRegionEN objViewRegionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewRegionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewRegionEN.RegionId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionId);
 var strRegionId = objViewRegionEN.RegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionId + "'");
 }
 
 if (objViewRegionEN.RegionName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionName);
 var strRegionName = objViewRegionEN.RegionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionName + "'");
 }
 
 if (objViewRegionEN.RegionTypeId  ==  "")
 {
 objViewRegionEN.RegionTypeId = null;
 }
 if (objViewRegionEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.RegionTypeId);
 var strRegionTypeId = objViewRegionEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegionTypeId + "'");
 }
 
 if (objViewRegionEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.FileName);
 var strFileName = objViewRegionEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objViewRegionEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Height);
 arrValueListForInsert.Add(objViewRegionEN.Height.ToString());
 }
 
 if (objViewRegionEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Width);
 arrValueListForInsert.Add(objViewRegionEN.Width.ToString());
 }
 
 if (objViewRegionEN.ColNum !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ColNum);
 arrValueListForInsert.Add(objViewRegionEN.ColNum.ToString());
 }
 
 if (objViewRegionEN.ContainerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ContainerTypeId);
 var strContainerTypeId = objViewRegionEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strContainerTypeId + "'");
 }
 
 if (objViewRegionEN.PageDispModeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.PageDispModeId);
 var strPageDispModeId = objViewRegionEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageDispModeId + "'");
 }
 
 if (objViewRegionEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.InOutTypeId);
 var strInOutTypeId = objViewRegionEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objViewRegionEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.TabId);
 var strTabId = objViewRegionEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objViewRegionEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.KeyId4Test);
 var strKeyId4Test = objViewRegionEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objViewRegionEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ErrMsg);
 var strErrMsg = objViewRegionEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewRegionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.PrjId);
 var strPrjId = objViewRegionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewRegionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.UpdUser);
 var strUpdUser = objViewRegionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objViewRegionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.UpdDate);
 var strUpdDate = objViewRegionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewRegionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.Memo);
 var strMemo = objViewRegionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objViewRegionEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conViewRegion.ClsName);
 var strClsName = objViewRegionEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewRegion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewRegions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegion where RegionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewRegion");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewRegionEN._CurrTabName ].NewRow();
objRow[conViewRegion.RegionId] = oRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objRow[conViewRegion.RegionName] = oRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objRow[conViewRegion.RegionTypeId] = oRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objRow[conViewRegion.FileName] = oRow[conViewRegion.FileName].ToString().Trim(); //文件名
objRow[conViewRegion.Height] = oRow[conViewRegion.Height].ToString().Trim(); //高度
objRow[conViewRegion.Width] = oRow[conViewRegion.Width].ToString().Trim(); //宽
objRow[conViewRegion.ColNum] = oRow[conViewRegion.ColNum].ToString().Trim(); //列数
objRow[conViewRegion.ContainerTypeId] = oRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objRow[conViewRegion.PageDispModeId] = oRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objRow[conViewRegion.InOutTypeId] = oRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objRow[conViewRegion.TabId] = oRow[conViewRegion.TabId].ToString().Trim(); //表ID
objRow[conViewRegion.KeyId4Test] = oRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objRow[conViewRegion.ErrMsg] = oRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objRow[conViewRegion.PrjId] = oRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objRow[conViewRegion.UpdUser] = oRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objRow[conViewRegion.UpdDate] = oRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objRow[conViewRegion.Memo] = oRow[conViewRegion.Memo].ToString().Trim(); //说明
objRow[conViewRegion.ClsName] = oRow[conViewRegion.ClsName].ToString().Trim(); //类名
 objDS.Tables[clsViewRegionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewRegionEN._CurrTabName);
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
 /// <param name = "objViewRegionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewRegionEN objViewRegionEN)
{
 objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
strSQL = "Select * from ViewRegion where RegionId = " + "'"+ objViewRegionEN.RegionId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewRegionEN._CurrTabName);
if (objDS.Tables[clsViewRegionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RegionId = " + "'"+ objViewRegionEN.RegionId+"'");
return false;
}
objRow = objDS.Tables[clsViewRegionEN._CurrTabName].Rows[0];
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionId))
 {
objRow[conViewRegion.RegionId] = objViewRegionEN.RegionId; //区域Id
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionName))
 {
objRow[conViewRegion.RegionName] = objViewRegionEN.RegionName; //区域名称
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionTypeId))
 {
objRow[conViewRegion.RegionTypeId] = objViewRegionEN.RegionTypeId; //区域类型Id
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.FileName))
 {
objRow[conViewRegion.FileName] = objViewRegionEN.FileName; //文件名
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.Height))
 {
objRow[conViewRegion.Height] = objViewRegionEN.Height; //高度
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.Width))
 {
objRow[conViewRegion.Width] = objViewRegionEN.Width; //宽
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.ColNum))
 {
objRow[conViewRegion.ColNum] = objViewRegionEN.ColNum; //列数
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.ContainerTypeId))
 {
objRow[conViewRegion.ContainerTypeId] = objViewRegionEN.ContainerTypeId; //容器类型Id
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.PageDispModeId))
 {
objRow[conViewRegion.PageDispModeId] = objViewRegionEN.PageDispModeId; //页面显示模式Id
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.InOutTypeId))
 {
objRow[conViewRegion.InOutTypeId] = objViewRegionEN.InOutTypeId; //INOUT类型ID
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.TabId))
 {
objRow[conViewRegion.TabId] = objViewRegionEN.TabId; //表ID
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.KeyId4Test))
 {
objRow[conViewRegion.KeyId4Test] = objViewRegionEN.KeyId4Test; //测试关键字Id
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.ErrMsg))
 {
objRow[conViewRegion.ErrMsg] = objViewRegionEN.ErrMsg; //错误信息
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.PrjId))
 {
objRow[conViewRegion.PrjId] = objViewRegionEN.PrjId; //工程Id
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.UpdUser))
 {
objRow[conViewRegion.UpdUser] = objViewRegionEN.UpdUser; //修改者
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.UpdDate))
 {
objRow[conViewRegion.UpdDate] = objViewRegionEN.UpdDate; //修改日期
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.Memo))
 {
objRow[conViewRegion.Memo] = objViewRegionEN.Memo; //说明
 }
 if (objViewRegionEN.IsUpdated(conViewRegion.ClsName))
 {
objRow[conViewRegion.ClsName] = objViewRegionEN.ClsName; //类名
 }
try
{
objDA.Update(objDS, clsViewRegionEN._CurrTabName);
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
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewRegionEN objViewRegionEN)
{
 objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewRegion Set ");
 
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionName))
 {
 if (objViewRegionEN.RegionName !=  null)
 {
 var strRegionName = objViewRegionEN.RegionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionName, conViewRegion.RegionName); //区域名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.RegionName); //区域名称
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionTypeId))
 {
 if (objViewRegionEN.RegionTypeId  ==  "")
 {
 objViewRegionEN.RegionTypeId = null;
 }
 if (objViewRegionEN.RegionTypeId !=  null)
 {
 var strRegionTypeId = objViewRegionEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionTypeId, conViewRegion.RegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.RegionTypeId); //区域类型Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.FileName))
 {
 if (objViewRegionEN.FileName !=  null)
 {
 var strFileName = objViewRegionEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conViewRegion.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.FileName); //文件名
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Height))
 {
 if (objViewRegionEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.Height, conViewRegion.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.Height); //高度
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Width))
 {
 if (objViewRegionEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.Width, conViewRegion.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.Width); //宽
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ColNum))
 {
 if (objViewRegionEN.ColNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.ColNum, conViewRegion.ColNum); //列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.ColNum); //列数
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ContainerTypeId))
 {
 if (objViewRegionEN.ContainerTypeId !=  null)
 {
 var strContainerTypeId = objViewRegionEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strContainerTypeId, conViewRegion.ContainerTypeId); //容器类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.ContainerTypeId); //容器类型Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.PageDispModeId))
 {
 if (objViewRegionEN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objViewRegionEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageDispModeId, conViewRegion.PageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.PageDispModeId); //页面显示模式Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.InOutTypeId))
 {
 if (objViewRegionEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objViewRegionEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, conViewRegion.InOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.InOutTypeId); //INOUT类型ID
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.TabId))
 {
 if (objViewRegionEN.TabId !=  null)
 {
 var strTabId = objViewRegionEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conViewRegion.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.TabId); //表ID
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.KeyId4Test))
 {
 if (objViewRegionEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objViewRegionEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyId4Test, conViewRegion.KeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.KeyId4Test); //测试关键字Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ErrMsg))
 {
 if (objViewRegionEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewRegionEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conViewRegion.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.ErrMsg); //错误信息
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.PrjId))
 {
 if (objViewRegionEN.PrjId !=  null)
 {
 var strPrjId = objViewRegionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewRegion.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.PrjId); //工程Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.UpdUser))
 {
 if (objViewRegionEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewRegion.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.UpdUser); //修改者
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.UpdDate))
 {
 if (objViewRegionEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewRegion.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.UpdDate); //修改日期
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Memo))
 {
 if (objViewRegionEN.Memo !=  null)
 {
 var strMemo = objViewRegionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewRegion.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.Memo); //说明
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ClsName))
 {
 if (objViewRegionEN.ClsName !=  null)
 {
 var strClsName = objViewRegionEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsName, conViewRegion.ClsName); //类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.ClsName); //类名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RegionId = '{0}'", objViewRegionEN.RegionId); 
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
 /// <param name = "objViewRegionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewRegionEN objViewRegionEN, string strCondition)
{
 objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRegion Set ");
 
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionName))
 {
 if (objViewRegionEN.RegionName !=  null)
 {
 var strRegionName = objViewRegionEN.RegionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionName = '{0}',", strRegionName); //区域名称
 }
 else
 {
 sbSQL.Append(" RegionName = null,"); //区域名称
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionTypeId))
 {
 if (objViewRegionEN.RegionTypeId  ==  "")
 {
 objViewRegionEN.RegionTypeId = null;
 }
 if (objViewRegionEN.RegionTypeId !=  null)
 {
 var strRegionTypeId = objViewRegionEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionTypeId = '{0}',", strRegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.Append(" RegionTypeId = null,"); //区域类型Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.FileName))
 {
 if (objViewRegionEN.FileName !=  null)
 {
 var strFileName = objViewRegionEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Height))
 {
 if (objViewRegionEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.Height, conViewRegion.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.Height); //高度
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Width))
 {
 if (objViewRegionEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.Width, conViewRegion.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.Width); //宽
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ColNum))
 {
 if (objViewRegionEN.ColNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.ColNum, conViewRegion.ColNum); //列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.ColNum); //列数
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ContainerTypeId))
 {
 if (objViewRegionEN.ContainerTypeId !=  null)
 {
 var strContainerTypeId = objViewRegionEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ContainerTypeId = '{0}',", strContainerTypeId); //容器类型Id
 }
 else
 {
 sbSQL.Append(" ContainerTypeId = null,"); //容器类型Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.PageDispModeId))
 {
 if (objViewRegionEN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objViewRegionEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageDispModeId = '{0}',", strPageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.Append(" PageDispModeId = null,"); //页面显示模式Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.InOutTypeId))
 {
 if (objViewRegionEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objViewRegionEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //INOUT类型ID
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.TabId))
 {
 if (objViewRegionEN.TabId !=  null)
 {
 var strTabId = objViewRegionEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.KeyId4Test))
 {
 if (objViewRegionEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objViewRegionEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyId4Test = '{0}',", strKeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.Append(" KeyId4Test = null,"); //测试关键字Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ErrMsg))
 {
 if (objViewRegionEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewRegionEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.PrjId))
 {
 if (objViewRegionEN.PrjId !=  null)
 {
 var strPrjId = objViewRegionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.UpdUser))
 {
 if (objViewRegionEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.UpdDate))
 {
 if (objViewRegionEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Memo))
 {
 if (objViewRegionEN.Memo !=  null)
 {
 var strMemo = objViewRegionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ClsName))
 {
 if (objViewRegionEN.ClsName !=  null)
 {
 var strClsName = objViewRegionEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsName = '{0}',", strClsName); //类名
 }
 else
 {
 sbSQL.Append(" ClsName = null,"); //类名
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
 /// <param name = "objViewRegionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewRegionEN objViewRegionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRegion Set ");
 
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionName))
 {
 if (objViewRegionEN.RegionName !=  null)
 {
 var strRegionName = objViewRegionEN.RegionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionName = '{0}',", strRegionName); //区域名称
 }
 else
 {
 sbSQL.Append(" RegionName = null,"); //区域名称
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionTypeId))
 {
 if (objViewRegionEN.RegionTypeId  ==  "")
 {
 objViewRegionEN.RegionTypeId = null;
 }
 if (objViewRegionEN.RegionTypeId !=  null)
 {
 var strRegionTypeId = objViewRegionEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionTypeId = '{0}',", strRegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.Append(" RegionTypeId = null,"); //区域类型Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.FileName))
 {
 if (objViewRegionEN.FileName !=  null)
 {
 var strFileName = objViewRegionEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Height))
 {
 if (objViewRegionEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.Height, conViewRegion.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.Height); //高度
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Width))
 {
 if (objViewRegionEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.Width, conViewRegion.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.Width); //宽
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ColNum))
 {
 if (objViewRegionEN.ColNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.ColNum, conViewRegion.ColNum); //列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.ColNum); //列数
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ContainerTypeId))
 {
 if (objViewRegionEN.ContainerTypeId !=  null)
 {
 var strContainerTypeId = objViewRegionEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ContainerTypeId = '{0}',", strContainerTypeId); //容器类型Id
 }
 else
 {
 sbSQL.Append(" ContainerTypeId = null,"); //容器类型Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.PageDispModeId))
 {
 if (objViewRegionEN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objViewRegionEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageDispModeId = '{0}',", strPageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.Append(" PageDispModeId = null,"); //页面显示模式Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.InOutTypeId))
 {
 if (objViewRegionEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objViewRegionEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //INOUT类型ID
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.TabId))
 {
 if (objViewRegionEN.TabId !=  null)
 {
 var strTabId = objViewRegionEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.KeyId4Test))
 {
 if (objViewRegionEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objViewRegionEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyId4Test = '{0}',", strKeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.Append(" KeyId4Test = null,"); //测试关键字Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ErrMsg))
 {
 if (objViewRegionEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewRegionEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.PrjId))
 {
 if (objViewRegionEN.PrjId !=  null)
 {
 var strPrjId = objViewRegionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.UpdUser))
 {
 if (objViewRegionEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.UpdDate))
 {
 if (objViewRegionEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Memo))
 {
 if (objViewRegionEN.Memo !=  null)
 {
 var strMemo = objViewRegionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ClsName))
 {
 if (objViewRegionEN.ClsName !=  null)
 {
 var strClsName = objViewRegionEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsName = '{0}',", strClsName); //类名
 }
 else
 {
 sbSQL.Append(" ClsName = null,"); //类名
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
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewRegionEN objViewRegionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewRegionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewRegionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewRegion Set ");
 
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionName))
 {
 if (objViewRegionEN.RegionName !=  null)
 {
 var strRegionName = objViewRegionEN.RegionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionName, conViewRegion.RegionName); //区域名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.RegionName); //区域名称
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.RegionTypeId))
 {
 if (objViewRegionEN.RegionTypeId  ==  "")
 {
 objViewRegionEN.RegionTypeId = null;
 }
 if (objViewRegionEN.RegionTypeId !=  null)
 {
 var strRegionTypeId = objViewRegionEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegionTypeId, conViewRegion.RegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.RegionTypeId); //区域类型Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.FileName))
 {
 if (objViewRegionEN.FileName !=  null)
 {
 var strFileName = objViewRegionEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conViewRegion.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.FileName); //文件名
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Height))
 {
 if (objViewRegionEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.Height, conViewRegion.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.Height); //高度
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Width))
 {
 if (objViewRegionEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.Width, conViewRegion.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.Width); //宽
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ColNum))
 {
 if (objViewRegionEN.ColNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objViewRegionEN.ColNum, conViewRegion.ColNum); //列数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.ColNum); //列数
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ContainerTypeId))
 {
 if (objViewRegionEN.ContainerTypeId !=  null)
 {
 var strContainerTypeId = objViewRegionEN.ContainerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strContainerTypeId, conViewRegion.ContainerTypeId); //容器类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.ContainerTypeId); //容器类型Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.PageDispModeId))
 {
 if (objViewRegionEN.PageDispModeId !=  null)
 {
 var strPageDispModeId = objViewRegionEN.PageDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageDispModeId, conViewRegion.PageDispModeId); //页面显示模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.PageDispModeId); //页面显示模式Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.InOutTypeId))
 {
 if (objViewRegionEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objViewRegionEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, conViewRegion.InOutTypeId); //INOUT类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.InOutTypeId); //INOUT类型ID
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.TabId))
 {
 if (objViewRegionEN.TabId !=  null)
 {
 var strTabId = objViewRegionEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conViewRegion.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.TabId); //表ID
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.KeyId4Test))
 {
 if (objViewRegionEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objViewRegionEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyId4Test, conViewRegion.KeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.KeyId4Test); //测试关键字Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ErrMsg))
 {
 if (objViewRegionEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewRegionEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conViewRegion.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.ErrMsg); //错误信息
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.PrjId))
 {
 if (objViewRegionEN.PrjId !=  null)
 {
 var strPrjId = objViewRegionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewRegion.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.PrjId); //工程Id
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.UpdUser))
 {
 if (objViewRegionEN.UpdUser !=  null)
 {
 var strUpdUser = objViewRegionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conViewRegion.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.UpdUser); //修改者
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.UpdDate))
 {
 if (objViewRegionEN.UpdDate !=  null)
 {
 var strUpdDate = objViewRegionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewRegion.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.UpdDate); //修改日期
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.Memo))
 {
 if (objViewRegionEN.Memo !=  null)
 {
 var strMemo = objViewRegionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewRegion.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.Memo); //说明
 }
 }
 
 if (objViewRegionEN.IsUpdated(conViewRegion.ClsName))
 {
 if (objViewRegionEN.ClsName !=  null)
 {
 var strClsName = objViewRegionEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsName, conViewRegion.ClsName); //类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewRegion.ClsName); //类名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RegionId = '{0}'", objViewRegionEN.RegionId); 
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strRegionId) 
{
CheckPrimaryKey(strRegionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strRegionId,
};
 objSQL.ExecSP("ViewRegion_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strRegionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strRegionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
//删除ViewRegion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRegion where RegionId = " + "'"+ strRegionId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewRegion(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
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
//删除ViewRegion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRegion where RegionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strRegionId) 
{
CheckPrimaryKey(strRegionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
//删除ViewRegion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewRegion where RegionId = " + "'"+ strRegionId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewRegion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewRegionDA: DelViewRegion)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewRegion where " + strCondition ;
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
public bool DelViewRegionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewRegionDA: DelViewRegionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewRegionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewRegion where " + strCondition ;
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
 /// <param name = "objViewRegionENS">源对象</param>
 /// <param name = "objViewRegionENT">目标对象</param>
public void CopyTo(clsViewRegionEN objViewRegionENS, clsViewRegionEN objViewRegionENT)
{
objViewRegionENT.RegionId = objViewRegionENS.RegionId; //区域Id
objViewRegionENT.RegionName = objViewRegionENS.RegionName; //区域名称
objViewRegionENT.RegionTypeId = objViewRegionENS.RegionTypeId; //区域类型Id
objViewRegionENT.FileName = objViewRegionENS.FileName; //文件名
objViewRegionENT.Height = objViewRegionENS.Height; //高度
objViewRegionENT.Width = objViewRegionENS.Width; //宽
objViewRegionENT.ColNum = objViewRegionENS.ColNum; //列数
objViewRegionENT.ContainerTypeId = objViewRegionENS.ContainerTypeId; //容器类型Id
objViewRegionENT.PageDispModeId = objViewRegionENS.PageDispModeId; //页面显示模式Id
objViewRegionENT.InOutTypeId = objViewRegionENS.InOutTypeId; //INOUT类型ID
objViewRegionENT.TabId = objViewRegionENS.TabId; //表ID
objViewRegionENT.KeyId4Test = objViewRegionENS.KeyId4Test; //测试关键字Id
objViewRegionENT.ErrMsg = objViewRegionENS.ErrMsg; //错误信息
objViewRegionENT.PrjId = objViewRegionENS.PrjId; //工程Id
objViewRegionENT.UpdUser = objViewRegionENS.UpdUser; //修改者
objViewRegionENT.UpdDate = objViewRegionENS.UpdDate; //修改日期
objViewRegionENT.Memo = objViewRegionENS.Memo; //说明
objViewRegionENT.ClsName = objViewRegionENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewRegionEN objViewRegionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewRegionEN.RegionName, conViewRegion.RegionName);
clsCheckSql.CheckFieldNotNull(objViewRegionEN.RegionTypeId, conViewRegion.RegionTypeId);
clsCheckSql.CheckFieldNotNull(objViewRegionEN.InOutTypeId, conViewRegion.InOutTypeId);
clsCheckSql.CheckFieldNotNull(objViewRegionEN.TabId, conViewRegion.TabId);
clsCheckSql.CheckFieldNotNull(objViewRegionEN.PrjId, conViewRegion.PrjId);
clsCheckSql.CheckFieldNotNull(objViewRegionEN.ClsName, conViewRegion.ClsName);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRegionEN.RegionId, 10, conViewRegion.RegionId);
clsCheckSql.CheckFieldLen(objViewRegionEN.RegionName, 50, conViewRegion.RegionName);
clsCheckSql.CheckFieldLen(objViewRegionEN.RegionTypeId, 4, conViewRegion.RegionTypeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.FileName, 150, conViewRegion.FileName);
clsCheckSql.CheckFieldLen(objViewRegionEN.ContainerTypeId, 4, conViewRegion.ContainerTypeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.PageDispModeId, 2, conViewRegion.PageDispModeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.InOutTypeId, 2, conViewRegion.InOutTypeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.TabId, 8, conViewRegion.TabId);
clsCheckSql.CheckFieldLen(objViewRegionEN.KeyId4Test, 50, conViewRegion.KeyId4Test);
clsCheckSql.CheckFieldLen(objViewRegionEN.ErrMsg, 2000, conViewRegion.ErrMsg);
clsCheckSql.CheckFieldLen(objViewRegionEN.PrjId, 4, conViewRegion.PrjId);
clsCheckSql.CheckFieldLen(objViewRegionEN.UpdUser, 20, conViewRegion.UpdUser);
clsCheckSql.CheckFieldLen(objViewRegionEN.UpdDate, 20, conViewRegion.UpdDate);
clsCheckSql.CheckFieldLen(objViewRegionEN.Memo, 1000, conViewRegion.Memo);
clsCheckSql.CheckFieldLen(objViewRegionEN.ClsName, 100, conViewRegion.ClsName);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objViewRegionEN.RegionTypeId, 4, conViewRegion.RegionTypeId);
 objViewRegionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewRegionEN objViewRegionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRegionEN.RegionName, 50, conViewRegion.RegionName);
clsCheckSql.CheckFieldLen(objViewRegionEN.RegionTypeId, 4, conViewRegion.RegionTypeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.FileName, 150, conViewRegion.FileName);
clsCheckSql.CheckFieldLen(objViewRegionEN.ContainerTypeId, 4, conViewRegion.ContainerTypeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.PageDispModeId, 2, conViewRegion.PageDispModeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.InOutTypeId, 2, conViewRegion.InOutTypeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.TabId, 8, conViewRegion.TabId);
clsCheckSql.CheckFieldLen(objViewRegionEN.KeyId4Test, 50, conViewRegion.KeyId4Test);
clsCheckSql.CheckFieldLen(objViewRegionEN.ErrMsg, 2000, conViewRegion.ErrMsg);
clsCheckSql.CheckFieldLen(objViewRegionEN.PrjId, 4, conViewRegion.PrjId);
clsCheckSql.CheckFieldLen(objViewRegionEN.UpdUser, 20, conViewRegion.UpdUser);
clsCheckSql.CheckFieldLen(objViewRegionEN.UpdDate, 20, conViewRegion.UpdDate);
clsCheckSql.CheckFieldLen(objViewRegionEN.Memo, 1000, conViewRegion.Memo);
clsCheckSql.CheckFieldLen(objViewRegionEN.ClsName, 100, conViewRegion.ClsName);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewRegionEN.RegionTypeId, 4, conViewRegion.RegionTypeId);
 objViewRegionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewRegionEN objViewRegionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewRegionEN.RegionId, 10, conViewRegion.RegionId);
clsCheckSql.CheckFieldLen(objViewRegionEN.RegionName, 50, conViewRegion.RegionName);
clsCheckSql.CheckFieldLen(objViewRegionEN.RegionTypeId, 4, conViewRegion.RegionTypeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.FileName, 150, conViewRegion.FileName);
clsCheckSql.CheckFieldLen(objViewRegionEN.ContainerTypeId, 4, conViewRegion.ContainerTypeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.PageDispModeId, 2, conViewRegion.PageDispModeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.InOutTypeId, 2, conViewRegion.InOutTypeId);
clsCheckSql.CheckFieldLen(objViewRegionEN.TabId, 8, conViewRegion.TabId);
clsCheckSql.CheckFieldLen(objViewRegionEN.KeyId4Test, 50, conViewRegion.KeyId4Test);
clsCheckSql.CheckFieldLen(objViewRegionEN.ErrMsg, 2000, conViewRegion.ErrMsg);
clsCheckSql.CheckFieldLen(objViewRegionEN.PrjId, 4, conViewRegion.PrjId);
clsCheckSql.CheckFieldLen(objViewRegionEN.UpdUser, 20, conViewRegion.UpdUser);
clsCheckSql.CheckFieldLen(objViewRegionEN.UpdDate, 20, conViewRegion.UpdDate);
clsCheckSql.CheckFieldLen(objViewRegionEN.Memo, 1000, conViewRegion.Memo);
clsCheckSql.CheckFieldLen(objViewRegionEN.ClsName, 100, conViewRegion.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.RegionId, conViewRegion.RegionId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.RegionName, conViewRegion.RegionName);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.RegionTypeId, conViewRegion.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.FileName, conViewRegion.FileName);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.ContainerTypeId, conViewRegion.ContainerTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.PageDispModeId, conViewRegion.PageDispModeId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.InOutTypeId, conViewRegion.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.TabId, conViewRegion.TabId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.KeyId4Test, conViewRegion.KeyId4Test);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.ErrMsg, conViewRegion.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.PrjId, conViewRegion.PrjId);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.UpdUser, conViewRegion.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.UpdDate, conViewRegion.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.Memo, conViewRegion.Memo);
clsCheckSql.CheckSqlInjection4Field(objViewRegionEN.ClsName, conViewRegion.ClsName);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewRegionEN.RegionTypeId, 4, conViewRegion.RegionTypeId);
 objViewRegionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetRegionId()
{
//获取某学院所有专业信息
string strSQL = "select RegionId, RegionName from ViewRegion ";
 clsSpecSQLforSql mySql = clsViewRegionDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewRegion(界面区域),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewRegionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsViewRegionEN objViewRegionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewRegionEN.PrjId);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objViewRegionEN.ClsName);
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
 objSQL = clsViewRegionDA.GetSpecSQLObj();
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
 objSQL = clsViewRegionDA.GetSpecSQLObj();
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
 objSQL = clsViewRegionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewRegionEN._CurrTabName);
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
 objSQL = clsViewRegionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewRegionEN._CurrTabName, strCondition);
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
 objSQL = clsViewRegionDA.GetSpecSQLObj();
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
 objSQL = clsViewRegionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}