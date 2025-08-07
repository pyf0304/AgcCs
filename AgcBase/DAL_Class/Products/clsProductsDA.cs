
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProductsDA
 表名:Products(00050180)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:产品(Products)
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
 /// 产品(Products)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsProductsDA : clsCommBase4DA
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
 return clsProductsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsProductsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsProductsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsProductsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsProductsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strProductsID">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strProductsID)
{
strProductsID = strProductsID.Replace("'", "''");
if (strProductsID.Length > 6)
{
throw new Exception("(errid:Data000001)在表:Products中,检查关键字,长度不正确!(clsProductsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strProductsID)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Products中,关键字不能为空 或 null!(clsProductsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProductsID);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsProductsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsProductsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = "Select * from Products where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Products(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsProductsDA: GetDataTable_Products)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = "Select * from Products where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsProductsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsProductsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = "Select * from Products where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsProductsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsProductsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Products where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Products where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsProductsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Products where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsProductsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Products.* " + 
$"from Products " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Products.ProductsID not in " + 
$"(Select top {intTop_In} Products.ProductsID from Products " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Products where {1} and ProductsID not in (Select top {2} ProductsID from Products where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Products where {1} and ProductsID not in (Select top {3} ProductsID from Products where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsProductsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Products.* " + 
$"from Products " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Products.ProductsID not in " + 
$"(Select top {intTop_In} Products.ProductsID from Products " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Products where {1} and ProductsID not in (Select top {2} ProductsID from Products where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Products where {1} and ProductsID not in (Select top {3} ProductsID from Products where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsProductsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsProductsDA:GetObjLst)", objException.Message));
}
List<clsProductsEN> arrObjLst = new List<clsProductsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = "Select * from Products where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProductsEN objProductsEN = new clsProductsEN();
try
{
objProductsEN.ProductsID = objRow[conProducts.ProductsID].ToString().Trim(); //产品编号
objProductsEN.ProductsName = objRow[conProducts.ProductsName].ToString().Trim(); //产品名称
objProductsEN.ProductsType = objRow[conProducts.ProductsType].ToString().Trim(); //产品类型
objProductsEN.Brand = objRow[conProducts.Brand].ToString().Trim(); //品牌
objProductsEN.Quantity = objRow[conProducts.Quantity].ToString().Trim(); //数量
objProductsEN.Amount = objRow[conProducts.Amount].ToString().Trim(); //金额
objProductsEN.Salesid = objRow[conProducts.Salesid].ToString().Trim(); //销售单号
objProductsEN.Memo = objRow[conProducts.Memo] == DBNull.Value ? null : objRow[conProducts.Memo].ToString().Trim(); //说明
objProductsEN.CustomersName = objRow[conProducts.CustomersName].ToString().Trim(); //购买客户人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsProductsDA: GetObjLst)", objException.Message));
}
objProductsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objProductsEN);
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
public List<clsProductsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsProductsDA:GetObjLstByTabName)", objException.Message));
}
List<clsProductsEN> arrObjLst = new List<clsProductsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProductsEN objProductsEN = new clsProductsEN();
try
{
objProductsEN.ProductsID = objRow[conProducts.ProductsID].ToString().Trim(); //产品编号
objProductsEN.ProductsName = objRow[conProducts.ProductsName].ToString().Trim(); //产品名称
objProductsEN.ProductsType = objRow[conProducts.ProductsType].ToString().Trim(); //产品类型
objProductsEN.Brand = objRow[conProducts.Brand].ToString().Trim(); //品牌
objProductsEN.Quantity = objRow[conProducts.Quantity].ToString().Trim(); //数量
objProductsEN.Amount = objRow[conProducts.Amount].ToString().Trim(); //金额
objProductsEN.Salesid = objRow[conProducts.Salesid].ToString().Trim(); //销售单号
objProductsEN.Memo = objRow[conProducts.Memo] == DBNull.Value ? null : objRow[conProducts.Memo].ToString().Trim(); //说明
objProductsEN.CustomersName = objRow[conProducts.CustomersName].ToString().Trim(); //购买客户人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsProductsDA: GetObjLst)", objException.Message));
}
objProductsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objProductsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objProductsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetProducts(ref clsProductsEN objProductsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = "Select * from Products where ProductsID = " + "'"+ objProductsEN.ProductsID+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objProductsEN.ProductsID = objDT.Rows[0][conProducts.ProductsID].ToString().Trim(); //产品编号(字段类型:varchar,字段长度:6,是否可空:False)
 objProductsEN.ProductsName = objDT.Rows[0][conProducts.ProductsName].ToString().Trim(); //产品名称(字段类型:varchar,字段长度:10,是否可空:False)
 objProductsEN.ProductsType = objDT.Rows[0][conProducts.ProductsType].ToString().Trim(); //产品类型(字段类型:varchar,字段长度:6,是否可空:False)
 objProductsEN.Brand = objDT.Rows[0][conProducts.Brand].ToString().Trim(); //品牌(字段类型:varchar,字段长度:20,是否可空:False)
 objProductsEN.Quantity = objDT.Rows[0][conProducts.Quantity].ToString().Trim(); //数量(字段类型:varchar,字段长度:10,是否可空:False)
 objProductsEN.Amount = objDT.Rows[0][conProducts.Amount].ToString().Trim(); //金额(字段类型:varchar,字段长度:10,是否可空:False)
 objProductsEN.Salesid = objDT.Rows[0][conProducts.Salesid].ToString().Trim(); //销售单号(字段类型:varchar,字段长度:6,是否可空:False)
 objProductsEN.Memo = objDT.Rows[0][conProducts.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objProductsEN.CustomersName = objDT.Rows[0][conProducts.CustomersName].ToString().Trim(); //购买客户人(字段类型:varchar,字段长度:20,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsProductsDA: GetProducts)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strProductsID">表关键字</param>
 /// <returns>表对象</returns>
public clsProductsEN GetObjByProductsID(string strProductsID)
{
CheckPrimaryKey(strProductsID);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = "Select * from Products where ProductsID = " + "'"+ strProductsID+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsProductsEN objProductsEN = new clsProductsEN();
try
{
 objProductsEN.ProductsID = objRow[conProducts.ProductsID].ToString().Trim(); //产品编号(字段类型:varchar,字段长度:6,是否可空:False)
 objProductsEN.ProductsName = objRow[conProducts.ProductsName].ToString().Trim(); //产品名称(字段类型:varchar,字段长度:10,是否可空:False)
 objProductsEN.ProductsType = objRow[conProducts.ProductsType].ToString().Trim(); //产品类型(字段类型:varchar,字段长度:6,是否可空:False)
 objProductsEN.Brand = objRow[conProducts.Brand].ToString().Trim(); //品牌(字段类型:varchar,字段长度:20,是否可空:False)
 objProductsEN.Quantity = objRow[conProducts.Quantity].ToString().Trim(); //数量(字段类型:varchar,字段长度:10,是否可空:False)
 objProductsEN.Amount = objRow[conProducts.Amount].ToString().Trim(); //金额(字段类型:varchar,字段长度:10,是否可空:False)
 objProductsEN.Salesid = objRow[conProducts.Salesid].ToString().Trim(); //销售单号(字段类型:varchar,字段长度:6,是否可空:False)
 objProductsEN.Memo = objRow[conProducts.Memo] == DBNull.Value ? null : objRow[conProducts.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objProductsEN.CustomersName = objRow[conProducts.CustomersName].ToString().Trim(); //购买客户人(字段类型:varchar,字段长度:20,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsProductsDA: GetObjByProductsID)", objException.Message));
}
return objProductsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsProductsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsProductsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = "Select * from Products where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsProductsEN objProductsEN = new clsProductsEN()
{
ProductsID = objRow[conProducts.ProductsID].ToString().Trim(), //产品编号
ProductsName = objRow[conProducts.ProductsName].ToString().Trim(), //产品名称
ProductsType = objRow[conProducts.ProductsType].ToString().Trim(), //产品类型
Brand = objRow[conProducts.Brand].ToString().Trim(), //品牌
Quantity = objRow[conProducts.Quantity].ToString().Trim(), //数量
Amount = objRow[conProducts.Amount].ToString().Trim(), //金额
Salesid = objRow[conProducts.Salesid].ToString().Trim(), //销售单号
Memo = objRow[conProducts.Memo] == DBNull.Value ? null : objRow[conProducts.Memo].ToString().Trim(), //说明
CustomersName = objRow[conProducts.CustomersName].ToString().Trim() //购买客户人
};
objProductsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objProductsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsProductsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsProductsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsProductsEN objProductsEN = new clsProductsEN();
try
{
objProductsEN.ProductsID = objRow[conProducts.ProductsID].ToString().Trim(); //产品编号
objProductsEN.ProductsName = objRow[conProducts.ProductsName].ToString().Trim(); //产品名称
objProductsEN.ProductsType = objRow[conProducts.ProductsType].ToString().Trim(); //产品类型
objProductsEN.Brand = objRow[conProducts.Brand].ToString().Trim(); //品牌
objProductsEN.Quantity = objRow[conProducts.Quantity].ToString().Trim(); //数量
objProductsEN.Amount = objRow[conProducts.Amount].ToString().Trim(); //金额
objProductsEN.Salesid = objRow[conProducts.Salesid].ToString().Trim(); //销售单号
objProductsEN.Memo = objRow[conProducts.Memo] == DBNull.Value ? null : objRow[conProducts.Memo].ToString().Trim(); //说明
objProductsEN.CustomersName = objRow[conProducts.CustomersName].ToString().Trim(); //购买客户人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsProductsDA: GetObjByDataRowProducts)", objException.Message));
}
objProductsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objProductsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsProductsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsProductsEN objProductsEN = new clsProductsEN();
try
{
objProductsEN.ProductsID = objRow[conProducts.ProductsID].ToString().Trim(); //产品编号
objProductsEN.ProductsName = objRow[conProducts.ProductsName].ToString().Trim(); //产品名称
objProductsEN.ProductsType = objRow[conProducts.ProductsType].ToString().Trim(); //产品类型
objProductsEN.Brand = objRow[conProducts.Brand].ToString().Trim(); //品牌
objProductsEN.Quantity = objRow[conProducts.Quantity].ToString().Trim(); //数量
objProductsEN.Amount = objRow[conProducts.Amount].ToString().Trim(); //金额
objProductsEN.Salesid = objRow[conProducts.Salesid].ToString().Trim(); //销售单号
objProductsEN.Memo = objRow[conProducts.Memo] == DBNull.Value ? null : objRow[conProducts.Memo].ToString().Trim(); //说明
objProductsEN.CustomersName = objRow[conProducts.CustomersName].ToString().Trim(); //购买客户人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsProductsDA: GetObjByDataRow)", objException.Message));
}
objProductsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objProductsEN;
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
objSQL = clsProductsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsProductsEN._CurrTabName, conProducts.ProductsID, 6, "");
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
objSQL = clsProductsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsProductsEN._CurrTabName, conProducts.ProductsID, 6, strPrefix);
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
 objSQL = clsProductsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ProductsID from Products where " + strCondition;
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
 objSQL = clsProductsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ProductsID from Products where " + strCondition;
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
 /// <param name = "strProductsID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strProductsID)
{
CheckPrimaryKey(strProductsID);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Products", "ProductsID = " + "'"+ strProductsID+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsProductsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Products", strCondition))
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
objSQL = clsProductsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Products");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsProductsEN objProductsEN)
 {
 if (objProductsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objProductsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = "Select * from Products where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Products");
objRow = objDS.Tables["Products"].NewRow();
objRow[conProducts.ProductsID] = objProductsEN.ProductsID; //产品编号
objRow[conProducts.ProductsName] = objProductsEN.ProductsName; //产品名称
objRow[conProducts.ProductsType] = objProductsEN.ProductsType; //产品类型
objRow[conProducts.Brand] = objProductsEN.Brand; //品牌
objRow[conProducts.Quantity] = objProductsEN.Quantity; //数量
objRow[conProducts.Amount] = objProductsEN.Amount; //金额
objRow[conProducts.Salesid] = objProductsEN.Salesid; //销售单号
 if (objProductsEN.Memo !=  "")
 {
objRow[conProducts.Memo] = objProductsEN.Memo; //说明
 }
objRow[conProducts.CustomersName] = objProductsEN.CustomersName; //购买客户人
objDS.Tables[clsProductsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsProductsEN._CurrTabName);
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
 /// <param name = "objProductsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsProductsEN objProductsEN)
{
 if (objProductsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objProductsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objProductsEN.ProductsID !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsID);
 var strProductsID = objProductsEN.ProductsID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsID + "'");
 }
 
 if (objProductsEN.ProductsName !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsName);
 var strProductsName = objProductsEN.ProductsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsName + "'");
 }
 
 if (objProductsEN.ProductsType !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsType);
 var strProductsType = objProductsEN.ProductsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsType + "'");
 }
 
 if (objProductsEN.Brand !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Brand);
 var strBrand = objProductsEN.Brand.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBrand + "'");
 }
 
 if (objProductsEN.Quantity !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Quantity);
 var strQuantity = objProductsEN.Quantity.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuantity + "'");
 }
 
 if (objProductsEN.Amount !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Amount);
 var strAmount = objProductsEN.Amount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAmount + "'");
 }
 
 if (objProductsEN.Salesid !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Salesid);
 var strSalesid = objProductsEN.Salesid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSalesid + "'");
 }
 
 if (objProductsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Memo);
 var strMemo = objProductsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objProductsEN.CustomersName !=  null)
 {
 arrFieldListForInsert.Add(conProducts.CustomersName);
 var strCustomersName = objProductsEN.CustomersName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomersName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Products");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objProductsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsProductsEN objProductsEN)
{
 if (objProductsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objProductsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objProductsEN.ProductsID !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsID);
 var strProductsID = objProductsEN.ProductsID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsID + "'");
 }
 
 if (objProductsEN.ProductsName !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsName);
 var strProductsName = objProductsEN.ProductsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsName + "'");
 }
 
 if (objProductsEN.ProductsType !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsType);
 var strProductsType = objProductsEN.ProductsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsType + "'");
 }
 
 if (objProductsEN.Brand !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Brand);
 var strBrand = objProductsEN.Brand.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBrand + "'");
 }
 
 if (objProductsEN.Quantity !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Quantity);
 var strQuantity = objProductsEN.Quantity.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuantity + "'");
 }
 
 if (objProductsEN.Amount !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Amount);
 var strAmount = objProductsEN.Amount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAmount + "'");
 }
 
 if (objProductsEN.Salesid !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Salesid);
 var strSalesid = objProductsEN.Salesid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSalesid + "'");
 }
 
 if (objProductsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Memo);
 var strMemo = objProductsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objProductsEN.CustomersName !=  null)
 {
 arrFieldListForInsert.Add(conProducts.CustomersName);
 var strCustomersName = objProductsEN.CustomersName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomersName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Products");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objProductsEN.ProductsID;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objProductsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsProductsEN objProductsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objProductsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objProductsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objProductsEN.ProductsID !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsID);
 var strProductsID = objProductsEN.ProductsID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsID + "'");
 }
 
 if (objProductsEN.ProductsName !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsName);
 var strProductsName = objProductsEN.ProductsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsName + "'");
 }
 
 if (objProductsEN.ProductsType !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsType);
 var strProductsType = objProductsEN.ProductsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsType + "'");
 }
 
 if (objProductsEN.Brand !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Brand);
 var strBrand = objProductsEN.Brand.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBrand + "'");
 }
 
 if (objProductsEN.Quantity !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Quantity);
 var strQuantity = objProductsEN.Quantity.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuantity + "'");
 }
 
 if (objProductsEN.Amount !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Amount);
 var strAmount = objProductsEN.Amount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAmount + "'");
 }
 
 if (objProductsEN.Salesid !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Salesid);
 var strSalesid = objProductsEN.Salesid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSalesid + "'");
 }
 
 if (objProductsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Memo);
 var strMemo = objProductsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objProductsEN.CustomersName !=  null)
 {
 arrFieldListForInsert.Add(conProducts.CustomersName);
 var strCustomersName = objProductsEN.CustomersName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomersName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Products");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objProductsEN.ProductsID;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objProductsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsProductsEN objProductsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objProductsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objProductsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objProductsEN.ProductsID !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsID);
 var strProductsID = objProductsEN.ProductsID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsID + "'");
 }
 
 if (objProductsEN.ProductsName !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsName);
 var strProductsName = objProductsEN.ProductsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsName + "'");
 }
 
 if (objProductsEN.ProductsType !=  null)
 {
 arrFieldListForInsert.Add(conProducts.ProductsType);
 var strProductsType = objProductsEN.ProductsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProductsType + "'");
 }
 
 if (objProductsEN.Brand !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Brand);
 var strBrand = objProductsEN.Brand.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBrand + "'");
 }
 
 if (objProductsEN.Quantity !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Quantity);
 var strQuantity = objProductsEN.Quantity.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuantity + "'");
 }
 
 if (objProductsEN.Amount !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Amount);
 var strAmount = objProductsEN.Amount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAmount + "'");
 }
 
 if (objProductsEN.Salesid !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Salesid);
 var strSalesid = objProductsEN.Salesid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSalesid + "'");
 }
 
 if (objProductsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conProducts.Memo);
 var strMemo = objProductsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objProductsEN.CustomersName !=  null)
 {
 arrFieldListForInsert.Add(conProducts.CustomersName);
 var strCustomersName = objProductsEN.CustomersName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomersName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Products");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewProductss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = "Select * from Products where ProductsID = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Products");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strProductsID = oRow[conProducts.ProductsID].ToString().Trim();
if (IsExist(strProductsID))
{
 string strResult = "关键字变量值为:" + string.Format("ProductsID = {0}", strProductsID) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsProductsEN._CurrTabName ].NewRow();
objRow[conProducts.ProductsID] = oRow[conProducts.ProductsID].ToString().Trim(); //产品编号
objRow[conProducts.ProductsName] = oRow[conProducts.ProductsName].ToString().Trim(); //产品名称
objRow[conProducts.ProductsType] = oRow[conProducts.ProductsType].ToString().Trim(); //产品类型
objRow[conProducts.Brand] = oRow[conProducts.Brand].ToString().Trim(); //品牌
objRow[conProducts.Quantity] = oRow[conProducts.Quantity].ToString().Trim(); //数量
objRow[conProducts.Amount] = oRow[conProducts.Amount].ToString().Trim(); //金额
objRow[conProducts.Salesid] = oRow[conProducts.Salesid].ToString().Trim(); //销售单号
objRow[conProducts.Memo] = oRow[conProducts.Memo].ToString().Trim(); //说明
objRow[conProducts.CustomersName] = oRow[conProducts.CustomersName].ToString().Trim(); //购买客户人
 objDS.Tables[clsProductsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsProductsEN._CurrTabName);
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
 /// <param name = "objProductsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsProductsEN objProductsEN)
{
 if (objProductsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objProductsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
strSQL = "Select * from Products where ProductsID = " + "'"+ objProductsEN.ProductsID+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsProductsEN._CurrTabName);
if (objDS.Tables[clsProductsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ProductsID = " + "'"+ objProductsEN.ProductsID+"'");
return false;
}
objRow = objDS.Tables[clsProductsEN._CurrTabName].Rows[0];
 if (objProductsEN.IsUpdated(conProducts.ProductsID))
 {
objRow[conProducts.ProductsID] = objProductsEN.ProductsID; //产品编号
 }
 if (objProductsEN.IsUpdated(conProducts.ProductsName))
 {
objRow[conProducts.ProductsName] = objProductsEN.ProductsName; //产品名称
 }
 if (objProductsEN.IsUpdated(conProducts.ProductsType))
 {
objRow[conProducts.ProductsType] = objProductsEN.ProductsType; //产品类型
 }
 if (objProductsEN.IsUpdated(conProducts.Brand))
 {
objRow[conProducts.Brand] = objProductsEN.Brand; //品牌
 }
 if (objProductsEN.IsUpdated(conProducts.Quantity))
 {
objRow[conProducts.Quantity] = objProductsEN.Quantity; //数量
 }
 if (objProductsEN.IsUpdated(conProducts.Amount))
 {
objRow[conProducts.Amount] = objProductsEN.Amount; //金额
 }
 if (objProductsEN.IsUpdated(conProducts.Salesid))
 {
objRow[conProducts.Salesid] = objProductsEN.Salesid; //销售单号
 }
 if (objProductsEN.IsUpdated(conProducts.Memo))
 {
objRow[conProducts.Memo] = objProductsEN.Memo; //说明
 }
 if (objProductsEN.IsUpdated(conProducts.CustomersName))
 {
objRow[conProducts.CustomersName] = objProductsEN.CustomersName; //购买客户人
 }
try
{
objDA.Update(objDS, clsProductsEN._CurrTabName);
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
 /// <param name = "objProductsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsProductsEN objProductsEN)
{
 if (objProductsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objProductsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Products Set ");
 
 if (objProductsEN.IsUpdated(conProducts.ProductsName))
 {
 if (objProductsEN.ProductsName !=  null)
 {
 var strProductsName = objProductsEN.ProductsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProductsName, conProducts.ProductsName); //产品名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.ProductsName); //产品名称
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.ProductsType))
 {
 if (objProductsEN.ProductsType !=  null)
 {
 var strProductsType = objProductsEN.ProductsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProductsType, conProducts.ProductsType); //产品类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.ProductsType); //产品类型
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Brand))
 {
 if (objProductsEN.Brand !=  null)
 {
 var strBrand = objProductsEN.Brand.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBrand, conProducts.Brand); //品牌
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.Brand); //品牌
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Quantity))
 {
 if (objProductsEN.Quantity !=  null)
 {
 var strQuantity = objProductsEN.Quantity.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuantity, conProducts.Quantity); //数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.Quantity); //数量
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Amount))
 {
 if (objProductsEN.Amount !=  null)
 {
 var strAmount = objProductsEN.Amount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAmount, conProducts.Amount); //金额
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.Amount); //金额
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Salesid))
 {
 if (objProductsEN.Salesid !=  null)
 {
 var strSalesid = objProductsEN.Salesid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSalesid, conProducts.Salesid); //销售单号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.Salesid); //销售单号
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Memo))
 {
 if (objProductsEN.Memo !=  null)
 {
 var strMemo = objProductsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conProducts.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.Memo); //说明
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.CustomersName))
 {
 if (objProductsEN.CustomersName !=  null)
 {
 var strCustomersName = objProductsEN.CustomersName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCustomersName, conProducts.CustomersName); //购买客户人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.CustomersName); //购买客户人
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProductsID = '{0}'", objProductsEN.ProductsID); 
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
 /// <param name = "objProductsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsProductsEN objProductsEN, string strCondition)
{
 if (objProductsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objProductsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Products Set ");
 
 if (objProductsEN.IsUpdated(conProducts.ProductsName))
 {
 if (objProductsEN.ProductsName !=  null)
 {
 var strProductsName = objProductsEN.ProductsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProductsName = '{0}',", strProductsName); //产品名称
 }
 else
 {
 sbSQL.Append(" ProductsName = null,"); //产品名称
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.ProductsType))
 {
 if (objProductsEN.ProductsType !=  null)
 {
 var strProductsType = objProductsEN.ProductsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProductsType = '{0}',", strProductsType); //产品类型
 }
 else
 {
 sbSQL.Append(" ProductsType = null,"); //产品类型
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Brand))
 {
 if (objProductsEN.Brand !=  null)
 {
 var strBrand = objProductsEN.Brand.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Brand = '{0}',", strBrand); //品牌
 }
 else
 {
 sbSQL.Append(" Brand = null,"); //品牌
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Quantity))
 {
 if (objProductsEN.Quantity !=  null)
 {
 var strQuantity = objProductsEN.Quantity.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Quantity = '{0}',", strQuantity); //数量
 }
 else
 {
 sbSQL.Append(" Quantity = null,"); //数量
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Amount))
 {
 if (objProductsEN.Amount !=  null)
 {
 var strAmount = objProductsEN.Amount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Amount = '{0}',", strAmount); //金额
 }
 else
 {
 sbSQL.Append(" Amount = null,"); //金额
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Salesid))
 {
 if (objProductsEN.Salesid !=  null)
 {
 var strSalesid = objProductsEN.Salesid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Salesid = '{0}',", strSalesid); //销售单号
 }
 else
 {
 sbSQL.Append(" Salesid = null,"); //销售单号
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Memo))
 {
 if (objProductsEN.Memo !=  null)
 {
 var strMemo = objProductsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.CustomersName))
 {
 if (objProductsEN.CustomersName !=  null)
 {
 var strCustomersName = objProductsEN.CustomersName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CustomersName = '{0}',", strCustomersName); //购买客户人
 }
 else
 {
 sbSQL.Append(" CustomersName = null,"); //购买客户人
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
 /// <param name = "objProductsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsProductsEN objProductsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objProductsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objProductsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Products Set ");
 
 if (objProductsEN.IsUpdated(conProducts.ProductsName))
 {
 if (objProductsEN.ProductsName !=  null)
 {
 var strProductsName = objProductsEN.ProductsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProductsName = '{0}',", strProductsName); //产品名称
 }
 else
 {
 sbSQL.Append(" ProductsName = null,"); //产品名称
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.ProductsType))
 {
 if (objProductsEN.ProductsType !=  null)
 {
 var strProductsType = objProductsEN.ProductsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProductsType = '{0}',", strProductsType); //产品类型
 }
 else
 {
 sbSQL.Append(" ProductsType = null,"); //产品类型
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Brand))
 {
 if (objProductsEN.Brand !=  null)
 {
 var strBrand = objProductsEN.Brand.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Brand = '{0}',", strBrand); //品牌
 }
 else
 {
 sbSQL.Append(" Brand = null,"); //品牌
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Quantity))
 {
 if (objProductsEN.Quantity !=  null)
 {
 var strQuantity = objProductsEN.Quantity.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Quantity = '{0}',", strQuantity); //数量
 }
 else
 {
 sbSQL.Append(" Quantity = null,"); //数量
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Amount))
 {
 if (objProductsEN.Amount !=  null)
 {
 var strAmount = objProductsEN.Amount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Amount = '{0}',", strAmount); //金额
 }
 else
 {
 sbSQL.Append(" Amount = null,"); //金额
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Salesid))
 {
 if (objProductsEN.Salesid !=  null)
 {
 var strSalesid = objProductsEN.Salesid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Salesid = '{0}',", strSalesid); //销售单号
 }
 else
 {
 sbSQL.Append(" Salesid = null,"); //销售单号
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Memo))
 {
 if (objProductsEN.Memo !=  null)
 {
 var strMemo = objProductsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.CustomersName))
 {
 if (objProductsEN.CustomersName !=  null)
 {
 var strCustomersName = objProductsEN.CustomersName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CustomersName = '{0}',", strCustomersName); //购买客户人
 }
 else
 {
 sbSQL.Append(" CustomersName = null,"); //购买客户人
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
 /// <param name = "objProductsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsProductsEN objProductsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objProductsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objProductsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Products Set ");
 
 if (objProductsEN.IsUpdated(conProducts.ProductsName))
 {
 if (objProductsEN.ProductsName !=  null)
 {
 var strProductsName = objProductsEN.ProductsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProductsName, conProducts.ProductsName); //产品名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.ProductsName); //产品名称
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.ProductsType))
 {
 if (objProductsEN.ProductsType !=  null)
 {
 var strProductsType = objProductsEN.ProductsType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProductsType, conProducts.ProductsType); //产品类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.ProductsType); //产品类型
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Brand))
 {
 if (objProductsEN.Brand !=  null)
 {
 var strBrand = objProductsEN.Brand.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBrand, conProducts.Brand); //品牌
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.Brand); //品牌
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Quantity))
 {
 if (objProductsEN.Quantity !=  null)
 {
 var strQuantity = objProductsEN.Quantity.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuantity, conProducts.Quantity); //数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.Quantity); //数量
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Amount))
 {
 if (objProductsEN.Amount !=  null)
 {
 var strAmount = objProductsEN.Amount.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAmount, conProducts.Amount); //金额
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.Amount); //金额
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Salesid))
 {
 if (objProductsEN.Salesid !=  null)
 {
 var strSalesid = objProductsEN.Salesid.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSalesid, conProducts.Salesid); //销售单号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.Salesid); //销售单号
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.Memo))
 {
 if (objProductsEN.Memo !=  null)
 {
 var strMemo = objProductsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conProducts.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.Memo); //说明
 }
 }
 
 if (objProductsEN.IsUpdated(conProducts.CustomersName))
 {
 if (objProductsEN.CustomersName !=  null)
 {
 var strCustomersName = objProductsEN.CustomersName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCustomersName, conProducts.CustomersName); //购买客户人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProducts.CustomersName); //购买客户人
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProductsID = '{0}'", objProductsEN.ProductsID); 
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
 /// <param name = "strProductsID">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strProductsID) 
{
CheckPrimaryKey(strProductsID);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strProductsID,
};
 objSQL.ExecSP("Products_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strProductsID">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strProductsID, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strProductsID);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
//删除Products本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Products where ProductsID = " + "'"+ strProductsID+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelProducts(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
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
//删除Products本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Products where ProductsID in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strProductsID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strProductsID) 
{
CheckPrimaryKey(strProductsID);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
//删除Products本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Products where ProductsID = " + "'"+ strProductsID+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelProducts(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsProductsDA: DelProducts)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Products where " + strCondition ;
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
public bool DelProductsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsProductsDA: DelProductsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProductsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Products where " + strCondition ;
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
 /// <param name = "objProductsENS">源对象</param>
 /// <param name = "objProductsENT">目标对象</param>
public void CopyTo(clsProductsEN objProductsENS, clsProductsEN objProductsENT)
{
objProductsENT.ProductsID = objProductsENS.ProductsID; //产品编号
objProductsENT.ProductsName = objProductsENS.ProductsName; //产品名称
objProductsENT.ProductsType = objProductsENS.ProductsType; //产品类型
objProductsENT.Brand = objProductsENS.Brand; //品牌
objProductsENT.Quantity = objProductsENS.Quantity; //数量
objProductsENT.Amount = objProductsENS.Amount; //金额
objProductsENT.Salesid = objProductsENS.Salesid; //销售单号
objProductsENT.Memo = objProductsENS.Memo; //说明
objProductsENT.CustomersName = objProductsENS.CustomersName; //购买客户人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsProductsEN objProductsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objProductsEN.ProductsName, conProducts.ProductsName);
clsCheckSql.CheckFieldNotNull(objProductsEN.ProductsType, conProducts.ProductsType);
clsCheckSql.CheckFieldNotNull(objProductsEN.Brand, conProducts.Brand);
clsCheckSql.CheckFieldNotNull(objProductsEN.Quantity, conProducts.Quantity);
clsCheckSql.CheckFieldNotNull(objProductsEN.Amount, conProducts.Amount);
clsCheckSql.CheckFieldNotNull(objProductsEN.Salesid, conProducts.Salesid);
clsCheckSql.CheckFieldNotNull(objProductsEN.CustomersName, conProducts.CustomersName);
//检查字段长度
clsCheckSql.CheckFieldLen(objProductsEN.ProductsID, 6, conProducts.ProductsID);
clsCheckSql.CheckFieldLen(objProductsEN.ProductsName, 10, conProducts.ProductsName);
clsCheckSql.CheckFieldLen(objProductsEN.ProductsType, 6, conProducts.ProductsType);
clsCheckSql.CheckFieldLen(objProductsEN.Brand, 20, conProducts.Brand);
clsCheckSql.CheckFieldLen(objProductsEN.Quantity, 10, conProducts.Quantity);
clsCheckSql.CheckFieldLen(objProductsEN.Amount, 10, conProducts.Amount);
clsCheckSql.CheckFieldLen(objProductsEN.Salesid, 6, conProducts.Salesid);
clsCheckSql.CheckFieldLen(objProductsEN.Memo, 1000, conProducts.Memo);
clsCheckSql.CheckFieldLen(objProductsEN.CustomersName, 20, conProducts.CustomersName);
//检查字段外键固定长度
 objProductsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsProductsEN objProductsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objProductsEN.ProductsName, 10, conProducts.ProductsName);
clsCheckSql.CheckFieldLen(objProductsEN.ProductsType, 6, conProducts.ProductsType);
clsCheckSql.CheckFieldLen(objProductsEN.Brand, 20, conProducts.Brand);
clsCheckSql.CheckFieldLen(objProductsEN.Quantity, 10, conProducts.Quantity);
clsCheckSql.CheckFieldLen(objProductsEN.Amount, 10, conProducts.Amount);
clsCheckSql.CheckFieldLen(objProductsEN.Salesid, 6, conProducts.Salesid);
clsCheckSql.CheckFieldLen(objProductsEN.Memo, 1000, conProducts.Memo);
clsCheckSql.CheckFieldLen(objProductsEN.CustomersName, 20, conProducts.CustomersName);
//检查外键字段长度
 objProductsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsProductsEN objProductsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objProductsEN.ProductsID, 6, conProducts.ProductsID);
clsCheckSql.CheckFieldLen(objProductsEN.ProductsName, 10, conProducts.ProductsName);
clsCheckSql.CheckFieldLen(objProductsEN.ProductsType, 6, conProducts.ProductsType);
clsCheckSql.CheckFieldLen(objProductsEN.Brand, 20, conProducts.Brand);
clsCheckSql.CheckFieldLen(objProductsEN.Quantity, 10, conProducts.Quantity);
clsCheckSql.CheckFieldLen(objProductsEN.Amount, 10, conProducts.Amount);
clsCheckSql.CheckFieldLen(objProductsEN.Salesid, 6, conProducts.Salesid);
clsCheckSql.CheckFieldLen(objProductsEN.Memo, 1000, conProducts.Memo);
clsCheckSql.CheckFieldLen(objProductsEN.CustomersName, 20, conProducts.CustomersName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objProductsEN.ProductsID, conProducts.ProductsID);
clsCheckSql.CheckSqlInjection4Field(objProductsEN.ProductsName, conProducts.ProductsName);
clsCheckSql.CheckSqlInjection4Field(objProductsEN.ProductsType, conProducts.ProductsType);
clsCheckSql.CheckSqlInjection4Field(objProductsEN.Brand, conProducts.Brand);
clsCheckSql.CheckSqlInjection4Field(objProductsEN.Quantity, conProducts.Quantity);
clsCheckSql.CheckSqlInjection4Field(objProductsEN.Amount, conProducts.Amount);
clsCheckSql.CheckSqlInjection4Field(objProductsEN.Salesid, conProducts.Salesid);
clsCheckSql.CheckSqlInjection4Field(objProductsEN.Memo, conProducts.Memo);
clsCheckSql.CheckSqlInjection4Field(objProductsEN.CustomersName, conProducts.CustomersName);
//检查外键字段长度
 objProductsEN._IsCheckProperty = true;
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
 objSQL = clsProductsDA.GetSpecSQLObj();
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
 objSQL = clsProductsDA.GetSpecSQLObj();
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
 objSQL = clsProductsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsProductsEN._CurrTabName);
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
 objSQL = clsProductsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsProductsEN._CurrTabName, strCondition);
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
 objSQL = clsProductsDA.GetSpecSQLObj();
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
 objSQL = clsProductsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}