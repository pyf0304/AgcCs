
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFtpResourceDA
 表名:FtpResource(00050210)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:23
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
 /// FTP资源(FtpResource)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsFtpResourceDA : clsCommBase4DA
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
 return clsFtpResourceEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFtpResourceEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFtpResourceEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFtpResourceEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFtpResourceEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdFtpResource">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdFtpResource)
{
strIdFtpResource = strIdFtpResource.Replace("'", "''");
if (strIdFtpResource.Length > 8)
{
throw new Exception("(errid:Data000001)在表:FtpResource中,检查关键字,长度不正确!(clsFtpResourceDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdFtpResource)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FtpResource中,关键字不能为空 或 null!(clsFtpResourceDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdFtpResource);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFtpResourceDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strIdFtpResource">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strIdFtpResource)
{
strIdFtpResource = strIdFtpResource.Replace("'", "''");
if (strIdFtpResource.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:FtpResource中,检查关键字,长度不正确!(简化版)(clsFtpResourceDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdFtpResource)  ==  true)
{
throw new Exception("(errid:Data000005)在表:FtpResource中,关键字不能为空 或 null!(clsFtpResourceDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdFtpResource);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsFtpResourceDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 strSQL = "Select * from FtpResource where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "FtpResource");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("FtpResource_SelectByCond",values, "FtpResource");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FtpResource where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "FtpResource");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FtpResource a where {0} And a.IdFtpResource not in (Select Top {2} IdFtpResource From FtpResource Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FtpResource");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FtpResource a where {0} And a.IdFtpResource not in (Select Top {2} IdFtpResource From FtpResource Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FtpResource");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FtpResource a where {0} And a.IdFtpResource not in (Select Top {2} IdFtpResource From FtpResource Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FtpResource");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FtpResource(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTable_FtpResource)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FtpResource where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FtpResource where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FtpResource where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FtpResource where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FtpResource.* from FtpResource Left Join {1} on {2} where {3} and FtpResource.IdFtpResource not in (Select top {5} FtpResource.IdFtpResource from FtpResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FtpResource where {1} and IdFtpResource not in (Select top {2} IdFtpResource from FtpResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FtpResource where {1} and IdFtpResource not in (Select top {3} IdFtpResource from FtpResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FtpResource.* from FtpResource Left Join {1} on {2} where {3} and FtpResource.IdFtpResource not in (Select top {5} FtpResource.IdFtpResource from FtpResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FtpResource where {1} and IdFtpResource not in (Select top {2} IdFtpResource from FtpResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FtpResource where {1} and IdFtpResource not in (Select top {3} IdFtpResource from FtpResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FtpResource.* from FtpResource Left Join {1} on {2} where {3} and FtpResource.IdFtpResource not in (Select top {5} FtpResource.IdFtpResource from FtpResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FtpResource where {1} and IdFtpResource not in (Select top {2} IdFtpResource from FtpResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FtpResource where {1} and IdFtpResource not in (Select top {3} IdFtpResource from FtpResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from FtpResource a where {0} And a.IdFtpResource not in (Select Top {2} IdFtpResource From FtpResource Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from FtpResource a where {0} And a.IdFtpResource not in (Select Top {2} IdFtpResource From FtpResource Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from FtpResource a where {0} And a.IdFtpResource not in (Select Top {2} IdFtpResource From FtpResource Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from FtpResource a where {0} And a.IdFtpResource not in (Select Top {2} IdFtpResource From FtpResource Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFtpResourceDA: GetFtpResourceByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FtpResource_SelectByCond",values);
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
public List<clsFtpResourceEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFtpResourceDA:GetObjLst)", objException.Message));
}
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.ftpServerIP = objRow[conFtpResource.ftpServerIP].ToString().Trim(); //ftp服务器地址
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFtpResource.FileSize].ToString().Trim()); //文件大小
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //创建者
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFtpResourceDA: GetObjLst)", objException.Message));
}
objFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFtpResourceEN);
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
public List<clsFtpResourceEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFtpResourceDA:GetObjLstByTabName)", objException.Message));
}
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.ftpServerIP = objRow[conFtpResource.ftpServerIP].ToString().Trim(); //ftp服务器地址
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFtpResource.FileSize].ToString().Trim()); //文件大小
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //创建者
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFtpResourceDA: GetObjLst)", objException.Message));
}
objFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFtpResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsFtpResourceEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsFtpResourceDA:GetObjLstBySP)", objException.Message));
}
List<clsFtpResourceEN> arrObjLst = new List<clsFtpResourceEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FtpResource_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.ftpServerIP = objRow[conFtpResource.ftpServerIP].ToString().Trim(); //ftp服务器地址
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFtpResource.FileSize].ToString().Trim()); //文件大小
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //创建者
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsFtpResourceDA: GetObjLstBySP)", objException.Message));
}
objFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFtpResourceEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFtpResource(ref clsFtpResourceEN objFtpResourceEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where IdFtpResource = " + "'"+ objFtpResourceEN.IdFtpResource+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFtpResourceEN.IdFtpResource = objDT.Rows[0][conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objFtpResourceEN.FtpResourceID = objDT.Rows[0][conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objFtpResourceEN.FileOriginalName = objDT.Rows[0][conFtpResource.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objFtpResourceEN.ftpServerIP = objDT.Rows[0][conFtpResource.ftpServerIP].ToString().Trim(); //ftp服务器地址(字段类型:varchar,字段长度:30,是否可空:False)
 objFtpResourceEN.FileDirName = objDT.Rows[0][conFtpResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objFtpResourceEN.FileRename = objDT.Rows[0][conFtpResource.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objFtpResourceEN.FileType = objDT.Rows[0][conFtpResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objFtpResourceEN.FileUpDate = objDT.Rows[0][conFtpResource.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objFtpResourceEN.FileUpTime = objDT.Rows[0][conFtpResource.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objFtpResourceEN.FileSize = TransNullToInt(objDT.Rows[0][conFtpResource.FileSize].ToString().Trim()); //文件大小(字段类型:bigint,字段长度:8,是否可空:True)
 objFtpResourceEN.ResourceOwner = objDT.Rows[0][conFtpResource.ResourceOwner].ToString().Trim(); //创建者(字段类型:varchar,字段长度:50,是否可空:True)
 objFtpResourceEN.Memo = objDT.Rows[0][conFtpResource.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFtpResourceDA: GetFtpResource)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdFtpResource">表关键字</param>
 /// <returns>表对象</returns>
public clsFtpResourceEN GetObjByIdFtpResource(string strIdFtpResource)
{
CheckPrimaryKey(strIdFtpResource);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where IdFtpResource = " + "'"+ strIdFtpResource+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
 objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objFtpResourceEN.ftpServerIP = objRow[conFtpResource.ftpServerIP].ToString().Trim(); //ftp服务器地址(字段类型:varchar,字段长度:30,是否可空:False)
 objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFtpResource.FileSize].ToString().Trim()); //文件大小(字段类型:bigint,字段长度:8,是否可空:True)
 objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //创建者(字段类型:varchar,字段长度:50,是否可空:True)
 objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFtpResourceDA: GetObjByIdFtpResource)", objException.Message));
}
return objFtpResourceEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程FtpResource_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFtpResourceOneBySP(clsFtpResourceEN objFtpResourceEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objFtpResourceEN.IdFtpResource
};
 objDT = objSQL.ExecSpReturnDT("FtpResource_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objFtpResourceEN.IdFtpResource = objDT.Rows[0][conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objFtpResourceEN.FtpResourceID = objDT.Rows[0][conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objFtpResourceEN.FileOriginalName = objDT.Rows[0][conFtpResource.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objFtpResourceEN.ftpServerIP = objDT.Rows[0][conFtpResource.ftpServerIP].ToString().Trim(); //ftp服务器地址(字段类型:varchar,字段长度:30,是否可空:False)
 objFtpResourceEN.FileDirName = objDT.Rows[0][conFtpResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objFtpResourceEN.FileRename = objDT.Rows[0][conFtpResource.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objFtpResourceEN.FileType = objDT.Rows[0][conFtpResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objFtpResourceEN.FileUpDate = objDT.Rows[0][conFtpResource.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objFtpResourceEN.FileUpTime = objDT.Rows[0][conFtpResource.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objFtpResourceEN.FileSize = TransNullToInt(objDT.Rows[0][conFtpResource.FileSize].ToString().Trim()); //文件大小(字段类型:bigint,字段长度:8,是否可空:True)
 objFtpResourceEN.ResourceOwner = objDT.Rows[0][conFtpResource.ResourceOwner].ToString().Trim(); //创建者(字段类型:varchar,字段长度:50,是否可空:True)
 objFtpResourceEN.Memo = objDT.Rows[0][conFtpResource.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFtpResourceEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFtpResourceDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN()
{
IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(), //文件原名
ftpServerIP = objRow[conFtpResource.ftpServerIP].ToString().Trim(), //ftp服务器地址
FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(), //文件新名
FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(), //文件类型
FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(), //创建时间
FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFtpResource.FileSize].ToString().Trim()), //文件大小
ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(), //创建者
Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim() //说明
};
objFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFtpResourceEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFtpResourceDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFtpResourceEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsFtpResourceDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FtpResource_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN()
{
IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(), //文件原名
ftpServerIP = objRow[conFtpResource.ftpServerIP].ToString().Trim(), //ftp服务器地址
FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(), //文件新名
FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(), //文件类型
FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(), //创建时间
FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFtpResource.FileSize].ToString().Trim()), //文件大小
ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(), //创建者
Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim() //说明
};
objFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFtpResourceEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFtpResourceEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.ftpServerIP = objRow[conFtpResource.ftpServerIP].ToString().Trim(); //ftp服务器地址
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFtpResource.FileSize].ToString().Trim()); //文件大小
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //创建者
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFtpResourceDA: GetObjByDataRowFtpResource)", objException.Message));
}
objFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFtpResourceEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFtpResourceEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFtpResourceEN objFtpResourceEN = new clsFtpResourceEN();
try
{
objFtpResourceEN.IdFtpResource = objRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFtpResourceEN.FtpResourceID = objRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objFtpResourceEN.FileOriginalName = objRow[conFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objFtpResourceEN.ftpServerIP = objRow[conFtpResource.ftpServerIP].ToString().Trim(); //ftp服务器地址
objFtpResourceEN.FileDirName = objRow[conFtpResource.FileDirName] == DBNull.Value ? null : objRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objFtpResourceEN.FileRename = objRow[conFtpResource.FileRename] == DBNull.Value ? null : objRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objFtpResourceEN.FileType = objRow[conFtpResource.FileType] == DBNull.Value ? null : objRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objFtpResourceEN.FileUpDate = objRow[conFtpResource.FileUpDate] == DBNull.Value ? null : objRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objFtpResourceEN.FileUpTime = objRow[conFtpResource.FileUpTime] == DBNull.Value ? null : objRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objFtpResourceEN.FileSize = objRow[conFtpResource.FileSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFtpResource.FileSize].ToString().Trim()); //文件大小
objFtpResourceEN.ResourceOwner = objRow[conFtpResource.ResourceOwner] == DBNull.Value ? null : objRow[conFtpResource.ResourceOwner].ToString().Trim(); //创建者
objFtpResourceEN.Memo = objRow[conFtpResource.Memo] == DBNull.Value ? null : objRow[conFtpResource.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFtpResourceDA: GetObjByDataRow)", objException.Message));
}
objFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFtpResourceEN;
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
objSQL = clsFtpResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFtpResourceEN._CurrTabName, conFtpResource.IdFtpResource, 8, "");
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
objSQL = clsFtpResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFtpResourceEN._CurrTabName, conFtpResource.IdFtpResource, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdFtpResource from FtpResource where " + strCondition;
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
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdFtpResource from FtpResource where " + strCondition;
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
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdFtpResource)
{
CheckPrimaryKey(strIdFtpResource);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FtpResource", "IdFtpResource = " + "'"+ strIdFtpResource+"'"))
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
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strIdFtpResource)
{
CheckPrimaryKey(strIdFtpResource);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strIdFtpResource,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("FtpResource_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFtpResourceDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FtpResource", strCondition))
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
objSQL = clsFtpResourceDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FtpResource");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFtpResourceEN objFtpResourceEN)
 {
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFtpResourceEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FtpResource");
objRow = objDS.Tables["FtpResource"].NewRow();
objRow[conFtpResource.IdFtpResource] = objFtpResourceEN.IdFtpResource; //FTP资源流水号
objRow[conFtpResource.FtpResourceID] = objFtpResourceEN.FtpResourceID; //FTP资源ID
 if (objFtpResourceEN.FileOriginalName !=  "")
 {
objRow[conFtpResource.FileOriginalName] = objFtpResourceEN.FileOriginalName; //文件原名
 }
objRow[conFtpResource.ftpServerIP] = objFtpResourceEN.ftpServerIP; //ftp服务器地址
 if (objFtpResourceEN.FileDirName !=  "")
 {
objRow[conFtpResource.FileDirName] = objFtpResourceEN.FileDirName; //文件目录名
 }
 if (objFtpResourceEN.FileRename !=  "")
 {
objRow[conFtpResource.FileRename] = objFtpResourceEN.FileRename; //文件新名
 }
 if (objFtpResourceEN.FileType !=  "")
 {
objRow[conFtpResource.FileType] = objFtpResourceEN.FileType; //文件类型
 }
 if (objFtpResourceEN.FileUpDate !=  "")
 {
objRow[conFtpResource.FileUpDate] = objFtpResourceEN.FileUpDate; //创建日期
 }
 if (objFtpResourceEN.FileUpTime !=  "")
 {
objRow[conFtpResource.FileUpTime] = objFtpResourceEN.FileUpTime; //创建时间
 }
objRow[conFtpResource.FileSize] = objFtpResourceEN.FileSize; //文件大小
 if (objFtpResourceEN.ResourceOwner !=  "")
 {
objRow[conFtpResource.ResourceOwner] = objFtpResourceEN.ResourceOwner; //创建者
 }
 if (objFtpResourceEN.Memo !=  "")
 {
objRow[conFtpResource.Memo] = objFtpResourceEN.Memo; //说明
 }
objDS.Tables[clsFtpResourceEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFtpResourceEN._CurrTabName);
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
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFtpResourceEN objFtpResourceEN)
{
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFtpResourceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFtpResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.IdFtpResource);
 objFtpResourceEN.IdFtpResource = objFtpResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.IdFtpResource + "'");
 }
 
 if (objFtpResourceEN.FtpResourceID !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FtpResourceID);
 objFtpResourceEN.FtpResourceID = objFtpResourceEN.FtpResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FtpResourceID + "'");
 }
 
 if (objFtpResourceEN.FileOriginalName !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileOriginalName);
 objFtpResourceEN.FileOriginalName = objFtpResourceEN.FileOriginalName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileOriginalName + "'");
 }
 
 if (objFtpResourceEN.ftpServerIP !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.ftpServerIP);
 objFtpResourceEN.ftpServerIP = objFtpResourceEN.ftpServerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.ftpServerIP + "'");
 }
 
 if (objFtpResourceEN.FileDirName !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileDirName);
 objFtpResourceEN.FileDirName = objFtpResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileDirName + "'");
 }
 
 if (objFtpResourceEN.FileRename !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileRename);
 objFtpResourceEN.FileRename = objFtpResourceEN.FileRename.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileRename + "'");
 }
 
 if (objFtpResourceEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileType);
 objFtpResourceEN.FileType = objFtpResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileType + "'");
 }
 
 if (objFtpResourceEN.FileUpDate !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileUpDate);
 objFtpResourceEN.FileUpDate = objFtpResourceEN.FileUpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileUpDate + "'");
 }
 
 if (objFtpResourceEN.FileUpTime !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileUpTime);
 objFtpResourceEN.FileUpTime = objFtpResourceEN.FileUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileUpTime + "'");
 }
 
 arrFieldListForInsert.Add(conFtpResource.FileSize);
 arrValueListForInsert.Add(objFtpResourceEN.FileSize.ToString());
 
 if (objFtpResourceEN.ResourceOwner !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.ResourceOwner);
 objFtpResourceEN.ResourceOwner = objFtpResourceEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.ResourceOwner + "'");
 }
 
 if (objFtpResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.Memo);
 objFtpResourceEN.Memo = objFtpResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FtpResource");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFtpResourceEN objFtpResourceEN)
{
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFtpResourceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFtpResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.IdFtpResource);
 objFtpResourceEN.IdFtpResource = objFtpResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.IdFtpResource + "'");
 }
 
 if (objFtpResourceEN.FtpResourceID !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FtpResourceID);
 objFtpResourceEN.FtpResourceID = objFtpResourceEN.FtpResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FtpResourceID + "'");
 }
 
 if (objFtpResourceEN.FileOriginalName !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileOriginalName);
 objFtpResourceEN.FileOriginalName = objFtpResourceEN.FileOriginalName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileOriginalName + "'");
 }
 
 if (objFtpResourceEN.ftpServerIP !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.ftpServerIP);
 objFtpResourceEN.ftpServerIP = objFtpResourceEN.ftpServerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.ftpServerIP + "'");
 }
 
 if (objFtpResourceEN.FileDirName !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileDirName);
 objFtpResourceEN.FileDirName = objFtpResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileDirName + "'");
 }
 
 if (objFtpResourceEN.FileRename !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileRename);
 objFtpResourceEN.FileRename = objFtpResourceEN.FileRename.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileRename + "'");
 }
 
 if (objFtpResourceEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileType);
 objFtpResourceEN.FileType = objFtpResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileType + "'");
 }
 
 if (objFtpResourceEN.FileUpDate !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileUpDate);
 objFtpResourceEN.FileUpDate = objFtpResourceEN.FileUpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileUpDate + "'");
 }
 
 if (objFtpResourceEN.FileUpTime !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileUpTime);
 objFtpResourceEN.FileUpTime = objFtpResourceEN.FileUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileUpTime + "'");
 }
 
 arrFieldListForInsert.Add(conFtpResource.FileSize);
 arrValueListForInsert.Add(objFtpResourceEN.FileSize.ToString());
 
 if (objFtpResourceEN.ResourceOwner !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.ResourceOwner);
 objFtpResourceEN.ResourceOwner = objFtpResourceEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.ResourceOwner + "'");
 }
 
 if (objFtpResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.Memo);
 objFtpResourceEN.Memo = objFtpResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FtpResource");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFtpResourceEN.IdFtpResource;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFtpResourceEN objFtpResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFtpResourceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFtpResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.IdFtpResource);
 objFtpResourceEN.IdFtpResource = objFtpResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.IdFtpResource + "'");
 }
 
 if (objFtpResourceEN.FtpResourceID !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FtpResourceID);
 objFtpResourceEN.FtpResourceID = objFtpResourceEN.FtpResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FtpResourceID + "'");
 }
 
 if (objFtpResourceEN.FileOriginalName !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileOriginalName);
 objFtpResourceEN.FileOriginalName = objFtpResourceEN.FileOriginalName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileOriginalName + "'");
 }
 
 if (objFtpResourceEN.ftpServerIP !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.ftpServerIP);
 objFtpResourceEN.ftpServerIP = objFtpResourceEN.ftpServerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.ftpServerIP + "'");
 }
 
 if (objFtpResourceEN.FileDirName !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileDirName);
 objFtpResourceEN.FileDirName = objFtpResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileDirName + "'");
 }
 
 if (objFtpResourceEN.FileRename !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileRename);
 objFtpResourceEN.FileRename = objFtpResourceEN.FileRename.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileRename + "'");
 }
 
 if (objFtpResourceEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileType);
 objFtpResourceEN.FileType = objFtpResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileType + "'");
 }
 
 if (objFtpResourceEN.FileUpDate !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileUpDate);
 objFtpResourceEN.FileUpDate = objFtpResourceEN.FileUpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileUpDate + "'");
 }
 
 if (objFtpResourceEN.FileUpTime !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileUpTime);
 objFtpResourceEN.FileUpTime = objFtpResourceEN.FileUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileUpTime + "'");
 }
 
 arrFieldListForInsert.Add(conFtpResource.FileSize);
 arrValueListForInsert.Add(objFtpResourceEN.FileSize.ToString());
 
 if (objFtpResourceEN.ResourceOwner !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.ResourceOwner);
 objFtpResourceEN.ResourceOwner = objFtpResourceEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.ResourceOwner + "'");
 }
 
 if (objFtpResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.Memo);
 objFtpResourceEN.Memo = objFtpResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FtpResource");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFtpResourceEN.IdFtpResource;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFtpResourceEN objFtpResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFtpResourceEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFtpResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.IdFtpResource);
 objFtpResourceEN.IdFtpResource = objFtpResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.IdFtpResource + "'");
 }
 
 if (objFtpResourceEN.FtpResourceID !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FtpResourceID);
 objFtpResourceEN.FtpResourceID = objFtpResourceEN.FtpResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FtpResourceID + "'");
 }
 
 if (objFtpResourceEN.FileOriginalName !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileOriginalName);
 objFtpResourceEN.FileOriginalName = objFtpResourceEN.FileOriginalName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileOriginalName + "'");
 }
 
 if (objFtpResourceEN.ftpServerIP !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.ftpServerIP);
 objFtpResourceEN.ftpServerIP = objFtpResourceEN.ftpServerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.ftpServerIP + "'");
 }
 
 if (objFtpResourceEN.FileDirName !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileDirName);
 objFtpResourceEN.FileDirName = objFtpResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileDirName + "'");
 }
 
 if (objFtpResourceEN.FileRename !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileRename);
 objFtpResourceEN.FileRename = objFtpResourceEN.FileRename.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileRename + "'");
 }
 
 if (objFtpResourceEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileType);
 objFtpResourceEN.FileType = objFtpResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileType + "'");
 }
 
 if (objFtpResourceEN.FileUpDate !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileUpDate);
 objFtpResourceEN.FileUpDate = objFtpResourceEN.FileUpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileUpDate + "'");
 }
 
 if (objFtpResourceEN.FileUpTime !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.FileUpTime);
 objFtpResourceEN.FileUpTime = objFtpResourceEN.FileUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.FileUpTime + "'");
 }
 
 arrFieldListForInsert.Add(conFtpResource.FileSize);
 arrValueListForInsert.Add(objFtpResourceEN.FileSize.ToString());
 
 if (objFtpResourceEN.ResourceOwner !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.ResourceOwner);
 objFtpResourceEN.ResourceOwner = objFtpResourceEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.ResourceOwner + "'");
 }
 
 if (objFtpResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFtpResource.Memo);
 objFtpResourceEN.Memo = objFtpResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFtpResourceEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FtpResource");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewFtpResourceBySP(clsFtpResourceEN objFtpResourceEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objFtpResourceEN.IdFtpResource,
 objFtpResourceEN.FtpResourceID,
 objFtpResourceEN.FileOriginalName,
 objFtpResourceEN.ftpServerIP,
 objFtpResourceEN.FileDirName,
 objFtpResourceEN.FileRename,
 objFtpResourceEN.FileType,
 objFtpResourceEN.FileUpDate,
 objFtpResourceEN.FileUpTime,
 objFtpResourceEN.FileSize,
 objFtpResourceEN.ResourceOwner,
