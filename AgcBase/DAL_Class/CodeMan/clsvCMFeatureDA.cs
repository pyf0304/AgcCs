
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFeatureDA
 表名:vCMFeature(00050519)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// vCM功能(vCMFeature)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMFeatureDA : clsCommBase4DA
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
 return clsvCMFeatureEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMFeatureEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFeatureEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMFeatureEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMFeatureEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCmFeatureId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCmFeatureId)
{
strCmFeatureId = strCmFeatureId.Replace("'", "''");
if (strCmFeatureId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCMFeature中,检查关键字,长度不正确!(clsvCMFeatureDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCmFeatureId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCMFeature中,关键字不能为空 或 null!(clsvCMFeatureDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCMFeatureDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMFeature(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMFeatureDA: GetDataTable_vCMFeature)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeature where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMFeatureDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFeature where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFeature where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMFeatureDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMFeature where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMFeature.* " + 
$"from vCMFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMFeature.CmFeatureId not in " + 
$"(Select top {intTop_In} vCMFeature.CmFeatureId from vCMFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFeature where {1} and CmFeatureId not in (Select top {2} CmFeatureId from vCMFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFeature where {1} and CmFeatureId not in (Select top {3} CmFeatureId from vCMFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMFeatureDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCMFeature.* " + 
$"from vCMFeature " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCMFeature.CmFeatureId not in " + 
$"(Select top {intTop_In} vCMFeature.CmFeatureId from vCMFeature " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMFeature where {1} and CmFeatureId not in (Select top {2} CmFeatureId from vCMFeature where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMFeature where {1} and CmFeatureId not in (Select top {3} CmFeatureId from vCMFeature where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMFeatureEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMFeatureDA:GetObjLst)", objException.Message));
}
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = TransNullToBool(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = TransNullToInt(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFeatureDA: GetObjLst)", objException.Message));
}
objvCMFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFeatureEN);
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
public List<clsvCMFeatureEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMFeatureDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMFeatureEN> arrObjLst = new List<clsvCMFeatureEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = TransNullToBool(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = TransNullToInt(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMFeatureDA: GetObjLst)", objException.Message));
}
objvCMFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMFeatureEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMFeatureEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMFeature(ref clsvCMFeatureEN objvCMFeatureEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeature where CmFeatureId = " + "'"+ objvCMFeatureEN.CmFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMFeatureEN.CmFeatureId = objDT.Rows[0][convCMFeature.CmFeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureEN.FeatureName = objDT.Rows[0][convCMFeature.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFeatureEN.FeatureENName = objDT.Rows[0][convCMFeature.FeatureENName].ToString().Trim(); //功能英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFeatureEN.KeyWords = objDT.Rows[0][convCMFeature.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFeatureEN.FeatureDescription = objDT.Rows[0][convCMFeature.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvCMFeatureEN.CmParentFeatureId = objDT.Rows[0][convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureEN.ParentFeatureName = objDT.Rows[0][convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFeatureEN.CmFeatureTypeId = objDT.Rows[0][convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMFeatureEN.FeatureTypeName = objDT.Rows[0][convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFeatureEN.CreateUserId = objDT.Rows[0][convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvCMFeatureEN.InUse = TransNullToBool(objDT.Rows[0][convCMFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvCMFeatureEN.OrderNum = TransNullToInt(objDT.Rows[0][convCMFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMFeatureEN.FuncModuleAgcId = objDT.Rows[0][convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureEN.FuncModuleName = objDT.Rows[0][convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFeatureEN.FuncModuleEnName = objDT.Rows[0][convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMFeatureEN.FuncModuleNameSim = objDT.Rows[0][convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMFeatureEN.CmPrjId = objDT.Rows[0][convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMFeatureEN.CmPrjName = objDT.Rows[0][convCMFeature.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMFeatureEN.PrjId = objDT.Rows[0][convCMFeature.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFeatureEN.PrjName = objDT.Rows[0][convCMFeature.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFeatureEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMFeatureEN.ApplicationTypeSimName = objDT.Rows[0][convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMFeatureEN.UpdDate = objDT.Rows[0][convCMFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFeatureEN.UpdUser = objDT.Rows[0][convCMFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFeatureEN.Memo = objDT.Rows[0][convCMFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMFeatureEN.FeatureName2 = objDT.Rows[0][convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount(字段类型:varchar,字段长度:112,是否可空:True)
 objvCMFeatureEN.CmReqCount = TransNullToInt(objDT.Rows[0][convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMFeatureDA: GetvCMFeature)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMFeatureEN GetObjByCmFeatureId(string strCmFeatureId)
{
CheckPrimaryKey(strCmFeatureId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeature where CmFeatureId = " + "'"+ strCmFeatureId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
 objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvCMFeatureEN.OrderNum = Int32.Parse(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount(字段类型:varchar,字段长度:112,是否可空:True)
 objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMFeatureDA: GetObjByCmFeatureId)", objException.Message));
}
return objvCMFeatureEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMFeatureEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMFeatureDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
strSQL = "Select * from vCMFeature where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN()
{
CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(), //功能名称
FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(), //功能英文名
KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(), //关键字
FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(), //功能说明
CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(), //父功能Id
ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(), //父功能名
CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(), //功能类型Id
FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(), //功能类型名称
CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(), //建立用户Id
InUse = TransNullToBool(objRow[convCMFeature.InUse].ToString().Trim()), //是否在用
OrderNum = TransNullToInt(objRow[convCMFeature.OrderNum].ToString().Trim()), //序号
FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(), //功能模块简称
CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(), //Cm工程Id
CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(), //CM工程名
PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(), //工程名称
ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(), //说明
FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(), //功能名-FuncCount
CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFeature.CmReqCount].ToString().Trim()) //CMReqCount
};
objvCMFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFeatureEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMFeatureDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMFeatureEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = TransNullToBool(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = TransNullToInt(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMFeatureDA: GetObjByDataRowvCMFeature)", objException.Message));
}
objvCMFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFeatureEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMFeatureEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMFeatureEN objvCMFeatureEN = new clsvCMFeatureEN();
try
{
objvCMFeatureEN.CmFeatureId = objRow[convCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objvCMFeatureEN.FeatureName = objRow[convCMFeature.FeatureName].ToString().Trim(); //功能名称
objvCMFeatureEN.FeatureENName = objRow[convCMFeature.FeatureENName] == DBNull.Value ? null : objRow[convCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objvCMFeatureEN.KeyWords = objRow[convCMFeature.KeyWords] == DBNull.Value ? null : objRow[convCMFeature.KeyWords].ToString().Trim(); //关键字
objvCMFeatureEN.FeatureDescription = objRow[convCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[convCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objvCMFeatureEN.CmParentFeatureId = objRow[convCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objvCMFeatureEN.ParentFeatureName = objRow[convCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvCMFeatureEN.CmFeatureTypeId = objRow[convCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objvCMFeatureEN.FeatureTypeName = objRow[convCMFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvCMFeatureEN.CreateUserId = objRow[convCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objvCMFeatureEN.InUse = TransNullToBool(objRow[convCMFeature.InUse].ToString().Trim()); //是否在用
objvCMFeatureEN.OrderNum = TransNullToInt(objRow[convCMFeature.OrderNum].ToString().Trim()); //序号
objvCMFeatureEN.FuncModuleAgcId = objRow[convCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMFeatureEN.FuncModuleName = objRow[convCMFeature.FuncModuleName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMFeatureEN.FuncModuleEnName = objRow[convCMFeature.FuncModuleEnName] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvCMFeatureEN.FuncModuleNameSim = objRow[convCMFeature.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMFeature.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMFeatureEN.CmPrjId = objRow[convCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMFeatureEN.CmPrjName = objRow[convCMFeature.CmPrjName] == DBNull.Value ? null : objRow[convCMFeature.CmPrjName].ToString().Trim(); //CM工程名
objvCMFeatureEN.PrjId = objRow[convCMFeature.PrjId] == DBNull.Value ? null : objRow[convCMFeature.PrjId].ToString().Trim(); //工程Id
objvCMFeatureEN.PrjName = objRow[convCMFeature.PrjName] == DBNull.Value ? null : objRow[convCMFeature.PrjName].ToString().Trim(); //工程名称
objvCMFeatureEN.ApplicationTypeId = objRow[convCMFeature.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFeature.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFeatureEN.ApplicationTypeSimName = objRow[convCMFeature.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMFeature.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMFeatureEN.UpdDate = objRow[convCMFeature.UpdDate] == DBNull.Value ? null : objRow[convCMFeature.UpdDate].ToString().Trim(); //修改日期
objvCMFeatureEN.UpdUser = objRow[convCMFeature.UpdUser] == DBNull.Value ? null : objRow[convCMFeature.UpdUser].ToString().Trim(); //修改者
objvCMFeatureEN.Memo = objRow[convCMFeature.Memo] == DBNull.Value ? null : objRow[convCMFeature.Memo].ToString().Trim(); //说明
objvCMFeatureEN.FeatureName2 = objRow[convCMFeature.FeatureName2] == DBNull.Value ? null : objRow[convCMFeature.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvCMFeatureEN.CmReqCount = objRow[convCMFeature.CmReqCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMFeature.CmReqCount].ToString().Trim()); //CMReqCount
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMFeatureDA: GetObjByDataRow)", objException.Message));
}
objvCMFeatureEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMFeatureEN;
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
objSQL = clsvCMFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFeatureEN._CurrTabName, convCMFeature.CmFeatureId, 8, "");
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
objSQL = clsvCMFeatureDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMFeatureEN._CurrTabName, convCMFeature.CmFeatureId, 8, strPrefix);
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
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CmFeatureId from vCMFeature where " + strCondition;
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
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CmFeatureId from vCMFeature where " + strCondition;
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
 /// <param name = "strCmFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCmFeatureId)
{
CheckPrimaryKey(strCmFeatureId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFeature", "CmFeatureId = " + "'"+ strCmFeatureId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMFeatureDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMFeature", strCondition))
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
objSQL = clsvCMFeatureDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMFeature");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMFeatureENS">源对象</param>
 /// <param name = "objvCMFeatureENT">目标对象</param>
public void CopyTo(clsvCMFeatureEN objvCMFeatureENS, clsvCMFeatureEN objvCMFeatureENT)
{
objvCMFeatureENT.CmFeatureId = objvCMFeatureENS.CmFeatureId; //功能Id
objvCMFeatureENT.FeatureName = objvCMFeatureENS.FeatureName; //功能名称
objvCMFeatureENT.FeatureENName = objvCMFeatureENS.FeatureENName; //功能英文名
objvCMFeatureENT.KeyWords = objvCMFeatureENS.KeyWords; //关键字
objvCMFeatureENT.FeatureDescription = objvCMFeatureENS.FeatureDescription; //功能说明
objvCMFeatureENT.CmParentFeatureId = objvCMFeatureENS.CmParentFeatureId; //父功能Id
objvCMFeatureENT.ParentFeatureName = objvCMFeatureENS.ParentFeatureName; //父功能名
objvCMFeatureENT.CmFeatureTypeId = objvCMFeatureENS.CmFeatureTypeId; //功能类型Id
objvCMFeatureENT.FeatureTypeName = objvCMFeatureENS.FeatureTypeName; //功能类型名称
objvCMFeatureENT.CreateUserId = objvCMFeatureENS.CreateUserId; //建立用户Id
objvCMFeatureENT.InUse = objvCMFeatureENS.InUse; //是否在用
objvCMFeatureENT.OrderNum = objvCMFeatureENS.OrderNum; //序号
objvCMFeatureENT.FuncModuleAgcId = objvCMFeatureENS.FuncModuleAgcId; //功能模块Id
objvCMFeatureENT.FuncModuleName = objvCMFeatureENS.FuncModuleName; //功能模块名称
objvCMFeatureENT.FuncModuleEnName = objvCMFeatureENS.FuncModuleEnName; //功能模块英文名称
objvCMFeatureENT.FuncModuleNameSim = objvCMFeatureENS.FuncModuleNameSim; //功能模块简称
objvCMFeatureENT.CmPrjId = objvCMFeatureENS.CmPrjId; //Cm工程Id
objvCMFeatureENT.CmPrjName = objvCMFeatureENS.CmPrjName; //CM工程名
objvCMFeatureENT.PrjId = objvCMFeatureENS.PrjId; //工程Id
objvCMFeatureENT.PrjName = objvCMFeatureENS.PrjName; //工程名称
objvCMFeatureENT.ApplicationTypeId = objvCMFeatureENS.ApplicationTypeId; //应用程序类型ID
objvCMFeatureENT.ApplicationTypeSimName = objvCMFeatureENS.ApplicationTypeSimName; //应用程序类型简称
objvCMFeatureENT.UpdDate = objvCMFeatureENS.UpdDate; //修改日期
objvCMFeatureENT.UpdUser = objvCMFeatureENS.UpdUser; //修改者
objvCMFeatureENT.Memo = objvCMFeatureENS.Memo; //说明
objvCMFeatureENT.FeatureName2 = objvCMFeatureENS.FeatureName2; //功能名-FuncCount
objvCMFeatureENT.CmReqCount = objvCMFeatureENS.CmReqCount; //CMReqCount
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMFeatureEN objvCMFeatureEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMFeatureEN.CmFeatureId, 8, convCMFeature.CmFeatureId);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.FeatureName, 100, convCMFeature.FeatureName);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.FeatureENName, 100, convCMFeature.FeatureENName);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.KeyWords, 500, convCMFeature.KeyWords);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.FeatureDescription, 4000, convCMFeature.FeatureDescription);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.CmParentFeatureId, 8, convCMFeature.CmParentFeatureId);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.ParentFeatureName, 500, convCMFeature.ParentFeatureName);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.CmFeatureTypeId, 2, convCMFeature.CmFeatureTypeId);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.FeatureTypeName, 30, convCMFeature.FeatureTypeName);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.CreateUserId, 18, convCMFeature.CreateUserId);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.FuncModuleAgcId, 8, convCMFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.FuncModuleName, 30, convCMFeature.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.FuncModuleEnName, 30, convCMFeature.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.FuncModuleNameSim, 30, convCMFeature.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.CmPrjId, 6, convCMFeature.CmPrjId);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.CmPrjName, 50, convCMFeature.CmPrjName);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.PrjId, 4, convCMFeature.PrjId);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.PrjName, 30, convCMFeature.PrjName);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.ApplicationTypeSimName, 30, convCMFeature.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.UpdDate, 20, convCMFeature.UpdDate);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.UpdUser, 20, convCMFeature.UpdUser);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.Memo, 1000, convCMFeature.Memo);
clsCheckSql.CheckFieldLen(objvCMFeatureEN.FeatureName2, 112, convCMFeature.FeatureName2);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.CmFeatureId, convCMFeature.CmFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.FeatureName, convCMFeature.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.FeatureENName, convCMFeature.FeatureENName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.KeyWords, convCMFeature.KeyWords);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.FeatureDescription, convCMFeature.FeatureDescription);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.CmParentFeatureId, convCMFeature.CmParentFeatureId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.ParentFeatureName, convCMFeature.ParentFeatureName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.CmFeatureTypeId, convCMFeature.CmFeatureTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.FeatureTypeName, convCMFeature.FeatureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.CreateUserId, convCMFeature.CreateUserId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.FuncModuleAgcId, convCMFeature.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.FuncModuleName, convCMFeature.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.FuncModuleEnName, convCMFeature.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.FuncModuleNameSim, convCMFeature.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.CmPrjId, convCMFeature.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.CmPrjName, convCMFeature.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.PrjId, convCMFeature.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.PrjName, convCMFeature.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.ApplicationTypeSimName, convCMFeature.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.UpdDate, convCMFeature.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.UpdUser, convCMFeature.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.Memo, convCMFeature.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCMFeatureEN.FeatureName2, convCMFeature.FeatureName2);
//检查外键字段长度
 objvCMFeatureEN._IsCheckProperty = true;
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
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
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
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
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
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFeatureEN._CurrTabName);
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
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMFeatureEN._CurrTabName, strCondition);
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
 objSQL = clsvCMFeatureDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}