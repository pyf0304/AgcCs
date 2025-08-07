
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNodeFuncMapDA
 表名:vDataNodeFuncMap(00050554)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 日期:2023/01/18 16:25:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// v结点函数映射(vDataNodeFuncMap)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsvDataNodeFuncMapDA : clsCommBase4DA
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
 return clsvDataNodeFuncMapEN._CurrTabName;
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsvDataNodeFuncMapEN._ConnectStringB)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDataNodeFuncMapEN._ConnectStringB);
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
 if (string.IsNullOrEmpty(clsvDataNodeFuncMapEN._ConnectStringB)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDataNodeFuncMapEN._ConnectStringB);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDnFuncMapId)
{
strDnFuncMapId = strDnFuncMapId.Replace("'", "''");
if (strDnFuncMapId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vDataNodeFuncMap中,检查关键字,长度不正确!(clsvDataNodeFuncMapDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vDataNodeFuncMap中,关键字不能为空 或 null!(clsvDataNodeFuncMapDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFuncMapId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvDataNodeFuncMapDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDataNodeFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDataNodeFuncMap(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA: GetDataTable_vDataNodeFuncMap)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDataNodeFuncMap where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDataNodeFuncMap where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataNodeFuncMap where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataNodeFuncMap where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDataNodeFuncMap where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vDataNodeFuncMap.* from vDataNodeFuncMap Left Join {1} on {2} where {3} and vDataNodeFuncMap.DnFuncMapId not in (Select top {5} vDataNodeFuncMap.DnFuncMapId from vDataNodeFuncMap Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataNodeFuncMap where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from vDataNodeFuncMap where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataNodeFuncMap where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from vDataNodeFuncMap where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vDataNodeFuncMap.* from vDataNodeFuncMap Left Join {1} on {2} where {3} and vDataNodeFuncMap.DnFuncMapId not in (Select top {5} vDataNodeFuncMap.DnFuncMapId from vDataNodeFuncMap Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataNodeFuncMap where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from vDataNodeFuncMap where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataNodeFuncMap where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from vDataNodeFuncMap where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDataNodeFuncMapEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA:GetObjLst)", objException.Message));
}
List<clsvDataNodeFuncMapEN> arrObjLst = new List<clsvDataNodeFuncMapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDataNodeFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeFuncMapEN objvDataNodeFuncMapEN = new clsvDataNodeFuncMapEN();
try
{
objvDataNodeFuncMapEN.DnFuncMapId = objRow[convDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDataNodeFuncMapEN.InDataNodeId = objRow[convDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objvDataNodeFuncMapEN.OutDataNodeId = objRow[convDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objvDataNodeFuncMapEN.AssociationMappingId = objRow[convDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDataNodeFuncMapEN.AssociationMappingName = objRow[convDataNodeFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDataNodeFuncMapEN.FuncMapModeId = objRow[convDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDataNodeFuncMapEN.FuncMapModeName = objRow[convDataNodeFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDataNodeFuncMapEN.TabId = objRow[convDataNodeFuncMap.TabId].ToString().Trim(); //表ID
objvDataNodeFuncMapEN.DnFunctionId = objRow[convDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDataNodeFuncMapEN.PrjId = objRow[convDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID
objvDataNodeFuncMapEN.CmPrjId = objRow[convDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id
objvDataNodeFuncMapEN.CmPrjName = objRow[convDataNodeFuncMap.CmPrjName].ToString().Trim(); //CM工程名
objvDataNodeFuncMapEN.UpdDate = objRow[convDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDataNodeFuncMapEN.UpdUser = objRow[convDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者
objvDataNodeFuncMapEN.Memo = objRow[convDataNodeFuncMap.Memo].ToString().Trim(); //说明
objvDataNodeFuncMapEN.InDataNodeName = objRow[convDataNodeFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDataNodeFuncMapEN.OutDataNodeName = objRow[convDataNodeFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDataNodeFuncMapDA: GetObjLst)", objException.Message));
}
objvDataNodeFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDataNodeFuncMapEN);
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
public List<clsvDataNodeFuncMapEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDataNodeFuncMapEN> arrObjLst = new List<clsvDataNodeFuncMapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeFuncMapEN objvDataNodeFuncMapEN = new clsvDataNodeFuncMapEN();
try
{
objvDataNodeFuncMapEN.DnFuncMapId = objRow[convDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDataNodeFuncMapEN.InDataNodeId = objRow[convDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objvDataNodeFuncMapEN.OutDataNodeId = objRow[convDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objvDataNodeFuncMapEN.AssociationMappingId = objRow[convDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDataNodeFuncMapEN.AssociationMappingName = objRow[convDataNodeFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDataNodeFuncMapEN.FuncMapModeId = objRow[convDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDataNodeFuncMapEN.FuncMapModeName = objRow[convDataNodeFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDataNodeFuncMapEN.TabId = objRow[convDataNodeFuncMap.TabId].ToString().Trim(); //表ID
objvDataNodeFuncMapEN.DnFunctionId = objRow[convDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDataNodeFuncMapEN.PrjId = objRow[convDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID
objvDataNodeFuncMapEN.CmPrjId = objRow[convDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id
objvDataNodeFuncMapEN.CmPrjName = objRow[convDataNodeFuncMap.CmPrjName].ToString().Trim(); //CM工程名
objvDataNodeFuncMapEN.UpdDate = objRow[convDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDataNodeFuncMapEN.UpdUser = objRow[convDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者
objvDataNodeFuncMapEN.Memo = objRow[convDataNodeFuncMap.Memo].ToString().Trim(); //说明
objvDataNodeFuncMapEN.InDataNodeName = objRow[convDataNodeFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDataNodeFuncMapEN.OutDataNodeName = objRow[convDataNodeFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDataNodeFuncMapDA: GetObjLst)", objException.Message));
}
objvDataNodeFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDataNodeFuncMapEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDataNodeFuncMap(ref clsvDataNodeFuncMapEN objvDataNodeFuncMapEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDataNodeFuncMap where DnFuncMapId = " + "'"+ objvDataNodeFuncMapEN.DnFuncMapId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDataNodeFuncMapEN.DnFuncMapId = objDT.Rows[0][convDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objvDataNodeFuncMapEN.InDataNodeId = objDT.Rows[0][convDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id(字段类型:char,字段长度:8,是否可空:True)
 objvDataNodeFuncMapEN.OutDataNodeId = objDT.Rows[0][convDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id(字段类型:char,字段长度:8,是否可空:True)
 objvDataNodeFuncMapEN.AssociationMappingId = objDT.Rows[0][convDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objvDataNodeFuncMapEN.AssociationMappingName = objDT.Rows[0][convDataNodeFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataNodeFuncMapEN.FuncMapModeId = objDT.Rows[0][convDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvDataNodeFuncMapEN.FuncMapModeName = objDT.Rows[0][convDataNodeFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataNodeFuncMapEN.TabId = objDT.Rows[0][convDataNodeFuncMap.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDataNodeFuncMapEN.DnFunctionId = objDT.Rows[0][convDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvDataNodeFuncMapEN.PrjId = objDT.Rows[0][convDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvDataNodeFuncMapEN.CmPrjId = objDT.Rows[0][convDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvDataNodeFuncMapEN.CmPrjName = objDT.Rows[0][convDataNodeFuncMap.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataNodeFuncMapEN.UpdDate = objDT.Rows[0][convDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataNodeFuncMapEN.UpdUser = objDT.Rows[0][convDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataNodeFuncMapEN.Memo = objDT.Rows[0][convDataNodeFuncMap.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDataNodeFuncMapEN.InDataNodeName = objDT.Rows[0][convDataNodeFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvDataNodeFuncMapEN.OutDataNodeName = objDT.Rows[0][convDataNodeFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDataNodeFuncMapDA: GetvDataNodeFuncMap)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDataNodeFuncMapEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
CheckPrimaryKey(strDnFuncMapId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDataNodeFuncMap where DnFuncMapId = " + "'"+ strDnFuncMapId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDataNodeFuncMapEN objvDataNodeFuncMapEN = new clsvDataNodeFuncMapEN();
try
{
 objvDataNodeFuncMapEN.DnFuncMapId = objRow[convDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objvDataNodeFuncMapEN.InDataNodeId = objRow[convDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id(字段类型:char,字段长度:8,是否可空:True)
 objvDataNodeFuncMapEN.OutDataNodeId = objRow[convDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id(字段类型:char,字段长度:8,是否可空:True)
 objvDataNodeFuncMapEN.AssociationMappingId = objRow[convDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objvDataNodeFuncMapEN.AssociationMappingName = objRow[convDataNodeFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataNodeFuncMapEN.FuncMapModeId = objRow[convDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvDataNodeFuncMapEN.FuncMapModeName = objRow[convDataNodeFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataNodeFuncMapEN.TabId = objRow[convDataNodeFuncMap.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDataNodeFuncMapEN.DnFunctionId = objRow[convDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvDataNodeFuncMapEN.PrjId = objRow[convDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvDataNodeFuncMapEN.CmPrjId = objRow[convDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvDataNodeFuncMapEN.CmPrjName = objRow[convDataNodeFuncMap.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataNodeFuncMapEN.UpdDate = objRow[convDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataNodeFuncMapEN.UpdUser = objRow[convDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataNodeFuncMapEN.Memo = objRow[convDataNodeFuncMap.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvDataNodeFuncMapEN.InDataNodeName = objRow[convDataNodeFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvDataNodeFuncMapEN.OutDataNodeName = objRow[convDataNodeFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDataNodeFuncMapDA: GetObjByDnFuncMapId)", objException.Message));
}
return objvDataNodeFuncMapEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDataNodeFuncMapEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from vDataNodeFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDataNodeFuncMapEN objvDataNodeFuncMapEN = new clsvDataNodeFuncMapEN()
{
DnFuncMapId = objRow[convDataNodeFuncMap.DnFuncMapId].ToString().Trim(), //函数映射Id
InDataNodeId = objRow[convDataNodeFuncMap.InDataNodeId].ToString().Trim(), //In数据结点Id
OutDataNodeId = objRow[convDataNodeFuncMap.OutDataNodeId].ToString().Trim(), //Out数据结点Id
AssociationMappingId = objRow[convDataNodeFuncMap.AssociationMappingId].ToString().Trim(), //关联关系映射Id
AssociationMappingName = objRow[convDataNodeFuncMap.AssociationMappingName].ToString().Trim(), //关联关系映射名
FuncMapModeId = objRow[convDataNodeFuncMap.FuncMapModeId].ToString().Trim(), //函数映射模式Id
FuncMapModeName = objRow[convDataNodeFuncMap.FuncMapModeName].ToString().Trim(), //函数映射模式名
TabId = objRow[convDataNodeFuncMap.TabId].ToString().Trim(), //表ID
DnFunctionId = objRow[convDataNodeFuncMap.DnFunctionId].ToString().Trim(), //DN函数Id
PrjId = objRow[convDataNodeFuncMap.PrjId].ToString().Trim(), //工程ID
CmPrjId = objRow[convDataNodeFuncMap.CmPrjId].ToString().Trim(), //CM工程Id
CmPrjName = objRow[convDataNodeFuncMap.CmPrjName].ToString().Trim(), //CM工程名
UpdDate = objRow[convDataNodeFuncMap.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convDataNodeFuncMap.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convDataNodeFuncMap.Memo].ToString().Trim(), //说明
InDataNodeName = objRow[convDataNodeFuncMap.InDataNodeName].ToString().Trim(), //In数据结点名
OutDataNodeName = objRow[convDataNodeFuncMap.OutDataNodeName].ToString().Trim() //Out数据结点名
};
objvDataNodeFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataNodeFuncMapEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDataNodeFuncMapDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDataNodeFuncMapEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDataNodeFuncMapEN objvDataNodeFuncMapEN = new clsvDataNodeFuncMapEN();
try
{
objvDataNodeFuncMapEN.DnFuncMapId = objRow[convDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDataNodeFuncMapEN.InDataNodeId = objRow[convDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objvDataNodeFuncMapEN.OutDataNodeId = objRow[convDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objvDataNodeFuncMapEN.AssociationMappingId = objRow[convDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDataNodeFuncMapEN.AssociationMappingName = objRow[convDataNodeFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDataNodeFuncMapEN.FuncMapModeId = objRow[convDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDataNodeFuncMapEN.FuncMapModeName = objRow[convDataNodeFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDataNodeFuncMapEN.TabId = objRow[convDataNodeFuncMap.TabId].ToString().Trim(); //表ID
objvDataNodeFuncMapEN.DnFunctionId = objRow[convDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDataNodeFuncMapEN.PrjId = objRow[convDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID
objvDataNodeFuncMapEN.CmPrjId = objRow[convDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id
objvDataNodeFuncMapEN.CmPrjName = objRow[convDataNodeFuncMap.CmPrjName].ToString().Trim(); //CM工程名
objvDataNodeFuncMapEN.UpdDate = objRow[convDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDataNodeFuncMapEN.UpdUser = objRow[convDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者
objvDataNodeFuncMapEN.Memo = objRow[convDataNodeFuncMap.Memo].ToString().Trim(); //说明
objvDataNodeFuncMapEN.InDataNodeName = objRow[convDataNodeFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDataNodeFuncMapEN.OutDataNodeName = objRow[convDataNodeFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDataNodeFuncMapDA: GetObjByDataRowvDataNodeFuncMap)", objException.Message));
}
objvDataNodeFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataNodeFuncMapEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDataNodeFuncMapEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDataNodeFuncMapEN objvDataNodeFuncMapEN = new clsvDataNodeFuncMapEN();
try
{
objvDataNodeFuncMapEN.DnFuncMapId = objRow[convDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDataNodeFuncMapEN.InDataNodeId = objRow[convDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objvDataNodeFuncMapEN.OutDataNodeId = objRow[convDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objvDataNodeFuncMapEN.AssociationMappingId = objRow[convDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDataNodeFuncMapEN.AssociationMappingName = objRow[convDataNodeFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDataNodeFuncMapEN.FuncMapModeId = objRow[convDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDataNodeFuncMapEN.FuncMapModeName = objRow[convDataNodeFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDataNodeFuncMapEN.TabId = objRow[convDataNodeFuncMap.TabId].ToString().Trim(); //表ID
objvDataNodeFuncMapEN.DnFunctionId = objRow[convDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDataNodeFuncMapEN.PrjId = objRow[convDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID
objvDataNodeFuncMapEN.CmPrjId = objRow[convDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id
objvDataNodeFuncMapEN.CmPrjName = objRow[convDataNodeFuncMap.CmPrjName].ToString().Trim(); //CM工程名
objvDataNodeFuncMapEN.UpdDate = objRow[convDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDataNodeFuncMapEN.UpdUser = objRow[convDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者
objvDataNodeFuncMapEN.Memo = objRow[convDataNodeFuncMap.Memo].ToString().Trim(); //说明
objvDataNodeFuncMapEN.InDataNodeName = objRow[convDataNodeFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDataNodeFuncMapEN.OutDataNodeName = objRow[convDataNodeFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDataNodeFuncMapDA: GetObjByDataRow)", objException.Message));
}
objvDataNodeFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataNodeFuncMapEN;
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
objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDataNodeFuncMapEN._CurrTabName, convDataNodeFuncMap.DnFuncMapId, 8, "");
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
objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDataNodeFuncMapEN._CurrTabName, convDataNodeFuncMap.DnFuncMapId, 8, strPrefix);
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
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DnFuncMapId from vDataNodeFuncMap where " + strCondition;
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
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DnFuncMapId from vDataNodeFuncMap where " + strCondition;
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
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDnFuncMapId)
{
CheckPrimaryKey(strDnFuncMapId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDataNodeFuncMap", "DnFuncMapId = " + "'"+ strDnFuncMapId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDataNodeFuncMapDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDataNodeFuncMap", strCondition))
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
objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDataNodeFuncMap");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapENS">源对象</param>
 /// <param name = "objvDataNodeFuncMapENT">目标对象</param>
public void CopyTo(clsvDataNodeFuncMapEN objvDataNodeFuncMapENS, clsvDataNodeFuncMapEN objvDataNodeFuncMapENT)
{
objvDataNodeFuncMapENT.DnFuncMapId = objvDataNodeFuncMapENS.DnFuncMapId; //函数映射Id
objvDataNodeFuncMapENT.InDataNodeId = objvDataNodeFuncMapENS.InDataNodeId; //In数据结点Id
objvDataNodeFuncMapENT.OutDataNodeId = objvDataNodeFuncMapENS.OutDataNodeId; //Out数据结点Id
objvDataNodeFuncMapENT.AssociationMappingId = objvDataNodeFuncMapENS.AssociationMappingId; //关联关系映射Id
objvDataNodeFuncMapENT.AssociationMappingName = objvDataNodeFuncMapENS.AssociationMappingName; //关联关系映射名
objvDataNodeFuncMapENT.FuncMapModeId = objvDataNodeFuncMapENS.FuncMapModeId; //函数映射模式Id
objvDataNodeFuncMapENT.FuncMapModeName = objvDataNodeFuncMapENS.FuncMapModeName; //函数映射模式名
objvDataNodeFuncMapENT.TabId = objvDataNodeFuncMapENS.TabId; //表ID
objvDataNodeFuncMapENT.DnFunctionId = objvDataNodeFuncMapENS.DnFunctionId; //DN函数Id
objvDataNodeFuncMapENT.PrjId = objvDataNodeFuncMapENS.PrjId; //工程ID
objvDataNodeFuncMapENT.CmPrjId = objvDataNodeFuncMapENS.CmPrjId; //CM工程Id
objvDataNodeFuncMapENT.CmPrjName = objvDataNodeFuncMapENS.CmPrjName; //CM工程名
objvDataNodeFuncMapENT.UpdDate = objvDataNodeFuncMapENS.UpdDate; //修改日期
objvDataNodeFuncMapENT.UpdUser = objvDataNodeFuncMapENS.UpdUser; //修改者
objvDataNodeFuncMapENT.Memo = objvDataNodeFuncMapENS.Memo; //说明
objvDataNodeFuncMapENT.InDataNodeName = objvDataNodeFuncMapENS.InDataNodeName; //In数据结点名
objvDataNodeFuncMapENT.OutDataNodeName = objvDataNodeFuncMapENS.OutDataNodeName; //Out数据结点名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDataNodeFuncMapEN objvDataNodeFuncMapEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.DnFuncMapId, 8, convDataNodeFuncMap.DnFuncMapId);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.InDataNodeId, 8, convDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.OutDataNodeId, 8, convDataNodeFuncMap.OutDataNodeId);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.AssociationMappingId, 2, convDataNodeFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.AssociationMappingName, 50, convDataNodeFuncMap.AssociationMappingName);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.FuncMapModeId, 2, convDataNodeFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.FuncMapModeName, 50, convDataNodeFuncMap.FuncMapModeName);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.TabId, 8, convDataNodeFuncMap.TabId);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.DnFunctionId, 8, convDataNodeFuncMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.PrjId, 4, convDataNodeFuncMap.PrjId);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.CmPrjId, 6, convDataNodeFuncMap.CmPrjId);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.CmPrjName, 50, convDataNodeFuncMap.CmPrjName);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.UpdDate, 20, convDataNodeFuncMap.UpdDate);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.UpdUser, 20, convDataNodeFuncMap.UpdUser);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.Memo, 1000, convDataNodeFuncMap.Memo);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.InDataNodeName, 100, convDataNodeFuncMap.InDataNodeName);
clsCheckSql.CheckFieldLen(objvDataNodeFuncMapEN.OutDataNodeName, 50, convDataNodeFuncMap.OutDataNodeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.DnFuncMapId, convDataNodeFuncMap.DnFuncMapId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.InDataNodeId, convDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.OutDataNodeId, convDataNodeFuncMap.OutDataNodeId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.AssociationMappingId, convDataNodeFuncMap.AssociationMappingId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.AssociationMappingName, convDataNodeFuncMap.AssociationMappingName);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.FuncMapModeId, convDataNodeFuncMap.FuncMapModeId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.FuncMapModeName, convDataNodeFuncMap.FuncMapModeName);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.TabId, convDataNodeFuncMap.TabId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.DnFunctionId, convDataNodeFuncMap.DnFunctionId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.PrjId, convDataNodeFuncMap.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.CmPrjId, convDataNodeFuncMap.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.CmPrjName, convDataNodeFuncMap.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.UpdDate, convDataNodeFuncMap.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.UpdUser, convDataNodeFuncMap.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.Memo, convDataNodeFuncMap.Memo);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.InDataNodeName, convDataNodeFuncMap.InDataNodeName);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeFuncMapEN.OutDataNodeName, convDataNodeFuncMap.OutDataNodeName);
//检查外键字段长度
 objvDataNodeFuncMapEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--vDataNodeFuncMap(v结点函数映射), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <param name = "strDnFuncMapId">函数映射Id(主键)</param>
 /// <returns></returns>
public bool CheckvDataNodeFuncMapUniqueness(string strDnFuncMapId )
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("DnFuncMapId !=  '{0}'", strDnFuncMapId);
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
}
 /// <summary>
 /// 检查唯一性(Uniqueness)--vDataNodeFuncMap(v结点函数映射), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <returns></returns>
public bool CheckvDataNodeFuncMapUniqueness()
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
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
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
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
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
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
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDataNodeFuncMapEN._CurrTabName);
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
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDataNodeFuncMapEN._CurrTabName, strCondition);
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
 objSQL = clsvDataNodeFuncMapDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}