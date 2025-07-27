
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvErrorIdManageDA
 表名:vErrorIdManage(00050302)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// v错误Id管理(vErrorIdManage)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsvErrorIdManageDA : clsCommBase4DA
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
 return clsvErrorIdManageEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvErrorIdManageEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvErrorIdManageEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvErrorIdManageEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvErrorIdManageEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 strSQL = "Select * from vErrorIdManage where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vErrorIdManage");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vErrorIdManage_SelectByCond",values, "vErrorIdManage");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vErrorIdManage");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vErrorIdManage a where {0} And a.mId not in (Select Top {2} mId From vErrorIdManage Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vErrorIdManage");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vErrorIdManage a where {0} And a.mId not in (Select Top {2} mId From vErrorIdManage Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vErrorIdManage");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vErrorIdManage a where {0} And a.mId not in (Select Top {2} mId From vErrorIdManage Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vErrorIdManage");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from vErrorIdManage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vErrorIdManage(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTable_vErrorIdManage)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from vErrorIdManage where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from vErrorIdManage where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from vErrorIdManage where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vErrorIdManage.* from vErrorIdManage Left Join {1} on {2} where {3} and vErrorIdManage.mId not in (Select top {5} vErrorIdManage.mId from vErrorIdManage Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1} and mId not in (Select top {2} mId from vErrorIdManage where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1} and mId not in (Select top {3} mId from vErrorIdManage where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vErrorIdManage.* from vErrorIdManage Left Join {1} on {2} where {3} and vErrorIdManage.mId not in (Select top {5} vErrorIdManage.mId from vErrorIdManage Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1} and mId not in (Select top {2} mId from vErrorIdManage where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1} and mId not in (Select top {3} mId from vErrorIdManage where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vErrorIdManage.* from vErrorIdManage Left Join {1} on {2} where {3} and vErrorIdManage.mId not in (Select top {5} vErrorIdManage.mId from vErrorIdManage Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1} and mId not in (Select top {2} mId from vErrorIdManage where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vErrorIdManage where {1} and mId not in (Select top {3} mId from vErrorIdManage where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vErrorIdManage a where {0} And a.mId not in (Select Top {2} mId From vErrorIdManage Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vErrorIdManage a where {0} And a.mId not in (Select Top {2} mId From vErrorIdManage Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vErrorIdManage a where {0} And a.mId not in (Select Top {2} mId From vErrorIdManage Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vErrorIdManage a where {0} And a.mId not in (Select Top {2} mId From vErrorIdManage Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvErrorIdManageDA: GetvErrorIdManageByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from vErrorIdManage where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vErrorIdManage_SelectByCond",values);
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
public List<clsvErrorIdManageEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvErrorIdManageDA:GetObjLst)", objException.Message));
}
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from vErrorIdManage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = TransNullToInt(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvErrorIdManageDA: GetObjLst)", objException.Message));
}
objvErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvErrorIdManageEN);
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
public List<clsvErrorIdManageEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvErrorIdManageDA:GetObjLstByTabName)", objException.Message));
}
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = TransNullToInt(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvErrorIdManageDA: GetObjLst)", objException.Message));
}
objvErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvErrorIdManageEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvErrorIdManageEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvErrorIdManageDA:GetObjLstBySP)", objException.Message));
}
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vErrorIdManage_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = TransNullToInt(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvErrorIdManageDA: GetObjLstBySP)", objException.Message));
}
objvErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvErrorIdManageEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvErrorIdManage(ref clsvErrorIdManageEN objvErrorIdManageEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from vErrorIdManage where mId = " + ""+ objvErrorIdManageEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvErrorIdManageEN.mId = TransNullToInt(objDT.Rows[0][convErrorIdManage.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvErrorIdManageEN.ErrID = objDT.Rows[0][convErrorIdManage.ErrID].ToString().Trim(); //错误Id(字段类型:char,字段长度:10,是否可空:False)
 objvErrorIdManageEN.ProgLevelTypeId = objDT.Rows[0][convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvErrorIdManageEN.ProgLevelTypeName = objDT.Rows[0][convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvErrorIdManageEN.ProgLevelTypeENName = objDT.Rows[0][convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvErrorIdManageEN.Prefix = objDT.Rows[0][convErrorIdManage.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objvErrorIdManageEN.CodeTypeId = objDT.Rows[0][convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvErrorIdManageEN.CodeTypeName = objDT.Rows[0][convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvErrorIdManageEN.CodeTypeENName = objDT.Rows[0][convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvErrorIdManageEN.FunctionName = objDT.Rows[0][convErrorIdManage.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvErrorIdManageEN.Explanation = objDT.Rows[0][convErrorIdManage.Explanation].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvErrorIdManageEN.UpdDate = objDT.Rows[0][convErrorIdManage.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvErrorIdManageEN.UpdUserId = objDT.Rows[0][convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvErrorIdManageEN.Memo = objDT.Rows[0][convErrorIdManage.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvErrorIdManageDA: GetvErrorIdManage)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvErrorIdManageEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from vErrorIdManage where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
 objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id(字段类型:char,字段长度:10,是否可空:False)
 objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvErrorIdManageDA: GetObjBymId)", objException.Message));
}
return objvErrorIdManageEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vErrorIdManage_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvErrorIdManageOneBySP(clsvErrorIdManageEN objvErrorIdManageEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvErrorIdManageEN.mId
};
 objDT = objSQL.ExecSpReturnDT("vErrorIdManage_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvErrorIdManageEN.mId = TransNullToInt(objDT.Rows[0][convErrorIdManage.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvErrorIdManageEN.ErrID = objDT.Rows[0][convErrorIdManage.ErrID].ToString().Trim(); //错误Id(字段类型:char,字段长度:10,是否可空:False)
 objvErrorIdManageEN.ProgLevelTypeId = objDT.Rows[0][convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvErrorIdManageEN.ProgLevelTypeName = objDT.Rows[0][convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvErrorIdManageEN.ProgLevelTypeENName = objDT.Rows[0][convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvErrorIdManageEN.Prefix = objDT.Rows[0][convErrorIdManage.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objvErrorIdManageEN.CodeTypeId = objDT.Rows[0][convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvErrorIdManageEN.CodeTypeName = objDT.Rows[0][convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvErrorIdManageEN.CodeTypeENName = objDT.Rows[0][convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvErrorIdManageEN.FunctionName = objDT.Rows[0][convErrorIdManage.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvErrorIdManageEN.Explanation = objDT.Rows[0][convErrorIdManage.Explanation].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvErrorIdManageEN.UpdDate = objDT.Rows[0][convErrorIdManage.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvErrorIdManageEN.UpdUserId = objDT.Rows[0][convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvErrorIdManageEN.Memo = objDT.Rows[0][convErrorIdManage.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvErrorIdManageEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvErrorIdManageDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from vErrorIdManage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN()
{
mId = TransNullToInt(objRow[convErrorIdManage.mId].ToString().Trim()), //mId
ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(), //错误Id
ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(), //程序分层类型Id
ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(), //程序分层类型名称
ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(), //程序分层类型英文名称
Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(), //前缀
CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(), //代码类型名
CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(), //代码类型英文名
FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(), //功能名称
Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(), //详细说明
UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim() //说明
};
objvErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvErrorIdManageEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvErrorIdManageDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvErrorIdManageEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvErrorIdManageDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vErrorIdManage_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN()
{
mId = TransNullToInt(objRow[convErrorIdManage.mId].ToString().Trim()), //mId
ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(), //错误Id
ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(), //程序分层类型Id
ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(), //程序分层类型名称
ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(), //程序分层类型英文名称
Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(), //前缀
CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(), //代码类型名
CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(), //代码类型英文名
FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(), //功能名称
Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(), //详细说明
UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim() //说明
};
objvErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvErrorIdManageEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvErrorIdManageEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = TransNullToInt(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvErrorIdManageDA: GetObjByDataRowvErrorIdManage)", objException.Message));
}
objvErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvErrorIdManageEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvErrorIdManageEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = TransNullToInt(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvErrorIdManageDA: GetObjByDataRow)", objException.Message));
}
objvErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvErrorIdManageEN;
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
objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvErrorIdManageEN._CurrTabName, convErrorIdManage.mId, 8, "");
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
objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvErrorIdManageEN._CurrTabName, convErrorIdManage.mId, 8, strPrefix);
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
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vErrorIdManage where " + strCondition;
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
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vErrorIdManage where " + strCondition;
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
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vErrorIdManage", "mId = " + ""+ lngmId+""))
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
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vErrorIdManage_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvErrorIdManageDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vErrorIdManage", strCondition))
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
objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vErrorIdManage");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvErrorIdManageENS">源对象</param>
 /// <param name = "objvErrorIdManageENT">目标对象</param>
public void CopyTo(clsvErrorIdManageEN objvErrorIdManageENS, clsvErrorIdManageEN objvErrorIdManageENT)
{
objvErrorIdManageENT.mId = objvErrorIdManageENS.mId; //mId
objvErrorIdManageENT.ErrID = objvErrorIdManageENS.ErrID; //错误Id
objvErrorIdManageENT.ProgLevelTypeId = objvErrorIdManageENS.ProgLevelTypeId; //程序分层类型Id
objvErrorIdManageENT.ProgLevelTypeName = objvErrorIdManageENS.ProgLevelTypeName; //程序分层类型名称
objvErrorIdManageENT.ProgLevelTypeENName = objvErrorIdManageENS.ProgLevelTypeENName; //程序分层类型英文名称
objvErrorIdManageENT.Prefix = objvErrorIdManageENS.Prefix; //前缀
objvErrorIdManageENT.CodeTypeId = objvErrorIdManageENS.CodeTypeId; //代码类型Id
objvErrorIdManageENT.CodeTypeName = objvErrorIdManageENS.CodeTypeName; //代码类型名
objvErrorIdManageENT.CodeTypeENName = objvErrorIdManageENS.CodeTypeENName; //代码类型英文名
objvErrorIdManageENT.FunctionName = objvErrorIdManageENS.FunctionName; //功能名称
objvErrorIdManageENT.Explanation = objvErrorIdManageENS.Explanation; //详细说明
objvErrorIdManageENT.UpdDate = objvErrorIdManageENS.UpdDate; //修改日期
objvErrorIdManageENT.UpdUserId = objvErrorIdManageENS.UpdUserId; //修改用户Id
objvErrorIdManageENT.Memo = objvErrorIdManageENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvErrorIdManageEN objvErrorIdManageEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.ErrID, 10, convErrorIdManage.ErrID);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.ProgLevelTypeId, 2, convErrorIdManage.ProgLevelTypeId);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.ProgLevelTypeName, 30, convErrorIdManage.ProgLevelTypeName);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.ProgLevelTypeENName, 30, convErrorIdManage.ProgLevelTypeENName);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.Prefix, 10, convErrorIdManage.Prefix);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.CodeTypeId, 4, convErrorIdManage.CodeTypeId);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.CodeTypeName, 50, convErrorIdManage.CodeTypeName);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.CodeTypeENName, 50, convErrorIdManage.CodeTypeENName);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.FunctionName, 200, convErrorIdManage.FunctionName);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.Explanation, 1000, convErrorIdManage.Explanation);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.UpdDate, 20, convErrorIdManage.UpdDate);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.UpdUserId, 20, convErrorIdManage.UpdUserId);
clsCheckSql.CheckFieldLen(objvErrorIdManageEN.Memo, 1000, convErrorIdManage.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.ErrID, convErrorIdManage.ErrID);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.ProgLevelTypeId, convErrorIdManage.ProgLevelTypeId);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.ProgLevelTypeName, convErrorIdManage.ProgLevelTypeName);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.ProgLevelTypeENName, convErrorIdManage.ProgLevelTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.Prefix, convErrorIdManage.Prefix);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.CodeTypeId, convErrorIdManage.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.CodeTypeName, convErrorIdManage.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.CodeTypeENName, convErrorIdManage.CodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.FunctionName, convErrorIdManage.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.Explanation, convErrorIdManage.Explanation);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.UpdDate, convErrorIdManage.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.UpdUserId, convErrorIdManage.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvErrorIdManageEN.Memo, convErrorIdManage.Memo);
//检查外键字段长度
 objvErrorIdManageEN._IsCheckProperty = true;
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
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
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
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
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
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvErrorIdManageEN._CurrTabName);
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
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvErrorIdManageEN._CurrTabName, strCondition);
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
 objSQL = clsvErrorIdManageDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}