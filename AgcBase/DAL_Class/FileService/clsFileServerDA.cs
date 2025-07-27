
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileServerDA
 表名:FileServer(00050209)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件服务(FileService)
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
 /// 文件服务(FileServer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsFileServerDA : clsCommBase4DA
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
 return clsFileServerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFileServerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFileServerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFileServerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFileServerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 strSQL = "Select * from FileServer where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "FileServer");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("FileServer_SelectByCond",values, "FileServer");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FileServer where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "FileServer");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFileServerDA: GetFileServerByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FileServer a where {0} And a.id_FileId not in (Select Top {2} id_FileId From FileServer Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FileServer");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFileServerDA: GetFileServerByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FileServer a where {0} And a.id_FileId not in (Select Top {2} id_FileId From FileServer Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FileServer");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFileServerDA: GetFileServerByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FileServer a where {0} And a.id_FileId not in (Select Top {2} id_FileId From FileServer Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FileServer");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FileServer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable_FileServer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FileServer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FileServer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFileServerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FileServer.* from FileServer Left Join {1} on {2} where {3} and FileServer.id_FileId not in (Select top {5} FileServer.id_FileId from FileServer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} and id_FileId not in (Select top {2} id_FileId from FileServer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} and id_FileId not in (Select top {3} id_FileId from FileServer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFileServerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FileServer.* from FileServer Left Join {1} on {2} where {3} and FileServer.id_FileId not in (Select top {5} FileServer.id_FileId from FileServer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} and id_FileId not in (Select top {2} id_FileId from FileServer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} and id_FileId not in (Select top {3} id_FileId from FileServer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsFileServerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FileServer.* from FileServer Left Join {1} on {2} where {3} and FileServer.id_FileId not in (Select top {5} FileServer.id_FileId from FileServer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} and id_FileId not in (Select top {2} id_FileId from FileServer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FileServer where {1} and id_FileId not in (Select top {3} id_FileId from FileServer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFileServerDA: GetFileServerByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from FileServer a where {0} And a.id_FileId not in (Select Top {2} id_FileId From FileServer Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from FileServer a where {0} And a.id_FileId not in (Select Top {2} id_FileId From FileServer Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFileServerDA: GetFileServerByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from FileServer a where {0} And a.id_FileId not in (Select Top {2} id_FileId From FileServer Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from FileServer a where {0} And a.id_FileId not in (Select Top {2} id_FileId From FileServer Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFileServerDA: GetFileServerByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFileServerDA: GetFileServerByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsFileServerDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FileServer_SelectByCond",values);
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
public List<clsFileServerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFileServerDA:GetObjLst)", objException.Message));
}
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = TransNullToInt(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = TransNullToBool(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFileServerDA: GetObjLst)", objException.Message));
}
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFileServerEN);
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
public List<clsFileServerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFileServerDA:GetObjLstByTabName)", objException.Message));
}
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = TransNullToInt(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = TransNullToBool(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFileServerDA: GetObjLst)", objException.Message));
}
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsFileServerEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsFileServerDA:GetObjLstBySP)", objException.Message));
}
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FileServer_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = TransNullToInt(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = TransNullToBool(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsFileServerDA: GetObjLstBySP)", objException.Message));
}
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFileServer(ref clsFileServerEN objFileServerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where id_FileId = " + ""+ objFileServerEN.id_FileId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFileServerEN.id_FileId = TransNullToInt(objDT.Rows[0][conFileServer.id_FileId].ToString().Trim()); //文件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objFileServerEN.FileContent = (byte[])objDT.Rows[0][conFileServer.FileContent]; //文件内容(字段类型:image,字段长度:2147483647,是否可空:True)
 objFileServerEN.FileName = objDT.Rows[0][conFileServer.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objFileServerEN.IsFree = TransNullToBool(objDT.Rows[0][conFileServer.IsFree].ToString().Trim()); //是否释放(字段类型:bit,字段长度:1,是否可空:True)
 objFileServerEN.FileSize = TransNullToInt(objDT.Rows[0][conFileServer.FileSize].ToString().Trim()); //文件大小(字段类型:bigint,字段长度:8,是否可空:True)
 objFileServerEN.FileType = objDT.Rows[0][conFileServer.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objFileServerEN.SaveDate = objDT.Rows[0][conFileServer.SaveDate].ToString().Trim(); //保存日期(字段类型:varchar,字段长度:25,是否可空:True)
 objFileServerEN.LastWriteTime = objDT.Rows[0][conFileServer.LastWriteTime].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:30,是否可空:True)
 objFileServerEN.IdFtpResource = objDT.Rows[0][conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objFileServerEN.id_ResourceType = objDT.Rows[0][conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objFileServerEN.SaveMode = objDT.Rows[0][conFileServer.SaveMode].ToString().Trim(); //文件存放方式(字段类型:varchar,字段长度:10,是否可空:True)
 objFileServerEN.ProjectName = objDT.Rows[0][conFileServer.ProjectName].ToString().Trim(); //项目名称(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFileServerDA: GetFileServer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_FileId">表关键字</param>
 /// <returns>表对象</returns>
public clsFileServerEN GetObjByid_FileId(long lngid_FileId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where id_FileId = " + ""+ lngid_FileId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
 objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容(字段类型:image,字段长度:2147483647,是否可空:True)
 objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放(字段类型:bit,字段长度:1,是否可空:True)
 objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小(字段类型:bigint,字段长度:8,是否可空:True)
 objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期(字段类型:varchar,字段长度:25,是否可空:True)
 objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:30,是否可空:True)
 objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式(字段类型:varchar,字段长度:10,是否可空:True)
 objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFileServerDA: GetObjByid_FileId)", objException.Message));
}
return objFileServerEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程FileServer_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFileServerOneBySP(clsFileServerEN objFileServerEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objFileServerEN.id_FileId
};
 objDT = objSQL.ExecSpReturnDT("FileServer_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objFileServerEN.id_FileId = TransNullToInt(objDT.Rows[0][conFileServer.id_FileId].ToString().Trim()); //文件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objFileServerEN.FileContent = (byte[])objDT.Rows[0][conFileServer.FileContent]; //文件内容(字段类型:image,字段长度:2147483647,是否可空:True)
 objFileServerEN.FileName = objDT.Rows[0][conFileServer.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objFileServerEN.IsFree = TransNullToBool(objDT.Rows[0][conFileServer.IsFree].ToString().Trim()); //是否释放(字段类型:bit,字段长度:1,是否可空:True)
 objFileServerEN.FileSize = TransNullToInt(objDT.Rows[0][conFileServer.FileSize].ToString().Trim()); //文件大小(字段类型:bigint,字段长度:8,是否可空:True)
 objFileServerEN.FileType = objDT.Rows[0][conFileServer.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objFileServerEN.SaveDate = objDT.Rows[0][conFileServer.SaveDate].ToString().Trim(); //保存日期(字段类型:varchar,字段长度:25,是否可空:True)
 objFileServerEN.LastWriteTime = objDT.Rows[0][conFileServer.LastWriteTime].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:30,是否可空:True)
 objFileServerEN.IdFtpResource = objDT.Rows[0][conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objFileServerEN.id_ResourceType = objDT.Rows[0][conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objFileServerEN.SaveMode = objDT.Rows[0][conFileServer.SaveMode].ToString().Trim(); //文件存放方式(字段类型:varchar,字段长度:10,是否可空:True)
 objFileServerEN.ProjectName = objDT.Rows[0][conFileServer.ProjectName].ToString().Trim(); //项目名称(字段类型:varchar,字段长度:100,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFileServerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFileServerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFileServerEN objFileServerEN = new clsFileServerEN()
{
id_FileId = TransNullToInt(objRow[conFileServer.id_FileId].ToString().Trim()), //文件流水号
FileContent = (byte[])objRow[conFileServer.FileContent], //文件内容
FileName = objRow[conFileServer.FileName].ToString().Trim(), //文件名
IsFree = TransNullToBool(objRow[conFileServer.IsFree].ToString().Trim()), //是否释放
FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileServer.FileSize].ToString().Trim()), //文件大小
FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(), //保存日期
LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(), //修改日期
IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(), //FTP资源流水号
id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(), //资源类型流水号
SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(), //文件存放方式
ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim() //项目名称
};
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFileServerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFileServerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFileServerEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsFileServerDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FileServer_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsFileServerEN objFileServerEN = new clsFileServerEN()
{
id_FileId = TransNullToInt(objRow[conFileServer.id_FileId].ToString().Trim()), //文件流水号
FileContent = (byte[])objRow[conFileServer.FileContent], //文件内容
FileName = objRow[conFileServer.FileName].ToString().Trim(), //文件名
IsFree = TransNullToBool(objRow[conFileServer.IsFree].ToString().Trim()), //是否释放
FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileServer.FileSize].ToString().Trim()), //文件大小
FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(), //保存日期
LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(), //修改日期
IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(), //FTP资源流水号
id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(), //资源类型流水号
SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(), //文件存放方式
ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim() //项目名称
};
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFileServerEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFileServerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = TransNullToInt(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = objRow[conFileServer.FileContent] as byte[]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = TransNullToBool(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFileServerDA: GetObjByDataRowFileServer)", objException.Message));
}
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFileServerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFileServerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = TransNullToInt(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = objRow[conFileServer.FileContent] as byte[]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = TransNullToBool(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFileServerDA: GetObjByDataRow)", objException.Message));
}
objFileServerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFileServerEN;
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
objSQL = clsFileServerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFileServerEN._CurrTabName, conFileServer.id_FileId, 8, "");
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
objSQL = clsFileServerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFileServerEN._CurrTabName, conFileServer.id_FileId, 8, strPrefix);
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select id_FileId from FileServer where " + strCondition;
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select id_FileId from FileServer where " + strCondition;
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
 /// <param name = "lngid_FileId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngid_FileId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FileServer", "id_FileId = " + ""+ lngid_FileId+""))
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
 /// <param name = "lngid_FileId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngid_FileId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngid_FileId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("FileServer_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFileServerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FileServer", strCondition))
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
objSQL = clsFileServerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FileServer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFileServerEN objFileServerEN)
 {
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileServerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FileServer");
objRow = objDS.Tables["FileServer"].NewRow();
objRow[conFileServer.FileContent] = objFileServerEN.FileContent; //文件内容
objRow[conFileServer.FileName] = objFileServerEN.FileName; //文件名
objRow[conFileServer.IsFree] = objFileServerEN.IsFree; //是否释放
objRow[conFileServer.FileSize] = objFileServerEN.FileSize; //文件大小
 if (objFileServerEN.FileType !=  "")
 {
objRow[conFileServer.FileType] = objFileServerEN.FileType; //文件类型
 }
 if (objFileServerEN.SaveDate !=  "")
 {
objRow[conFileServer.SaveDate] = objFileServerEN.SaveDate; //保存日期
 }
 if (objFileServerEN.LastWriteTime !=  "")
 {
objRow[conFileServer.LastWriteTime] = objFileServerEN.LastWriteTime; //修改日期
 }
 if (objFileServerEN.IdFtpResource !=  "")
 {
objRow[conFileServer.IdFtpResource] = objFileServerEN.IdFtpResource; //FTP资源流水号
 }
objRow[conFileServer.id_ResourceType] = objFileServerEN.id_ResourceType; //资源类型流水号
 if (objFileServerEN.SaveMode !=  "")
 {
objRow[conFileServer.SaveMode] = objFileServerEN.SaveMode; //文件存放方式
 }
 if (objFileServerEN.ProjectName !=  "")
 {
objRow[conFileServer.ProjectName] = objFileServerEN.ProjectName; //项目名称
 }
objDS.Tables[clsFileServerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFileServerEN._CurrTabName);
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFileServerEN objFileServerEN)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileServerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 
 if (objFileServerEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileName);
 objFileServerEN.FileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.FileName + "'");
 }
 
 arrFieldListForInsert.Add(conFileServer.IsFree);
 arrValueListForInsert.Add("'" + (objFileServerEN.IsFree  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFileServer.FileSize);
 arrValueListForInsert.Add(objFileServerEN.FileSize.ToString());
 
 if (objFileServerEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileType);
 objFileServerEN.FileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.FileType + "'");
 }
 
 if (objFileServerEN.SaveDate !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveDate);
 objFileServerEN.SaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.SaveDate + "'");
 }
 
 if (objFileServerEN.LastWriteTime !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.LastWriteTime);
 objFileServerEN.LastWriteTime = objFileServerEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.LastWriteTime + "'");
 }
 
 if (objFileServerEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.IdFtpResource);
 objFileServerEN.IdFtpResource = objFileServerEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.IdFtpResource + "'");
 }
 
 if (objFileServerEN.id_ResourceType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.id_ResourceType);
 objFileServerEN.id_ResourceType = objFileServerEN.id_ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.id_ResourceType + "'");
 }
 
 if (objFileServerEN.SaveMode !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveMode);
 objFileServerEN.SaveMode = objFileServerEN.SaveMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.SaveMode + "'");
 }
 
 if (objFileServerEN.ProjectName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.ProjectName);
 objFileServerEN.ProjectName = objFileServerEN.ProjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.ProjectName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileServer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFileServerEN objFileServerEN)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileServerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 
 if (objFileServerEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileName);
 objFileServerEN.FileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.FileName + "'");
 }
 
 arrFieldListForInsert.Add(conFileServer.IsFree);
 arrValueListForInsert.Add("'" + (objFileServerEN.IsFree  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFileServer.FileSize);
 arrValueListForInsert.Add(objFileServerEN.FileSize.ToString());
 
 if (objFileServerEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileType);
 objFileServerEN.FileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.FileType + "'");
 }
 
 if (objFileServerEN.SaveDate !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveDate);
 objFileServerEN.SaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.SaveDate + "'");
 }
 
 if (objFileServerEN.LastWriteTime !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.LastWriteTime);
 objFileServerEN.LastWriteTime = objFileServerEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.LastWriteTime + "'");
 }
 
 if (objFileServerEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.IdFtpResource);
 objFileServerEN.IdFtpResource = objFileServerEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.IdFtpResource + "'");
 }
 
 if (objFileServerEN.id_ResourceType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.id_ResourceType);
 objFileServerEN.id_ResourceType = objFileServerEN.id_ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.id_ResourceType + "'");
 }
 
 if (objFileServerEN.SaveMode !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveMode);
 objFileServerEN.SaveMode = objFileServerEN.SaveMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.SaveMode + "'");
 }
 
 if (objFileServerEN.ProjectName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.ProjectName);
 objFileServerEN.ProjectName = objFileServerEN.ProjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.ProjectName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileServer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFileServerEN objFileServerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileServerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 
 if (objFileServerEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileName);
 objFileServerEN.FileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.FileName + "'");
 }
 
 arrFieldListForInsert.Add(conFileServer.IsFree);
 arrValueListForInsert.Add("'" + (objFileServerEN.IsFree  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFileServer.FileSize);
 arrValueListForInsert.Add(objFileServerEN.FileSize.ToString());
 
 if (objFileServerEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileType);
 objFileServerEN.FileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.FileType + "'");
 }
 
 if (objFileServerEN.SaveDate !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveDate);
 objFileServerEN.SaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.SaveDate + "'");
 }
 
 if (objFileServerEN.LastWriteTime !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.LastWriteTime);
 objFileServerEN.LastWriteTime = objFileServerEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.LastWriteTime + "'");
 }
 
 if (objFileServerEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.IdFtpResource);
 objFileServerEN.IdFtpResource = objFileServerEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.IdFtpResource + "'");
 }
 
 if (objFileServerEN.id_ResourceType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.id_ResourceType);
 objFileServerEN.id_ResourceType = objFileServerEN.id_ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.id_ResourceType + "'");
 }
 
 if (objFileServerEN.SaveMode !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveMode);
 objFileServerEN.SaveMode = objFileServerEN.SaveMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.SaveMode + "'");
 }
 
 if (objFileServerEN.ProjectName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.ProjectName);
 objFileServerEN.ProjectName = objFileServerEN.ProjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.ProjectName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileServer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFileServerEN objFileServerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileServerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 
 if (objFileServerEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileName);
 objFileServerEN.FileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.FileName + "'");
 }
 
 arrFieldListForInsert.Add(conFileServer.IsFree);
 arrValueListForInsert.Add("'" + (objFileServerEN.IsFree  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFileServer.FileSize);
 arrValueListForInsert.Add(objFileServerEN.FileSize.ToString());
 
 if (objFileServerEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.FileType);
 objFileServerEN.FileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.FileType + "'");
 }
 
 if (objFileServerEN.SaveDate !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveDate);
 objFileServerEN.SaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.SaveDate + "'");
 }
 
 if (objFileServerEN.LastWriteTime !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.LastWriteTime);
 objFileServerEN.LastWriteTime = objFileServerEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.LastWriteTime + "'");
 }
 
 if (objFileServerEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.IdFtpResource);
 objFileServerEN.IdFtpResource = objFileServerEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.IdFtpResource + "'");
 }
 
 if (objFileServerEN.id_ResourceType !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.id_ResourceType);
 objFileServerEN.id_ResourceType = objFileServerEN.id_ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.id_ResourceType + "'");
 }
 
 if (objFileServerEN.SaveMode !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.SaveMode);
 objFileServerEN.SaveMode = objFileServerEN.SaveMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.SaveMode + "'");
 }
 
 if (objFileServerEN.ProjectName !=  null)
 {
 arrFieldListForInsert.Add(conFileServer.ProjectName);
 objFileServerEN.ProjectName = objFileServerEN.ProjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFileServerEN.ProjectName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileServer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewFileServerBySP(clsFileServerEN objFileServerEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objFileServerEN.FileContent,
 objFileServerEN.FileName,
 objFileServerEN.IsFree,
 objFileServerEN.FileSize,
 objFileServerEN.FileType,
 objFileServerEN.SaveDate,
 objFileServerEN.LastWriteTime,
 objFileServerEN.IdFtpResource,
 objFileServerEN.id_ResourceType,
 objFileServerEN.SaveMode,
objFileServerEN.ProjectName
};
 objSQL.ExecSP("FileServer_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFileServers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where id_FileId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FileServer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngid_FileId = TransNullToInt(oRow[conFileServer.id_FileId].ToString().Trim());
if (IsExist(lngid_FileId))
{
 string strResult = "关键字变量值为:" + string.Format("id_FileId = {0}", lngid_FileId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFileServerEN._CurrTabName ].NewRow();
objRow[conFileServer.FileContent] = oRow[conFileServer.FileContent].ToString().Trim(); //文件内容
objRow[conFileServer.FileName] = oRow[conFileServer.FileName].ToString().Trim(); //文件名
objRow[conFileServer.IsFree] = oRow[conFileServer.IsFree].ToString().Trim(); //是否释放
objRow[conFileServer.FileSize] = oRow[conFileServer.FileSize].ToString().Trim(); //文件大小
objRow[conFileServer.FileType] = oRow[conFileServer.FileType].ToString().Trim(); //文件类型
objRow[conFileServer.SaveDate] = oRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objRow[conFileServer.LastWriteTime] = oRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objRow[conFileServer.IdFtpResource] = oRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objRow[conFileServer.id_ResourceType] = oRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objRow[conFileServer.SaveMode] = oRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objRow[conFileServer.ProjectName] = oRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
 objDS.Tables[clsFileServerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFileServerEN._CurrTabName);
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
 /// <param name = "objFileServerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFileServerEN objFileServerEN)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
strSQL = "Select * from FileServer where id_FileId = " + ""+ objFileServerEN.id_FileId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFileServerEN._CurrTabName);
if (objDS.Tables[clsFileServerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:id_FileId = " + ""+ objFileServerEN.id_FileId+"");
return false;
}
objRow = objDS.Tables[clsFileServerEN._CurrTabName].Rows[0];
 if (objFileServerEN.IsUpdated(conFileServer.FileContent))
 {
objRow[conFileServer.FileContent] = objFileServerEN.FileContent; //文件内容
 }
 if (objFileServerEN.IsUpdated(conFileServer.FileName))
 {
objRow[conFileServer.FileName] = objFileServerEN.FileName; //文件名
 }
 if (objFileServerEN.IsUpdated(conFileServer.IsFree))
 {
objRow[conFileServer.IsFree] = objFileServerEN.IsFree; //是否释放
 }
 if (objFileServerEN.IsUpdated(conFileServer.FileSize))
 {
objRow[conFileServer.FileSize] = objFileServerEN.FileSize; //文件大小
 }
 if (objFileServerEN.IsUpdated(conFileServer.FileType))
 {
objRow[conFileServer.FileType] = objFileServerEN.FileType; //文件类型
 }
 if (objFileServerEN.IsUpdated(conFileServer.SaveDate))
 {
objRow[conFileServer.SaveDate] = objFileServerEN.SaveDate; //保存日期
 }
 if (objFileServerEN.IsUpdated(conFileServer.LastWriteTime))
 {
objRow[conFileServer.LastWriteTime] = objFileServerEN.LastWriteTime; //修改日期
 }
 if (objFileServerEN.IsUpdated(conFileServer.IdFtpResource))
 {
objRow[conFileServer.IdFtpResource] = objFileServerEN.IdFtpResource; //FTP资源流水号
 }
 if (objFileServerEN.IsUpdated(conFileServer.id_ResourceType))
 {
objRow[conFileServer.id_ResourceType] = objFileServerEN.id_ResourceType; //资源类型流水号
 }
 if (objFileServerEN.IsUpdated(conFileServer.SaveMode))
 {
objRow[conFileServer.SaveMode] = objFileServerEN.SaveMode; //文件存放方式
 }
 if (objFileServerEN.IsUpdated(conFileServer.ProjectName))
 {
objRow[conFileServer.ProjectName] = objFileServerEN.ProjectName; //项目名称
 }
try
{
objDA.Update(objDS, clsFileServerEN._CurrTabName);
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
public bool UpdateBySP(clsFileServerEN objFileServerEN)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objFileServerEN.id_FileId,
 objFileServerEN.FileContent,
 objFileServerEN.FileName,
 objFileServerEN.IsFree,
 objFileServerEN.FileSize,
 objFileServerEN.FileType,
 objFileServerEN.SaveDate,
 objFileServerEN.LastWriteTime,
 objFileServerEN.IdFtpResource,
 objFileServerEN.id_ResourceType,
 objFileServerEN.SaveMode,
 objFileServerEN.ProjectName
};
 objSQL.ExecSP("FileServer_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFileServerEN objFileServerEN)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FileServer Set ");
 
 if (objFileServerEN.IsUpdated(conFileServer.FileContent))
 {
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.FileContent, conFileServer.FileContent); //文件内容
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileName))
 {
 if (objFileServerEN.FileName !=  null)
 {
 objFileServerEN.FileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.FileName, conFileServer.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileName); //文件名
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.IsFree))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFileServerEN.IsFree == true?"1":"0", conFileServer.IsFree); //是否释放
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileSize))
 {
 sbSQL.AppendFormat("{1} = {0},",objFileServerEN.FileSize, conFileServer.FileSize); //文件大小
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileType))
 {
 if (objFileServerEN.FileType !=  null)
 {
 objFileServerEN.FileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.FileType, conFileServer.FileType); //文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileType); //文件类型
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveDate))
 {
 if (objFileServerEN.SaveDate !=  null)
 {
 objFileServerEN.SaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.SaveDate, conFileServer.SaveDate); //保存日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.SaveDate); //保存日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.LastWriteTime))
 {
 if (objFileServerEN.LastWriteTime !=  null)
 {
 objFileServerEN.LastWriteTime = objFileServerEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.LastWriteTime, conFileServer.LastWriteTime); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.LastWriteTime); //修改日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.IdFtpResource))
 {
 if (objFileServerEN.IdFtpResource !=  null)
 {
 objFileServerEN.IdFtpResource = objFileServerEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.IdFtpResource, conFileServer.IdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.IdFtpResource); //FTP资源流水号
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.id_ResourceType))
 {
 if (objFileServerEN.id_ResourceType !=  null)
 {
 objFileServerEN.id_ResourceType = objFileServerEN.id_ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.id_ResourceType, conFileServer.id_ResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.id_ResourceType); //资源类型流水号
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveMode))
 {
 if (objFileServerEN.SaveMode !=  null)
 {
 objFileServerEN.SaveMode = objFileServerEN.SaveMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.SaveMode, conFileServer.SaveMode); //文件存放方式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.SaveMode); //文件存放方式
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.ProjectName))
 {
 if (objFileServerEN.ProjectName !=  null)
 {
 objFileServerEN.ProjectName = objFileServerEN.ProjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.ProjectName, conFileServer.ProjectName); //项目名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.ProjectName); //项目名称
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where id_FileId = {0}", objFileServerEN.id_FileId); 
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
 /// <param name = "objFileServerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFileServerEN objFileServerEN, string strCondition)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FileServer Set ");
 
 if (objFileServerEN.IsUpdated(conFileServer.FileContent))
 {
 sbSQL.AppendFormat(" FileContent = '{0}',", objFileServerEN.FileContent); //文件内容
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileName))
 {
 if (objFileServerEN.FileName !=  null)
 {
 objFileServerEN.FileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", objFileServerEN.FileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.IsFree))
 {
 sbSQL.AppendFormat(" IsFree = '{0}',", objFileServerEN.IsFree == true?"1":"0"); //是否释放
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objFileServerEN.FileSize); //文件大小
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileType))
 {
 if (objFileServerEN.FileType !=  null)
 {
 objFileServerEN.FileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileType = '{0}',", objFileServerEN.FileType); //文件类型
 }
 else
 {
 sbSQL.Append(" FileType = null,"); //文件类型
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveDate))
 {
 if (objFileServerEN.SaveDate !=  null)
 {
 objFileServerEN.SaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SaveDate = '{0}',", objFileServerEN.SaveDate); //保存日期
 }
 else
 {
 sbSQL.Append(" SaveDate = null,"); //保存日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.LastWriteTime))
 {
 if (objFileServerEN.LastWriteTime !=  null)
 {
 objFileServerEN.LastWriteTime = objFileServerEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastWriteTime = '{0}',", objFileServerEN.LastWriteTime); //修改日期
 }
 else
 {
 sbSQL.Append(" LastWriteTime = null,"); //修改日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.IdFtpResource))
 {
 if (objFileServerEN.IdFtpResource !=  null)
 {
 objFileServerEN.IdFtpResource = objFileServerEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdFtpResource = '{0}',", objFileServerEN.IdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.Append(" IdFtpResource = null,"); //FTP资源流水号
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.id_ResourceType))
 {
 if (objFileServerEN.id_ResourceType !=  null)
 {
 objFileServerEN.id_ResourceType = objFileServerEN.id_ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" id_ResourceType = '{0}',", objFileServerEN.id_ResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.Append(" id_ResourceType = null,"); //资源类型流水号
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveMode))
 {
 if (objFileServerEN.SaveMode !=  null)
 {
 objFileServerEN.SaveMode = objFileServerEN.SaveMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SaveMode = '{0}',", objFileServerEN.SaveMode); //文件存放方式
 }
 else
 {
 sbSQL.Append(" SaveMode = null,"); //文件存放方式
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.ProjectName))
 {
 if (objFileServerEN.ProjectName !=  null)
 {
 objFileServerEN.ProjectName = objFileServerEN.ProjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProjectName = '{0}',", objFileServerEN.ProjectName); //项目名称
 }
 else
 {
 sbSQL.Append(" ProjectName = null,"); //项目名称
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
 /// <param name = "objFileServerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFileServerEN objFileServerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FileServer Set ");
 
 if (objFileServerEN.IsUpdated(conFileServer.FileContent))
 {
 sbSQL.AppendFormat(" FileContent = '{0}',", objFileServerEN.FileContent); //文件内容
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileName))
 {
 if (objFileServerEN.FileName !=  null)
 {
 objFileServerEN.FileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", objFileServerEN.FileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.IsFree))
 {
 sbSQL.AppendFormat(" IsFree = '{0}',", objFileServerEN.IsFree == true?"1":"0"); //是否释放
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objFileServerEN.FileSize); //文件大小
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileType))
 {
 if (objFileServerEN.FileType !=  null)
 {
 objFileServerEN.FileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileType = '{0}',", objFileServerEN.FileType); //文件类型
 }
 else
 {
 sbSQL.Append(" FileType = null,"); //文件类型
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveDate))
 {
 if (objFileServerEN.SaveDate !=  null)
 {
 objFileServerEN.SaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SaveDate = '{0}',", objFileServerEN.SaveDate); //保存日期
 }
 else
 {
 sbSQL.Append(" SaveDate = null,"); //保存日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.LastWriteTime))
 {
 if (objFileServerEN.LastWriteTime !=  null)
 {
 objFileServerEN.LastWriteTime = objFileServerEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastWriteTime = '{0}',", objFileServerEN.LastWriteTime); //修改日期
 }
 else
 {
 sbSQL.Append(" LastWriteTime = null,"); //修改日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.IdFtpResource))
 {
 if (objFileServerEN.IdFtpResource !=  null)
 {
 objFileServerEN.IdFtpResource = objFileServerEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdFtpResource = '{0}',", objFileServerEN.IdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.Append(" IdFtpResource = null,"); //FTP资源流水号
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.id_ResourceType))
 {
 if (objFileServerEN.id_ResourceType !=  null)
 {
 objFileServerEN.id_ResourceType = objFileServerEN.id_ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" id_ResourceType = '{0}',", objFileServerEN.id_ResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.Append(" id_ResourceType = null,"); //资源类型流水号
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveMode))
 {
 if (objFileServerEN.SaveMode !=  null)
 {
 objFileServerEN.SaveMode = objFileServerEN.SaveMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SaveMode = '{0}',", objFileServerEN.SaveMode); //文件存放方式
 }
 else
 {
 sbSQL.Append(" SaveMode = null,"); //文件存放方式
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.ProjectName))
 {
 if (objFileServerEN.ProjectName !=  null)
 {
 objFileServerEN.ProjectName = objFileServerEN.ProjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProjectName = '{0}',", objFileServerEN.ProjectName); //项目名称
 }
 else
 {
 sbSQL.Append(" ProjectName = null,"); //项目名称
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFileServerEN objFileServerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFileServerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileServerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FileServer Set ");
 
 if (objFileServerEN.IsUpdated(conFileServer.FileContent))
 {
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.FileContent, conFileServer.FileContent); //文件内容
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileName))
 {
 if (objFileServerEN.FileName !=  null)
 {
 objFileServerEN.FileName = objFileServerEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.FileName, conFileServer.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileName); //文件名
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.IsFree))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFileServerEN.IsFree == true?"1":"0", conFileServer.IsFree); //是否释放
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileSize))
 {
 sbSQL.AppendFormat("{1} = {0},",objFileServerEN.FileSize, conFileServer.FileSize); //文件大小
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.FileType))
 {
 if (objFileServerEN.FileType !=  null)
 {
 objFileServerEN.FileType = objFileServerEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.FileType, conFileServer.FileType); //文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.FileType); //文件类型
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveDate))
 {
 if (objFileServerEN.SaveDate !=  null)
 {
 objFileServerEN.SaveDate = objFileServerEN.SaveDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.SaveDate, conFileServer.SaveDate); //保存日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.SaveDate); //保存日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.LastWriteTime))
 {
 if (objFileServerEN.LastWriteTime !=  null)
 {
 objFileServerEN.LastWriteTime = objFileServerEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.LastWriteTime, conFileServer.LastWriteTime); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.LastWriteTime); //修改日期
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.IdFtpResource))
 {
 if (objFileServerEN.IdFtpResource !=  null)
 {
 objFileServerEN.IdFtpResource = objFileServerEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.IdFtpResource, conFileServer.IdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.IdFtpResource); //FTP资源流水号
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.id_ResourceType))
 {
 if (objFileServerEN.id_ResourceType !=  null)
 {
 objFileServerEN.id_ResourceType = objFileServerEN.id_ResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.id_ResourceType, conFileServer.id_ResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.id_ResourceType); //资源类型流水号
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.SaveMode))
 {
 if (objFileServerEN.SaveMode !=  null)
 {
 objFileServerEN.SaveMode = objFileServerEN.SaveMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.SaveMode, conFileServer.SaveMode); //文件存放方式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.SaveMode); //文件存放方式
 }
 }
 
 if (objFileServerEN.IsUpdated(conFileServer.ProjectName))
 {
 if (objFileServerEN.ProjectName !=  null)
 {
 objFileServerEN.ProjectName = objFileServerEN.ProjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFileServerEN.ProjectName, conFileServer.ProjectName); //项目名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileServer.ProjectName); //项目名称
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where id_FileId = {0}", objFileServerEN.id_FileId); 
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
 /// <param name = "lngid_FileId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngid_FileId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngid_FileId,
};
 objSQL.ExecSP("FileServer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngid_FileId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngid_FileId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
//删除FileServer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FileServer where id_FileId = " + ""+ lngid_FileId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFileServer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
//删除FileServer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FileServer where id_FileId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngid_FileId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngid_FileId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
//删除FileServer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FileServer where id_FileId = " + ""+ lngid_FileId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFileServer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFileServerDA: DelFileServer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FileServer where " + strCondition ;
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
public bool DelFileServerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFileServerDA: DelFileServerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileServerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FileServer where " + strCondition ;
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
 /// <param name = "objFileServerENS">源对象</param>
 /// <param name = "objFileServerENT">目标对象</param>
public void CopyTo(clsFileServerEN objFileServerENS, clsFileServerEN objFileServerENT)
{
objFileServerENT.id_FileId = objFileServerENS.id_FileId; //文件流水号
objFileServerENT.FileContent = objFileServerENS.FileContent; //文件内容
objFileServerENT.FileName = objFileServerENS.FileName; //文件名
objFileServerENT.IsFree = objFileServerENS.IsFree; //是否释放
objFileServerENT.FileSize = objFileServerENS.FileSize; //文件大小
objFileServerENT.FileType = objFileServerENS.FileType; //文件类型
objFileServerENT.SaveDate = objFileServerENS.SaveDate; //保存日期
objFileServerENT.LastWriteTime = objFileServerENS.LastWriteTime; //修改日期
objFileServerENT.IdFtpResource = objFileServerENS.IdFtpResource; //FTP资源流水号
objFileServerENT.id_ResourceType = objFileServerENS.id_ResourceType; //资源类型流水号
objFileServerENT.SaveMode = objFileServerENS.SaveMode; //文件存放方式
objFileServerENT.ProjectName = objFileServerENS.ProjectName; //项目名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFileServerEN objFileServerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFileServerEN.FileName, conFileServer.FileName);
clsCheckSql.CheckFieldNotNull(objFileServerEN.id_ResourceType, conFileServer.id_ResourceType);
//检查字段长度
clsCheckSql.CheckFieldLen(objFileServerEN.FileName, 150, conFileServer.FileName);
clsCheckSql.CheckFieldLen(objFileServerEN.FileType, 30, conFileServer.FileType);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveDate, 25, conFileServer.SaveDate);
clsCheckSql.CheckFieldLen(objFileServerEN.LastWriteTime, 30, conFileServer.LastWriteTime);
clsCheckSql.CheckFieldLen(objFileServerEN.IdFtpResource, 8, conFileServer.IdFtpResource);
clsCheckSql.CheckFieldLen(objFileServerEN.id_ResourceType, 4, conFileServer.id_ResourceType);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveMode, 10, conFileServer.SaveMode);
clsCheckSql.CheckFieldLen(objFileServerEN.ProjectName, 100, conFileServer.ProjectName);
//检查字段外键固定长度
 objFileServerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFileServerEN objFileServerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFileServerEN.FileName, 150, conFileServer.FileName);