objFtpResourceEN.Memo
};
 objSQL.ExecSP("FtpResource_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFtpResources(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where IdFtpResource = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FtpResource");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdFtpResource = oRow[conFtpResource.IdFtpResource].ToString().Trim();
if (IsExist(strIdFtpResource))
{
 string strResult = "关键字变量值为:" + string.Format("IdFtpResource = {0}", strIdFtpResource) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFtpResourceEN._CurrTabName ].NewRow();
objRow[conFtpResource.IdFtpResource] = oRow[conFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objRow[conFtpResource.FtpResourceID] = oRow[conFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objRow[conFtpResource.FileOriginalName] = oRow[conFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objRow[conFtpResource.ftpServerIP] = oRow[conFtpResource.ftpServerIP].ToString().Trim(); //ftp服务器地址
objRow[conFtpResource.FileDirName] = oRow[conFtpResource.FileDirName].ToString().Trim(); //文件目录名
objRow[conFtpResource.FileRename] = oRow[conFtpResource.FileRename].ToString().Trim(); //文件新名
objRow[conFtpResource.FileType] = oRow[conFtpResource.FileType].ToString().Trim(); //文件类型
objRow[conFtpResource.FileUpDate] = oRow[conFtpResource.FileUpDate].ToString().Trim(); //创建日期
objRow[conFtpResource.FileUpTime] = oRow[conFtpResource.FileUpTime].ToString().Trim(); //创建时间
objRow[conFtpResource.FileSize] = oRow[conFtpResource.FileSize].ToString().Trim(); //文件大小
objRow[conFtpResource.ResourceOwner] = oRow[conFtpResource.ResourceOwner].ToString().Trim(); //创建者
objRow[conFtpResource.Memo] = oRow[conFtpResource.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFtpResourceEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFtpResourceEN._CurrTabName);
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
 /// <param name = "objFtpResourceEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFtpResourceEN objFtpResourceEN)
{
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFtpResourceEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from FtpResource where IdFtpResource = " + "'"+ objFtpResourceEN.IdFtpResource+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFtpResourceEN._CurrTabName);
if (objDS.Tables[clsFtpResourceEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdFtpResource = " + "'"+ objFtpResourceEN.IdFtpResource+"'");
return false;
}
objRow = objDS.Tables[clsFtpResourceEN._CurrTabName].Rows[0];
 if (objFtpResourceEN.IsUpdated(conFtpResource.IdFtpResource))
 {
objRow[conFtpResource.IdFtpResource] = objFtpResourceEN.IdFtpResource; //FTP资源流水号
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.FtpResourceID))
 {
objRow[conFtpResource.FtpResourceID] = objFtpResourceEN.FtpResourceID; //FTP资源ID
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileOriginalName))
 {
objRow[conFtpResource.FileOriginalName] = objFtpResourceEN.FileOriginalName; //文件原名
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.ftpServerIP))
 {
objRow[conFtpResource.ftpServerIP] = objFtpResourceEN.ftpServerIP; //ftp服务器地址
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileDirName))
 {
objRow[conFtpResource.FileDirName] = objFtpResourceEN.FileDirName; //文件目录名
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileRename))
 {
objRow[conFtpResource.FileRename] = objFtpResourceEN.FileRename; //文件新名
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileType))
 {
objRow[conFtpResource.FileType] = objFtpResourceEN.FileType; //文件类型
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileUpDate))
 {
objRow[conFtpResource.FileUpDate] = objFtpResourceEN.FileUpDate; //创建日期
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileUpTime))
 {
objRow[conFtpResource.FileUpTime] = objFtpResourceEN.FileUpTime; //创建时间
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileSize))
 {
objRow[conFtpResource.FileSize] = objFtpResourceEN.FileSize; //文件大小
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.ResourceOwner))
 {
objRow[conFtpResource.ResourceOwner] = objFtpResourceEN.ResourceOwner; //创建者
 }
 if (objFtpResourceEN.IsUpdated(conFtpResource.Memo))
 {
objRow[conFtpResource.Memo] = objFtpResourceEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFtpResourceEN._CurrTabName);
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
public bool UpdateBySP(clsFtpResourceEN objFtpResourceEN)
{
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFtpResourceEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objFtpResourceEN.IdFtpResource,
 objFtpResourceEN.FtpResourceID,
 objFtpResourceEN.FileOriginalName,
 objFtpResourceEN.ftpServerIP,
 objFtpResourceEN.FileDirName,
 objFtpResourceEN.FileRename,
 objFtpResourceEN.FileType,
 objFtpResourceEN.FileUpDate,
 objFtpResourceEN.FileUpTime,
 objFtpResourceEN.FileSize,
 objFtpResourceEN.ResourceOwner,
 objFtpResourceEN.Memo
};
 objSQL.ExecSP("FtpResource_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFtpResourceEN objFtpResourceEN)
{
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFtpResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FtpResource Set ");
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FtpResourceID))
 {
 if (objFtpResourceEN.FtpResourceID !=  null)
 {
 objFtpResourceEN.FtpResourceID = objFtpResourceEN.FtpResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FtpResourceID, conFtpResource.FtpResourceID); //FTP资源ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FtpResourceID); //FTP资源ID
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileOriginalName))
 {
 if (objFtpResourceEN.FileOriginalName !=  null)
 {
 objFtpResourceEN.FileOriginalName = objFtpResourceEN.FileOriginalName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileOriginalName, conFtpResource.FileOriginalName); //文件原名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileOriginalName); //文件原名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.ftpServerIP))
 {
 if (objFtpResourceEN.ftpServerIP !=  null)
 {
 objFtpResourceEN.ftpServerIP = objFtpResourceEN.ftpServerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.ftpServerIP, conFtpResource.ftpServerIP); //ftp服务器地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.ftpServerIP); //ftp服务器地址
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileDirName))
 {
 if (objFtpResourceEN.FileDirName !=  null)
 {
 objFtpResourceEN.FileDirName = objFtpResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileDirName, conFtpResource.FileDirName); //文件目录名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileDirName); //文件目录名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileRename))
 {
 if (objFtpResourceEN.FileRename !=  null)
 {
 objFtpResourceEN.FileRename = objFtpResourceEN.FileRename.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileRename, conFtpResource.FileRename); //文件新名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileRename); //文件新名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileType))
 {
 if (objFtpResourceEN.FileType !=  null)
 {
 objFtpResourceEN.FileType = objFtpResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileType, conFtpResource.FileType); //文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileType); //文件类型
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileUpDate))
 {
 if (objFtpResourceEN.FileUpDate !=  null)
 {
 objFtpResourceEN.FileUpDate = objFtpResourceEN.FileUpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileUpDate, conFtpResource.FileUpDate); //创建日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileUpDate); //创建日期
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileUpTime))
 {
 if (objFtpResourceEN.FileUpTime !=  null)
 {
 objFtpResourceEN.FileUpTime = objFtpResourceEN.FileUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileUpTime, conFtpResource.FileUpTime); //创建时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileUpTime); //创建时间
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileSize))
 {
 sbSQL.AppendFormat("{1} = {0},",objFtpResourceEN.FileSize, conFtpResource.FileSize); //文件大小
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.ResourceOwner))
 {
 if (objFtpResourceEN.ResourceOwner !=  null)
 {
 objFtpResourceEN.ResourceOwner = objFtpResourceEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.ResourceOwner, conFtpResource.ResourceOwner); //创建者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.ResourceOwner); //创建者
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.Memo))
 {
 if (objFtpResourceEN.Memo !=  null)
 {
 objFtpResourceEN.Memo = objFtpResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.Memo, conFtpResource.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdFtpResource = '{0}'", objFtpResourceEN.IdFtpResource); 
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
 /// <param name = "objFtpResourceEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFtpResourceEN objFtpResourceEN, string strCondition)
{
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFtpResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FtpResource Set ");
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FtpResourceID))
 {
 if (objFtpResourceEN.FtpResourceID !=  null)
 {
 objFtpResourceEN.FtpResourceID = objFtpResourceEN.FtpResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FtpResourceID = '{0}',", objFtpResourceEN.FtpResourceID); //FTP资源ID
 }
 else
 {
 sbSQL.Append(" FtpResourceID = null,"); //FTP资源ID
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileOriginalName))
 {
 if (objFtpResourceEN.FileOriginalName !=  null)
 {
 objFtpResourceEN.FileOriginalName = objFtpResourceEN.FileOriginalName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileOriginalName = '{0}',", objFtpResourceEN.FileOriginalName); //文件原名
 }
 else
 {
 sbSQL.Append(" FileOriginalName = null,"); //文件原名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.ftpServerIP))
 {
 if (objFtpResourceEN.ftpServerIP !=  null)
 {
 objFtpResourceEN.ftpServerIP = objFtpResourceEN.ftpServerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpServerIP = '{0}',", objFtpResourceEN.ftpServerIP); //ftp服务器地址
 }
 else
 {
 sbSQL.Append(" ftpServerIP = null,"); //ftp服务器地址
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileDirName))
 {
 if (objFtpResourceEN.FileDirName !=  null)
 {
 objFtpResourceEN.FileDirName = objFtpResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileDirName = '{0}',", objFtpResourceEN.FileDirName); //文件目录名
 }
 else
 {
 sbSQL.Append(" FileDirName = null,"); //文件目录名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileRename))
 {
 if (objFtpResourceEN.FileRename !=  null)
 {
 objFtpResourceEN.FileRename = objFtpResourceEN.FileRename.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileRename = '{0}',", objFtpResourceEN.FileRename); //文件新名
 }
 else
 {
 sbSQL.Append(" FileRename = null,"); //文件新名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileType))
 {
 if (objFtpResourceEN.FileType !=  null)
 {
 objFtpResourceEN.FileType = objFtpResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileType = '{0}',", objFtpResourceEN.FileType); //文件类型
 }
 else
 {
 sbSQL.Append(" FileType = null,"); //文件类型
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileUpDate))
 {
 if (objFtpResourceEN.FileUpDate !=  null)
 {
 objFtpResourceEN.FileUpDate = objFtpResourceEN.FileUpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileUpDate = '{0}',", objFtpResourceEN.FileUpDate); //创建日期
 }
 else
 {
 sbSQL.Append(" FileUpDate = null,"); //创建日期
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileUpTime))
 {
 if (objFtpResourceEN.FileUpTime !=  null)
 {
 objFtpResourceEN.FileUpTime = objFtpResourceEN.FileUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileUpTime = '{0}',", objFtpResourceEN.FileUpTime); //创建时间
 }
 else
 {
 sbSQL.Append(" FileUpTime = null,"); //创建时间
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objFtpResourceEN.FileSize); //文件大小
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.ResourceOwner))
 {
 if (objFtpResourceEN.ResourceOwner !=  null)
 {
 objFtpResourceEN.ResourceOwner = objFtpResourceEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceOwner = '{0}',", objFtpResourceEN.ResourceOwner); //创建者
 }
 else
 {
 sbSQL.Append(" ResourceOwner = null,"); //创建者
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.Memo))
 {
 if (objFtpResourceEN.Memo !=  null)
 {
 objFtpResourceEN.Memo = objFtpResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objFtpResourceEN.Memo); //说明
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
 /// <param name = "objFtpResourceEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFtpResourceEN objFtpResourceEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFtpResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FtpResource Set ");
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FtpResourceID))
 {
 if (objFtpResourceEN.FtpResourceID !=  null)
 {
 objFtpResourceEN.FtpResourceID = objFtpResourceEN.FtpResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FtpResourceID = '{0}',", objFtpResourceEN.FtpResourceID); //FTP资源ID
 }
 else
 {
 sbSQL.Append(" FtpResourceID = null,"); //FTP资源ID
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileOriginalName))
 {
 if (objFtpResourceEN.FileOriginalName !=  null)
 {
 objFtpResourceEN.FileOriginalName = objFtpResourceEN.FileOriginalName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileOriginalName = '{0}',", objFtpResourceEN.FileOriginalName); //文件原名
 }
 else
 {
 sbSQL.Append(" FileOriginalName = null,"); //文件原名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.ftpServerIP))
 {
 if (objFtpResourceEN.ftpServerIP !=  null)
 {
 objFtpResourceEN.ftpServerIP = objFtpResourceEN.ftpServerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpServerIP = '{0}',", objFtpResourceEN.ftpServerIP); //ftp服务器地址
 }
 else
 {
 sbSQL.Append(" ftpServerIP = null,"); //ftp服务器地址
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileDirName))
 {
 if (objFtpResourceEN.FileDirName !=  null)
 {
 objFtpResourceEN.FileDirName = objFtpResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileDirName = '{0}',", objFtpResourceEN.FileDirName); //文件目录名
 }
 else
 {
 sbSQL.Append(" FileDirName = null,"); //文件目录名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileRename))
 {
 if (objFtpResourceEN.FileRename !=  null)
 {
 objFtpResourceEN.FileRename = objFtpResourceEN.FileRename.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileRename = '{0}',", objFtpResourceEN.FileRename); //文件新名
 }
 else
 {
 sbSQL.Append(" FileRename = null,"); //文件新名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileType))
 {
 if (objFtpResourceEN.FileType !=  null)
 {
 objFtpResourceEN.FileType = objFtpResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileType = '{0}',", objFtpResourceEN.FileType); //文件类型
 }
 else
 {
 sbSQL.Append(" FileType = null,"); //文件类型
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileUpDate))
 {
 if (objFtpResourceEN.FileUpDate !=  null)
 {
 objFtpResourceEN.FileUpDate = objFtpResourceEN.FileUpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileUpDate = '{0}',", objFtpResourceEN.FileUpDate); //创建日期
 }
 else
 {
 sbSQL.Append(" FileUpDate = null,"); //创建日期
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileUpTime))
 {
 if (objFtpResourceEN.FileUpTime !=  null)
 {
 objFtpResourceEN.FileUpTime = objFtpResourceEN.FileUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileUpTime = '{0}',", objFtpResourceEN.FileUpTime); //创建时间
 }
 else
 {
 sbSQL.Append(" FileUpTime = null,"); //创建时间
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileSize))
 {
 sbSQL.AppendFormat(" FileSize = {0},", objFtpResourceEN.FileSize); //文件大小
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.ResourceOwner))
 {
 if (objFtpResourceEN.ResourceOwner !=  null)
 {
 objFtpResourceEN.ResourceOwner = objFtpResourceEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceOwner = '{0}',", objFtpResourceEN.ResourceOwner); //创建者
 }
 else
 {
 sbSQL.Append(" ResourceOwner = null,"); //创建者
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.Memo))
 {
 if (objFtpResourceEN.Memo !=  null)
 {
 objFtpResourceEN.Memo = objFtpResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objFtpResourceEN.Memo); //说明
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
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFtpResourceEN objFtpResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFtpResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFtpResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FtpResource Set ");
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FtpResourceID))
 {
 if (objFtpResourceEN.FtpResourceID !=  null)
 {
 objFtpResourceEN.FtpResourceID = objFtpResourceEN.FtpResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FtpResourceID, conFtpResource.FtpResourceID); //FTP资源ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FtpResourceID); //FTP资源ID
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileOriginalName))
 {
 if (objFtpResourceEN.FileOriginalName !=  null)
 {
 objFtpResourceEN.FileOriginalName = objFtpResourceEN.FileOriginalName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileOriginalName, conFtpResource.FileOriginalName); //文件原名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileOriginalName); //文件原名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.ftpServerIP))
 {
 if (objFtpResourceEN.ftpServerIP !=  null)
 {
 objFtpResourceEN.ftpServerIP = objFtpResourceEN.ftpServerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.ftpServerIP, conFtpResource.ftpServerIP); //ftp服务器地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.ftpServerIP); //ftp服务器地址
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileDirName))
 {
 if (objFtpResourceEN.FileDirName !=  null)
 {
 objFtpResourceEN.FileDirName = objFtpResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileDirName, conFtpResource.FileDirName); //文件目录名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileDirName); //文件目录名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileRename))
 {
 if (objFtpResourceEN.FileRename !=  null)
 {
 objFtpResourceEN.FileRename = objFtpResourceEN.FileRename.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileRename, conFtpResource.FileRename); //文件新名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileRename); //文件新名
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileType))
 {
 if (objFtpResourceEN.FileType !=  null)
 {
 objFtpResourceEN.FileType = objFtpResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileType, conFtpResource.FileType); //文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileType); //文件类型
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileUpDate))
 {
 if (objFtpResourceEN.FileUpDate !=  null)
 {
 objFtpResourceEN.FileUpDate = objFtpResourceEN.FileUpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileUpDate, conFtpResource.FileUpDate); //创建日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileUpDate); //创建日期
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileUpTime))
 {
 if (objFtpResourceEN.FileUpTime !=  null)
 {
 objFtpResourceEN.FileUpTime = objFtpResourceEN.FileUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.FileUpTime, conFtpResource.FileUpTime); //创建时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.FileUpTime); //创建时间
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.FileSize))
 {
 sbSQL.AppendFormat("{1} = {0},",objFtpResourceEN.FileSize, conFtpResource.FileSize); //文件大小
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.ResourceOwner))
 {
 if (objFtpResourceEN.ResourceOwner !=  null)
 {
 objFtpResourceEN.ResourceOwner = objFtpResourceEN.ResourceOwner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.ResourceOwner, conFtpResource.ResourceOwner); //创建者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.ResourceOwner); //创建者
 }
 }
 
 if (objFtpResourceEN.IsUpdated(conFtpResource.Memo))
 {
 if (objFtpResourceEN.Memo !=  null)
 {
 objFtpResourceEN.Memo = objFtpResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFtpResourceEN.Memo, conFtpResource.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFtpResource.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdFtpResource = '{0}'", objFtpResourceEN.IdFtpResource); 
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
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdFtpResource) 
{
CheckPrimaryKey(strIdFtpResource);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdFtpResource,
};
 objSQL.ExecSP("FtpResource_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdFtpResource, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdFtpResource);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
//删除FtpResource本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FtpResource where IdFtpResource = " + "'"+ strIdFtpResource+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFtpResource(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
//删除FtpResource本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FtpResource where IdFtpResource in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdFtpResource) 
{
CheckPrimaryKey(strIdFtpResource);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
//删除FtpResource本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FtpResource where IdFtpResource = " + "'"+ strIdFtpResource+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFtpResource(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFtpResourceDA: DelFtpResource)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FtpResource where " + strCondition ;
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
public bool DelFtpResourceWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFtpResourceDA: DelFtpResourceWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FtpResource where " + strCondition ;
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
 /// <param name = "objFtpResourceENS">源对象</param>
 /// <param name = "objFtpResourceENT">目标对象</param>
public void CopyTo(clsFtpResourceEN objFtpResourceENS, clsFtpResourceEN objFtpResourceENT)
{
objFtpResourceENT.IdFtpResource = objFtpResourceENS.IdFtpResource; //FTP资源流水号
objFtpResourceENT.FtpResourceID = objFtpResourceENS.FtpResourceID; //FTP资源ID
objFtpResourceENT.FileOriginalName = objFtpResourceENS.FileOriginalName; //文件原名
objFtpResourceENT.ftpServerIP = objFtpResourceENS.ftpServerIP; //ftp服务器地址
objFtpResourceENT.FileDirName = objFtpResourceENS.FileDirName; //文件目录名
objFtpResourceENT.FileRename = objFtpResourceENS.FileRename; //文件新名
objFtpResourceENT.FileType = objFtpResourceENS.FileType; //文件类型
objFtpResourceENT.FileUpDate = objFtpResourceENS.FileUpDate; //创建日期
objFtpResourceENT.FileUpTime = objFtpResourceENS.FileUpTime; //创建时间
objFtpResourceENT.FileSize = objFtpResourceENS.FileSize; //文件大小
objFtpResourceENT.ResourceOwner = objFtpResourceENS.ResourceOwner; //创建者
objFtpResourceENT.Memo = objFtpResourceENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFtpResourceEN objFtpResourceEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFtpResourceEN.FtpResourceID, conFtpResource.FtpResourceID);
clsCheckSql.CheckFieldNotNull(objFtpResourceEN.ftpServerIP, conFtpResource.ftpServerIP);
//检查字段长度
clsCheckSql.CheckFieldLen(objFtpResourceEN.IdFtpResource, 8, conFtpResource.IdFtpResource);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FtpResourceID, 8, conFtpResource.FtpResourceID);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileOriginalName, 200, conFtpResource.FileOriginalName);
clsCheckSql.CheckFieldLen(objFtpResourceEN.ftpServerIP, 30, conFtpResource.ftpServerIP);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileDirName, 200, conFtpResource.FileDirName);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileRename, 200, conFtpResource.FileRename);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileType, 30, conFtpResource.FileType);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileUpDate, 8, conFtpResource.FileUpDate);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileUpTime, 6, conFtpResource.FileUpTime);
clsCheckSql.CheckFieldLen(objFtpResourceEN.ResourceOwner, 50, conFtpResource.ResourceOwner);
clsCheckSql.CheckFieldLen(objFtpResourceEN.Memo, 1000, conFtpResource.Memo);
//检查字段外键固定长度
 objFtpResourceEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFtpResourceEN objFtpResourceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFtpResourceEN.FtpResourceID, 8, conFtpResource.FtpResourceID);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileOriginalName, 200, conFtpResource.FileOriginalName);
