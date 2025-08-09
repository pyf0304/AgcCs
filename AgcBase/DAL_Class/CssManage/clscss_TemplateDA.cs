
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_TemplateDA
 表名:css_Template(00050469)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:14
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
 /// css_Template(css_Template)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscss_TemplateDA : clsCommBase4DA
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
 return clscss_TemplateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscss_TemplateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscss_TemplateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscss_TemplateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscss_TemplateEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTemplateId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTemplateId)
{
strTemplateId = strTemplateId.Replace("'", "''");
if (strTemplateId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:css_Template中,检查关键字,长度不正确!(clscss_TemplateDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTemplateId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:css_Template中,关键字不能为空 或 null!(clscss_TemplateDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTemplateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscss_TemplateDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscss_TemplateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = "Select * from css_Template where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_css_Template(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscss_TemplateDA: GetDataTable_css_Template)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = "Select * from css_Template where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscss_TemplateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscss_TemplateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = "Select * from css_Template where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscss_TemplateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscss_TemplateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_Template where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_Template where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscss_TemplateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from css_Template where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscss_TemplateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} css_Template.* " + 
$"from css_Template " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and css_Template.TemplateId not in " + 
$"(Select top {intTop_In} css_Template.TemplateId from css_Template " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_Template where {1} and TemplateId not in (Select top {2} TemplateId from css_Template where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_Template where {1} and TemplateId not in (Select top {3} TemplateId from css_Template where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscss_TemplateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} css_Template.* " + 
$"from css_Template " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and css_Template.TemplateId not in " + 
$"(Select top {intTop_In} css_Template.TemplateId from css_Template " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from css_Template where {1} and TemplateId not in (Select top {2} TemplateId from css_Template where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from css_Template where {1} and TemplateId not in (Select top {3} TemplateId from css_Template where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscss_TemplateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscss_TemplateDA:GetObjLst)", objException.Message));
}
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = "Select * from css_Template where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = TransNullToBool(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = TransNullToBool(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscss_TemplateDA: GetObjLst)", objException.Message));
}
objcss_TemplateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcss_TemplateEN);
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
public List<clscss_TemplateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscss_TemplateDA:GetObjLstByTabName)", objException.Message));
}
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = TransNullToBool(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = TransNullToBool(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscss_TemplateDA: GetObjLst)", objException.Message));
}
objcss_TemplateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcss_TemplateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcss_Template(ref clscss_TemplateEN objcss_TemplateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = "Select * from css_Template where TemplateId = " + "'"+ objcss_TemplateEN.TemplateId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcss_TemplateEN.TemplateId = objDT.Rows[0][concss_Template.TemplateId].ToString().Trim(); //模板ID(字段类型:char,字段长度:8,是否可空:False)
 objcss_TemplateEN.TemplateName = objDT.Rows[0][concss_Template.TemplateName].ToString().Trim(); //模板名称(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_TemplateEN.TemplateDesc = objDT.Rows[0][concss_Template.TemplateDesc].ToString().Trim(); //模板描述(字段类型:varchar,字段长度:100,是否可空:True)
 objcss_TemplateEN.OrderNum = TransNullToInt(objDT.Rows[0][concss_Template.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objcss_TemplateEN.TemplatePic = objDT.Rows[0][concss_Template.TemplatePic].ToString().Trim(); //模板图片(字段类型:varchar,字段长度:100,是否可空:True)
 objcss_TemplateEN.IsPublic = TransNullToBool(objDT.Rows[0][concss_Template.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objcss_TemplateEN.IsDeleted = TransNullToBool(objDT.Rows[0][concss_Template.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objcss_TemplateEN.DeletedDate = objDT.Rows[0][concss_Template.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_TemplateEN.UpdDate = objDT.Rows[0][concss_Template.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_TemplateEN.UpdUser = objDT.Rows[0][concss_Template.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_TemplateEN.Memo = objDT.Rows[0][concss_Template.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscss_TemplateDA: Getcss_Template)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTemplateId">表关键字</param>
 /// <returns>表对象</returns>
public clscss_TemplateEN GetObjByTemplateId(string strTemplateId)
{
CheckPrimaryKey(strTemplateId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = "Select * from css_Template where TemplateId = " + "'"+ strTemplateId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
 objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID(字段类型:char,字段长度:8,是否可空:False)
 objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述(字段类型:varchar,字段长度:100,是否可空:True)
 objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片(字段类型:varchar,字段长度:100,是否可空:True)
 objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscss_TemplateDA: GetObjByTemplateId)", objException.Message));
}
return objcss_TemplateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscss_TemplateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscss_TemplateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = "Select * from css_Template where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN()
{
TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(), //模板ID
TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(), //模板名称
TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(), //模板描述
OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concss_Template.OrderNum].ToString().Trim()), //序号
TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(), //模板图片
IsPublic = TransNullToBool(objRow[concss_Template.IsPublic].ToString().Trim()), //是否公开
IsDeleted = TransNullToBool(objRow[concss_Template.IsDeleted].ToString().Trim()), //是否删除
DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(), //删除日期
UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(), //修改者
Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim() //说明
};
objcss_TemplateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_TemplateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscss_TemplateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscss_TemplateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = TransNullToBool(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = TransNullToBool(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscss_TemplateDA: GetObjByDataRowcss_Template)", objException.Message));
}
objcss_TemplateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_TemplateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscss_TemplateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = TransNullToBool(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = TransNullToBool(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscss_TemplateDA: GetObjByDataRow)", objException.Message));
}
objcss_TemplateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcss_TemplateEN;
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
objSQL = clscss_TemplateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscss_TemplateEN._CurrTabName, concss_Template.TemplateId, 8, "");
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
objSQL = clscss_TemplateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscss_TemplateEN._CurrTabName, concss_Template.TemplateId, 8, strPrefix);
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
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TemplateId from css_Template where " + strCondition;
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
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TemplateId from css_Template where " + strCondition;
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
 /// <param name = "strTemplateId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTemplateId)
{
CheckPrimaryKey(strTemplateId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("css_Template", "TemplateId = " + "'"+ strTemplateId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscss_TemplateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("css_Template", strCondition))
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
objSQL = clscss_TemplateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("css_Template");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscss_TemplateEN objcss_TemplateEN)
 {
 objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_TemplateEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = "Select * from css_Template where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "css_Template");
objRow = objDS.Tables["css_Template"].NewRow();
objRow[concss_Template.TemplateId] = objcss_TemplateEN.TemplateId; //模板ID
 if (objcss_TemplateEN.TemplateName !=  "")
 {
objRow[concss_Template.TemplateName] = objcss_TemplateEN.TemplateName; //模板名称
 }
 if (objcss_TemplateEN.TemplateDesc !=  "")
 {
objRow[concss_Template.TemplateDesc] = objcss_TemplateEN.TemplateDesc; //模板描述
 }
objRow[concss_Template.OrderNum] = objcss_TemplateEN.OrderNum; //序号
 if (objcss_TemplateEN.TemplatePic !=  "")
 {
objRow[concss_Template.TemplatePic] = objcss_TemplateEN.TemplatePic; //模板图片
 }
objRow[concss_Template.IsPublic] = objcss_TemplateEN.IsPublic; //是否公开
objRow[concss_Template.IsDeleted] = objcss_TemplateEN.IsDeleted; //是否删除
 if (objcss_TemplateEN.DeletedDate !=  "")
 {
objRow[concss_Template.DeletedDate] = objcss_TemplateEN.DeletedDate; //删除日期
 }
 if (objcss_TemplateEN.UpdDate !=  "")
 {
objRow[concss_Template.UpdDate] = objcss_TemplateEN.UpdDate; //修改日期
 }
 if (objcss_TemplateEN.UpdUser !=  "")
 {
objRow[concss_Template.UpdUser] = objcss_TemplateEN.UpdUser; //修改者
 }
 if (objcss_TemplateEN.Memo !=  "")
 {
objRow[concss_Template.Memo] = objcss_TemplateEN.Memo; //说明
 }
objDS.Tables[clscss_TemplateEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscss_TemplateEN._CurrTabName);
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
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscss_TemplateEN objcss_TemplateEN)
{
 objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_TemplateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_TemplateEN.TemplateId !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateId);
 var strTemplateId = objcss_TemplateEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateId + "'");
 }
 
 if (objcss_TemplateEN.TemplateName !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateName);
 var strTemplateName = objcss_TemplateEN.TemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateName + "'");
 }
 
 if (objcss_TemplateEN.TemplateDesc !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateDesc);
 var strTemplateDesc = objcss_TemplateEN.TemplateDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateDesc + "'");
 }
 
 if (objcss_TemplateEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.OrderNum);
 arrValueListForInsert.Add(objcss_TemplateEN.OrderNum.ToString());
 }
 
 if (objcss_TemplateEN.TemplatePic !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplatePic);
 var strTemplatePic = objcss_TemplateEN.TemplatePic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplatePic + "'");
 }
 
 arrFieldListForInsert.Add(concss_Template.IsPublic);
 arrValueListForInsert.Add("'" + (objcss_TemplateEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concss_Template.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_TemplateEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_TemplateEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.DeletedDate);
 var strDeletedDate = objcss_TemplateEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 
 if (objcss_TemplateEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.UpdDate);
 var strUpdDate = objcss_TemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_TemplateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.UpdUser);
 var strUpdUser = objcss_TemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_TemplateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.Memo);
 var strMemo = objcss_TemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_Template");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscss_TemplateEN objcss_TemplateEN)
{
 objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_TemplateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_TemplateEN.TemplateId !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateId);
 var strTemplateId = objcss_TemplateEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateId + "'");
 }
 
 if (objcss_TemplateEN.TemplateName !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateName);
 var strTemplateName = objcss_TemplateEN.TemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateName + "'");
 }
 
 if (objcss_TemplateEN.TemplateDesc !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateDesc);
 var strTemplateDesc = objcss_TemplateEN.TemplateDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateDesc + "'");
 }
 
 if (objcss_TemplateEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.OrderNum);
 arrValueListForInsert.Add(objcss_TemplateEN.OrderNum.ToString());
 }
 
 if (objcss_TemplateEN.TemplatePic !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplatePic);
 var strTemplatePic = objcss_TemplateEN.TemplatePic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplatePic + "'");
 }
 
 arrFieldListForInsert.Add(concss_Template.IsPublic);
 arrValueListForInsert.Add("'" + (objcss_TemplateEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concss_Template.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_TemplateEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_TemplateEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.DeletedDate);
 var strDeletedDate = objcss_TemplateEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 
 if (objcss_TemplateEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.UpdDate);
 var strUpdDate = objcss_TemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_TemplateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.UpdUser);
 var strUpdUser = objcss_TemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_TemplateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.Memo);
 var strMemo = objcss_TemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_Template");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcss_TemplateEN.TemplateId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscss_TemplateEN objcss_TemplateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_TemplateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_TemplateEN.TemplateId !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateId);
 var strTemplateId = objcss_TemplateEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateId + "'");
 }
 
 if (objcss_TemplateEN.TemplateName !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateName);
 var strTemplateName = objcss_TemplateEN.TemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateName + "'");
 }
 
 if (objcss_TemplateEN.TemplateDesc !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateDesc);
 var strTemplateDesc = objcss_TemplateEN.TemplateDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateDesc + "'");
 }
 
 if (objcss_TemplateEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.OrderNum);
 arrValueListForInsert.Add(objcss_TemplateEN.OrderNum.ToString());
 }
 
 if (objcss_TemplateEN.TemplatePic !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplatePic);
 var strTemplatePic = objcss_TemplateEN.TemplatePic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplatePic + "'");
 }
 
 arrFieldListForInsert.Add(concss_Template.IsPublic);
 arrValueListForInsert.Add("'" + (objcss_TemplateEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concss_Template.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_TemplateEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_TemplateEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.DeletedDate);
 var strDeletedDate = objcss_TemplateEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 
 if (objcss_TemplateEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.UpdDate);
 var strUpdDate = objcss_TemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_TemplateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.UpdUser);
 var strUpdUser = objcss_TemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_TemplateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.Memo);
 var strMemo = objcss_TemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_Template");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcss_TemplateEN.TemplateId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscss_TemplateEN objcss_TemplateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcss_TemplateEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcss_TemplateEN.TemplateId !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateId);
 var strTemplateId = objcss_TemplateEN.TemplateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateId + "'");
 }
 
 if (objcss_TemplateEN.TemplateName !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateName);
 var strTemplateName = objcss_TemplateEN.TemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateName + "'");
 }
 
 if (objcss_TemplateEN.TemplateDesc !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplateDesc);
 var strTemplateDesc = objcss_TemplateEN.TemplateDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplateDesc + "'");
 }
 
 if (objcss_TemplateEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.OrderNum);
 arrValueListForInsert.Add(objcss_TemplateEN.OrderNum.ToString());
 }
 
 if (objcss_TemplateEN.TemplatePic !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.TemplatePic);
 var strTemplatePic = objcss_TemplateEN.TemplatePic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTemplatePic + "'");
 }
 
 arrFieldListForInsert.Add(concss_Template.IsPublic);
 arrValueListForInsert.Add("'" + (objcss_TemplateEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concss_Template.IsDeleted);
 arrValueListForInsert.Add("'" + (objcss_TemplateEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objcss_TemplateEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.DeletedDate);
 var strDeletedDate = objcss_TemplateEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 
 if (objcss_TemplateEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.UpdDate);
 var strUpdDate = objcss_TemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcss_TemplateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.UpdUser);
 var strUpdUser = objcss_TemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcss_TemplateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concss_Template.Memo);
 var strMemo = objcss_TemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into css_Template");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcss_Templates(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = "Select * from css_Template where TemplateId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "css_Template");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTemplateId = oRow[concss_Template.TemplateId].ToString().Trim();
