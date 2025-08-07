
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeFuncMapDA
 表名:DataNodeFuncMap(00050549)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 日期:2023/01/18 16:21:32
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
 /// 结点函数映射(DataNodeFuncMap)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsDataNodeFuncMapDA : clsCommBase4DA
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
 return clsDataNodeFuncMapEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDataNodeFuncMapEN._ConnectStringB)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataNodeFuncMapEN._ConnectStringB);
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
 if (string.IsNullOrEmpty(clsDataNodeFuncMapEN._ConnectStringB)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDataNodeFuncMapEN._ConnectStringB);
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
throw new Exception("(errid:Data000001)在表:DataNodeFuncMap中,检查关键字,长度不正确!(clsDataNodeFuncMapDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DataNodeFuncMap中,关键字不能为空 或 null!(clsDataNodeFuncMapDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFuncMapId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDataNodeFuncMapDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DataNodeFuncMap(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: GetDataTable_DataNodeFuncMap)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeFuncMap where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeFuncMap where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataNodeFuncMap where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataNodeFuncMap where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataNodeFuncMap where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DataNodeFuncMap.* from DataNodeFuncMap Left Join {1} on {2} where {3} and DataNodeFuncMap.DnFuncMapId not in (Select top {5} DataNodeFuncMap.DnFuncMapId from DataNodeFuncMap Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataNodeFuncMap where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from DataNodeFuncMap where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataNodeFuncMap where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from DataNodeFuncMap where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DataNodeFuncMap.* from DataNodeFuncMap Left Join {1} on {2} where {3} and DataNodeFuncMap.DnFuncMapId not in (Select top {5} DataNodeFuncMap.DnFuncMapId from DataNodeFuncMap Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataNodeFuncMap where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from DataNodeFuncMap where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataNodeFuncMap where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from DataNodeFuncMap where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDataNodeFuncMapEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA:GetObjLst)", objException.Message));
}
List<clsDataNodeFuncMapEN> arrObjLst = new List<clsDataNodeFuncMapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeFuncMapEN objDataNodeFuncMapEN = new clsDataNodeFuncMapEN();
try
{
objDataNodeFuncMapEN.DnFuncMapId = objRow[conDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDataNodeFuncMapEN.InDataNodeId = objRow[conDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objDataNodeFuncMapEN.OutDataNodeId = objRow[conDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objDataNodeFuncMapEN.AssociationMappingId = objRow[conDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeFuncMapEN.FuncMapModeId = objRow[conDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeFuncMapEN.TabId = objRow[conDataNodeFuncMap.TabId].ToString().Trim(); //表ID
objDataNodeFuncMapEN.DnFunctionId = objRow[conDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeFuncMapEN.PrjId = objRow[conDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID
objDataNodeFuncMapEN.CmPrjId = objRow[conDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id
objDataNodeFuncMapEN.UpdDate = objRow[conDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeFuncMapEN.UpdUser = objRow[conDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者
objDataNodeFuncMapEN.Memo = objRow[conDataNodeFuncMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataNodeFuncMapDA: GetObjLst)", objException.Message));
}
objDataNodeFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataNodeFuncMapEN);
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
public List<clsDataNodeFuncMapEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA:GetObjLstByTabName)", objException.Message));
}
List<clsDataNodeFuncMapEN> arrObjLst = new List<clsDataNodeFuncMapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeFuncMapEN objDataNodeFuncMapEN = new clsDataNodeFuncMapEN();
try
{
objDataNodeFuncMapEN.DnFuncMapId = objRow[conDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDataNodeFuncMapEN.InDataNodeId = objRow[conDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objDataNodeFuncMapEN.OutDataNodeId = objRow[conDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objDataNodeFuncMapEN.AssociationMappingId = objRow[conDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeFuncMapEN.FuncMapModeId = objRow[conDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeFuncMapEN.TabId = objRow[conDataNodeFuncMap.TabId].ToString().Trim(); //表ID
objDataNodeFuncMapEN.DnFunctionId = objRow[conDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeFuncMapEN.PrjId = objRow[conDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID
objDataNodeFuncMapEN.CmPrjId = objRow[conDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id
objDataNodeFuncMapEN.UpdDate = objRow[conDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeFuncMapEN.UpdUser = objRow[conDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者
objDataNodeFuncMapEN.Memo = objRow[conDataNodeFuncMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataNodeFuncMapDA: GetObjLst)", objException.Message));
}
objDataNodeFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataNodeFuncMapEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDataNodeFuncMap(ref clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeFuncMap where DnFuncMapId = " + "'"+ objDataNodeFuncMapEN.DnFuncMapId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDataNodeFuncMapEN.DnFuncMapId = objDT.Rows[0][conDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objDataNodeFuncMapEN.InDataNodeId = objDT.Rows[0][conDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id(字段类型:char,字段长度:8,是否可空:True)
 objDataNodeFuncMapEN.OutDataNodeId = objDT.Rows[0][conDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id(字段类型:char,字段长度:8,是否可空:True)
 objDataNodeFuncMapEN.AssociationMappingId = objDT.Rows[0][conDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objDataNodeFuncMapEN.FuncMapModeId = objDT.Rows[0][conDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objDataNodeFuncMapEN.TabId = objDT.Rows[0][conDataNodeFuncMap.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objDataNodeFuncMapEN.DnFunctionId = objDT.Rows[0][conDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objDataNodeFuncMapEN.PrjId = objDT.Rows[0][conDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objDataNodeFuncMapEN.CmPrjId = objDT.Rows[0][conDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objDataNodeFuncMapEN.UpdDate = objDT.Rows[0][conDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeFuncMapEN.UpdUser = objDT.Rows[0][conDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeFuncMapEN.Memo = objDT.Rows[0][conDataNodeFuncMap.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDataNodeFuncMapDA: GetDataNodeFuncMap)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public clsDataNodeFuncMapEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
CheckPrimaryKey(strDnFuncMapId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeFuncMap where DnFuncMapId = " + "'"+ strDnFuncMapId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDataNodeFuncMapEN objDataNodeFuncMapEN = new clsDataNodeFuncMapEN();
try
{
 objDataNodeFuncMapEN.DnFuncMapId = objRow[conDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objDataNodeFuncMapEN.InDataNodeId = objRow[conDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id(字段类型:char,字段长度:8,是否可空:True)
 objDataNodeFuncMapEN.OutDataNodeId = objRow[conDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id(字段类型:char,字段长度:8,是否可空:True)
 objDataNodeFuncMapEN.AssociationMappingId = objRow[conDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objDataNodeFuncMapEN.FuncMapModeId = objRow[conDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objDataNodeFuncMapEN.TabId = objRow[conDataNodeFuncMap.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objDataNodeFuncMapEN.DnFunctionId = objRow[conDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objDataNodeFuncMapEN.PrjId = objRow[conDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objDataNodeFuncMapEN.CmPrjId = objRow[conDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objDataNodeFuncMapEN.UpdDate = objRow[conDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeFuncMapEN.UpdUser = objRow[conDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeFuncMapEN.Memo = objRow[conDataNodeFuncMap.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDataNodeFuncMapDA: GetObjByDnFuncMapId)", objException.Message));
}
return objDataNodeFuncMapEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDataNodeFuncMapEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeFuncMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDataNodeFuncMapEN objDataNodeFuncMapEN = new clsDataNodeFuncMapEN()
{
DnFuncMapId = objRow[conDataNodeFuncMap.DnFuncMapId].ToString().Trim(), //函数映射Id
InDataNodeId = objRow[conDataNodeFuncMap.InDataNodeId].ToString().Trim(), //In数据结点Id
OutDataNodeId = objRow[conDataNodeFuncMap.OutDataNodeId].ToString().Trim(), //Out数据结点Id
AssociationMappingId = objRow[conDataNodeFuncMap.AssociationMappingId].ToString().Trim(), //关联关系映射Id
FuncMapModeId = objRow[conDataNodeFuncMap.FuncMapModeId].ToString().Trim(), //函数映射模式Id
TabId = objRow[conDataNodeFuncMap.TabId].ToString().Trim(), //表ID
DnFunctionId = objRow[conDataNodeFuncMap.DnFunctionId].ToString().Trim(), //DN函数Id
PrjId = objRow[conDataNodeFuncMap.PrjId].ToString().Trim(), //工程ID
CmPrjId = objRow[conDataNodeFuncMap.CmPrjId].ToString().Trim(), //CM工程Id
UpdDate = objRow[conDataNodeFuncMap.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDataNodeFuncMap.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDataNodeFuncMap.Memo].ToString().Trim() //说明
};
objDataNodeFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataNodeFuncMapEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDataNodeFuncMapDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDataNodeFuncMapEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataNodeFuncMapEN objDataNodeFuncMapEN = new clsDataNodeFuncMapEN();
try
{
objDataNodeFuncMapEN.DnFuncMapId = objRow[conDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDataNodeFuncMapEN.InDataNodeId = objRow[conDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objDataNodeFuncMapEN.OutDataNodeId = objRow[conDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objDataNodeFuncMapEN.AssociationMappingId = objRow[conDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeFuncMapEN.FuncMapModeId = objRow[conDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeFuncMapEN.TabId = objRow[conDataNodeFuncMap.TabId].ToString().Trim(); //表ID
objDataNodeFuncMapEN.DnFunctionId = objRow[conDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeFuncMapEN.PrjId = objRow[conDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID
objDataNodeFuncMapEN.CmPrjId = objRow[conDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id
objDataNodeFuncMapEN.UpdDate = objRow[conDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeFuncMapEN.UpdUser = objRow[conDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者
objDataNodeFuncMapEN.Memo = objRow[conDataNodeFuncMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDataNodeFuncMapDA: GetObjByDataRowDataNodeFuncMap)", objException.Message));
}
objDataNodeFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataNodeFuncMapEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDataNodeFuncMapEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataNodeFuncMapEN objDataNodeFuncMapEN = new clsDataNodeFuncMapEN();
try
{
objDataNodeFuncMapEN.DnFuncMapId = objRow[conDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDataNodeFuncMapEN.InDataNodeId = objRow[conDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objDataNodeFuncMapEN.OutDataNodeId = objRow[conDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objDataNodeFuncMapEN.AssociationMappingId = objRow[conDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeFuncMapEN.FuncMapModeId = objRow[conDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeFuncMapEN.TabId = objRow[conDataNodeFuncMap.TabId].ToString().Trim(); //表ID
objDataNodeFuncMapEN.DnFunctionId = objRow[conDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeFuncMapEN.PrjId = objRow[conDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID
objDataNodeFuncMapEN.CmPrjId = objRow[conDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id
objDataNodeFuncMapEN.UpdDate = objRow[conDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeFuncMapEN.UpdUser = objRow[conDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者
objDataNodeFuncMapEN.Memo = objRow[conDataNodeFuncMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDataNodeFuncMapDA: GetObjByDataRow)", objException.Message));
}
objDataNodeFuncMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataNodeFuncMapEN;
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
objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataNodeFuncMapEN._CurrTabName, conDataNodeFuncMap.DnFuncMapId, 8, "");
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
objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataNodeFuncMapEN._CurrTabName, conDataNodeFuncMap.DnFuncMapId, 8, strPrefix);
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
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DnFuncMapId from DataNodeFuncMap where " + strCondition;
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
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DnFuncMapId from DataNodeFuncMap where " + strCondition;
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
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataNodeFuncMap", "DnFuncMapId = " + "'"+ strDnFuncMapId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataNodeFuncMap", strCondition))
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
objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DataNodeFuncMap");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
 {
 objDataNodeFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeFuncMapEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeFuncMap where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataNodeFuncMap");
objRow = objDS.Tables["DataNodeFuncMap"].NewRow();
objRow[conDataNodeFuncMap.DnFuncMapId] = objDataNodeFuncMapEN.DnFuncMapId; //函数映射Id
objRow[conDataNodeFuncMap.InDataNodeId] = objDataNodeFuncMapEN.InDataNodeId; //In数据结点Id
objRow[conDataNodeFuncMap.OutDataNodeId] = objDataNodeFuncMapEN.OutDataNodeId; //Out数据结点Id
objRow[conDataNodeFuncMap.AssociationMappingId] = objDataNodeFuncMapEN.AssociationMappingId; //关联关系映射Id
objRow[conDataNodeFuncMap.FuncMapModeId] = objDataNodeFuncMapEN.FuncMapModeId; //函数映射模式Id
 if (objDataNodeFuncMapEN.TabId !=  "")
 {
objRow[conDataNodeFuncMap.TabId] = objDataNodeFuncMapEN.TabId; //表ID
 }
 if (objDataNodeFuncMapEN.DnFunctionId !=  "")
 {
objRow[conDataNodeFuncMap.DnFunctionId] = objDataNodeFuncMapEN.DnFunctionId; //DN函数Id
 }
objRow[conDataNodeFuncMap.PrjId] = objDataNodeFuncMapEN.PrjId; //工程ID
objRow[conDataNodeFuncMap.CmPrjId] = objDataNodeFuncMapEN.CmPrjId; //CM工程Id
 if (objDataNodeFuncMapEN.UpdDate !=  "")
 {
objRow[conDataNodeFuncMap.UpdDate] = objDataNodeFuncMapEN.UpdDate; //修改日期
 }
 if (objDataNodeFuncMapEN.UpdUser !=  "")
 {
objRow[conDataNodeFuncMap.UpdUser] = objDataNodeFuncMapEN.UpdUser; //修改者
 }
 if (objDataNodeFuncMapEN.Memo !=  "")
 {
objRow[conDataNodeFuncMap.Memo] = objDataNodeFuncMapEN.Memo; //说明
 }
objDS.Tables[clsDataNodeFuncMapEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDataNodeFuncMapEN._CurrTabName);
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
 /// <param name = "objDataNodeFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
 objDataNodeFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeFuncMapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataNodeFuncMapEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.DnFuncMapId);
 objDataNodeFuncMapEN.DnFuncMapId = objDataNodeFuncMapEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.DnFuncMapId + "'");
 }
 
 if (objDataNodeFuncMapEN.InDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.InDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.InDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.InDataNodeId);
 objDataNodeFuncMapEN.InDataNodeId = objDataNodeFuncMapEN.InDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.InDataNodeId + "'");
 }
 
 if (objDataNodeFuncMapEN.OutDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.OutDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.OutDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.OutDataNodeId);
 objDataNodeFuncMapEN.OutDataNodeId = objDataNodeFuncMapEN.OutDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.OutDataNodeId + "'");
 }
 
 if (objDataNodeFuncMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.AssociationMappingId);
 objDataNodeFuncMapEN.AssociationMappingId = objDataNodeFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.AssociationMappingId + "'");
 }
 
 if (objDataNodeFuncMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.FuncMapModeId);
 objDataNodeFuncMapEN.FuncMapModeId = objDataNodeFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.FuncMapModeId + "'");
 }
 
 if (objDataNodeFuncMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.TabId);
 objDataNodeFuncMapEN.TabId = objDataNodeFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.TabId + "'");
 }
 
 if (objDataNodeFuncMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.DnFunctionId);
 objDataNodeFuncMapEN.DnFunctionId = objDataNodeFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.DnFunctionId + "'");
 }
 
 if (objDataNodeFuncMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.PrjId);
 objDataNodeFuncMapEN.PrjId = objDataNodeFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.PrjId + "'");
 }
 
 if (objDataNodeFuncMapEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.CmPrjId);
 objDataNodeFuncMapEN.CmPrjId = objDataNodeFuncMapEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.CmPrjId + "'");
 }
 
 if (objDataNodeFuncMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.UpdDate);
 objDataNodeFuncMapEN.UpdDate = objDataNodeFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.UpdDate + "'");
 }
 
 if (objDataNodeFuncMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.UpdUser);
 objDataNodeFuncMapEN.UpdUser = objDataNodeFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.UpdUser + "'");
 }
 
 if (objDataNodeFuncMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.Memo);
 objDataNodeFuncMapEN.Memo = objDataNodeFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNodeFuncMap");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
 objDataNodeFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeFuncMapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataNodeFuncMapEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.DnFuncMapId);
 objDataNodeFuncMapEN.DnFuncMapId = objDataNodeFuncMapEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.DnFuncMapId + "'");
 }
 
 if (objDataNodeFuncMapEN.InDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.InDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.InDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.InDataNodeId);
 objDataNodeFuncMapEN.InDataNodeId = objDataNodeFuncMapEN.InDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.InDataNodeId + "'");
 }
 
 if (objDataNodeFuncMapEN.OutDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.OutDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.OutDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.OutDataNodeId);
 objDataNodeFuncMapEN.OutDataNodeId = objDataNodeFuncMapEN.OutDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.OutDataNodeId + "'");
 }
 
 if (objDataNodeFuncMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.AssociationMappingId);
 objDataNodeFuncMapEN.AssociationMappingId = objDataNodeFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.AssociationMappingId + "'");
 }
 
 if (objDataNodeFuncMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.FuncMapModeId);
 objDataNodeFuncMapEN.FuncMapModeId = objDataNodeFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.FuncMapModeId + "'");
 }
 
 if (objDataNodeFuncMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.TabId);
 objDataNodeFuncMapEN.TabId = objDataNodeFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.TabId + "'");
 }
 
 if (objDataNodeFuncMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.DnFunctionId);
 objDataNodeFuncMapEN.DnFunctionId = objDataNodeFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.DnFunctionId + "'");
 }
 
 if (objDataNodeFuncMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.PrjId);
 objDataNodeFuncMapEN.PrjId = objDataNodeFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.PrjId + "'");
 }
 
 if (objDataNodeFuncMapEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.CmPrjId);
 objDataNodeFuncMapEN.CmPrjId = objDataNodeFuncMapEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.CmPrjId + "'");
 }
 
 if (objDataNodeFuncMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.UpdDate);
 objDataNodeFuncMapEN.UpdDate = objDataNodeFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.UpdDate + "'");
 }
 
 if (objDataNodeFuncMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.UpdUser);
 objDataNodeFuncMapEN.UpdUser = objDataNodeFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.UpdUser + "'");
 }
 
 if (objDataNodeFuncMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.Memo);
 objDataNodeFuncMapEN.Memo = objDataNodeFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNodeFuncMap");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDataNodeFuncMapEN.DnFuncMapId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataNodeFuncMapEN objDataNodeFuncMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDataNodeFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeFuncMapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataNodeFuncMapEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.DnFuncMapId);
 objDataNodeFuncMapEN.DnFuncMapId = objDataNodeFuncMapEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.DnFuncMapId + "'");
 }
 
 if (objDataNodeFuncMapEN.InDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.InDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.InDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.InDataNodeId);
 objDataNodeFuncMapEN.InDataNodeId = objDataNodeFuncMapEN.InDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.InDataNodeId + "'");
 }
 
 if (objDataNodeFuncMapEN.OutDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.OutDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.OutDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.OutDataNodeId);
 objDataNodeFuncMapEN.OutDataNodeId = objDataNodeFuncMapEN.OutDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.OutDataNodeId + "'");
 }
 
 if (objDataNodeFuncMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.AssociationMappingId);
 objDataNodeFuncMapEN.AssociationMappingId = objDataNodeFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.AssociationMappingId + "'");
 }
 
 if (objDataNodeFuncMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.FuncMapModeId);
 objDataNodeFuncMapEN.FuncMapModeId = objDataNodeFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.FuncMapModeId + "'");
 }
 
 if (objDataNodeFuncMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.TabId);
 objDataNodeFuncMapEN.TabId = objDataNodeFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.TabId + "'");
 }
 
 if (objDataNodeFuncMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.DnFunctionId);
 objDataNodeFuncMapEN.DnFunctionId = objDataNodeFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.DnFunctionId + "'");
 }
 
 if (objDataNodeFuncMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.PrjId);
 objDataNodeFuncMapEN.PrjId = objDataNodeFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.PrjId + "'");
 }
 
 if (objDataNodeFuncMapEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.CmPrjId);
 objDataNodeFuncMapEN.CmPrjId = objDataNodeFuncMapEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.CmPrjId + "'");
 }
 
 if (objDataNodeFuncMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.UpdDate);
 objDataNodeFuncMapEN.UpdDate = objDataNodeFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.UpdDate + "'");
 }
 
 if (objDataNodeFuncMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.UpdUser);
 objDataNodeFuncMapEN.UpdUser = objDataNodeFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.UpdUser + "'");
 }
 
 if (objDataNodeFuncMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.Memo);
 objDataNodeFuncMapEN.Memo = objDataNodeFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNodeFuncMap");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDataNodeFuncMapEN.DnFuncMapId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataNodeFuncMapEN objDataNodeFuncMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDataNodeFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeFuncMapEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataNodeFuncMapEN.DnFuncMapId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.DnFuncMapId);
 objDataNodeFuncMapEN.DnFuncMapId = objDataNodeFuncMapEN.DnFuncMapId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.DnFuncMapId + "'");
 }
 
 if (objDataNodeFuncMapEN.InDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.InDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.InDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.InDataNodeId);
 objDataNodeFuncMapEN.InDataNodeId = objDataNodeFuncMapEN.InDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.InDataNodeId + "'");
 }
 
 if (objDataNodeFuncMapEN.OutDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.OutDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.OutDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.OutDataNodeId);
 objDataNodeFuncMapEN.OutDataNodeId = objDataNodeFuncMapEN.OutDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.OutDataNodeId + "'");
 }
 
 if (objDataNodeFuncMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.AssociationMappingId);
 objDataNodeFuncMapEN.AssociationMappingId = objDataNodeFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.AssociationMappingId + "'");
 }
 
 if (objDataNodeFuncMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.FuncMapModeId);
 objDataNodeFuncMapEN.FuncMapModeId = objDataNodeFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.FuncMapModeId + "'");
 }
 
 if (objDataNodeFuncMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.TabId);
 objDataNodeFuncMapEN.TabId = objDataNodeFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.TabId + "'");
 }
 
 if (objDataNodeFuncMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.DnFunctionId);
 objDataNodeFuncMapEN.DnFunctionId = objDataNodeFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.DnFunctionId + "'");
 }
 
 if (objDataNodeFuncMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.PrjId);
 objDataNodeFuncMapEN.PrjId = objDataNodeFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.PrjId + "'");
 }
 
 if (objDataNodeFuncMapEN.CmPrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.CmPrjId);
 objDataNodeFuncMapEN.CmPrjId = objDataNodeFuncMapEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.CmPrjId + "'");
 }
 
 if (objDataNodeFuncMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.UpdDate);
 objDataNodeFuncMapEN.UpdDate = objDataNodeFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.UpdDate + "'");
 }
 
 if (objDataNodeFuncMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.UpdUser);
 objDataNodeFuncMapEN.UpdUser = objDataNodeFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.UpdUser + "'");
 }
 
 if (objDataNodeFuncMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeFuncMap.Memo);
 objDataNodeFuncMapEN.Memo = objDataNodeFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataNodeFuncMapEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNodeFuncMap");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDataNodeFuncMaps(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeFuncMap where DnFuncMapId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataNodeFuncMap");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDnFuncMapId = oRow[conDataNodeFuncMap.DnFuncMapId].ToString().Trim();
