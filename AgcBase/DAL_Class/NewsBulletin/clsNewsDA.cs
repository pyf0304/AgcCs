
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsNewsDA
 表名:News(00050478)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:新闻公告(NewsBulletin)
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
 /// 新闻(News)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsNewsDA : clsCommBase4DA
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
 return clsNewsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsNewsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsNewsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsNewsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsNewsEN._ConnectString);
 }
 return objSQL;
 }


 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCond_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsNewsDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
 strSQL = "Select * from News where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "News");
 return objDS;
}

 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查,用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsNewsDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("News_SelectByCond",values, "News");
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表的顶部数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSet_Top(int intTopSize, string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsNewsDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from News where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "News");
 return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsNewsDA: GetNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsNewsDA: GetNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsNewsDA: GetNewsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsNewsDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from News a where {0} And a.Id_News not in (Select Top {2} Id_News From News Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "News");
return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsNewsDA: GetNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsNewsDA: GetNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsNewsDA: GetNewsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsNewsDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from News a where {0} And a.Id_News not in (Select Top {2} Id_News From News Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "News");
return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns>返回满足条件一定范围的DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsNewsDA: GetNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsNewsDA: GetNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsNewsDA: GetNewsByRange)", intMaxNum, intMinNum));
 }
try
{
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsNewsDA: GetDataSet)ByRange", objException.Message));
}
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsNewsDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from News a where {0} And a.Id_News not in (Select Top {2} Id_News From News Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "News");
return objDS;
}

 #endregion 获取数据表的DataSet

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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_News(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTable_News)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from News where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from News where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from News where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from News where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsNewsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} News.* from News Left Join {1} on {2} where {3} and News.Id_News not in (Select top {5} News.Id_News from News Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from News where {1} and Id_News not in (Select top {2} Id_News from News where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from News where {1} and Id_News not in (Select top {3} Id_News from News where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsNewsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} News.* from News Left Join {1} on {2} where {3} and News.Id_News not in (Select top {5} News.Id_News from News Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from News where {1} and Id_News not in (Select top {2} Id_News from News where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from News where {1} and Id_News not in (Select top {3} Id_News from News where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsNewsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} News.* from News Left Join {1} on {2} where {3} and News.Id_News not in (Select top {5} News.Id_News from News Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from News where {1} and Id_News not in (Select top {2} Id_News from News where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from News where {1} and Id_News not in (Select top {3} Id_News from News where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsNewsDA: GetNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsNewsDA: GetNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsNewsDA: GetNewsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from News a where {0} And a.Id_News not in (Select Top {2} Id_News From News Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from News a where {0} And a.Id_News not in (Select Top {2} Id_News From News Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, List<string> lstExclude)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsNewsDA: GetNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsNewsDA: GetNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsNewsDA: GetNewsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from News a where {0} And a.Id_News not in (Select Top {2} Id_News From News Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from News a where {0} And a.Id_News not in (Select Top {2} Id_News From News Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, bool bolIsCheckSQLAttack)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsNewsDA: GetNewsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsNewsDA: GetNewsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsNewsDA: GetNewsByRange)", intMaxNum, intMinNum));
 }
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsNewsDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("News_SelectByCond",values);
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
public List<clsNewsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsNewsDA:GetObjLst)", objException.Message));
}
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = TransNullToInt(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = TransNullToBool(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = TransNullToBool(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsNewsDA: GetObjLst)", objException.Message));
}
objNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objNewsEN);
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
public List<clsNewsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsNewsDA:GetObjLstByTabName)", objException.Message));
}
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = TransNullToInt(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = TransNullToBool(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = TransNullToBool(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsNewsDA: GetObjLst)", objException.Message));
}
objNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsNewsEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsNewsDA:GetObjLstBySP)", objException.Message));
}
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("News_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = TransNullToInt(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = TransNullToBool(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = TransNullToBool(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsNewsDA: GetObjLstBySP)", objException.Message));
}
objNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objNewsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objNewsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetNews(ref clsNewsEN objNewsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where Id_News = " + ""+ objNewsEN.Id_News+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objNewsEN.Id_News = TransNullToInt(objDT.Rows[0][conNews.Id_News].ToString().Trim()); //Id_News(字段类型:bigint,字段长度:8,是否可空:False)
 objNewsEN.NewsTypeId = objDT.Rows[0][conNews.NewsTypeId].ToString().Trim(); //信息类型Id(字段类型:char,字段长度:1,是否可空:False)
 objNewsEN.NewsTitle = objDT.Rows[0][conNews.NewsTitle].ToString().Trim(); //信息标题(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.NewsContent = objDT.Rows[0][conNews.NewsContent].ToString().Trim(); //信息内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objNewsEN.ImgPath = objDT.Rows[0][conNews.ImgPath].ToString().Trim(); //图片路径(字段类型:varchar,字段长度:500,是否可空:True)
 objNewsEN.EditPeople = objDT.Rows[0][conNews.EditPeople].ToString().Trim(); //编辑人(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.EditTime = objDT.Rows[0][conNews.EditTime].ToString().Trim(); //编辑时间(字段类型:varchar,字段长度:20,是否可空:True)
 objNewsEN.Source = objDT.Rows[0][conNews.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.IsTop = TransNullToBool(objDT.Rows[0][conNews.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objNewsEN.Views = TransNullToInt(objDT.Rows[0][conNews.Views].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objNewsEN.Audit = objDT.Rows[0][conNews.Audit].ToString().Trim(); //审核(字段类型:char,字段长度:1,是否可空:True)
 objNewsEN.IsDeleted = TransNullToBool(objDT.Rows[0][conNews.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objNewsEN.DeletedDate = objDT.Rows[0][conNews.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.Memo = objDT.Rows[0][conNews.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsNewsDA: GetNews)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_News">表关键字</param>
 /// <returns>表对象</returns>
public clsNewsEN GetObjById_News(long lngId_News)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where Id_News = " + ""+ lngId_News+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsNewsEN objNewsEN = new clsNewsEN();
try
{
 objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News(字段类型:bigint,字段长度:8,是否可空:False)
 objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id(字段类型:char,字段长度:1,是否可空:False)
 objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径(字段类型:varchar,字段长度:500,是否可空:True)
 objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间(字段类型:varchar,字段长度:20,是否可空:True)
 objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核(字段类型:char,字段长度:1,是否可空:True)
 objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsNewsDA: GetObjById_News)", objException.Message));
}
return objNewsEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程News_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objNewsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetNewsOneBySP(clsNewsEN objNewsEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objNewsEN.Id_News
};
 objDT = objSQL.ExecSpReturnDT("News_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objNewsEN.Id_News = TransNullToInt(objDT.Rows[0][conNews.Id_News].ToString().Trim()); //Id_News(字段类型:bigint,字段长度:8,是否可空:False)
 objNewsEN.NewsTypeId = objDT.Rows[0][conNews.NewsTypeId].ToString().Trim(); //信息类型Id(字段类型:char,字段长度:1,是否可空:False)
 objNewsEN.NewsTitle = objDT.Rows[0][conNews.NewsTitle].ToString().Trim(); //信息标题(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.NewsContent = objDT.Rows[0][conNews.NewsContent].ToString().Trim(); //信息内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objNewsEN.ImgPath = objDT.Rows[0][conNews.ImgPath].ToString().Trim(); //图片路径(字段类型:varchar,字段长度:500,是否可空:True)
 objNewsEN.EditPeople = objDT.Rows[0][conNews.EditPeople].ToString().Trim(); //编辑人(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.EditTime = objDT.Rows[0][conNews.EditTime].ToString().Trim(); //编辑时间(字段类型:varchar,字段长度:20,是否可空:True)
 objNewsEN.Source = objDT.Rows[0][conNews.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.IsTop = TransNullToBool(objDT.Rows[0][conNews.IsTop].ToString().Trim()); //是否置顶(字段类型:bit,字段长度:1,是否可空:True)
 objNewsEN.Views = TransNullToInt(objDT.Rows[0][conNews.Views].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objNewsEN.Audit = objDT.Rows[0][conNews.Audit].ToString().Trim(); //审核(字段类型:char,字段长度:1,是否可空:True)
 objNewsEN.IsDeleted = TransNullToBool(objDT.Rows[0][conNews.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objNewsEN.DeletedDate = objDT.Rows[0][conNews.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
 objNewsEN.Memo = objDT.Rows[0][conNews.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsNewsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsNewsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsNewsEN objNewsEN = new clsNewsEN()
{
Id_News = TransNullToInt(objRow[conNews.Id_News].ToString().Trim()), //Id_News
NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(), //信息类型Id
NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(), //信息标题
NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(), //信息内容
ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(), //图片路径
EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(), //编辑人
EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(), //编辑时间
Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(), //来源
IsTop = TransNullToBool(objRow[conNews.IsTop].ToString().Trim()), //是否置顶
Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conNews.Views].ToString().Trim()), //浏览量
Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(), //审核
IsDeleted = TransNullToBool(objRow[conNews.IsDeleted].ToString().Trim()), //是否删除
DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(), //删除日期
Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim() //说明
};
objNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objNewsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsNewsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsNewsEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsNewsDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("News_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsNewsEN objNewsEN = new clsNewsEN()
{
Id_News = TransNullToInt(objRow[conNews.Id_News].ToString().Trim()), //Id_News
NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(), //信息类型Id
NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(), //信息标题
NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(), //信息内容
ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(), //图片路径
EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(), //编辑人
EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(), //编辑时间
Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(), //来源
IsTop = TransNullToBool(objRow[conNews.IsTop].ToString().Trim()), //是否置顶
Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conNews.Views].ToString().Trim()), //浏览量
Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(), //审核
IsDeleted = TransNullToBool(objRow[conNews.IsDeleted].ToString().Trim()), //是否删除
DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(), //删除日期
Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim() //说明
};
objNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objNewsEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsNewsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = TransNullToInt(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = TransNullToBool(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = TransNullToBool(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsNewsDA: GetObjByDataRowNews)", objException.Message));
}
objNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objNewsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsNewsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = TransNullToInt(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = TransNullToBool(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = TransNullToBool(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsNewsDA: GetObjByDataRow)", objException.Message));
}
objNewsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objNewsEN;
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
objSQL = clsNewsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsNewsEN._CurrTabName, conNews.Id_News, 8, "");
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
objSQL = clsNewsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsNewsEN._CurrTabName, conNews.Id_News, 8, strPrefix);
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
 objSQL = clsNewsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select Id_News from News where " + strCondition;
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
 objSQL = clsNewsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select Id_News from News where " + strCondition;
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
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngId_News)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("News", "Id_News = " + ""+ lngId_News+""))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录, 用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistBySP)
 /// </summary>
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngId_News)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngId_News,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("News_IsExist", values);
if (arrReturn[0].ToString()  ==  "1")
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsNewsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("News", strCondition))
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
objSQL = clsNewsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("News");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsNewsEN objNewsEN)
 {
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objNewsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "News");
objRow = objDS.Tables["News"].NewRow();
objRow[conNews.NewsTypeId] = objNewsEN.NewsTypeId; //信息类型Id
 if (objNewsEN.NewsTitle !=  "")
 {
objRow[conNews.NewsTitle] = objNewsEN.NewsTitle; //信息标题
 }
 if (objNewsEN.NewsContent !=  "")
 {
objRow[conNews.NewsContent] = objNewsEN.NewsContent; //信息内容
 }
 if (objNewsEN.ImgPath !=  "")
 {
objRow[conNews.ImgPath] = objNewsEN.ImgPath; //图片路径
 }
 if (objNewsEN.EditPeople !=  "")
 {
objRow[conNews.EditPeople] = objNewsEN.EditPeople; //编辑人
 }
 if (objNewsEN.EditTime !=  "")
 {
objRow[conNews.EditTime] = objNewsEN.EditTime; //编辑时间
 }
 if (objNewsEN.Source !=  "")
 {
objRow[conNews.Source] = objNewsEN.Source; //来源
 }
objRow[conNews.IsTop] = objNewsEN.IsTop; //是否置顶
objRow[conNews.Views] = objNewsEN.Views; //浏览量
 if (objNewsEN.Audit !=  "")
 {
objRow[conNews.Audit] = objNewsEN.Audit; //审核
 }
objRow[conNews.IsDeleted] = objNewsEN.IsDeleted; //是否删除
 if (objNewsEN.DeletedDate !=  "")
 {
objRow[conNews.DeletedDate] = objNewsEN.DeletedDate; //删除日期
 }
 if (objNewsEN.Memo !=  "")
 {
objRow[conNews.Memo] = objNewsEN.Memo; //说明
 }
objDS.Tables[clsNewsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsNewsEN._CurrTabName);
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
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsNewsEN objNewsEN)
{
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objNewsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objNewsEN.NewsTypeId  ==  "")
 {
 objNewsEN.NewsTypeId = null;
 }
 if (objNewsEN.NewsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsTypeId);
 objNewsEN.NewsTypeId = objNewsEN.NewsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsTypeId + "'");
 }
 
 if (objNewsEN.NewsTitle !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsTitle);
 objNewsEN.NewsTitle = objNewsEN.NewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsTitle + "'");
 }
 
 if (objNewsEN.NewsContent !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsContent);
 objNewsEN.NewsContent = objNewsEN.NewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsContent + "'");
 }
 
 if (objNewsEN.ImgPath !=  null)
 {
 arrFieldListForInsert.Add(conNews.ImgPath);
 objNewsEN.ImgPath = objNewsEN.ImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.ImgPath + "'");
 }
 
 if (objNewsEN.EditPeople !=  null)
 {
 arrFieldListForInsert.Add(conNews.EditPeople);
 objNewsEN.EditPeople = objNewsEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.EditPeople + "'");
 }
 
 if (objNewsEN.EditTime !=  null)
 {
 arrFieldListForInsert.Add(conNews.EditTime);
 objNewsEN.EditTime = objNewsEN.EditTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.EditTime + "'");
 }
 
 if (objNewsEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conNews.Source);
 objNewsEN.Source = objNewsEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Source + "'");
 }
 
 arrFieldListForInsert.Add(conNews.IsTop);
 arrValueListForInsert.Add("'" + (objNewsEN.IsTop  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conNews.Views);
 arrValueListForInsert.Add(objNewsEN.Views.ToString());
 
 if (objNewsEN.Audit !=  null)
 {
 arrFieldListForInsert.Add(conNews.Audit);
 objNewsEN.Audit = objNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Audit + "'");
 }
 
 arrFieldListForInsert.Add(conNews.IsDeleted);
 arrValueListForInsert.Add("'" + (objNewsEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objNewsEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(conNews.DeletedDate);
 objNewsEN.DeletedDate = objNewsEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.DeletedDate + "'");
 }
 
 if (objNewsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conNews.Memo);
 objNewsEN.Memo = objNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into News");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsNewsEN objNewsEN)
{
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objNewsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objNewsEN.NewsTypeId  ==  "")
 {
 objNewsEN.NewsTypeId = null;
 }
 if (objNewsEN.NewsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsTypeId);
 objNewsEN.NewsTypeId = objNewsEN.NewsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsTypeId + "'");
 }
 
 if (objNewsEN.NewsTitle !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsTitle);
 objNewsEN.NewsTitle = objNewsEN.NewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsTitle + "'");
 }
 
 if (objNewsEN.NewsContent !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsContent);
 objNewsEN.NewsContent = objNewsEN.NewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsContent + "'");
 }
 
 if (objNewsEN.ImgPath !=  null)
 {
 arrFieldListForInsert.Add(conNews.ImgPath);
 objNewsEN.ImgPath = objNewsEN.ImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.ImgPath + "'");
 }
 
 if (objNewsEN.EditPeople !=  null)
 {
 arrFieldListForInsert.Add(conNews.EditPeople);
 objNewsEN.EditPeople = objNewsEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.EditPeople + "'");
 }
 
 if (objNewsEN.EditTime !=  null)
 {
 arrFieldListForInsert.Add(conNews.EditTime);
 objNewsEN.EditTime = objNewsEN.EditTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.EditTime + "'");
 }
 
 if (objNewsEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conNews.Source);
 objNewsEN.Source = objNewsEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Source + "'");
 }
 
 arrFieldListForInsert.Add(conNews.IsTop);
 arrValueListForInsert.Add("'" + (objNewsEN.IsTop  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conNews.Views);
 arrValueListForInsert.Add(objNewsEN.Views.ToString());
 
 if (objNewsEN.Audit !=  null)
 {
 arrFieldListForInsert.Add(conNews.Audit);
 objNewsEN.Audit = objNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Audit + "'");
 }
 
 arrFieldListForInsert.Add(conNews.IsDeleted);
 arrValueListForInsert.Add("'" + (objNewsEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objNewsEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(conNews.DeletedDate);
 objNewsEN.DeletedDate = objNewsEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.DeletedDate + "'");
 }
 
 if (objNewsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conNews.Memo);
 objNewsEN.Memo = objNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into News");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsNewsEN objNewsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objNewsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objNewsEN.NewsTypeId  ==  "")
 {
 objNewsEN.NewsTypeId = null;
 }
 if (objNewsEN.NewsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsTypeId);
 objNewsEN.NewsTypeId = objNewsEN.NewsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsTypeId + "'");
 }
 
 if (objNewsEN.NewsTitle !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsTitle);
 objNewsEN.NewsTitle = objNewsEN.NewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsTitle + "'");
 }
 
 if (objNewsEN.NewsContent !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsContent);
 objNewsEN.NewsContent = objNewsEN.NewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsContent + "'");
 }
 
 if (objNewsEN.ImgPath !=  null)
 {
 arrFieldListForInsert.Add(conNews.ImgPath);
 objNewsEN.ImgPath = objNewsEN.ImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.ImgPath + "'");
 }
 
 if (objNewsEN.EditPeople !=  null)
 {
 arrFieldListForInsert.Add(conNews.EditPeople);
 objNewsEN.EditPeople = objNewsEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.EditPeople + "'");
 }
 
 if (objNewsEN.EditTime !=  null)
 {
 arrFieldListForInsert.Add(conNews.EditTime);
 objNewsEN.EditTime = objNewsEN.EditTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.EditTime + "'");
 }
 
 if (objNewsEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conNews.Source);
 objNewsEN.Source = objNewsEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Source + "'");
 }
 
 arrFieldListForInsert.Add(conNews.IsTop);
 arrValueListForInsert.Add("'" + (objNewsEN.IsTop  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conNews.Views);
 arrValueListForInsert.Add(objNewsEN.Views.ToString());
 
 if (objNewsEN.Audit !=  null)
 {
 arrFieldListForInsert.Add(conNews.Audit);
 objNewsEN.Audit = objNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Audit + "'");
 }
 
 arrFieldListForInsert.Add(conNews.IsDeleted);
 arrValueListForInsert.Add("'" + (objNewsEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objNewsEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(conNews.DeletedDate);
 objNewsEN.DeletedDate = objNewsEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.DeletedDate + "'");
 }
 
 if (objNewsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conNews.Memo);
 objNewsEN.Memo = objNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into News");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsNewsEN objNewsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objNewsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objNewsEN.NewsTypeId  ==  "")
 {
 objNewsEN.NewsTypeId = null;
 }
 if (objNewsEN.NewsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsTypeId);
 objNewsEN.NewsTypeId = objNewsEN.NewsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsTypeId + "'");
 }
 
 if (objNewsEN.NewsTitle !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsTitle);
 objNewsEN.NewsTitle = objNewsEN.NewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsTitle + "'");
 }
 
 if (objNewsEN.NewsContent !=  null)
 {
 arrFieldListForInsert.Add(conNews.NewsContent);
 objNewsEN.NewsContent = objNewsEN.NewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.NewsContent + "'");
 }
 
 if (objNewsEN.ImgPath !=  null)
 {
 arrFieldListForInsert.Add(conNews.ImgPath);
 objNewsEN.ImgPath = objNewsEN.ImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.ImgPath + "'");
 }
 
 if (objNewsEN.EditPeople !=  null)
 {
 arrFieldListForInsert.Add(conNews.EditPeople);
 objNewsEN.EditPeople = objNewsEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.EditPeople + "'");
 }
 
 if (objNewsEN.EditTime !=  null)
 {
 arrFieldListForInsert.Add(conNews.EditTime);
 objNewsEN.EditTime = objNewsEN.EditTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.EditTime + "'");
 }
 
 if (objNewsEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conNews.Source);
 objNewsEN.Source = objNewsEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Source + "'");
 }
 
 arrFieldListForInsert.Add(conNews.IsTop);
 arrValueListForInsert.Add("'" + (objNewsEN.IsTop  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conNews.Views);
 arrValueListForInsert.Add(objNewsEN.Views.ToString());
 
 if (objNewsEN.Audit !=  null)
 {
 arrFieldListForInsert.Add(conNews.Audit);
 objNewsEN.Audit = objNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Audit + "'");
 }
 
 arrFieldListForInsert.Add(conNews.IsDeleted);
 arrValueListForInsert.Add("'" + (objNewsEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 if (objNewsEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(conNews.DeletedDate);
 objNewsEN.DeletedDate = objNewsEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.DeletedDate + "'");
 }
 
 if (objNewsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conNews.Memo);
 objNewsEN.Memo = objNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objNewsEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into News");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objNewsEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewNewsBySP(clsNewsEN objNewsEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objNewsEN.NewsTypeId,
 objNewsEN.NewsTitle,
 objNewsEN.NewsContent,
 objNewsEN.ImgPath,
 objNewsEN.EditPeople,
 objNewsEN.EditTime,
 objNewsEN.Source,
 objNewsEN.IsTop,
 objNewsEN.Views,
 objNewsEN.Audit,
 objNewsEN.IsDeleted,
 objNewsEN.DeletedDate,
objNewsEN.Memo
};
 objSQL.ExecSP("News_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewNewss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where Id_News = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "News");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngId_News = TransNullToInt(oRow[conNews.Id_News].ToString().Trim());
if (IsExist(lngId_News))
{
 string strResult = "关键字变量值为:" + string.Format("Id_News = {0}", lngId_News) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsNewsEN._CurrTabName ].NewRow();
objRow[conNews.NewsTypeId] = oRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objRow[conNews.NewsTitle] = oRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objRow[conNews.NewsContent] = oRow[conNews.NewsContent].ToString().Trim(); //信息内容
objRow[conNews.ImgPath] = oRow[conNews.ImgPath].ToString().Trim(); //图片路径
objRow[conNews.EditPeople] = oRow[conNews.EditPeople].ToString().Trim(); //编辑人
objRow[conNews.EditTime] = oRow[conNews.EditTime].ToString().Trim(); //编辑时间
objRow[conNews.Source] = oRow[conNews.Source].ToString().Trim(); //来源
objRow[conNews.IsTop] = oRow[conNews.IsTop].ToString().Trim(); //是否置顶
objRow[conNews.Views] = oRow[conNews.Views].ToString().Trim(); //浏览量
objRow[conNews.Audit] = oRow[conNews.Audit].ToString().Trim(); //审核
objRow[conNews.IsDeleted] = oRow[conNews.IsDeleted].ToString().Trim(); //是否删除
objRow[conNews.DeletedDate] = oRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objRow[conNews.Memo] = oRow[conNews.Memo].ToString().Trim(); //说明
 objDS.Tables[clsNewsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsNewsEN._CurrTabName);
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
 /// <param name = "objNewsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsNewsEN objNewsEN)
{
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objNewsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
strSQL = "Select * from News where Id_News = " + ""+ objNewsEN.Id_News+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsNewsEN._CurrTabName);
if (objDS.Tables[clsNewsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:Id_News = " + ""+ objNewsEN.Id_News+"");
return false;
}
objRow = objDS.Tables[clsNewsEN._CurrTabName].Rows[0];
 if (objNewsEN.IsUpdated(conNews.NewsTypeId))
 {
objRow[conNews.NewsTypeId] = objNewsEN.NewsTypeId; //信息类型Id
 }
 if (objNewsEN.IsUpdated(conNews.NewsTitle))
 {
objRow[conNews.NewsTitle] = objNewsEN.NewsTitle; //信息标题
 }
 if (objNewsEN.IsUpdated(conNews.NewsContent))
 {
objRow[conNews.NewsContent] = objNewsEN.NewsContent; //信息内容
 }
 if (objNewsEN.IsUpdated(conNews.ImgPath))
 {
objRow[conNews.ImgPath] = objNewsEN.ImgPath; //图片路径
 }
 if (objNewsEN.IsUpdated(conNews.EditPeople))
 {
objRow[conNews.EditPeople] = objNewsEN.EditPeople; //编辑人
 }
 if (objNewsEN.IsUpdated(conNews.EditTime))
 {
objRow[conNews.EditTime] = objNewsEN.EditTime; //编辑时间
 }
 if (objNewsEN.IsUpdated(conNews.Source))
 {
objRow[conNews.Source] = objNewsEN.Source; //来源
 }
 if (objNewsEN.IsUpdated(conNews.IsTop))
 {
objRow[conNews.IsTop] = objNewsEN.IsTop; //是否置顶
 }
 if (objNewsEN.IsUpdated(conNews.Views))
 {
objRow[conNews.Views] = objNewsEN.Views; //浏览量
 }
 if (objNewsEN.IsUpdated(conNews.Audit))
 {
objRow[conNews.Audit] = objNewsEN.Audit; //审核
 }
 if (objNewsEN.IsUpdated(conNews.IsDeleted))
 {
objRow[conNews.IsDeleted] = objNewsEN.IsDeleted; //是否删除
 }
 if (objNewsEN.IsUpdated(conNews.DeletedDate))
 {
objRow[conNews.DeletedDate] = objNewsEN.DeletedDate; //删除日期
 }
 if (objNewsEN.IsUpdated(conNews.Memo))
 {
objRow[conNews.Memo] = objNewsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsNewsEN._CurrTabName);
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
 /// /// 功能:通过存储过程(StoreProcedure)来修改记录
 /// /// 缺点:1、不能支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySP)
 /// </summary>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySP(clsNewsEN objNewsEN)
{
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objNewsEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objNewsEN.Id_News,
 objNewsEN.NewsTypeId,
 objNewsEN.NewsTitle,
 objNewsEN.NewsContent,
 objNewsEN.ImgPath,
 objNewsEN.EditPeople,
 objNewsEN.EditTime,
 objNewsEN.Source,
 objNewsEN.IsTop,
 objNewsEN.Views,
 objNewsEN.Audit,
 objNewsEN.IsDeleted,
 objNewsEN.DeletedDate,
 objNewsEN.Memo
};
 objSQL.ExecSP("News_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsNewsEN objNewsEN)
{
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objNewsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update News Set ");
 
 if (objNewsEN.IsUpdated(conNews.NewsTypeId))
 {
 if (objNewsEN.NewsTypeId  ==  "")
 {
 objNewsEN.NewsTypeId = null;
 }
 if (objNewsEN.NewsTypeId !=  null)
 {
 objNewsEN.NewsTypeId = objNewsEN.NewsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.NewsTypeId, conNews.NewsTypeId); //信息类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.NewsTypeId); //信息类型Id
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.NewsTitle))
 {
 if (objNewsEN.NewsTitle !=  null)
 {
 objNewsEN.NewsTitle = objNewsEN.NewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.NewsTitle, conNews.NewsTitle); //信息标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.NewsTitle); //信息标题
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.NewsContent))
 {
 if (objNewsEN.NewsContent !=  null)
 {
 objNewsEN.NewsContent = objNewsEN.NewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.NewsContent, conNews.NewsContent); //信息内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.NewsContent); //信息内容
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.ImgPath))
 {
 if (objNewsEN.ImgPath !=  null)
 {
 objNewsEN.ImgPath = objNewsEN.ImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.ImgPath, conNews.ImgPath); //图片路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.ImgPath); //图片路径
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.EditPeople))
 {
 if (objNewsEN.EditPeople !=  null)
 {
 objNewsEN.EditPeople = objNewsEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.EditPeople, conNews.EditPeople); //编辑人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.EditPeople); //编辑人
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.EditTime))
 {
 if (objNewsEN.EditTime !=  null)
 {
 objNewsEN.EditTime = objNewsEN.EditTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.EditTime, conNews.EditTime); //编辑时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.EditTime); //编辑时间
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.Source))
 {
 if (objNewsEN.Source !=  null)
 {
 objNewsEN.Source = objNewsEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.Source, conNews.Source); //来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.Source); //来源
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.IsTop))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objNewsEN.IsTop == true?"1":"0", conNews.IsTop); //是否置顶
 }
 
 if (objNewsEN.IsUpdated(conNews.Views))
 {
 sbSQL.AppendFormat("{1} = {0},",objNewsEN.Views, conNews.Views); //浏览量
 }
 
 if (objNewsEN.IsUpdated(conNews.Audit))
 {
 if (objNewsEN.Audit !=  null)
 {
 objNewsEN.Audit = objNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.Audit, conNews.Audit); //审核
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.Audit); //审核
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objNewsEN.IsDeleted == true?"1":"0", conNews.IsDeleted); //是否删除
 }
 
 if (objNewsEN.IsUpdated(conNews.DeletedDate))
 {
 if (objNewsEN.DeletedDate !=  null)
 {
 objNewsEN.DeletedDate = objNewsEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.DeletedDate, conNews.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.DeletedDate); //删除日期
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.Memo))
 {
 if (objNewsEN.Memo !=  null)
 {
 objNewsEN.Memo = objNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.Memo, conNews.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where Id_News = {0}", objNewsEN.Id_News); 
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
 /// <param name = "objNewsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsNewsEN objNewsEN, string strCondition)
{
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objNewsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update News Set ");
 
 if (objNewsEN.IsUpdated(conNews.NewsTypeId))
 {
 if (objNewsEN.NewsTypeId  ==  "")
 {
 objNewsEN.NewsTypeId = null;
 }
 if (objNewsEN.NewsTypeId !=  null)
 {
 objNewsEN.NewsTypeId = objNewsEN.NewsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NewsTypeId = '{0}',", objNewsEN.NewsTypeId); //信息类型Id
 }
 else
 {
 sbSQL.Append(" NewsTypeId = null,"); //信息类型Id
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.NewsTitle))
 {
 if (objNewsEN.NewsTitle !=  null)
 {
 objNewsEN.NewsTitle = objNewsEN.NewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NewsTitle = '{0}',", objNewsEN.NewsTitle); //信息标题
 }
 else
 {
 sbSQL.Append(" NewsTitle = null,"); //信息标题
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.NewsContent))
 {
 if (objNewsEN.NewsContent !=  null)
 {
 objNewsEN.NewsContent = objNewsEN.NewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NewsContent = '{0}',", objNewsEN.NewsContent); //信息内容
 }
 else
 {
 sbSQL.Append(" NewsContent = null,"); //信息内容
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.ImgPath))
 {
 if (objNewsEN.ImgPath !=  null)
 {
 objNewsEN.ImgPath = objNewsEN.ImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImgPath = '{0}',", objNewsEN.ImgPath); //图片路径
 }
 else
 {
 sbSQL.Append(" ImgPath = null,"); //图片路径
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.EditPeople))
 {
 if (objNewsEN.EditPeople !=  null)
 {
 objNewsEN.EditPeople = objNewsEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EditPeople = '{0}',", objNewsEN.EditPeople); //编辑人
 }
 else
 {
 sbSQL.Append(" EditPeople = null,"); //编辑人
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.EditTime))
 {
 if (objNewsEN.EditTime !=  null)
 {
 objNewsEN.EditTime = objNewsEN.EditTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EditTime = '{0}',", objNewsEN.EditTime); //编辑时间
 }
 else
 {
 sbSQL.Append(" EditTime = null,"); //编辑时间
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.Source))
 {
 if (objNewsEN.Source !=  null)
 {
 objNewsEN.Source = objNewsEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Source = '{0}',", objNewsEN.Source); //来源
 }
 else
 {
 sbSQL.Append(" Source = null,"); //来源
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.IsTop))
 {
 sbSQL.AppendFormat(" IsTop = '{0}',", objNewsEN.IsTop == true?"1":"0"); //是否置顶
 }
 
 if (objNewsEN.IsUpdated(conNews.Views))
 {
 sbSQL.AppendFormat(" Views = {0},", objNewsEN.Views); //浏览量
 }
 
 if (objNewsEN.IsUpdated(conNews.Audit))
 {
 if (objNewsEN.Audit !=  null)
 {
 objNewsEN.Audit = objNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Audit = '{0}',", objNewsEN.Audit); //审核
 }
 else
 {
 sbSQL.Append(" Audit = null,"); //审核
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.IsDeleted))
 {
 sbSQL.AppendFormat(" IsDeleted = '{0}',", objNewsEN.IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objNewsEN.IsUpdated(conNews.DeletedDate))
 {
 if (objNewsEN.DeletedDate !=  null)
 {
 objNewsEN.DeletedDate = objNewsEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DeletedDate = '{0}',", objNewsEN.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" DeletedDate = null,"); //删除日期
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.Memo))
 {
 if (objNewsEN.Memo !=  null)
 {
 objNewsEN.Memo = objNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objNewsEN.Memo); //说明
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
 /// <param name = "objNewsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsNewsEN objNewsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objNewsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update News Set ");
 
 if (objNewsEN.IsUpdated(conNews.NewsTypeId))
 {
 if (objNewsEN.NewsTypeId  ==  "")
 {
 objNewsEN.NewsTypeId = null;
 }
 if (objNewsEN.NewsTypeId !=  null)
 {
 objNewsEN.NewsTypeId = objNewsEN.NewsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NewsTypeId = '{0}',", objNewsEN.NewsTypeId); //信息类型Id
 }
 else
 {
 sbSQL.Append(" NewsTypeId = null,"); //信息类型Id
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.NewsTitle))
 {
 if (objNewsEN.NewsTitle !=  null)
 {
 objNewsEN.NewsTitle = objNewsEN.NewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NewsTitle = '{0}',", objNewsEN.NewsTitle); //信息标题
 }
 else
 {
 sbSQL.Append(" NewsTitle = null,"); //信息标题
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.NewsContent))
 {
 if (objNewsEN.NewsContent !=  null)
 {
 objNewsEN.NewsContent = objNewsEN.NewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NewsContent = '{0}',", objNewsEN.NewsContent); //信息内容
 }
 else
 {
 sbSQL.Append(" NewsContent = null,"); //信息内容
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.ImgPath))
 {
 if (objNewsEN.ImgPath !=  null)
 {
 objNewsEN.ImgPath = objNewsEN.ImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImgPath = '{0}',", objNewsEN.ImgPath); //图片路径
 }
 else
 {
 sbSQL.Append(" ImgPath = null,"); //图片路径
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.EditPeople))
 {
 if (objNewsEN.EditPeople !=  null)
 {
 objNewsEN.EditPeople = objNewsEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EditPeople = '{0}',", objNewsEN.EditPeople); //编辑人
 }
 else
 {
 sbSQL.Append(" EditPeople = null,"); //编辑人
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.EditTime))
 {
 if (objNewsEN.EditTime !=  null)
 {
 objNewsEN.EditTime = objNewsEN.EditTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EditTime = '{0}',", objNewsEN.EditTime); //编辑时间
 }
 else
 {
 sbSQL.Append(" EditTime = null,"); //编辑时间
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.Source))
 {
 if (objNewsEN.Source !=  null)
 {
 objNewsEN.Source = objNewsEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Source = '{0}',", objNewsEN.Source); //来源
 }
 else
 {
 sbSQL.Append(" Source = null,"); //来源
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.IsTop))
 {
 sbSQL.AppendFormat(" IsTop = '{0}',", objNewsEN.IsTop == true?"1":"0"); //是否置顶
 }
 
 if (objNewsEN.IsUpdated(conNews.Views))
 {
 sbSQL.AppendFormat(" Views = {0},", objNewsEN.Views); //浏览量
 }
 
 if (objNewsEN.IsUpdated(conNews.Audit))
 {
 if (objNewsEN.Audit !=  null)
 {
 objNewsEN.Audit = objNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Audit = '{0}',", objNewsEN.Audit); //审核
 }
 else
 {
 sbSQL.Append(" Audit = null,"); //审核
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.IsDeleted))
 {
 sbSQL.AppendFormat(" IsDeleted = '{0}',", objNewsEN.IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objNewsEN.IsUpdated(conNews.DeletedDate))
 {
 if (objNewsEN.DeletedDate !=  null)
 {
 objNewsEN.DeletedDate = objNewsEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DeletedDate = '{0}',", objNewsEN.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" DeletedDate = null,"); //删除日期
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.Memo))
 {
 if (objNewsEN.Memo !=  null)
 {
 objNewsEN.Memo = objNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objNewsEN.Memo); //说明
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
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsNewsEN objNewsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objNewsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objNewsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update News Set ");
 
 if (objNewsEN.IsUpdated(conNews.NewsTypeId))
 {
 if (objNewsEN.NewsTypeId  ==  "")
 {
 objNewsEN.NewsTypeId = null;
 }
 if (objNewsEN.NewsTypeId !=  null)
 {
 objNewsEN.NewsTypeId = objNewsEN.NewsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.NewsTypeId, conNews.NewsTypeId); //信息类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.NewsTypeId); //信息类型Id
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.NewsTitle))
 {
 if (objNewsEN.NewsTitle !=  null)
 {
 objNewsEN.NewsTitle = objNewsEN.NewsTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.NewsTitle, conNews.NewsTitle); //信息标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.NewsTitle); //信息标题
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.NewsContent))
 {
 if (objNewsEN.NewsContent !=  null)
 {
 objNewsEN.NewsContent = objNewsEN.NewsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.NewsContent, conNews.NewsContent); //信息内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.NewsContent); //信息内容
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.ImgPath))
 {
 if (objNewsEN.ImgPath !=  null)
 {
 objNewsEN.ImgPath = objNewsEN.ImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.ImgPath, conNews.ImgPath); //图片路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.ImgPath); //图片路径
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.EditPeople))
 {
 if (objNewsEN.EditPeople !=  null)
 {
 objNewsEN.EditPeople = objNewsEN.EditPeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.EditPeople, conNews.EditPeople); //编辑人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.EditPeople); //编辑人
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.EditTime))
 {
 if (objNewsEN.EditTime !=  null)
 {
 objNewsEN.EditTime = objNewsEN.EditTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.EditTime, conNews.EditTime); //编辑时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.EditTime); //编辑时间
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.Source))
 {
 if (objNewsEN.Source !=  null)
 {
 objNewsEN.Source = objNewsEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.Source, conNews.Source); //来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.Source); //来源
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.IsTop))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objNewsEN.IsTop == true?"1":"0", conNews.IsTop); //是否置顶
 }
 
 if (objNewsEN.IsUpdated(conNews.Views))
 {
 sbSQL.AppendFormat("{1} = {0},",objNewsEN.Views, conNews.Views); //浏览量
 }
 
 if (objNewsEN.IsUpdated(conNews.Audit))
 {
 if (objNewsEN.Audit !=  null)
 {
 objNewsEN.Audit = objNewsEN.Audit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.Audit, conNews.Audit); //审核
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.Audit); //审核
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objNewsEN.IsDeleted == true?"1":"0", conNews.IsDeleted); //是否删除
 }
 
 if (objNewsEN.IsUpdated(conNews.DeletedDate))
 {
 if (objNewsEN.DeletedDate !=  null)
 {
 objNewsEN.DeletedDate = objNewsEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.DeletedDate, conNews.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.DeletedDate); //删除日期
 }
 }
 
 if (objNewsEN.IsUpdated(conNews.Memo))
 {
 if (objNewsEN.Memo !=  null)
 {
 objNewsEN.Memo = objNewsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objNewsEN.Memo, conNews.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conNews.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where Id_News = {0}", objNewsEN.Id_News); 
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
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngId_News) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngId_News,
};
 objSQL.ExecSP("News_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngId_News, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
//删除News本表中与当前对象有关的记录
strSQL = strSQL + "Delete from News where Id_News = " + ""+ lngId_News+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelNews(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
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
//删除News本表中与当前对象有关的记录
strSQL = strSQL + "Delete from News where Id_News in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngId_News) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
//删除News本表中与当前对象有关的记录
strSQL = strSQL + "Delete from News where Id_News = " + ""+ lngId_News+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelNews(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsNewsDA: DelNews)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from News where " + strCondition ;
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
public bool DelNewsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsNewsDA: DelNewsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsNewsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from News where " + strCondition ;
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
 /// <param name = "objNewsENS">源对象</param>
 /// <param name = "objNewsENT">目标对象</param>
public void CopyTo(clsNewsEN objNewsENS, clsNewsEN objNewsENT)
{
objNewsENT.Id_News = objNewsENS.Id_News; //Id_News
objNewsENT.NewsTypeId = objNewsENS.NewsTypeId; //信息类型Id
objNewsENT.NewsTitle = objNewsENS.NewsTitle; //信息标题
objNewsENT.NewsContent = objNewsENS.NewsContent; //信息内容
objNewsENT.ImgPath = objNewsENS.ImgPath; //图片路径
objNewsENT.EditPeople = objNewsENS.EditPeople; //编辑人
objNewsENT.EditTime = objNewsENS.EditTime; //编辑时间
objNewsENT.Source = objNewsENS.Source; //来源
objNewsENT.IsTop = objNewsENS.IsTop; //是否置顶
objNewsENT.Views = objNewsENS.Views; //浏览量
objNewsENT.Audit = objNewsENS.Audit; //审核
objNewsENT.IsDeleted = objNewsENS.IsDeleted; //是否删除
objNewsENT.DeletedDate = objNewsENS.DeletedDate; //删除日期
objNewsENT.Memo = objNewsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsNewsEN objNewsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objNewsEN.NewsTypeId, conNews.NewsTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objNewsEN.NewsTypeId, 1, conNews.NewsTypeId);
clsCheckSql.CheckFieldLen(objNewsEN.NewsTitle, 50, conNews.NewsTitle);
clsCheckSql.CheckFieldLen(objNewsEN.ImgPath, 500, conNews.ImgPath);
clsCheckSql.CheckFieldLen(objNewsEN.EditPeople, 50, conNews.EditPeople);
clsCheckSql.CheckFieldLen(objNewsEN.EditTime, 20, conNews.EditTime);
clsCheckSql.CheckFieldLen(objNewsEN.Source, 50, conNews.Source);
clsCheckSql.CheckFieldLen(objNewsEN.Audit, 1, conNews.Audit);
clsCheckSql.CheckFieldLen(objNewsEN.DeletedDate, 50, conNews.DeletedDate);
clsCheckSql.CheckFieldLen(objNewsEN.Memo, 1000, conNews.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objNewsEN.NewsTypeId, 1, conNews.NewsTypeId);
 objNewsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsNewsEN objNewsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objNewsEN.NewsTypeId, 1, conNews.NewsTypeId);
clsCheckSql.CheckFieldLen(objNewsEN.NewsTitle, 50, conNews.NewsTitle);
clsCheckSql.CheckFieldLen(objNewsEN.ImgPath, 500, conNews.ImgPath);
clsCheckSql.CheckFieldLen(objNewsEN.EditPeople, 50, conNews.EditPeople);
clsCheckSql.CheckFieldLen(objNewsEN.EditTime, 20, conNews.EditTime);
clsCheckSql.CheckFieldLen(objNewsEN.Source, 50, conNews.Source);
clsCheckSql.CheckFieldLen(objNewsEN.Audit, 1, conNews.Audit);
clsCheckSql.CheckFieldLen(objNewsEN.DeletedDate, 50, conNews.DeletedDate);
clsCheckSql.CheckFieldLen(objNewsEN.Memo, 1000, conNews.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objNewsEN.NewsTypeId, 1, conNews.NewsTypeId);
 objNewsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsNewsEN objNewsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objNewsEN.NewsTypeId, 1, conNews.NewsTypeId);