if (IsExist(strTemplateId))
{
 string strResult = "关键字变量值为:" + string.Format("TemplateId = {0}", strTemplateId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscss_TemplateEN._CurrTabName ].NewRow();
objRow[concss_Template.TemplateId] = oRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objRow[concss_Template.TemplateName] = oRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objRow[concss_Template.TemplateDesc] = oRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objRow[concss_Template.OrderNum] = oRow[concss_Template.OrderNum].ToString().Trim(); //序号
objRow[concss_Template.TemplatePic] = oRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objRow[concss_Template.IsPublic] = oRow[concss_Template.IsPublic].ToString().Trim(); //是否公开
objRow[concss_Template.IsDeleted] = oRow[concss_Template.IsDeleted].ToString().Trim(); //是否删除
objRow[concss_Template.DeletedDate] = oRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objRow[concss_Template.UpdDate] = oRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objRow[concss_Template.UpdUser] = oRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objRow[concss_Template.Memo] = oRow[concss_Template.Memo].ToString().Trim(); //说明
 objDS.Tables[clscss_TemplateEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscss_TemplateEN._CurrTabName);
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
 /// <param name = "objcss_TemplateEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscss_TemplateEN objcss_TemplateEN)
{
 objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_TemplateEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
strSQL = "Select * from css_Template where TemplateId = " + "'"+ objcss_TemplateEN.TemplateId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscss_TemplateEN._CurrTabName);
if (objDS.Tables[clscss_TemplateEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TemplateId = " + "'"+ objcss_TemplateEN.TemplateId+"'");
return false;
}
objRow = objDS.Tables[clscss_TemplateEN._CurrTabName].Rows[0];
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateId))
 {
objRow[concss_Template.TemplateId] = objcss_TemplateEN.TemplateId; //模板ID
 }
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateName))
 {
objRow[concss_Template.TemplateName] = objcss_TemplateEN.TemplateName; //模板名称
 }
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateDesc))
 {
objRow[concss_Template.TemplateDesc] = objcss_TemplateEN.TemplateDesc; //模板描述
 }
 if (objcss_TemplateEN.IsUpdated(concss_Template.OrderNum))
 {
objRow[concss_Template.OrderNum] = objcss_TemplateEN.OrderNum; //序号
 }
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplatePic))
 {
objRow[concss_Template.TemplatePic] = objcss_TemplateEN.TemplatePic; //模板图片
 }
 if (objcss_TemplateEN.IsUpdated(concss_Template.IsPublic))
 {
objRow[concss_Template.IsPublic] = objcss_TemplateEN.IsPublic; //是否公开
 }
 if (objcss_TemplateEN.IsUpdated(concss_Template.IsDeleted))
 {
objRow[concss_Template.IsDeleted] = objcss_TemplateEN.IsDeleted; //是否删除
 }
 if (objcss_TemplateEN.IsUpdated(concss_Template.DeletedDate))
 {
objRow[concss_Template.DeletedDate] = objcss_TemplateEN.DeletedDate; //删除日期
 }
 if (objcss_TemplateEN.IsUpdated(concss_Template.UpdDate))
 {
objRow[concss_Template.UpdDate] = objcss_TemplateEN.UpdDate; //修改日期
 }
 if (objcss_TemplateEN.IsUpdated(concss_Template.UpdUser))
 {
objRow[concss_Template.UpdUser] = objcss_TemplateEN.UpdUser; //修改者
 }
 if (objcss_TemplateEN.IsUpdated(concss_Template.Memo))
 {
objRow[concss_Template.Memo] = objcss_TemplateEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clscss_TemplateEN._CurrTabName);
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
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscss_TemplateEN objcss_TemplateEN)
{
 objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_TemplateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update css_Template Set ");
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateName))
 {
 if (objcss_TemplateEN.TemplateName !=  null)
 {
 var strTemplateName = objcss_TemplateEN.TemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplateName, concss_Template.TemplateName); //模板名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.TemplateName); //模板名称
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateDesc))
 {
 if (objcss_TemplateEN.TemplateDesc !=  null)
 {
 var strTemplateDesc = objcss_TemplateEN.TemplateDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplateDesc, concss_Template.TemplateDesc); //模板描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.TemplateDesc); //模板描述
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.OrderNum))
 {
 if (objcss_TemplateEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcss_TemplateEN.OrderNum, concss_Template.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.OrderNum); //序号
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplatePic))
 {
 if (objcss_TemplateEN.TemplatePic !=  null)
 {
 var strTemplatePic = objcss_TemplateEN.TemplatePic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplatePic, concss_Template.TemplatePic); //模板图片
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.TemplatePic); //模板图片
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcss_TemplateEN.IsPublic == true?"1":"0", concss_Template.IsPublic); //是否公开
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcss_TemplateEN.IsDeleted == true?"1":"0", concss_Template.IsDeleted); //是否删除
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.DeletedDate))
 {
 if (objcss_TemplateEN.DeletedDate !=  null)
 {
 var strDeletedDate = objcss_TemplateEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDeletedDate, concss_Template.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.DeletedDate); //删除日期
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.UpdDate))
 {
 if (objcss_TemplateEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_TemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concss_Template.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.UpdDate); //修改日期
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.UpdUser))
 {
 if (objcss_TemplateEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_TemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concss_Template.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.UpdUser); //修改者
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.Memo))
 {
 if (objcss_TemplateEN.Memo !=  null)
 {
 var strMemo = objcss_TemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concss_Template.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TemplateId = '{0}'", objcss_TemplateEN.TemplateId); 
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
 /// <param name = "objcss_TemplateEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscss_TemplateEN objcss_TemplateEN, string strCondition)
{
 objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_TemplateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_Template Set ");
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateName))
 {
 if (objcss_TemplateEN.TemplateName !=  null)
 {
 var strTemplateName = objcss_TemplateEN.TemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplateName = '{0}',", strTemplateName); //模板名称
 }
 else
 {
 sbSQL.Append(" TemplateName = null,"); //模板名称
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateDesc))
 {
 if (objcss_TemplateEN.TemplateDesc !=  null)
 {
 var strTemplateDesc = objcss_TemplateEN.TemplateDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplateDesc = '{0}',", strTemplateDesc); //模板描述
 }
 else
 {
 sbSQL.Append(" TemplateDesc = null,"); //模板描述
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.OrderNum))
 {
 if (objcss_TemplateEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcss_TemplateEN.OrderNum, concss_Template.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.OrderNum); //序号
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplatePic))
 {
 if (objcss_TemplateEN.TemplatePic !=  null)
 {
 var strTemplatePic = objcss_TemplateEN.TemplatePic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplatePic = '{0}',", strTemplatePic); //模板图片
 }
 else
 {
 sbSQL.Append(" TemplatePic = null,"); //模板图片
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objcss_TemplateEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.IsDeleted))
 {
 sbSQL.AppendFormat(" IsDeleted = '{0}',", objcss_TemplateEN.IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.DeletedDate))
 {
 if (objcss_TemplateEN.DeletedDate !=  null)
 {
 var strDeletedDate = objcss_TemplateEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DeletedDate = '{0}',", strDeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" DeletedDate = null,"); //删除日期
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.UpdDate))
 {
 if (objcss_TemplateEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_TemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.UpdUser))
 {
 if (objcss_TemplateEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_TemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.Memo))
 {
 if (objcss_TemplateEN.Memo !=  null)
 {
 var strMemo = objcss_TemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcss_TemplateEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscss_TemplateEN objcss_TemplateEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_TemplateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_Template Set ");
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateName))
 {
 if (objcss_TemplateEN.TemplateName !=  null)
 {
 var strTemplateName = objcss_TemplateEN.TemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplateName = '{0}',", strTemplateName); //模板名称
 }
 else
 {
 sbSQL.Append(" TemplateName = null,"); //模板名称
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateDesc))
 {
 if (objcss_TemplateEN.TemplateDesc !=  null)
 {
 var strTemplateDesc = objcss_TemplateEN.TemplateDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplateDesc = '{0}',", strTemplateDesc); //模板描述
 }
 else
 {
 sbSQL.Append(" TemplateDesc = null,"); //模板描述
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.OrderNum))
 {
 if (objcss_TemplateEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcss_TemplateEN.OrderNum, concss_Template.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.OrderNum); //序号
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplatePic))
 {
 if (objcss_TemplateEN.TemplatePic !=  null)
 {
 var strTemplatePic = objcss_TemplateEN.TemplatePic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TemplatePic = '{0}',", strTemplatePic); //模板图片
 }
 else
 {
 sbSQL.Append(" TemplatePic = null,"); //模板图片
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objcss_TemplateEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.IsDeleted))
 {
 sbSQL.AppendFormat(" IsDeleted = '{0}',", objcss_TemplateEN.IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.DeletedDate))
 {
 if (objcss_TemplateEN.DeletedDate !=  null)
 {
 var strDeletedDate = objcss_TemplateEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DeletedDate = '{0}',", strDeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" DeletedDate = null,"); //删除日期
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.UpdDate))
 {
 if (objcss_TemplateEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_TemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.UpdUser))
 {
 if (objcss_TemplateEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_TemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.Memo))
 {
 if (objcss_TemplateEN.Memo !=  null)
 {
 var strMemo = objcss_TemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscss_TemplateEN objcss_TemplateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcss_TemplateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcss_TemplateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update css_Template Set ");
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateName))
 {
 if (objcss_TemplateEN.TemplateName !=  null)
 {
 var strTemplateName = objcss_TemplateEN.TemplateName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplateName, concss_Template.TemplateName); //模板名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.TemplateName); //模板名称
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplateDesc))
 {
 if (objcss_TemplateEN.TemplateDesc !=  null)
 {
 var strTemplateDesc = objcss_TemplateEN.TemplateDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplateDesc, concss_Template.TemplateDesc); //模板描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.TemplateDesc); //模板描述
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.OrderNum))
 {
 if (objcss_TemplateEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcss_TemplateEN.OrderNum, concss_Template.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.OrderNum); //序号
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.TemplatePic))
 {
 if (objcss_TemplateEN.TemplatePic !=  null)
 {
 var strTemplatePic = objcss_TemplateEN.TemplatePic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTemplatePic, concss_Template.TemplatePic); //模板图片
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.TemplatePic); //模板图片
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcss_TemplateEN.IsPublic == true?"1":"0", concss_Template.IsPublic); //是否公开
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcss_TemplateEN.IsDeleted == true?"1":"0", concss_Template.IsDeleted); //是否删除
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.DeletedDate))
 {
 if (objcss_TemplateEN.DeletedDate !=  null)
 {
 var strDeletedDate = objcss_TemplateEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDeletedDate, concss_Template.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.DeletedDate); //删除日期
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.UpdDate))
 {
 if (objcss_TemplateEN.UpdDate !=  null)
 {
 var strUpdDate = objcss_TemplateEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concss_Template.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.UpdDate); //修改日期
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.UpdUser))
 {
 if (objcss_TemplateEN.UpdUser !=  null)
 {
 var strUpdUser = objcss_TemplateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concss_Template.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.UpdUser); //修改者
 }
 }
 
 if (objcss_TemplateEN.IsUpdated(concss_Template.Memo))
 {
 if (objcss_TemplateEN.Memo !=  null)
 {
 var strMemo = objcss_TemplateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concss_Template.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concss_Template.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TemplateId = '{0}'", objcss_TemplateEN.TemplateId); 
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
 /// <param name = "strTemplateId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTemplateId) 
{
CheckPrimaryKey(strTemplateId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTemplateId,
};
 objSQL.ExecSP("css_Template_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTemplateId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTemplateId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTemplateId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
//删除css_Template本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_Template where TemplateId = " + "'"+ strTemplateId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcss_Template(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
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
//删除css_Template本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_Template where TemplateId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTemplateId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTemplateId) 
{
CheckPrimaryKey(strTemplateId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
//删除css_Template本表中与当前对象有关的记录
strSQL = strSQL + "Delete from css_Template where TemplateId = " + "'"+ strTemplateId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcss_Template(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscss_TemplateDA: Delcss_Template)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from css_Template where " + strCondition ;
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
public bool Delcss_TemplateWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscss_TemplateDA: Delcss_TemplateWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from css_Template where " + strCondition ;
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
 /// <param name = "objcss_TemplateENS">源对象</param>
 /// <param name = "objcss_TemplateENT">目标对象</param>
public void CopyTo(clscss_TemplateEN objcss_TemplateENS, clscss_TemplateEN objcss_TemplateENT)
{
objcss_TemplateENT.TemplateId = objcss_TemplateENS.TemplateId; //模板ID
objcss_TemplateENT.TemplateName = objcss_TemplateENS.TemplateName; //模板名称
objcss_TemplateENT.TemplateDesc = objcss_TemplateENS.TemplateDesc; //模板描述
objcss_TemplateENT.OrderNum = objcss_TemplateENS.OrderNum; //序号
objcss_TemplateENT.TemplatePic = objcss_TemplateENS.TemplatePic; //模板图片
objcss_TemplateENT.IsPublic = objcss_TemplateENS.IsPublic; //是否公开
objcss_TemplateENT.IsDeleted = objcss_TemplateENS.IsDeleted; //是否删除
objcss_TemplateENT.DeletedDate = objcss_TemplateENS.DeletedDate; //删除日期
objcss_TemplateENT.UpdDate = objcss_TemplateENS.UpdDate; //修改日期
objcss_TemplateENT.UpdUser = objcss_TemplateENS.UpdUser; //修改者
objcss_TemplateENT.Memo = objcss_TemplateENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscss_TemplateEN objcss_TemplateEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplateId, 8, concss_Template.TemplateId);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplateName, 50, concss_Template.TemplateName);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplateDesc, 100, concss_Template.TemplateDesc);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplatePic, 100, concss_Template.TemplatePic);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.DeletedDate, 50, concss_Template.DeletedDate);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.UpdDate, 20, concss_Template.UpdDate);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.UpdUser, 20, concss_Template.UpdUser);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.Memo, 1000, concss_Template.Memo);
//检查字段外键固定长度
 objcss_TemplateEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscss_TemplateEN objcss_TemplateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplateName, 50, concss_Template.TemplateName);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplateDesc, 100, concss_Template.TemplateDesc);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplatePic, 100, concss_Template.TemplatePic);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.DeletedDate, 50, concss_Template.DeletedDate);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.UpdDate, 20, concss_Template.UpdDate);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.UpdUser, 20, concss_Template.UpdUser);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.Memo, 1000, concss_Template.Memo);
