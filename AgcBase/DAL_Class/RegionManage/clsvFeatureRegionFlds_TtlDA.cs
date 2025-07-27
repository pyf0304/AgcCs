
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureRegionFlds_TtlDA
 表名:vFeatureRegionFlds_Ttl(00050474)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:44
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
 /// v功能区域字段_Ttl(vFeatureRegionFlds_Ttl)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFeatureRegionFlds_TtlDA : clsCommBase4DA
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
 return clsvFeatureRegionFlds_TtlEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFeatureRegionFlds_TtlEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureRegionFlds_TtlEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFeatureRegionFlds_TtlEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFeatureRegionFlds_TtlEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strViewFeatureId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strViewFeatureId)
{
strViewFeatureId = strViewFeatureId.Replace("'", "''");
if (strViewFeatureId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vFeatureRegionFlds_Ttl中,检查关键字,长度不正确!(clsvFeatureRegionFlds_TtlDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewFeatureId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFeatureRegionFlds_Ttl中,关键字不能为空 或 null!(clsvFeatureRegionFlds_TtlDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFeatureRegionFlds_TtlDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds_Ttl where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFeatureRegionFlds_Ttl(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetDataTable_vFeatureRegionFlds_Ttl)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds_Ttl where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds_Ttl where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds_Ttl where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds_Ttl where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds_Ttl where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFeatureRegionFlds_Ttl.* from vFeatureRegionFlds_Ttl Left Join {1} on {2} where {3} and vFeatureRegionFlds_Ttl.ViewFeatureId not in (Select top {5} vFeatureRegionFlds_Ttl.ViewFeatureId from vFeatureRegionFlds_Ttl Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds_Ttl where {1} and ViewFeatureId not in (Select top {2} ViewFeatureId from vFeatureRegionFlds_Ttl where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds_Ttl where {1} and ViewFeatureId not in (Select top {3} ViewFeatureId from vFeatureRegionFlds_Ttl where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFeatureRegionFlds_Ttl.* from vFeatureRegionFlds_Ttl Left Join {1} on {2} where {3} and vFeatureRegionFlds_Ttl.ViewFeatureId not in (Select top {5} vFeatureRegionFlds_Ttl.ViewFeatureId from vFeatureRegionFlds_Ttl Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds_Ttl where {1} and ViewFeatureId not in (Select top {2} ViewFeatureId from vFeatureRegionFlds_Ttl where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds_Ttl where {1} and ViewFeatureId not in (Select top {3} ViewFeatureId from vFeatureRegionFlds_Ttl where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFeatureRegionFlds_TtlEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA:GetObjLst)", objException.Message));
}
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds_Ttl where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = TransNullToBool(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetObjLst)", objException.Message));
}
objvFeatureRegionFlds_TtlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
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
public List<clsvFeatureRegionFlds_TtlEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFeatureRegionFlds_TtlEN> arrObjLst = new List<clsvFeatureRegionFlds_TtlEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = TransNullToBool(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetObjLst)", objException.Message));
}
objvFeatureRegionFlds_TtlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFeatureRegionFlds_TtlEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFeatureRegionFlds_Ttl(ref clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds_Ttl where ViewFeatureId = " + "'"+ objvFeatureRegionFlds_TtlEN.ViewFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFeatureRegionFlds_TtlEN.ViewFeatureId = objDT.Rows[0][convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvFeatureRegionFlds_TtlEN.RegionId = objDT.Rows[0][convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvFeatureRegionFlds_TtlEN.RegionName = objDT.Rows[0][convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFlds_TtlEN.RegionTypeId = objDT.Rows[0][convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFlds_TtlEN.RegionTypeName = objDT.Rows[0][convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.FeatureId = objDT.Rows[0][convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFlds_TtlEN.FeatureName = objDT.Rows[0][convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureRegionFlds_TtlEN.KeyWords = objDT.Rows[0][convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvFeatureRegionFlds_TtlEN.TabFeatureId = objDT.Rows[0][convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFlds_TtlEN.TabFeatureName = objDT.Rows[0][convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFlds_TtlEN.CheckTabFeature = objDT.Rows[0][convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.FeatureDescription = objDT.Rows[0][convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvFeatureRegionFlds_TtlEN.ButtonName = objDT.Rows[0][convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objDT.Rows[0][convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.EventFuncName = objDT.Rows[0][convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objDT.Rows[0][convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id(字段类型:char,字段长度:2,是否可空:False)
 objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objDT.Rows[0][convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.FuncName = objDT.Rows[0][convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureRegionFlds_TtlEN.DefaultValue = objDT.Rows[0][convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.Text = objDT.Rows[0][convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.GroupName = objDT.Rows[0][convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.ReleTabId = objDT.Rows[0][convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFlds_TtlEN.ReleFldId = objDT.Rows[0][convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFlds_TtlEN.FieldTypeId = objDT.Rows[0][convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvFeatureRegionFlds_TtlEN.FieldTypeName = objDT.Rows[0][convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvFeatureRegionFlds_TtlEN.ViewImplId = objDT.Rows[0][convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFlds_TtlEN.ViewImplName = objDT.Rows[0][convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFlds_TtlEN.CtlTypeId = objDT.Rows[0][convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvFeatureRegionFlds_TtlEN.CtlTypeName = objDT.Rows[0][convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.CtlCnName = objDT.Rows[0][convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objDT.Rows[0][convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvFeatureRegionFlds_TtlEN.Height = TransNullToInt(objDT.Rows[0][convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFlds_TtlEN.Width = TransNullToInt(objDT.Rows[0][convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFlds_TtlEN.SeqNum = TransNullToInt(objDT.Rows[0][convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFlds_TtlEN.CssClass = objDT.Rows[0][convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.ImageUrl = objDT.Rows[0][convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFlds_TtlEN.InUse = TransNullToBool(objDT.Rows[0][convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFeatureRegionFlds_TtlEN.UpdUser = objDT.Rows[0][convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureRegionFlds_TtlEN.UpdDate = objDT.Rows[0][convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureRegionFlds_TtlEN.Memo = objDT.Rows[0][convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFeatureRegionFlds_TtlEN.FldNum = TransNullToInt(objDT.Rows[0][convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFlds_TtlEN.RelaFldName = objDT.Rows[0][convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.RelaTabName = objDT.Rows[0][convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFlds_TtlEN.PrjId = objDT.Rows[0][convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetvFeatureRegionFlds_Ttl)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFeatureRegionFlds_TtlEN GetObjByViewFeatureId(string strViewFeatureId)
{
CheckPrimaryKey(strViewFeatureId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds_Ttl where ViewFeatureId = " + "'"+ strViewFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
 objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id(字段类型:char,字段长度:2,是否可空:False)
 objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFlds_TtlEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetObjByViewFeatureId)", objException.Message));
}
return objvFeatureRegionFlds_TtlEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFeatureRegionFlds_TtlEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds_Ttl where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN()
{
ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(), //界面功能Id
RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(), //区域Id
RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(), //区域名称
RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(), //区域类型Id
RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(), //区域类型名称
FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(), //功能名称
KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(), //关键字
TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(), //表功能Id
TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(), //表功能名
CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(), //检查表功能
FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(), //功能说明
ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(), //按钮名称
ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(), //按钮名称4Mvc
EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(), //事件函数名
ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(), //给值方式Id
ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(), //给值方式名
FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(), //函数名
DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(), //缺省值
Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(), //文本
GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(), //组名
ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(), //相关表Id
ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(), //相关字段Id
FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(), //字段类型Id
FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(), //字段类型名
ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(), //界面实现Id
ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(), //界面实现名
CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(), //控件类型号
CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(), //控件类型名
CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(), //控件类型中文名
CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(), //控件类型缩写
Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()), //高度
Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()), //宽
SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()), //字段序号
CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(), //样式表
ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(), //图片资源
InUse = TransNullToBool(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()), //是否在用
UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(), //说明
FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()), //字段数
RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(), //关系字段名
RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(), //相关表名
PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim() //工程ID
};
objvFeatureRegionFlds_TtlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureRegionFlds_TtlEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFeatureRegionFlds_TtlEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = TransNullToBool(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetObjByDataRowvFeatureRegionFlds_Ttl)", objException.Message));
}
objvFeatureRegionFlds_TtlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureRegionFlds_TtlEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFeatureRegionFlds_TtlEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN = new clsvFeatureRegionFlds_TtlEN();
try
{
objvFeatureRegionFlds_TtlEN.ViewFeatureId = objRow[convFeatureRegionFlds_Ttl.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFlds_TtlEN.RegionId = objRow[convFeatureRegionFlds_Ttl.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFlds_TtlEN.RegionName = objRow[convFeatureRegionFlds_Ttl.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFlds_TtlEN.RegionTypeId = objRow[convFeatureRegionFlds_Ttl.RegionTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFlds_TtlEN.RegionTypeName = objRow[convFeatureRegionFlds_Ttl.RegionTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFlds_TtlEN.FeatureId = objRow[convFeatureRegionFlds_Ttl.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFlds_TtlEN.FeatureName = objRow[convFeatureRegionFlds_Ttl.FeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFlds_TtlEN.KeyWords = objRow[convFeatureRegionFlds_Ttl.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFlds_TtlEN.TabFeatureId = objRow[convFeatureRegionFlds_Ttl.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFlds_TtlEN.TabFeatureName = objRow[convFeatureRegionFlds_Ttl.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFlds_TtlEN.CheckTabFeature = objRow[convFeatureRegionFlds_Ttl.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFlds_TtlEN.FeatureDescription = objRow[convFeatureRegionFlds_Ttl.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFlds_TtlEN.ButtonName = objRow[convFeatureRegionFlds_Ttl.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFlds_TtlEN.ButtonName4Mvc = objRow[convFeatureRegionFlds_Ttl.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFlds_TtlEN.EventFuncName = objRow[convFeatureRegionFlds_Ttl.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFlds_TtlEN.ValueGivingModeId = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFlds_TtlEN.ValueGivingModeName = objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFlds_TtlEN.FuncName = objRow[convFeatureRegionFlds_Ttl.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFlds_TtlEN.DefaultValue = objRow[convFeatureRegionFlds_Ttl.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFlds_TtlEN.Text = objRow[convFeatureRegionFlds_Ttl.Text].ToString().Trim(); //文本
objvFeatureRegionFlds_TtlEN.GroupName = objRow[convFeatureRegionFlds_Ttl.GroupName].ToString().Trim(); //组名
objvFeatureRegionFlds_TtlEN.ReleTabId = objRow[convFeatureRegionFlds_Ttl.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFlds_TtlEN.ReleFldId = objRow[convFeatureRegionFlds_Ttl.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFlds_TtlEN.FieldTypeId = objRow[convFeatureRegionFlds_Ttl.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFlds_TtlEN.FieldTypeName = objRow[convFeatureRegionFlds_Ttl.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFlds_TtlEN.ViewImplId = objRow[convFeatureRegionFlds_Ttl.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFlds_TtlEN.ViewImplName = objRow[convFeatureRegionFlds_Ttl.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFlds_TtlEN.CtlTypeId = objRow[convFeatureRegionFlds_Ttl.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFlds_TtlEN.CtlTypeName = objRow[convFeatureRegionFlds_Ttl.CtlTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFlds_TtlEN.CtlCnName = objRow[convFeatureRegionFlds_Ttl.CtlCnName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFlds_TtlEN.CtlTypeAbbr = objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFlds_TtlEN.Height = objRow[convFeatureRegionFlds_Ttl.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.Height].ToString().Trim()); //高度
objvFeatureRegionFlds_TtlEN.Width = objRow[convFeatureRegionFlds_Ttl.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.Width].ToString().Trim()); //宽
objvFeatureRegionFlds_TtlEN.SeqNum = objRow[convFeatureRegionFlds_Ttl.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFlds_TtlEN.CssClass = objRow[convFeatureRegionFlds_Ttl.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFlds_TtlEN.ImageUrl = objRow[convFeatureRegionFlds_Ttl.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFlds_TtlEN.InUse = TransNullToBool(objRow[convFeatureRegionFlds_Ttl.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFlds_TtlEN.UpdUser = objRow[convFeatureRegionFlds_Ttl.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFlds_TtlEN.UpdDate = objRow[convFeatureRegionFlds_Ttl.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFlds_TtlEN.Memo = objRow[convFeatureRegionFlds_Ttl.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.Memo].ToString().Trim(); //说明
objvFeatureRegionFlds_TtlEN.FldNum = objRow[convFeatureRegionFlds_Ttl.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds_Ttl.FldNum].ToString().Trim()); //字段数
objvFeatureRegionFlds_TtlEN.RelaFldName = objRow[convFeatureRegionFlds_Ttl.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFlds_TtlEN.RelaTabName = objRow[convFeatureRegionFlds_Ttl.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFlds_TtlEN.PrjId = objRow[convFeatureRegionFlds_Ttl.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds_Ttl.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFeatureRegionFlds_TtlDA: GetObjByDataRow)", objException.Message));
}
objvFeatureRegionFlds_TtlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureRegionFlds_TtlEN;
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
objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFeatureRegionFlds_TtlEN._CurrTabName, convFeatureRegionFlds_Ttl.ViewFeatureId, 8, "");
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
objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFeatureRegionFlds_TtlEN._CurrTabName, convFeatureRegionFlds_Ttl.ViewFeatureId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewFeatureId from vFeatureRegionFlds_Ttl where " + strCondition;
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
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewFeatureId from vFeatureRegionFlds_Ttl where " + strCondition;
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
 /// <param name = "strViewFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strViewFeatureId)
{
CheckPrimaryKey(strViewFeatureId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFeatureRegionFlds_Ttl", "ViewFeatureId = " + "'"+ strViewFeatureId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFeatureRegionFlds_TtlDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFeatureRegionFlds_Ttl", strCondition))
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
objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFeatureRegionFlds_Ttl");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFeatureRegionFlds_TtlENS">源对象</param>
 /// <param name = "objvFeatureRegionFlds_TtlENT">目标对象</param>
public void CopyTo(clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlENS, clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlENT)
{
objvFeatureRegionFlds_TtlENT.ViewFeatureId = objvFeatureRegionFlds_TtlENS.ViewFeatureId; //界面功能Id
objvFeatureRegionFlds_TtlENT.RegionId = objvFeatureRegionFlds_TtlENS.RegionId; //区域Id
objvFeatureRegionFlds_TtlENT.RegionName = objvFeatureRegionFlds_TtlENS.RegionName; //区域名称
objvFeatureRegionFlds_TtlENT.RegionTypeId = objvFeatureRegionFlds_TtlENS.RegionTypeId; //区域类型Id
objvFeatureRegionFlds_TtlENT.RegionTypeName = objvFeatureRegionFlds_TtlENS.RegionTypeName; //区域类型名称
objvFeatureRegionFlds_TtlENT.FeatureId = objvFeatureRegionFlds_TtlENS.FeatureId; //功能Id
objvFeatureRegionFlds_TtlENT.FeatureName = objvFeatureRegionFlds_TtlENS.FeatureName; //功能名称
objvFeatureRegionFlds_TtlENT.KeyWords = objvFeatureRegionFlds_TtlENS.KeyWords; //关键字
objvFeatureRegionFlds_TtlENT.TabFeatureId = objvFeatureRegionFlds_TtlENS.TabFeatureId; //表功能Id
objvFeatureRegionFlds_TtlENT.TabFeatureName = objvFeatureRegionFlds_TtlENS.TabFeatureName; //表功能名
objvFeatureRegionFlds_TtlENT.CheckTabFeature = objvFeatureRegionFlds_TtlENS.CheckTabFeature; //检查表功能
objvFeatureRegionFlds_TtlENT.FeatureDescription = objvFeatureRegionFlds_TtlENS.FeatureDescription; //功能说明
objvFeatureRegionFlds_TtlENT.ButtonName = objvFeatureRegionFlds_TtlENS.ButtonName; //按钮名称
objvFeatureRegionFlds_TtlENT.ButtonName4Mvc = objvFeatureRegionFlds_TtlENS.ButtonName4Mvc; //按钮名称4Mvc
objvFeatureRegionFlds_TtlENT.EventFuncName = objvFeatureRegionFlds_TtlENS.EventFuncName; //事件函数名
objvFeatureRegionFlds_TtlENT.ValueGivingModeId = objvFeatureRegionFlds_TtlENS.ValueGivingModeId; //给值方式Id
objvFeatureRegionFlds_TtlENT.ValueGivingModeName = objvFeatureRegionFlds_TtlENS.ValueGivingModeName; //给值方式名
objvFeatureRegionFlds_TtlENT.FuncName = objvFeatureRegionFlds_TtlENS.FuncName; //函数名
objvFeatureRegionFlds_TtlENT.DefaultValue = objvFeatureRegionFlds_TtlENS.DefaultValue; //缺省值
objvFeatureRegionFlds_TtlENT.Text = objvFeatureRegionFlds_TtlENS.Text; //文本
objvFeatureRegionFlds_TtlENT.GroupName = objvFeatureRegionFlds_TtlENS.GroupName; //组名
objvFeatureRegionFlds_TtlENT.ReleTabId = objvFeatureRegionFlds_TtlENS.ReleTabId; //相关表Id
objvFeatureRegionFlds_TtlENT.ReleFldId = objvFeatureRegionFlds_TtlENS.ReleFldId; //相关字段Id
objvFeatureRegionFlds_TtlENT.FieldTypeId = objvFeatureRegionFlds_TtlENS.FieldTypeId; //字段类型Id
objvFeatureRegionFlds_TtlENT.FieldTypeName = objvFeatureRegionFlds_TtlENS.FieldTypeName; //字段类型名
objvFeatureRegionFlds_TtlENT.ViewImplId = objvFeatureRegionFlds_TtlENS.ViewImplId; //界面实现Id
objvFeatureRegionFlds_TtlENT.ViewImplName = objvFeatureRegionFlds_TtlENS.ViewImplName; //界面实现名
objvFeatureRegionFlds_TtlENT.CtlTypeId = objvFeatureRegionFlds_TtlENS.CtlTypeId; //控件类型号
objvFeatureRegionFlds_TtlENT.CtlTypeName = objvFeatureRegionFlds_TtlENS.CtlTypeName; //控件类型名
objvFeatureRegionFlds_TtlENT.CtlCnName = objvFeatureRegionFlds_TtlENS.CtlCnName; //控件类型中文名
objvFeatureRegionFlds_TtlENT.CtlTypeAbbr = objvFeatureRegionFlds_TtlENS.CtlTypeAbbr; //控件类型缩写
objvFeatureRegionFlds_TtlENT.Height = objvFeatureRegionFlds_TtlENS.Height; //高度
objvFeatureRegionFlds_TtlENT.Width = objvFeatureRegionFlds_TtlENS.Width; //宽
objvFeatureRegionFlds_TtlENT.SeqNum = objvFeatureRegionFlds_TtlENS.SeqNum; //字段序号
objvFeatureRegionFlds_TtlENT.CssClass = objvFeatureRegionFlds_TtlENS.CssClass; //样式表
objvFeatureRegionFlds_TtlENT.ImageUrl = objvFeatureRegionFlds_TtlENS.ImageUrl; //图片资源
objvFeatureRegionFlds_TtlENT.InUse = objvFeatureRegionFlds_TtlENS.InUse; //是否在用
objvFeatureRegionFlds_TtlENT.UpdUser = objvFeatureRegionFlds_TtlENS.UpdUser; //修改者
objvFeatureRegionFlds_TtlENT.UpdDate = objvFeatureRegionFlds_TtlENS.UpdDate; //修改日期
objvFeatureRegionFlds_TtlENT.Memo = objvFeatureRegionFlds_TtlENS.Memo; //说明
objvFeatureRegionFlds_TtlENT.FldNum = objvFeatureRegionFlds_TtlENS.FldNum; //字段数
objvFeatureRegionFlds_TtlENT.RelaFldName = objvFeatureRegionFlds_TtlENS.RelaFldName; //关系字段名
objvFeatureRegionFlds_TtlENT.RelaTabName = objvFeatureRegionFlds_TtlENS.RelaTabName; //相关表名
objvFeatureRegionFlds_TtlENT.PrjId = objvFeatureRegionFlds_TtlENS.PrjId; //工程ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFeatureRegionFlds_TtlEN objvFeatureRegionFlds_TtlEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.ViewFeatureId, 8, convFeatureRegionFlds_Ttl.ViewFeatureId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.RegionId, 10, convFeatureRegionFlds_Ttl.RegionId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.RegionName, 50, convFeatureRegionFlds_Ttl.RegionName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.RegionTypeId, 4, convFeatureRegionFlds_Ttl.RegionTypeId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.RegionTypeName, 30, convFeatureRegionFlds_Ttl.RegionTypeName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.FeatureId, 4, convFeatureRegionFlds_Ttl.FeatureId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.FeatureName, 100, convFeatureRegionFlds_Ttl.FeatureName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.KeyWords, 500, convFeatureRegionFlds_Ttl.KeyWords);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.TabFeatureId, 8, convFeatureRegionFlds_Ttl.TabFeatureId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.TabFeatureName, 100, convFeatureRegionFlds_Ttl.TabFeatureName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.CheckTabFeature, 50, convFeatureRegionFlds_Ttl.CheckTabFeature);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.FeatureDescription, 4000, convFeatureRegionFlds_Ttl.FeatureDescription);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.ButtonName, 30, convFeatureRegionFlds_Ttl.ButtonName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.ButtonName4Mvc, 30, convFeatureRegionFlds_Ttl.ButtonName4Mvc);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.EventFuncName, 50, convFeatureRegionFlds_Ttl.EventFuncName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.ValueGivingModeId, 2, convFeatureRegionFlds_Ttl.ValueGivingModeId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.ValueGivingModeName, 50, convFeatureRegionFlds_Ttl.ValueGivingModeName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.FuncName, 100, convFeatureRegionFlds_Ttl.FuncName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.DefaultValue, 50, convFeatureRegionFlds_Ttl.DefaultValue);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.Text, 30, convFeatureRegionFlds_Ttl.Text);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.GroupName, 30, convFeatureRegionFlds_Ttl.GroupName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.ReleTabId, 8, convFeatureRegionFlds_Ttl.ReleTabId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.ReleFldId, 8, convFeatureRegionFlds_Ttl.ReleFldId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.FieldTypeId, 2, convFeatureRegionFlds_Ttl.FieldTypeId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.FieldTypeName, 30, convFeatureRegionFlds_Ttl.FieldTypeName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.ViewImplId, 4, convFeatureRegionFlds_Ttl.ViewImplId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.ViewImplName, 50, convFeatureRegionFlds_Ttl.ViewImplName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.CtlTypeId, 2, convFeatureRegionFlds_Ttl.CtlTypeId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.CtlTypeName, 30, convFeatureRegionFlds_Ttl.CtlTypeName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.CtlCnName, 50, convFeatureRegionFlds_Ttl.CtlCnName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.CtlTypeAbbr, 5, convFeatureRegionFlds_Ttl.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.CssClass, 50, convFeatureRegionFlds_Ttl.CssClass);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.ImageUrl, 100, convFeatureRegionFlds_Ttl.ImageUrl);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.UpdUser, 20, convFeatureRegionFlds_Ttl.UpdUser);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.UpdDate, 20, convFeatureRegionFlds_Ttl.UpdDate);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.Memo, 1000, convFeatureRegionFlds_Ttl.Memo);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.RelaFldName, 50, convFeatureRegionFlds_Ttl.RelaFldName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.RelaTabName, 100, convFeatureRegionFlds_Ttl.RelaTabName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFlds_TtlEN.PrjId, 4, convFeatureRegionFlds_Ttl.PrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.ViewFeatureId, convFeatureRegionFlds_Ttl.ViewFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.RegionId, convFeatureRegionFlds_Ttl.RegionId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.RegionName, convFeatureRegionFlds_Ttl.RegionName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.RegionTypeId, convFeatureRegionFlds_Ttl.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.RegionTypeName, convFeatureRegionFlds_Ttl.RegionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.FeatureId, convFeatureRegionFlds_Ttl.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.FeatureName, convFeatureRegionFlds_Ttl.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.KeyWords, convFeatureRegionFlds_Ttl.KeyWords);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.TabFeatureId, convFeatureRegionFlds_Ttl.TabFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.TabFeatureName, convFeatureRegionFlds_Ttl.TabFeatureName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.CheckTabFeature, convFeatureRegionFlds_Ttl.CheckTabFeature);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.FeatureDescription, convFeatureRegionFlds_Ttl.FeatureDescription);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.ButtonName, convFeatureRegionFlds_Ttl.ButtonName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.ButtonName4Mvc, convFeatureRegionFlds_Ttl.ButtonName4Mvc);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.EventFuncName, convFeatureRegionFlds_Ttl.EventFuncName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.ValueGivingModeId, convFeatureRegionFlds_Ttl.ValueGivingModeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.ValueGivingModeName, convFeatureRegionFlds_Ttl.ValueGivingModeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.FuncName, convFeatureRegionFlds_Ttl.FuncName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.DefaultValue, convFeatureRegionFlds_Ttl.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.Text, convFeatureRegionFlds_Ttl.Text);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.GroupName, convFeatureRegionFlds_Ttl.GroupName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.ReleTabId, convFeatureRegionFlds_Ttl.ReleTabId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.ReleFldId, convFeatureRegionFlds_Ttl.ReleFldId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.FieldTypeId, convFeatureRegionFlds_Ttl.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.FieldTypeName, convFeatureRegionFlds_Ttl.FieldTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.ViewImplId, convFeatureRegionFlds_Ttl.ViewImplId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.ViewImplName, convFeatureRegionFlds_Ttl.ViewImplName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.CtlTypeId, convFeatureRegionFlds_Ttl.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.CtlTypeName, convFeatureRegionFlds_Ttl.CtlTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.CtlCnName, convFeatureRegionFlds_Ttl.CtlCnName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.CtlTypeAbbr, convFeatureRegionFlds_Ttl.CtlTypeAbbr);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.CssClass, convFeatureRegionFlds_Ttl.CssClass);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.ImageUrl, convFeatureRegionFlds_Ttl.ImageUrl);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.UpdUser, convFeatureRegionFlds_Ttl.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.UpdDate, convFeatureRegionFlds_Ttl.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.Memo, convFeatureRegionFlds_Ttl.Memo);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.RelaFldName, convFeatureRegionFlds_Ttl.RelaFldName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.RelaTabName, convFeatureRegionFlds_Ttl.RelaTabName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFlds_TtlEN.PrjId, convFeatureRegionFlds_Ttl.PrjId);
//检查外键字段长度
 objvFeatureRegionFlds_TtlEN._IsCheckProperty = true;
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
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
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
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
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
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFeatureRegionFlds_TtlEN._CurrTabName);
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
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFeatureRegionFlds_TtlEN._CurrTabName, strCondition);
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
 objSQL = clsvFeatureRegionFlds_TtlDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}