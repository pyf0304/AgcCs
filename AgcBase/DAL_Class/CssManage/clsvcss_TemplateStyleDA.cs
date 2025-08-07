
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcss_TemplateStyleDA
 表名:vcss_TemplateStyle(00050472)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:41:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
 /// vcss_TemplateStyle(vcss_TemplateStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsvcss_TemplateStyleDA : clsCommBase4DA
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
 return clsvcss_TemplateStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcss_TemplateStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcss_TemplateStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcss_TemplateStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcss_TemplateStyleEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 strSQL = "Select * from vcss_TemplateStyle where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vcss_TemplateStyle");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vcss_TemplateStyle_SelectByCond",values, "vcss_TemplateStyle");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vcss_TemplateStyle");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vcss_TemplateStyle a where {0} And a.mId not in (Select Top {2} mId From vcss_TemplateStyle Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vcss_TemplateStyle");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vcss_TemplateStyle a where {0} And a.mId not in (Select Top {2} mId From vcss_TemplateStyle Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vcss_TemplateStyle");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vcss_TemplateStyle a where {0} And a.mId not in (Select Top {2} mId From vcss_TemplateStyle Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vcss_TemplateStyle");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_TemplateStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcss_TemplateStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTable_vcss_TemplateStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_TemplateStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_TemplateStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_TemplateStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcss_TemplateStyle.* from vcss_TemplateStyle Left Join {1} on {2} where {3} and vcss_TemplateStyle.mId not in (Select top {5} vcss_TemplateStyle.mId from vcss_TemplateStyle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1} and mId not in (Select top {2} mId from vcss_TemplateStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1} and mId not in (Select top {3} mId from vcss_TemplateStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcss_TemplateStyle.* from vcss_TemplateStyle Left Join {1} on {2} where {3} and vcss_TemplateStyle.mId not in (Select top {5} vcss_TemplateStyle.mId from vcss_TemplateStyle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1} and mId not in (Select top {2} mId from vcss_TemplateStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1} and mId not in (Select top {3} mId from vcss_TemplateStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcss_TemplateStyle.* from vcss_TemplateStyle Left Join {1} on {2} where {3} and vcss_TemplateStyle.mId not in (Select top {5} vcss_TemplateStyle.mId from vcss_TemplateStyle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1} and mId not in (Select top {2} mId from vcss_TemplateStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcss_TemplateStyle where {1} and mId not in (Select top {3} mId from vcss_TemplateStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vcss_TemplateStyle a where {0} And a.mId not in (Select Top {2} mId From vcss_TemplateStyle Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vcss_TemplateStyle a where {0} And a.mId not in (Select Top {2} mId From vcss_TemplateStyle Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vcss_TemplateStyle a where {0} And a.mId not in (Select Top {2} mId From vcss_TemplateStyle Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vcss_TemplateStyle a where {0} And a.mId not in (Select Top {2} mId From vcss_TemplateStyle Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyleByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_TemplateStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vcss_TemplateStyle_SelectByCond",values);
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
public List<clsvcss_TemplateStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA:GetObjLst)", objException.Message));
}
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_TemplateStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = TransNullToInt(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = TransNullToBool(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = TransNullToBool(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcss_TemplateStyleDA: GetObjLst)", objException.Message));
}
objvcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcss_TemplateStyleEN);
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
public List<clsvcss_TemplateStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = TransNullToInt(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = TransNullToBool(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = TransNullToBool(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcss_TemplateStyleDA: GetObjLst)", objException.Message));
}
objvcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvcss_TemplateStyleEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA:GetObjLstBySP)", objException.Message));
}
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vcss_TemplateStyle_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = TransNullToInt(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = TransNullToBool(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = TransNullToBool(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvcss_TemplateStyleDA: GetObjLstBySP)", objException.Message));
}
objvcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcss_TemplateStyle(ref clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_TemplateStyle where mId = " + ""+ objvcss_TemplateStyleEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcss_TemplateStyleEN.mId = TransNullToInt(objDT.Rows[0][convcss_TemplateStyle.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.StyleId = objDT.Rows[0][convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.ControlId = objDT.Rows[0][convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.ControlName = objDT.Rows[0][convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.StyleName = objDT.Rows[0][convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.StyleDesc = objDT.Rows[0][convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_TemplateStyleEN.StyleContent = objDT.Rows[0][convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_TemplateStyleEN.TemplateId = objDT.Rows[0][convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.TemplateName = objDT.Rows[0][convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.TemplateDesc = objDT.Rows[0][convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述(字段类型:varchar,字段长度:100,是否可空:True)
 objvcss_TemplateStyleEN.TemplatePic = objDT.Rows[0][convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片(字段类型:varchar,字段长度:100,是否可空:True)
 objvcss_TemplateStyleEN.IsPublic = TransNullToBool(objDT.Rows[0][convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcss_TemplateStyleEN.TemplateStyleName = objDT.Rows[0][convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.UpdDate = objDT.Rows[0][convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcss_TemplateStyleEN.UpdUser = objDT.Rows[0][convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvcss_TemplateStyleEN.Memo = objDT.Rows[0][convcss_TemplateStyle.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_TemplateStyleEN.TemplateStyleNameEn = objDT.Rows[0][convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文(字段类型:varchar,字段长度:200,是否可空:True)
 objvcss_TemplateStyleEN.cssModuleAreaId = objDT.Rows[0][convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.ModuleAreaName = objDT.Rows[0][convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcss_TemplateStyleEN.IsDelete = TransNullToBool(objDT.Rows[0][convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcss_TemplateStyleDA: Getvcss_TemplateStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcss_TemplateStyleEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_TemplateStyle where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
 objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述(字段类型:varchar,字段长度:100,是否可空:True)
 objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片(字段类型:varchar,字段长度:100,是否可空:True)
 objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文(字段类型:varchar,字段长度:200,是否可空:True)
 objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcss_TemplateStyleDA: GetObjBymId)", objException.Message));
}
return objvcss_TemplateStyleEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vcss_TemplateStyle_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcss_TemplateStyleOneBySP(clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvcss_TemplateStyleEN.mId
};
 objDT = objSQL.ExecSpReturnDT("vcss_TemplateStyle_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvcss_TemplateStyleEN.mId = TransNullToInt(objDT.Rows[0][convcss_TemplateStyle.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.StyleId = objDT.Rows[0][convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.ControlId = objDT.Rows[0][convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.ControlName = objDT.Rows[0][convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.StyleName = objDT.Rows[0][convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.StyleDesc = objDT.Rows[0][convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_TemplateStyleEN.StyleContent = objDT.Rows[0][convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_TemplateStyleEN.TemplateId = objDT.Rows[0][convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.TemplateName = objDT.Rows[0][convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.TemplateDesc = objDT.Rows[0][convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述(字段类型:varchar,字段长度:100,是否可空:True)
 objvcss_TemplateStyleEN.TemplatePic = objDT.Rows[0][convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片(字段类型:varchar,字段长度:100,是否可空:True)
 objvcss_TemplateStyleEN.IsPublic = TransNullToBool(objDT.Rows[0][convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcss_TemplateStyleEN.TemplateStyleName = objDT.Rows[0][convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcss_TemplateStyleEN.UpdDate = objDT.Rows[0][convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcss_TemplateStyleEN.UpdUser = objDT.Rows[0][convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvcss_TemplateStyleEN.Memo = objDT.Rows[0][convcss_TemplateStyle.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcss_TemplateStyleEN.TemplateStyleNameEn = objDT.Rows[0][convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文(字段类型:varchar,字段长度:200,是否可空:True)
 objvcss_TemplateStyleEN.cssModuleAreaId = objDT.Rows[0][convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键(字段类型:char,字段长度:8,是否可空:False)
 objvcss_TemplateStyleEN.ModuleAreaName = objDT.Rows[0][convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcss_TemplateStyleEN.IsDelete = TransNullToBool(objDT.Rows[0][convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete(字段类型:bit,字段长度:1,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcss_TemplateStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
strSQL = "Select * from vcss_TemplateStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN()
{
mId = TransNullToInt(objRow[convcss_TemplateStyle.mId].ToString().Trim()), //mId
StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(), //样式ID
ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(), //控件ID
ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(), //控件名称
StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(), //样式名称
StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(), //样式描述
StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(), //样式内容
TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(), //模板ID
TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(), //模板名称
TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(), //模板描述
TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(), //模板图片
IsPublic = TransNullToBool(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()), //是否公开
TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(), //模板样式名称
UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(), //说明
TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(), //模板样式英文
cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(), //区域主键
ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(), //区域名称
IsDelete = TransNullToBool(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()) //IsDelete
};
objvcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcss_TemplateStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcss_TemplateStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcss_TemplateStyleEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vcss_TemplateStyle_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN()
{
mId = TransNullToInt(objRow[convcss_TemplateStyle.mId].ToString().Trim()), //mId
StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(), //样式ID
ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(), //控件ID
ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(), //控件名称
StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(), //样式名称
StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(), //样式描述
StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(), //样式内容
TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(), //模板ID
TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(), //模板名称
TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(), //模板描述
TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(), //模板图片
IsPublic = TransNullToBool(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()), //是否公开
TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(), //模板样式名称
UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(), //说明
TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(), //模板样式英文
cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(), //区域主键
ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(), //区域名称
IsDelete = TransNullToBool(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()) //IsDelete
};
objvcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcss_TemplateStyleEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcss_TemplateStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = TransNullToInt(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = TransNullToBool(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = TransNullToBool(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcss_TemplateStyleDA: GetObjByDataRowvcss_TemplateStyle)", objException.Message));
}
objvcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcss_TemplateStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcss_TemplateStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = TransNullToInt(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = TransNullToBool(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = TransNullToBool(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcss_TemplateStyleDA: GetObjByDataRow)", objException.Message));
}
objvcss_TemplateStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcss_TemplateStyleEN;
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
objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcss_TemplateStyleEN._CurrTabName, convcss_TemplateStyle.mId, 8, "");
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
objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcss_TemplateStyleEN._CurrTabName, convcss_TemplateStyle.mId, 8, strPrefix);
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
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vcss_TemplateStyle where " + strCondition;
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
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vcss_TemplateStyle where " + strCondition;
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
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcss_TemplateStyle", "mId = " + ""+ lngmId+""))
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
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vcss_TemplateStyle_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcss_TemplateStyle", strCondition))
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
objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcss_TemplateStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleENS">源对象</param>
 /// <param name = "objvcss_TemplateStyleENT">目标对象</param>
public void CopyTo(clsvcss_TemplateStyleEN objvcss_TemplateStyleENS, clsvcss_TemplateStyleEN objvcss_TemplateStyleENT)
{
objvcss_TemplateStyleENT.mId = objvcss_TemplateStyleENS.mId; //mId
objvcss_TemplateStyleENT.StyleId = objvcss_TemplateStyleENS.StyleId; //样式ID
objvcss_TemplateStyleENT.ControlId = objvcss_TemplateStyleENS.ControlId; //控件ID
objvcss_TemplateStyleENT.ControlName = objvcss_TemplateStyleENS.ControlName; //控件名称
objvcss_TemplateStyleENT.StyleName = objvcss_TemplateStyleENS.StyleName; //样式名称
objvcss_TemplateStyleENT.StyleDesc = objvcss_TemplateStyleENS.StyleDesc; //样式描述
objvcss_TemplateStyleENT.StyleContent = objvcss_TemplateStyleENS.StyleContent; //样式内容
objvcss_TemplateStyleENT.TemplateId = objvcss_TemplateStyleENS.TemplateId; //模板ID
objvcss_TemplateStyleENT.TemplateName = objvcss_TemplateStyleENS.TemplateName; //模板名称
objvcss_TemplateStyleENT.TemplateDesc = objvcss_TemplateStyleENS.TemplateDesc; //模板描述
objvcss_TemplateStyleENT.TemplatePic = objvcss_TemplateStyleENS.TemplatePic; //模板图片
objvcss_TemplateStyleENT.IsPublic = objvcss_TemplateStyleENS.IsPublic; //是否公开
objvcss_TemplateStyleENT.TemplateStyleName = objvcss_TemplateStyleENS.TemplateStyleName; //模板样式名称
objvcss_TemplateStyleENT.UpdDate = objvcss_TemplateStyleENS.UpdDate; //修改日期
objvcss_TemplateStyleENT.UpdUser = objvcss_TemplateStyleENS.UpdUser; //修改者
objvcss_TemplateStyleENT.Memo = objvcss_TemplateStyleENS.Memo; //说明
objvcss_TemplateStyleENT.TemplateStyleNameEn = objvcss_TemplateStyleENS.TemplateStyleNameEn; //模板样式英文
objvcss_TemplateStyleENT.cssModuleAreaId = objvcss_TemplateStyleENS.cssModuleAreaId; //区域主键
objvcss_TemplateStyleENT.ModuleAreaName = objvcss_TemplateStyleENS.ModuleAreaName; //区域名称
objvcss_TemplateStyleENT.IsDelete = objvcss_TemplateStyleENS.IsDelete; //IsDelete
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.StyleId, 8, convcss_TemplateStyle.StyleId);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.ControlId, 8, convcss_TemplateStyle.ControlId);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.ControlName, 50, convcss_TemplateStyle.ControlName);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.StyleName, 50, convcss_TemplateStyle.StyleName);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.StyleDesc, 1000, convcss_TemplateStyle.StyleDesc);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.StyleContent, 1000, convcss_TemplateStyle.StyleContent);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.TemplateId, 8, convcss_TemplateStyle.TemplateId);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.TemplateName, 50, convcss_TemplateStyle.TemplateName);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.TemplateDesc, 100, convcss_TemplateStyle.TemplateDesc);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.TemplatePic, 100, convcss_TemplateStyle.TemplatePic);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.TemplateStyleName, 50, convcss_TemplateStyle.TemplateStyleName);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.UpdDate, 20, convcss_TemplateStyle.UpdDate);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.UpdUser, 20, convcss_TemplateStyle.UpdUser);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.Memo, 1000, convcss_TemplateStyle.Memo);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.TemplateStyleNameEn, 200, convcss_TemplateStyle.TemplateStyleNameEn);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.cssModuleAreaId, 8, convcss_TemplateStyle.cssModuleAreaId);
clsCheckSql.CheckFieldLen(objvcss_TemplateStyleEN.ModuleAreaName, 100, convcss_TemplateStyle.ModuleAreaName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.StyleId, convcss_TemplateStyle.StyleId);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.ControlId, convcss_TemplateStyle.ControlId);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.ControlName, convcss_TemplateStyle.ControlName);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.StyleName, convcss_TemplateStyle.StyleName);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.StyleDesc, convcss_TemplateStyle.StyleDesc);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.StyleContent, convcss_TemplateStyle.StyleContent);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.TemplateId, convcss_TemplateStyle.TemplateId);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.TemplateName, convcss_TemplateStyle.TemplateName);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.TemplateDesc, convcss_TemplateStyle.TemplateDesc);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.TemplatePic, convcss_TemplateStyle.TemplatePic);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.TemplateStyleName, convcss_TemplateStyle.TemplateStyleName);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.UpdDate, convcss_TemplateStyle.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.UpdUser, convcss_TemplateStyle.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.Memo, convcss_TemplateStyle.Memo);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.TemplateStyleNameEn, convcss_TemplateStyle.TemplateStyleNameEn);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.cssModuleAreaId, convcss_TemplateStyle.cssModuleAreaId);
clsCheckSql.CheckSqlInjection4Field(objvcss_TemplateStyleEN.ModuleAreaName, convcss_TemplateStyle.ModuleAreaName);
//检查外键字段长度
 objvcss_TemplateStyleEN._IsCheckProperty = true;
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
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
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
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
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
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcss_TemplateStyleEN._CurrTabName);
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
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcss_TemplateStyleEN._CurrTabName, strCondition);
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
 objSQL = clsvcss_TemplateStyleDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}