
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureRegionFldsDA
 表名:vFeatureRegionFlds(00050197)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:49
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
 /// v功能区域字段(vFeatureRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFeatureRegionFldsDA : clsCommBase4DA
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
 return clsvFeatureRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFeatureRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFeatureRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFeatureRegionFldsEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vFeatureRegionFlds中,检查关键字,长度不正确!(clsvFeatureRegionFldsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewFeatureId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFeatureRegionFlds中,关键字不能为空 或 null!(clsvFeatureRegionFldsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFeatureRegionFldsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFeatureRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA: GetDataTable_vFeatureRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFeatureRegionFlds.* from vFeatureRegionFlds Left Join {1} on {2} where {3} and vFeatureRegionFlds.ViewFeatureId not in (Select top {5} vFeatureRegionFlds.ViewFeatureId from vFeatureRegionFlds Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds where {1} and ViewFeatureId not in (Select top {2} ViewFeatureId from vFeatureRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds where {1} and ViewFeatureId not in (Select top {3} ViewFeatureId from vFeatureRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFeatureRegionFlds.* from vFeatureRegionFlds Left Join {1} on {2} where {3} and vFeatureRegionFlds.ViewFeatureId not in (Select top {5} vFeatureRegionFlds.ViewFeatureId from vFeatureRegionFlds Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds where {1} and ViewFeatureId not in (Select top {2} ViewFeatureId from vFeatureRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFeatureRegionFlds where {1} and ViewFeatureId not in (Select top {3} ViewFeatureId from vFeatureRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFeatureRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = TransNullToBool(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFeatureRegionFldsDA: GetObjLst)", objException.Message));
}
objvFeatureRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFeatureRegionFldsEN);
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
public List<clsvFeatureRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFeatureRegionFldsEN> arrObjLst = new List<clsvFeatureRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = TransNullToBool(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFeatureRegionFldsDA: GetObjLst)", objException.Message));
}
objvFeatureRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFeatureRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFeatureRegionFlds(ref clsvFeatureRegionFldsEN objvFeatureRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds where ViewFeatureId = " + "'"+ objvFeatureRegionFldsEN.ViewFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFeatureRegionFldsEN.ViewFeatureId = objDT.Rows[0][convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvFeatureRegionFldsEN.RegionId = objDT.Rows[0][convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvFeatureRegionFldsEN.RegionName = objDT.Rows[0][convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFldsEN.RegionTypeId = objDT.Rows[0][convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFldsEN.RegionTypeName = objDT.Rows[0][convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.RegionTypeSimName = objDT.Rows[0][convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名(字段类型:varchar,字段长度:10,是否可空:True)
 objvFeatureRegionFldsEN.FeatureId = objDT.Rows[0][convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFldsEN.FeatureName = objDT.Rows[0][convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureRegionFldsEN.KeyWords = objDT.Rows[0][convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvFeatureRegionFldsEN.TabFeatureId = objDT.Rows[0][convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFldsEN.TabFeatureName = objDT.Rows[0][convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFldsEN.CheckTabFeature = objDT.Rows[0][convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.FeatureDescription = objDT.Rows[0][convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvFeatureRegionFldsEN.ButtonName = objDT.Rows[0][convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.ButtonName4Mvc = objDT.Rows[0][convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.EventFuncName = objDT.Rows[0][convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.ValueGivingModeId = objDT.Rows[0][convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id(字段类型:char,字段长度:2,是否可空:False)
 objvFeatureRegionFldsEN.ValueGivingModeName = objDT.Rows[0][convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.FuncName = objDT.Rows[0][convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureRegionFldsEN.DefaultValue = objDT.Rows[0][convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.KeyIdGetModeId = objDT.Rows[0][convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id(字段类型:char,字段长度:4,是否可空:True)
 objvFeatureRegionFldsEN.Text = objDT.Rows[0][convFeatureRegionFlds.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.GroupName = objDT.Rows[0][convFeatureRegionFlds.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.ReleTabId = objDT.Rows[0][convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFldsEN.ReleFldId = objDT.Rows[0][convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFldsEN.FieldTypeId = objDT.Rows[0][convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvFeatureRegionFldsEN.FieldTypeName = objDT.Rows[0][convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvFeatureRegionFldsEN.ViewImplId = objDT.Rows[0][convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFldsEN.ViewImplName = objDT.Rows[0][convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFldsEN.CtlTypeId = objDT.Rows[0][convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvFeatureRegionFldsEN.CtlTypeName = objDT.Rows[0][convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.CtlCnName = objDT.Rows[0][convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFldsEN.CtlTypeAbbr = objDT.Rows[0][convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvFeatureRegionFldsEN.Height = TransNullToInt(objDT.Rows[0][convFeatureRegionFlds.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFldsEN.Width = TransNullToInt(objDT.Rows[0][convFeatureRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFldsEN.CssClass = objDT.Rows[0][convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.ImageUrl = objDT.Rows[0][convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFeatureRegionFldsEN.UpdUser = objDT.Rows[0][convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureRegionFldsEN.UpdDate = objDT.Rows[0][convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureRegionFldsEN.Memo = objDT.Rows[0][convFeatureRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFeatureRegionFldsEN.RelaFldName = objDT.Rows[0][convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.RelaTabName = objDT.Rows[0][convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFldsEN.PrjId = objDT.Rows[0][convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFeatureRegionFldsDA: GetvFeatureRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFeatureRegionFldsEN GetObjByViewFeatureId(string strViewFeatureId)
{
CheckPrimaryKey(strViewFeatureId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds where ViewFeatureId = " + "'"+ strViewFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
 objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名(字段类型:varchar,字段长度:10,是否可空:True)
 objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id(字段类型:char,字段长度:2,是否可空:False)
 objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id(字段类型:char,字段长度:4,是否可空:True)
 objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id(字段类型:char,字段长度:8,是否可空:True)
 objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id(字段类型:char,字段长度:4,是否可空:False)
 objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFeatureRegionFldsDA: GetObjByViewFeatureId)", objException.Message));
}
return objvFeatureRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFeatureRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vFeatureRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN()
{
ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(), //界面功能Id
RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(), //区域Id
RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(), //区域名称
RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(), //区域类型Id
RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(), //区域类型名称
RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(), //区域类型简名
FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(), //功能名称
KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(), //关键字
TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(), //表功能Id
TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(), //表功能名
CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(), //检查表功能
FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(), //功能说明
ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(), //按钮名称
ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(), //按钮名称4Mvc
EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(), //事件函数名
ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(), //给值方式Id
ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(), //给值方式名
FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(), //函数名
DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(), //缺省值
KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(), //GC关键字获取方式Id
Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(), //文本
GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(), //组名
ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(), //相关表Id
ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(), //相关字段Id
FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(), //字段类型Id
FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(), //字段类型名
ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(), //界面实现Id
ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(), //界面实现名
CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(), //控件类型号
CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(), //控件类型名
CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(), //控件类型中文名
CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(), //控件类型缩写
Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.Height].ToString().Trim()), //高度
Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.Width].ToString().Trim()), //宽
SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()), //字段序号
CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(), //样式表
ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(), //图片资源
InUse = TransNullToBool(objRow[convFeatureRegionFlds.InUse].ToString().Trim()), //是否在用
UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(), //说明
RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(), //关系字段名
RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(), //相关表名
PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim() //工程ID
};
objvFeatureRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFeatureRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFeatureRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = TransNullToBool(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFeatureRegionFldsDA: GetObjByDataRowvFeatureRegionFlds)", objException.Message));
}
objvFeatureRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFeatureRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFeatureRegionFldsEN objvFeatureRegionFldsEN = new clsvFeatureRegionFldsEN();
try
{
objvFeatureRegionFldsEN.ViewFeatureId = objRow[convFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvFeatureRegionFldsEN.RegionId = objRow[convFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objvFeatureRegionFldsEN.RegionName = objRow[convFeatureRegionFlds.RegionName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionName].ToString().Trim(); //区域名称
objvFeatureRegionFldsEN.RegionTypeId = objRow[convFeatureRegionFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvFeatureRegionFldsEN.RegionTypeName = objRow[convFeatureRegionFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvFeatureRegionFldsEN.RegionTypeSimName = objRow[convFeatureRegionFlds.RegionTypeSimName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RegionTypeSimName].ToString().Trim(); //区域类型简名
objvFeatureRegionFldsEN.FeatureId = objRow[convFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objvFeatureRegionFldsEN.FeatureName = objRow[convFeatureRegionFlds.FeatureName].ToString().Trim(); //功能名称
objvFeatureRegionFldsEN.KeyWords = objRow[convFeatureRegionFlds.KeyWords] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyWords].ToString().Trim(); //关键字
objvFeatureRegionFldsEN.TabFeatureId = objRow[convFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvFeatureRegionFldsEN.TabFeatureName = objRow[convFeatureRegionFlds.TabFeatureName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.TabFeatureName].ToString().Trim(); //表功能名
objvFeatureRegionFldsEN.CheckTabFeature = objRow[convFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objvFeatureRegionFldsEN.FeatureDescription = objRow[convFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureRegionFldsEN.ButtonName = objRow[convFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objvFeatureRegionFldsEN.ButtonName4Mvc = objRow[convFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objvFeatureRegionFldsEN.EventFuncName = objRow[convFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureRegionFldsEN.ValueGivingModeId = objRow[convFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvFeatureRegionFldsEN.ValueGivingModeName = objRow[convFeatureRegionFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvFeatureRegionFldsEN.FuncName = objRow[convFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objvFeatureRegionFldsEN.DefaultValue = objRow[convFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[convFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objvFeatureRegionFldsEN.KeyIdGetModeId = objRow[convFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objvFeatureRegionFldsEN.Text = objRow[convFeatureRegionFlds.Text].ToString().Trim(); //文本
objvFeatureRegionFldsEN.GroupName = objRow[convFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objvFeatureRegionFldsEN.ReleTabId = objRow[convFeatureRegionFlds.ReleTabId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objvFeatureRegionFldsEN.ReleFldId = objRow[convFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvFeatureRegionFldsEN.FieldTypeId = objRow[convFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureRegionFldsEN.FieldTypeName = objRow[convFeatureRegionFlds.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureRegionFldsEN.ViewImplId = objRow[convFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureRegionFldsEN.ViewImplName = objRow[convFeatureRegionFlds.ViewImplName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureRegionFldsEN.CtlTypeId = objRow[convFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvFeatureRegionFldsEN.CtlTypeName = objRow[convFeatureRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvFeatureRegionFldsEN.CtlCnName = objRow[convFeatureRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvFeatureRegionFldsEN.CtlTypeAbbr = objRow[convFeatureRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvFeatureRegionFldsEN.Height = objRow[convFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.Height].ToString().Trim()); //高度
objvFeatureRegionFldsEN.Width = objRow[convFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.Width].ToString().Trim()); //宽
objvFeatureRegionFldsEN.SeqNum = objRow[convFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvFeatureRegionFldsEN.CssClass = objRow[convFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[convFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objvFeatureRegionFldsEN.ImageUrl = objRow[convFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[convFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objvFeatureRegionFldsEN.InUse = TransNullToBool(objRow[convFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objvFeatureRegionFldsEN.UpdUser = objRow[convFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objvFeatureRegionFldsEN.UpdDate = objRow[convFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvFeatureRegionFldsEN.Memo = objRow[convFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[convFeatureRegionFlds.Memo].ToString().Trim(); //说明
objvFeatureRegionFldsEN.RelaFldName = objRow[convFeatureRegionFlds.RelaFldName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaFldName].ToString().Trim(); //关系字段名
objvFeatureRegionFldsEN.RelaTabName = objRow[convFeatureRegionFlds.RelaTabName] == DBNull.Value ? null : objRow[convFeatureRegionFlds.RelaTabName].ToString().Trim(); //相关表名
objvFeatureRegionFldsEN.PrjId = objRow[convFeatureRegionFlds.PrjId] == DBNull.Value ? null : objRow[convFeatureRegionFlds.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFeatureRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objvFeatureRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFeatureRegionFldsEN;
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
objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFeatureRegionFldsEN._CurrTabName, convFeatureRegionFlds.ViewFeatureId, 8, "");
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
objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFeatureRegionFldsEN._CurrTabName, convFeatureRegionFlds.ViewFeatureId, 8, strPrefix);
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
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewFeatureId from vFeatureRegionFlds where " + strCondition;
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
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewFeatureId from vFeatureRegionFlds where " + strCondition;
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
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFeatureRegionFlds", "ViewFeatureId = " + "'"+ strViewFeatureId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFeatureRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFeatureRegionFlds", strCondition))
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
objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFeatureRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFeatureRegionFldsENS">源对象</param>
 /// <param name = "objvFeatureRegionFldsENT">目标对象</param>
public void CopyTo(clsvFeatureRegionFldsEN objvFeatureRegionFldsENS, clsvFeatureRegionFldsEN objvFeatureRegionFldsENT)
{
objvFeatureRegionFldsENT.ViewFeatureId = objvFeatureRegionFldsENS.ViewFeatureId; //界面功能Id
objvFeatureRegionFldsENT.RegionId = objvFeatureRegionFldsENS.RegionId; //区域Id
objvFeatureRegionFldsENT.RegionName = objvFeatureRegionFldsENS.RegionName; //区域名称
objvFeatureRegionFldsENT.RegionTypeId = objvFeatureRegionFldsENS.RegionTypeId; //区域类型Id
objvFeatureRegionFldsENT.RegionTypeName = objvFeatureRegionFldsENS.RegionTypeName; //区域类型名称
objvFeatureRegionFldsENT.RegionTypeSimName = objvFeatureRegionFldsENS.RegionTypeSimName; //区域类型简名
objvFeatureRegionFldsENT.FeatureId = objvFeatureRegionFldsENS.FeatureId; //功能Id
objvFeatureRegionFldsENT.FeatureName = objvFeatureRegionFldsENS.FeatureName; //功能名称
objvFeatureRegionFldsENT.KeyWords = objvFeatureRegionFldsENS.KeyWords; //关键字
objvFeatureRegionFldsENT.TabFeatureId = objvFeatureRegionFldsENS.TabFeatureId; //表功能Id
objvFeatureRegionFldsENT.TabFeatureName = objvFeatureRegionFldsENS.TabFeatureName; //表功能名
objvFeatureRegionFldsENT.CheckTabFeature = objvFeatureRegionFldsENS.CheckTabFeature; //检查表功能
objvFeatureRegionFldsENT.FeatureDescription = objvFeatureRegionFldsENS.FeatureDescription; //功能说明
objvFeatureRegionFldsENT.ButtonName = objvFeatureRegionFldsENS.ButtonName; //按钮名称
objvFeatureRegionFldsENT.ButtonName4Mvc = objvFeatureRegionFldsENS.ButtonName4Mvc; //按钮名称4Mvc
objvFeatureRegionFldsENT.EventFuncName = objvFeatureRegionFldsENS.EventFuncName; //事件函数名
objvFeatureRegionFldsENT.ValueGivingModeId = objvFeatureRegionFldsENS.ValueGivingModeId; //给值方式Id
objvFeatureRegionFldsENT.ValueGivingModeName = objvFeatureRegionFldsENS.ValueGivingModeName; //给值方式名
objvFeatureRegionFldsENT.FuncName = objvFeatureRegionFldsENS.FuncName; //函数名
objvFeatureRegionFldsENT.DefaultValue = objvFeatureRegionFldsENS.DefaultValue; //缺省值
objvFeatureRegionFldsENT.KeyIdGetModeId = objvFeatureRegionFldsENS.KeyIdGetModeId; //GC关键字获取方式Id
objvFeatureRegionFldsENT.Text = objvFeatureRegionFldsENS.Text; //文本
objvFeatureRegionFldsENT.GroupName = objvFeatureRegionFldsENS.GroupName; //组名
objvFeatureRegionFldsENT.ReleTabId = objvFeatureRegionFldsENS.ReleTabId; //相关表Id
objvFeatureRegionFldsENT.ReleFldId = objvFeatureRegionFldsENS.ReleFldId; //相关字段Id
objvFeatureRegionFldsENT.FieldTypeId = objvFeatureRegionFldsENS.FieldTypeId; //字段类型Id
objvFeatureRegionFldsENT.FieldTypeName = objvFeatureRegionFldsENS.FieldTypeName; //字段类型名
objvFeatureRegionFldsENT.ViewImplId = objvFeatureRegionFldsENS.ViewImplId; //界面实现Id
objvFeatureRegionFldsENT.ViewImplName = objvFeatureRegionFldsENS.ViewImplName; //界面实现名
objvFeatureRegionFldsENT.CtlTypeId = objvFeatureRegionFldsENS.CtlTypeId; //控件类型号
objvFeatureRegionFldsENT.CtlTypeName = objvFeatureRegionFldsENS.CtlTypeName; //控件类型名
objvFeatureRegionFldsENT.CtlCnName = objvFeatureRegionFldsENS.CtlCnName; //控件类型中文名
objvFeatureRegionFldsENT.CtlTypeAbbr = objvFeatureRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvFeatureRegionFldsENT.Height = objvFeatureRegionFldsENS.Height; //高度
objvFeatureRegionFldsENT.Width = objvFeatureRegionFldsENS.Width; //宽
objvFeatureRegionFldsENT.SeqNum = objvFeatureRegionFldsENS.SeqNum; //字段序号
objvFeatureRegionFldsENT.CssClass = objvFeatureRegionFldsENS.CssClass; //样式表
objvFeatureRegionFldsENT.ImageUrl = objvFeatureRegionFldsENS.ImageUrl; //图片资源
objvFeatureRegionFldsENT.InUse = objvFeatureRegionFldsENS.InUse; //是否在用
objvFeatureRegionFldsENT.UpdUser = objvFeatureRegionFldsENS.UpdUser; //修改者
objvFeatureRegionFldsENT.UpdDate = objvFeatureRegionFldsENS.UpdDate; //修改日期
objvFeatureRegionFldsENT.Memo = objvFeatureRegionFldsENS.Memo; //说明
objvFeatureRegionFldsENT.RelaFldName = objvFeatureRegionFldsENS.RelaFldName; //关系字段名
objvFeatureRegionFldsENT.RelaTabName = objvFeatureRegionFldsENS.RelaTabName; //相关表名
objvFeatureRegionFldsENT.PrjId = objvFeatureRegionFldsENS.PrjId; //工程ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFeatureRegionFldsEN objvFeatureRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.ViewFeatureId, 8, convFeatureRegionFlds.ViewFeatureId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.RegionId, 10, convFeatureRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.RegionName, 50, convFeatureRegionFlds.RegionName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.RegionTypeId, 4, convFeatureRegionFlds.RegionTypeId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.RegionTypeName, 30, convFeatureRegionFlds.RegionTypeName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.RegionTypeSimName, 10, convFeatureRegionFlds.RegionTypeSimName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.FeatureId, 4, convFeatureRegionFlds.FeatureId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.FeatureName, 100, convFeatureRegionFlds.FeatureName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.KeyWords, 500, convFeatureRegionFlds.KeyWords);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.TabFeatureId, 8, convFeatureRegionFlds.TabFeatureId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.TabFeatureName, 100, convFeatureRegionFlds.TabFeatureName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.CheckTabFeature, 50, convFeatureRegionFlds.CheckTabFeature);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.FeatureDescription, 4000, convFeatureRegionFlds.FeatureDescription);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.ButtonName, 30, convFeatureRegionFlds.ButtonName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.ButtonName4Mvc, 30, convFeatureRegionFlds.ButtonName4Mvc);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.EventFuncName, 50, convFeatureRegionFlds.EventFuncName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.ValueGivingModeId, 2, convFeatureRegionFlds.ValueGivingModeId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.ValueGivingModeName, 50, convFeatureRegionFlds.ValueGivingModeName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.FuncName, 100, convFeatureRegionFlds.FuncName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.DefaultValue, 50, convFeatureRegionFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.KeyIdGetModeId, 4, convFeatureRegionFlds.KeyIdGetModeId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.Text, 30, convFeatureRegionFlds.Text);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.GroupName, 30, convFeatureRegionFlds.GroupName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.ReleTabId, 8, convFeatureRegionFlds.ReleTabId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.ReleFldId, 8, convFeatureRegionFlds.ReleFldId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.FieldTypeId, 2, convFeatureRegionFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.FieldTypeName, 30, convFeatureRegionFlds.FieldTypeName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.ViewImplId, 4, convFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.ViewImplName, 50, convFeatureRegionFlds.ViewImplName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.CtlTypeId, 2, convFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.CtlTypeName, 30, convFeatureRegionFlds.CtlTypeName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.CtlCnName, 50, convFeatureRegionFlds.CtlCnName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.CtlTypeAbbr, 5, convFeatureRegionFlds.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.CssClass, 50, convFeatureRegionFlds.CssClass);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.ImageUrl, 100, convFeatureRegionFlds.ImageUrl);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.UpdUser, 20, convFeatureRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.UpdDate, 20, convFeatureRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.Memo, 1000, convFeatureRegionFlds.Memo);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.RelaFldName, 50, convFeatureRegionFlds.RelaFldName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.RelaTabName, 100, convFeatureRegionFlds.RelaTabName);
clsCheckSql.CheckFieldLen(objvFeatureRegionFldsEN.PrjId, 4, convFeatureRegionFlds.PrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.ViewFeatureId, convFeatureRegionFlds.ViewFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.RegionId, convFeatureRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.RegionName, convFeatureRegionFlds.RegionName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.RegionTypeId, convFeatureRegionFlds.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.RegionTypeName, convFeatureRegionFlds.RegionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.RegionTypeSimName, convFeatureRegionFlds.RegionTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.FeatureId, convFeatureRegionFlds.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.FeatureName, convFeatureRegionFlds.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.KeyWords, convFeatureRegionFlds.KeyWords);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.TabFeatureId, convFeatureRegionFlds.TabFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.TabFeatureName, convFeatureRegionFlds.TabFeatureName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.CheckTabFeature, convFeatureRegionFlds.CheckTabFeature);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.FeatureDescription, convFeatureRegionFlds.FeatureDescription);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.ButtonName, convFeatureRegionFlds.ButtonName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.ButtonName4Mvc, convFeatureRegionFlds.ButtonName4Mvc);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.EventFuncName, convFeatureRegionFlds.EventFuncName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.ValueGivingModeId, convFeatureRegionFlds.ValueGivingModeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.ValueGivingModeName, convFeatureRegionFlds.ValueGivingModeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.FuncName, convFeatureRegionFlds.FuncName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.DefaultValue, convFeatureRegionFlds.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.KeyIdGetModeId, convFeatureRegionFlds.KeyIdGetModeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.Text, convFeatureRegionFlds.Text);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.GroupName, convFeatureRegionFlds.GroupName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.ReleTabId, convFeatureRegionFlds.ReleTabId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.ReleFldId, convFeatureRegionFlds.ReleFldId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.FieldTypeId, convFeatureRegionFlds.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.FieldTypeName, convFeatureRegionFlds.FieldTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.ViewImplId, convFeatureRegionFlds.ViewImplId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.ViewImplName, convFeatureRegionFlds.ViewImplName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.CtlTypeId, convFeatureRegionFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.CtlTypeName, convFeatureRegionFlds.CtlTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.CtlCnName, convFeatureRegionFlds.CtlCnName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.CtlTypeAbbr, convFeatureRegionFlds.CtlTypeAbbr);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.CssClass, convFeatureRegionFlds.CssClass);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.ImageUrl, convFeatureRegionFlds.ImageUrl);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.UpdUser, convFeatureRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.UpdDate, convFeatureRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.Memo, convFeatureRegionFlds.Memo);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.RelaFldName, convFeatureRegionFlds.RelaFldName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.RelaTabName, convFeatureRegionFlds.RelaTabName);
clsCheckSql.CheckSqlInjection4Field(objvFeatureRegionFldsEN.PrjId, convFeatureRegionFlds.PrjId);
//检查外键字段长度
 objvFeatureRegionFldsEN._IsCheckProperty = true;
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
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFeatureRegionFldsEN._CurrTabName);
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
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFeatureRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsvFeatureRegionFldsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}