clsCheckSql.CheckFieldLen(objNewsEN.NewsTitle, 50, conNews.NewsTitle);
clsCheckSql.CheckFieldLen(objNewsEN.ImgPath, 500, conNews.ImgPath);
clsCheckSql.CheckFieldLen(objNewsEN.EditPeople, 50, conNews.EditPeople);
clsCheckSql.CheckFieldLen(objNewsEN.EditTime, 20, conNews.EditTime);
clsCheckSql.CheckFieldLen(objNewsEN.Source, 50, conNews.Source);
clsCheckSql.CheckFieldLen(objNewsEN.Audit, 1, conNews.Audit);
clsCheckSql.CheckFieldLen(objNewsEN.DeletedDate, 50, conNews.DeletedDate);
clsCheckSql.CheckFieldLen(objNewsEN.Memo, 1000, conNews.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objNewsEN.NewsTypeId, conNews.NewsTypeId);
clsCheckSql.CheckSqlInjection4Field(objNewsEN.NewsTitle, conNews.NewsTitle);
clsCheckSql.CheckSqlInjection4Field(objNewsEN.ImgPath, conNews.ImgPath);
clsCheckSql.CheckSqlInjection4Field(objNewsEN.EditPeople, conNews.EditPeople);
clsCheckSql.CheckSqlInjection4Field(objNewsEN.EditTime, conNews.EditTime);
clsCheckSql.CheckSqlInjection4Field(objNewsEN.Source, conNews.Source);
clsCheckSql.CheckSqlInjection4Field(objNewsEN.Audit, conNews.Audit);
clsCheckSql.CheckSqlInjection4Field(objNewsEN.DeletedDate, conNews.DeletedDate);
clsCheckSql.CheckSqlInjection4Field(objNewsEN.Memo, conNews.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objNewsEN.NewsTypeId, 1, conNews.NewsTypeId);
 objNewsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--News(新闻),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objNewsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStrNewsTitle_EditPeople(clsNewsEN objNewsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objNewsEN.NewsTitle == null)
{
 sbCondition.AppendFormat(" and NewsTitle is null");
}
else
{
 sbCondition.AppendFormat(" and NewsTitle = '{0}'", objNewsEN.NewsTitle);
}
 if (objNewsEN.EditPeople == null)
{
 sbCondition.AppendFormat(" and EditPeople is null");
}
else
{
 sbCondition.AppendFormat(" and EditPeople = '{0}'", objNewsEN.EditPeople);
}
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
 objSQL = clsNewsDA.GetSpecSQLObj();
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
 objSQL = clsNewsDA.GetSpecSQLObj();
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
 objSQL = clsNewsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsNewsEN._CurrTabName);
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
 objSQL = clsNewsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsNewsEN._CurrTabName, strCondition);
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
 objSQL = clsNewsDA.GetSpecSQLObj();
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
 objSQL = clsNewsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}