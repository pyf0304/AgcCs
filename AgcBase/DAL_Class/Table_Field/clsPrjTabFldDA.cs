
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabFldDA
 表名:PrjTabFld(00050019)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 工程表字段(PrjTabFld)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjTabFldDA : clsCommBase4DA
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
 return clsPrjTabFldEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjTabFldEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjTabFldEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjTabFldEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjTabFldEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjTabFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjTabFld(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjTabFldDA: GetDataTable_PrjTabFld)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjTabFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjTabFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjTabFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjTabFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjTabFld where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjTabFld where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjTabFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjTabFld where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjTabFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjTabFld.* " + 
$"from PrjTabFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjTabFld.mId not in " + 
$"(Select top {intTop_In} PrjTabFld.mId from PrjTabFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjTabFld where {1} and mId not in (Select top {2} mId from PrjTabFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjTabFld where {1} and mId not in (Select top {3} mId from PrjTabFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjTabFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjTabFld.* " + 
$"from PrjTabFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjTabFld.mId not in " + 
$"(Select top {intTop_In} PrjTabFld.mId from PrjTabFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjTabFld where {1} and mId not in (Select top {2} mId from PrjTabFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjTabFld where {1} and mId not in (Select top {3} mId from PrjTabFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjTabFldEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjTabFldDA:GetObjLst)", objException.Message));
}
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = TransNullToInt(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = TransNullToBool(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = TransNullToBool(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = TransNullToBool(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = TransNullToBool(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = TransNullToBool(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = TransNullToBool(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = TransNullToBool(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjTabFldDA: GetObjLst)", objException.Message));
}
objPrjTabFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjTabFldEN);
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
public List<clsPrjTabFldEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjTabFldDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = TransNullToInt(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = TransNullToBool(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = TransNullToBool(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = TransNullToBool(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = TransNullToBool(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = TransNullToBool(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = TransNullToBool(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = TransNullToBool(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjTabFldDA: GetObjLst)", objException.Message));
}
objPrjTabFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjTabFldEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjTabFld(ref clsPrjTabFldEN objPrjTabFldEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabFld where mId = " + ""+ objPrjTabFldEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjTabFldEN.mId = TransNullToInt(objDT.Rows[0][conPrjTabFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objPrjTabFldEN.TabId = objDT.Rows[0][conPrjTabFld.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabFldEN.FldId = objDT.Rows[0][conPrjTabFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabFldEN.PrjId = objDT.Rows[0][conPrjTabFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjTabFldEN.FieldTypeId = objDT.Rows[0][conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objPrjTabFldEN.IsTabNullable = TransNullToBool(objDT.Rows[0][conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.IsTabUnique = TransNullToBool(objDT.Rows[0][conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.IsTabForeignKey = TransNullToBool(objDT.Rows[0][conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.IsSortFld = TransNullToBool(objDT.Rows[0][conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.IsGeneProp = TransNullToBool(objDT.Rows[0][conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.IsForExtendClass = TransNullToBool(objDT.Rows[0][conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.CtlTypeIdDu = objDT.Rows[0][conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du(字段类型:char,字段长度:2,是否可空:True)
 objPrjTabFldEN.FldDispUnitStyleId = objDT.Rows[0][conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabFldEN.InFldId = objDT.Rows[0][conPrjTabFld.InFldId].ToString().Trim(); //In字段Id(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabFldEN.DnPathId = objDT.Rows[0][conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabFldEN.KeyId4Test = objDT.Rows[0][conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabFldEN.DisplayFormat = objDT.Rows[0][conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabFldEN.IsParentObj = TransNullToBool(objDT.Rows[0][conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.PrimaryTypeId = objDT.Rows[0][conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objPrjTabFldEN.ForeignKeyTabId = objDT.Rows[0][conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabFldEN.FldOpTypeId = objDT.Rows[0][conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjTabFldEN.SequenceNumber = TransNullToInt(objDT.Rows[0][conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号(字段类型:int,字段长度:4,是否可空:True)
 objPrjTabFldEN.MemoInTab = objDT.Rows[0][conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objPrjTabFldEN.ErrMsg = objDT.Rows[0][conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objPrjTabFldEN.UpdDate = objDT.Rows[0][conPrjTabFld.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjTabFldEN.UpdUser = objDT.Rows[0][conPrjTabFld.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjTabFldEN.Memo = objDT.Rows[0][conPrjTabFld.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjTabFldDA: GetPrjTabFld)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjTabFldEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabFld where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
 objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du(字段类型:char,字段长度:2,是否可空:True)
 objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号(字段类型:int,字段长度:4,是否可空:True)
 objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjTabFldDA: GetObjBymId)", objException.Message));
}
return objPrjTabFldEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjTabFldEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjTabFldDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN()
{
mId = TransNullToInt(objRow[conPrjTabFld.mId].ToString().Trim()), //mId
TabId = objRow[conPrjTabFld.TabId].ToString().Trim(), //表ID
FldId = objRow[conPrjTabFld.FldId].ToString().Trim(), //字段Id
PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(), //工程Id
FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(), //字段类型Id
IsTabNullable = TransNullToBool(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()), //是否表中可空
IsTabUnique = TransNullToBool(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()), //是否表中唯一
IsTabForeignKey = TransNullToBool(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()), //是否表外键
IsSortFld = TransNullToBool(objRow[conPrjTabFld.IsSortFld].ToString().Trim()), //是否排序字段
IsGeneProp = TransNullToBool(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()), //是否生成属性
IsForExtendClass = TransNullToBool(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()), //用于扩展类
CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(), //控件类型Id_du
FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(), //字段显示单元样式Id
InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(), //In字段Id
DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(), //DN路径Id
KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(), //测试关键字Id
DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(), //显示格式
IsParentObj = TransNullToBool(objRow[conPrjTabFld.IsParentObj].ToString().Trim()), //是否父对象
PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(), //主键类型ID
ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(), //外键表ID
FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(), //字段操作类型Id
SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()), //顺序号
MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(), //表中说明
ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(), //错误信息
UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim() //说明
};
objPrjTabFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjTabFldEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjTabFldDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjTabFldEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = TransNullToInt(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = TransNullToBool(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = TransNullToBool(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = TransNullToBool(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = TransNullToBool(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = TransNullToBool(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = TransNullToBool(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = TransNullToBool(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjTabFldDA: GetObjByDataRowPrjTabFld)", objException.Message));
}
objPrjTabFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjTabFldEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjTabFldEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = TransNullToInt(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = TransNullToBool(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = TransNullToBool(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = TransNullToBool(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = TransNullToBool(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = TransNullToBool(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = TransNullToBool(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = TransNullToBool(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjTabFldDA: GetObjByDataRow)", objException.Message));
}
objPrjTabFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjTabFldEN;
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
objSQL = clsPrjTabFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjTabFldEN._CurrTabName, conPrjTabFld.mId, 8, "");
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
objSQL = clsPrjTabFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjTabFldEN._CurrTabName, conPrjTabFld.mId, 8, strPrefix);
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from PrjTabFld where " + strCondition;
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from PrjTabFld where " + strCondition;
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjTabFld", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjTabFldDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjTabFld", strCondition))
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
objSQL = clsPrjTabFldDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjTabFld");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjTabFldEN objPrjTabFldEN)
 {
 objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabFldEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabFld where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjTabFld");
objRow = objDS.Tables["PrjTabFld"].NewRow();
objRow[conPrjTabFld.TabId] = objPrjTabFldEN.TabId; //表ID
objRow[conPrjTabFld.FldId] = objPrjTabFldEN.FldId; //字段Id
objRow[conPrjTabFld.PrjId] = objPrjTabFldEN.PrjId; //工程Id
objRow[conPrjTabFld.FieldTypeId] = objPrjTabFldEN.FieldTypeId; //字段类型Id
objRow[conPrjTabFld.IsTabNullable] = objPrjTabFldEN.IsTabNullable; //是否表中可空
objRow[conPrjTabFld.IsTabUnique] = objPrjTabFldEN.IsTabUnique; //是否表中唯一
objRow[conPrjTabFld.IsTabForeignKey] = objPrjTabFldEN.IsTabForeignKey; //是否表外键
objRow[conPrjTabFld.IsSortFld] = objPrjTabFldEN.IsSortFld; //是否排序字段
objRow[conPrjTabFld.IsGeneProp] = objPrjTabFldEN.IsGeneProp; //是否生成属性
objRow[conPrjTabFld.IsForExtendClass] = objPrjTabFldEN.IsForExtendClass; //用于扩展类
 if (objPrjTabFldEN.CtlTypeIdDu !=  "")
 {
objRow[conPrjTabFld.CtlTypeIdDu] = objPrjTabFldEN.CtlTypeIdDu; //控件类型Id_du
 }
 if (objPrjTabFldEN.FldDispUnitStyleId !=  "")
 {
objRow[conPrjTabFld.FldDispUnitStyleId] = objPrjTabFldEN.FldDispUnitStyleId; //字段显示单元样式Id
 }
 if (objPrjTabFldEN.InFldId !=  "")
 {
objRow[conPrjTabFld.InFldId] = objPrjTabFldEN.InFldId; //In字段Id
 }
 if (objPrjTabFldEN.DnPathId !=  "")
 {
objRow[conPrjTabFld.DnPathId] = objPrjTabFldEN.DnPathId; //DN路径Id
 }
 if (objPrjTabFldEN.KeyId4Test !=  "")
 {
objRow[conPrjTabFld.KeyId4Test] = objPrjTabFldEN.KeyId4Test; //测试关键字Id
 }
 if (objPrjTabFldEN.DisplayFormat !=  "")
 {
objRow[conPrjTabFld.DisplayFormat] = objPrjTabFldEN.DisplayFormat; //显示格式
 }
objRow[conPrjTabFld.IsParentObj] = objPrjTabFldEN.IsParentObj; //是否父对象
objRow[conPrjTabFld.PrimaryTypeId] = objPrjTabFldEN.PrimaryTypeId; //主键类型ID
 if (objPrjTabFldEN.ForeignKeyTabId !=  "")
 {
objRow[conPrjTabFld.ForeignKeyTabId] = objPrjTabFldEN.ForeignKeyTabId; //外键表ID
 }
objRow[conPrjTabFld.FldOpTypeId] = objPrjTabFldEN.FldOpTypeId; //字段操作类型Id
objRow[conPrjTabFld.SequenceNumber] = objPrjTabFldEN.SequenceNumber; //顺序号
 if (objPrjTabFldEN.MemoInTab !=  "")
 {
objRow[conPrjTabFld.MemoInTab] = objPrjTabFldEN.MemoInTab; //表中说明
 }
 if (objPrjTabFldEN.ErrMsg !=  "")
 {
objRow[conPrjTabFld.ErrMsg] = objPrjTabFldEN.ErrMsg; //错误信息
 }
 if (objPrjTabFldEN.UpdDate !=  "")
 {
objRow[conPrjTabFld.UpdDate] = objPrjTabFldEN.UpdDate; //修改日期
 }
 if (objPrjTabFldEN.UpdUser !=  "")
 {
objRow[conPrjTabFld.UpdUser] = objPrjTabFldEN.UpdUser; //修改者
 }
 if (objPrjTabFldEN.Memo !=  "")
 {
objRow[conPrjTabFld.Memo] = objPrjTabFldEN.Memo; //说明
 }
objDS.Tables[clsPrjTabFldEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjTabFldEN._CurrTabName);
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
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjTabFldEN objPrjTabFldEN)
{
 objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabFldEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjTabFldEN.TabId  ==  "")
 {
 objPrjTabFldEN.TabId = null;
 }
 if (objPrjTabFldEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.TabId);
 var strTabId = objPrjTabFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabFldEN.FldId  ==  "")
 {
 objPrjTabFldEN.FldId = null;
 }
 if (objPrjTabFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldId);
 var strFldId = objPrjTabFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objPrjTabFldEN.PrjId  ==  "")
 {
 objPrjTabFldEN.PrjId = null;
 }
 if (objPrjTabFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.PrjId);
 var strPrjId = objPrjTabFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabFldEN.FieldTypeId  ==  "")
 {
 objPrjTabFldEN.FieldTypeId = null;
 }
 if (objPrjTabFldEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FieldTypeId);
 var strFieldTypeId = objPrjTabFldEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabNullable);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabUnique);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabUnique  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabForeignKey);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabForeignKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsSortFld);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsSortFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsGeneProp);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsGeneProp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsForExtendClass);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsForExtendClass  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabFldEN.CtlTypeIdDu !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.CtlTypeIdDu);
 var strCtlTypeIdDu = objPrjTabFldEN.CtlTypeIdDu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeIdDu + "'");
 }
 
 if (objPrjTabFldEN.FldDispUnitStyleId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldDispUnitStyleId);
 var strFldDispUnitStyleId = objPrjTabFldEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleId + "'");
 }
 
 if (objPrjTabFldEN.InFldId  ==  "")
 {
 objPrjTabFldEN.InFldId = null;
 }
 if (objPrjTabFldEN.InFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.InFldId);
 var strInFldId = objPrjTabFldEN.InFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldId + "'");
 }
 
 if (objPrjTabFldEN.DnPathId  ==  "")
 {
 objPrjTabFldEN.DnPathId = null;
 }
 if (objPrjTabFldEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.DnPathId);
 var strDnPathId = objPrjTabFldEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objPrjTabFldEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.KeyId4Test);
 var strKeyId4Test = objPrjTabFldEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objPrjTabFldEN.DisplayFormat !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.DisplayFormat);
 var strDisplayFormat = objPrjTabFldEN.DisplayFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDisplayFormat + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabFld.IsParentObj);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsParentObj  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabFldEN.PrimaryTypeId  ==  "")
 {
 objPrjTabFldEN.PrimaryTypeId = null;
 }
 if (objPrjTabFldEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.PrimaryTypeId);
 var strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objPrjTabFldEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.ForeignKeyTabId);
 var strForeignKeyTabId = objPrjTabFldEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objPrjTabFldEN.FldOpTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldOpTypeId);
 var strFldOpTypeId = objPrjTabFldEN.FldOpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldOpTypeId + "'");
 }
 
 if (objPrjTabFldEN.SequenceNumber !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.SequenceNumber);
 arrValueListForInsert.Add(objPrjTabFldEN.SequenceNumber.ToString());
 }
 
 if (objPrjTabFldEN.MemoInTab !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.MemoInTab);
 var strMemoInTab = objPrjTabFldEN.MemoInTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemoInTab + "'");
 }
 
 if (objPrjTabFldEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.ErrMsg);
 var strErrMsg = objPrjTabFldEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objPrjTabFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.UpdDate);
 var strUpdDate = objPrjTabFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjTabFldEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.UpdUser);
 var strUpdUser = objPrjTabFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjTabFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.Memo);
 var strMemo = objPrjTabFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTabFld");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjTabFldEN objPrjTabFldEN)
{
 objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabFldEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjTabFldEN.TabId  ==  "")
 {
 objPrjTabFldEN.TabId = null;
 }
 if (objPrjTabFldEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.TabId);
 var strTabId = objPrjTabFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabFldEN.FldId  ==  "")
 {
 objPrjTabFldEN.FldId = null;
 }
 if (objPrjTabFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldId);
 var strFldId = objPrjTabFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objPrjTabFldEN.PrjId  ==  "")
 {
 objPrjTabFldEN.PrjId = null;
 }
 if (objPrjTabFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.PrjId);
 var strPrjId = objPrjTabFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabFldEN.FieldTypeId  ==  "")
 {
 objPrjTabFldEN.FieldTypeId = null;
 }
 if (objPrjTabFldEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FieldTypeId);
 var strFieldTypeId = objPrjTabFldEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabNullable);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabUnique);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabUnique  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabForeignKey);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabForeignKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsSortFld);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsSortFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsGeneProp);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsGeneProp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsForExtendClass);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsForExtendClass  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabFldEN.CtlTypeIdDu !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.CtlTypeIdDu);
 var strCtlTypeIdDu = objPrjTabFldEN.CtlTypeIdDu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeIdDu + "'");
 }
 
 if (objPrjTabFldEN.FldDispUnitStyleId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldDispUnitStyleId);
 var strFldDispUnitStyleId = objPrjTabFldEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleId + "'");
 }
 
 if (objPrjTabFldEN.InFldId  ==  "")
 {
 objPrjTabFldEN.InFldId = null;
 }
 if (objPrjTabFldEN.InFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.InFldId);
 var strInFldId = objPrjTabFldEN.InFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldId + "'");
 }
 
 if (objPrjTabFldEN.DnPathId  ==  "")
 {
 objPrjTabFldEN.DnPathId = null;
 }
 if (objPrjTabFldEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.DnPathId);
 var strDnPathId = objPrjTabFldEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objPrjTabFldEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.KeyId4Test);
 var strKeyId4Test = objPrjTabFldEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objPrjTabFldEN.DisplayFormat !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.DisplayFormat);
 var strDisplayFormat = objPrjTabFldEN.DisplayFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDisplayFormat + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabFld.IsParentObj);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsParentObj  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabFldEN.PrimaryTypeId  ==  "")
 {
 objPrjTabFldEN.PrimaryTypeId = null;
 }
 if (objPrjTabFldEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.PrimaryTypeId);
 var strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objPrjTabFldEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.ForeignKeyTabId);
 var strForeignKeyTabId = objPrjTabFldEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objPrjTabFldEN.FldOpTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldOpTypeId);
 var strFldOpTypeId = objPrjTabFldEN.FldOpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldOpTypeId + "'");
 }
 
 if (objPrjTabFldEN.SequenceNumber !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.SequenceNumber);
 arrValueListForInsert.Add(objPrjTabFldEN.SequenceNumber.ToString());
 }
 
 if (objPrjTabFldEN.MemoInTab !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.MemoInTab);
 var strMemoInTab = objPrjTabFldEN.MemoInTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemoInTab + "'");
 }
 
 if (objPrjTabFldEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.ErrMsg);
 var strErrMsg = objPrjTabFldEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objPrjTabFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.UpdDate);
 var strUpdDate = objPrjTabFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjTabFldEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.UpdUser);
 var strUpdUser = objPrjTabFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjTabFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.Memo);
 var strMemo = objPrjTabFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTabFld");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjTabFldEN objPrjTabFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabFldEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjTabFldEN.TabId  ==  "")
 {
 objPrjTabFldEN.TabId = null;
 }
 if (objPrjTabFldEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.TabId);
 var strTabId = objPrjTabFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabFldEN.FldId  ==  "")
 {
 objPrjTabFldEN.FldId = null;
 }
 if (objPrjTabFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldId);
 var strFldId = objPrjTabFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objPrjTabFldEN.PrjId  ==  "")
 {
 objPrjTabFldEN.PrjId = null;
 }
 if (objPrjTabFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.PrjId);
 var strPrjId = objPrjTabFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabFldEN.FieldTypeId  ==  "")
 {
 objPrjTabFldEN.FieldTypeId = null;
 }
 if (objPrjTabFldEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FieldTypeId);
 var strFieldTypeId = objPrjTabFldEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabNullable);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabUnique);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabUnique  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabForeignKey);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabForeignKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsSortFld);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsSortFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsGeneProp);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsGeneProp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsForExtendClass);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsForExtendClass  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabFldEN.CtlTypeIdDu !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.CtlTypeIdDu);
 var strCtlTypeIdDu = objPrjTabFldEN.CtlTypeIdDu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeIdDu + "'");
 }
 
 if (objPrjTabFldEN.FldDispUnitStyleId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldDispUnitStyleId);
 var strFldDispUnitStyleId = objPrjTabFldEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleId + "'");
 }
 
 if (objPrjTabFldEN.InFldId  ==  "")
 {
 objPrjTabFldEN.InFldId = null;
 }
 if (objPrjTabFldEN.InFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.InFldId);
 var strInFldId = objPrjTabFldEN.InFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldId + "'");
 }
 
 if (objPrjTabFldEN.DnPathId  ==  "")
 {
 objPrjTabFldEN.DnPathId = null;
 }
 if (objPrjTabFldEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.DnPathId);
 var strDnPathId = objPrjTabFldEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objPrjTabFldEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.KeyId4Test);
 var strKeyId4Test = objPrjTabFldEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objPrjTabFldEN.DisplayFormat !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.DisplayFormat);
 var strDisplayFormat = objPrjTabFldEN.DisplayFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDisplayFormat + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabFld.IsParentObj);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsParentObj  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabFldEN.PrimaryTypeId  ==  "")
 {
 objPrjTabFldEN.PrimaryTypeId = null;
 }
 if (objPrjTabFldEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.PrimaryTypeId);
 var strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objPrjTabFldEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.ForeignKeyTabId);
 var strForeignKeyTabId = objPrjTabFldEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objPrjTabFldEN.FldOpTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldOpTypeId);
 var strFldOpTypeId = objPrjTabFldEN.FldOpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldOpTypeId + "'");
 }
 
 if (objPrjTabFldEN.SequenceNumber !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.SequenceNumber);
 arrValueListForInsert.Add(objPrjTabFldEN.SequenceNumber.ToString());
 }
 
 if (objPrjTabFldEN.MemoInTab !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.MemoInTab);
 var strMemoInTab = objPrjTabFldEN.MemoInTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemoInTab + "'");
 }
 
 if (objPrjTabFldEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.ErrMsg);
 var strErrMsg = objPrjTabFldEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objPrjTabFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.UpdDate);
 var strUpdDate = objPrjTabFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjTabFldEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.UpdUser);
 var strUpdUser = objPrjTabFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjTabFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.Memo);
 var strMemo = objPrjTabFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTabFld");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjTabFldEN objPrjTabFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabFldEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjTabFldEN.TabId  ==  "")
 {
 objPrjTabFldEN.TabId = null;
 }
 if (objPrjTabFldEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.TabId);
 var strTabId = objPrjTabFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabFldEN.FldId  ==  "")
 {
 objPrjTabFldEN.FldId = null;
 }
 if (objPrjTabFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldId);
 var strFldId = objPrjTabFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objPrjTabFldEN.PrjId  ==  "")
 {
 objPrjTabFldEN.PrjId = null;
 }
 if (objPrjTabFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.PrjId);
 var strPrjId = objPrjTabFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabFldEN.FieldTypeId  ==  "")
 {
 objPrjTabFldEN.FieldTypeId = null;
 }
 if (objPrjTabFldEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FieldTypeId);
 var strFieldTypeId = objPrjTabFldEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabNullable);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabUnique);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabUnique  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsTabForeignKey);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsTabForeignKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsSortFld);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsSortFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsGeneProp);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsGeneProp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabFld.IsForExtendClass);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsForExtendClass  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabFldEN.CtlTypeIdDu !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.CtlTypeIdDu);
 var strCtlTypeIdDu = objPrjTabFldEN.CtlTypeIdDu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtlTypeIdDu + "'");
 }
 
 if (objPrjTabFldEN.FldDispUnitStyleId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldDispUnitStyleId);
 var strFldDispUnitStyleId = objPrjTabFldEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldDispUnitStyleId + "'");
 }
 
 if (objPrjTabFldEN.InFldId  ==  "")
 {
 objPrjTabFldEN.InFldId = null;
 }
 if (objPrjTabFldEN.InFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.InFldId);
 var strInFldId = objPrjTabFldEN.InFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldId + "'");
 }
 
 if (objPrjTabFldEN.DnPathId  ==  "")
 {
 objPrjTabFldEN.DnPathId = null;
 }
 if (objPrjTabFldEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.DnPathId);
 var strDnPathId = objPrjTabFldEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objPrjTabFldEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.KeyId4Test);
 var strKeyId4Test = objPrjTabFldEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objPrjTabFldEN.DisplayFormat !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.DisplayFormat);
 var strDisplayFormat = objPrjTabFldEN.DisplayFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDisplayFormat + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabFld.IsParentObj);
 arrValueListForInsert.Add("'" + (objPrjTabFldEN.IsParentObj  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabFldEN.PrimaryTypeId  ==  "")
 {
 objPrjTabFldEN.PrimaryTypeId = null;
 }
 if (objPrjTabFldEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.PrimaryTypeId);
 var strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objPrjTabFldEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.ForeignKeyTabId);
 var strForeignKeyTabId = objPrjTabFldEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objPrjTabFldEN.FldOpTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.FldOpTypeId);
 var strFldOpTypeId = objPrjTabFldEN.FldOpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldOpTypeId + "'");
 }
 
 if (objPrjTabFldEN.SequenceNumber !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.SequenceNumber);
 arrValueListForInsert.Add(objPrjTabFldEN.SequenceNumber.ToString());
 }
 
 if (objPrjTabFldEN.MemoInTab !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.MemoInTab);
 var strMemoInTab = objPrjTabFldEN.MemoInTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemoInTab + "'");
 }
 
 if (objPrjTabFldEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.ErrMsg);
 var strErrMsg = objPrjTabFldEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objPrjTabFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.UpdDate);
 var strUpdDate = objPrjTabFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjTabFldEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.UpdUser);
 var strUpdUser = objPrjTabFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPrjTabFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabFld.Memo);
 var strMemo = objPrjTabFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTabFld");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjTabFlds(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabFld where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjTabFld");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conPrjTabFld.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjTabFldEN._CurrTabName ].NewRow();