clsCheckSql.CheckFieldLen(objFtpResourceEN.ftpServerIP, 30, conFtpResource.ftpServerIP);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileDirName, 200, conFtpResource.FileDirName);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileRename, 200, conFtpResource.FileRename);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileType, 30, conFtpResource.FileType);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileUpDate, 8, conFtpResource.FileUpDate);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileUpTime, 6, conFtpResource.FileUpTime);
clsCheckSql.CheckFieldLen(objFtpResourceEN.ResourceOwner, 50, conFtpResource.ResourceOwner);
clsCheckSql.CheckFieldLen(objFtpResourceEN.Memo, 1000, conFtpResource.Memo);
//检查外键字段长度
 objFtpResourceEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFtpResourceEN objFtpResourceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFtpResourceEN.IdFtpResource, 8, conFtpResource.IdFtpResource);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FtpResourceID, 8, conFtpResource.FtpResourceID);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileOriginalName, 200, conFtpResource.FileOriginalName);
clsCheckSql.CheckFieldLen(objFtpResourceEN.ftpServerIP, 30, conFtpResource.ftpServerIP);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileDirName, 200, conFtpResource.FileDirName);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileRename, 200, conFtpResource.FileRename);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileType, 30, conFtpResource.FileType);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileUpDate, 8, conFtpResource.FileUpDate);
clsCheckSql.CheckFieldLen(objFtpResourceEN.FileUpTime, 6, conFtpResource.FileUpTime);
clsCheckSql.CheckFieldLen(objFtpResourceEN.ResourceOwner, 50, conFtpResource.ResourceOwner);
clsCheckSql.CheckFieldLen(objFtpResourceEN.Memo, 1000, conFtpResource.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.IdFtpResource, conFtpResource.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.FtpResourceID, conFtpResource.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.FileOriginalName, conFtpResource.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.ftpServerIP, conFtpResource.ftpServerIP);
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.FileDirName, conFtpResource.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.FileRename, conFtpResource.FileRename);
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.FileType, conFtpResource.FileType);
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.FileUpDate, conFtpResource.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.FileUpTime, conFtpResource.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.ResourceOwner, conFtpResource.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objFtpResourceEN.Memo, conFtpResource.Memo);
//检查外键字段长度
 objFtpResourceEN._IsCheckProperty = true;
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
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFtpResourceEN._CurrTabName);
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
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFtpResourceEN._CurrTabName, strCondition);
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
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
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
 objSQL = clsFtpResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}