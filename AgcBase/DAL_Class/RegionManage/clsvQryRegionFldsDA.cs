
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQryRegionFldsDA
 表名:vQryRegionFlds(00050151)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:57
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
 /// v查询区域字段(vQryRegionFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQryRegionFldsDA : clsCommBase4DA
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
 return clsvQryRegionFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQryRegionFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQryRegionFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQryRegionFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQryRegionFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vQryRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQryRegionFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA: GetDataTable_vQryRegionFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vQryRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vQryRegionFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQryRegionFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQryRegionFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQryRegionFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQryRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQryRegionFlds.* from vQryRegionFlds Left Join {1} on {2} where {3} and vQryRegionFlds.mId not in (Select top {5} vQryRegionFlds.mId from vQryRegionFlds Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQryRegionFlds where {1} and mId not in (Select top {2} mId from vQryRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQryRegionFlds where {1} and mId not in (Select top {3} mId from vQryRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQryRegionFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQryRegionFlds.* from vQryRegionFlds Left Join {1} on {2} where {3} and vQryRegionFlds.mId not in (Select top {5} vQryRegionFlds.mId from vQryRegionFlds Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQryRegionFlds where {1} and mId not in (Select top {2} mId from vQryRegionFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQryRegionFlds where {1} and mId not in (Select top {3} mId from vQryRegionFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQryRegionFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA:GetObjLst)", objException.Message));
}
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vQryRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = TransNullToInt(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = TransNullToBool(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQryRegionFldsDA: GetObjLst)", objException.Message));
}
objvQryRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQryRegionFldsEN);
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
public List<clsvQryRegionFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQryRegionFldsEN> arrObjLst = new List<clsvQryRegionFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = TransNullToInt(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = TransNullToBool(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQryRegionFldsDA: GetObjLst)", objException.Message));
}
objvQryRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQryRegionFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQryRegionFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQryRegionFlds(ref clsvQryRegionFldsEN objvQryRegionFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vQryRegionFlds where mId = " + ""+ objvQryRegionFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQryRegionFldsEN.mId = TransNullToInt(objDT.Rows[0][convQryRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvQryRegionFldsEN.RegionId = objDT.Rows[0][convQryRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvQryRegionFldsEN.RegionName = objDT.Rows[0][convQryRegionFlds.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQryRegionFldsEN.TabId = objDT.Rows[0][convQryRegionFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvQryRegionFldsEN.TabName = objDT.Rows[0][convQryRegionFlds.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQryRegionFldsEN.FldId = objDT.Rows[0][convQryRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvQryRegionFldsEN.FldName = objDT.Rows[0][convQryRegionFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQryRegionFldsEN.LabelCaption = objDT.Rows[0][convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objvQryRegionFldsEN.CtlTypeId = objDT.Rows[0][convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvQryRegionFldsEN.CtlTypeName = objDT.Rows[0][convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQryRegionFldsEN.CtlCnName = objDT.Rows[0][convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQryRegionFldsEN.CtlTypeAbbr = objDT.Rows[0][convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvQryRegionFldsEN.VarId = objDT.Rows[0][convQryRegionFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objvQryRegionFldsEN.DsTabId = objDT.Rows[0][convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objvQryRegionFldsEN.QueryOptionId = objDT.Rows[0][convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id(字段类型:varchar,字段长度:2,是否可空:False)
 objvQryRegionFldsEN.QueryOptionName = objDT.Rows[0][convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvQryRegionFldsEN.DdlItemsOptionId = objDT.Rows[0][convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objvQryRegionFldsEN.DdlItemsOptionName = objDT.Rows[0][convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQryRegionFldsEN.DsSqlStr = objDT.Rows[0][convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objvQryRegionFldsEN.ItemsString = objDT.Rows[0][convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objvQryRegionFldsEN.DsCondStr = objDT.Rows[0][convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objvQryRegionFldsEN.ColSpan = TransNullToInt(objDT.Rows[0][convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objvQryRegionFldsEN.Width = TransNullToInt(objDT.Rows[0][convQryRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvQryRegionFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvQryRegionFldsEN.ChangeEvent = objDT.Rows[0][convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvQryRegionFldsEN.ClickEvent = objDT.Rows[0][convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvQryRegionFldsEN.InUse = TransNullToBool(objDT.Rows[0][convQryRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQryRegionFldsEN.UpdUser = objDT.Rows[0][convQryRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvQryRegionFldsEN.UpdDate = objDT.Rows[0][convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQryRegionFldsEN.Memo = objDT.Rows[0][convQryRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQryRegionFldsEN.PrjId = objDT.Rows[0][convQryRegionFlds.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQryRegionFldsDA: GetvQryRegionFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQryRegionFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vQryRegionFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
 objvQryRegionFldsEN.mId = Int32.Parse(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id(字段类型:varchar,字段长度:2,是否可空:False)
 objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数(字段类型:int,字段长度:4,是否可空:True)
 objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件(字段类型:varchar,字段长度:50,是否可空:True)
 objvQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQryRegionFldsDA: GetObjBymId)", objException.Message));
}
return objvQryRegionFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQryRegionFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
strSQL = "Select * from vQryRegionFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN()
{
mId = TransNullToInt(objRow[convQryRegionFlds.mId].ToString().Trim()), //mId
RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(), //区域Id
RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(), //区域名称
TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(), //表ID
TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(), //表名
FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(), //字段Id
FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(), //字段名
LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(), //标签标题
CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(), //控件类型号
CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(), //控件类型名
CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(), //控件类型中文名
CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(), //控件类型缩写
VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(), //变量Id
DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(), //数据源表ID
QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(), //查询方式Id
QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(), //查询方式名称
DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(), //下拉框列表选项ID
DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(), //下拉选项名
DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(), //数据源SQL串
ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(), //列表项串
DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(), //数据源条件串
ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.ColSpan].ToString().Trim()), //跨列数
Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.Width].ToString().Trim()), //宽
SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.SeqNum].ToString().Trim()), //字段序号
ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(), //Change事件
ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(), //Click事件
InUse = TransNullToBool(objRow[convQryRegionFlds.InUse].ToString().Trim()), //是否在用
UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(), //说明
PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim() //工程ID
};
objvQryRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQryRegionFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQryRegionFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQryRegionFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = TransNullToInt(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = TransNullToBool(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQryRegionFldsDA: GetObjByDataRowvQryRegionFlds)", objException.Message));
}
objvQryRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQryRegionFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQryRegionFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQryRegionFldsEN objvQryRegionFldsEN = new clsvQryRegionFldsEN();
try
{
objvQryRegionFldsEN.mId = TransNullToInt(objRow[convQryRegionFlds.mId].ToString().Trim()); //mId
objvQryRegionFldsEN.RegionId = objRow[convQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objvQryRegionFldsEN.RegionName = objRow[convQryRegionFlds.RegionName].ToString().Trim(); //区域名称
objvQryRegionFldsEN.TabId = objRow[convQryRegionFlds.TabId] == DBNull.Value ? null : objRow[convQryRegionFlds.TabId].ToString().Trim(); //表ID
objvQryRegionFldsEN.TabName = objRow[convQryRegionFlds.TabName].ToString().Trim(); //表名
objvQryRegionFldsEN.FldId = objRow[convQryRegionFlds.FldId].ToString().Trim(); //字段Id
objvQryRegionFldsEN.FldName = objRow[convQryRegionFlds.FldName].ToString().Trim(); //字段名
objvQryRegionFldsEN.LabelCaption = objRow[convQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[convQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objvQryRegionFldsEN.CtlTypeId = objRow[convQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[convQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvQryRegionFldsEN.CtlTypeName = objRow[convQryRegionFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvQryRegionFldsEN.CtlCnName = objRow[convQryRegionFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvQryRegionFldsEN.CtlTypeAbbr = objRow[convQryRegionFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvQryRegionFldsEN.VarId = objRow[convQryRegionFlds.VarId] == DBNull.Value ? null : objRow[convQryRegionFlds.VarId].ToString().Trim(); //变量Id
objvQryRegionFldsEN.DsTabId = objRow[convQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objvQryRegionFldsEN.QueryOptionId = objRow[convQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objvQryRegionFldsEN.QueryOptionName = objRow[convQryRegionFlds.QueryOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.QueryOptionName].ToString().Trim(); //查询方式名称
objvQryRegionFldsEN.DdlItemsOptionId = objRow[convQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvQryRegionFldsEN.DdlItemsOptionName = objRow[convQryRegionFlds.DdlItemsOptionName] == DBNull.Value ? null : objRow[convQryRegionFlds.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objvQryRegionFldsEN.DsSqlStr = objRow[convQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvQryRegionFldsEN.ItemsString = objRow[convQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[convQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objvQryRegionFldsEN.DsCondStr = objRow[convQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[convQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvQryRegionFldsEN.ColSpan = objRow[convQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objvQryRegionFldsEN.Width = objRow[convQryRegionFlds.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.Width].ToString().Trim()); //宽
objvQryRegionFldsEN.SeqNum = objRow[convQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objvQryRegionFldsEN.ChangeEvent = objRow[convQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objvQryRegionFldsEN.ClickEvent = objRow[convQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[convQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objvQryRegionFldsEN.InUse = TransNullToBool(objRow[convQryRegionFlds.InUse].ToString().Trim()); //是否在用
objvQryRegionFldsEN.UpdUser = objRow[convQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objvQryRegionFldsEN.UpdDate = objRow[convQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[convQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objvQryRegionFldsEN.Memo = objRow[convQryRegionFlds.Memo] == DBNull.Value ? null : objRow[convQryRegionFlds.Memo].ToString().Trim(); //说明
objvQryRegionFldsEN.PrjId = objRow[convQryRegionFlds.PrjId] == DBNull.Value ? null : objRow[convQryRegionFlds.PrjId].ToString().Trim(); //工程ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQryRegionFldsDA: GetObjByDataRow)", objException.Message));
}
objvQryRegionFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQryRegionFldsEN;
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
objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQryRegionFldsEN._CurrTabName, convQryRegionFlds.mId, 8, "");
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
objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQryRegionFldsEN._CurrTabName, convQryRegionFlds.mId, 8, strPrefix);
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
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vQryRegionFlds where " + strCondition;
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
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vQryRegionFlds where " + strCondition;
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
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQryRegionFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQryRegionFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQryRegionFlds", strCondition))
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
objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQryRegionFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQryRegionFldsENS">源对象</param>
 /// <param name = "objvQryRegionFldsENT">目标对象</param>
public void CopyTo(clsvQryRegionFldsEN objvQryRegionFldsENS, clsvQryRegionFldsEN objvQryRegionFldsENT)
{
objvQryRegionFldsENT.mId = objvQryRegionFldsENS.mId; //mId
objvQryRegionFldsENT.RegionId = objvQryRegionFldsENS.RegionId; //区域Id
objvQryRegionFldsENT.RegionName = objvQryRegionFldsENS.RegionName; //区域名称
objvQryRegionFldsENT.TabId = objvQryRegionFldsENS.TabId; //表ID
objvQryRegionFldsENT.TabName = objvQryRegionFldsENS.TabName; //表名
objvQryRegionFldsENT.FldId = objvQryRegionFldsENS.FldId; //字段Id
objvQryRegionFldsENT.FldName = objvQryRegionFldsENS.FldName; //字段名
objvQryRegionFldsENT.LabelCaption = objvQryRegionFldsENS.LabelCaption; //标签标题
objvQryRegionFldsENT.CtlTypeId = objvQryRegionFldsENS.CtlTypeId; //控件类型号
objvQryRegionFldsENT.CtlTypeName = objvQryRegionFldsENS.CtlTypeName; //控件类型名
objvQryRegionFldsENT.CtlCnName = objvQryRegionFldsENS.CtlCnName; //控件类型中文名
objvQryRegionFldsENT.CtlTypeAbbr = objvQryRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvQryRegionFldsENT.VarId = objvQryRegionFldsENS.VarId; //变量Id
objvQryRegionFldsENT.DsTabId = objvQryRegionFldsENS.DsTabId; //数据源表ID
objvQryRegionFldsENT.QueryOptionId = objvQryRegionFldsENS.QueryOptionId; //查询方式Id
objvQryRegionFldsENT.QueryOptionName = objvQryRegionFldsENS.QueryOptionName; //查询方式名称
objvQryRegionFldsENT.DdlItemsOptionId = objvQryRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objvQryRegionFldsENT.DdlItemsOptionName = objvQryRegionFldsENS.DdlItemsOptionName; //下拉选项名
objvQryRegionFldsENT.DsSqlStr = objvQryRegionFldsENS.DsSqlStr; //数据源SQL串
objvQryRegionFldsENT.ItemsString = objvQryRegionFldsENS.ItemsString; //列表项串
objvQryRegionFldsENT.DsCondStr = objvQryRegionFldsENS.DsCondStr; //数据源条件串
objvQryRegionFldsENT.ColSpan = objvQryRegionFldsENS.ColSpan; //跨列数
objvQryRegionFldsENT.Width = objvQryRegionFldsENS.Width; //宽
objvQryRegionFldsENT.SeqNum = objvQryRegionFldsENS.SeqNum; //字段序号
objvQryRegionFldsENT.ChangeEvent = objvQryRegionFldsENS.ChangeEvent; //Change事件
objvQryRegionFldsENT.ClickEvent = objvQryRegionFldsENS.ClickEvent; //Click事件
objvQryRegionFldsENT.InUse = objvQryRegionFldsENS.InUse; //是否在用
objvQryRegionFldsENT.UpdUser = objvQryRegionFldsENS.UpdUser; //修改者
objvQryRegionFldsENT.UpdDate = objvQryRegionFldsENS.UpdDate; //修改日期
objvQryRegionFldsENT.Memo = objvQryRegionFldsENS.Memo; //说明
objvQryRegionFldsENT.PrjId = objvQryRegionFldsENS.PrjId; //工程ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQryRegionFldsEN objvQryRegionFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.RegionId, 10, convQryRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.RegionName, 50, convQryRegionFlds.RegionName);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.TabId, 8, convQryRegionFlds.TabId);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.TabName, 100, convQryRegionFlds.TabName);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.FldId, 8, convQryRegionFlds.FldId);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.FldName, 50, convQryRegionFlds.FldName);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.LabelCaption, 150, convQryRegionFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.CtlTypeId, 2, convQryRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.CtlTypeName, 30, convQryRegionFlds.CtlTypeName);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.CtlCnName, 50, convQryRegionFlds.CtlCnName);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.CtlTypeAbbr, 5, convQryRegionFlds.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.VarId, 8, convQryRegionFlds.VarId);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.DsTabId, 8, convQryRegionFlds.DsTabId);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.QueryOptionId, 2, convQryRegionFlds.QueryOptionId);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.QueryOptionName, 20, convQryRegionFlds.QueryOptionName);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.DdlItemsOptionId, 2, convQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.DdlItemsOptionName, 20, convQryRegionFlds.DdlItemsOptionName);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.DsSqlStr, 200, convQryRegionFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.ItemsString, 200, convQryRegionFlds.ItemsString);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.DsCondStr, 50, convQryRegionFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.ChangeEvent, 50, convQryRegionFlds.ChangeEvent);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.ClickEvent, 50, convQryRegionFlds.ClickEvent);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.UpdUser, 20, convQryRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.UpdDate, 20, convQryRegionFlds.UpdDate);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.Memo, 1000, convQryRegionFlds.Memo);
clsCheckSql.CheckFieldLen(objvQryRegionFldsEN.PrjId, 4, convQryRegionFlds.PrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.RegionId, convQryRegionFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.RegionName, convQryRegionFlds.RegionName);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.TabId, convQryRegionFlds.TabId);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.TabName, convQryRegionFlds.TabName);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.FldId, convQryRegionFlds.FldId);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.FldName, convQryRegionFlds.FldName);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.LabelCaption, convQryRegionFlds.LabelCaption);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.CtlTypeId, convQryRegionFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.CtlTypeName, convQryRegionFlds.CtlTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.CtlCnName, convQryRegionFlds.CtlCnName);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.CtlTypeAbbr, convQryRegionFlds.CtlTypeAbbr);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.VarId, convQryRegionFlds.VarId);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.DsTabId, convQryRegionFlds.DsTabId);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.QueryOptionId, convQryRegionFlds.QueryOptionId);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.QueryOptionName, convQryRegionFlds.QueryOptionName);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.DdlItemsOptionId, convQryRegionFlds.DdlItemsOptionId);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.DdlItemsOptionName, convQryRegionFlds.DdlItemsOptionName);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.DsSqlStr, convQryRegionFlds.DsSqlStr);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.ItemsString, convQryRegionFlds.ItemsString);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.DsCondStr, convQryRegionFlds.DsCondStr);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.ChangeEvent, convQryRegionFlds.ChangeEvent);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.ClickEvent, convQryRegionFlds.ClickEvent);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.UpdUser, convQryRegionFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.UpdDate, convQryRegionFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.Memo, convQryRegionFlds.Memo);
clsCheckSql.CheckSqlInjection4Field(objvQryRegionFldsEN.PrjId, convQryRegionFlds.PrjId);
//检查外键字段长度
 objvQryRegionFldsEN._IsCheckProperty = true;
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
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
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
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQryRegionFldsEN._CurrTabName);
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
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQryRegionFldsEN._CurrTabName, strCondition);
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
 objSQL = clsvQryRegionFldsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}