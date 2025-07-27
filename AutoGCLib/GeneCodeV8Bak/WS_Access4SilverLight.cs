using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// 共分以下几层:
    ///		1、界面层
    ///			通用界面层,专门提供一些界面控件的公共操作函数
    ///		2、逻辑层
    ///			2.1 业务逻辑层
    ///			2.2 表代理层。包括:
    ///					1)表记录的添加、
    ///					2)表记录的删除
    ///					3)表记录的修改
    ///					4)表记录的查询
    ///					5)获取某些表记录的有关字段属性
    ///					6)设置表记录的有关字段属性等。
    ///		3、数据层,即通用数据层,专门用于操作数据库的一些操作,以及操作表的一些通用操作
    /// </summary>
    partial class WS_Access4SilverLight : clsGeneCodeBase4Tab
    {


        #region 构造函数

        public WS_Access4SilverLight(string strTabId,  string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion
        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                            objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                    objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

        

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "WS";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.Append("\r\n" + "using System;"); //
                strBuilder.Append("\r\n" + "using System.Text; "); //
                strBuilder.Append("\r\n" + "using System.Collections; "); //
                strBuilder.Append("\r\n" + "using System.Collections.Generic;"); //
                strBuilder.Append("\r\n" + "using System.Windows.Controls;");

                strBuilder.Append("\r\n" + "using System.ServiceModel;"); // 
                strBuilder.AppendFormat("\r\n" + "using {0}_SL4WS.ServiceReference{1};", objProject.PrjDomain, objPrjTabENEx.TabName); // 
                                                                                                                                       //strBuilder.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain); // 

                strBuilder.Append("\r\n" + ""); //
                strBuilder.AppendFormat("\r\n" + "namespace {0}_SL4WS",
                objProject.PrjDomain);
                strBuilder.Append("\r\n" + "{");

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取当前表的最大关键字值");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}GetMaxStrIdHandle(object sender, {0}GetMaxStrIdCompletedEventArgs e);",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 是否存在记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}_IsExistHandle(object sender, {0}_IsExistCompletedEventArgs e);",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 是否存在条件记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}_IsExistRecordByCondHandle(object sender, {0}_IsExistRecordByCondCompletedEventArgs e);",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 添加记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}_AddNewRecordBySql_XMLHandle(object sender, {0}_AddNewRecordBySql_XMLCompletedEventArgs e);",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 修改记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}_UpdateBySql_XMLHandle(object sender, {0}_UpdateBySql_XMLCompletedEventArgs e);",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 删除一条记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}_DelRecordHandle(object sender, {0}_DelRecordCompletedEventArgs e);",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 删除满足条件的记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}_Del{0}sByCondHandle(object sender, {0}_Del{0}sByCondCompletedEventArgs e);",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 序列化一个记录到XML串中");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}_SerializeObjToXMLStrHandle(object sender, {0}_SerializeObjToXMLStrCompletedEventArgs e);",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 序列化记录列表到XML串中");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}_SerializeObjLstToXMLStrHandle(object sender, {0}_SerializeObjLstToXMLStrCompletedEventArgs e);",
                objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取一个“{0}”对象,根据对象的关键字",
                objPrjTabENEx.TabCnName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}Get{0}Handle(object sender, {0}Get{0}CompletedEventArgs e);",
                objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取一个“{0}”对象,根据对象的关键字",
                objPrjTabENEx.TabCnName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}GetObjBy{1}Handle(object sender, {0}GetObjBy{1}CompletedEventArgs e);",
                objPrjTabENEx.TabName, objKeyField.FldName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取一个“{0}”对象列表,根据条件串",
                objPrjTabENEx.TabCnName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public delegate void {0}GetObjLstHandle(object sender, {0}GetObjLstCompletedEventArgs e);",
                objPrjTabENEx.TabName);



                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// For SilverLight");

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{");


                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取当前表的最大关键字值");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}GetMaxStrIdHandle Event{0}GetMaxStrId;//声明一个事件",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 是否存在记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}_IsExistHandle Event{0}_IsExist;//声明一个事件",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 是否存在条件记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}_IsExistRecordByCondHandle Event{0}_IsExistRecordByCond;//声明一个事件",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 添加记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}_AddNewRecordBySql_XMLHandle Event{0}_AddNewRecordBySql_XML;//声明一个事件",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 修改记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}_UpdateBySql_XMLHandle Event{0}_UpdateBySql_XML;//声明一个事件",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 删除一条记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}_DelRecordHandle Event{0}_DelRecord;//声明一个事件",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 删除满足条件的记录");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}_Del{0}sByCondHandle Event{0}_Del{0}sByCond;//声明一个事件",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 序列化一个对象记录到XML串中");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}_SerializeObjToXMLStrHandle Event{0}_SerializeObjToXMLStr;//声明一个事件",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 序列化记录列表到XML串中");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}_SerializeObjLstToXMLStrHandle Event{0}_SerializeObjLstToXMLStr;//声明一个事件",
                objPrjTabENEx.TabName);


                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取一个对象,根据对象的关键字");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}Get{0}Handle Event{0}Get{0};//声明一个事件",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "");

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取一个对象,根据对象的关键字");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}GetObjBy{1}Handle Event{0}GetObjBy{1};//声明一个事件",
                objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "");


                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取对象列表,根据条件串");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public event {0}GetObjLstHandle Event{0}GetObjLst;//声明一个事件",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "");
                //strBuilder.AppendFormat("\r\n" + "private static {0}ServiceSoapClient obj{0}ServiceSoapClient = null;",
                // objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// “{0}”对象,用于暂存用户获取的“{0}”对象",
                objPrjTabENEx.TabCnName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public static cls{0}EN obj{0}EN = null;",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// “{0}”对象列表,用于暂存用户获得的“{0}”对象列表",
                objPrjTabENEx.TabCnName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> lst{0}ObjLst = null;",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 下拉框对象,暂存需要绑定的下拉框");
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public static ComboBox objCBO = null;");
                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 是否需要绑定下拉框");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public static bool bolIsBindComboBox = false;");



                //私有属性名-----和属性过程
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                       objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //私有属性名-----和属性过程
                strBuilder.AppendFormat("\r\n" + "private static {0}ServiceSoapClient obj{0}ServiceSoapClient = null;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns></returns>");
                strBuilder.AppendFormat("\r\n" + "public static {0}ServiceSoapClient Get{0}ServiceSoapClient()",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "if (obj{0}ServiceSoapClient == null)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                strBuilder.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                strBuilder.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                strBuilder.Append("\r\n" + "String strServiceUrl = String.Empty;");
                strBuilder.Append("\r\n" + "if (clsSysPara4WS.bolIsLocalHost == false)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);",
                "{", "}", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WS.strCurrIPAddressAndPort_Local);",
                "{", "}", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                strBuilder.AppendFormat("\r\n" + "return new {0}ServiceSoapClient(binding, address);",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "return obj{0}ServiceSoapClient;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
           clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
           objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);
                
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    string strFuncName = objvFunction4GeneCodeEN.FuncName;


                    strTemp = A_GeneFuncCode_SilverLight(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");

                //把生成写到文件中;
                ////检查该文件名的文件夹名,并判断是否存在;
                //strFolder = clsString.ParentDir_S(strClassFName);
                //if (System.IO.Directory.Exists(strFolder) == false)
                //{
                //    Directory.CreateDirectory(strFolder);
                //}

                //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
                //{
                //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                //    string strFindFileFullFile = clsFile.FindFileFromFolder(objPrjTabENEx.FolderName_Root, strSimpleFileName);
                //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                //    {
                //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                //        throw new Exception(strMsg);

                //    }
                //}
                ////UTF8Encoding utf8 = new UTF8Encoding(false);
                //clsFile.CreateFileByString(strClassFName, strBuilder.ToString(), myEncoding);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        public string A_GeneFuncCode_SilverLight(string strFuncName)
        {
            try
            {
                string strCode = "";
                Type t = typeof(WS_Srv4Front4CSharp);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, newobject[] { "1234567890123"    });
                    strCode = (string)mt.Invoke(this, null);
                    //Console.WriteLine(str);
                }

                return strCode;

            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        
        public string Gen_4Ws_GetObjLst_SL()
        {
            string strTextFieldName = "";
            string strValueFieldName = "";
            bool bolIsNeedBindCbo = false;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (strValueFieldName != "" && strTextFieldName != "")
            {
                bolIsNeedBindCbo = true;
            }
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strBuilder.Append("\r\n /// <summary> ");
            strBuilder.Append("\r\n /// 获取满足条件的对象列表,通过事件《获取对象列表完成》来获取对象列表 ");
            strBuilder.AppendFormat("\r\n /// 作者:{0} ", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期: {0}",clsDateTime.getTodayDateTimeStr(0));
            strBuilder.Append("\r\n /// </summary> ");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要的对象列表的条件串</param> ");
            strBuilder.AppendFormat("\r\n" + "public void GetObjLst(string strWhereCond) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{ ");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient(); ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}GetObjLstCompleted+= new EventHandler<{0}GetObjLstCompletedEventArgs>(obj{0}Service_{0}GetObjLstCompleted); ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}GetObjLstAsync(strWhereCond); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "} ");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}GetObjLstCompleted(object sender, {0}GetObjLstCompletedEventArgs e) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{ ");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN[] lst{0}Objs = e.Result; ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.lst{0}ObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in lst{0}Objs) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{ ");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.lst{0}ObjLst.Add(obj{0}EN); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "} ");
            strBuilder.Append("\r\n" + "");
            if (bolIsNeedBindCbo == true)
            {
                strBuilder.Append("\r\n" + "if (bolIsBindComboBox == true)");
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");
                strBuilder.AppendFormat("\r\n" + "cls{0}WS.objCBO.ItemsSource = cls{0}WS.lst{0}ObjLst;",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "cls{0}WS.objCBO.SelectedValuePath = \"{1}\";",
                objPrjTabENEx.TabName, strValueFieldName);
                strBuilder.AppendFormat("\r\n" + "cls{0}WS.objCBO.DisplayMemberPath = \"{1}\";",
                objPrjTabENEx.TabName, strTextFieldName);
                strBuilder.AppendFormat("\r\n" + "cls{0}WS.objCBO.SelectedIndex = 0;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "bolIsBindComboBox = false;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
            }
            strBuilder.AppendFormat("\r\n" + "if (Event{0}GetObjLst != null) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{ ");
            strBuilder.AppendFormat("\r\n" + "Event{0}GetObjLst(this, e); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "} ");
            if (bolIsNeedBindCbo == true)
            {
                strBuilder.Append("\r\n" + "} ");
            }
            strBuilder.Append("\r\n" + "} ");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecordProperty4Object_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据对象的关键字值,获取对象的全部属性");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">相关对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\n" + "public void Get{0}Ws(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}Get{0}Completed += new EventHandler<{0}Get{0}CompletedEventArgs>(obj{0}Service_{0}Get{0}Completed);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}Get{0}Async(obj{0}EN);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}Get{0}Completed(object sender, {0}Get{0}CompletedEventArgs e)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.obj{0}EN = e.obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (Event{0}Get{0} != null)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}Get{0}(this, e);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetObjByKeyId_SL()
        {
            StringBuilder strBuilder = new StringBuilder();


            strBuilder.AppendFormat("\r\n" + "public void GetObjBy{2}Ws({1})",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}GetObjBy{1}Completed += new EventHandler<{0}GetObjBy{1}CompletedEventArgs>(obj{0}Service_{0}GetObjBy{1}Completed);",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}GetObjBy{1}Async({2});",
            objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.PrivFuncName);

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}GetObjBy{1}Completed(object sender, {0}GetObjBy{1}CompletedEventArgs e)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.obj{0}EN = e.Result;",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (Event{0}GetObjBy{1} != null)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}GetObjBy{1}(this, e);",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelRecord_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void DelRecordWs({1} {0})",
            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_DelRecordCompleted += new EventHandler<{0}_DelRecordCompletedEventArgs>(obj{0}Service_{0}_DelRecordCompleted);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_DelRecordAsync({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_DelRecordAsync\", \"{1}:DelRecordWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"删1除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_DelRecordCompleted(object sender, {0}_DelRecordCompletedEventArgs e)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_DelRecord(this, e);",
            objPrjTabENEx.TabName);
            // throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

   
        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelMultiRecordByCond_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void Del{0}sByCondWs(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_Del{0}sByCondCompleted += new EventHandler<{0}_Del{0}sByCondCompletedEventArgs>(obj{0}Service_{0}_Del{0}sByCondCompleted); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_Del{0}sByCondAsync(strWhereCond);",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_Del{0}sByCondAsync\", \"{1}:Del{0}sByCondWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"删1除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_Del{0}sByCondCompleted(object sender, {0}_Del{0}sByCondCompletedEventArgs e)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecords = e.Result;");
            strBuilder.AppendFormat("\r\n" + "Event{0}_Del{0}sByCond(this, e);",
            objPrjTabENEx.TabName);
            // throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

   
        public string Gen_4Ws_AddNewRecordBySql_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void AddNewRecordBySql2Ws(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "string str{0}ObjXmlStr = cls{0}BL.SerializeObjToXMLStrByIso(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_AddNewRecordBySql_XMLCompleted += new EventHandler<{0}_AddNewRecordBySql_XMLCompletedEventArgs>(obj{0}Service_{0}_AddNewRecordBySql_XMLCompleted);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_AddNewRecordBySql_XMLAsync(str{0}ObjXmlStr);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_AddNewRecordBySql_XMLAsync\", \"{1}:AddNewRecordBySql2Ws\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"添1加记录出错!\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_AddNewRecordBySql_XMLCompleted(object sender, {0}_AddNewRecordBySql_XMLCompletedEventArgs e)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_AddNewRecordBySql_XML(this, e);",
            objPrjTabENEx.TabName);
            //throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        
        public string Gen_4Ws_UpdateBySql_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void UpdateBySql2Ws(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string str{0}ObjXmlStr = cls{0}BL.SerializeObjToXMLStrByIso(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_UpdateBySql_XMLCompleted += new EventHandler<{0}_UpdateBySql_XMLCompletedEventArgs>(obj{0}Service_{0}_UpdateBySql_XMLCompleted);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_UpdateBySql_XMLAsync(str{0}ObjXmlStr);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_UpdateBySql_XMLAsync\", \"{1}:UpdateBySql2Ws\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"修1改记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");





            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_UpdateBySql_XMLCompleted(object sender, {0}_UpdateBySql_XMLCompletedEventArgs e)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_UpdateBySql_XML(this, e);",
            objPrjTabENEx.TabName);
            //throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        
        public string Gen_4Ws_IsExistRecord_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "public void IsExistRecordWs(string strWhereCond)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_IsExistRecordByCondCompleted += new EventHandler<{0}_IsExistRecordByCondCompletedEventArgs>(obj{0}Service_{0}_IsExistRecordByCondCompleted);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_IsExistRecordByCondAsync(strWhereCond); ",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_IsExistRecordByCondCompleted(object sender, {0}_IsExistRecordByCondCompletedEventArgs e)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_IsExistRecordByCond(this, e);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        
        public string Gen_4Ws_IsExist_SL()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public void IsExistWs({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_IsExistCompleted += new EventHandler<{0}_IsExistCompletedEventArgs>(obj{0}Service_{0}_IsExistCompleted);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_IsExistAsync({1}); ",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}_IsExistCompleted(object sender, {0}_IsExistCompletedEventArgs e)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_IsExist(this, e);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        
        public string Gen_4Ws_GetMaxStrId_SL()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strBuilder.AppendFormat("\r\n" + "public void GetMaxStrIdWs()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//检测记录是否存在");
                strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}GetMaxStrIdCompleted += new EventHandler<{0}GetMaxStrIdCompletedEventArgs>(obj{0}Service_{0}GetMaxStrIdCompleted);",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}GetMaxStrIdAsync();",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");

                strBuilder.AppendFormat("\r\n" + "void obj{0}Service_{0}GetMaxStrIdCompleted(object sender, {0}GetMaxStrIdCompletedEventArgs e)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "Event{0}GetMaxStrId(this, e);",
                objPrjTabENEx.TabName);
                //throw new NotImplementedException();
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }
        
        public string gfungetStrLen_SL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取字符串长度,其中汉字为2个字节,英文为1个字节---------;
            strBuilder.Append("\r\npublic int GetStrLen(string strTemp)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nint len ;");
            strBuilder.Append("\r\nbyte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);");
            strBuilder.Append("\r\nlen = sarr.Length;//will output as 3+3*2 = 9");
            strBuilder.Append("\r\nreturn len;");
            strBuilder.Append("\r\n}");
            ///获取字符串长度,其中汉字为2个字节,英文为1个;
            ///私有函数 == = ;
            return strBuilder.ToString();
        }
      
        public string GenCboBindFunction_SL()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///生成仅有变量;
                //绑定下拉框的函数 代码;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {


                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.Append("\r\n /// 绑定下拉框");
                    strBuilder.Append("\r\n /// 作者:潘以锋");
                    strBuilder.Append("\r\n /// 日期:");
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.Append("\r\n /// <param name = \"objCBO\">需要绑定的下拉框</param>");
                    strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要绑定数据库的条件串</param>");
                    strBuilder.AppendFormat("\r\n" + "public void BindCbo_{0}(ComboBox objCBO, string strWhereCond)",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "cls{0}WS.objCBO = objCBO;",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}GetObjLstCompleted += new EventHandler<{0}GetObjLstCompletedEventArgs>(obj{0}Service_{0}GetObjLstCompleted); ",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}GetObjLstAsync(strWhereCond);",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "bolIsBindComboBox = true;");
                    strBuilder.Append("\r\n" + "}");

                }
            }

            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

      
        public string Gen_4Ws_SerializeObjToXMLStr_SL()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 序列化一个对象到Xml串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">需要序列化的对象关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象XML串</returns>",
            objPrjTabENEx.TabName);


            strBuilder.AppendFormat("\r\n" + "public void SerializeObjToXMLStr({0} {1})",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = new List<cls{0}EN>();",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_SerializeObjToXMLStrCompleted+= new EventHandler<{0}_SerializeObjToXMLStrCompletedEventArgs>(obj{0}Service_SerializeObjToXMLStrCompleted);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_SerializeObjToXMLStrAsync({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);


            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_SerializeObjToXMLStrCompleted(object sender, {0}_SerializeObjToXMLStrCompletedEventArgs e)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_SerializeObjToXMLStr(this, e);",
            objPrjTabENEx.TabName);
            //throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

      
        public string Gen_4Ws_SerializeObjLstToXMLStr_SL()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 序列化一个对象列表到Xml串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", objPrjTabENEx.CurrDate);
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要序列化的对象列表的条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象列表XML串</returns>",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public void SerializeObjLstToXMLStr(string strWhereCond)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = new List<cls{0}EN>();",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_SerializeObjLstToXMLStrCompleted += new EventHandler<{0}_SerializeObjLstToXMLStrCompletedEventArgs>(obj{0}Service_SerializeObjLstToXMLStrCompleted);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}Service.{0}_SerializeObjLstToXMLStrAsync(strWhereCond); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "void obj{0}Service_SerializeObjLstToXMLStrCompleted(object sender, {0}_SerializeObjLstToXMLStrCompletedEventArgs e)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Event{0}_SerializeObjLstToXMLStr(this, e);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string strXML = e.Result;");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}ObjLst = cls{0}BL.GetObjLstFromXmlStr(strXML);",
            objPrjTabENEx.TabName);
            //throw new NotImplementedException();
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_4WS_GeneEnumConstList()
        {
            string strKeyFieldName = "";
            string strNamedFieldName = "";
            string strEnglishNameFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strKeyFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")
                {
                    strNamedFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "05")
                {
                    strEnglishNameFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (string.IsNullOrEmpty(strKeyFieldName) == true) return "";
            if (string.IsNullOrEmpty(strNamedFieldName) == true) return "";
            if (string.IsNullOrEmpty(strEnglishNameFieldName) == true) return "";
            DataTable objDT;
            try
            {
                objDT = clsTablesBLEx.GetDataTableByTabName(objPrjTabENEx.TabName, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在获取表内容（GetDataTableByTabName）时出错!表名：{0},出错信息：{1}。({2})",
                    objPrjTabENEx.TabName, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据表内容设置enum列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\npublic class enum{0}WS",
                       objPrjTabENEx.TabName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// {0}", objRow[strNamedFieldName]);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n" + "public const string {0}_{1} = \"{1}\";",
                        objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            else
            {
                strBuilder.AppendFormat("\r\npublic enum enum{0} : {1}",
                objPrjTabENEx.TabName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strBuilder.AppendFormat("\r\n" + "[Description(\"{0}\")]", objRow[strNamedFieldName]);
                    strBuilder.AppendFormat("\r\n" + "{0} = {1},", objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            strBuilder.Append("\r\n}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4WS_GeneEnumConstList4Field()
        {

            string strStrConstFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.FieldTypeId == "07")
                {
                    strStrConstFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }

            if (string.IsNullOrEmpty(strStrConstFieldName) == true) return "";
            DataTable objDT;
            try
            {
                objDT = clsTablesBLEx.GetDataTableByTabName(objPrjTabENEx.TabName, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在获取表内容（GetDataTableByTabName）时出错!表名：{0},出错信息：{1}。({2})",
                    objPrjTabENEx.TabName, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strBuilder = new StringBuilder();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") continue;
                if (objField.FieldTypeId != "07") continue;
                //获取某一条件值的记录集-----------------------------;
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 根据表字段内容设置enum列表-字段名：[{0}]", objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.AppendFormat("\r\npublic class enum{0}_{1}WS",
                       objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n{");
                List<string> arrExistItem = new List<string>();
                foreach (DataRow objRow in objDT.Rows)
                {
                    string strFieldValue = objRow[objField.ObjFieldTabENEx.FldName].ToString();
                    if (arrExistItem.Contains(strFieldValue)) continue;
                    arrExistItem.Add(strFieldValue);
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// {0}", strFieldValue);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n" + "public const string con{0} = \"{0}\";",
                        strFieldValue);
                }

                strBuilder.Append("\r\n}");
            }
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WS_Access4SilverLight);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }

        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}WS", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
