
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsErrorLevelWS
 表名:ErrorLevel
 生成代码版本:2017.06.27.1
 生成日期:2017/06/27 20:06:05
 生成者:
 生成服务器IP:180.153.158.158
 工程名称:AGC_CSV7
 工程ID:0005
 模块中文名:日志管理
 模块英文名:LogManage
 框架-层名:Web服务转换层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.19.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
 == == == == == == == == == == == == 
 */
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using com.taishsoft.common;
using System.ServiceModel;
using AGC_CSV74WS.ServiceReferenceErrorLevel;
using System.Collections.Generic;

namespace AGC_CSV74WS
{
 /// <summary>
 /// 错误等级(ErrorLevel)
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
public class clsErrorLevelWS
{
private static string mstrPageName = "ErrorLevelService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
public static List<clsErrorLevelEN> arrErrorLevelObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static ErrorLevelServiceSoapClient objErrorLevelServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
 /// <returns></returns>
public static ErrorLevelServiceSoapClient GetErrorLevelServiceSoapClient()
{
if (objErrorLevelServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "ErrorLevelServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new ErrorLevelServiceSoapClient(binding, address);
}
else
{
return objErrorLevelServiceSoapClient;
}
}

 public clsErrorLevelWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_ErrorLevelId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetDataTable_ErrorLevelWs("1=1");
clsErrorLevelEN objErrorLevelEN;
//初始化一个对象列表
ArrayList ErrorLevelList = new ArrayList();
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
objErrorLevelEN = new clsErrorLevelEN();
objErrorLevelEN.ErrorLevelId = "0";
objErrorLevelEN.ErrorLevelName = "请选择...";
ErrorLevelList.Add(objErrorLevelEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objErrorLevelEN = new clsErrorLevelEN();
objErrorLevelEN.ErrorLevelId = objRow["ErrorLevelId"].ToString();
objErrorLevelEN.ErrorLevelName = objRow["ErrorLevelName"].ToString();
ErrorLevelList.Add(objErrorLevelEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = ErrorLevelList;
objComboBox.ValueMember="ErrorLevelId";
objComboBox.DisplayMember="ErrorLevelName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ErrorLevelId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li=new System.Web.UI.WebControls.ListItem("请选择...","0");
System.Data.DataTable objDT = GetDataTable_ErrorLevelWs("1=1");
objDDL.DataValueField="ErrorLevelId";
objDDL.DataTextField="ErrorLevelName";
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 ///生成绑定ListView的代码
 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_ErrorLevel(System.Windows.Forms.ListView lvErrorLevel, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviErrorLevel; 
List<clsErrorLevelEN> arrErrorLevelObjList;
//	2、根据条件串获取该表满足条件的DataTable；
arrErrorLevelObjList = GetErrorLevelObjList(strWhereCond);
//	3、设置ListView的列头信息
lvErrorLevel.Items.Clear();//清除原来所有Item
lvErrorLevel.Columns.Clear();//清除原来所有列头信息
lvErrorLevel.Columns.Add("错误等级Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvErrorLevel.Columns.Add("错误等级名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvErrorLevel.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvErrorLevel.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsErrorLevelEN objErrorLevelEN in arrErrorLevelObjList)
{
lviErrorLevel = new System.Windows.Forms.ListViewItem();
lviErrorLevel.Tag = objErrorLevelEN.ErrorLevelId;
lviErrorLevel.Text = objErrorLevelEN.ErrorLevelId.ToString();
lviErrorLevel.SubItems.Add(objErrorLevelEN.ErrorLevelName);
lviErrorLevel.SubItems.Add(objErrorLevelEN.Memo);
lvErrorLevel.Items.Add(lviErrorLevel);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrErrorLevelObjList.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsErrorLevelEN objErrorLevelEN)
{
if (!Object.Equals(null, objErrorLevelEN.ErrorLevelId) && getStrLen(objErrorLevelEN.ErrorLevelId) > 4)
{
 throw new Exception("字段[错误等级Id]的长度不能超过4!");
}
if (!Object.Equals(null, objErrorLevelEN.ErrorLevelName) && getStrLen(objErrorLevelEN.ErrorLevelName) > 50)
{
 throw new Exception("字段[错误等级名]的长度不能超过50!");
}
if (!Object.Equals(null, objErrorLevelEN.Memo) && getStrLen(objErrorLevelEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objErrorLevelEN.IsCheckProperty = true;
 }

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTable_ErrorLevelWs(string strWhereCond)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objErrorLevelService.ErrorLevel_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_GetDataSet", "clsErrorLevelWS:GetDataTable_ErrorLevelWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetTopDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTable_TopErrorLevelWs(int intTopSize, string strWhereCond)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objErrorLevelService.ErrorLevel_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_GetTopDataSet", "clsErrorLevelWS:GetDataTable_TopErrorLevelWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4TabByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lngMinNum">范围之最小值</param>
 /// <param name = "lngMaxNum">范围之最大值</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTable_ErrorLevelByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objErrorLevelService.ErrorLevel_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_GetDataSetByRange", "clsErrorLevelWS:GetDataTable_ErrorLevelByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTable_ErrorLevelVWs(string strWhereCond)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objErrorLevelService.ErrorLevel_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_GetDataSetV", "clsErrorLevelWS:GetDataTable_ErrorLevelVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetErrorLevelVWs(string strWhereCond)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objErrorLevelService.ErrorLevel_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_GetDataSetV", "clsErrorLevelWS:GetDataTable_ErrorLevelVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objErrorLevelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetErrorLevelWs(ref clsErrorLevelEN objErrorLevelEN)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
bool bolResult = objErrorLevelService.ErrorLevel_GetErrorLevel(ref objErrorLevelEN);
return bolResult;
}

public static clsErrorLevelEN GetErrorLevelByErrorLevelIdWs(string strErrorLevelId)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
clsErrorLevelEN objErrorLevelEN = objErrorLevelService.ErrorLevel_GetErrorLevelByErrorLevelId(strErrorLevelId);
return objErrorLevelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
try
{
string strErrorLevelId = objErrorLevelService.ErrorLevel_GetFirstID_S(strWhereCond);
return strErrorLevelId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_GetFirstID_S", "clsErrorLevelWS:GetFirstID_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsErrorLevelEN GetFirstErrorLevel_S(string strWhereCond)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
try
{
clsErrorLevelEN objErrorLevelEN = objErrorLevelService.ErrorLevel_GetFirstErrorLevel_S(strWhereCond);
return objErrorLevelEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_GetFirstErrorLevel_S", "clsErrorLevelWS:GetFirstErrorLevel_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strErrorLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetErrorLevelNameByErrorLevelId_Cache(string strErrorLevelId)
{
if (string.IsNullOrEmpty(strErrorLevelId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrErrorLevelObjLst_Cache.Count - 1;
int intMid = 0;
clsErrorLevelEN objErrorLevelEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objErrorLevelEN = arrErrorLevelObjLst_Cache[intMid];
if (objErrorLevelEN.ErrorLevelId == strErrorLevelId)
{
intFindFailCount = 0;
return objErrorLevelEN.ErrorLevelName;
}
else if (objErrorLevelEN.ErrorLevelId.CompareTo(strErrorLevelId) > 0)
{
intEnd = intMid - 1;
}
else
{
intStart = intMid + 1;
}
}
intFindFailCount++;
// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
arrErrorLevelObjLst_Cache = null;
if (intFindFailCount == 1) return GetErrorLevelNameByErrorLevelId_Cache(strErrorLevelId);
string strErrMsgForGetObjById = string.Format("在ErrorLevel对象缓存列表中,找不到记录[ErrorLevelId = {0}][intFindFailCount = {1}](函数:{2})", strErrorLevelId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objErrorLevelEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objErrorLevelEN.ErrorLevelId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsErrorLevelBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by ErrorLevelId");
if (arrErrorLevelObjLst_Cache == null)
{
arrErrorLevelObjLst_Cache = clsErrorLevelWS.GetErrorLevelObjList(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetRecObjByKey_Cache)
 /// </summary>
 /// <param name = "strErrorLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsErrorLevelEN GetErrorLevelObjByErrorLevelId_Cache(string strErrorLevelId)
{
if (string.IsNullOrEmpty(strErrorLevelId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrErrorLevelObjLst_Cache.Count - 1;
int intMid = 0;
clsErrorLevelEN objErrorLevelEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objErrorLevelEN = arrErrorLevelObjLst_Cache[intMid];
if (objErrorLevelEN.ErrorLevelId == strErrorLevelId)
{
intFindFailCount = 0;
return objErrorLevelEN;
}
else if (objErrorLevelEN.ErrorLevelId.CompareTo(strErrorLevelId) > 0)
{
intEnd = intMid - 1;
}
else
{
intStart = intMid + 1;
}
}
intFindFailCount++;
// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
arrErrorLevelObjLst_Cache = null;
if (intFindFailCount == 1) return GetErrorLevelObjByErrorLevelId_Cache(strErrorLevelId);
string strErrMsgForGetObjById = string.Format("在ErrorLevel对象缓存列表中,找不到记录[ErrorLevelId = {0}][intFindFailCount = {1}](函数:{2})", strErrorLevelId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objErrorLevelEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objErrorLevelEN.ErrorLevelId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsErrorLevelBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

public static List<clsErrorLevelEN> GetErrorLevelObjList(string strWhereCond)
{
 List<clsErrorLevelEN> arrObjList = new List<clsErrorLevelEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_ErrorLevelWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorLevelEN objErrorLevelEN = new clsErrorLevelEN();
objErrorLevelEN.ErrorLevelId = objRow["ErrorLevelId"].ToString().Trim(); //错误等级Id
objErrorLevelEN.ErrorLevelName = objRow["ErrorLevelName"].ToString().Trim(); //错误等级名
objErrorLevelEN.Memo = objRow["Memo"].ToString().Trim(); //说明
	arrObjList.Add(objErrorLevelEN);
	}
objDT = null;
return arrObjList;
}

public static List<clsErrorLevelEN> GetErrorLevelObjListByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
 List<clsErrorLevelEN> arrObjList = new List<clsErrorLevelEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_ErrorLevelByRangeWs(strWhereCond, lngMinNum, lngMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorLevelEN objErrorLevelEN = new clsErrorLevelEN();
objErrorLevelEN.ErrorLevelId = objRow["ErrorLevelId"].ToString().Trim(); //错误等级Id
objErrorLevelEN.ErrorLevelName = objRow["ErrorLevelName"].ToString().Trim(); //错误等级名
objErrorLevelEN.Memo = objRow["Memo"].ToString().Trim(); //说明
	arrObjList.Add(objErrorLevelEN);
	}
objDT = null;
return arrObjList;
}

public static bool DelRecordWs(string strErrorLevelId)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
try
{
bool bolResult = objErrorLevelService.ErrorLevel_DelRecord(strErrorLevelId);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_DelRecord", "clsErrorLevelWS:DelRecordWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool DelErrorLevelsWs(List<string> arrErrorLevelId)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
try
{
string[] sstrErrorLevelId = (string[])(arrErrorLevelId.ToArray());
bool bolResult = objErrorLevelService.ErrorLevel_DelErrorLevels(sstrErrorLevelId);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_DelErrorLevels", "clsErrorLevelWS:DelErrorLevelsWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static int DelErrorLevelsByCondWs(string strWhereCond)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
try
{
int intRecNum = objErrorLevelService.ErrorLevel_DelErrorLevelsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_DelErrorLevelsByCond", "clsErrorLevelWS:DelErrorLevelsByCondWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool AddNewRecordBySql2Ws(clsErrorLevelEN objErrorLevelEN)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
try
{
bool bolResult = objErrorLevelService.ErrorLevel_AddNewRecordBySql2(objErrorLevelEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_AddNewRecordBySql2", "clsErrorLevelWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool UpdateBySql2Ws(clsErrorLevelEN objErrorLevelEN)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
try
{
bool bolResult = objErrorLevelService.ErrorLevel_UpdateBySql2(objErrorLevelEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_UpdateBySql2", "clsErrorLevelWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objErrorLevelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsErrorLevelEN objErrorLevelEN, string strWhereCond)
{
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
try
{
bool bolResult = objErrorLevelService.ErrorLevel_UpdateBySqlWithCondition(objErrorLevelEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorLevel_UpdateBySqlWithCondition", "clsErrorLevelWS:UpdateBySqlWithCondition", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool IsExistRecordWs(string strWhereCond)
{
//检测记录是否存在
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
bool bolIsExist = objErrorLevelService.ErrorLevel_IsExistRecord(strWhereCond);
return bolIsExist;
}

public static bool IsExistWs(string strErrorLevelId)
{
//检测记录是否存在
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
bool bolIsExist = objErrorLevelService.ErrorLevel_IsExist(strErrorLevelId);
return bolIsExist;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdWs()
{
//检测记录是否存在
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
string strMaxErrorLevelId = objErrorLevelService.ErrorLevel_GetMaxStrId();
return strMaxErrorLevelId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
ErrorLevelServiceSoapClient objErrorLevelService = GetErrorLevelServiceSoapClient();
string strMaxErrorLevelId = objErrorLevelService.ErrorLevel_GetMaxStrIdByPrefix(strPrefix);
return strMaxErrorLevelId;
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.AutoGCPubFuncV6:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int getStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 获取Web服务的地址
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetServiceUrl)
 /// </summary>
 /// <returns>返回当前文件中Web服务的地址</returns>
public static string GetServiceUrl(string strPageName, ref string strDir)
{
String strServiceUrl = String.Empty;
if (strDir == "0")
{
strDir = clsDict_PageName_Dic.GetDir4PageName(strPageName);
}
if (clsSysPara4WS.bolIsLocalHost == false)
{
if (string.IsNullOrEmpty(strDir) == true)
{
strServiceUrl = String.Format("http://{0}/{1}/{2}",
clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strPageName);
}
else
{
strServiceUrl = String.Format("http://{0}/{1}/{2}/{3}",
clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strDir, strPageName);
}
}
else
{
if (string.IsNullOrEmpty(strDir) == true)
{
strServiceUrl = String.Format("http://{0}/{1}",
clsSysPara4WS.strCurrIPAddressAndPort_Local,
strPageName);
}
else
{
strServiceUrl = String.Format("http://{0}/{1}/{2}",
clsSysPara4WS.strCurrIPAddressAndPort_Local, strDir, strPageName);
}
}
return strServiceUrl;
}
}
}