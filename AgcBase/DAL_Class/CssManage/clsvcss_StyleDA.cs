
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcss_StyleDA
 表名:vcss_Style(00050471)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:55
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
 /// vcss_Style(vcss_Style)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcss_StyleDA : clsCommBase4DA
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
 return clsvcss_StyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcss_StyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcss_StyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcss_StyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcss_StyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strStyleId)
{
strStyleId = strStyleId.Replace("'", "''");
if (strStyleId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vcss_Style中,检查关键字,长度不正确!(clsvcss_StyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vcss_Style中,关键字不能为空 或 null!(clsvcss_StyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvcss_StyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcss_StyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_Style where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcss_Style(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcss_StyleDA: GetDataTable_vcss_Style)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_Style where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcss_StyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcss_StyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_Style where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcss_StyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcss_StyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcss_Style where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcss_Style where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcss_StyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcss_Style where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcss_StyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vcss_Style.* " + 
$"from vcss_Style " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vcss_Style.StyleId not in " + 
$"(Select top {intTop_In} vcss_Style.StyleId from vcss_Style " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcss_Style where {1} and StyleId not in (Select top {2} StyleId from vcss_Style where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcss_Style where {1} and StyleId not in (Select top {3} StyleId from vcss_Style where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcss_StyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vcss_Style.* " + 
$"from vcss_Style " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vcss_Style.StyleId not in " + 
$"(Select top {intTop_In} vcss_Style.StyleId from vcss_Style " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcss_Style where {1} and StyleId not in (Select top {2} StyleId from vcss_Style where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcss_Style where {1} and StyleId not in (Select top {3} StyleId from vcss_Style where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcss_StyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcss_StyleDA:GetObjLst)", objException.Message));
}
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_Style where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = TransNullToBool(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcss_StyleDA: GetObjLst)", objException.Message));
}
objvcss_StyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcss_StyleEN);
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
public List<clsvcss_StyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcss_StyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = TransNullToBool(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcss_StyleDA: GetObjLst)", objException.Message));
}
objvcss_StyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcss_StyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcss_Style(ref clsvcss_StyleEN objvcss_StyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_Style where StyleId = " + "'"+ objvcss_StyleEN.StyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcss_StyleEN.StyleId = objDT.Rows[0][convcss_Style.StyleId].ToString().Trim(); //样式ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_StyleEN.CtlTypeId = objDT.Rows[0][convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvcss_StyleEN.CtlTypeName = objDT.Rows[0][convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvcss_StyleEN.StyleName = objDT.Rows[0][convcss_Style.StyleName].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_StyleEN.StyleDesc = objDT.Rows[0][convcss_Style.StyleDesc].ToString().Trim(); //样式描述(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_StyleEN.StyleContent = objDT.Rows[0][convcss_Style.StyleContent].ToString().Trim(); //样式内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_StyleEN.IsDeleted = TransNullToBool(objDT.Rows[0][convcss_Style.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvcss_StyleEN.DeletedDate = objDT.Rows[0][convcss_Style.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_StyleEN.UpdDate = objDT.Rows[0][convcss_Style.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcss_StyleEN.UpdUser = objDT.Rows[0][convcss_Style.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvcss_StyleEN.Memo = objDT.Rows[0][convcss_Style.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcss_StyleDA: Getvcss_Style)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcss_StyleEN GetObjByStyleId(string strStyleId)
{
CheckPrimaryKey(strStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_Style where StyleId = " + "'"+ strStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
 objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcss_StyleDA: GetObjByStyleId)", objException.Message));
}
return objvcss_StyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcss_StyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcss_StyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_Style where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN()
{
StyleId = objRow[convcss_Style.StyleId].ToString().Trim(), //样式ID
CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(), //控件类型号
CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(), //控件类型名
StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(), //样式名称
StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(), //样式描述
StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(), //样式内容
IsDeleted = TransNullToBool(objRow[convcss_Style.IsDeleted].ToString().Trim()), //是否删除
DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(), //删除日期
UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim() //说明
};
objvcss_StyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcss_StyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcss_StyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcss_StyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = TransNullToBool(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcss_StyleDA: GetObjByDataRowvcss_Style)", objException.Message));
}
objvcss_StyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcss_StyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcss_StyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = TransNullToBool(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcss_StyleDA: GetObjByDataRow)", objException.Message));
}
objvcss_StyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcss_StyleEN;
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
objSQL = clsvcss_StyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcss_StyleEN._CurrTabName, convcss_Style.StyleId, 8, "");
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
objSQL = clsvcss_StyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcss_StyleEN._CurrTabName, convcss_Style.StyleId, 8, strPrefix);
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
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select StyleId from vcss_Style where " + strCondition;
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
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select StyleId from vcss_Style where " + strCondition;
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
 /// <param name = "strStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strStyleId)
{
CheckPrimaryKey(strStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcss_Style", "StyleId = " + "'"+ strStyleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcss_StyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcss_Style", strCondition))
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
objSQL = clsvcss_StyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcss_Style");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcss_StyleENS">源对象</param>
 /// <param name = "objvcss_StyleENT">目标对象</param>
public void CopyTo(clsvcss_StyleEN objvcss_StyleENS, clsvcss_StyleEN objvcss_StyleENT)
{
objvcss_StyleENT.StyleId = objvcss_StyleENS.StyleId; //样式ID
objvcss_StyleENT.CtlTypeId = objvcss_StyleENS.CtlTypeId; //控件类型号
objvcss_StyleENT.CtlTypeName = objvcss_StyleENS.CtlTypeName; //控件类型名
objvcss_StyleENT.StyleName = objvcss_StyleENS.StyleName; //样式名称
objvcss_StyleENT.StyleDesc = objvcss_StyleENS.StyleDesc; //样式描述
objvcss_StyleENT.StyleContent = objvcss_StyleENS.StyleContent; //样式内容
objvcss_StyleENT.IsDeleted = objvcss_StyleENS.IsDeleted; //是否删除
objvcss_StyleENT.DeletedDate = objvcss_StyleENS.DeletedDate; //删除日期
objvcss_StyleENT.UpdDate = objvcss_StyleENS.UpdDate; //修改日期
objvcss_StyleENT.UpdUser = objvcss_StyleENS.UpdUser; //修改者
objvcss_StyleENT.Memo = objvcss_StyleENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcss_StyleEN objvcss_StyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcss_StyleEN.StyleId, 8, convcss_Style.StyleId);
clsCheckSql.CheckFieldLen(objvcss_StyleEN.CtlTypeId, 2, convcss_Style.CtlTypeId);
clsCheckSql.CheckFieldLen(objvcss_StyleEN.CtlTypeName, 30, convcss_Style.CtlTypeName);
clsCheckSql.CheckFieldLen(objvcss_StyleEN.StyleName, 50, convcss_Style.StyleName);
clsCheckSql.CheckFieldLen(objvcss_StyleEN.StyleDesc, 1000, convcss_Style.StyleDesc);
clsCheckSql.CheckFieldLen(objvcss_StyleEN.StyleContent, 1000, convcss_Style.StyleContent);
clsCheckSql.CheckFieldLen(objvcss_StyleEN.DeletedDate, 50, convcss_Style.DeletedDate);
clsCheckSql.CheckFieldLen(objvcss_StyleEN.UpdDate, 20, convcss_Style.UpdDate);
clsCheckSql.CheckFieldLen(objvcss_StyleEN.UpdUser, 20, convcss_Style.UpdUser);
clsCheckSql.CheckFieldLen(objvcss_StyleEN.Memo, 1000, convcss_Style.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcss_StyleEN.StyleId, convcss_Style.StyleId);
clsCheckSql.CheckSqlInjection4Field(objvcss_StyleEN.CtlTypeId, convcss_Style.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcss_StyleEN.CtlTypeName, convcss_Style.CtlTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcss_StyleEN.StyleName, convcss_Style.StyleName);
clsCheckSql.CheckSqlInjection4Field(objvcss_StyleEN.StyleDesc, convcss_Style.StyleDesc);
clsCheckSql.CheckSqlInjection4Field(objvcss_StyleEN.StyleContent, convcss_Style.StyleContent);
clsCheckSql.CheckSqlInjection4Field(objvcss_StyleEN.DeletedDate, convcss_Style.DeletedDate);
clsCheckSql.CheckSqlInjection4Field(objvcss_StyleEN.UpdDate, convcss_Style.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcss_StyleEN.UpdUser, convcss_Style.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvcss_StyleEN.Memo, convcss_Style.Memo);
//检查外键字段长度
 objvcss_StyleEN._IsCheckProperty = true;
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
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
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
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
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
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcss_StyleEN._CurrTabName);
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
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcss_StyleEN._CurrTabName, strCondition);
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
 objSQL = clsvcss_StyleDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}