clsCheckSql.CheckFieldLen(objFileServerEN.FileType, 30, conFileServer.FileType);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveDate, 25, conFileServer.SaveDate);
clsCheckSql.CheckFieldLen(objFileServerEN.LastWriteTime, 30, conFileServer.LastWriteTime);
clsCheckSql.CheckFieldLen(objFileServerEN.IdFtpResource, 8, conFileServer.IdFtpResource);
clsCheckSql.CheckFieldLen(objFileServerEN.id_ResourceType, 4, conFileServer.id_ResourceType);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveMode, 10, conFileServer.SaveMode);
clsCheckSql.CheckFieldLen(objFileServerEN.ProjectName, 100, conFileServer.ProjectName);
//检查外键字段长度
 objFileServerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFileServerEN objFileServerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFileServerEN.FileName, 150, conFileServer.FileName);
clsCheckSql.CheckFieldLen(objFileServerEN.FileType, 30, conFileServer.FileType);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveDate, 25, conFileServer.SaveDate);
clsCheckSql.CheckFieldLen(objFileServerEN.LastWriteTime, 30, conFileServer.LastWriteTime);
clsCheckSql.CheckFieldLen(objFileServerEN.IdFtpResource, 8, conFileServer.IdFtpResource);
clsCheckSql.CheckFieldLen(objFileServerEN.id_ResourceType, 4, conFileServer.id_ResourceType);
clsCheckSql.CheckFieldLen(objFileServerEN.SaveMode, 10, conFileServer.SaveMode);
clsCheckSql.CheckFieldLen(objFileServerEN.ProjectName, 100, conFileServer.ProjectName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.FileName, conFileServer.FileName);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.FileType, conFileServer.FileType);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.SaveDate, conFileServer.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.LastWriteTime, conFileServer.LastWriteTime);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.IdFtpResource, conFileServer.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.id_ResourceType, conFileServer.id_ResourceType);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.SaveMode, conFileServer.SaveMode);
clsCheckSql.CheckSqlInjection4Field(objFileServerEN.ProjectName, conFileServer.ProjectName);
//检查外键字段长度
 objFileServerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FileServer(文件服务),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFileServerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStrProjectName_id_ResourceType_FileName(clsFileServerEN objFileServerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objFileServerEN.ProjectName == null)
{
 sbCondition.AppendFormat(" and ProjectName is null");
}
else
{
 sbCondition.AppendFormat(" and ProjectName = '{0}'", objFileServerEN.ProjectName);
}
 sbCondition.AppendFormat(" and id_ResourceType = '{0}'", objFileServerEN.id_ResourceType);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileServerEN.FileName);
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFileServerEN._CurrTabName);
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFileServerEN._CurrTabName, strCondition);
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
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
 objSQL = clsFileServerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}