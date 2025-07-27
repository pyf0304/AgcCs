
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewGroupFldsDA
 表名:ViewGroupFlds(00050136)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 界面组字段集合(ViewGroupFlds)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsViewGroupFldsDA : clsCommBase4DA
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
 return clsViewGroupFldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewGroupFldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewGroupFldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewGroupFldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewGroupFldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
 strSQL = "Select * from ViewGroupFlds where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "ViewGroupFlds");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("ViewGroupFlds_SelectByCond",values, "ViewGroupFlds");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "ViewGroupFlds");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from ViewGroupFlds a where {0} And a.mId not in (Select Top {2} mId From ViewGroupFlds Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "ViewGroupFlds");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from ViewGroupFlds a where {0} And a.mId not in (Select Top {2} mId From ViewGroupFlds Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "ViewGroupFlds");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from ViewGroupFlds a where {0} And a.mId not in (Select Top {2} mId From ViewGroupFlds Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "ViewGroupFlds");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewGroupFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTable_ViewGroupFlds)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ViewGroupFlds.* from ViewGroupFlds Left Join {1} on {2} where {3} and ViewGroupFlds.mId not in (Select top {5} ViewGroupFlds.mId from ViewGroupFlds Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1} and mId not in (Select top {2} mId from ViewGroupFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1} and mId not in (Select top {3} mId from ViewGroupFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ViewGroupFlds.* from ViewGroupFlds Left Join {1} on {2} where {3} and ViewGroupFlds.mId not in (Select top {5} ViewGroupFlds.mId from ViewGroupFlds Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1} and mId not in (Select top {2} mId from ViewGroupFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1} and mId not in (Select top {3} mId from ViewGroupFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ViewGroupFlds.* from ViewGroupFlds Left Join {1} on {2} where {3} and ViewGroupFlds.mId not in (Select top {5} ViewGroupFlds.mId from ViewGroupFlds Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1} and mId not in (Select top {2} mId from ViewGroupFlds where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewGroupFlds where {1} and mId not in (Select top {3} mId from ViewGroupFlds where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from ViewGroupFlds a where {0} And a.mId not in (Select Top {2} mId From ViewGroupFlds Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from ViewGroupFlds a where {0} And a.mId not in (Select Top {2} mId From ViewGroupFlds Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from ViewGroupFlds a where {0} And a.mId not in (Select Top {2} mId From ViewGroupFlds Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from ViewGroupFlds a where {0} And a.mId not in (Select Top {2} mId From ViewGroupFlds Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsViewGroupFldsDA: GetViewGroupFldsByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("ViewGroupFlds_SelectByCond",values);
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
public List<clsViewGroupFldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewGroupFldsDA:GetObjLst)", objException.Message));
}
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = TransNullToInt(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = TransNullToInt(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewGroupFldsDA: GetObjLst)", objException.Message));
}
objViewGroupFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewGroupFldsEN);
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
public List<clsViewGroupFldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewGroupFldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = TransNullToInt(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = TransNullToInt(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewGroupFldsDA: GetObjLst)", objException.Message));
}
objViewGroupFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewGroupFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsViewGroupFldsEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsViewGroupFldsDA:GetObjLstBySP)", objException.Message));
}
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("ViewGroupFlds_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = TransNullToInt(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = TransNullToInt(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsViewGroupFldsDA: GetObjLstBySP)", objException.Message));
}
objViewGroupFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewGroupFldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewGroupFlds(ref clsViewGroupFldsEN objViewGroupFldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where mId = " + ""+ objViewGroupFldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewGroupFldsEN.mId = TransNullToInt(objDT.Rows[0][conViewGroupFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewGroupFldsEN.CtlTypeId = objDT.Rows[0][conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objViewGroupFldsEN.DdlItemsOptionId = objDT.Rows[0][conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objViewGroupFldsEN.DsCondStr = objDT.Rows[0][conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objViewGroupFldsEN.Ds_DataTextFieldId = objDT.Rows[0][conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id(字段类型:char,字段长度:8,是否可空:True)
 objViewGroupFldsEN.DsDataValueFieldId = objDT.Rows[0][conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id(字段类型:char,字段长度:8,是否可空:True)
 objViewGroupFldsEN.DsSqlStr = objDT.Rows[0][conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objViewGroupFldsEN.DsTabId = objDT.Rows[0][conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewGroupFldsEN.ItemsString = objDT.Rows[0][conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objViewGroupFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objViewGroupFldsEN.TabFldId = TransNullToInt(objDT.Rows[0][conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID(字段类型:bigint,字段长度:8,是否可空:False)
 objViewGroupFldsEN.UpdDate = objDT.Rows[0][conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewGroupFldsEN.UserId = objDT.Rows[0][conViewGroupFlds.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objViewGroupFldsEN.ViewGroupId = objDT.Rows[0][conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objViewGroupFldsEN.Memo = objDT.Rows[0][conViewGroupFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewGroupFldsDA: GetViewGroupFlds)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewGroupFldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
 objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id(字段类型:char,字段长度:8,是否可空:True)
 objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id(字段类型:char,字段长度:8,是否可空:True)
 objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID(字段类型:bigint,字段长度:8,是否可空:False)
 objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewGroupFldsDA: GetObjBymId)", objException.Message));
}
return objViewGroupFldsEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程ViewGroupFlds_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewGroupFldsOneBySP(clsViewGroupFldsEN objViewGroupFldsEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objViewGroupFldsEN.mId
};
 objDT = objSQL.ExecSpReturnDT("ViewGroupFlds_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objViewGroupFldsEN.mId = TransNullToInt(objDT.Rows[0][conViewGroupFlds.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objViewGroupFldsEN.CtlTypeId = objDT.Rows[0][conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号(字段类型:char,字段长度:2,是否可空:True)
 objViewGroupFldsEN.DdlItemsOptionId = objDT.Rows[0][conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID(字段类型:char,字段长度:2,是否可空:False)
 objViewGroupFldsEN.DsCondStr = objDT.Rows[0][conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串(字段类型:varchar,字段长度:50,是否可空:True)
 objViewGroupFldsEN.Ds_DataTextFieldId = objDT.Rows[0][conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id(字段类型:char,字段长度:8,是否可空:True)
 objViewGroupFldsEN.DsDataValueFieldId = objDT.Rows[0][conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id(字段类型:char,字段长度:8,是否可空:True)
 objViewGroupFldsEN.DsSqlStr = objDT.Rows[0][conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串(字段类型:varchar,字段长度:200,是否可空:True)
 objViewGroupFldsEN.DsTabId = objDT.Rows[0][conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewGroupFldsEN.ItemsString = objDT.Rows[0][conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串(字段类型:varchar,字段长度:200,是否可空:True)
 objViewGroupFldsEN.SeqNum = TransNullToInt(objDT.Rows[0][conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号(字段类型:int,字段长度:4,是否可空:True)
 objViewGroupFldsEN.TabFldId = TransNullToInt(objDT.Rows[0][conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID(字段类型:bigint,字段长度:8,是否可空:False)
 objViewGroupFldsEN.UpdDate = objDT.Rows[0][conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewGroupFldsEN.UserId = objDT.Rows[0][conViewGroupFlds.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objViewGroupFldsEN.ViewGroupId = objDT.Rows[0][conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objViewGroupFldsEN.Memo = objDT.Rows[0][conViewGroupFlds.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewGroupFldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN()
{
mId = TransNullToInt(objRow[conViewGroupFlds.mId].ToString().Trim()), //mId
CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(), //控件类型号
DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(), //下拉框列表选项ID
DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(), //数据源条件串
Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(), //数据源文本字段Id
DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(), //数据源值字段Id
DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(), //数据源SQL串
DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(), //数据源表ID
ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(), //列表项串
SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewGroupFlds.SeqNum].ToString().Trim()), //字段序号
TabFldId = TransNullToInt(objRow[conViewGroupFlds.TabFldId].ToString().Trim()), //表字段ID
UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(), //修改日期
UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(), //用户Id
ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(), //界面组ID
Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim() //说明
};
objViewGroupFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewGroupFldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewGroupFldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewGroupFldsEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsViewGroupFldsDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("ViewGroupFlds_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN()
{
mId = TransNullToInt(objRow[conViewGroupFlds.mId].ToString().Trim()), //mId
CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(), //控件类型号
DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(), //下拉框列表选项ID
DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(), //数据源条件串
Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(), //数据源文本字段Id
DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(), //数据源值字段Id
DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(), //数据源SQL串
DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(), //数据源表ID
ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(), //列表项串
SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewGroupFlds.SeqNum].ToString().Trim()), //字段序号
TabFldId = TransNullToInt(objRow[conViewGroupFlds.TabFldId].ToString().Trim()), //表字段ID
UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(), //修改日期
UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(), //用户Id
ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(), //界面组ID
Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim() //说明
};
objViewGroupFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewGroupFldsEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewGroupFldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = TransNullToInt(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = TransNullToInt(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewGroupFldsDA: GetObjByDataRowViewGroupFlds)", objException.Message));
}
objViewGroupFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewGroupFldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewGroupFldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = TransNullToInt(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = TransNullToInt(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewGroupFldsDA: GetObjByDataRow)", objException.Message));
}
objViewGroupFldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewGroupFldsEN;
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
objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewGroupFldsEN._CurrTabName, conViewGroupFlds.mId, 8, "");
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
objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewGroupFldsEN._CurrTabName, conViewGroupFlds.mId, 8, strPrefix);
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ViewGroupFlds where " + strCondition;
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ViewGroupFlds where " + strCondition;
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewGroupFlds", "mId = " + ""+ lngmId+""))
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("ViewGroupFlds_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewGroupFldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewGroupFlds", strCondition))
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
objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewGroupFlds");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewGroupFldsEN objViewGroupFldsEN)
 {
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewGroupFldsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewGroupFlds");
objRow = objDS.Tables["ViewGroupFlds"].NewRow();
 if (objViewGroupFldsEN.CtlTypeId !=  "")
 {
objRow[conViewGroupFlds.CtlTypeId] = objViewGroupFldsEN.CtlTypeId; //控件类型号
 }
objRow[conViewGroupFlds.DdlItemsOptionId] = objViewGroupFldsEN.DdlItemsOptionId; //下拉框列表选项ID
 if (objViewGroupFldsEN.DsCondStr !=  "")
 {
objRow[conViewGroupFlds.DsCondStr] = objViewGroupFldsEN.DsCondStr; //数据源条件串
 }
 if (objViewGroupFldsEN.Ds_DataTextFieldId !=  "")
 {
objRow[conViewGroupFlds.Ds_DataTextFieldId] = objViewGroupFldsEN.Ds_DataTextFieldId; //数据源文本字段Id
 }
 if (objViewGroupFldsEN.DsDataValueFieldId !=  "")
 {
objRow[conViewGroupFlds.DsDataValueFieldId] = objViewGroupFldsEN.DsDataValueFieldId; //数据源值字段Id
 }
 if (objViewGroupFldsEN.DsSqlStr !=  "")
 {
objRow[conViewGroupFlds.DsSqlStr] = objViewGroupFldsEN.DsSqlStr; //数据源SQL串
 }
objRow[conViewGroupFlds.DsTabId] = objViewGroupFldsEN.DsTabId; //数据源表ID
 if (objViewGroupFldsEN.ItemsString !=  "")
 {
objRow[conViewGroupFlds.ItemsString] = objViewGroupFldsEN.ItemsString; //列表项串
 }
objRow[conViewGroupFlds.SeqNum] = objViewGroupFldsEN.SeqNum; //字段序号
objRow[conViewGroupFlds.TabFldId] = objViewGroupFldsEN.TabFldId; //表字段ID
 if (objViewGroupFldsEN.UpdDate !=  "")
 {
objRow[conViewGroupFlds.UpdDate] = objViewGroupFldsEN.UpdDate; //修改日期
 }
objRow[conViewGroupFlds.UserId] = objViewGroupFldsEN.UserId; //用户Id
objRow[conViewGroupFlds.ViewGroupId] = objViewGroupFldsEN.ViewGroupId; //界面组ID
 if (objViewGroupFldsEN.Memo !=  "")
 {
objRow[conViewGroupFlds.Memo] = objViewGroupFldsEN.Memo; //说明
 }
objDS.Tables[clsViewGroupFldsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewGroupFldsEN._CurrTabName);
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
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewGroupFldsEN objViewGroupFldsEN)
{
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewGroupFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewGroupFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.CtlTypeId);
 objViewGroupFldsEN.CtlTypeId = objViewGroupFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.CtlTypeId + "'");
 }
 
 if (objViewGroupFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DdlItemsOptionId);
 objViewGroupFldsEN.DdlItemsOptionId = objViewGroupFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DdlItemsOptionId + "'");
 }
 
 if (objViewGroupFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsCondStr);
 objViewGroupFldsEN.DsCondStr = objViewGroupFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsCondStr + "'");
 }
 
 if (objViewGroupFldsEN.Ds_DataTextFieldId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.Ds_DataTextFieldId);
 objViewGroupFldsEN.Ds_DataTextFieldId = objViewGroupFldsEN.Ds_DataTextFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.Ds_DataTextFieldId + "'");
 }
 
 if (objViewGroupFldsEN.DsDataValueFieldId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsDataValueFieldId);
 objViewGroupFldsEN.DsDataValueFieldId = objViewGroupFldsEN.DsDataValueFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsDataValueFieldId + "'");
 }
 
 if (objViewGroupFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsSqlStr);
 objViewGroupFldsEN.DsSqlStr = objViewGroupFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsSqlStr + "'");
 }
 
 if (objViewGroupFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsTabId);
 objViewGroupFldsEN.DsTabId = objViewGroupFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsTabId + "'");
 }
 
 if (objViewGroupFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.ItemsString);
 objViewGroupFldsEN.ItemsString = objViewGroupFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.ItemsString + "'");
 }
 
 arrFieldListForInsert.Add(conViewGroupFlds.SeqNum);
 arrValueListForInsert.Add(objViewGroupFldsEN.SeqNum.ToString());
 
 arrFieldListForInsert.Add(conViewGroupFlds.TabFldId);
 arrValueListForInsert.Add(objViewGroupFldsEN.TabFldId.ToString());
 
 if (objViewGroupFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.UpdDate);
 objViewGroupFldsEN.UpdDate = objViewGroupFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.UpdDate + "'");
 }
 
 if (objViewGroupFldsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.UserId);
 objViewGroupFldsEN.UserId = objViewGroupFldsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.UserId + "'");
 }
 
 if (objViewGroupFldsEN.ViewGroupId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.ViewGroupId);
 objViewGroupFldsEN.ViewGroupId = objViewGroupFldsEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.ViewGroupId + "'");
 }
 
 if (objViewGroupFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.Memo);
 objViewGroupFldsEN.Memo = objViewGroupFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewGroupFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewGroupFldsEN objViewGroupFldsEN)
{
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewGroupFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewGroupFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.CtlTypeId);
 objViewGroupFldsEN.CtlTypeId = objViewGroupFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.CtlTypeId + "'");
 }
 
 if (objViewGroupFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DdlItemsOptionId);
 objViewGroupFldsEN.DdlItemsOptionId = objViewGroupFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DdlItemsOptionId + "'");
 }
 
 if (objViewGroupFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsCondStr);
 objViewGroupFldsEN.DsCondStr = objViewGroupFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsCondStr + "'");
 }
 
 if (objViewGroupFldsEN.Ds_DataTextFieldId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.Ds_DataTextFieldId);
 objViewGroupFldsEN.Ds_DataTextFieldId = objViewGroupFldsEN.Ds_DataTextFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.Ds_DataTextFieldId + "'");
 }
 
 if (objViewGroupFldsEN.DsDataValueFieldId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsDataValueFieldId);
 objViewGroupFldsEN.DsDataValueFieldId = objViewGroupFldsEN.DsDataValueFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsDataValueFieldId + "'");
 }
 
 if (objViewGroupFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsSqlStr);
 objViewGroupFldsEN.DsSqlStr = objViewGroupFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsSqlStr + "'");
 }
 
 if (objViewGroupFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsTabId);
 objViewGroupFldsEN.DsTabId = objViewGroupFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsTabId + "'");
 }
 
 if (objViewGroupFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.ItemsString);
 objViewGroupFldsEN.ItemsString = objViewGroupFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.ItemsString + "'");
 }
 
 arrFieldListForInsert.Add(conViewGroupFlds.SeqNum);
 arrValueListForInsert.Add(objViewGroupFldsEN.SeqNum.ToString());
 
 arrFieldListForInsert.Add(conViewGroupFlds.TabFldId);
 arrValueListForInsert.Add(objViewGroupFldsEN.TabFldId.ToString());
 
 if (objViewGroupFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.UpdDate);
 objViewGroupFldsEN.UpdDate = objViewGroupFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.UpdDate + "'");
 }
 
 if (objViewGroupFldsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.UserId);
 objViewGroupFldsEN.UserId = objViewGroupFldsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.UserId + "'");
 }
 
 if (objViewGroupFldsEN.ViewGroupId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.ViewGroupId);
 objViewGroupFldsEN.ViewGroupId = objViewGroupFldsEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.ViewGroupId + "'");
 }
 
 if (objViewGroupFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.Memo);
 objViewGroupFldsEN.Memo = objViewGroupFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewGroupFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewGroupFldsEN objViewGroupFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewGroupFldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewGroupFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.CtlTypeId);
 objViewGroupFldsEN.CtlTypeId = objViewGroupFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.CtlTypeId + "'");
 }
 
 if (objViewGroupFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DdlItemsOptionId);
 objViewGroupFldsEN.DdlItemsOptionId = objViewGroupFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DdlItemsOptionId + "'");
 }
 
 if (objViewGroupFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsCondStr);
 objViewGroupFldsEN.DsCondStr = objViewGroupFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsCondStr + "'");
 }
 
 if (objViewGroupFldsEN.Ds_DataTextFieldId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.Ds_DataTextFieldId);
 objViewGroupFldsEN.Ds_DataTextFieldId = objViewGroupFldsEN.Ds_DataTextFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.Ds_DataTextFieldId + "'");
 }
 
 if (objViewGroupFldsEN.DsDataValueFieldId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsDataValueFieldId);
 objViewGroupFldsEN.DsDataValueFieldId = objViewGroupFldsEN.DsDataValueFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsDataValueFieldId + "'");
 }
 
 if (objViewGroupFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsSqlStr);
 objViewGroupFldsEN.DsSqlStr = objViewGroupFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsSqlStr + "'");
 }
 
 if (objViewGroupFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsTabId);
 objViewGroupFldsEN.DsTabId = objViewGroupFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsTabId + "'");
 }
 
 if (objViewGroupFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.ItemsString);
 objViewGroupFldsEN.ItemsString = objViewGroupFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.ItemsString + "'");
 }
 
 arrFieldListForInsert.Add(conViewGroupFlds.SeqNum);
 arrValueListForInsert.Add(objViewGroupFldsEN.SeqNum.ToString());
 
 arrFieldListForInsert.Add(conViewGroupFlds.TabFldId);
 arrValueListForInsert.Add(objViewGroupFldsEN.TabFldId.ToString());
 
 if (objViewGroupFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.UpdDate);
 objViewGroupFldsEN.UpdDate = objViewGroupFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.UpdDate + "'");
 }
 
 if (objViewGroupFldsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.UserId);
 objViewGroupFldsEN.UserId = objViewGroupFldsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.UserId + "'");
 }
 
 if (objViewGroupFldsEN.ViewGroupId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.ViewGroupId);
 objViewGroupFldsEN.ViewGroupId = objViewGroupFldsEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.ViewGroupId + "'");
 }
 
 if (objViewGroupFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.Memo);
 objViewGroupFldsEN.Memo = objViewGroupFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewGroupFlds");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewGroupFldsEN objViewGroupFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewGroupFldsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objViewGroupFldsEN.CtlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.CtlTypeId);
 objViewGroupFldsEN.CtlTypeId = objViewGroupFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.CtlTypeId + "'");
 }
 
 if (objViewGroupFldsEN.DdlItemsOptionId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DdlItemsOptionId);
 objViewGroupFldsEN.DdlItemsOptionId = objViewGroupFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DdlItemsOptionId + "'");
 }
 
 if (objViewGroupFldsEN.DsCondStr !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsCondStr);
 objViewGroupFldsEN.DsCondStr = objViewGroupFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsCondStr + "'");
 }
 
 if (objViewGroupFldsEN.Ds_DataTextFieldId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.Ds_DataTextFieldId);
 objViewGroupFldsEN.Ds_DataTextFieldId = objViewGroupFldsEN.Ds_DataTextFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.Ds_DataTextFieldId + "'");
 }
 
 if (objViewGroupFldsEN.DsDataValueFieldId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsDataValueFieldId);
 objViewGroupFldsEN.DsDataValueFieldId = objViewGroupFldsEN.DsDataValueFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsDataValueFieldId + "'");
 }
 
 if (objViewGroupFldsEN.DsSqlStr !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsSqlStr);
 objViewGroupFldsEN.DsSqlStr = objViewGroupFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsSqlStr + "'");
 }
 
 if (objViewGroupFldsEN.DsTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.DsTabId);
 objViewGroupFldsEN.DsTabId = objViewGroupFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.DsTabId + "'");
 }
 
 if (objViewGroupFldsEN.ItemsString !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.ItemsString);
 objViewGroupFldsEN.ItemsString = objViewGroupFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.ItemsString + "'");
 }
 
 arrFieldListForInsert.Add(conViewGroupFlds.SeqNum);
 arrValueListForInsert.Add(objViewGroupFldsEN.SeqNum.ToString());
 
 arrFieldListForInsert.Add(conViewGroupFlds.TabFldId);
 arrValueListForInsert.Add(objViewGroupFldsEN.TabFldId.ToString());
 
 if (objViewGroupFldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.UpdDate);
 objViewGroupFldsEN.UpdDate = objViewGroupFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.UpdDate + "'");
 }
 
 if (objViewGroupFldsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.UserId);
 objViewGroupFldsEN.UserId = objViewGroupFldsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.UserId + "'");
 }
 
 if (objViewGroupFldsEN.ViewGroupId !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.ViewGroupId);
 objViewGroupFldsEN.ViewGroupId = objViewGroupFldsEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.ViewGroupId + "'");
 }
 
 if (objViewGroupFldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewGroupFlds.Memo);
 objViewGroupFldsEN.Memo = objViewGroupFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objViewGroupFldsEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewGroupFlds");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewViewGroupFldsBySP(clsViewGroupFldsEN objViewGroupFldsEN)
{
//通过存储过程来
//直接使用
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objViewGroupFldsEN.CtlTypeId,
 objViewGroupFldsEN.DdlItemsOptionId,
 objViewGroupFldsEN.DsCondStr,
 objViewGroupFldsEN.Ds_DataTextFieldId,
 objViewGroupFldsEN.DsDataValueFieldId,
 objViewGroupFldsEN.DsSqlStr,
 objViewGroupFldsEN.DsTabId,
 objViewGroupFldsEN.ItemsString,
 objViewGroupFldsEN.SeqNum,
 objViewGroupFldsEN.TabFldId,
 objViewGroupFldsEN.UpdDate,
 objViewGroupFldsEN.UserId,
 objViewGroupFldsEN.ViewGroupId,
objViewGroupFldsEN.Memo
};
 objSQL.ExecSP("ViewGroupFlds_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewGroupFldss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewGroupFlds");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conViewGroupFlds.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewGroupFldsEN._CurrTabName ].NewRow();