if (IsExist(strDnFuncMapId))
{
 string strResult = "关键字变量值为:" + string.Format("DnFuncMapId = {0}", strDnFuncMapId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDataNodeFuncMapEN._CurrTabName ].NewRow();
objRow[conDataNodeFuncMap.DnFuncMapId] = oRow[conDataNodeFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objRow[conDataNodeFuncMap.InDataNodeId] = oRow[conDataNodeFuncMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objRow[conDataNodeFuncMap.OutDataNodeId] = oRow[conDataNodeFuncMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objRow[conDataNodeFuncMap.AssociationMappingId] = oRow[conDataNodeFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objRow[conDataNodeFuncMap.FuncMapModeId] = oRow[conDataNodeFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objRow[conDataNodeFuncMap.TabId] = oRow[conDataNodeFuncMap.TabId].ToString().Trim(); //表ID
objRow[conDataNodeFuncMap.DnFunctionId] = oRow[conDataNodeFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objRow[conDataNodeFuncMap.PrjId] = oRow[conDataNodeFuncMap.PrjId].ToString().Trim(); //工程ID
objRow[conDataNodeFuncMap.CmPrjId] = oRow[conDataNodeFuncMap.CmPrjId].ToString().Trim(); //CM工程Id
objRow[conDataNodeFuncMap.UpdDate] = oRow[conDataNodeFuncMap.UpdDate].ToString().Trim(); //修改日期
objRow[conDataNodeFuncMap.UpdUser] = oRow[conDataNodeFuncMap.UpdUser].ToString().Trim(); //修改者
objRow[conDataNodeFuncMap.Memo] = oRow[conDataNodeFuncMap.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDataNodeFuncMapEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDataNodeFuncMapEN._CurrTabName);
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
 /// <param name = "objDataNodeFuncMapEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
 objDataNodeFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeFuncMapEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeFuncMap where DnFuncMapId = " + "'"+ objDataNodeFuncMapEN.DnFuncMapId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDataNodeFuncMapEN._CurrTabName);
if (objDS.Tables[clsDataNodeFuncMapEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DnFuncMapId = " + "'"+ objDataNodeFuncMapEN.DnFuncMapId+"'");
return false;
}
objRow = objDS.Tables[clsDataNodeFuncMapEN._CurrTabName].Rows[0];
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.DnFuncMapId))
 {
objRow[conDataNodeFuncMap.DnFuncMapId] = objDataNodeFuncMapEN.DnFuncMapId; //函数映射Id
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.InDataNodeId))
 {
objRow[conDataNodeFuncMap.InDataNodeId] = objDataNodeFuncMapEN.InDataNodeId; //In数据结点Id
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.OutDataNodeId))
 {
objRow[conDataNodeFuncMap.OutDataNodeId] = objDataNodeFuncMapEN.OutDataNodeId; //Out数据结点Id
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.AssociationMappingId))
 {
objRow[conDataNodeFuncMap.AssociationMappingId] = objDataNodeFuncMapEN.AssociationMappingId; //关联关系映射Id
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.FuncMapModeId))
 {
objRow[conDataNodeFuncMap.FuncMapModeId] = objDataNodeFuncMapEN.FuncMapModeId; //函数映射模式Id
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.TabId))
 {
objRow[conDataNodeFuncMap.TabId] = objDataNodeFuncMapEN.TabId; //表ID
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.DnFunctionId))
 {
objRow[conDataNodeFuncMap.DnFunctionId] = objDataNodeFuncMapEN.DnFunctionId; //DN函数Id
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.PrjId))
 {
objRow[conDataNodeFuncMap.PrjId] = objDataNodeFuncMapEN.PrjId; //工程ID
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.CmPrjId))
 {
objRow[conDataNodeFuncMap.CmPrjId] = objDataNodeFuncMapEN.CmPrjId; //CM工程Id
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.UpdDate))
 {
objRow[conDataNodeFuncMap.UpdDate] = objDataNodeFuncMapEN.UpdDate; //修改日期
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.UpdUser))
 {
objRow[conDataNodeFuncMap.UpdUser] = objDataNodeFuncMapEN.UpdUser; //修改者
 }
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.Memo))
 {
objRow[conDataNodeFuncMap.Memo] = objDataNodeFuncMapEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDataNodeFuncMapEN._CurrTabName);
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
 /// <param name = "objDataNodeFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
 objDataNodeFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeFuncMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DataNodeFuncMap Set ");
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.InDataNodeId))
 {
 if (objDataNodeFuncMapEN.InDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.InDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.InDataNodeId !=  null)
 {
 objDataNodeFuncMapEN.InDataNodeId = objDataNodeFuncMapEN.InDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.InDataNodeId, conDataNodeFuncMap.InDataNodeId); //In数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.InDataNodeId); //In数据结点Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.OutDataNodeId))
 {
 if (objDataNodeFuncMapEN.OutDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.OutDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.OutDataNodeId !=  null)
 {
 objDataNodeFuncMapEN.OutDataNodeId = objDataNodeFuncMapEN.OutDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.OutDataNodeId, conDataNodeFuncMap.OutDataNodeId); //Out数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.OutDataNodeId); //Out数据结点Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.AssociationMappingId))
 {
 if (objDataNodeFuncMapEN.AssociationMappingId !=  null)
 {
 objDataNodeFuncMapEN.AssociationMappingId = objDataNodeFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.AssociationMappingId, conDataNodeFuncMap.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.AssociationMappingId); //关联关系映射Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.FuncMapModeId))
 {
 if (objDataNodeFuncMapEN.FuncMapModeId !=  null)
 {
 objDataNodeFuncMapEN.FuncMapModeId = objDataNodeFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.FuncMapModeId, conDataNodeFuncMap.FuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.FuncMapModeId); //函数映射模式Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.TabId))
 {
 if (objDataNodeFuncMapEN.TabId !=  null)
 {
 objDataNodeFuncMapEN.TabId = objDataNodeFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.TabId, conDataNodeFuncMap.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.TabId); //表ID
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.DnFunctionId))
 {
 if (objDataNodeFuncMapEN.DnFunctionId !=  null)
 {
 objDataNodeFuncMapEN.DnFunctionId = objDataNodeFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.DnFunctionId, conDataNodeFuncMap.DnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.DnFunctionId); //DN函数Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.PrjId))
 {
 if (objDataNodeFuncMapEN.PrjId !=  null)
 {
 objDataNodeFuncMapEN.PrjId = objDataNodeFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.PrjId, conDataNodeFuncMap.PrjId); //工程ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.PrjId); //工程ID
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.CmPrjId))
 {
 if (objDataNodeFuncMapEN.CmPrjId !=  null)
 {
 objDataNodeFuncMapEN.CmPrjId = objDataNodeFuncMapEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.CmPrjId, conDataNodeFuncMap.CmPrjId); //CM工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.CmPrjId); //CM工程Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.UpdDate))
 {
 if (objDataNodeFuncMapEN.UpdDate !=  null)
 {
 objDataNodeFuncMapEN.UpdDate = objDataNodeFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.UpdDate, conDataNodeFuncMap.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.UpdDate); //修改日期
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.UpdUser))
 {
 if (objDataNodeFuncMapEN.UpdUser !=  null)
 {
 objDataNodeFuncMapEN.UpdUser = objDataNodeFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.UpdUser, conDataNodeFuncMap.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.UpdUser); //修改者
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.Memo))
 {
 if (objDataNodeFuncMapEN.Memo !=  null)
 {
 objDataNodeFuncMapEN.Memo = objDataNodeFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.Memo, conDataNodeFuncMap.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DnFuncMapId = '{0}'", objDataNodeFuncMapEN.DnFuncMapId); 
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
 /// <param name = "objDataNodeFuncMapEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strCondition)
{
 objDataNodeFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeFuncMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataNodeFuncMap Set ");
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.InDataNodeId))
 {
 if (objDataNodeFuncMapEN.InDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.InDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.InDataNodeId !=  null)
 {
 objDataNodeFuncMapEN.InDataNodeId = objDataNodeFuncMapEN.InDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InDataNodeId = '{0}',", objDataNodeFuncMapEN.InDataNodeId); //In数据结点Id
 }
 else
 {
 sbSQL.Append(" InDataNodeId = null,"); //In数据结点Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.OutDataNodeId))
 {
 if (objDataNodeFuncMapEN.OutDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.OutDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.OutDataNodeId !=  null)
 {
 objDataNodeFuncMapEN.OutDataNodeId = objDataNodeFuncMapEN.OutDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutDataNodeId = '{0}',", objDataNodeFuncMapEN.OutDataNodeId); //Out数据结点Id
 }
 else
 {
 sbSQL.Append(" OutDataNodeId = null,"); //Out数据结点Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.AssociationMappingId))
 {
 if (objDataNodeFuncMapEN.AssociationMappingId !=  null)
 {
 objDataNodeFuncMapEN.AssociationMappingId = objDataNodeFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationMappingId = '{0}',", objDataNodeFuncMapEN.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.Append(" AssociationMappingId = null,"); //关联关系映射Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.FuncMapModeId))
 {
 if (objDataNodeFuncMapEN.FuncMapModeId !=  null)
 {
 objDataNodeFuncMapEN.FuncMapModeId = objDataNodeFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncMapModeId = '{0}',", objDataNodeFuncMapEN.FuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.Append(" FuncMapModeId = null,"); //函数映射模式Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.TabId))
 {
 if (objDataNodeFuncMapEN.TabId !=  null)
 {
 objDataNodeFuncMapEN.TabId = objDataNodeFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", objDataNodeFuncMapEN.TabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.DnFunctionId))
 {
 if (objDataNodeFuncMapEN.DnFunctionId !=  null)
 {
 objDataNodeFuncMapEN.DnFunctionId = objDataNodeFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnFunctionId = '{0}',", objDataNodeFuncMapEN.DnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.Append(" DnFunctionId = null,"); //DN函数Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.PrjId))
 {
 if (objDataNodeFuncMapEN.PrjId !=  null)
 {
 objDataNodeFuncMapEN.PrjId = objDataNodeFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", objDataNodeFuncMapEN.PrjId); //工程ID
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程ID
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.CmPrjId))
 {
 if (objDataNodeFuncMapEN.CmPrjId !=  null)
 {
 objDataNodeFuncMapEN.CmPrjId = objDataNodeFuncMapEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjId = '{0}',", objDataNodeFuncMapEN.CmPrjId); //CM工程Id
 }
 else
 {
 sbSQL.Append(" CmPrjId = null,"); //CM工程Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.UpdDate))
 {
 if (objDataNodeFuncMapEN.UpdDate !=  null)
 {
 objDataNodeFuncMapEN.UpdDate = objDataNodeFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objDataNodeFuncMapEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.UpdUser))
 {
 if (objDataNodeFuncMapEN.UpdUser !=  null)
 {
 objDataNodeFuncMapEN.UpdUser = objDataNodeFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objDataNodeFuncMapEN.UpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.Memo))
 {
 if (objDataNodeFuncMapEN.Memo !=  null)
 {
 objDataNodeFuncMapEN.Memo = objDataNodeFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objDataNodeFuncMapEN.Memo); //说明
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
 /// <param name = "objDataNodeFuncMapEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDataNodeFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeFuncMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataNodeFuncMap Set ");
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.InDataNodeId))
 {
 if (objDataNodeFuncMapEN.InDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.InDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.InDataNodeId !=  null)
 {
 objDataNodeFuncMapEN.InDataNodeId = objDataNodeFuncMapEN.InDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InDataNodeId = '{0}',", objDataNodeFuncMapEN.InDataNodeId); //In数据结点Id
 }
 else
 {
 sbSQL.Append(" InDataNodeId = null,"); //In数据结点Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.OutDataNodeId))
 {
 if (objDataNodeFuncMapEN.OutDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.OutDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.OutDataNodeId !=  null)
 {
 objDataNodeFuncMapEN.OutDataNodeId = objDataNodeFuncMapEN.OutDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutDataNodeId = '{0}',", objDataNodeFuncMapEN.OutDataNodeId); //Out数据结点Id
 }
 else
 {
 sbSQL.Append(" OutDataNodeId = null,"); //Out数据结点Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.AssociationMappingId))
 {
 if (objDataNodeFuncMapEN.AssociationMappingId !=  null)
 {
 objDataNodeFuncMapEN.AssociationMappingId = objDataNodeFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationMappingId = '{0}',", objDataNodeFuncMapEN.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.Append(" AssociationMappingId = null,"); //关联关系映射Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.FuncMapModeId))
 {
 if (objDataNodeFuncMapEN.FuncMapModeId !=  null)
 {
 objDataNodeFuncMapEN.FuncMapModeId = objDataNodeFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncMapModeId = '{0}',", objDataNodeFuncMapEN.FuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.Append(" FuncMapModeId = null,"); //函数映射模式Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.TabId))
 {
 if (objDataNodeFuncMapEN.TabId !=  null)
 {
 objDataNodeFuncMapEN.TabId = objDataNodeFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", objDataNodeFuncMapEN.TabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.DnFunctionId))
 {
 if (objDataNodeFuncMapEN.DnFunctionId !=  null)
 {
 objDataNodeFuncMapEN.DnFunctionId = objDataNodeFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnFunctionId = '{0}',", objDataNodeFuncMapEN.DnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.Append(" DnFunctionId = null,"); //DN函数Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.PrjId))
 {
 if (objDataNodeFuncMapEN.PrjId !=  null)
 {
 objDataNodeFuncMapEN.PrjId = objDataNodeFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", objDataNodeFuncMapEN.PrjId); //工程ID
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程ID
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.CmPrjId))
 {
 if (objDataNodeFuncMapEN.CmPrjId !=  null)
 {
 objDataNodeFuncMapEN.CmPrjId = objDataNodeFuncMapEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmPrjId = '{0}',", objDataNodeFuncMapEN.CmPrjId); //CM工程Id
 }
 else
 {
 sbSQL.Append(" CmPrjId = null,"); //CM工程Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.UpdDate))
 {
 if (objDataNodeFuncMapEN.UpdDate !=  null)
 {
 objDataNodeFuncMapEN.UpdDate = objDataNodeFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objDataNodeFuncMapEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.UpdUser))
 {
 if (objDataNodeFuncMapEN.UpdUser !=  null)
 {
 objDataNodeFuncMapEN.UpdUser = objDataNodeFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objDataNodeFuncMapEN.UpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.Memo))
 {
 if (objDataNodeFuncMapEN.Memo !=  null)
 {
 objDataNodeFuncMapEN.Memo = objDataNodeFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objDataNodeFuncMapEN.Memo); //说明
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
 /// <param name = "objDataNodeFuncMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataNodeFuncMapEN objDataNodeFuncMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDataNodeFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeFuncMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeFuncMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataNodeFuncMap Set ");
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.InDataNodeId))
 {
 if (objDataNodeFuncMapEN.InDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.InDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.InDataNodeId !=  null)
 {
 objDataNodeFuncMapEN.InDataNodeId = objDataNodeFuncMapEN.InDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.InDataNodeId, conDataNodeFuncMap.InDataNodeId); //In数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.InDataNodeId); //In数据结点Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.OutDataNodeId))
 {
 if (objDataNodeFuncMapEN.OutDataNodeId  ==  "")
 {
 objDataNodeFuncMapEN.OutDataNodeId = null;
 }
 if (objDataNodeFuncMapEN.OutDataNodeId !=  null)
 {
 objDataNodeFuncMapEN.OutDataNodeId = objDataNodeFuncMapEN.OutDataNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.OutDataNodeId, conDataNodeFuncMap.OutDataNodeId); //Out数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.OutDataNodeId); //Out数据结点Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.AssociationMappingId))
 {
 if (objDataNodeFuncMapEN.AssociationMappingId !=  null)
 {
 objDataNodeFuncMapEN.AssociationMappingId = objDataNodeFuncMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.AssociationMappingId, conDataNodeFuncMap.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.AssociationMappingId); //关联关系映射Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.FuncMapModeId))
 {
 if (objDataNodeFuncMapEN.FuncMapModeId !=  null)
 {
 objDataNodeFuncMapEN.FuncMapModeId = objDataNodeFuncMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.FuncMapModeId, conDataNodeFuncMap.FuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.FuncMapModeId); //函数映射模式Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.TabId))
 {
 if (objDataNodeFuncMapEN.TabId !=  null)
 {
 objDataNodeFuncMapEN.TabId = objDataNodeFuncMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.TabId, conDataNodeFuncMap.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.TabId); //表ID
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.DnFunctionId))
 {
 if (objDataNodeFuncMapEN.DnFunctionId !=  null)
 {
 objDataNodeFuncMapEN.DnFunctionId = objDataNodeFuncMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.DnFunctionId, conDataNodeFuncMap.DnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.DnFunctionId); //DN函数Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.PrjId))
 {
 if (objDataNodeFuncMapEN.PrjId !=  null)
 {
 objDataNodeFuncMapEN.PrjId = objDataNodeFuncMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.PrjId, conDataNodeFuncMap.PrjId); //工程ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.PrjId); //工程ID
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.CmPrjId))
 {
 if (objDataNodeFuncMapEN.CmPrjId !=  null)
 {
 objDataNodeFuncMapEN.CmPrjId = objDataNodeFuncMapEN.CmPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.CmPrjId, conDataNodeFuncMap.CmPrjId); //CM工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.CmPrjId); //CM工程Id
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.UpdDate))
 {
 if (objDataNodeFuncMapEN.UpdDate !=  null)
 {
 objDataNodeFuncMapEN.UpdDate = objDataNodeFuncMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.UpdDate, conDataNodeFuncMap.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.UpdDate); //修改日期
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.UpdUser))
 {
 if (objDataNodeFuncMapEN.UpdUser !=  null)
 {
 objDataNodeFuncMapEN.UpdUser = objDataNodeFuncMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.UpdUser, conDataNodeFuncMap.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.UpdUser); //修改者
 }
 }
 
 if (objDataNodeFuncMapEN.IsUpdated(conDataNodeFuncMap.Memo))
 {
 if (objDataNodeFuncMapEN.Memo !=  null)
 {
 objDataNodeFuncMapEN.Memo = objDataNodeFuncMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataNodeFuncMapEN.Memo, conDataNodeFuncMap.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeFuncMap.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DnFuncMapId = '{0}'", objDataNodeFuncMapEN.DnFuncMapId); 
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
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDnFuncMapId) 
{
CheckPrimaryKey(strDnFuncMapId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDnFuncMapId,
};
 objSQL.ExecSP("DataNodeFuncMap_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDnFuncMapId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDnFuncMapId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
//删除DataNodeFuncMap本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataNodeFuncMap where DnFuncMapId = " + "'"+ strDnFuncMapId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDataNodeFuncMap(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
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
//删除DataNodeFuncMap本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataNodeFuncMap where DnFuncMapId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDnFuncMapId) 
{
CheckPrimaryKey(strDnFuncMapId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
//删除DataNodeFuncMap本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataNodeFuncMap where DnFuncMapId = " + "'"+ strDnFuncMapId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDataNodeFuncMap(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: DelDataNodeFuncMap)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataNodeFuncMap where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelDataNodeFuncMapWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDataNodeFuncMapDA: DelDataNodeFuncMapWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataNodeFuncMap where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objDataNodeFuncMapENS">源对象</param>
 /// <param name = "objDataNodeFuncMapENT">目标对象</param>
public void CopyTo(clsDataNodeFuncMapEN objDataNodeFuncMapENS, clsDataNodeFuncMapEN objDataNodeFuncMapENT)
{
objDataNodeFuncMapENT.DnFuncMapId = objDataNodeFuncMapENS.DnFuncMapId; //函数映射Id
objDataNodeFuncMapENT.InDataNodeId = objDataNodeFuncMapENS.InDataNodeId; //In数据结点Id
objDataNodeFuncMapENT.OutDataNodeId = objDataNodeFuncMapENS.OutDataNodeId; //Out数据结点Id
objDataNodeFuncMapENT.AssociationMappingId = objDataNodeFuncMapENS.AssociationMappingId; //关联关系映射Id
objDataNodeFuncMapENT.FuncMapModeId = objDataNodeFuncMapENS.FuncMapModeId; //函数映射模式Id
objDataNodeFuncMapENT.TabId = objDataNodeFuncMapENS.TabId; //表ID
objDataNodeFuncMapENT.DnFunctionId = objDataNodeFuncMapENS.DnFunctionId; //DN函数Id
objDataNodeFuncMapENT.PrjId = objDataNodeFuncMapENS.PrjId; //工程ID
objDataNodeFuncMapENT.CmPrjId = objDataNodeFuncMapENS.CmPrjId; //CM工程Id
objDataNodeFuncMapENT.UpdDate = objDataNodeFuncMapENS.UpdDate; //修改日期
objDataNodeFuncMapENT.UpdUser = objDataNodeFuncMapENS.UpdUser; //修改者
objDataNodeFuncMapENT.Memo = objDataNodeFuncMapENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDataNodeFuncMapEN.InDataNodeId, conDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldNotNull(objDataNodeFuncMapEN.OutDataNodeId, conDataNodeFuncMap.OutDataNodeId);
clsCheckSql.CheckFieldNotNull(objDataNodeFuncMapEN.AssociationMappingId, conDataNodeFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldNotNull(objDataNodeFuncMapEN.FuncMapModeId, conDataNodeFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldNotNull(objDataNodeFuncMapEN.PrjId, conDataNodeFuncMap.PrjId);
clsCheckSql.CheckFieldNotNull(objDataNodeFuncMapEN.CmPrjId, conDataNodeFuncMap.CmPrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.DnFuncMapId, 8, conDataNodeFuncMap.DnFuncMapId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.InDataNodeId, 8, conDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.OutDataNodeId, 8, conDataNodeFuncMap.OutDataNodeId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.AssociationMappingId, 2, conDataNodeFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.FuncMapModeId, 2, conDataNodeFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.TabId, 8, conDataNodeFuncMap.TabId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.DnFunctionId, 8, conDataNodeFuncMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.PrjId, 4, conDataNodeFuncMap.PrjId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.CmPrjId, 6, conDataNodeFuncMap.CmPrjId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.UpdDate, 20, conDataNodeFuncMap.UpdDate);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.UpdUser, 20, conDataNodeFuncMap.UpdUser);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.Memo, 1000, conDataNodeFuncMap.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objDataNodeFuncMapEN.InDataNodeId, 8, conDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldForeignKey(objDataNodeFuncMapEN.OutDataNodeId, 8, conDataNodeFuncMap.OutDataNodeId);
 objDataNodeFuncMapEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.InDataNodeId, 8, conDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.OutDataNodeId, 8, conDataNodeFuncMap.OutDataNodeId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.AssociationMappingId, 2, conDataNodeFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.FuncMapModeId, 2, conDataNodeFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.TabId, 8, conDataNodeFuncMap.TabId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.DnFunctionId, 8, conDataNodeFuncMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.PrjId, 4, conDataNodeFuncMap.PrjId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.CmPrjId, 6, conDataNodeFuncMap.CmPrjId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.UpdDate, 20, conDataNodeFuncMap.UpdDate);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.UpdUser, 20, conDataNodeFuncMap.UpdUser);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.Memo, 1000, conDataNodeFuncMap.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objDataNodeFuncMapEN.InDataNodeId, 8, conDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldForeignKey(objDataNodeFuncMapEN.OutDataNodeId, 8, conDataNodeFuncMap.OutDataNodeId);
 objDataNodeFuncMapEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.DnFuncMapId, 8, conDataNodeFuncMap.DnFuncMapId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.InDataNodeId, 8, conDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.OutDataNodeId, 8, conDataNodeFuncMap.OutDataNodeId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.AssociationMappingId, 2, conDataNodeFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.FuncMapModeId, 2, conDataNodeFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.TabId, 8, conDataNodeFuncMap.TabId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.DnFunctionId, 8, conDataNodeFuncMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.PrjId, 4, conDataNodeFuncMap.PrjId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.CmPrjId, 6, conDataNodeFuncMap.CmPrjId);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.UpdDate, 20, conDataNodeFuncMap.UpdDate);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.UpdUser, 20, conDataNodeFuncMap.UpdUser);
clsCheckSql.CheckFieldLen(objDataNodeFuncMapEN.Memo, 1000, conDataNodeFuncMap.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.DnFuncMapId, conDataNodeFuncMap.DnFuncMapId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.InDataNodeId, conDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.OutDataNodeId, conDataNodeFuncMap.OutDataNodeId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.AssociationMappingId, conDataNodeFuncMap.AssociationMappingId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.FuncMapModeId, conDataNodeFuncMap.FuncMapModeId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.TabId, conDataNodeFuncMap.TabId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.DnFunctionId, conDataNodeFuncMap.DnFunctionId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.PrjId, conDataNodeFuncMap.PrjId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.CmPrjId, conDataNodeFuncMap.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.UpdDate, conDataNodeFuncMap.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.UpdUser, conDataNodeFuncMap.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDataNodeFuncMapEN.Memo, conDataNodeFuncMap.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objDataNodeFuncMapEN.InDataNodeId, 8, conDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldForeignKey(objDataNodeFuncMapEN.OutDataNodeId, 8, conDataNodeFuncMap.OutDataNodeId);
 objDataNodeFuncMapEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--DataNodeFuncMap(结点函数映射), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <param name = "strDnFuncMapId">函数映射Id(主键)</param>
 /// <returns></returns>
public bool CheckDataNodeFuncMapUniqueness(string strDnFuncMapId )
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
 /// 检查唯一性(Uniqueness)--DataNodeFuncMap(结点函数映射), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <returns></returns>
public bool CheckDataNodeFuncMapUniqueness()
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

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DataNodeFuncMap(结点函数映射),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr_InDataNodeId_OutDataNodeId_CMPrjId(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDataNodeFuncMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDataNodeFuncMapEN.OutDataNodeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objDataNodeFuncMapEN.CmPrjId);
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
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
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
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
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
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataNodeFuncMapEN._CurrTabName);
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
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataNodeFuncMapEN._CurrTabName, strCondition);
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
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
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
 objSQL = clsDataNodeFuncMapDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}