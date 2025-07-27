
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionRelaDA
 表名:vViewRegionRela(00050574)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:18:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
 框架-层名:数据处理层(CS)(DALCode)
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
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// v界面区域关系(vViewRegionRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewRegionRelaDA : clsCommBase4DA
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
 return clsvViewRegionRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewRegionRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewRegionRelaEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
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
 if (string.IsNullOrEmpty(clsvViewRegionRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewRegionRelaEN._ConnectString);
 }
 return objSQL;
 }


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewRegionRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA: GetDataTable_vViewRegionRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewRegionRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewRegionRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewRegionRela where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewRegionRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vViewRegionRela.* from vViewRegionRela Left Join {1} on {2} where {3} and vViewRegionRela.mId not in (Select top {5} vViewRegionRela.mId from vViewRegionRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewRegionRela where {1} and mId not in (Select top {2} mId from vViewRegionRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewRegionRela where {1} and mId not in (Select top {3} mId from vViewRegionRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewRegionRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vViewRegionRela.* from vViewRegionRela Left Join {1} on {2} where {3} and vViewRegionRela.mId not in (Select top {5} vViewRegionRela.mId from vViewRegionRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewRegionRela where {1} and mId not in (Select top {2} mId from vViewRegionRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewRegionRela where {1} and mId not in (Select top {3} mId from vViewRegionRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvViewRegionRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA:GetObjLst)", objException.Message));
}
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = TransNullToInt(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = TransNullToBool(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = TransNullToBool(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewRegionRelaDA: GetObjLst)", objException.Message));
}
objvViewRegionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsvViewRegionRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewRegionRelaEN> arrObjLst = new List<clsvViewRegionRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = TransNullToInt(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = TransNullToBool(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = TransNullToBool(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewRegionRelaDA: GetObjLst)", objException.Message));
}
objvViewRegionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewRegionRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewRegionRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewRegionRela(ref clsvViewRegionRelaEN objvViewRegionRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegionRela where mId = " + ""+ objvViewRegionRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewRegionRelaEN.mId = TransNullToInt(objDT.Rows[0][convViewRegionRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvViewRegionRelaEN.RegionId = objDT.Rows[0][convViewRegionRela.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvViewRegionRelaEN.RegionName = objDT.Rows[0][convViewRegionRela.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewRegionRelaEN.RegionTypeId = objDT.Rows[0][convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewRegionRelaEN.RegionTypeName = objDT.Rows[0][convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewRegionRelaEN.RegionTypeSimName = objDT.Rows[0][convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名(字段类型:varchar,字段长度:10,是否可空:True)
 objvViewRegionRelaEN.RegionTypeOrderNum = TransNullToInt(objDT.Rows[0][convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionRelaEN.Height = TransNullToInt(objDT.Rows[0][convViewRegionRela.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionRelaEN.Width = TransNullToInt(objDT.Rows[0][convViewRegionRela.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionRelaEN.ColNum = TransNullToInt(objDT.Rows[0][convViewRegionRela.ColNum].ToString().Trim()); //列数(字段类型:int,字段长度:4,是否可空:False)
 objvViewRegionRelaEN.ContainerTypeName = objDT.Rows[0][convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewRegionRelaEN.PageDispModeName = objDT.Rows[0][convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewRegionRelaEN.ViewId = objDT.Rows[0][convViewRegionRela.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewRegionRelaEN.ViewName = objDT.Rows[0][convViewRegionRela.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewRegionRelaEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewRegionRelaEN.ViewCnName = objDT.Rows[0][convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewRegionRelaEN.FileName = objDT.Rows[0][convViewRegionRela.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvViewRegionRelaEN.ContainerTypeId = objDT.Rows[0][convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvViewRegionRelaEN.PageDispModeId = objDT.Rows[0][convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvViewRegionRelaEN.InUse = TransNullToBool(objDT.Rows[0][convViewRegionRela.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvViewRegionRelaEN.IsDisp = TransNullToBool(objDT.Rows[0][convViewRegionRela.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objvViewRegionRelaEN.PrjId = objDT.Rows[0][convViewRegionRela.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvViewRegionRelaEN.UpdUser = objDT.Rows[0][convViewRegionRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewRegionRelaEN.UpdDate = objDT.Rows[0][convViewRegionRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewRegionRelaEN.Memo = objDT.Rows[0][convViewRegionRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewRegionRelaEN.ClsName = objDT.Rows[0][convViewRegionRela.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewRegionRelaDA: GetvViewRegionRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewRegionRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegionRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
 objvViewRegionRelaEN.mId = Int32.Parse(objRow[convViewRegionRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名(字段类型:varchar,字段长度:10,是否可空:True)
 objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数(字段类型:int,字段长度:4,是否可空:False)
 objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:False)
 objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewRegionRelaDA: GetObjBymId)", objException.Message));
}
return objvViewRegionRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewRegionRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
strSQL = "Select * from vViewRegionRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN()
{
mId = TransNullToInt(objRow[convViewRegionRela.mId].ToString().Trim()), //mId
RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(), //区域Id
RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(), //区域名称
RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(), //区域类型Id
RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(), //区域类型名称
RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(), //区域类型简名
RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()), //区域类型序号
Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.Height].ToString().Trim()), //高度
Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.Width].ToString().Trim()), //宽
ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.ColNum].ToString().Trim()), //列数
ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(), //容器类型名
PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(), //页面显示模式名称
ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(), //界面Id
ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(), //界面名称
ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(), //视图中文名
FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(), //文件名
ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(), //容器类型Id
PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(), //页面显示模式Id
InUse = TransNullToBool(objRow[convViewRegionRela.InUse].ToString().Trim()), //是否在用
IsDisp = TransNullToBool(objRow[convViewRegionRela.IsDisp].ToString().Trim()), //是否显示
PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(), //工程ID
UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(), //说明
ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim() //类名
};
objvViewRegionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewRegionRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewRegionRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewRegionRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = TransNullToInt(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = TransNullToBool(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = TransNullToBool(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewRegionRelaDA: GetObjByDataRowvViewRegionRela)", objException.Message));
}
objvViewRegionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewRegionRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewRegionRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewRegionRelaEN objvViewRegionRelaEN = new clsvViewRegionRelaEN();
try
{
objvViewRegionRelaEN.mId = TransNullToInt(objRow[convViewRegionRela.mId].ToString().Trim()); //mId
objvViewRegionRelaEN.RegionId = objRow[convViewRegionRela.RegionId].ToString().Trim(); //区域Id
objvViewRegionRelaEN.RegionName = objRow[convViewRegionRela.RegionName].ToString().Trim(); //区域名称
objvViewRegionRelaEN.RegionTypeId = objRow[convViewRegionRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewRegionRelaEN.RegionTypeName = objRow[convViewRegionRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewRegionRelaEN.RegionTypeSimName = objRow[convViewRegionRela.RegionTypeSimName] == DBNull.Value ? null : objRow[convViewRegionRela.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvViewRegionRelaEN.RegionTypeOrderNum = objRow[convViewRegionRela.RegionTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objvViewRegionRelaEN.Height = objRow[convViewRegionRela.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.Height].ToString().Trim()); //高度
objvViewRegionRelaEN.Width = objRow[convViewRegionRela.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.Width].ToString().Trim()); //宽
objvViewRegionRelaEN.ColNum = objRow[convViewRegionRela.ColNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.ColNum].ToString().Trim()); //列数
objvViewRegionRelaEN.ContainerTypeName = objRow[convViewRegionRela.ContainerTypeName] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeName].ToString().Trim(); //容器类型名
objvViewRegionRelaEN.PageDispModeName = objRow[convViewRegionRela.PageDispModeName] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeName].ToString().Trim(); //页面显示模式名称
objvViewRegionRelaEN.ViewId = objRow[convViewRegionRela.ViewId] == DBNull.Value ? null : objRow[convViewRegionRela.ViewId].ToString().Trim(); //界面Id
objvViewRegionRelaEN.ViewName = objRow[convViewRegionRela.ViewName].ToString().Trim(); //界面名称
objvViewRegionRelaEN.ApplicationTypeId = objRow[convViewRegionRela.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewRegionRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewRegionRelaEN.ViewCnName = objRow[convViewRegionRela.ViewCnName] == DBNull.Value ? null : objRow[convViewRegionRela.ViewCnName].ToString().Trim(); //视图中文名
objvViewRegionRelaEN.FileName = objRow[convViewRegionRela.FileName] == DBNull.Value ? null : objRow[convViewRegionRela.FileName].ToString().Trim(); //文件名
objvViewRegionRelaEN.ContainerTypeId = objRow[convViewRegionRela.ContainerTypeId] == DBNull.Value ? null : objRow[convViewRegionRela.ContainerTypeId].ToString().Trim(); //容器类型Id
objvViewRegionRelaEN.PageDispModeId = objRow[convViewRegionRela.PageDispModeId] == DBNull.Value ? null : objRow[convViewRegionRela.PageDispModeId].ToString().Trim(); //页面显示模式Id
objvViewRegionRelaEN.InUse = TransNullToBool(objRow[convViewRegionRela.InUse].ToString().Trim()); //是否在用
objvViewRegionRelaEN.IsDisp = TransNullToBool(objRow[convViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objvViewRegionRelaEN.PrjId = objRow[convViewRegionRela.PrjId].ToString().Trim(); //工程ID
objvViewRegionRelaEN.UpdUser = objRow[convViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[convViewRegionRela.UpdUser].ToString().Trim(); //修改者
objvViewRegionRelaEN.UpdDate = objRow[convViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[convViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objvViewRegionRelaEN.Memo = objRow[convViewRegionRela.Memo] == DBNull.Value ? null : objRow[convViewRegionRela.Memo].ToString().Trim(); //说明
objvViewRegionRelaEN.ClsName = objRow[convViewRegionRela.ClsName] == DBNull.Value ? null : objRow[convViewRegionRela.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewRegionRelaDA: GetObjByDataRow)", objException.Message));
}
objvViewRegionRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewRegionRelaEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewRegionRelaEN._CurrTabName, convViewRegionRela.mId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewRegionRelaEN._CurrTabName, convViewRegionRela.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vViewRegionRela where " + strCondition;
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
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
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
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vViewRegionRela where " + strCondition;
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
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewRegionRela", "mId = " + ""+ lngmId+""))
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
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewRegionRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewRegionRela", strCondition))
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
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewRegionRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewRegionRelaENS">源对象</param>
 /// <param name = "objvViewRegionRelaENT">目标对象</param>
public void CopyTo(clsvViewRegionRelaEN objvViewRegionRelaENS, clsvViewRegionRelaEN objvViewRegionRelaENT)
{
objvViewRegionRelaENT.mId = objvViewRegionRelaENS.mId; //mId
objvViewRegionRelaENT.RegionId = objvViewRegionRelaENS.RegionId; //区域Id
objvViewRegionRelaENT.RegionName = objvViewRegionRelaENS.RegionName; //区域名称
objvViewRegionRelaENT.RegionTypeId = objvViewRegionRelaENS.RegionTypeId; //区域类型Id
objvViewRegionRelaENT.RegionTypeName = objvViewRegionRelaENS.RegionTypeName; //区域类型名称
objvViewRegionRelaENT.RegionTypeSimName = objvViewRegionRelaENS.RegionTypeSimName; //区域类型简名
objvViewRegionRelaENT.RegionTypeOrderNum = objvViewRegionRelaENS.RegionTypeOrderNum; //区域类型序号
objvViewRegionRelaENT.Height = objvViewRegionRelaENS.Height; //高度
objvViewRegionRelaENT.Width = objvViewRegionRelaENS.Width; //宽
objvViewRegionRelaENT.ColNum = objvViewRegionRelaENS.ColNum; //列数
objvViewRegionRelaENT.ContainerTypeName = objvViewRegionRelaENS.ContainerTypeName; //容器类型名
objvViewRegionRelaENT.PageDispModeName = objvViewRegionRelaENS.PageDispModeName; //页面显示模式名称
objvViewRegionRelaENT.ViewId = objvViewRegionRelaENS.ViewId; //界面Id
objvViewRegionRelaENT.ViewName = objvViewRegionRelaENS.ViewName; //界面名称
objvViewRegionRelaENT.ApplicationTypeId = objvViewRegionRelaENS.ApplicationTypeId; //应用程序类型ID
objvViewRegionRelaENT.ViewCnName = objvViewRegionRelaENS.ViewCnName; //视图中文名
objvViewRegionRelaENT.FileName = objvViewRegionRelaENS.FileName; //文件名
objvViewRegionRelaENT.ContainerTypeId = objvViewRegionRelaENS.ContainerTypeId; //容器类型Id
objvViewRegionRelaENT.PageDispModeId = objvViewRegionRelaENS.PageDispModeId; //页面显示模式Id
objvViewRegionRelaENT.InUse = objvViewRegionRelaENS.InUse; //是否在用
objvViewRegionRelaENT.IsDisp = objvViewRegionRelaENS.IsDisp; //是否显示
objvViewRegionRelaENT.PrjId = objvViewRegionRelaENS.PrjId; //工程ID
objvViewRegionRelaENT.UpdUser = objvViewRegionRelaENS.UpdUser; //修改者
objvViewRegionRelaENT.UpdDate = objvViewRegionRelaENS.UpdDate; //修改日期
objvViewRegionRelaENT.Memo = objvViewRegionRelaENS.Memo; //说明
objvViewRegionRelaENT.ClsName = objvViewRegionRelaENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewRegionRelaEN objvViewRegionRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.RegionId, 10, convViewRegionRela.RegionId);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.RegionName, 50, convViewRegionRela.RegionName);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.RegionTypeId, 4, convViewRegionRela.RegionTypeId);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.RegionTypeName, 30, convViewRegionRela.RegionTypeName);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.RegionTypeSimName, 10, convViewRegionRela.RegionTypeSimName);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.ContainerTypeName, 50, convViewRegionRela.ContainerTypeName);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.PageDispModeName, 50, convViewRegionRela.PageDispModeName);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.ViewId, 8, convViewRegionRela.ViewId);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.ViewName, 100, convViewRegionRela.ViewName);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.ViewCnName, 100, convViewRegionRela.ViewCnName);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.FileName, 150, convViewRegionRela.FileName);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.ContainerTypeId, 4, convViewRegionRela.ContainerTypeId);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.PageDispModeId, 2, convViewRegionRela.PageDispModeId);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.PrjId, 4, convViewRegionRela.PrjId);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.UpdUser, 20, convViewRegionRela.UpdUser);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.UpdDate, 20, convViewRegionRela.UpdDate);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.Memo, 1000, convViewRegionRela.Memo);
clsCheckSql.CheckFieldLen(objvViewRegionRelaEN.ClsName, 100, convViewRegionRela.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.RegionId, convViewRegionRela.RegionId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.RegionName, convViewRegionRela.RegionName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.RegionTypeId, convViewRegionRela.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.RegionTypeName, convViewRegionRela.RegionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.RegionTypeSimName, convViewRegionRela.RegionTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.ContainerTypeName, convViewRegionRela.ContainerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.PageDispModeName, convViewRegionRela.PageDispModeName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.ViewId, convViewRegionRela.ViewId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.ViewName, convViewRegionRela.ViewName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.ViewCnName, convViewRegionRela.ViewCnName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.FileName, convViewRegionRela.FileName);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.ContainerTypeId, convViewRegionRela.ContainerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.PageDispModeId, convViewRegionRela.PageDispModeId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.PrjId, convViewRegionRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.UpdUser, convViewRegionRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.UpdDate, convViewRegionRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.Memo, convViewRegionRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvViewRegionRelaEN.ClsName, convViewRegionRela.ClsName);
//检查外键字段长度
 objvViewRegionRelaEN._IsCheckProperty = true;
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
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
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
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
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
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewRegionRelaEN._CurrTabName);
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
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewRegionRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvViewRegionRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}