objRow[conViewGroupFlds.CtlTypeId] = oRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objRow[conViewGroupFlds.DdlItemsOptionId] = oRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objRow[conViewGroupFlds.DsCondStr] = oRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objRow[conViewGroupFlds.Ds_DataTextFieldId] = oRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objRow[conViewGroupFlds.DsDataValueFieldId] = oRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objRow[conViewGroupFlds.DsSqlStr] = oRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objRow[conViewGroupFlds.DsTabId] = oRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objRow[conViewGroupFlds.ItemsString] = oRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objRow[conViewGroupFlds.SeqNum] = oRow[conViewGroupFlds.SeqNum].ToString().Trim(); //字段序号
objRow[conViewGroupFlds.TabFldId] = oRow[conViewGroupFlds.TabFldId].ToString().Trim(); //表字段ID
objRow[conViewGroupFlds.UpdDate] = oRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objRow[conViewGroupFlds.UserId] = oRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objRow[conViewGroupFlds.ViewGroupId] = oRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objRow[conViewGroupFlds.Memo] = oRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
 objDS.Tables[clsViewGroupFldsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewGroupFldsEN._CurrTabName);
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
 /// <param name = "objViewGroupFldsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewGroupFldsEN objViewGroupFldsEN)
{
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupFldsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
strSQL = "Select * from ViewGroupFlds where mId = " + ""+ objViewGroupFldsEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewGroupFldsEN._CurrTabName);
if (objDS.Tables[clsViewGroupFldsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objViewGroupFldsEN.mId+"");
return false;
}
objRow = objDS.Tables[clsViewGroupFldsEN._CurrTabName].Rows[0];
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.CtlTypeId))
 {
objRow[conViewGroupFlds.CtlTypeId] = objViewGroupFldsEN.CtlTypeId; //控件类型号
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DdlItemsOptionId))
 {
objRow[conViewGroupFlds.DdlItemsOptionId] = objViewGroupFldsEN.DdlItemsOptionId; //下拉框列表选项ID
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsCondStr))
 {
objRow[conViewGroupFlds.DsCondStr] = objViewGroupFldsEN.DsCondStr; //数据源条件串
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.Ds_DataTextFieldId))
 {
objRow[conViewGroupFlds.Ds_DataTextFieldId] = objViewGroupFldsEN.Ds_DataTextFieldId; //数据源文本字段Id
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsDataValueFieldId))
 {
objRow[conViewGroupFlds.DsDataValueFieldId] = objViewGroupFldsEN.DsDataValueFieldId; //数据源值字段Id
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsSqlStr))
 {
objRow[conViewGroupFlds.DsSqlStr] = objViewGroupFldsEN.DsSqlStr; //数据源SQL串
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsTabId))
 {
objRow[conViewGroupFlds.DsTabId] = objViewGroupFldsEN.DsTabId; //数据源表ID
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.ItemsString))
 {
objRow[conViewGroupFlds.ItemsString] = objViewGroupFldsEN.ItemsString; //列表项串
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.SeqNum))
 {
objRow[conViewGroupFlds.SeqNum] = objViewGroupFldsEN.SeqNum; //字段序号
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.TabFldId))
 {
objRow[conViewGroupFlds.TabFldId] = objViewGroupFldsEN.TabFldId; //表字段ID
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.UpdDate))
 {
objRow[conViewGroupFlds.UpdDate] = objViewGroupFldsEN.UpdDate; //修改日期
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.UserId))
 {
objRow[conViewGroupFlds.UserId] = objViewGroupFldsEN.UserId; //用户Id
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.ViewGroupId))
 {
objRow[conViewGroupFlds.ViewGroupId] = objViewGroupFldsEN.ViewGroupId; //界面组ID
 }
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.Memo))
 {
objRow[conViewGroupFlds.Memo] = objViewGroupFldsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsViewGroupFldsEN._CurrTabName);
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
public bool UpdateBySP(clsViewGroupFldsEN objViewGroupFldsEN)
{
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupFldsEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objViewGroupFldsEN.mId,
 objViewGroupFldsEN.CtlTypeId,
 objViewGroupFldsEN.DdlItemsOptionId,
 objViewGroupFldsEN.DsCondStr,
 objViewGroupFldsEN.Ds_DataTextFieldId,
 objViewGroupFldsEN.DsDataValueFieldId,
 objViewGroupFldsEN.DsSqlStr,
 objViewGroupFldsEN.DsTabId,
 objViewGroupFldsEN.ItemsString,
 objViewGroupFldsEN.SeqNum,
 objViewGroupFldsEN.TabFldId,
 objViewGroupFldsEN.UpdDate,
 objViewGroupFldsEN.UserId,
 objViewGroupFldsEN.ViewGroupId,
 objViewGroupFldsEN.Memo
};
 objSQL.ExecSP("ViewGroupFlds_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewGroupFldsEN objViewGroupFldsEN)
{
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewGroupFlds Set ");
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.CtlTypeId))
 {
 if (objViewGroupFldsEN.CtlTypeId !=  null)
 {
 objViewGroupFldsEN.CtlTypeId = objViewGroupFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.CtlTypeId, conViewGroupFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DdlItemsOptionId))
 {
 if (objViewGroupFldsEN.DdlItemsOptionId !=  null)
 {
 objViewGroupFldsEN.DdlItemsOptionId = objViewGroupFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.DdlItemsOptionId, conViewGroupFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsCondStr))
 {
 if (objViewGroupFldsEN.DsCondStr !=  null)
 {
 objViewGroupFldsEN.DsCondStr = objViewGroupFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.DsCondStr, conViewGroupFlds.DsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.DsCondStr); //数据源条件串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.Ds_DataTextFieldId))
 {
 if (objViewGroupFldsEN.Ds_DataTextFieldId !=  null)
 {
 objViewGroupFldsEN.Ds_DataTextFieldId = objViewGroupFldsEN.Ds_DataTextFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.Ds_DataTextFieldId, conViewGroupFlds.Ds_DataTextFieldId); //数据源文本字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.Ds_DataTextFieldId); //数据源文本字段Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsDataValueFieldId))
 {
 if (objViewGroupFldsEN.DsDataValueFieldId !=  null)
 {
 objViewGroupFldsEN.DsDataValueFieldId = objViewGroupFldsEN.DsDataValueFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.DsDataValueFieldId, conViewGroupFlds.DsDataValueFieldId); //数据源值字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.DsDataValueFieldId); //数据源值字段Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsSqlStr))
 {
 if (objViewGroupFldsEN.DsSqlStr !=  null)
 {
 objViewGroupFldsEN.DsSqlStr = objViewGroupFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.DsSqlStr, conViewGroupFlds.DsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.DsSqlStr); //数据源SQL串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsTabId))
 {
 if (objViewGroupFldsEN.DsTabId !=  null)
 {
 objViewGroupFldsEN.DsTabId = objViewGroupFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.DsTabId, conViewGroupFlds.DsTabId); //数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.DsTabId); //数据源表ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.ItemsString))
 {
 if (objViewGroupFldsEN.ItemsString !=  null)
 {
 objViewGroupFldsEN.ItemsString = objViewGroupFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.ItemsString, conViewGroupFlds.ItemsString); //列表项串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.ItemsString); //列表项串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.SeqNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objViewGroupFldsEN.SeqNum, conViewGroupFlds.SeqNum); //字段序号
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.TabFldId))
 {
 sbSQL.AppendFormat("{1} = {0},",objViewGroupFldsEN.TabFldId, conViewGroupFlds.TabFldId); //表字段ID
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.UpdDate))
 {
 if (objViewGroupFldsEN.UpdDate !=  null)
 {
 objViewGroupFldsEN.UpdDate = objViewGroupFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.UpdDate, conViewGroupFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.UpdDate); //修改日期
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.UserId))
 {
 if (objViewGroupFldsEN.UserId !=  null)
 {
 objViewGroupFldsEN.UserId = objViewGroupFldsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.UserId, conViewGroupFlds.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.UserId); //用户Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.ViewGroupId))
 {
 if (objViewGroupFldsEN.ViewGroupId !=  null)
 {
 objViewGroupFldsEN.ViewGroupId = objViewGroupFldsEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.ViewGroupId, conViewGroupFlds.ViewGroupId); //界面组ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.ViewGroupId); //界面组ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.Memo))
 {
 if (objViewGroupFldsEN.Memo !=  null)
 {
 objViewGroupFldsEN.Memo = objViewGroupFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.Memo, conViewGroupFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objViewGroupFldsEN.mId); 
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
 /// <param name = "objViewGroupFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewGroupFldsEN objViewGroupFldsEN, string strCondition)
{
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewGroupFlds Set ");
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.CtlTypeId))
 {
 if (objViewGroupFldsEN.CtlTypeId !=  null)
 {
 objViewGroupFldsEN.CtlTypeId = objViewGroupFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", objViewGroupFldsEN.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DdlItemsOptionId))
 {
 if (objViewGroupFldsEN.DdlItemsOptionId !=  null)
 {
 objViewGroupFldsEN.DdlItemsOptionId = objViewGroupFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DdlItemsOptionId = '{0}',", objViewGroupFldsEN.DdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.Append(" DdlItemsOptionId = null,"); //下拉框列表选项ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsCondStr))
 {
 if (objViewGroupFldsEN.DsCondStr !=  null)
 {
 objViewGroupFldsEN.DsCondStr = objViewGroupFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsCondStr = '{0}',", objViewGroupFldsEN.DsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.Append(" DsCondStr = null,"); //数据源条件串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.Ds_DataTextFieldId))
 {
 if (objViewGroupFldsEN.Ds_DataTextFieldId !=  null)
 {
 objViewGroupFldsEN.Ds_DataTextFieldId = objViewGroupFldsEN.Ds_DataTextFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Ds_DataTextFieldId = '{0}',", objViewGroupFldsEN.Ds_DataTextFieldId); //数据源文本字段Id
 }
 else
 {
 sbSQL.Append(" Ds_DataTextFieldId = null,"); //数据源文本字段Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsDataValueFieldId))
 {
 if (objViewGroupFldsEN.DsDataValueFieldId !=  null)
 {
 objViewGroupFldsEN.DsDataValueFieldId = objViewGroupFldsEN.DsDataValueFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsDataValueFieldId = '{0}',", objViewGroupFldsEN.DsDataValueFieldId); //数据源值字段Id
 }
 else
 {
 sbSQL.Append(" DsDataValueFieldId = null,"); //数据源值字段Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsSqlStr))
 {
 if (objViewGroupFldsEN.DsSqlStr !=  null)
 {
 objViewGroupFldsEN.DsSqlStr = objViewGroupFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsSqlStr = '{0}',", objViewGroupFldsEN.DsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.Append(" DsSqlStr = null,"); //数据源SQL串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsTabId))
 {
 if (objViewGroupFldsEN.DsTabId !=  null)
 {
 objViewGroupFldsEN.DsTabId = objViewGroupFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsTabId = '{0}',", objViewGroupFldsEN.DsTabId); //数据源表ID
 }
 else
 {
 sbSQL.Append(" DsTabId = null,"); //数据源表ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.ItemsString))
 {
 if (objViewGroupFldsEN.ItemsString !=  null)
 {
 objViewGroupFldsEN.ItemsString = objViewGroupFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ItemsString = '{0}',", objViewGroupFldsEN.ItemsString); //列表项串
 }
 else
 {
 sbSQL.Append(" ItemsString = null,"); //列表项串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.SeqNum))
 {
 sbSQL.AppendFormat(" SeqNum = {0},", objViewGroupFldsEN.SeqNum); //字段序号
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.TabFldId))
 {
 sbSQL.AppendFormat(" TabFldId = {0},", objViewGroupFldsEN.TabFldId); //表字段ID
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.UpdDate))
 {
 if (objViewGroupFldsEN.UpdDate !=  null)
 {
 objViewGroupFldsEN.UpdDate = objViewGroupFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objViewGroupFldsEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.UserId))
 {
 if (objViewGroupFldsEN.UserId !=  null)
 {
 objViewGroupFldsEN.UserId = objViewGroupFldsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", objViewGroupFldsEN.UserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.ViewGroupId))
 {
 if (objViewGroupFldsEN.ViewGroupId !=  null)
 {
 objViewGroupFldsEN.ViewGroupId = objViewGroupFldsEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewGroupId = '{0}',", objViewGroupFldsEN.ViewGroupId); //界面组ID
 }
 else
 {
 sbSQL.Append(" ViewGroupId = null,"); //界面组ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.Memo))
 {
 if (objViewGroupFldsEN.Memo !=  null)
 {
 objViewGroupFldsEN.Memo = objViewGroupFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objViewGroupFldsEN.Memo); //说明
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
 /// <param name = "objViewGroupFldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewGroupFldsEN objViewGroupFldsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewGroupFlds Set ");
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.CtlTypeId))
 {
 if (objViewGroupFldsEN.CtlTypeId !=  null)
 {
 objViewGroupFldsEN.CtlTypeId = objViewGroupFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CtlTypeId = '{0}',", objViewGroupFldsEN.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.Append(" CtlTypeId = null,"); //控件类型号
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DdlItemsOptionId))
 {
 if (objViewGroupFldsEN.DdlItemsOptionId !=  null)
 {
 objViewGroupFldsEN.DdlItemsOptionId = objViewGroupFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DdlItemsOptionId = '{0}',", objViewGroupFldsEN.DdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.Append(" DdlItemsOptionId = null,"); //下拉框列表选项ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsCondStr))
 {
 if (objViewGroupFldsEN.DsCondStr !=  null)
 {
 objViewGroupFldsEN.DsCondStr = objViewGroupFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsCondStr = '{0}',", objViewGroupFldsEN.DsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.Append(" DsCondStr = null,"); //数据源条件串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.Ds_DataTextFieldId))
 {
 if (objViewGroupFldsEN.Ds_DataTextFieldId !=  null)
 {
 objViewGroupFldsEN.Ds_DataTextFieldId = objViewGroupFldsEN.Ds_DataTextFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Ds_DataTextFieldId = '{0}',", objViewGroupFldsEN.Ds_DataTextFieldId); //数据源文本字段Id
 }
 else
 {
 sbSQL.Append(" Ds_DataTextFieldId = null,"); //数据源文本字段Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsDataValueFieldId))
 {
 if (objViewGroupFldsEN.DsDataValueFieldId !=  null)
 {
 objViewGroupFldsEN.DsDataValueFieldId = objViewGroupFldsEN.DsDataValueFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsDataValueFieldId = '{0}',", objViewGroupFldsEN.DsDataValueFieldId); //数据源值字段Id
 }
 else
 {
 sbSQL.Append(" DsDataValueFieldId = null,"); //数据源值字段Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsSqlStr))
 {
 if (objViewGroupFldsEN.DsSqlStr !=  null)
 {
 objViewGroupFldsEN.DsSqlStr = objViewGroupFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsSqlStr = '{0}',", objViewGroupFldsEN.DsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.Append(" DsSqlStr = null,"); //数据源SQL串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsTabId))
 {
 if (objViewGroupFldsEN.DsTabId !=  null)
 {
 objViewGroupFldsEN.DsTabId = objViewGroupFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DsTabId = '{0}',", objViewGroupFldsEN.DsTabId); //数据源表ID
 }
 else
 {
 sbSQL.Append(" DsTabId = null,"); //数据源表ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.ItemsString))
 {
 if (objViewGroupFldsEN.ItemsString !=  null)
 {
 objViewGroupFldsEN.ItemsString = objViewGroupFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ItemsString = '{0}',", objViewGroupFldsEN.ItemsString); //列表项串
 }
 else
 {
 sbSQL.Append(" ItemsString = null,"); //列表项串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.SeqNum))
 {
 sbSQL.AppendFormat(" SeqNum = {0},", objViewGroupFldsEN.SeqNum); //字段序号
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.TabFldId))
 {
 sbSQL.AppendFormat(" TabFldId = {0},", objViewGroupFldsEN.TabFldId); //表字段ID
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.UpdDate))
 {
 if (objViewGroupFldsEN.UpdDate !=  null)
 {
 objViewGroupFldsEN.UpdDate = objViewGroupFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objViewGroupFldsEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.UserId))
 {
 if (objViewGroupFldsEN.UserId !=  null)
 {
 objViewGroupFldsEN.UserId = objViewGroupFldsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", objViewGroupFldsEN.UserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.ViewGroupId))
 {
 if (objViewGroupFldsEN.ViewGroupId !=  null)
 {
 objViewGroupFldsEN.ViewGroupId = objViewGroupFldsEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewGroupId = '{0}',", objViewGroupFldsEN.ViewGroupId); //界面组ID
 }
 else
 {
 sbSQL.Append(" ViewGroupId = null,"); //界面组ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.Memo))
 {
 if (objViewGroupFldsEN.Memo !=  null)
 {
 objViewGroupFldsEN.Memo = objViewGroupFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objViewGroupFldsEN.Memo); //说明
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
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewGroupFldsEN objViewGroupFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewGroupFldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewGroupFldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewGroupFlds Set ");
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.CtlTypeId))
 {
 if (objViewGroupFldsEN.CtlTypeId !=  null)
 {
 objViewGroupFldsEN.CtlTypeId = objViewGroupFldsEN.CtlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.CtlTypeId, conViewGroupFlds.CtlTypeId); //控件类型号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.CtlTypeId); //控件类型号
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DdlItemsOptionId))
 {
 if (objViewGroupFldsEN.DdlItemsOptionId !=  null)
 {
 objViewGroupFldsEN.DdlItemsOptionId = objViewGroupFldsEN.DdlItemsOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.DdlItemsOptionId, conViewGroupFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.DdlItemsOptionId); //下拉框列表选项ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsCondStr))
 {
 if (objViewGroupFldsEN.DsCondStr !=  null)
 {
 objViewGroupFldsEN.DsCondStr = objViewGroupFldsEN.DsCondStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.DsCondStr, conViewGroupFlds.DsCondStr); //数据源条件串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.DsCondStr); //数据源条件串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.Ds_DataTextFieldId))
 {
 if (objViewGroupFldsEN.Ds_DataTextFieldId !=  null)
 {
 objViewGroupFldsEN.Ds_DataTextFieldId = objViewGroupFldsEN.Ds_DataTextFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.Ds_DataTextFieldId, conViewGroupFlds.Ds_DataTextFieldId); //数据源文本字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.Ds_DataTextFieldId); //数据源文本字段Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsDataValueFieldId))
 {
 if (objViewGroupFldsEN.DsDataValueFieldId !=  null)
 {
 objViewGroupFldsEN.DsDataValueFieldId = objViewGroupFldsEN.DsDataValueFieldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.DsDataValueFieldId, conViewGroupFlds.DsDataValueFieldId); //数据源值字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.DsDataValueFieldId); //数据源值字段Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsSqlStr))
 {
 if (objViewGroupFldsEN.DsSqlStr !=  null)
 {
 objViewGroupFldsEN.DsSqlStr = objViewGroupFldsEN.DsSqlStr.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.DsSqlStr, conViewGroupFlds.DsSqlStr); //数据源SQL串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.DsSqlStr); //数据源SQL串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.DsTabId))
 {
 if (objViewGroupFldsEN.DsTabId !=  null)
 {
 objViewGroupFldsEN.DsTabId = objViewGroupFldsEN.DsTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.DsTabId, conViewGroupFlds.DsTabId); //数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.DsTabId); //数据源表ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.ItemsString))
 {
 if (objViewGroupFldsEN.ItemsString !=  null)
 {
 objViewGroupFldsEN.ItemsString = objViewGroupFldsEN.ItemsString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.ItemsString, conViewGroupFlds.ItemsString); //列表项串
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.ItemsString); //列表项串
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.SeqNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objViewGroupFldsEN.SeqNum, conViewGroupFlds.SeqNum); //字段序号
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.TabFldId))
 {
 sbSQL.AppendFormat("{1} = {0},",objViewGroupFldsEN.TabFldId, conViewGroupFlds.TabFldId); //表字段ID
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.UpdDate))
 {
 if (objViewGroupFldsEN.UpdDate !=  null)
 {
 objViewGroupFldsEN.UpdDate = objViewGroupFldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.UpdDate, conViewGroupFlds.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.UpdDate); //修改日期
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.UserId))
 {
 if (objViewGroupFldsEN.UserId !=  null)
 {
 objViewGroupFldsEN.UserId = objViewGroupFldsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.UserId, conViewGroupFlds.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.UserId); //用户Id
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.ViewGroupId))
 {
 if (objViewGroupFldsEN.ViewGroupId !=  null)
 {
 objViewGroupFldsEN.ViewGroupId = objViewGroupFldsEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.ViewGroupId, conViewGroupFlds.ViewGroupId); //界面组ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.ViewGroupId); //界面组ID
 }
 }
 
 if (objViewGroupFldsEN.IsUpdated(conViewGroupFlds.Memo))
 {
 if (objViewGroupFldsEN.Memo !=  null)
 {
 objViewGroupFldsEN.Memo = objViewGroupFldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objViewGroupFldsEN.Memo, conViewGroupFlds.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewGroupFlds.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objViewGroupFldsEN.mId); 
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ViewGroupFlds_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
//删除ViewGroupFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewGroupFlds where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewGroupFlds(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
//删除ViewGroupFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewGroupFlds where mId in (" + strKeyList + ")";
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
//删除ViewGroupFlds本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewGroupFlds where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewGroupFlds(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: DelViewGroupFlds)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewGroupFlds where " + strCondition ;
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
public bool DelViewGroupFldsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewGroupFldsDA: DelViewGroupFldsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewGroupFlds where " + strCondition ;
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
 /// <param name = "objViewGroupFldsENS">源对象</param>
 /// <param name = "objViewGroupFldsENT">目标对象</param>
public void CopyTo(clsViewGroupFldsEN objViewGroupFldsENS, clsViewGroupFldsEN objViewGroupFldsENT)
{
objViewGroupFldsENT.mId = objViewGroupFldsENS.mId; //mId
objViewGroupFldsENT.CtlTypeId = objViewGroupFldsENS.CtlTypeId; //控件类型号
objViewGroupFldsENT.DdlItemsOptionId = objViewGroupFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objViewGroupFldsENT.DsCondStr = objViewGroupFldsENS.DsCondStr; //数据源条件串
objViewGroupFldsENT.Ds_DataTextFieldId = objViewGroupFldsENS.Ds_DataTextFieldId; //数据源文本字段Id
objViewGroupFldsENT.DsDataValueFieldId = objViewGroupFldsENS.DsDataValueFieldId; //数据源值字段Id
objViewGroupFldsENT.DsSqlStr = objViewGroupFldsENS.DsSqlStr; //数据源SQL串
objViewGroupFldsENT.DsTabId = objViewGroupFldsENS.DsTabId; //数据源表ID
objViewGroupFldsENT.ItemsString = objViewGroupFldsENS.ItemsString; //列表项串
objViewGroupFldsENT.SeqNum = objViewGroupFldsENS.SeqNum; //字段序号
objViewGroupFldsENT.TabFldId = objViewGroupFldsENS.TabFldId; //表字段ID
objViewGroupFldsENT.UpdDate = objViewGroupFldsENS.UpdDate; //修改日期
objViewGroupFldsENT.UserId = objViewGroupFldsENS.UserId; //用户Id
objViewGroupFldsENT.ViewGroupId = objViewGroupFldsENS.ViewGroupId; //界面组ID
objViewGroupFldsENT.Memo = objViewGroupFldsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewGroupFldsEN objViewGroupFldsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewGroupFldsEN.DdlItemsOptionId, conViewGroupFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldNotNull(objViewGroupFldsEN.DsTabId, conViewGroupFlds.DsTabId);
clsCheckSql.CheckFieldNotNull(objViewGroupFldsEN.TabFldId, conViewGroupFlds.TabFldId);
clsCheckSql.CheckFieldNotNull(objViewGroupFldsEN.UserId, conViewGroupFlds.UserId);
clsCheckSql.CheckFieldNotNull(objViewGroupFldsEN.ViewGroupId, conViewGroupFlds.ViewGroupId);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.CtlTypeId, 2, conViewGroupFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DdlItemsOptionId, 2, conViewGroupFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsCondStr, 50, conViewGroupFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.Ds_DataTextFieldId, 8, conViewGroupFlds.Ds_DataTextFieldId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsDataValueFieldId, 8, conViewGroupFlds.DsDataValueFieldId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsSqlStr, 200, conViewGroupFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsTabId, 8, conViewGroupFlds.DsTabId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.ItemsString, 200, conViewGroupFlds.ItemsString);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.UpdDate, 20, conViewGroupFlds.UpdDate);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.UserId, 18, conViewGroupFlds.UserId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.ViewGroupId, 8, conViewGroupFlds.ViewGroupId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.Memo, 1000, conViewGroupFlds.Memo);
//检查字段外键固定长度
 objViewGroupFldsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewGroupFldsEN objViewGroupFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.CtlTypeId, 2, conViewGroupFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DdlItemsOptionId, 2, conViewGroupFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsCondStr, 50, conViewGroupFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.Ds_DataTextFieldId, 8, conViewGroupFlds.Ds_DataTextFieldId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsDataValueFieldId, 8, conViewGroupFlds.DsDataValueFieldId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsSqlStr, 200, conViewGroupFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsTabId, 8, conViewGroupFlds.DsTabId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.ItemsString, 200, conViewGroupFlds.ItemsString);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.UpdDate, 20, conViewGroupFlds.UpdDate);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.UserId, 18, conViewGroupFlds.UserId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.ViewGroupId, 8, conViewGroupFlds.ViewGroupId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.Memo, 1000, conViewGroupFlds.Memo);
//检查外键字段长度
 objViewGroupFldsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewGroupFldsEN objViewGroupFldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.CtlTypeId, 2, conViewGroupFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DdlItemsOptionId, 2, conViewGroupFlds.DdlItemsOptionId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsCondStr, 50, conViewGroupFlds.DsCondStr);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.Ds_DataTextFieldId, 8, conViewGroupFlds.Ds_DataTextFieldId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsDataValueFieldId, 8, conViewGroupFlds.DsDataValueFieldId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsSqlStr, 200, conViewGroupFlds.DsSqlStr);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.DsTabId, 8, conViewGroupFlds.DsTabId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.ItemsString, 200, conViewGroupFlds.ItemsString);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.UpdDate, 20, conViewGroupFlds.UpdDate);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.UserId, 18, conViewGroupFlds.UserId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.ViewGroupId, 8, conViewGroupFlds.ViewGroupId);
clsCheckSql.CheckFieldLen(objViewGroupFldsEN.Memo, 1000, conViewGroupFlds.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.CtlTypeId, conViewGroupFlds.CtlTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.DdlItemsOptionId, conViewGroupFlds.DdlItemsOptionId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.DsCondStr, conViewGroupFlds.DsCondStr);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.Ds_DataTextFieldId, conViewGroupFlds.Ds_DataTextFieldId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.DsDataValueFieldId, conViewGroupFlds.DsDataValueFieldId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.DsSqlStr, conViewGroupFlds.DsSqlStr);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.DsTabId, conViewGroupFlds.DsTabId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.ItemsString, conViewGroupFlds.ItemsString);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.UpdDate, conViewGroupFlds.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.UserId, conViewGroupFlds.UserId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.ViewGroupId, conViewGroupFlds.ViewGroupId);
clsCheckSql.CheckSqlInjection4Field(objViewGroupFldsEN.Memo, conViewGroupFlds.Memo);
//检查外键字段长度
 objViewGroupFldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewGroupFlds(界面组字段集合),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStrTabFldId_ViewGroupId(clsViewGroupFldsEN objViewGroupFldsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabFldId = '{0}'", objViewGroupFldsEN.TabFldId);
 sbCondition.AppendFormat(" and ViewGroupId = '{0}'", objViewGroupFldsEN.ViewGroupId);
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewGroupFldsEN._CurrTabName);
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewGroupFldsEN._CurrTabName, strCondition);
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
 objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}