objRow[conPrjTabFld.TabId] = oRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objRow[conPrjTabFld.FldId] = oRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objRow[conPrjTabFld.PrjId] = oRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objRow[conPrjTabFld.FieldTypeId] = oRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objRow[conPrjTabFld.IsTabNullable] = oRow[conPrjTabFld.IsTabNullable].ToString().Trim(); //是否表中可空
objRow[conPrjTabFld.IsTabUnique] = oRow[conPrjTabFld.IsTabUnique].ToString().Trim(); //是否表中唯一
objRow[conPrjTabFld.IsTabForeignKey] = oRow[conPrjTabFld.IsTabForeignKey].ToString().Trim(); //是否表外键
objRow[conPrjTabFld.IsSortFld] = oRow[conPrjTabFld.IsSortFld].ToString().Trim(); //是否排序字段
objRow[conPrjTabFld.IsGeneProp] = oRow[conPrjTabFld.IsGeneProp].ToString().Trim(); //是否生成属性
objRow[conPrjTabFld.IsForExtendClass] = oRow[conPrjTabFld.IsForExtendClass].ToString().Trim(); //用于扩展类
objRow[conPrjTabFld.CtlTypeIdDu] = oRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objRow[conPrjTabFld.FldDispUnitStyleId] = oRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objRow[conPrjTabFld.InFldId] = oRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objRow[conPrjTabFld.DnPathId] = oRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objRow[conPrjTabFld.KeyId4Test] = oRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objRow[conPrjTabFld.DisplayFormat] = oRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objRow[conPrjTabFld.IsParentObj] = oRow[conPrjTabFld.IsParentObj].ToString().Trim(); //是否父对象
objRow[conPrjTabFld.PrimaryTypeId] = oRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objRow[conPrjTabFld.ForeignKeyTabId] = oRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objRow[conPrjTabFld.FldOpTypeId] = oRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objRow[conPrjTabFld.SequenceNumber] = oRow[conPrjTabFld.SequenceNumber].ToString().Trim(); //顺序号
objRow[conPrjTabFld.MemoInTab] = oRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objRow[conPrjTabFld.ErrMsg] = oRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objRow[conPrjTabFld.UpdDate] = oRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objRow[conPrjTabFld.UpdUser] = oRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objRow[conPrjTabFld.Memo] = oRow[conPrjTabFld.Memo].ToString().Trim(); //说明
 objDS.Tables[clsPrjTabFldEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjTabFldEN._CurrTabName);
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
 /// <param name = "objPrjTabFldEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjTabFldEN objPrjTabFldEN)
{
 objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabFldEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabFld where mId = " + ""+ objPrjTabFldEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjTabFldEN._CurrTabName);
if (objDS.Tables[clsPrjTabFldEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objPrjTabFldEN.mId+"");
return false;
}
objRow = objDS.Tables[clsPrjTabFldEN._CurrTabName].Rows[0];
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.TabId))
 {
objRow[conPrjTabFld.TabId] = objPrjTabFldEN.TabId; //表ID
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldId))
 {
objRow[conPrjTabFld.FldId] = objPrjTabFldEN.FldId; //字段Id
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.PrjId))
 {
objRow[conPrjTabFld.PrjId] = objPrjTabFldEN.PrjId; //工程Id
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FieldTypeId))
 {
objRow[conPrjTabFld.FieldTypeId] = objPrjTabFldEN.FieldTypeId; //字段类型Id
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabNullable))
 {
objRow[conPrjTabFld.IsTabNullable] = objPrjTabFldEN.IsTabNullable; //是否表中可空
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabUnique))
 {
objRow[conPrjTabFld.IsTabUnique] = objPrjTabFldEN.IsTabUnique; //是否表中唯一
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabForeignKey))
 {
objRow[conPrjTabFld.IsTabForeignKey] = objPrjTabFldEN.IsTabForeignKey; //是否表外键
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsSortFld))
 {
objRow[conPrjTabFld.IsSortFld] = objPrjTabFldEN.IsSortFld; //是否排序字段
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsGeneProp))
 {
objRow[conPrjTabFld.IsGeneProp] = objPrjTabFldEN.IsGeneProp; //是否生成属性
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsForExtendClass))
 {
objRow[conPrjTabFld.IsForExtendClass] = objPrjTabFldEN.IsForExtendClass; //用于扩展类
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.CtlTypeIdDu))
 {
objRow[conPrjTabFld.CtlTypeIdDu] = objPrjTabFldEN.CtlTypeIdDu; //控件类型Id_du
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldDispUnitStyleId))
 {
objRow[conPrjTabFld.FldDispUnitStyleId] = objPrjTabFldEN.FldDispUnitStyleId; //字段显示单元样式Id
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.InFldId))
 {
objRow[conPrjTabFld.InFldId] = objPrjTabFldEN.InFldId; //In字段Id
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.DnPathId))
 {
objRow[conPrjTabFld.DnPathId] = objPrjTabFldEN.DnPathId; //DN路径Id
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.KeyId4Test))
 {
objRow[conPrjTabFld.KeyId4Test] = objPrjTabFldEN.KeyId4Test; //测试关键字Id
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.DisplayFormat))
 {
objRow[conPrjTabFld.DisplayFormat] = objPrjTabFldEN.DisplayFormat; //显示格式
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsParentObj))
 {
objRow[conPrjTabFld.IsParentObj] = objPrjTabFldEN.IsParentObj; //是否父对象
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.PrimaryTypeId))
 {
objRow[conPrjTabFld.PrimaryTypeId] = objPrjTabFldEN.PrimaryTypeId; //主键类型ID
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.ForeignKeyTabId))
 {
objRow[conPrjTabFld.ForeignKeyTabId] = objPrjTabFldEN.ForeignKeyTabId; //外键表ID
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldOpTypeId))
 {
objRow[conPrjTabFld.FldOpTypeId] = objPrjTabFldEN.FldOpTypeId; //字段操作类型Id
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.SequenceNumber))
 {
objRow[conPrjTabFld.SequenceNumber] = objPrjTabFldEN.SequenceNumber; //顺序号
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.MemoInTab))
 {
objRow[conPrjTabFld.MemoInTab] = objPrjTabFldEN.MemoInTab; //表中说明
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.ErrMsg))
 {
objRow[conPrjTabFld.ErrMsg] = objPrjTabFldEN.ErrMsg; //错误信息
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.UpdDate))
 {
objRow[conPrjTabFld.UpdDate] = objPrjTabFldEN.UpdDate; //修改日期
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.UpdUser))
 {
objRow[conPrjTabFld.UpdUser] = objPrjTabFldEN.UpdUser; //修改者
 }
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.Memo))
 {
objRow[conPrjTabFld.Memo] = objPrjTabFldEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsPrjTabFldEN._CurrTabName);
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
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjTabFldEN objPrjTabFldEN)
{
 objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjTabFld Set ");
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.TabId))
 {
 if (objPrjTabFldEN.TabId  ==  "")
 {
 objPrjTabFldEN.TabId = null;
 }
 if (objPrjTabFldEN.TabId !=  null)
 {
 var strTabId = objPrjTabFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conPrjTabFld.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.TabId); //表ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldId))
 {
 if (objPrjTabFldEN.FldId  ==  "")
 {
 objPrjTabFldEN.FldId = null;
 }
 if (objPrjTabFldEN.FldId !=  null)
 {
 var strFldId = objPrjTabFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conPrjTabFld.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.FldId); //字段Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.PrjId))
 {
 if (objPrjTabFldEN.PrjId  ==  "")
 {
 objPrjTabFldEN.PrjId = null;
 }
 if (objPrjTabFldEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjTabFld.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.PrjId); //工程Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FieldTypeId))
 {
 if (objPrjTabFldEN.FieldTypeId  ==  "")
 {
 objPrjTabFldEN.FieldTypeId = null;
 }
 if (objPrjTabFldEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objPrjTabFldEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conPrjTabFld.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.FieldTypeId); //字段类型Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabNullable))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsTabNullable == true?"1":"0", conPrjTabFld.IsTabNullable); //是否表中可空
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabUnique))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsTabUnique == true?"1":"0", conPrjTabFld.IsTabUnique); //是否表中唯一
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabForeignKey))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsTabForeignKey == true?"1":"0", conPrjTabFld.IsTabForeignKey); //是否表外键
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsSortFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsSortFld == true?"1":"0", conPrjTabFld.IsSortFld); //是否排序字段
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsGeneProp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsGeneProp == true?"1":"0", conPrjTabFld.IsGeneProp); //是否生成属性
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsForExtendClass))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsForExtendClass == true?"1":"0", conPrjTabFld.IsForExtendClass); //用于扩展类
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.CtlTypeIdDu))
 {
 if (objPrjTabFldEN.CtlTypeIdDu !=  null)
 {
 var strCtlTypeIdDu = objPrjTabFldEN.CtlTypeIdDu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeIdDu, conPrjTabFld.CtlTypeIdDu); //控件类型Id_du
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.CtlTypeIdDu); //控件类型Id_du
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldDispUnitStyleId))
 {
 if (objPrjTabFldEN.FldDispUnitStyleId !=  null)
 {
 var strFldDispUnitStyleId = objPrjTabFldEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldDispUnitStyleId, conPrjTabFld.FldDispUnitStyleId); //字段显示单元样式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.FldDispUnitStyleId); //字段显示单元样式Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.InFldId))
 {
 if (objPrjTabFldEN.InFldId  ==  "")
 {
 objPrjTabFldEN.InFldId = null;
 }
 if (objPrjTabFldEN.InFldId !=  null)
 {
 var strInFldId = objPrjTabFldEN.InFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInFldId, conPrjTabFld.InFldId); //In字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.InFldId); //In字段Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.DnPathId))
 {
 if (objPrjTabFldEN.DnPathId  ==  "")
 {
 objPrjTabFldEN.DnPathId = null;
 }
 if (objPrjTabFldEN.DnPathId !=  null)
 {
 var strDnPathId = objPrjTabFldEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnPathId, conPrjTabFld.DnPathId); //DN路径Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.DnPathId); //DN路径Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.KeyId4Test))
 {
 if (objPrjTabFldEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objPrjTabFldEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyId4Test, conPrjTabFld.KeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.KeyId4Test); //测试关键字Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.DisplayFormat))
 {
 if (objPrjTabFldEN.DisplayFormat !=  null)
 {
 var strDisplayFormat = objPrjTabFldEN.DisplayFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDisplayFormat, conPrjTabFld.DisplayFormat); //显示格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.DisplayFormat); //显示格式
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsParentObj))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsParentObj == true?"1":"0", conPrjTabFld.IsParentObj); //是否父对象
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.PrimaryTypeId))
 {
 if (objPrjTabFldEN.PrimaryTypeId  ==  "")
 {
 objPrjTabFldEN.PrimaryTypeId = null;
 }
 if (objPrjTabFldEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeId, conPrjTabFld.PrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.PrimaryTypeId); //主键类型ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.ForeignKeyTabId))
 {
 if (objPrjTabFldEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objPrjTabFldEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyTabId, conPrjTabFld.ForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.ForeignKeyTabId); //外键表ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldOpTypeId))
 {
 if (objPrjTabFldEN.FldOpTypeId !=  null)
 {
 var strFldOpTypeId = objPrjTabFldEN.FldOpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldOpTypeId, conPrjTabFld.FldOpTypeId); //字段操作类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.FldOpTypeId); //字段操作类型Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.SequenceNumber))
 {
 if (objPrjTabFldEN.SequenceNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabFldEN.SequenceNumber, conPrjTabFld.SequenceNumber); //顺序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.SequenceNumber); //顺序号
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.MemoInTab))
 {
 if (objPrjTabFldEN.MemoInTab !=  null)
 {
 var strMemoInTab = objPrjTabFldEN.MemoInTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemoInTab, conPrjTabFld.MemoInTab); //表中说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.MemoInTab); //表中说明
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.ErrMsg))
 {
 if (objPrjTabFldEN.ErrMsg !=  null)
 {
 var strErrMsg = objPrjTabFldEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conPrjTabFld.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.ErrMsg); //错误信息
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.UpdDate))
 {
 if (objPrjTabFldEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjTabFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjTabFld.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.UpdDate); //修改日期
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.UpdUser))
 {
 if (objPrjTabFldEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjTabFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPrjTabFld.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.UpdUser); //修改者
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.Memo))
 {
 if (objPrjTabFldEN.Memo !=  null)
 {
 var strMemo = objPrjTabFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjTabFld.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objPrjTabFldEN.mId); 
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
 /// <param name = "objPrjTabFldEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjTabFldEN objPrjTabFldEN, string strCondition)
{
 objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjTabFld Set ");
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.TabId))
 {
 if (objPrjTabFldEN.TabId  ==  "")
 {
 objPrjTabFldEN.TabId = null;
 }
 if (objPrjTabFldEN.TabId !=  null)
 {
 var strTabId = objPrjTabFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldId))
 {
 if (objPrjTabFldEN.FldId  ==  "")
 {
 objPrjTabFldEN.FldId = null;
 }
 if (objPrjTabFldEN.FldId !=  null)
 {
 var strFldId = objPrjTabFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.PrjId))
 {
 if (objPrjTabFldEN.PrjId  ==  "")
 {
 objPrjTabFldEN.PrjId = null;
 }
 if (objPrjTabFldEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FieldTypeId))
 {
 if (objPrjTabFldEN.FieldTypeId  ==  "")
 {
 objPrjTabFldEN.FieldTypeId = null;
 }
 if (objPrjTabFldEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objPrjTabFldEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabNullable))
 {
 sbSQL.AppendFormat(" IsTabNullable = '{0}',", objPrjTabFldEN.IsTabNullable == true?"1":"0"); //是否表中可空
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabUnique))
 {
 sbSQL.AppendFormat(" IsTabUnique = '{0}',", objPrjTabFldEN.IsTabUnique == true?"1":"0"); //是否表中唯一
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabForeignKey))
 {
 sbSQL.AppendFormat(" IsTabForeignKey = '{0}',", objPrjTabFldEN.IsTabForeignKey == true?"1":"0"); //是否表外键
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsSortFld))
 {
 sbSQL.AppendFormat(" IsSortFld = '{0}',", objPrjTabFldEN.IsSortFld == true?"1":"0"); //是否排序字段
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsGeneProp))
 {
 sbSQL.AppendFormat(" IsGeneProp = '{0}',", objPrjTabFldEN.IsGeneProp == true?"1":"0"); //是否生成属性
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsForExtendClass))
 {
 sbSQL.AppendFormat(" IsForExtendClass = '{0}',", objPrjTabFldEN.IsForExtendClass == true?"1":"0"); //用于扩展类
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.CtlTypeIdDu))
 {
 if (objPrjTabFldEN.CtlTypeIdDu !=  null)
 {
 var strCtlTypeIdDu = objPrjTabFldEN.CtlTypeIdDu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeIdDu = '{0}',", strCtlTypeIdDu); //控件类型Id_du
 }
 else
 {
 sbSQL.Append(" CtlTypeIdDu = null,"); //控件类型Id_du
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldDispUnitStyleId))
 {
 if (objPrjTabFldEN.FldDispUnitStyleId !=  null)
 {
 var strFldDispUnitStyleId = objPrjTabFldEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldDispUnitStyleId = '{0}',", strFldDispUnitStyleId); //字段显示单元样式Id
 }
 else
 {
 sbSQL.Append(" FldDispUnitStyleId = null,"); //字段显示单元样式Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.InFldId))
 {
 if (objPrjTabFldEN.InFldId  ==  "")
 {
 objPrjTabFldEN.InFldId = null;
 }
 if (objPrjTabFldEN.InFldId !=  null)
 {
 var strInFldId = objPrjTabFldEN.InFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InFldId = '{0}',", strInFldId); //In字段Id
 }
 else
 {
 sbSQL.Append(" InFldId = null,"); //In字段Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.DnPathId))
 {
 if (objPrjTabFldEN.DnPathId  ==  "")
 {
 objPrjTabFldEN.DnPathId = null;
 }
 if (objPrjTabFldEN.DnPathId !=  null)
 {
 var strDnPathId = objPrjTabFldEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnPathId = '{0}',", strDnPathId); //DN路径Id
 }
 else
 {
 sbSQL.Append(" DnPathId = null,"); //DN路径Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.KeyId4Test))
 {
 if (objPrjTabFldEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objPrjTabFldEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyId4Test = '{0}',", strKeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.Append(" KeyId4Test = null,"); //测试关键字Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.DisplayFormat))
 {
 if (objPrjTabFldEN.DisplayFormat !=  null)
 {
 var strDisplayFormat = objPrjTabFldEN.DisplayFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DisplayFormat = '{0}',", strDisplayFormat); //显示格式
 }
 else
 {
 sbSQL.Append(" DisplayFormat = null,"); //显示格式
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsParentObj))
 {
 sbSQL.AppendFormat(" IsParentObj = '{0}',", objPrjTabFldEN.IsParentObj == true?"1":"0"); //是否父对象
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.PrimaryTypeId))
 {
 if (objPrjTabFldEN.PrimaryTypeId  ==  "")
 {
 objPrjTabFldEN.PrimaryTypeId = null;
 }
 if (objPrjTabFldEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeId = '{0}',", strPrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.Append(" PrimaryTypeId = null,"); //主键类型ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.ForeignKeyTabId))
 {
 if (objPrjTabFldEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objPrjTabFldEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyTabId = '{0}',", strForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.Append(" ForeignKeyTabId = null,"); //外键表ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldOpTypeId))
 {
 if (objPrjTabFldEN.FldOpTypeId !=  null)
 {
 var strFldOpTypeId = objPrjTabFldEN.FldOpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldOpTypeId = '{0}',", strFldOpTypeId); //字段操作类型Id
 }
 else
 {
 sbSQL.Append(" FldOpTypeId = null,"); //字段操作类型Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.SequenceNumber))
 {
 if (objPrjTabFldEN.SequenceNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabFldEN.SequenceNumber, conPrjTabFld.SequenceNumber); //顺序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.SequenceNumber); //顺序号
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.MemoInTab))
 {
 if (objPrjTabFldEN.MemoInTab !=  null)
 {
 var strMemoInTab = objPrjTabFldEN.MemoInTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MemoInTab = '{0}',", strMemoInTab); //表中说明
 }
 else
 {
 sbSQL.Append(" MemoInTab = null,"); //表中说明
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.ErrMsg))
 {
 if (objPrjTabFldEN.ErrMsg !=  null)
 {
 var strErrMsg = objPrjTabFldEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.UpdDate))
 {
 if (objPrjTabFldEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjTabFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.UpdUser))
 {
 if (objPrjTabFldEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjTabFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.Memo))
 {
 if (objPrjTabFldEN.Memo !=  null)
 {
 var strMemo = objPrjTabFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjTabFldEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjTabFldEN objPrjTabFldEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjTabFld Set ");
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.TabId))
 {
 if (objPrjTabFldEN.TabId  ==  "")
 {
 objPrjTabFldEN.TabId = null;
 }
 if (objPrjTabFldEN.TabId !=  null)
 {
 var strTabId = objPrjTabFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldId))
 {
 if (objPrjTabFldEN.FldId  ==  "")
 {
 objPrjTabFldEN.FldId = null;
 }
 if (objPrjTabFldEN.FldId !=  null)
 {
 var strFldId = objPrjTabFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.PrjId))
 {
 if (objPrjTabFldEN.PrjId  ==  "")
 {
 objPrjTabFldEN.PrjId = null;
 }
 if (objPrjTabFldEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FieldTypeId))
 {
 if (objPrjTabFldEN.FieldTypeId  ==  "")
 {
 objPrjTabFldEN.FieldTypeId = null;
 }
 if (objPrjTabFldEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objPrjTabFldEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabNullable))
 {
 sbSQL.AppendFormat(" IsTabNullable = '{0}',", objPrjTabFldEN.IsTabNullable == true?"1":"0"); //是否表中可空
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabUnique))
 {
 sbSQL.AppendFormat(" IsTabUnique = '{0}',", objPrjTabFldEN.IsTabUnique == true?"1":"0"); //是否表中唯一
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabForeignKey))
 {
 sbSQL.AppendFormat(" IsTabForeignKey = '{0}',", objPrjTabFldEN.IsTabForeignKey == true?"1":"0"); //是否表外键
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsSortFld))
 {
 sbSQL.AppendFormat(" IsSortFld = '{0}',", objPrjTabFldEN.IsSortFld == true?"1":"0"); //是否排序字段
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsGeneProp))
 {
 sbSQL.AppendFormat(" IsGeneProp = '{0}',", objPrjTabFldEN.IsGeneProp == true?"1":"0"); //是否生成属性
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsForExtendClass))
 {
 sbSQL.AppendFormat(" IsForExtendClass = '{0}',", objPrjTabFldEN.IsForExtendClass == true?"1":"0"); //用于扩展类
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.CtlTypeIdDu))
 {
 if (objPrjTabFldEN.CtlTypeIdDu !=  null)
 {
 var strCtlTypeIdDu = objPrjTabFldEN.CtlTypeIdDu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeIdDu = '{0}',", strCtlTypeIdDu); //控件类型Id_du
 }
 else
 {
 sbSQL.Append(" CtlTypeIdDu = null,"); //控件类型Id_du
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldDispUnitStyleId))
 {
 if (objPrjTabFldEN.FldDispUnitStyleId !=  null)
 {
 var strFldDispUnitStyleId = objPrjTabFldEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldDispUnitStyleId = '{0}',", strFldDispUnitStyleId); //字段显示单元样式Id
 }
 else
 {
 sbSQL.Append(" FldDispUnitStyleId = null,"); //字段显示单元样式Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.InFldId))
 {
 if (objPrjTabFldEN.InFldId  ==  "")
 {
 objPrjTabFldEN.InFldId = null;
 }
 if (objPrjTabFldEN.InFldId !=  null)
 {
 var strInFldId = objPrjTabFldEN.InFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InFldId = '{0}',", strInFldId); //In字段Id
 }
 else
 {
 sbSQL.Append(" InFldId = null,"); //In字段Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.DnPathId))
 {
 if (objPrjTabFldEN.DnPathId  ==  "")
 {
 objPrjTabFldEN.DnPathId = null;
 }
 if (objPrjTabFldEN.DnPathId !=  null)
 {
 var strDnPathId = objPrjTabFldEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnPathId = '{0}',", strDnPathId); //DN路径Id
 }
 else
 {
 sbSQL.Append(" DnPathId = null,"); //DN路径Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.KeyId4Test))
 {
 if (objPrjTabFldEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objPrjTabFldEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyId4Test = '{0}',", strKeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.Append(" KeyId4Test = null,"); //测试关键字Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.DisplayFormat))
 {
 if (objPrjTabFldEN.DisplayFormat !=  null)
 {
 var strDisplayFormat = objPrjTabFldEN.DisplayFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DisplayFormat = '{0}',", strDisplayFormat); //显示格式
 }
 else
 {
 sbSQL.Append(" DisplayFormat = null,"); //显示格式
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsParentObj))
 {
 sbSQL.AppendFormat(" IsParentObj = '{0}',", objPrjTabFldEN.IsParentObj == true?"1":"0"); //是否父对象
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.PrimaryTypeId))
 {
 if (objPrjTabFldEN.PrimaryTypeId  ==  "")
 {
 objPrjTabFldEN.PrimaryTypeId = null;
 }
 if (objPrjTabFldEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeId = '{0}',", strPrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.Append(" PrimaryTypeId = null,"); //主键类型ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.ForeignKeyTabId))
 {
 if (objPrjTabFldEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objPrjTabFldEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyTabId = '{0}',", strForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.Append(" ForeignKeyTabId = null,"); //外键表ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldOpTypeId))
 {
 if (objPrjTabFldEN.FldOpTypeId !=  null)
 {
 var strFldOpTypeId = objPrjTabFldEN.FldOpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldOpTypeId = '{0}',", strFldOpTypeId); //字段操作类型Id
 }
 else
 {
 sbSQL.Append(" FldOpTypeId = null,"); //字段操作类型Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.SequenceNumber))
 {
 if (objPrjTabFldEN.SequenceNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabFldEN.SequenceNumber, conPrjTabFld.SequenceNumber); //顺序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.SequenceNumber); //顺序号
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.MemoInTab))
 {
 if (objPrjTabFldEN.MemoInTab !=  null)
 {
 var strMemoInTab = objPrjTabFldEN.MemoInTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MemoInTab = '{0}',", strMemoInTab); //表中说明
 }
 else
 {
 sbSQL.Append(" MemoInTab = null,"); //表中说明
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.ErrMsg))
 {
 if (objPrjTabFldEN.ErrMsg !=  null)
 {
 var strErrMsg = objPrjTabFldEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.UpdDate))
 {
 if (objPrjTabFldEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjTabFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.UpdUser))
 {
 if (objPrjTabFldEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjTabFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.Memo))
 {
 if (objPrjTabFldEN.Memo !=  null)
 {
 var strMemo = objPrjTabFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjTabFldEN objPrjTabFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjTabFld Set ");
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.TabId))
 {
 if (objPrjTabFldEN.TabId  ==  "")
 {
 objPrjTabFldEN.TabId = null;
 }
 if (objPrjTabFldEN.TabId !=  null)
 {
 var strTabId = objPrjTabFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conPrjTabFld.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.TabId); //表ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldId))
 {
 if (objPrjTabFldEN.FldId  ==  "")
 {
 objPrjTabFldEN.FldId = null;
 }
 if (objPrjTabFldEN.FldId !=  null)
 {
 var strFldId = objPrjTabFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conPrjTabFld.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.FldId); //字段Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.PrjId))
 {
 if (objPrjTabFldEN.PrjId  ==  "")
 {
 objPrjTabFldEN.PrjId = null;
 }
 if (objPrjTabFldEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjTabFld.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.PrjId); //工程Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FieldTypeId))
 {
 if (objPrjTabFldEN.FieldTypeId  ==  "")
 {
 objPrjTabFldEN.FieldTypeId = null;
 }
 if (objPrjTabFldEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objPrjTabFldEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conPrjTabFld.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.FieldTypeId); //字段类型Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabNullable))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsTabNullable == true?"1":"0", conPrjTabFld.IsTabNullable); //是否表中可空
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabUnique))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsTabUnique == true?"1":"0", conPrjTabFld.IsTabUnique); //是否表中唯一
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsTabForeignKey))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsTabForeignKey == true?"1":"0", conPrjTabFld.IsTabForeignKey); //是否表外键
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsSortFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsSortFld == true?"1":"0", conPrjTabFld.IsSortFld); //是否排序字段
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsGeneProp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsGeneProp == true?"1":"0", conPrjTabFld.IsGeneProp); //是否生成属性
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsForExtendClass))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsForExtendClass == true?"1":"0", conPrjTabFld.IsForExtendClass); //用于扩展类
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.CtlTypeIdDu))
 {
 if (objPrjTabFldEN.CtlTypeIdDu !=  null)
 {
 var strCtlTypeIdDu = objPrjTabFldEN.CtlTypeIdDu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCtlTypeIdDu, conPrjTabFld.CtlTypeIdDu); //控件类型Id_du
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.CtlTypeIdDu); //控件类型Id_du
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldDispUnitStyleId))
 {
 if (objPrjTabFldEN.FldDispUnitStyleId !=  null)
 {
 var strFldDispUnitStyleId = objPrjTabFldEN.FldDispUnitStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldDispUnitStyleId, conPrjTabFld.FldDispUnitStyleId); //字段显示单元样式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.FldDispUnitStyleId); //字段显示单元样式Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.InFldId))
 {
 if (objPrjTabFldEN.InFldId  ==  "")
 {
 objPrjTabFldEN.InFldId = null;
 }
 if (objPrjTabFldEN.InFldId !=  null)
 {
 var strInFldId = objPrjTabFldEN.InFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInFldId, conPrjTabFld.InFldId); //In字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.InFldId); //In字段Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.DnPathId))
 {
 if (objPrjTabFldEN.DnPathId  ==  "")
 {
 objPrjTabFldEN.DnPathId = null;
 }
 if (objPrjTabFldEN.DnPathId !=  null)
 {
 var strDnPathId = objPrjTabFldEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnPathId, conPrjTabFld.DnPathId); //DN路径Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.DnPathId); //DN路径Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.KeyId4Test))
 {
 if (objPrjTabFldEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objPrjTabFldEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyId4Test, conPrjTabFld.KeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.KeyId4Test); //测试关键字Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.DisplayFormat))
 {
 if (objPrjTabFldEN.DisplayFormat !=  null)
 {
 var strDisplayFormat = objPrjTabFldEN.DisplayFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDisplayFormat, conPrjTabFld.DisplayFormat); //显示格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.DisplayFormat); //显示格式
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.IsParentObj))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabFldEN.IsParentObj == true?"1":"0", conPrjTabFld.IsParentObj); //是否父对象
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.PrimaryTypeId))
 {
 if (objPrjTabFldEN.PrimaryTypeId  ==  "")
 {
 objPrjTabFldEN.PrimaryTypeId = null;
 }
 if (objPrjTabFldEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeId, conPrjTabFld.PrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.PrimaryTypeId); //主键类型ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.ForeignKeyTabId))
 {
 if (objPrjTabFldEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objPrjTabFldEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyTabId, conPrjTabFld.ForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.ForeignKeyTabId); //外键表ID
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.FldOpTypeId))
 {
 if (objPrjTabFldEN.FldOpTypeId !=  null)
 {
 var strFldOpTypeId = objPrjTabFldEN.FldOpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldOpTypeId, conPrjTabFld.FldOpTypeId); //字段操作类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.FldOpTypeId); //字段操作类型Id
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.SequenceNumber))
 {
 if (objPrjTabFldEN.SequenceNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabFldEN.SequenceNumber, conPrjTabFld.SequenceNumber); //顺序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.SequenceNumber); //顺序号
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.MemoInTab))
 {
 if (objPrjTabFldEN.MemoInTab !=  null)
 {
 var strMemoInTab = objPrjTabFldEN.MemoInTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemoInTab, conPrjTabFld.MemoInTab); //表中说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.MemoInTab); //表中说明
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.ErrMsg))
 {
 if (objPrjTabFldEN.ErrMsg !=  null)
 {
 var strErrMsg = objPrjTabFldEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conPrjTabFld.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.ErrMsg); //错误信息
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.UpdDate))
 {
 if (objPrjTabFldEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjTabFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjTabFld.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.UpdDate); //修改日期
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.UpdUser))
 {
 if (objPrjTabFldEN.UpdUser !=  null)
 {
 var strUpdUser = objPrjTabFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPrjTabFld.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.UpdUser); //修改者
 }
 }
 
 if (objPrjTabFldEN.IsUpdated(conPrjTabFld.Memo))
 {
 if (objPrjTabFldEN.Memo !=  null)
 {
 var strMemo = objPrjTabFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjTabFld.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabFld.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objPrjTabFldEN.mId); 
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("PrjTabFld_Delete", values);
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
//删除PrjTabFld本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjTabFld where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjTabFld(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
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
//删除PrjTabFld本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjTabFld where mId in (" + strKeyList + ")";
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
//删除PrjTabFld本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjTabFld where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjTabFld(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjTabFldDA: DelPrjTabFld)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjTabFld where " + strCondition ;
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
public bool DelPrjTabFldWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjTabFldDA: DelPrjTabFldWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjTabFld where " + strCondition ;
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
 /// <param name = "objPrjTabFldENS">源对象</param>
 /// <param name = "objPrjTabFldENT">目标对象</param>
public void CopyTo(clsPrjTabFldEN objPrjTabFldENS, clsPrjTabFldEN objPrjTabFldENT)
{
objPrjTabFldENT.mId = objPrjTabFldENS.mId; //mId
objPrjTabFldENT.TabId = objPrjTabFldENS.TabId; //表ID
objPrjTabFldENT.FldId = objPrjTabFldENS.FldId; //字段Id
objPrjTabFldENT.PrjId = objPrjTabFldENS.PrjId; //工程Id
objPrjTabFldENT.FieldTypeId = objPrjTabFldENS.FieldTypeId; //字段类型Id
objPrjTabFldENT.IsTabNullable = objPrjTabFldENS.IsTabNullable; //是否表中可空
objPrjTabFldENT.IsTabUnique = objPrjTabFldENS.IsTabUnique; //是否表中唯一
objPrjTabFldENT.IsTabForeignKey = objPrjTabFldENS.IsTabForeignKey; //是否表外键
objPrjTabFldENT.IsSortFld = objPrjTabFldENS.IsSortFld; //是否排序字段
objPrjTabFldENT.IsGeneProp = objPrjTabFldENS.IsGeneProp; //是否生成属性
objPrjTabFldENT.IsForExtendClass = objPrjTabFldENS.IsForExtendClass; //用于扩展类
objPrjTabFldENT.CtlTypeIdDu = objPrjTabFldENS.CtlTypeIdDu; //控件类型Id_du
objPrjTabFldENT.FldDispUnitStyleId = objPrjTabFldENS.FldDispUnitStyleId; //字段显示单元样式Id
objPrjTabFldENT.InFldId = objPrjTabFldENS.InFldId; //In字段Id
objPrjTabFldENT.DnPathId = objPrjTabFldENS.DnPathId; //DN路径Id
objPrjTabFldENT.KeyId4Test = objPrjTabFldENS.KeyId4Test; //测试关键字Id
objPrjTabFldENT.DisplayFormat = objPrjTabFldENS.DisplayFormat; //显示格式
objPrjTabFldENT.IsParentObj = objPrjTabFldENS.IsParentObj; //是否父对象
objPrjTabFldENT.PrimaryTypeId = objPrjTabFldENS.PrimaryTypeId; //主键类型ID
objPrjTabFldENT.ForeignKeyTabId = objPrjTabFldENS.ForeignKeyTabId; //外键表ID
objPrjTabFldENT.FldOpTypeId = objPrjTabFldENS.FldOpTypeId; //字段操作类型Id
objPrjTabFldENT.SequenceNumber = objPrjTabFldENS.SequenceNumber; //顺序号
objPrjTabFldENT.MemoInTab = objPrjTabFldENS.MemoInTab; //表中说明
objPrjTabFldENT.ErrMsg = objPrjTabFldENS.ErrMsg; //错误信息
objPrjTabFldENT.UpdDate = objPrjTabFldENS.UpdDate; //修改日期
objPrjTabFldENT.UpdUser = objPrjTabFldENS.UpdUser; //修改者
objPrjTabFldENT.Memo = objPrjTabFldENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjTabFldEN objPrjTabFldEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjTabFldEN.TabId, conPrjTabFld.TabId);
clsCheckSql.CheckFieldNotNull(objPrjTabFldEN.FldId, conPrjTabFld.FldId);
clsCheckSql.CheckFieldNotNull(objPrjTabFldEN.PrjId, conPrjTabFld.PrjId);
clsCheckSql.CheckFieldNotNull(objPrjTabFldEN.FieldTypeId, conPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldNotNull(objPrjTabFldEN.IsTabNullable, conPrjTabFld.IsTabNullable);
clsCheckSql.CheckFieldNotNull(objPrjTabFldEN.IsForExtendClass, conPrjTabFld.IsForExtendClass);
clsCheckSql.CheckFieldNotNull(objPrjTabFldEN.PrimaryTypeId, conPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckFieldNotNull(objPrjTabFldEN.FldOpTypeId, conPrjTabFld.FldOpTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjTabFldEN.TabId, 8, conPrjTabFld.TabId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FldId, 8, conPrjTabFld.FldId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.PrjId, 4, conPrjTabFld.PrjId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FieldTypeId, 2, conPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.CtlTypeIdDu, 2, conPrjTabFld.CtlTypeIdDu);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FldDispUnitStyleId, 8, conPrjTabFld.FldDispUnitStyleId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.InFldId, 8, conPrjTabFld.InFldId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.DnPathId, 8, conPrjTabFld.DnPathId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.KeyId4Test, 50, conPrjTabFld.KeyId4Test);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.DisplayFormat, 50, conPrjTabFld.DisplayFormat);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.PrimaryTypeId, 2, conPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.ForeignKeyTabId, 8, conPrjTabFld.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FldOpTypeId, 4, conPrjTabFld.FldOpTypeId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.MemoInTab, 1000, conPrjTabFld.MemoInTab);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.ErrMsg, 2000, conPrjTabFld.ErrMsg);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.UpdDate, 20, conPrjTabFld.UpdDate);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.UpdUser, 20, conPrjTabFld.UpdUser);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.Memo, 1000, conPrjTabFld.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.TabId, 8, conPrjTabFld.TabId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.FldId, 8, conPrjTabFld.FldId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.PrjId, 4, conPrjTabFld.PrjId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.FieldTypeId, 2, conPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.InFldId, 8, conPrjTabFld.InFldId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.DnPathId, 8, conPrjTabFld.DnPathId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.PrimaryTypeId, 2, conPrjTabFld.PrimaryTypeId);
 objPrjTabFldEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjTabFldEN objPrjTabFldEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjTabFldEN.TabId, 8, conPrjTabFld.TabId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FldId, 8, conPrjTabFld.FldId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.PrjId, 4, conPrjTabFld.PrjId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FieldTypeId, 2, conPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.CtlTypeIdDu, 2, conPrjTabFld.CtlTypeIdDu);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FldDispUnitStyleId, 8, conPrjTabFld.FldDispUnitStyleId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.InFldId, 8, conPrjTabFld.InFldId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.DnPathId, 8, conPrjTabFld.DnPathId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.KeyId4Test, 50, conPrjTabFld.KeyId4Test);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.DisplayFormat, 50, conPrjTabFld.DisplayFormat);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.PrimaryTypeId, 2, conPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.ForeignKeyTabId, 8, conPrjTabFld.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FldOpTypeId, 4, conPrjTabFld.FldOpTypeId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.MemoInTab, 1000, conPrjTabFld.MemoInTab);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.ErrMsg, 2000, conPrjTabFld.ErrMsg);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.UpdDate, 20, conPrjTabFld.UpdDate);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.UpdUser, 20, conPrjTabFld.UpdUser);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.Memo, 1000, conPrjTabFld.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.TabId, 8, conPrjTabFld.TabId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.FldId, 8, conPrjTabFld.FldId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.PrjId, 4, conPrjTabFld.PrjId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.FieldTypeId, 2, conPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.InFldId, 8, conPrjTabFld.InFldId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.DnPathId, 8, conPrjTabFld.DnPathId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.PrimaryTypeId, 2, conPrjTabFld.PrimaryTypeId);
 objPrjTabFldEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjTabFldEN objPrjTabFldEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjTabFldEN.TabId, 8, conPrjTabFld.TabId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FldId, 8, conPrjTabFld.FldId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.PrjId, 4, conPrjTabFld.PrjId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FieldTypeId, 2, conPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.CtlTypeIdDu, 2, conPrjTabFld.CtlTypeIdDu);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FldDispUnitStyleId, 8, conPrjTabFld.FldDispUnitStyleId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.InFldId, 8, conPrjTabFld.InFldId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.DnPathId, 8, conPrjTabFld.DnPathId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.KeyId4Test, 50, conPrjTabFld.KeyId4Test);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.DisplayFormat, 50, conPrjTabFld.DisplayFormat);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.PrimaryTypeId, 2, conPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.ForeignKeyTabId, 8, conPrjTabFld.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.FldOpTypeId, 4, conPrjTabFld.FldOpTypeId);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.MemoInTab, 1000, conPrjTabFld.MemoInTab);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.ErrMsg, 2000, conPrjTabFld.ErrMsg);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.UpdDate, 20, conPrjTabFld.UpdDate);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.UpdUser, 20, conPrjTabFld.UpdUser);
