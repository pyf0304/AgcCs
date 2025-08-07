
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFileResourceDA
 表名:vFileResource(00050540)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:36
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:资源管理(ResourceMan)
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
 /// v文件资源(vFileResource)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsvFileResourceDA : clsCommBase4DA
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
 return clsvFileResourceEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFileResourceEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFileResourceEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFileResourceEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFileResourceEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 strSQL = "Select * from vFileResource where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vFileResource");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vFileResource_SelectByCond",values, "vFileResource");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFileResource where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vFileResource");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vFileResource a where {0} And a.FileResourceID not in (Select Top {2} FileResourceID From vFileResource Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vFileResource");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vFileResource a where {0} And a.FileResourceID not in (Select Top {2} FileResourceID From vFileResource Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vFileResource");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vFileResource a where {0} And a.FileResourceID not in (Select Top {2} FileResourceID From vFileResource Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vFileResource");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFileResource(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable_vFileResource)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFileResource where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFileResource where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFileResource.* from vFileResource Left Join {1} on {2} where {3} and vFileResource.FileResourceID not in (Select top {5} vFileResource.FileResourceID from vFileResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} and FileResourceID not in (Select top {2} FileResourceID from vFileResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} and FileResourceID not in (Select top {3} FileResourceID from vFileResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFileResource.* from vFileResource Left Join {1} on {2} where {3} and vFileResource.FileResourceID not in (Select top {5} vFileResource.FileResourceID from vFileResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} and FileResourceID not in (Select top {2} FileResourceID from vFileResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} and FileResourceID not in (Select top {3} FileResourceID from vFileResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFileResource.* from vFileResource Left Join {1} on {2} where {3} and vFileResource.FileResourceID not in (Select top {5} vFileResource.FileResourceID from vFileResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} and FileResourceID not in (Select top {2} FileResourceID from vFileResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} and FileResourceID not in (Select top {3} FileResourceID from vFileResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vFileResource a where {0} And a.FileResourceID not in (Select Top {2} FileResourceID From vFileResource Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vFileResource a where {0} And a.FileResourceID not in (Select Top {2} FileResourceID From vFileResource Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vFileResource a where {0} And a.FileResourceID not in (Select Top {2} FileResourceID From vFileResource Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vFileResource a where {0} And a.FileResourceID not in (Select Top {2} FileResourceID From vFileResource Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvFileResourceDA: GetvFileResourceByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vFileResource_SelectByCond",values);
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
public List<clsvFileResourceEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFileResourceDA:GetObjLst)", objException.Message));
}
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = TransNullToBool(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = TransNullToBool(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = TransNullToBool(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFileResourceDA: GetObjLst)", objException.Message));
}
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFileResourceEN);
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
public List<clsvFileResourceEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFileResourceDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = TransNullToBool(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = TransNullToBool(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = TransNullToBool(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFileResourceDA: GetObjLst)", objException.Message));
}
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvFileResourceEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvFileResourceDA:GetObjLstBySP)", objException.Message));
}
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vFileResource_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = TransNullToBool(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = TransNullToBool(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = TransNullToBool(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvFileResourceDA: GetObjLstBySP)", objException.Message));
}
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFileResourceEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFileResource(ref clsvFileResourceEN objvFileResourceEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where FileResourceID = " + ""+ objvFileResourceEN.FileResourceID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFileResourceEN.FileResourceID = TransNullToInt(objDT.Rows[0][convFileResource.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objvFileResourceEN.FileDirName = objDT.Rows[0][convFileResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFileResourceEN.FileName = objDT.Rows[0][convFileResource.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvFileResourceEN.Extension = objDT.Rows[0][convFileResource.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.TabId = objDT.Rows[0][convFileResource.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvFileResourceEN.TabName = objDT.Rows[0][convFileResource.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFileResourceEN.TabCnName = objDT.Rows[0][convFileResource.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFileResourceEN.TabStateId = objDT.Rows[0][convFileResource.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvFileResourceEN.FuncModuleAgcId = objDT.Rows[0][convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvFileResourceEN.FuncModuleName = objDT.Rows[0][convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFileResourceEN.IsBelongsCurrCMPrj = TransNullToBool(objDT.Rows[0][convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsGeneCode = TransNullToBool(objDT.Rows[0][convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsCanDel = TransNullToBool(objDT.Rows[0][convFileResource.IsCanDel].ToString().Trim()); //是否可删除(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.FileLength = TransNullToInt(objDT.Rows[0][convFileResource.FileLength].ToString().Trim()); //文件长度(字段类型:bigint,字段长度:8,是否可空:True)
 objvFileResourceEN.FileType = objDT.Rows[0][convFileResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.CreationTime = objDT.Rows[0][convFileResource.CreationTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.LastWriteTime = objDT.Rows[0][convFileResource.LastWriteTime].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.CheckDateTime = objDT.Rows[0][convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.InUse = TransNullToBool(objDT.Rows[0][convFileResource.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsExistFile = TransNullToBool(objDT.Rows[0][convFileResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.PrjId = objDT.Rows[0][convFileResource.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvFileResourceEN.PrjName = objDT.Rows[0][convFileResource.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFileResourceEN.CmPrjId = objDT.Rows[0][convFileResource.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvFileResourceEN.CmPrjName = objDT.Rows[0][convFileResource.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFileResourceEN.IpAddress = objDT.Rows[0][convFileResource.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objvFileResourceEN.UpdDate = objDT.Rows[0][convFileResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.UpdUser = objDT.Rows[0][convFileResource.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.Memo = objDT.Rows[0][convFileResource.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFileResourceDA: GetvFileResource)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表对象</returns>
public clsvFileResourceEN GetObjByFileResourceID(long lngFileResourceID)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where FileResourceID = " + ""+ lngFileResourceID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
 objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度(字段类型:bigint,字段长度:8,是否可空:True)
 objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFileResourceDA: GetObjByFileResourceID)", objException.Message));
}
return objvFileResourceEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vFileResource_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFileResourceOneBySP(clsvFileResourceEN objvFileResourceEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvFileResourceEN.FileResourceID
};
 objDT = objSQL.ExecSpReturnDT("vFileResource_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvFileResourceEN.FileResourceID = TransNullToInt(objDT.Rows[0][convFileResource.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objvFileResourceEN.FileDirName = objDT.Rows[0][convFileResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFileResourceEN.FileName = objDT.Rows[0][convFileResource.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvFileResourceEN.Extension = objDT.Rows[0][convFileResource.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.TabId = objDT.Rows[0][convFileResource.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvFileResourceEN.TabName = objDT.Rows[0][convFileResource.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFileResourceEN.TabCnName = objDT.Rows[0][convFileResource.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFileResourceEN.TabStateId = objDT.Rows[0][convFileResource.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvFileResourceEN.FuncModuleAgcId = objDT.Rows[0][convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvFileResourceEN.FuncModuleName = objDT.Rows[0][convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFileResourceEN.IsBelongsCurrCMPrj = TransNullToBool(objDT.Rows[0][convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsGeneCode = TransNullToBool(objDT.Rows[0][convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsCanDel = TransNullToBool(objDT.Rows[0][convFileResource.IsCanDel].ToString().Trim()); //是否可删除(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.FileLength = TransNullToInt(objDT.Rows[0][convFileResource.FileLength].ToString().Trim()); //文件长度(字段类型:bigint,字段长度:8,是否可空:True)
 objvFileResourceEN.FileType = objDT.Rows[0][convFileResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.CreationTime = objDT.Rows[0][convFileResource.CreationTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.LastWriteTime = objDT.Rows[0][convFileResource.LastWriteTime].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.CheckDateTime = objDT.Rows[0][convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.InUse = TransNullToBool(objDT.Rows[0][convFileResource.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsExistFile = TransNullToBool(objDT.Rows[0][convFileResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.PrjId = objDT.Rows[0][convFileResource.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvFileResourceEN.PrjName = objDT.Rows[0][convFileResource.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFileResourceEN.CmPrjId = objDT.Rows[0][convFileResource.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvFileResourceEN.CmPrjName = objDT.Rows[0][convFileResource.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFileResourceEN.IpAddress = objDT.Rows[0][convFileResource.IpAddress].ToString().Trim(); //服务器(字段类型:varchar,字段长度:25,是否可空:False)
 objvFileResourceEN.UpdDate = objDT.Rows[0][convFileResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.UpdUser = objDT.Rows[0][convFileResource.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.Memo = objDT.Rows[0][convFileResource.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFileResourceEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN()
{
FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()), //FileResourceID
FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(), //文件目录名
FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(), //文件名
Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(), //扩展名
TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(), //表ID
TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(), //表名
TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(), //表中文名
TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(), //表状态ID
FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(), //功能模块名称
IsBelongsCurrCMPrj = TransNullToBool(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()), //是否属于当前项目
IsGeneCode = TransNullToBool(objRow[convFileResource.IsGeneCode].ToString().Trim()), //是否生成代码
IsCanDel = TransNullToBool(objRow[convFileResource.IsCanDel].ToString().Trim()), //是否可删除
FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()), //文件长度
FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(), //文件类型
CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(), //建立时间
LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(), //修改日期
CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(), //CheckDateTime
InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()), //是否在用
IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()), //是否存在文件
PrjId = objRow[convFileResource.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(), //工程名称
CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(), //CM工程Id
CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(), //CM工程名
IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(), //服务器
UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim() //说明
};
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFileResourceEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFileResourceDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFileResourceEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvFileResourceDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vFileResource_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN()
{
FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()), //FileResourceID
FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(), //文件目录名
FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(), //文件名
Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(), //扩展名
TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(), //表ID
TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(), //表名
TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(), //表中文名
TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(), //表状态ID
FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(), //功能模块名称
IsBelongsCurrCMPrj = TransNullToBool(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()), //是否属于当前项目
IsGeneCode = TransNullToBool(objRow[convFileResource.IsGeneCode].ToString().Trim()), //是否生成代码
IsCanDel = TransNullToBool(objRow[convFileResource.IsCanDel].ToString().Trim()), //是否可删除
FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()), //文件长度
FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(), //文件类型
CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(), //建立时间
LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(), //修改日期
CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(), //CheckDateTime
InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()), //是否在用
IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()), //是否存在文件
PrjId = objRow[convFileResource.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(), //工程名称
CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(), //CM工程Id
CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(), //CM工程名
IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(), //服务器
UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim() //说明
};
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFileResourceEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFileResourceEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = TransNullToBool(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = TransNullToBool(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = TransNullToBool(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFileResourceDA: GetObjByDataRowvFileResource)", objException.Message));
}
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFileResourceEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFileResourceEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = TransNullToBool(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = TransNullToBool(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = TransNullToBool(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFileResourceDA: GetObjByDataRow)", objException.Message));
}
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFileResourceEN;
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
objSQL = clsvFileResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFileResourceEN._CurrTabName, convFileResource.FileResourceID, 8, "");
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
objSQL = clsvFileResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFileResourceEN._CurrTabName, convFileResource.FileResourceID, 8, strPrefix);
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FileResourceID from vFileResource where " + strCondition;
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FileResourceID from vFileResource where " + strCondition;
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
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngFileResourceID)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFileResource", "FileResourceID = " + ""+ lngFileResourceID+""))
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
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngFileResourceID)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngFileResourceID,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vFileResource_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFileResourceDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFileResource", strCondition))
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
objSQL = clsvFileResourceDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFileResource");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFileResourceENS">源对象</param>
 /// <param name = "objvFileResourceENT">目标对象</param>
public void CopyTo(clsvFileResourceEN objvFileResourceENS, clsvFileResourceEN objvFileResourceENT)
{
objvFileResourceENT.FileResourceID = objvFileResourceENS.FileResourceID; //FileResourceID
objvFileResourceENT.FileDirName = objvFileResourceENS.FileDirName; //文件目录名
objvFileResourceENT.FileName = objvFileResourceENS.FileName; //文件名
objvFileResourceENT.Extension = objvFileResourceENS.Extension; //扩展名
objvFileResourceENT.TabId = objvFileResourceENS.TabId; //表ID
objvFileResourceENT.TabName = objvFileResourceENS.TabName; //表名
objvFileResourceENT.TabCnName = objvFileResourceENS.TabCnName; //表中文名
objvFileResourceENT.TabStateId = objvFileResourceENS.TabStateId; //表状态ID
objvFileResourceENT.FuncModuleAgcId = objvFileResourceENS.FuncModuleAgcId; //功能模块Id
objvFileResourceENT.FuncModuleName = objvFileResourceENS.FuncModuleName; //功能模块名称
objvFileResourceENT.IsBelongsCurrCMPrj = objvFileResourceENS.IsBelongsCurrCMPrj; //是否属于当前项目
objvFileResourceENT.IsGeneCode = objvFileResourceENS.IsGeneCode; //是否生成代码
objvFileResourceENT.IsCanDel = objvFileResourceENS.IsCanDel; //是否可删除
objvFileResourceENT.FileLength = objvFileResourceENS.FileLength; //文件长度
objvFileResourceENT.FileType = objvFileResourceENS.FileType; //文件类型
objvFileResourceENT.CreationTime = objvFileResourceENS.CreationTime; //建立时间
objvFileResourceENT.LastWriteTime = objvFileResourceENS.LastWriteTime; //修改日期
objvFileResourceENT.CheckDateTime = objvFileResourceENS.CheckDateTime; //CheckDateTime
objvFileResourceENT.InUse = objvFileResourceENS.InUse; //是否在用
objvFileResourceENT.IsExistFile = objvFileResourceENS.IsExistFile; //是否存在文件
objvFileResourceENT.PrjId = objvFileResourceENS.PrjId; //工程ID
objvFileResourceENT.PrjName = objvFileResourceENS.PrjName; //工程名称
objvFileResourceENT.CmPrjId = objvFileResourceENS.CmPrjId; //CM工程Id
objvFileResourceENT.CmPrjName = objvFileResourceENS.CmPrjName; //CM工程名
objvFileResourceENT.IpAddress = objvFileResourceENS.IpAddress; //服务器
objvFileResourceENT.UpdDate = objvFileResourceENS.UpdDate; //修改日期
objvFileResourceENT.UpdUser = objvFileResourceENS.UpdUser; //修改者
objvFileResourceENT.Memo = objvFileResourceENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFileResourceEN objvFileResourceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFileResourceEN.FileDirName, 200, convFileResource.FileDirName);
clsCheckSql.CheckFieldLen(objvFileResourceEN.FileName, 150, convFileResource.FileName);
clsCheckSql.CheckFieldLen(objvFileResourceEN.Extension, 20, convFileResource.Extension);
clsCheckSql.CheckFieldLen(objvFileResourceEN.TabId, 8, convFileResource.TabId);
clsCheckSql.CheckFieldLen(objvFileResourceEN.TabName, 100, convFileResource.TabName);
clsCheckSql.CheckFieldLen(objvFileResourceEN.TabCnName, 200, convFileResource.TabCnName);
clsCheckSql.CheckFieldLen(objvFileResourceEN.TabStateId, 2, convFileResource.TabStateId);
clsCheckSql.CheckFieldLen(objvFileResourceEN.FuncModuleAgcId, 8, convFileResource.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvFileResourceEN.FuncModuleName, 30, convFileResource.FuncModuleName);
clsCheckSql.CheckFieldLen(objvFileResourceEN.FileType, 30, convFileResource.FileType);
clsCheckSql.CheckFieldLen(objvFileResourceEN.CreationTime, 20, convFileResource.CreationTime);
clsCheckSql.CheckFieldLen(objvFileResourceEN.LastWriteTime, 30, convFileResource.LastWriteTime);
clsCheckSql.CheckFieldLen(objvFileResourceEN.CheckDateTime, 30, convFileResource.CheckDateTime);
clsCheckSql.CheckFieldLen(objvFileResourceEN.PrjId, 4, convFileResource.PrjId);
clsCheckSql.CheckFieldLen(objvFileResourceEN.PrjName, 30, convFileResource.PrjName);
clsCheckSql.CheckFieldLen(objvFileResourceEN.CmPrjId, 6, convFileResource.CmPrjId);
clsCheckSql.CheckFieldLen(objvFileResourceEN.CmPrjName, 50, convFileResource.CmPrjName);
clsCheckSql.CheckFieldLen(objvFileResourceEN.IpAddress, 25, convFileResource.IpAddress);
clsCheckSql.CheckFieldLen(objvFileResourceEN.UpdDate, 20, convFileResource.UpdDate);
clsCheckSql.CheckFieldLen(objvFileResourceEN.UpdUser, 20, convFileResource.UpdUser);
clsCheckSql.CheckFieldLen(objvFileResourceEN.Memo, 1000, convFileResource.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.FileDirName, convFileResource.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.FileName, convFileResource.FileName);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.Extension, convFileResource.Extension);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.TabId, convFileResource.TabId);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.TabName, convFileResource.TabName);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.TabCnName, convFileResource.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.TabStateId, convFileResource.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.FuncModuleAgcId, convFileResource.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.FuncModuleName, convFileResource.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.FileType, convFileResource.FileType);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.CreationTime, convFileResource.CreationTime);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.LastWriteTime, convFileResource.LastWriteTime);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.CheckDateTime, convFileResource.CheckDateTime);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.PrjId, convFileResource.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.PrjName, convFileResource.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.CmPrjId, convFileResource.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.CmPrjName, convFileResource.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.IpAddress, convFileResource.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.UpdDate, convFileResource.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.UpdUser, convFileResource.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.Memo, convFileResource.Memo);
//检查外键字段长度
 objvFileResourceEN._IsCheckProperty = true;
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFileResourceEN._CurrTabName);
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFileResourceEN._CurrTabName, strCondition);
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}