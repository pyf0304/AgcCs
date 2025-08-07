
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewFeatureFldsDA
 表名:vViewFeatureFlds(00050454)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 14:38:39
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
 /// v界面功能字段(vViewFeatureFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewFeatureFldsDA : clsCommBase4DA
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
 return clsvViewFeatureFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewFeatureFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewFeatureFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewFeatureFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewFeatureFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vViewFeatureFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewFeatureFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA: GetDataTable_vViewFeatureFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vViewFeatureFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vViewFeatureFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewFeatureFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewFeatureFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewFeatureFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewFeatureFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vViewFeatureFlds.* from vViewFeatureFlds Left Join {1} on {2} where {3} and vViewFeatureFlds.mId not in (Select top {5} vViewFeatureFlds.mId from vViewFeatureFlds Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewFeatureFlds where {1} and mId not in (Select top {2} mId from vViewFeatureFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewFeatureFlds where {1} and mId not in (Select top {3} mId from vViewFeatureFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewFeatureFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vViewFeatureFlds.* from vViewFeatureFlds Left Join {1} on {2} where {3} and vViewFeatureFlds.mId not in (Select top {5} vViewFeatureFlds.mId from vViewFeatureFlds Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewFeatureFlds where {1} and mId not in (Select top {2} mId from vViewFeatureFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewFeatureFlds where {1} and mId not in (Select top {3} mId from vViewFeatureFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewFeatureFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA:GetObjLst)", objException.Message));
}
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vViewFeatureFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = TransNullToInt(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = TransNullToBool(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewFeatureFldsDA: GetObjLst)", objException.Message));
}
objvViewFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewFeatureFldsEN);
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
public List<clsvViewFeatureFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewFeatureFldsEN> arrObjLst = new List<clsvViewFeatureFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = TransNullToInt(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = TransNullToBool(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewFeatureFldsDA: GetObjLst)", objException.Message));
}
objvViewFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewFeatureFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewFeatureFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewFeatureFlds(ref clsvViewFeatureFldsEN objvViewFeatureFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vViewFeatureFlds where mId = " + ""+ objvViewFeatureFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewFeatureFldsEN.mId = TransNullToInt(objDT.Rows[0][convViewFeatureFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvViewFeatureFldsEN.ViewFeatureId = objDT.Rows[0][convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvViewFeatureFldsEN.RegionId = objDT.Rows[0][convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvViewFeatureFldsEN.RegionName = objDT.Rows[0][convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewFeatureFldsEN.RegionTypeId = objDT.Rows[0][convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewFeatureFldsEN.RegionTypeName = objDT.Rows[0][convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewFeatureFldsEN.FeatureId = objDT.Rows[0][convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewFeatureFldsEN.FeatureName = objDT.Rows[0][convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewFeatureFldsEN.ButtonName = objDT.Rows[0][convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewFeatureFldsEN.ValueGivingModeId = objDT.Rows[0][convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id(字段类型:char,字段长度:2,是否可空:False)
 objvViewFeatureFldsEN.GroupName = objDT.Rows[0][convViewFeatureFlds.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewFeatureFldsEN.ReleTabId = objDT.Rows[0][convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvViewFeatureFldsEN.RelaTabName = objDT.Rows[0][convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewFeatureFldsEN.ReleFldId = objDT.Rows[0][convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.FieldTypeId = objDT.Rows[0][convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvViewFeatureFldsEN.FieldTypeName = objDT.Rows[0][convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewFeatureFldsEN.FuncName = objDT.Rows[0][convViewFeatureFlds.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewFeatureFldsEN.LabelCaption = objDT.Rows[0][convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objvViewFeatureFldsEN.CtlTypeId = objDT.Rows[0][convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvViewFeatureFldsEN.CtlTypeName = objDT.Rows[0][convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewFeatureFldsEN.CtlCnName = objDT.Rows[0][convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewFeatureFldsEN.CtlTypeAbbr = objDT.Rows[0][convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvViewFeatureFldsEN.VarId = objDT.Rows[0][convViewFeatureFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.VarName = objDT.Rows[0][convViewFeatureFlds.VarName].ToString().Trim(); //变量名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewFeatureFldsEN.CtrlId = objDT.Rows[0][convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewFeatureFldsEN.DefaultValue = objDT.Rows[0][convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewFeatureFldsEN.OrderNum = TransNullToInt(objDT.Rows[0][convViewFeatureFlds.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvViewFeatureFldsEN.DdlItemsOptionId = objDT.Rows[0][convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objvViewFeatureFldsEN.DsTabId = objDT.Rows[0][convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewFeatureFldsEN.FldName = objDT.Rows[0][convViewFeatureFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewFeatureFldsEN.DsCondStr = objDT.Rows[0][convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewFeatureFldsEN.DsSqlStr = objDT.Rows[0][convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objvViewFeatureFldsEN.ItemsString = objDT.Rows[0][convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objvViewFeatureFldsEN.InUse = TransNullToBool(objDT.Rows[0][convViewFeatureFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvViewFeatureFldsEN.PrjId = objDT.Rows[0][convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvViewFeatureFldsEN.UpdUser = objDT.Rows[0][convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewFeatureFldsEN.UpdDate = objDT.Rows[0][convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewFeatureFldsEN.Memo = objDT.Rows[0][convViewFeatureFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewFeatureFldsEN.DsTabName = objDT.Rows[0][convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewFeatureFldsEN.FldIdCond1 = objDT.Rows[0][convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.FldIdCond2 = objDT.Rows[0][convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.TabFeatureId4Ddl = objDT.Rows[0][convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.VarIdCond1 = objDT.Rows[0][convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.VarIdCond2 = objDT.Rows[0][convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.VarTypeIdCond1 = objDT.Rows[0][convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1(字段类型:char,字段长度:4,是否可空:True)
 objvViewFeatureFldsEN.VarTypeIdCond2 = objDT.Rows[0][convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2(字段类型:char,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewFeatureFldsDA: GetvViewFeatureFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewFeatureFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vViewFeatureFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
 objvViewFeatureFldsEN.mId = Int32.Parse(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id(字段类型:char,字段长度:10,是否可空:False)
 objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id(字段类型:char,字段长度:2,是否可空:False)
 objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题(字段类型:varchar,字段长度:150,是否可空:True)
 objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objvViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1(字段类型:char,字段长度:8,是否可空:True)
 objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1(字段类型:char,字段长度:4,是否可空:True)
 objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2(字段类型:char,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewFeatureFldsDA: GetObjBymId)", objException.Message));
}
return objvViewFeatureFldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewFeatureFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
strSQL = "Select * from vViewFeatureFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN()
{
mId = TransNullToInt(objRow[convViewFeatureFlds.mId].ToString().Trim()), //mId
ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(), //界面功能Id
RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(), //区域Id
RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(), //区域名称
RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(), //区域类型Id
RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(), //区域类型名称
FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(), //功能名称
ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(), //按钮名称
ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(), //给值方式Id
GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(), //组名
ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(), //相关表Id
SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()), //字段序号
RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(), //相关表名
ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(), //相关字段Id
FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(), //字段类型Id
FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(), //字段类型名
FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(), //函数名
LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(), //标签标题
CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(), //控件类型号
CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(), //控件类型名
CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(), //控件类型中文名
CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(), //控件类型缩写
VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(), //变量Id
VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(), //变量名
CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(), //控件Id
DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(), //缺省值
OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()), //序号
DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(), //下拉框列表选项ID
DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(), //数据源表ID
FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(), //字段名
DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(), //数据源条件串
DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(), //数据源SQL串
ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(), //列表项串
InUse = TransNullToBool(objRow[convViewFeatureFlds.InUse].ToString().Trim()), //是否在用
PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(), //工程ID
UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(), //说明
DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(), //数据源表
FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(), //字段Id_条件1
FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(), //字段Id_条件2
TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(), //下拉框表功能Id
VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(), //变量Id_条件1
VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(), //数据源字段_条件1
VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(), //变量类型Id_条件1
VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim() //变量类型Id_条件2
};
objvViewFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewFeatureFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewFeatureFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewFeatureFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = TransNullToInt(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = TransNullToBool(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewFeatureFldsDA: GetObjByDataRowvViewFeatureFlds)", objException.Message));
}
objvViewFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewFeatureFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewFeatureFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewFeatureFldsEN objvViewFeatureFldsEN = new clsvViewFeatureFldsEN();
try
{
objvViewFeatureFldsEN.mId = TransNullToInt(objRow[convViewFeatureFlds.mId].ToString().Trim()); //mId
objvViewFeatureFldsEN.ViewFeatureId = objRow[convViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objvViewFeatureFldsEN.RegionId = objRow[convViewFeatureFlds.RegionId].ToString().Trim(); //区域Id
objvViewFeatureFldsEN.RegionName = objRow[convViewFeatureFlds.RegionName].ToString().Trim(); //区域名称
objvViewFeatureFldsEN.RegionTypeId = objRow[convViewFeatureFlds.RegionTypeId].ToString().Trim(); //区域类型Id
objvViewFeatureFldsEN.RegionTypeName = objRow[convViewFeatureFlds.RegionTypeName].ToString().Trim(); //区域类型名称
objvViewFeatureFldsEN.FeatureId = objRow[convViewFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvViewFeatureFldsEN.FeatureName = objRow[convViewFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvViewFeatureFldsEN.ButtonName = objRow[convViewFeatureFlds.ButtonName] == DBNull.Value ? null : objRow[convViewFeatureFlds.ButtonName].ToString().Trim(); //按钮名称
objvViewFeatureFldsEN.ValueGivingModeId = objRow[convViewFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvViewFeatureFldsEN.GroupName = objRow[convViewFeatureFlds.GroupName] == DBNull.Value ? null : objRow[convViewFeatureFlds.GroupName].ToString().Trim(); //组名
objvViewFeatureFldsEN.ReleTabId = objRow[convViewFeatureFlds.ReleTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleTabId].ToString().Trim(); //相关表Id
objvViewFeatureFldsEN.SeqNum = objRow[convViewFeatureFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewFeatureFlds.SeqNum].ToString().Trim()); //字段序号
objvViewFeatureFldsEN.RelaTabName = objRow[convViewFeatureFlds.RelaTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.RelaTabName].ToString().Trim(); //相关表名
objvViewFeatureFldsEN.ReleFldId = objRow[convViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[convViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objvViewFeatureFldsEN.FieldTypeId = objRow[convViewFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvViewFeatureFldsEN.FieldTypeName = objRow[convViewFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvViewFeatureFldsEN.FuncName = objRow[convViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objvViewFeatureFldsEN.LabelCaption = objRow[convViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[convViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objvViewFeatureFldsEN.CtlTypeId = objRow[convViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objvViewFeatureFldsEN.CtlTypeName = objRow[convViewFeatureFlds.CtlTypeName].ToString().Trim(); //控件类型名
objvViewFeatureFldsEN.CtlCnName = objRow[convViewFeatureFlds.CtlCnName].ToString().Trim(); //控件类型中文名
objvViewFeatureFldsEN.CtlTypeAbbr = objRow[convViewFeatureFlds.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objvViewFeatureFldsEN.VarId = objRow[convViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objvViewFeatureFldsEN.VarName = objRow[convViewFeatureFlds.VarName] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarName].ToString().Trim(); //变量名
objvViewFeatureFldsEN.CtrlId = objRow[convViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[convViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objvViewFeatureFldsEN.DefaultValue = objRow[convViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvViewFeatureFldsEN.OrderNum = objRow[convViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objvViewFeatureFldsEN.DdlItemsOptionId = objRow[convViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objvViewFeatureFldsEN.DsTabId = objRow[convViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objvViewFeatureFldsEN.FldName = objRow[convViewFeatureFlds.FldName].ToString().Trim(); //字段名
objvViewFeatureFldsEN.DsCondStr = objRow[convViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objvViewFeatureFldsEN.DsSqlStr = objRow[convViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objvViewFeatureFldsEN.ItemsString = objRow[convViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[convViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objvViewFeatureFldsEN.InUse = TransNullToBool(objRow[convViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objvViewFeatureFldsEN.PrjId = objRow[convViewFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convViewFeatureFlds.PrjId].ToString().Trim(); //工程ID
objvViewFeatureFldsEN.UpdUser = objRow[convViewFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvViewFeatureFldsEN.UpdDate = objRow[convViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvViewFeatureFldsEN.Memo = objRow[convViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[convViewFeatureFlds.Memo].ToString().Trim(); //说明
objvViewFeatureFldsEN.DsTabName = objRow[convViewFeatureFlds.DsTabName] == DBNull.Value ? null : objRow[convViewFeatureFlds.DsTabName].ToString().Trim(); //数据源表
objvViewFeatureFldsEN.FldIdCond1 = objRow[convViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objvViewFeatureFldsEN.FldIdCond2 = objRow[convViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objvViewFeatureFldsEN.TabFeatureId4Ddl = objRow[convViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[convViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objvViewFeatureFldsEN.VarIdCond1 = objRow[convViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objvViewFeatureFldsEN.VarIdCond2 = objRow[convViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objvViewFeatureFldsEN.VarTypeIdCond1 = objRow[convViewFeatureFlds.VarTypeIdCond1] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond1].ToString().Trim(); //变量类型Id_条件1
objvViewFeatureFldsEN.VarTypeIdCond2 = objRow[convViewFeatureFlds.VarTypeIdCond2] == DBNull.Value ? null : objRow[convViewFeatureFlds.VarTypeIdCond2].ToString().Trim(); //变量类型Id_条件2
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewFeatureFldsDA: GetObjByDataRow)", objException.Message));
}
objvViewFeatureFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewFeatureFldsEN;
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
objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewFeatureFldsEN._CurrTabName, convViewFeatureFlds.mId, 8, "");
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
objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewFeatureFldsEN._CurrTabName, convViewFeatureFlds.mId, 8, strPrefix);
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
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vViewFeatureFlds where " + strCondition;
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
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vViewFeatureFlds where " + strCondition;
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
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewFeatureFlds", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewFeatureFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewFeatureFlds", strCondition))
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
objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewFeatureFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewFeatureFldsENS">源对象</param>
 /// <param name = "objvViewFeatureFldsENT">目标对象</param>
public void CopyTo(clsvViewFeatureFldsEN objvViewFeatureFldsENS, clsvViewFeatureFldsEN objvViewFeatureFldsENT)
{
objvViewFeatureFldsENT.mId = objvViewFeatureFldsENS.mId; //mId
objvViewFeatureFldsENT.ViewFeatureId = objvViewFeatureFldsENS.ViewFeatureId; //界面功能Id
objvViewFeatureFldsENT.RegionId = objvViewFeatureFldsENS.RegionId; //区域Id
objvViewFeatureFldsENT.RegionName = objvViewFeatureFldsENS.RegionName; //区域名称
objvViewFeatureFldsENT.RegionTypeId = objvViewFeatureFldsENS.RegionTypeId; //区域类型Id
objvViewFeatureFldsENT.RegionTypeName = objvViewFeatureFldsENS.RegionTypeName; //区域类型名称
objvViewFeatureFldsENT.FeatureId = objvViewFeatureFldsENS.FeatureId; //功能Id
objvViewFeatureFldsENT.FeatureName = objvViewFeatureFldsENS.FeatureName; //功能名称
objvViewFeatureFldsENT.ButtonName = objvViewFeatureFldsENS.ButtonName; //按钮名称
objvViewFeatureFldsENT.ValueGivingModeId = objvViewFeatureFldsENS.ValueGivingModeId; //给值方式Id
objvViewFeatureFldsENT.GroupName = objvViewFeatureFldsENS.GroupName; //组名
objvViewFeatureFldsENT.ReleTabId = objvViewFeatureFldsENS.ReleTabId; //相关表Id
objvViewFeatureFldsENT.SeqNum = objvViewFeatureFldsENS.SeqNum; //字段序号
objvViewFeatureFldsENT.RelaTabName = objvViewFeatureFldsENS.RelaTabName; //相关表名
objvViewFeatureFldsENT.ReleFldId = objvViewFeatureFldsENS.ReleFldId; //相关字段Id
objvViewFeatureFldsENT.FieldTypeId = objvViewFeatureFldsENS.FieldTypeId; //字段类型Id
objvViewFeatureFldsENT.FieldTypeName = objvViewFeatureFldsENS.FieldTypeName; //字段类型名
objvViewFeatureFldsENT.FuncName = objvViewFeatureFldsENS.FuncName; //函数名
objvViewFeatureFldsENT.LabelCaption = objvViewFeatureFldsENS.LabelCaption; //标签标题
objvViewFeatureFldsENT.CtlTypeId = objvViewFeatureFldsENS.CtlTypeId; //控件类型号
objvViewFeatureFldsENT.CtlTypeName = objvViewFeatureFldsENS.CtlTypeName; //控件类型名
objvViewFeatureFldsENT.CtlCnName = objvViewFeatureFldsENS.CtlCnName; //控件类型中文名
objvViewFeatureFldsENT.CtlTypeAbbr = objvViewFeatureFldsENS.CtlTypeAbbr; //控件类型缩写
objvViewFeatureFldsENT.VarId = objvViewFeatureFldsENS.VarId; //变量Id
objvViewFeatureFldsENT.VarName = objvViewFeatureFldsENS.VarName; //变量名
objvViewFeatureFldsENT.CtrlId = objvViewFeatureFldsENS.CtrlId; //控件Id
objvViewFeatureFldsENT.DefaultValue = objvViewFeatureFldsENS.DefaultValue; //缺省值
objvViewFeatureFldsENT.OrderNum = objvViewFeatureFldsENS.OrderNum; //序号
objvViewFeatureFldsENT.DdlItemsOptionId = objvViewFeatureFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objvViewFeatureFldsENT.DsTabId = objvViewFeatureFldsENS.DsTabId; //数据源表ID
objvViewFeatureFldsENT.FldName = objvViewFeatureFldsENS.FldName; //字段名
objvViewFeatureFldsENT.DsCondStr = objvViewFeatureFldsENS.DsCondStr; //数据源条件串
objvViewFeatureFldsENT.DsSqlStr = objvViewFeatureFldsENS.DsSqlStr; //数据源SQL串
objvViewFeatureFldsENT.ItemsString = objvViewFeatureFldsENS.ItemsString; //列表项串
objvViewFeatureFldsENT.InUse = objvViewFeatureFldsENS.InUse; //是否在用
objvViewFeatureFldsENT.PrjId = objvViewFeatureFldsENS.PrjId; //工程ID
objvViewFeatureFldsENT.UpdUser = objvViewFeatureFldsENS.UpdUser; //修改者
objvViewFeatureFldsENT.UpdDate = objvViewFeatureFldsENS.UpdDate; //修改日期
objvViewFeatureFldsENT.Memo = objvViewFeatureFldsENS.Memo; //说明
objvViewFeatureFldsENT.DsTabName = objvViewFeatureFldsENS.DsTabName; //数据源表
objvViewFeatureFldsENT.FldIdCond1 = objvViewFeatureFldsENS.FldIdCond1; //字段Id_条件1
objvViewFeatureFldsENT.FldIdCond2 = objvViewFeatureFldsENS.FldIdCond2; //字段Id_条件2
objvViewFeatureFldsENT.TabFeatureId4Ddl = objvViewFeatureFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objvViewFeatureFldsENT.VarIdCond1 = objvViewFeatureFldsENS.VarIdCond1; //变量Id_条件1
objvViewFeatureFldsENT.VarIdCond2 = objvViewFeatureFldsENS.VarIdCond2; //数据源字段_条件1
objvViewFeatureFldsENT.VarTypeIdCond1 = objvViewFeatureFldsENS.VarTypeIdCond1; //变量类型Id_条件1
objvViewFeatureFldsENT.VarTypeIdCond2 = objvViewFeatureFldsENS.VarTypeIdCond2; //变量类型Id_条件2
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewFeatureFldsEN objvViewFeatureFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.ViewFeatureId, 8, convViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.RegionId, 10, convViewFeatureFlds.RegionId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.RegionName, 50, convViewFeatureFlds.RegionName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.RegionTypeId, 4, convViewFeatureFlds.RegionTypeId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.RegionTypeName, 30, convViewFeatureFlds.RegionTypeName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.FeatureId, 4, convViewFeatureFlds.FeatureId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.FeatureName, 100, convViewFeatureFlds.FeatureName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.ButtonName, 30, convViewFeatureFlds.ButtonName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.ValueGivingModeId, 2, convViewFeatureFlds.ValueGivingModeId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.GroupName, 30, convViewFeatureFlds.GroupName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.ReleTabId, 8, convViewFeatureFlds.ReleTabId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.RelaTabName, 100, convViewFeatureFlds.RelaTabName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.ReleFldId, 8, convViewFeatureFlds.ReleFldId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.FieldTypeId, 2, convViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.FieldTypeName, 30, convViewFeatureFlds.FieldTypeName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.FuncName, 100, convViewFeatureFlds.FuncName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.LabelCaption, 150, convViewFeatureFlds.LabelCaption);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.CtlTypeId, 2, convViewFeatureFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.CtlTypeName, 30, convViewFeatureFlds.CtlTypeName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.CtlCnName, 50, convViewFeatureFlds.CtlCnName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.CtlTypeAbbr, 5, convViewFeatureFlds.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.VarId, 8, convViewFeatureFlds.VarId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.VarName, 50, convViewFeatureFlds.VarName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.CtrlId, 50, convViewFeatureFlds.CtrlId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.DefaultValue, 50, convViewFeatureFlds.DefaultValue);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.DdlItemsOptionId, 2, convViewFeatureFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.DsTabId, 8, convViewFeatureFlds.DsTabId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.FldName, 50, convViewFeatureFlds.FldName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.DsCondStr, 50, convViewFeatureFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.DsSqlStr, 200, convViewFeatureFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.ItemsString, 200, convViewFeatureFlds.ItemsString);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.PrjId, 4, convViewFeatureFlds.PrjId);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.UpdUser, 20, convViewFeatureFlds.UpdUser);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.UpdDate, 20, convViewFeatureFlds.UpdDate);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.Memo, 1000, convViewFeatureFlds.Memo);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.DsTabName, 100, convViewFeatureFlds.DsTabName);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.FldIdCond1, 8, convViewFeatureFlds.FldIdCond1);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.FldIdCond2, 8, convViewFeatureFlds.FldIdCond2);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.TabFeatureId4Ddl, 8, convViewFeatureFlds.TabFeatureId4Ddl);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.VarIdCond1, 8, convViewFeatureFlds.VarIdCond1);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.VarIdCond2, 8, convViewFeatureFlds.VarIdCond2);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.VarTypeIdCond1, 4, convViewFeatureFlds.VarTypeIdCond1);
clsCheckSql.CheckFieldLen(objvViewFeatureFldsEN.VarTypeIdCond2, 4, convViewFeatureFlds.VarTypeIdCond2);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.ViewFeatureId, convViewFeatureFlds.ViewFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.RegionId, convViewFeatureFlds.RegionId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.RegionName, convViewFeatureFlds.RegionName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.RegionTypeId, convViewFeatureFlds.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.RegionTypeName, convViewFeatureFlds.RegionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.FeatureId, convViewFeatureFlds.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.FeatureName, convViewFeatureFlds.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.ButtonName, convViewFeatureFlds.ButtonName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.ValueGivingModeId, convViewFeatureFlds.ValueGivingModeId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.GroupName, convViewFeatureFlds.GroupName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.ReleTabId, convViewFeatureFlds.ReleTabId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.RelaTabName, convViewFeatureFlds.RelaTabName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.ReleFldId, convViewFeatureFlds.ReleFldId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.FieldTypeId, convViewFeatureFlds.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.FieldTypeName, convViewFeatureFlds.FieldTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.FuncName, convViewFeatureFlds.FuncName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.LabelCaption, convViewFeatureFlds.LabelCaption);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.CtlTypeId, convViewFeatureFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.CtlTypeName, convViewFeatureFlds.CtlTypeName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.CtlCnName, convViewFeatureFlds.CtlCnName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.CtlTypeAbbr, convViewFeatureFlds.CtlTypeAbbr);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.VarId, convViewFeatureFlds.VarId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.VarName, convViewFeatureFlds.VarName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.CtrlId, convViewFeatureFlds.CtrlId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.DefaultValue, convViewFeatureFlds.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.DdlItemsOptionId, convViewFeatureFlds.DdlItemsOptionId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.DsTabId, convViewFeatureFlds.DsTabId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.FldName, convViewFeatureFlds.FldName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.DsCondStr, convViewFeatureFlds.DsCondStr);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.DsSqlStr, convViewFeatureFlds.DsSqlStr);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.ItemsString, convViewFeatureFlds.ItemsString);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.PrjId, convViewFeatureFlds.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.UpdUser, convViewFeatureFlds.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.UpdDate, convViewFeatureFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.Memo, convViewFeatureFlds.Memo);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.DsTabName, convViewFeatureFlds.DsTabName);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.FldIdCond1, convViewFeatureFlds.FldIdCond1);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.FldIdCond2, convViewFeatureFlds.FldIdCond2);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.TabFeatureId4Ddl, convViewFeatureFlds.TabFeatureId4Ddl);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.VarIdCond1, convViewFeatureFlds.VarIdCond1);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.VarIdCond2, convViewFeatureFlds.VarIdCond2);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.VarTypeIdCond1, convViewFeatureFlds.VarTypeIdCond1);
clsCheckSql.CheckSqlInjection4Field(objvViewFeatureFldsEN.VarTypeIdCond2, convViewFeatureFlds.VarTypeIdCond2);
//检查外键字段长度
 objvViewFeatureFldsEN._IsCheckProperty = true;
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
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
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
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
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
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewFeatureFldsEN._CurrTabName);
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
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewFeatureFldsEN._CurrTabName, strCondition);
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
 objSQL = clsvViewFeatureFldsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}