clsCheckSql.CheckFieldLen(objPrjTabFldEN.Memo, 1000, conPrjTabFld.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.TabId, conPrjTabFld.TabId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.FldId, conPrjTabFld.FldId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.PrjId, conPrjTabFld.PrjId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.FieldTypeId, conPrjTabFld.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.CtlTypeIdDu, conPrjTabFld.CtlTypeIdDu);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.FldDispUnitStyleId, conPrjTabFld.FldDispUnitStyleId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.InFldId, conPrjTabFld.InFldId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.DnPathId, conPrjTabFld.DnPathId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.KeyId4Test, conPrjTabFld.KeyId4Test);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.DisplayFormat, conPrjTabFld.DisplayFormat);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.PrimaryTypeId, conPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.ForeignKeyTabId, conPrjTabFld.ForeignKeyTabId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.FldOpTypeId, conPrjTabFld.FldOpTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.MemoInTab, conPrjTabFld.MemoInTab);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.ErrMsg, conPrjTabFld.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.UpdDate, conPrjTabFld.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.UpdUser, conPrjTabFld.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objPrjTabFldEN.Memo, conPrjTabFld.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.TabId, 8, conPrjTabFld.TabId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.FldId, 8, conPrjTabFld.FldId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.PrjId, 4, conPrjTabFld.PrjId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.FieldTypeId, 2, conPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.InFldId, 8, conPrjTabFld.InFldId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.DnPathId, 8, conPrjTabFld.DnPathId);
clsCheckSql.CheckFieldForeignKey(objPrjTabFldEN.PrimaryTypeId, 2, conPrjTabFld.PrimaryTypeId);
 objPrjTabFldEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PrjTabFld(工程表字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjTabFldEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPrjTabFldEN objPrjTabFldEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objPrjTabFldEN.FldId);
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjTabFldEN._CurrTabName);
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjTabFldEN._CurrTabName, strCondition);
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
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
 objSQL = clsPrjTabFldDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}