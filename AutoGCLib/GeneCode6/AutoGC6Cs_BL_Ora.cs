using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;
using com.taishsoft.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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
    class AutoGC6Cs_BL_Ora : AutoGCPubFunc_Ora
    {
        //类名
        //private string objPrjTabENEx.ClsName;



        #region 构造函数

        public AutoGC6Cs_BL_Ora(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        #endregion

    

        /// <summary>
        /// 生成通用逻辑层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceCode(Encoding myEncoding)
        {
            string strFuncName = "";
            string strResult;
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                           objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            //让用户设置属性;
            string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            objPrjTabENEx.ClsName = string.Format("{0}Service", objPrjTabENEx.TabName);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Web.Services;");
                strCodeForCs.Append("\r\n" + "using System.Web.Services.Protocols;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.AppendFormat("\r\n" + "using {0};",
                objProjectsEN.PrjDomain);
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdbfororacle;"); //
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
                objProjectsEN.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} 的摘要说明",
                        objPrjTabENEx.ClsName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //  strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[WebService(Namespace = \"http://tempuri.org/\")]");
                strCodeForCs.Append("\r\n" + "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]");
                strCodeForCs.Append("\r\n" + "[ToolboxItem(false)]");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0}Service : System.Web.Services.WebService",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");

                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                                .OrderBy(x => x.OrderNum); 

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

                //把生成写到文件中;
                //检查该文件名的文件夹名,并判断是否存在;
                strFolder = clsString.ParentDir_S(strClassFName);
                if (System.IO.Directory.Exists(strFolder) == false)
                {
                    Directory.CreateDirectory(strFolder);
                }

                if (clsSysParaEN_Local.IsBackupForGeneCode == true)
                {
                    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                    string strFindFileFullFile = clsFile.FindFileFromFolder(objPrjTabENEx.FolderName_Root, strSimpleFileName);
                    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                    {
                        clsFile.FileBackup(strFindFileFullFile, objPrjTabENEx.BackupFolderName);
                        File.Delete(strFindFileFullFile);
                        strFindFileFullFile = clsFile.FindFileFromFolder(objPrjTabENEx.FolderName_Root, strSimpleFileName);

                    }
                }
                //UTF8Encoding utf8 = new UTF8Encoding(false);
                clsFile.CreateFileByString(strClassFName, strCodeForCs.ToString(), myEncoding);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
      
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenBusinessLogicCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strResult;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                              objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(1);
            
            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BL";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.BusinessLogicLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            
            //string strIsShare = objPrjTabENEx.IsShare == true ? "_1Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;

            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //类名开始
                strCodeForCs.Append("\r\n" + "using System;"); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data.OracleClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using System.Globalization;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //  strCodeForCs.Append("\r\n" + "using System.IO.IsolatedStorage;");
                //  strCodeForCs.AppendFormat("\r\n" + "using {0}_SL4WS.ServiceReference{1};",
                //  objProjectsEN.PrjDomain, objPrjTabENEx.TabName);
                //}
                strCodeForCs.Append("\r\n" + "using System.Xml;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.file;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdbfororacle;"); //
                
                //if (objPrjTabENEx.IsForSilverLight == false)
                //{
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsENEx.PrjDomain);
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.OracleClient; "); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.DAL;", objProjectsENEx.PrjDomain);

                //}

                strCodeForCs.Append("\r\n" + ""); //
                                                  //if (objPrjTabENEx.IsForSilverLight == true)
                                                  //{
                                                  //  strCodeForCs.AppendFormat("\r\n" + "namespace {0}_SL4WS",
                                                  //  objProjectsEN.PrjDomain);
                                                  //}
                                                  //else
                                                  //{
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
                objProjectsENEx.PrjDomain);
                //}
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// 数据源类型:{0}",
                objSQLDSType.SqlDsTypeName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //  strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 单项的XML结点标签");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public const string itemXmlNode = \"{0}ListItem\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 列表的XML结点标签");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public const string listXmlNode = \"{0}List\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 集合的XML结点标签");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public const string itemsXmlNode = \"Items\";");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                       objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 用于记录缓存的记录数");
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public static int intFldNumCache = 0;");


                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                                .OrderBy(x => x.OrderNum);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.", strFuncName, objException.Message);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
    
            }
            return strCodeForCs.ToString();
        }
        #region aaa
        #endregion
        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenBusinessLogicCode4View(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strResult;
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
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

               
            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BL";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.BusinessLogicLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            
            //string strIsShare = objPrjTabENEx.IsShare == true ? "_1Share" : "";
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //类名开始
                strCodeForCs.Append("\r\n" + "using System;"); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data.OracleClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using System.Globalization;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.Append("\r\n" + "using System.IO.IsolatedStorage;");
                //    strCodeForCs.AppendFormat("\r\n" + "using {0}_SL4WS.ServiceReference{1};",
                //    objProjectsEN.PrjDomain, objPrjTabENEx.TabName);
                //}
                strCodeForCs.Append("\r\n" + "using System.Xml;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.file;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");

                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdbfororacle;"); //
                

                //if (objPrjTabENEx.IsForSilverLight == false)
                //{
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsEN.PrjDomain);
                    strCodeForCs.Append("\r\n" + "using System.Data; "); //
                    strCodeForCs.AppendFormat("\r\n" + "using {0}.DAL;", objProjectsEN.PrjDomain);
                //}

                strCodeForCs.Append("\r\n" + ""); //
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "namespace {0}_SL4WS",
                //    objProjectsEN.PrjDomain);
                //}
                //else
                //{
                    strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
                    objProjectsEN.PrjDomain);
                //}
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 单项的XML结点标签");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public const string itemXmlNode = \"{0}ListItem\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 列表的XML结点标签");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public const string listXmlNode = \"{0}List\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 集合的XML结点标签");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public const string itemsXmlNode = \"Items\";");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 用于记录缓存的记录数");
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public static int intFldNumCache = 0;");
                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                  .OrderBy(x => x.OrderNum);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

               
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
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
                Type t = typeof(AutoGC6Cs_BL_Ora);
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



        public string Gen_GetDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSet(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetTopDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetTopDataSet(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet_Top(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetDataSetV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 获取记录属性
        /// </summary>
        /// <returns></returns>
        public string Gen_GetRecordProperty()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Get{0}();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetRecordPropertyV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}Get{0}V(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Get{0}();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_IsExistRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_IsExistRecordByCond(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExistRecord(\"{0}\", strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_IsExist({2} {1})",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExist({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewRecordBySQL2();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.UpdateBySql2();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_DelRecord({2} {1})",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = new cls{0}EN({1}).DelRecordBySP();",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_Del{0}s(List<string> arr{1}Lst)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.Del{0}(arr{1}Lst);",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}_Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}sByCond(strWhereCond);",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}EN ExposeLogicClass(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{ ");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicExClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}Ex ExposeLogicExClass(cls{0}Ex obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "} ");
            return strBuilder.ToString();
        }



        public string Gen_4BL_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 类的构造函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }



        public string Gen_4BL_GetDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.GetDataTable(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable", "获取表:{0} 数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 数据出错!({1}: GetDataTable)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数据出错!\\r\\n({1}:GetDataTable)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}(strWhereCond, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable", "获取表:{0} 数据出错!(排除的检查字符串列表)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 数据出错!(排除的检查字符串列表)({1}: GetDataTable)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数据出错!(排除的检查字符串列表)\\r\\n({1}:GetDataTable)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查SQL攻击</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, bool bolIsCheckSQLAttack)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}(strWhereCond, bolIsCheckSQLAttack);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable", "获取表:{0} 数据出错!(是否检查SQL攻击)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 数据出错!(是否检查SQL攻击)({1}: GetDataTable)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数据出错!(是否检查SQL攻击)\\r\\n({1}:GetDataTable)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }
        public string Gen_4BL_GetDataTableByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}ByRange(strWhereCond, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "根据条件获取范围中数据表:{0} 数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})根据条件获取范围中数据表:{0} 数据出错!({1}:GetDataTableByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"根据条件获取范围中数据表:{0} 数据出错!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}ByRange(strWhereCond, lstExclude, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "根据条件获取范围中数据表:{0} 数据出错!(同时可以排除一些关键字不检查)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})根据条件获取范围中数据表:{0} 数据出错!(同时可以排除一些关键字不检查)({1}:GetDataTableByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"根据条件获取范围中数据表:{0} 数据出错!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查SQL攻击</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}ByRange(strWhereCond, bolIsCheckSQLAttack, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "根据条件获取范围中数据表:{0} 数据出错!(同时检查是否含有SQL攻击)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})根据条件获取范围中数据表:{0} 数据出错!(同时检查是否含有SQL攻击)({1}:GetDataTableByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"根据条件获取范围中数据表:{0} 数据出错!(同时检查是否含有SQL攻击)\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetDataSet(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSet", "获取表:{0} 数据集出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 数据集出错!({1}:GetDataSet)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数据集出错!\\r\\n({1}:GetDataSet)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetTopDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetTopDataSet_" + objPrjTabENEx.TabName + "(int intTopSize, string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetTopDataSet_{0}(intTopSize, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetTopDataSet_{0}", "获取表:{0} 数据集出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 数据集出错!({1}:GetTopDataSet_{0})\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数据集出错!\\r\\n({1}:GetDataSet)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataSetByCondByRange_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetByRange(string strCondition, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetDataSetByRange(strCondition, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetByRange", "获取表:{0} 带范围的数据集出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 带范围的数据集出错!({1}:GetDataSetByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 带范围的数据集出错!\\r\\n({1}:GetDataSetByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataSetByCond_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取当前表视图的数据集,用DataSet表示");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回当前表视图的数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetV(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetDataSetV(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetV", "获取表:{0} 视图的数据集出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 视图的数据集出错!({1}:GetDataSetV)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 视图的数据集出错!\\r\\n({1}:GetDataSetV)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_GetDataSetByCondByRange_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetVByRange(string strCondition, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetDataSetVByRange(strCondition, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetVByRange", "获取表:{0} 视图的数据集出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 视图的带范围数据集出错!({1}:GetDataSetVByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 视图的带范围数据集出错!\\r\\n({1}:GetDataSetVByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetDataTableV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取当前表视图的数据表,用DataTable表示");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回当前表视图的数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}V(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableV", "获取表:{0} 视图的数据集出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 视图的数据出错!({1}:GetDataTableV)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 视图的数据出错!\\r\\n({1}:GetDataTableV)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表的视图,用DataTable表示,同时可以排除一些关键字不检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableV(string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}V(strWhereCond, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableV", "获取表:{0} 视图的数据出错!(同时可以排除一些关键字不检查)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 视图的数据出错!(同时可以排除一些关键字不检查)({1}:GetDataTableV)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 视图的数据出错!(同时可以排除一些关键字不检查)\\r\\n({1}:GetDataTableV)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableVByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}VByRange(strWhereCond, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "获取表:{0} 视图的带范围数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 视图的带范围数据出错!({1}:GetDataTableVByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 视图的带范围数据出错!\\r\\n({1}:GetDataTableVByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, List<string> lstExclude, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}VByRange(strWhereCond, lstExclude, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "获取表:{0} 视图的带范围数据出错!(同时可以排除一些关键字不检查)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 视图的带范围数据出错!(同时可以排除一些关键字不检查)({1}:GetDataTableVByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数据出错!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查SQL攻击</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}VByRange(strWhereCond, bolIsCheckSQLAttack, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "获取表:{0} 视图的带范围数据出错!(同时检查是否含有SQL攻击)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取表:{0} 视图的带范围数据出错!(同时检查是否含有SQL攻击)({1}:GetDataTableVByRange)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数据出错!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetDataTableV2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static DataTable Get{0}(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}DA.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception (\"获取表View数据出错!\\r\\n(cls{0}DA:Get{0})\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_RecObjLstFromDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据提供的DataTable获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objDT\">提供的DataTable</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstFromDataTable(DataTable objDT)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            //strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            //strBuilder.AppendFormat("\r\n objDT = GetDataTable(strCondition);",
            //objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            //
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }



        public string Gen_4BL_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"转换DataRow成clsvFuncParaRelaEN对象出错, 关键字:[{0}]。{1}. (In {2})\",");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1}, objException.Message, clsStackTrace.GetCurrClassFunction());", 
                objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">查询条件中排除的标志列表</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(string strCondition, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strCondition, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_GetObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(string strCondition, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByRange(strCondition, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">查询条件中排除的标志列表</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByRange(strCondition, lstExclude, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetObjLst2()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> {0}List(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strCondition);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecordProperty4Object()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据对象的关键字值,获取对象的全部属性");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">相关对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjByKeyId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{2}({1})",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                      && objPrjTabENEx.arrKeyFldSet.Count == 1)
            {

                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, string.Format("GetObjBy{1}", objPrjTabENEx.TabName, objKeyField.FldName),
                        string.Format("在表[{1}]中,关键字[{0}]不能为空!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName), "生成代码");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{2})在表[{1}]中,关键字[{0}]不能为空!(cls{1}BL:Get{1}By{3})\");",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName, strErrId,
                         objKeyField.FldName);
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}DA.GetObjBy{1}({2});",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_CopyObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo", "Copy表:{0} 对象数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool DelRecord({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.DelRecord({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecord", "删除记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})删除记录出错!({1}:DelRecord)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"删除记录出错!({1}: DelRecord)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_DelRecordBySign()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool DelRecordBySign({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.DelRecordBySign({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecordBySign", "根据标志删除记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})根据标志删除记录出错!({1}:DelRecord)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"删除记录出错!({1}: DelRecord)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_UnDelRecordBySign()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UnDelRecordBySign({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.UnDelRecordBySign({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecordBySign", "根据标志删除记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})根据标志删除记录出错!({1}:DelRecord)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"删除记录出错!({1}: DelRecord)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelRecordWithTransaction_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指的记录,使用事务");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>返回删除是否成功?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool DelRecord({0}, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.DelRecord({1},objOracleConnection,objOracleTransaction);",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecord", "删除记录出错!(使用事务)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})删除记录出错!(使用事务)({1}:DelRecord)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"删除记录出错!(使用事务)({1}: DelRecord)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_DelRecordBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            ///
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");
            string strTemp = string.Format("public bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.DelRecordBySP({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecordBySP", "通过存储过程删除记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})通过存储过程删除记录出错!({1}:DelRecordBySP)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"通过存储过程删除记录出错!({1}:DelRecordBySP)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            ///public bool Addnew {TabName}BySP() == ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:同时删除多条记录,删除给定关键字列表的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">给定的关键字值列表</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>返回删除是否成功?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Del{0}s(List<string> arr{1}Lst)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.Del{0}(arr{1}Lst);",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}s", "删除多记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})删除多记录出错!({1}:Del{0}s)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"删除多记录出错!({1}: Del{0}s)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除多条记录根据条件
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除满足条件的多条记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要删除的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>返回删除的记录数。</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}DA.Del{0}(strWhereCond);",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}sByCond", "删除满足条件的多条记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})删除满足条件的多条记录出错!({1}:Del{0}sByCond)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"删除满足条件的多条记录出错!({1}: Del{0}sByCond)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除多条记录根据条件
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelMultiRecordByCondWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除满足条件的多条记录.(带事务处理)");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要删除的记录条件</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>返回是否删除成功。</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Del{0}sByCondWithTransaction_S(string strWhereCond, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.Del{0}WithTransaction_S(strWhereCond, objOracleConnection, objOracleTransaction);",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}sByCondWithTransaction_S", "删除满足条件的多条记录出错!(同时处理事务)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})删除满足条件的多条记录出错!(同时处理事务)({1}:Del{0}sByCondWithTransaction_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"删除满足条件的多条记录出错!(同时处理事务)({1}: Del{0}WithTransaction_S)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.AddNewRecordBySQL2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2", "添加记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})添加记录出错!({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql2WithTransaction_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql2(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.AddNewRecordBySQL2(obj{0}EN, objOracleConnection, objOracleTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2", "添加记录出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})添加记录出错!(带事务处理)({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!(带事务处理)({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql2WithReturnKey()
        {
            if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strKey = obj{0}DA.AddNewRecordBySQL2WithReturnKey(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2WithReturnKey", "带返回值的添加记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})带返回值的添加记录出错!({1}:AddNewRecordBySql2WithReturnKey)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"带返回值的添加记录出错!({1}: AddNewRecordBySql2WithReturnKey)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_AddNewRecordBySql2WithReturnKeyAndTransaction_S()
        {
            if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值,该函数可以进行事务处理");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");

            strBuilder.Append("\r\n /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strKey = obj{0}DA.AddNewRecordBySQL2WithReturnKey(obj{0}EN, objOracleConnection, objOracleTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2WithReturnKey", "带返回值的添加记录出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})带返回值的添加记录出错!(带事务处理)({1}:AddNewRecordBySql2WithReturnKey)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"带返回值的添加记录出错!(带事务处理)({1}: AddNewRecordBySql2WithReturnKey)\\r\\n\" + objException.Message);",
            //      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">代表实体对象的XML串</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = GetObjFromXmlStr(str{0}ObjXml);",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.AddNewRecordBySQL2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql_XML", "添加记录出错!(使用XML)", "生成代码");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})添加记录出错!(使用XML)({1}: AddNewRecordBySql_XML)\\r\\n\" + objException.Message);",
                 objPrjTabENEx.TabName,
                 objPrjTabENEx.ClsName,
                 strErrId);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_Update()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Update(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.Update(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
            objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update", "修改记录(Update)出错!", "生成代码");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})修改记录(Update)出错!({1}: Update)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "修改记录(UpdateBySql2)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})修改记录(UpdateBySql2)出错!({1}: UpdateBySql2)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_UpdateBySql2WithTransaction_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.Append("\r\n /// /// 3、支持事务处理.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(cls{0}EN obj{0}EN, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySql2(obj{0}EN, objOracleConnection, objOracleTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
          objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "修改记录(UpdateBySql2)出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})修改记录(UpdateBySql2)出错!(带事务处理)({1}: UpdateBySql2)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.Append("\r\n" + "throw new Exception(\"修改记录(UpdateBySql2)出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_UpdateBySqlWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strCondition\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySqlWithCondition(cls{0}EN obj{0}EN, string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySqlWithCondition(obj{0}EN, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySqlWithCondition", "修改记录(UpdateBySqlWithCondition)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})修改记录(UpdateBySqlWithCondition)出错!({1}: UpdateBySql2)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.Append("\r\n" + "throw new Exception(\"修改记录(UpdateBySqlWithCondition)出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_UpdateBySqlWithConditionTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strCondition\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objOracleTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySqlWithConditionTransaction(cls{0}EN obj{0}EN, string strCondition, OracleConnection objOracleConnection, OracleTransaction objOracleTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySqlWithConditionTransaction(obj{0}EN, strCondition, objOracleConnection, objOracleTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySqlWithConditionTransaction", "修改记录(UpdateBySqlWithConditionTransaction)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})修改记录(UpdateBySqlWithConditionTransaction)出错!({1}: UpdateBySqlWithConditionTransaction)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.Append("\r\n" + "throw new Exception(\"修改记录(UpdateBySqlWithConditionTransaction)出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_UpdateBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">需要修改的对象,用XML来表示</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = GetObjFromXmlStr(str{0}ObjXml);",
            objPrjTabENEx.TabName);


            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql_XML", "修改记录(UpdateBySql_XML)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})修改记录(UpdateBySql_XML)出错!({1}: UpdateBySql_XML)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.Append("\r\n" + "throw new Exception(\"修改记录(UpdateBySql_XML)出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_IsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:判断是否存在某一条件的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>");
            strBuilder.Append("\r\n" + "public static bool IsExistRecord(string strCondition)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}DA.IsExistCondRec(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");

            strBuilder.AppendFormat("\r\npublic static {0} GetFirstID_S(string strCondition) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n {0} {1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n {0} = cls{1}DA.GetFirstID_S(strCondition);",
            objKeyField.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return {0};", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetFirstID_S", "获取First关键字出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取First关键字出错!({1}: GetFirstID_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n throw new Exception(\"获取First关键字出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetPrimaryKeyID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的关键字值列表");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件的关键字列表值</returns>");

            strBuilder.Append("\r\npublic static List<string> GetPrimaryKeyID_S(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n List<string> arrList;");
            //strBuilder.AppendFormat("\r\n {0} {1};",
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arrList = new cls{0}DA().GetID(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return arrList;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetPrimaryKeyID_S", "获取关键字列表出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取关键字列表出错!({1}: GetPrimaryKeyID_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n throw new Exception(\"获取关键字列表出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetMaxStrID_S()
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";

            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");

            strBuilder.Append("\r\npublic static string GetMaxStrId_S() ");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n string strMax{1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strMax{0} = cls{1}DA.GetMaxStrId();",
            objKeyField.FldName_FstUcase, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return strMax{0};", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetMaxStrId_S", "获取最大关键字值(GetMaxStrId)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})获取最大关键字值(GetMaxStrId)出错!({1}: GetMaxStrId_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n throw new Exception(\"获取最大关键字值(GetMaxStrId)出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }


        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_IsExistTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查是否存在当前表");
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.Append("\r\n /// <returns>存在就返回True,否则返回False</returns>");

            strBuilder.Append("\r\npublic static bool IsExistTable() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n bool bolIsExist;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n bolIsExist = cls{0}DA.IsExistTable();",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return bolIsExist;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "IsExistTable", "检查是否存在当前表(IsExistTable)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})检查是否存在当前表(IsExistTable)出错!({1}: IsExistTable)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            //strBuilder.AppendFormat("\r\n throw new Exception(\"检查是否存在当前表(IsExistTable)出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查是否存在当前表");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">给定表</param>");
            strBuilder.Append("\r\n /// <returns>存在就返回True,否则返回False</returns>");

            strBuilder.Append("\r\npublic static bool IsExistTable(string strTabName) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n bool bolIsExist;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n bolIsExist = cls{0}DA.IsExistTable(strTabName);",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return bolIsExist;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "IsExistTable", "检查是否存在指定表(IsExistTable)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})检查是否存在指定表(IsExistTable)出错!({1}: IsExistTable)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            //strBuilder.AppendFormat("\r\n throw new Exception(\"检查是否存在指定表(IsExistTable)出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }


        /// <summary>
        /// 生成代码:提供条件,查询相关记录对象,结果有多个对象,获取其中的第一个,返回类型是类类型
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetFirstObject_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的对象");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的对象</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetFirstObj_S(string strCondition) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}DA().GetFirst{0}(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"在根据条件获取第一个对象时,发生:{{0}},请检查!({1}: GetFirst{0})\", objException.Message));",
         objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }


        /// <summary>
        /// 生成代码:提供条件,查询相关记录对象,结果有多个对象,获取其中的第一个,返回类型是类类型
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecValueObjByDataRow_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把DataRow转换成相关实体对象");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRow\">给定的DataRow</param>");
            strBuilder.Append("\r\n /// <returns>返回相关的实体对象</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetObjByDataRow_S(DataRow objRow) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}DA().GetObjByDataRow(objRow);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "getObjByDataRow_S", "根据DataRow记录获取对象出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})根据DataRow记录获取对象出错!({1}: GetObjByDataRow_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n throw new Exception(\"通过DataRow记录对象出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");

            //StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把DataRowView(GridView行对象)转换成相关实体对象");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRow\">给定的DataRowView</param>");
            strBuilder.Append("\r\n /// <returns>返回相关的实体对象</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetObjByDataRow_S(DataRowView objRow) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}DA().GetObjByDataRow(objRow);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "getObjByDataRow_S", "根据DataRowView记录获取对象出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{2})根据DataRowView记录获取对象出错!({1}: GetObjByDataRow_S)\\r\\n\" + objException.Message);",
              objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n throw new Exception(\"通过DataRow记录对象出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }


        public string Gen_4BL_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 判断当前表中是否存在给定关键字值的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回是否存在?</returns>");

            strBuilder.AppendFormat("\r\n" + "public static bool IsExist({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objPrjTabENEx.arrKeyFldSet.Count == 1)
            {

                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, string.Format("IsExist", objPrjTabENEx.TabName, objKeyField.FldName),
                    string.Format("在表[{1}]中,关键字[{0}]不能为空!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                     objPrjTabENEx.TabName), "生成代码");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{2})在表[{1}]中,关键字[{0}]不能为空!(cls{1}BL:IsExist)\");",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName,
                         strErrId);
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }

            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}DA.IsExist({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_4BL_IsExistByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 判断当前表中是否存在给定关键字值的记录");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <param name = \"strId_School\">给定的学校</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回是否存在?</returns>");

            strBuilder.AppendFormat("\r\n" + "public static bool IsExist({0}, string strTabName)",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objPrjTabENEx.arrKeyFldSet.Count == 1)
            {

                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, string.Format("IsExistByTabName", objPrjTabENEx.TabName, objKeyField.FldName),
                    string.Format("在表[{1}]中,关键字[{0}]不能为空!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                     objPrjTabENEx.TabName), "生成代码");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{2})在表[{1}]中,关键字[{0}]不能为空!(cls{1}BL:IsExist)\");",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName,
                         strErrId);
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }

            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}DA.IsExist({1}, strTabName);",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_4BL_CheckUniqueness()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                    
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(主键)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\n" + "//检测记录是否存在");
                    strBuilder.AppendFormat("\r\n" + "bool bolIsUniqueness = cls{0}DA.Check{1}Uniqueness({3}, {5});",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n" + "return bolIsUniqueness;");
                    strBuilder.Append("\r\n" + "}");
                }
            }
            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_CheckUniquenessV2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 检查唯一性,单个字段(Uniqueness)--{0}({1})",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(主键)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}UniquenessSingleField(cls{1}EN obj{1}EN)",
                    objField.ObjFieldTabENEx.FldName,
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\n" + "//检测记录是否存在");

                    strBuilder.Append("\r\n" + "bool bolIsUniqueness;");
                    strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
                    objPrjTabENEx.TabName);

                    switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "int":
                        case "long":
                        case "short":
                            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                            objPrjTabENEx.TabName,
                            objKeyField.FldName);
                            break;
                        case "string":
                            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                            objPrjTabENEx.TabName,
                            objKeyField.PropertyName(this.IsFstLcase));
                            break;
                        default:
                            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                            objPrjTabENEx.TabName,
                            objKeyField.PropertyName(this.IsFstLcase));
                            break;
                    }
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}DA.Check{1}Uniqueness(",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1});",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "else");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}DA.Check{1}Uniqueness(",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{2}, obj{0}EN.{1});",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.FldName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "return bolIsUniqueness;");

                    strBuilder.Append("\r\n" + "}");
                }
            }
            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CheckUniquenessV3()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
              objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);

            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求唯一的对象</param>",
                   objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness(cls{0}EN obj{0}EN)",
                         objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");

            strBuilder.Append("\r\n" + "bool bolIsUniqueness;");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
            objPrjTabENEx.TabName);

            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "int":
                case "long":
                case "short":
                    strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName);
                    break;
                case "string":
                    strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                    objPrjTabENEx.TabName,
                    objKeyField.PropertyName(this.IsFstLcase));
                    break;
                default:
                    strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                    objPrjTabENEx.TabName,
                    objKeyField.PropertyName(this.IsFstLcase));
                    break;
            }
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}DA.Check{0}Uniqueness(",
            objPrjTabENEx.TabName);
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique = false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                if (bolIsFirst == true)
                {

                    strBuilder.AppendFormat("obj{0}EN.{1}",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    bolIsFirst = false;
                }
                else
                {
                    strBuilder.AppendFormat(", obj{0}EN.{1}",
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName);
                }
            }
            strBuilder.Append(");");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}DA.Check{0}Uniqueness(",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("obj{0}EN.{1}",
            objPrjTabENEx.TabName,
            objKeyField.FldName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique = false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;
                strBuilder.AppendFormat(", obj{0}EN.{1}",
                objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);

            }
            strBuilder.Append(");");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return bolIsUniqueness;");

            strBuilder.Append("\r\n" + "}");


            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }

      



        public string Gen_4BL_GetUniquenessConditionString()
        {
            StringBuilder strBuilder = new StringBuilder();
            int intVerCount = 1;
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;
         
                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取检查唯一性条件串(Uniqueness)--{0}({1})",
                  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strBuilder.Append($"\r\n /// 唯一性条件:{objInFor.ConstraintName4GC()}");

                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求唯一的对象</param>",
                       objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strBuilder.Append("\r\n /// <returns></returns>");
                strBuilder.Append($"\r\npublic static string GetUniCondStr{strVersion}(cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\n" + "//检测记录是否存在");

                strBuilder.AppendFormat("\r\n" + "string strResult = cls{0}DA.GetUniCondStr(",
                objPrjTabENEx.TabName, objInFor.ConstraintName4GC());
                strBuilder.AppendFormat("obj{0}EN.{1}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
                //bool bolIsFirst = true;
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsTabUnique = false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                    strBuilder.AppendFormat(", obj{0}EN.{1}",
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName);

                }
                strBuilder.Append(");");
                strBuilder.Append("\r\n" + "return strResult;");

                strBuilder.Append("\r\n" + "}");

            }
            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //检测记录是否存在
            strBuilder.AppendFormat("\r\n cls{0}DA.CheckPropertyNew(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            ///检查类中属性是否正确 == == ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_CheckProperty4Condition()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckProperty4Condition(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //检测记录是否存在
            strBuilder.AppendFormat("\r\n cls{0}DA.CheckProperty4Condition(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            ///检查类中属性是否正确 == == ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_ComboBoxBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            bool bolIsNeedQuote = true;
            clsDataTypeAbbrEN objDataTypeAbbr4ValueField = null;
            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                        bolIsNeedQuote = objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote;
                        objDataTypeAbbr4ValueField = objField.ObjFieldTabENEx.objDataTypeAbbrEN;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Win的下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objComboBox\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源为表的下拉框设置内容");
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObj = cls{0}BL.GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//初始化一个对象列表");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                    if (bolIsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = 0;",
                        objPrjTabENEx.TabName, strValueFieldName);

                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"选[{2}]...\";",
                    objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//把DataTable中的所有项均加到对象列表中");
                    strCodeForCs.AppendFormat("\r\n" + "foreach(cls{0}EN objInFor in arrObj)", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(objInFor);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");

                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = cls{0}EN.con_{1};",
                     objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = cls{0}EN.con_{1};",
                     objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4BL_DdlBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {


                    //				
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Web的下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objDDL\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
           

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"选[{0}]...\",\"0\");",
                        objPrjTabENEx.TabCnName);
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{1}DA.Get{0}();",
                    strValueFieldName, objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};", objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};", objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");


                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Web的下拉框-使用Cache");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objDDL\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}Cache(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"选[{0}]...\",\"0\");",
                          objPrjTabENEx.TabCnName);
                    //strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{1}DA.Get{0}();",
                    //strValueFieldName, objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = GetAll{0}ObjLstCache(); ",
                              objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};", objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};", objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataSource = arr{0}ObjLst;",
                              objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetJSONObjByKeyCache()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象, 从缓存的对象列表中获取.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.Append("\r\n" + "int intStart = 0;");
            strBuilder.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMid = 0;");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "while (intEnd >= intStart)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                 objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intEnd = intMid - 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intStart = intMid + 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            //strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //objPrjTabENEx.TabName,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "}");
            //clsSysParaEN_Local.strVersion
            strBuilder.Append("\r\n" + "intFindFailCount++;");
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return GetObjBy{1}Cache({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录[{3} = {{0}}][intFindFailCount = {{1}}](函数:{{2}})\", {4}, intFindFailCount);",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"最后一次查找的对象相关字段属性值:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"最后一次查找的对象为null, 请检查![intMid = {{0}}]\", intMid);",
               "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName);
            //strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strErrMsgForGetObjById);");

            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetJSONObjByKeyCache_Once()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象, 从缓存的对象列表中获取.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache_Once({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.Append("\r\n" + "int intStart = 0;");
            strBuilder.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMid = 0;");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "while (intEnd >= intStart)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                 objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intEnd = intMid - 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intStart = intMid + 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "return null;");
            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.使用顺序查询
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetJSONObjByKeyCache_Seq()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache_Seq({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "intFindFailCount++;");
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return GetObjBy{1}Cache_Seq({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录[{3} = {{0}}][intFindFailCount = {{1}}](函数:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName);



            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName);
            //strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strErrMsgForGetObjById);");

            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }



        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.使用顺序查询
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetJSONObjByKeyCache_Seq_Once()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache_Seq_Once({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "return null;");


            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetAllRecObjLstCache()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 从缓存中获取所有对象列表.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <returns>从缓存中获取的所有对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetAll{0}ObjLstCache()",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
              objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjLstCache()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 从缓存中获取所有对象列表.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <returns>从缓存中获取的所有对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstCache()",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
              objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 根据关键字列表获取相关对象列表.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjLstByKeyLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字列表获取相关对象列表.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">所给的关键字</param>", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstBy{1}Lst(List<{2}> arr{1}Lst)",
            objPrjTabENEx.TabName,
            objKeyField.FldName_FstUcase,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n StringBuilder sbCondition = new StringBuilder();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n string strSqlConditionStr = clsArray.GetSqlInStrByArray(arr{0}Lst, true);", objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n string strSqlConditionStr = clsArray.GetSqlInStrByArray(arr{0}Lst);", objKeyField.FldName_FstUcase);
            }
            strBuilder.AppendFormat("\r\n string strCondition = string.Format(\"{0} in ({{0}})\", strSqlConditionStr);", objKeyField.FldName, "{", "}");


            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");



            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecNameByKeyCache()
        {
            string strTextFieldName = "";
            string strValueFieldName = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            if (objPrjTabENEx.IsUseCache == false) return string.Format("//该表没有使用Cache,不需要生成[Get{0}By{1}Cache]函数;",
        strTextFieldName, objKeyField.FldName);

            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关名称, 从缓存的对象列表中获取.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.Append("\r\n" + "int intStart = 0;");
            strBuilder.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMid = 0;");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "while (intEnd >= intStart)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
             objPrjTabENEx.TabName,
             strTextFieldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                 objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intEnd = intMid - 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intStart = intMid + 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //objPrjTabENEx.TabName,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
            //objPrjTabENEx.TabName,
            //strTextFieldName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "intFindFailCount++;");
            strBuilder.AppendFormat("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}Cache({2});",
                strTextFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录[{3} = {{0}}][intFindFailCount = {{1}}](函数:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"最后一次查找的对象相关字段属性值:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"最后一次查找的对象为null, 请检查![intMid = {{0}}]\", intMid);",
               "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关名称, 从缓存的对象列表中获取.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string GetNameBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.Append("\r\n" + "int intStart = 0;");
            strBuilder.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMid = 0;");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "while (intEnd >= intStart)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
             objPrjTabENEx.TabName,
             strTextFieldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                 objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intEnd = intMid - 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intStart = intMid + 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //objPrjTabENEx.TabName,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
            //objPrjTabENEx.TabName,
            //strTextFieldName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "intFindFailCount++;");
            strBuilder.AppendFormat("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}Cache({2});",
                strTextFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录[{3} = {{0}}][intFindFailCount = {{1}}](函数:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"最后一次查找的对象相关字段属性值:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"最后一次查找的对象为null, 请检查![intMid = {{0}}]\", intMid);",
               "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");
            
            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetJSONObjByKeyFromList()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象, 从给定的对象列表中获取.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">给定的对象列表</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}FromList({2} {3}, List<cls{0}EN> lst{0}ObjLst)",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in lst{0}ObjLst)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 读XmlReader到一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecObjByXmlReader()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///读XmlReader到一个对象-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 读XmlReader到一个对象");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"reader\">提供的数据源:XmlReader</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回的一个对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjFromXml(System.Xml.XmlReader reader)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "reader.Read();");
            strBuilder.AppendFormat("\r\n" + "while (!(reader.Name == cls{0}BL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "if (reader.IsStartElement(cls{1}EN.con_{0}))",
                      objField.ObjFieldTabENEx.FldName,
                      objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "{");
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "bool":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsBoolean());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "int":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsInt());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsLong());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "float":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsFloat());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "double":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsDouble());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "DateTime":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsDateTime());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;

                        case "short":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}((short)reader.ReadElementContentAsInt());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "Int16":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsInt());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "Int32":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsInt());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "byte":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsByte());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "byte[]":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(reader.ReadElementContentAsBytes());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        default:
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}( reader.ReadElementContentAsString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                    }
                    strBuilder.Append("\r\n" + "}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "if (reader.IsStartElement(cls{1}EN.con_{0}))",
                      objField.ObjFieldTabENEx.FldName,
                      objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "{");
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "string":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsString();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "bool":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsBoolean();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "int":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsInt();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "long":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsLong();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "float":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsFloat();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "double":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsDouble();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "DateTime":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsDateTime();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;

                        case "short":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (short)reader.ReadElementContentAsInt();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "Int16":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsInt();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "Int32":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsInt();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "byte":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsByte();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        case "byte[]":
                            //strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsBytes();",
                            //objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                        default:
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsString();",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                            break;
                    }
                    strBuilder.Append("\r\n" + "}");
                }
            }

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 从XML文件中获取一个对象列表.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjLstFromXmlFile()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///从XML文件中获取一个对象列表-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 从XML文件中获取一个对象列表");
            strBuilder.AppendFormat("\r\n /// 作者:{0}",
            objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strXmlFileName\">提供的一个XML文件</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回一个[cls{0}EN]对象列表</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstFromXmlFile(string strXmlFileName)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}Obj = new List<cls{0}EN>();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "XmlReader reader = XmlReader.Create(strXmlFileName);");
            strBuilder.AppendFormat("\r\n" + "while (reader.ReadToFollowing(cls{0}BL.itemXmlNode))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = GetObjFromXml(reader);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lst{0}Obj.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return lst{0}Obj;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// 从XML串中获取一个对象列表.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjLstFromXmlStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///从XML串中获取一个对象列表.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 从XML串中获取一个对象列表");
            strBuilder.AppendFormat("\r\n /// 作者:{0}",
            objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}listXml\">提供的一个XML串</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个[cls{0}EN]对象列表</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstFromXmlStr(string str{0}listXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}Obj = new List<cls{0}EN>();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "UTF8Encoding enc = new UTF8Encoding();");
            strBuilder.AppendFormat("\r\n" + "using (MemoryStream ms = new MemoryStream(enc.GetBytes(str{0}listXml)))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "XmlReaderSettings xmlrs = new XmlReaderSettings();");
            strBuilder.AppendFormat("\r\n" + "xmlrs.IgnoreComments = true;");
            strBuilder.AppendFormat("\r\n" + "xmlrs.IgnoreWhitespace = true;");
            strBuilder.AppendFormat("\r\n" + "XmlReader reader = XmlReader.Create(ms, xmlrs);");

            strBuilder.AppendFormat("\r\n" + "while (reader.ReadToFollowing(cls{0}BL.itemXmlNode))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = GetObjFromXml(reader);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lst{0}Obj.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return lst{0}Obj;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 把一个对象序列化到XML中.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeXML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 把一个对象序列化到XML中");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"writer\">目标:序列化到的XmlWriter</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">数据源:需要序列化的对象</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static void SerializeXML(XmlWriter writer, cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "writer.WriteStartElement(cls{0}BL.itemXmlNode);",
            objPrjTabENEx.TabName);


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                string strTemp = GetCode4FieldInSerializeXML(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);
            }

            strBuilder.AppendFormat("\r\n" + "writer.WriteEndElement();");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 序列化一个对象列表到XmlWriter.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjLstToXML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 序列化一个对象列表到XmlWriter");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">[cls{0}EN]对象列表</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"writer\">提供的一个XmlWriter对象</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回是否成功?</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static bool SerializeObjLstToXML(List<cls{0}EN> lst{0}ObjLst, XmlWriter writer)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "writer.WriteStartElement(cls{0}BL.listXmlNode);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "writer.WriteStartElement(cls{0}BL.itemsXmlNode);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in lst{0}ObjLst)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}BL.SerializeXML(writer, obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "writer.WriteEndElement();");
            strBuilder.AppendFormat("\r\n" + "writer.WriteEndElement();");
            strBuilder.AppendFormat("\r\n" + "return true;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// 序列化一个对象列表到Xml文件.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjLstToXMLFile()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 序列化一个对象列表到Xml文件");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">需要序列化的对象列表</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"strXmlFile\">生成的XML文件</param>");
            strBuilder.AppendFormat("\r\n" + "public static void SerializeObjLstToXMLFile(List<cls{0}EN> lst{0}ObjLst, string strXmlFile)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "settings.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "settings.IndentChars = (\" \");");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "SerializeObjLstToXML(lst{0}ObjLst, writer);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// 序列化一个对象列表到Xml文件.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjLstToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 序列化一个对象列表到Xml文件");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">需要序列化的对象列表</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个生成的XML串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjLstToXMLStr(List<cls{0}EN> lst{0}ObjLst)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strXmlFile = clsSysParaEN.strTempXMLFileName;");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "settings.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "settings.IndentChars = (\" \");");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SerializeObjLstToXML(lst{0}ObjLst, writer);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "};");

            strBuilder.AppendFormat("\r\n" + "string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);");
            strBuilder.AppendFormat("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 序列化一个对象列表到JSON串.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjLstToJSONStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 序列化一个对象列表到JSON串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">需要序列化的对象列表</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个生成的JSON串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjLstToJSONStr(List<cls{0}EN> lst{0}ObjLst)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "StringBuilder sbJSON = new StringBuilder();");
            strBuilder.Append("\r\n" + "sbJSON.Append(\"{\");");
            strBuilder.AppendFormat("\r\n" + "sbJSON.AppendFormat(\"\\\"RecCount\\\":\\\"{{0}}\\\",\", lst{2}ObjLst.Count);",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "sbJSON.Append(\"\\\"data\\\":[\");");
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in lst{0}ObjLst)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJSON_One = SerializeObjToJSON(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "sbJSON.AppendFormat(\"{{0}},\", strJSON_One);",
              "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "sbJSON.Remove(sbJSON.Length - 1, 1);");
            strBuilder.Append("\r\n" + "sbJSON.Append(\"]}\");");
            strBuilder.Append("\r\n" + "return sbJSON.ToString();");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 序列化一个对象到Xml文件.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 序列化一个对象到Xml文件");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要序列化的对象</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个生成的XML串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToXMLStr(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strXmlFile = clsSysParaEN.strTempXMLFileName;");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "settings.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "settings.IndentChars = (\" \");");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SerializeXML(writer, obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);");
            strBuilder.AppendFormat("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_func()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 映射函数。根据表映射把输入字段值,映射成输出字段值");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strInFldName\">输入字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strOutFldName\">输出字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strInValue\">输入字段值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回一个输出字段值</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string Func(string strInFldName, string strOutFldName, string strInValue)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "if (strInFldName != con{0}.{1})", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"输入字段名:[{0}]不正确!\", strInFldName);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (con{0}._AttributeName.Contains(strOutFldName) == false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"输出字段名:[{0}]不正确,不在输出字段范围之内!({1})\",");
            strBuilder.AppendFormat("\r\n" + "strInFldName, string.Join(\", \", con{0}._AttributeName));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "const obj{0} = cls{0}BL.GetObjBy{1}Cache(strInValue);", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0} == null) return \"\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}[strOutFldName].ToString();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 序列化一个对象到JSON.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjToJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 序列化一个对象到JSON");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要序列化JSON的对象</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个生成的JSON串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToJSON(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "StringBuilder sbJSON = new StringBuilder();");
            strBuilder.Append("\r\n" + "sbJSON.Append(\"{\");");
            strBuilder.AppendFormat("\r\n" + "foreach (string strField in cls{0}EN._AttributeName)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "sbJSON.AppendFormat(\"\\\"{{0}}\\\":\\\"{{1}}\\\",\", strField, obj{2}EN[strField]);",
              "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "sbJSON.Remove(sbJSON.Length - 1, 1);");
            strBuilder.Append("\r\n" + "sbJSON.Append(\"}\");");
            strBuilder.Append("\r\n" + "return sbJSON.ToString();");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }



        /// <summary>
        /// 序列化一个对象到Xml文件,利用隔离文件
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjToXMLStrIso()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 序列化一个对象到Xml文件,利用隔离文件");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要序列化的对象</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象XML串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToXMLStrByIso(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            //if (objPrjTabENEx.IsForSilverLight == true)
            //{
            //    strBuilder.AppendFormat("\r\n" + "string strXmlIsoFile = clsSysParaEN.strTempXMLIsoFileName;");
            //}
            //else
            //{
                strBuilder.AppendFormat("\r\n" + "string strXmlIsoFile = clsSysParaEN.strTempXMLIsoFileName;");
            //}
            strBuilder.AppendFormat("\r\n" + "using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings xmlws = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "xmlws.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "using (IsolatedStorageFileStream isoStream = isoStore.CreateFile(strXmlIsoFile))");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(isoStream, xmlws))");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SerializeXML(writer, obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "string strXmlString = clsFile.GetContentFromIsoFile(strXmlIsoFile);");
            strBuilder.AppendFormat("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// 读Xml字符串到一个对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecObjByXmlStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///读XmlReader到一个对象-----------------------------;


            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 读Xml字符串到一个对象");
            strBuilder.Append("\r\n /// 作者:潘以锋");
            strBuilder.Append("\r\n /// 日期:2010/10/04");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXmlStr\">提供的数据源:表示一个对象的XML串</param>",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>返回的一个对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjFromXmlStr(string str{0}ObjXmlStr)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "UTF8Encoding enc = new UTF8Encoding();");
            strBuilder.AppendFormat("\r\n" + "using (MemoryStream ms = new MemoryStream(enc.GetBytes(str{0}ObjXmlStr)))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "XmlReaderSettings xmlrs = new XmlReaderSettings();");
            strBuilder.Append("\r\n" + "xmlrs.IgnoreComments = true;");
            strBuilder.Append("\r\n" + "xmlrs.IgnoreWhitespace = true;");
            strBuilder.Append("\r\n" + "XmlReader reader = XmlReader.Create(ms, xmlrs);");
            strBuilder.AppendFormat("\r\n" + "while (reader.ReadToFollowing(cls{0}BL.itemXmlNode))",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = GetObjFromXml(reader);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        private string GetCode4FieldInSerializeXML(clsPrjTabFldENEx objField)
        {

            StringBuilder sbCodeForCs = new StringBuilder();
            if (objField.FldOpTypeId == "0003")
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "string":
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "bool":
                        //sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(\"{0}\");",
                        // objField.ObjFieldTabENEx.FldName);
                        //sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} = false ? \"0\" : \"1\") + \"'\");",
                        // strPrivPropNameWithObjectName4Get);
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.Get{0}().ToString().ToLower(CultureInfo.InvariantCulture));",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":
                    case "byte":
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                       objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "byte[]":
                        //sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        //objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    default:
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                }

                return sbCodeForCs.ToString();
            }
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "string":
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
                case "bool":
                    //sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(\"{0}\");",
                    // objField.ObjFieldTabENEx.FldName);
                    //sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} = false ? \"0\" : \"1\") + \"'\");",
                    // strPrivPropNameWithObjectName4Get);
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.{0}.ToString().ToLower(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
                case "int":
                case "long":
                case "float":
                case "double":
                case "short":
                case "Int16":
                case "Int32":
                case "byte":
                case "byte[]":
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(cls{1}EN.con_{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
            }

            return sbCodeForCs.ToString();
        }



        public string Gen_4BL_GetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数.该表与当前类不相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int GetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.GetRecCount(strTabName);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string Gen_4BL_GetRecCount()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数.该表与当前类相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int GetRecCount()");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.GetRecCount();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int GetRecCountByCond(string strTabName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.GetRecCountByCond(strTabName, strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strTabName, string strFldName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n List<string> arrList = cls{0}DA.GetFldValue(strTabName, strFldName, strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strFldName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n List<string> arrList = new cls{0}DA().GetFldValue(strFldName, strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static int GetRecCountByCond( string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.GetRecCountByCond(strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_GetSpecSQLObj()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取SQL服务器连接对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforOra GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.objLog == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"请初始化用于记录日志的clsSysParaEN.objLog对象!\");");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.objErrorLog == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!\");");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");

            strBuilder.Append("\r\n //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforOra(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strBuilder.Append("\r\n //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforOra();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforOra(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == ;
            return strBuilder.ToString();
        }




        public string Gen_4BL_funSetFldValue4String()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///设置/获取表中的符合条件的某字段的值------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");



            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = new cls{0}DA().SetFldValue(strFldName, strValue, strCondition);",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Float()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(cls{0}EN._CurrTabName, strFldName, fltValue, strCondition);",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"intValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = new cls{0}DA().SetFldValue( strFldName, intValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4String_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, strValue, strCondition);",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Int_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, intValue, strCondition);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Float_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforOra objSQL = null;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, fltValue, strCondition);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }


        public string Gen_4BL_GenSQLCode4CreateTab()
        {

            string strDatabaseOwner;

            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;       //, strIsNullable0;		// = " null ";
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //字段长度
            string strFldPrecision;

            strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }


            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取建立表的代码");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>建立表的代码</returns>");
            strBuilder.Append("\r\npublic static string GetCode4CreateTable() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n StringBuilder strCreateTabCode = new StringBuilder();");

            strBuilder.AppendFormat("\r\n  strCreateTabCode.Append(\"CREATE table [{1}].[{0}] \"); ",
              objPrjTabENEx.TabName, strDatabaseOwner);
            strBuilder.Append("\r\n strCreateTabCode.Append(\" ( \"); ");//左括号
            int intCount = 0;

            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {
                intCount++;
                ///计算字段名
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///计算字段类型
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///计算字段长度
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                strFldPrecision = objField.ObjFieldTabENEx.FldPrecision.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else if (strFieldType == "decimal" || strFieldType == "numeric")
                {
                    strFieldLength = string.Format("({0},{1})", strFieldLength0, strFldPrecision);
                }
                else
                {
                    strFieldLength = "(" + strFieldLength0 + ")";
                }
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///计算字段注释(即字段中文名称)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + " **/";

                ///计算是否可空

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///计算主键
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                    if (strFieldType == "bigint identity")
                    {
                        strFieldType = "bigint";
                    }
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
                {
                    strFieldCode = strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                strBuilder.AppendFormat("\r\n // {0} ", strRemark);//定义一个字段的信息
                if (intCount == objPrjTabENEx.arrFldSetAll.Count)
                {
                    strBuilder.AppendFormat("\r\n strCreateTabCode.Append(\" {0} \"); ", strFieldCode, strRemark);//定义一个字段的信息
                }
                else
                {
                    strBuilder.AppendFormat("\r\n strCreateTabCode.Append(\" {0}, \"); ", strFieldCode, strRemark);//定义一个字段的信息
                }
            }
            strBuilder.Remove(strBuilder.Length - 1, 1);
            strBuilder.Append("\r\n strCreateTabCode.Append(\") \"); ");//右括号
            strBuilder.Append("\r\n  strCreateTabCode.Append(\"ON [PRIMARY] \");");//

            //						Response.Write(strCreateTabCode.ToString());
            strBuilder.Append("\r\n  return strCreateTabCode.ToString();");

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();

        }

    }
}