//检查外键字段长度
 objcss_TemplateEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscss_TemplateEN objcss_TemplateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplateId, 8, concss_Template.TemplateId);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplateName, 50, concss_Template.TemplateName);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplateDesc, 100, concss_Template.TemplateDesc);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.TemplatePic, 100, concss_Template.TemplatePic);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.DeletedDate, 50, concss_Template.DeletedDate);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.UpdDate, 20, concss_Template.UpdDate);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.UpdUser, 20, concss_Template.UpdUser);
clsCheckSql.CheckFieldLen(objcss_TemplateEN.Memo, 1000, concss_Template.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateEN.TemplateId, concss_Template.TemplateId);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateEN.TemplateName, concss_Template.TemplateName);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateEN.TemplateDesc, concss_Template.TemplateDesc);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateEN.TemplatePic, concss_Template.TemplatePic);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateEN.DeletedDate, concss_Template.DeletedDate);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateEN.UpdDate, concss_Template.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateEN.UpdUser, concss_Template.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objcss_TemplateEN.Memo, concss_Template.Memo);
//检查外键字段长度
 objcss_TemplateEN._IsCheckProperty = true;
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
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
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
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
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
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscss_TemplateEN._CurrTabName);
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
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscss_TemplateEN._CurrTabName, strCondition);
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
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
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
 objSQL = clscss_TemplateDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}