using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using AGC.BusinessLogic;
using com.taishsoft.datetime;
using AgcCommBase;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using com.taishsoft.sql;
using AGC.PureClassEx;
using System.Globalization;

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
    partial class NodeBusinessLogic4CSharp : clsGeneCodeBase4Tab
    {
        private string strKeyFldName_ObjName = "";

        #region 构造函数

        public NodeBusinessLogic4CSharp(string strTabId, string strPrjDataBaseId, string strPrjId)
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
        public string A_GenWebServiceCodeNew(Encoding myEncoding)
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
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


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
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
                objProjectsEN.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} 的摘要说明",
                objPrjTabENEx.ClsName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "[WebService(Namespace = \"http://tempuri.org/\")]");
                strCodeForCs.Append("\r\n" + "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]");
                strCodeForCs.Append("\r\n" + "[ToolboxItem(false)]");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0}Service : System.Web.Services.WebService",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{ ");

                //生成所有的函数

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
                //clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeForCs.ToString(), 
                //    objPrjTabENEx.FolderName_Root, objPrjTabENEx.BackupFolderName, myEncoding);


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
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
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




        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        //public string A_GenCode4Function_Swift4(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp; //临时变量;
        //    string strFuncName = "";
        //    try
        //    {
        //        //类名开始
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Swift4(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        //public string A_GenCode4Function_Swift3(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp; //临时变量;
        //    string strFuncName = "";
        //    try
        //    {
        //        //类名开始
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Swift3(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}


        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        //public string A_GenCode4Function_Swift(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp; //临时变量;
        //    string strFuncName = "";
        //    try
        //    {
        //        //类名开始
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Swift(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function_SilverLight(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);

                strFuncName = objvFunction4GeneCodeEN.FuncName;

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

        /// <summary>
        /// 生成业务逻辑层代码－－C#.NET
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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

            var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(1);
            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
clsvFunction4GeneCodeBLEx.GetObjLstByPrjTabEx(objPrjTabENEx, this.CmPrjId);

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BL";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.BusinessLogicLevel;




            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache( objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;

            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //类名开始
                strCodeForCs.Append("\r\n" + "using System;"); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using System.Globalization;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Linq;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                //if (objProjectsENEx.IsSupportMvc == true)
                //{
                //    strCodeForCs.Append("\r\n" + "using System.Web.Mvc;");
                //}
                strCodeForCs.Append("\r\n" + "using System.Xml;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.file;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.json;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.dynamiccompiler;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");


                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsENEx.PrjDomain);
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient; "); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.DAL;", objProjectsENEx.PrjDomain);



                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
                objProjectsENEx.PrjDomain);

                strCodeForCs.Append("\r\n" + "{");

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Static = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId == enumFunctionType.PureStaticFunction_12);
                if (arrvFunction4GeneCodeObjLst_Static.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static class  {0}_Static", objPrjTabENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_Static)
                    {
                        //clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
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
                            objPrjTabENEx.FuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
                            if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                            {
                                strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                                    objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                            }
                            else
                            {
                                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");

                }


                //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN21 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4BL_GeneEnumConstList");

                strTemp = A_GeneFuncCodeByFuncName("Gen_4BL_GeneEnumConstList");
                strCodeForCs.Append(strTemp);
                //objvFunction4GeneCodeEN21 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4BL_GeneEnumConstList4Field");

                strTemp = A_GeneFuncCodeByFuncName("Gen_4BL_GeneEnumConstList4Field");
                strCodeForCs.Append(strTemp);

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// 数据源类型:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                //私有属性名-----和属性过程
                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_NotStatic = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId != enumFunctionType.PureStaticFunction_12);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_NotStatic)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
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
                        objPrjTabENEx.FuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
                        if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                        {
                            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                        }
                        else
                        {
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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
                Type t = typeof(NodeBusinessLogic4CSharp);
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
                throw objException;
            }
        }

        public string Gen_Neo4JBL_DefineObjCommFun4BL()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// 专门在逻辑层用于处理缓存等公共函数的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.Append("\r\n" + "public static clsCommFun4BL objCommFun4BL = null;");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public static clsCommFun4BLV2 objCommFun4BL = null;");
            }
            //strCodeForCs.Append("\r\n" + "public static event OnAddNewRecord onAddNewRecord;");
            //strCodeForCs.Append("\r\n" + "public static event OnUpdateRecord onUpdateRecord;");
            //strCodeForCs.Append("\r\n" + "public static event OnDeleteRecord onDelRecord;");

            return strCodeForCs.ToString();
        }

        public string Gen_Neo4JBL_DefineUniqueInstance4DAL()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// 单例模式:访问数据访问层的单例模式");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private static cls{0}DA uniqueInstance = null;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。");
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public static cls{0}DA {0}DA", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "    get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (uniqueInstance == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "uniqueInstance = new cls{0}DA();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return uniqueInstance;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_DelRecordEx()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">表关键字</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "/// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "private static bool DelRecordEx({0} {1})",
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n" + "//获取连接对象");
            strCodeForCs.AppendFormat("\r\n" + "objSQL = cls{0}DA.GetSpecSQLObj();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//删除TeacherInfo本表中与当前对象有关的记录");
            strCodeForCs.Append("\r\n" + "SqlConnection objConnection = null;");
            strCodeForCs.Append("\r\n" + "SqlTransaction objSqlTransaction = null;");
            strCodeForCs.Append("\r\n" + "  try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//获取连接对象");
            strCodeForCs.Append("\r\n" + "objConnection = objSQL.getConnectObj(objSQL.ConnectionString);");
            strCodeForCs.Append("\r\n" + "//获取该连接对象中的事务");
            strCodeForCs.Append("\r\n" + "objSqlTransaction = objConnection.BeginTransaction();");
            strCodeForCs.Append("\r\n" + "//");
            strCodeForCs.AppendFormat("\r\n" + "//删除与表:[{0}]相关的表的代码,需要时去除注释,编写相关的代码",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//string strCondition = string.Format(\"{0} = '{1}'\",");
            strCodeForCs.Append("\r\n" + "//constStudent.id_College,");
            strCodeForCs.Append("\r\n" + "//strid_College);");
            strCodeForCs.Append("\r\n" + "//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);");
            strCodeForCs.Append("\r\n" + "//");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1}, objConnection, objSqlTransaction);",
                objPrjTabENEx.TabName, objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "                objSqlTransaction.Commit();");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "ErrorInformationBL.AddInformation(\"cls{0}BLEx\", \"DelRecordEx\", objException.Message, clsSysParaEN.strUserId);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"扩展删除记录出错:{0}!keyId = {1}.({2})\",");
            strCodeForCs.Append("\r\n" + "objException.Message,");
            strCodeForCs.AppendFormat("\r\n" + "{0}, clsStackTrace.GetCurrClassFunction());",
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "if (objSqlTransaction != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "objSqlTransaction.Rollback();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

            //return false;
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "finally");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "objConnection.Close();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_DelRecord4MultiTab()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理");
            strCodeForCs.AppendFormat("\r\n" + "/// 这里仅仅是演示函数,使用时请复制到扩展类:[{0}]中改名为:[{1}]使用",
                objPrjTabENEx.TabName,
                "DelRecord4MultiTabEx");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">表关键字</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "/// <returns></returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public static bool DelRecord4MultiTab({0} {1})",
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "public static bool DelRecord4MultiTab({0} {1}, {2} {3})",
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objKeyField.PrivFuncName,
                objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n" + "//获取连接对象");
            strCodeForCs.AppendFormat("\r\n" + "objSQL = cls{0}DA.GetSpecSQLObj();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//删除TeacherInfo本表中与当前对象有关的记录");
            strCodeForCs.Append("\r\n" + "SqlConnection objConnection = null;");
            strCodeForCs.Append("\r\n" + "SqlTransaction objSqlTransaction = null;");
            strCodeForCs.Append("\r\n" + "  try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//获取连接对象");
            strCodeForCs.Append("\r\n" + "objConnection = objSQL.getConnectObj(objSQL.ConnectionString);");
            strCodeForCs.Append("\r\n" + "//获取该连接对象中的事务");
            strCodeForCs.Append("\r\n" + "objSqlTransaction = objConnection.BeginTransaction();");
            strCodeForCs.Append("\r\n" + "//");
            strCodeForCs.AppendFormat("\r\n" + "//删除与表:[{0}]相关的表的代码,需要时去除注释,编写相关的代码",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//string strCondition = string.Format(\"{0} = '{1}'\",");
            strCodeForCs.Append("\r\n" + "//constStudent.id_College,");
            strCodeForCs.Append("\r\n" + "//strid_College);");
            strCodeForCs.Append("\r\n" + "//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);");
            strCodeForCs.Append("\r\n" + "//");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1}, objConnection, objSqlTransaction);",
                objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.DelRecord({1}, {2}, objConnection, objSqlTransaction);",
                objPrjTabENEx.TabName, objKeyField.PrivFuncName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "                objSqlTransaction.Commit();");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "ErrorInformationBL.AddInformation(\"cls{0}BL\", \"DelRecord4MultiTab\", objException.Message, clsSysParaEN.strUserId);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"删除多表记录出错:{0}!keyId = {1}.({2})\",");
            strCodeForCs.Append("\r\n" + "objException.Message,");
            strCodeForCs.AppendFormat("\r\n" + "{0}, clsStackTrace.GetCurrClassFunction());",
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "if (objSqlTransaction != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "objSqlTransaction.Rollback();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");

            //return false;
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "finally");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "objConnection.Close();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4BL_DefineUniqueInstance4DALEx()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// 单例模式:访问数据访问扩展层的单例模式");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private static cls{0}DAEx uniqueInstanceEx = null;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。");
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "private static cls{0}DAEx {0}DAEx", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "    get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (uniqueInstanceEx == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "uniqueInstanceEx = new cls{0}DAEx();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return uniqueInstanceEx;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_Neo4JBL_DefineObjLst4Cache()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "//public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 从缓存中查找失败的次数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");
            strCodeForCs.AppendFormat("\r\n" + "   private static string strMsg = \"\";");
            return strCodeForCs.ToString();
        }

        public string Gen_Neo4JBL_ReFreshCache()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshCache()");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshCache({0} {1})",
                                    objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "  if (clsSysParaEN.spIsUseQueue4Task == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.arrFunctionLst4Queue == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "clsDynamicFunction objDynamicFunction = new clsDynamicFunction()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "NameSpace = \"{0}.BusinessLogic\",", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "ClassName = \"cls{0}BL\",", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "AssemblyType = typeof({0}.BusinessLogic.cls{1}BL),", objProjectsENEx.PrjDomain, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "FunctionName = clsStackTrace.GetCurrFunction()");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "if (clsDynamicFunction.IsExistSameFunction(clsSysParaEN.arrFunctionLst4Queue, objDynamicFunction) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.arrFunctionLst4Queue.Enqueue(objDynamicFunction);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.objCommFun4BL != null) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + " string strMsg = string.Format(\"刷1新缓存成功!({{2}}->{{1}}->{{0}})\",", "{", "}");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");

            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }

            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.objCommFun4BL.ReFreshCache();",
                objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.objCommFun4BL.ReFreshCache({1});",
             objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_Neo4JBL_ReFreshThisCache()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 刷新本类中的缓存.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshThisCache()");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshThisCache({0} {1} = \"\")",
                    objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg;");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.spSetRefreshCacheOn == true)");
            strCodeForCs.Append("\r\n" + "{");
            //  strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"刷1新缓存成功!({{2}}->{{1}}->{{0}})\",");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = string.Format(\"刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})\",");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3));");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4CFBL_ReFreshCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.AppendFormat("\r\n" + "public override void ReFreshCache()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg;");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.spSetRefreshCacheOn == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = string.Format(\"刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})\",");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3));");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");



            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReFreshThisCache();",
                    objPrjTabENEx.TabName);
            //string strTabId = cboPrjTab.SelectedValue.ToString();
            //arrPrjTabObjLst = clsPrjTabBLEx.GetPrjTabObjLstByPrjIdCacheEx(strPrjId);
            //int intIndex = clsPrjTabBLEx.GetIndexByTabId(strTabId, arrPrjTabObjLst);
            List<string> arrTabId = clsPrjTabBLEx.GetRelaViewTabIdLstByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
            foreach (string strRelaTabId in arrTabId)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, objPrjTabENEx.PrjId);
                if (objPrjTab.TabStateId != "01") continue;
                //string strMsg = string.Format("{0}({1}) ",
                //    objPrjTab.TabName, objPrjTab.TabId);
                //listBox1.Items.Add(strMsg);
                if (objPrjTab.IsUseCache == false) continue;
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.ReFreshThisCache();",
                        objPrjTab.TabName);
            }

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_DefineConst4Xml()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 单项的XML结点标签");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public const string itemXmlNode = \"{0}ListItem\";",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 列表的XML结点标签");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public const string listXmlNode = \"{0}List\";",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 集合的XML结点标签");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public const string itemsXmlNode = \"Items\";");


            return strCodeForCs.ToString();
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


        public string Gen_Neo4JBL_GetDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable_{0}(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable_{0}(string strWhereCond)", "获取表数据出错_{0}!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(string strWhereCond)", "获取表数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表数据出错!(strWhereCond = {{1}}), {{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


      //      strBuilder.AppendFormat("\r\n /// <summary>");
      //      strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查");
      //      strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
      //      strBuilder.AppendFormat("\r\n /// </summary>");
      //      strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
      //      strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
      //      strBuilder.AppendFormat("\r\n /// <returns></returns>");
      //      strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)",
      //      objPrjTabENEx.TabName);
      //      strBuilder.Append("\r\n" + "{");
      //      strBuilder.Append("\r\n" + "DataTable objDT;");
      //      strBuilder.Append("\r\n" + "try");
      //      strBuilder.Append("\r\n" + "{");
      //      strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond, lstExclude);",
      //      objPrjTabENEx.TabName);
      //      strBuilder.Append("\r\n" + "return objDT;");
      //      strBuilder.Append("\r\n" + "}");
      //      strBuilder.Append("\r\n" + "catch (Exception objException)");
      //      strBuilder.Append("\r\n" + "{");
      //      strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      //objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(strWhereCond, lstExclude)", "获取表数据出错!(排除的检查字符串列表)", "生成代码");

      //      strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表数据出错!(排除的检查字符串列表)(strWhereCond = {{1}}), {{2}}.({{0}})\",", strErrId);
      //      strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
      //      strBuilder.AppendFormat("\r\n" + "strWhereCond,");
      //      strBuilder.AppendFormat("\r\n" + "objException.Message); ");
      //      strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
      //      strBuilder.Append("\r\n" + "}");
      //      strBuilder.Append("\r\n" + "}");

      //      strBuilder.AppendFormat("\r\n /// <summary>");
      //      strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
      //      strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
      //      strBuilder.AppendFormat("\r\n /// </summary>");
      //      strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
      //      strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查SQL攻击</param>");
      //      strBuilder.AppendFormat("\r\n /// <returns></returns>");
      //      strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, bool bolIsCheckSQLAttack)",
      //      objPrjTabENEx.TabName);
      //      strBuilder.Append("\r\n" + "{");
      //      strBuilder.Append("\r\n" + "DataTable objDT;");
      //      strBuilder.Append("\r\n" + "try");
      //      strBuilder.Append("\r\n" + "{");
      //      strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond, bolIsCheckSQLAttack);",
      //      objPrjTabENEx.TabName);
      //      strBuilder.Append("\r\n" + "return objDT;");
      //      strBuilder.Append("\r\n" + "}");
      //      strBuilder.Append("\r\n" + "catch (Exception objException)");
      //      strBuilder.Append("\r\n" + "{");
      //      strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      //objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(string strWhereCond, bool bolIsCheckSQLAttack)", "获取表数据出错!(是否检查SQL攻击)", "生成代码");

      //      strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表数据出错!(是否检查SQL攻击), {{1}}.({{0}})\",", strErrId);
      //      strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
      //      strBuilder.AppendFormat("\r\n" + "objException.Message); ");
      //      strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

      //      strBuilder.Append("\r\n" + "}");

      //      strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, string strTabName)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond, strTabName);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(string strWhereCond, string strTabName)", "获取表数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond, strTabName, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(strWhereCond, strTabName, lstExclude)", "获取表数据出错!(排除的检查字符串列表)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表数据出错!(排除的检查字符串列表)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查SQL攻击</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond, string strTabName, bool bolIsCheckSQLAttack)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable(strWhereCond, strTabName, bolIsCheckSQLAttack);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable(string strWhereCond, string strTabName, bool bolIsCheckSQLAttack)", "获取表数据出错!(是否检查SQL攻击)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表数据出错!(是否检查SQL攻击),{{1}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"03:(errid:{22})获取表数据出错!(是否检查SQL攻击)({1}: GetDataTable)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表数据出错!(是否检查SQL攻击)\\r\\n({1}:GetDataTable)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }


        public string Gen_4BL_GetTopDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objTopPara\">获取顶部对象列表的参数对象</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_Top(stuTopPara objTopPara)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable_Top(objTopPara);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable_Top", "获取表顶数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表顶数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objTopPara.whereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable_Top", "获取表顶数据出错!(排除的检查字符串列表)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查SQL攻击</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable_Top", "获取表顶数据出错!(是否检查SQL攻击)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表顶数据出错!(是否检查SQL攻击),{{1}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Neo4JBL_GetDataTableByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">页序号</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">页记录数</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByPager", "获取分页表顶数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取分页表顶数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

      //      strBuilder.AppendFormat("\r\n /// <summary>");
      //      strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查");
      //      strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
      //      strBuilder.AppendFormat("\r\n /// </summary>");
      //      strBuilder.Append("\r\n /// <param name = \"intPageIndex\">页序号</param>");
      //      strBuilder.Append("\r\n /// <param name = \"intPageSize\">页记录数</param>");
      //      strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
      //      strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
      //      strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
      //      strBuilder.AppendFormat("\r\n /// <returns></returns>");
      //      strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)",
      //      objPrjTabENEx.TabName);
      //      strBuilder.Append("\r\n" + "{");
      //      strBuilder.Append("\r\n" + "DataTable objDT;");
      //      strBuilder.Append("\r\n" + "try");
      //      strBuilder.Append("\r\n" + "{");
      //      strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);",
      //      objPrjTabENEx.TabName);
      //      strBuilder.Append("\r\n" + "return objDT;");
      //      strBuilder.Append("\r\n" + "}");
      //      strBuilder.Append("\r\n" + "catch (Exception objException)");
      //      strBuilder.Append("\r\n" + "{");
      //      strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      //objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByPager", "获取分页表顶数据出错!(排除的检查字符串列表)", "生成代码");

      //      strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
      //      strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
      //      strBuilder.AppendFormat("\r\n" + "strWhereCond,");
      //      strBuilder.AppendFormat("\r\n" + "objException.Message); ");
      //      strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

      //      strBuilder.Append("\r\n" + "}");

      //      strBuilder.Append("\r\n" + "}");


      //      strBuilder.AppendFormat("\r\n /// <summary>");
      //      strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
      //      strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
      //      strBuilder.AppendFormat("\r\n /// </summary>");
      //      strBuilder.Append("\r\n /// <param name = \"intPageIndex\">页序号</param>");
      //      strBuilder.Append("\r\n /// <param name = \"intPageSize\">页记录数</param>");
      //      strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
      //      strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
      //      strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查SQL攻击</param>");
      //      strBuilder.AppendFormat("\r\n /// <returns></returns>");
      //      strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)",
      //      objPrjTabENEx.TabName);
      //      strBuilder.Append("\r\n" + "{");
      //      strBuilder.Append("\r\n" + "DataTable objDT;");
      //      strBuilder.Append("\r\n" + "try");
      //      strBuilder.Append("\r\n" + "{");
      //      strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);",
      //      objPrjTabENEx.TabName);
      //      strBuilder.Append("\r\n" + "return objDT;");
      //      strBuilder.Append("\r\n" + "}");
      //      strBuilder.Append("\r\n" + "catch (Exception objException)");
      //      strBuilder.Append("\r\n" + "{");
      //      strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      //objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByPager", "获取分页表顶数据出错!(是否检查SQL攻击)", "生成代码");

      //      strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取分页表顶数据出错!(是否检查SQL攻击),{{1}}.({{0}})\",", strErrId);
      //      strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
      //      strBuilder.AppendFormat("\r\n" + "objException.Message); ");
      //      strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

      //      strBuilder.Append("\r\n" + "}");

      //      strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "获取表带范围数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表带范围数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"06:(errid:{22})获取表带范围数据出错!(strWhereCond = {{0}})({1}:GetDataTableByRange)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表带范围数据出错!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_4BL_GetDataTableByRange_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "获取表带范围数据出错!(同时可以排除一些关键字不检查)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {{1}}), {{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"06:(errid:{22})获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {{0}})({1}:GetDataTableByRange)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表带范围数据出错!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }


        public string Gen_4BL_GetDataTableByRange_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查SQL攻击</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableByRange(strWhereCond, bolIsCheckSQLAttack, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableByRange", "获取表带范围数据出错!(同时检查是否含有SQL攻击)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"06:(errid:{22})获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {{0}})({1}:GetDataTableByRange)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表带范围数据出错!(同时检查是否含有SQL攻击)\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet(string strWhereCond)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSet", "获取表数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"03:(errid:{22})获取表数据出错!(strWhereCond = {{0}})({1}:GetDataSet)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSet_Top(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSet_Top", "获取表数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表顶数据出错!(strWhereCond = {{1}}),{{2}}({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"03:(errid:{22})获取表数据出错!(strWhereCond = {{0}})({1}:GetDataSet)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetByRange", "获取表带范围数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表带范围数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"06:(errid:{22})获取表带范围数据出错!(strWhereCond = {{0}})({1}:GetDataSetByRange)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回当前表视图的数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetV(string strWhereCond)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetV", "获取表视图数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表视图数据出错!(strWhereCond = {{1}}),{{2}}({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"04:(errid:{22})获取表视图数据出错!(strWhereCond = {{0}})({1}:GetDataSetV)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表视图数据出错!\\r\\n({1}:GetDataSetV)\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSetVByRange(string strWhereCond, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSetVByRange(strWhereCond, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataSetVByRange", "获取表视图带范围数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表视图带范围数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"05:(errid:{22})获取表视图带范围数据出错!(strWhereCond = {{0}})({1}:GetDataSetVByRange)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表视图带范围数据出错!\\r\\n({1}:GetDataSetVByRange)\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回当前表视图的数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableV", "获取表视图数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表视图数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取当前表视图的数据表,用DataTable表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回当前表视图的数据表,用DataTable表示</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}V(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTable_{0}V(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTable_{0}V", "获取表视图数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表视图数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetDataTableV_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表的视图,用DataTable表示,同时可以排除一些关键字不检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableV(strWhereCond, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableV", "获取表视图数据出错!(同时可以排除一些关键字不检查)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表视图数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableVByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableVByRange(strWhereCond, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "获取表视图带范围数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表视图带范围数据出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"05:(errid:{22})获取表视图带范围数据出错!(strWhereCond = {{0}})({1}:GetDataTableVByRange)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表视图带范围数据出错!\\r\\n({1}:GetDataTableVByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableVByRange_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableVByRange(strWhereCond, lstExclude, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "获取表视图带范围数据出错!(同时可以排除一些关键字不检查)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表视图带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"05:(errid:{22})获取表视图带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {{0}})({1}:GetDataTableVByRange)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表数据出错!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataTableVByRange_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "objDT = {0}DA.GetDataTableVByRange(strWhereCond, bolIsCheckSQLAttack, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetDataTableVByRange", "获取表视图带范围数据出错!(同时检查是否含有SQL攻击)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取表视图带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"05:(errid:{22})获取表视图带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {{0}})({1}:GetDataTableVByRange)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表数据出错!\\r\\n({1}:GetDataTableByRange)\" + objException.Message);",
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
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = {0}DA.GetDataSetV(strWhereCond);",
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


        public string Gen_4BL_GetRecObjLstFromDataTable()
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

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            //strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond);",
            //objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            //
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append(Gen_4BL_GC_GetObjLstFromDataTable());

            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_Neo4JBL_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}Cond\">给定条件的条件对象</param>",       objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static IEnumerable<cls{0}EN> GetObjLst(cls{0}EN obj{0}Cond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nIEnumerable<cls{0}EN> arrObjLst = null; ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arrObjLst = cls{0}BL.{0}DA.GetObjLst(obj{0}Cond);",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objException;");
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            ////获取某一条件值的记录集-----------------------------;
            //strBuilder.Append("\r\n /// <summary>");
            //strBuilder.Append("\r\n /// 根据条件获取对象列表");
            //strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strBuilder.Append("\r\n /// </summary>");
            //strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            //strBuilder.Append("\r\n /// <param name = \"lstExclude\">查询条件中排除的标志列表</param>");
            //strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            //strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(string strWhereCond, List<string> lstExclude)",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n{");
            //strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");
            //strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond, lstExclude);",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            //strBuilder.Append("\r\n{");
            //
            //strBuilder.Append("\r\nreturn arrObjLst;");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append(Gen_4BL_GC_GetObjLstFromDataTable());
            //
            //strBuilder.Append("\r\nreturn arrObjLst;");
            //strBuilder.Append("\r\n}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_GetObjLstByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByTabName(string strWhereCond, string strTabName)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond, strTabName);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append(Gen_4BL_GC_GetObjLstFromDataTable());

            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">查询条件中排除的标志列表</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond, strTabName, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append(Gen_4BL_GC_GetObjLstFromDataTable());

            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取JSON对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static string GetJSONObjLst(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = GetObjLst(strWhereCond);",
                    objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arrObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");

            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取JSON对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">查询条件中排除的标志列表</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);",
                        objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arrObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");

            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objTopPara\">获取顶部对象列表的参数对象</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetTopObjLst(stuTopPara objTopPara)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);",
 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n" + " stuTopPara objTopPara = new stuTopPara()");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + " topSize = intTopSize,");
            strBuilder.Append("\r\n" + " whereCond = strWhereCond,");
            strBuilder.Append("\r\n" + " orderBy = strOrderBy");
            strBuilder.Append("\r\n" + " };");

            strBuilder.AppendFormat("\r\n objDT = GetDataTable_Top(objTopPara);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append(Gen_4BL_GC_GetObjLstFromDataTable());

            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">查询条件中排除的标志列表</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append(Gen_4BL_GC_GetObjLstFromDataTable());

            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_Neo4JBL_GetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件分页获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objPagerPara\">分页获取记录的参数对象</param>");
            strBuilder.Append("\r\n /// <returns>返回分页对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static IEnumerable<cls{0}EN> GetObjLstByPager(stuPagerPara objPagerPara)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nIEnumerable<cls{0}EN> arrObjLst = null; ",
 objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arrObjLst = cls{0}BL.{0}DA.GetObjLstByPager(objPagerPara);",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objException;");
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GeneEnumConstList()
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
                strBuilder.AppendFormat("\r\npublic class enum{0}",
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
                    strBuilder.AppendFormat("\r\n" + "{0}_{1} = {1},", objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            strBuilder.Append("\r\n}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_GeneEnumConstList4Field()
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

                strBuilder.AppendFormat("\r\npublic class enum{0}_{1}",
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

        public string Gen_4BL_GetObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据记录范围和条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRangePara\">根据范围获取记录的参数对象</param>");

            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(stuRangePara objRangePara)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");


            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据记录范围和条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");


            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append(Gen_4BL_GC_GetObjLstFromDataTable());

            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");


            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">查询条件中排除的标志列表</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append(Gen_4BL_GC_GetObjLstFromDataTable());

            

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
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> {0}List(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append(Gen_4BL_GC_GetObjLstFromDataTable());

            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecProperty4Object()
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

            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Static_GetObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObj(this K_{1}_{0} myKey)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            //string strErrId = "";
            //      if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objPrjTabENEx.arrKeyFldSet.Count == 1)
            //      {
            //          strBuilder.AppendFormat("\r\n" + "if ({0}.IndexOf(' ') >=0)",
            //objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //          strBuilder.Append("\r\n" + "{");
            //          strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
            //              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetObjBy{Key}",
            //                  string.Format("在表中,关键字[Key]中不能有空格!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
            //                   objPrjTabENEx.TabName), "生成代码");

            //          strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})在表中,关键字[{3}]中不能有空格!({{0}})\",", strErrId, "{", "}", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //          strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
            //          strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //          //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"01:(errid:{22})在表[{1}]中,关键字[{0}]不能为空!(cls{1}BL:Get{1}By{3})\");",
            //          //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
            //          //         objPrjTabENEx.TabName, strErrId,
            //          //         objKeyField.FldName);
            //          //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            //          strBuilder.Append("\r\n" + "}");


            //          strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
            //                objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //          strBuilder.Append("\r\n" + "{");
            //          strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
            //              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetObjBy{Key}",
            //                  string.Format("在表中,关键字[Key]不能为空!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
            //                   objPrjTabENEx.TabName), "生成代码");

            //          strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})在表中,关键字[{3}]不能为空!({{0}})\",", strErrId, "{", "}", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //          strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
            //          strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //          //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"01:(errid:{22})在表[{1}]中,关键字[{0}]不能为空!(cls{1}BL:Get{1}By{3})\");",
            //          //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
            //          //         objPrjTabENEx.TabName, strErrId,
            //          //         objKeyField.FldName);
            //          //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            //          strBuilder.Append("\r\n" + "}");
            //      }
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.{0}DA.GetObjBy{1}(myKey.Value);",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JBL_GetObjByKey()
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
            string strErrId = "";
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                strBuilder.AppendFormat("\r\n" + "if ({0}.IndexOf(' ') >=0)",
      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetObjBy{Key}",
                        string.Format("在表中,关键字[Key]中不能有空格!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName), "生成代码");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})在表中,关键字[{3}]中不能有空格!({{0}})\",", strErrId, "{", "}", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"01:(errid:{22})在表[{1}]中,关键字[{0}]不能为空!(cls{1}BL:Get{1}By{3})\");",
                //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                //         objPrjTabENEx.TabName, strErrId,
                //         objKeyField.FldName);
                //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");


                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetObjBy{Key}",
                        string.Format("在表中,关键字[Key]不能为空!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName), "生成代码");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})在表中,关键字[{3}]不能为空!({{0}})\",", strErrId, "{", "}", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"01:(errid:{22})在表[{1}]中,关键字[{0}]不能为空!(cls{1}BL:Get{1}By{3})\");",
                //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                //         objPrjTabENEx.TabName, strErrId,
                //         objKeyField.FldName);
                //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = {0}DA.GetObjBy{1}({2});",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjByKeyByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{2}({1}, string strTabName)",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            string strErrId = "";
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetObjBy{Key}ByTabName",
                        string.Format("在表中,关键字[Key]不能为空!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                         objPrjTabENEx.TabName), "生成代码");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})在表中,关键字[{3}]不能为空!({{0}})\",", strErrId, "{", "}", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"01:(errid:{22})在表[{1}]中,关键字[{0}]不能为空!(cls{1}BL:Get{1}By{3})\");",
                //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                //         objPrjTabENEx.TabName, strErrId,
                //         objKeyField.FldName);
                //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = {0}DA.GetObjBy{1}({2}, strTabName);",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_Neo4JBL_CopyObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }

            //strBuilder.AppendFormat("\r\n" + "{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            //objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo", "Copy表:{0} 对象数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})Copy表对象数据出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public string Gen_Neo4JBL_Static_CopyObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyTo(this cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }

            //strBuilder.AppendFormat("\r\n" + "cls{0}BL.{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            //objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo__Static", "静态Copy表:{0} 对象数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy表对象数据出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public string Gen_Neo4JBL_Static_CopyTo()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>目标对象=>cls{0}EN:obj{0}ENT</returns>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static cls{0}EN CopyTo(this cls{0}EN obj{0}ENS)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}ENT = new cls{0}EN();", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }

            //strBuilder.AppendFormat("\r\n" + "cls{0}BL.{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            //objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}ENT;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo2__Static", "静态Copy表2:{0} 对象数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy表对象数据出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CopyObjToSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,复制到另一个对象(简单)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyObjToSimObj(cls{0}EN obj{0}ENS, cls{0}EN_Sim obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}DA.CopyObjToSimObj(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyObjToSimObj", "Copy表:{0} 对象到简单对象数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})Copy表对象数据出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyObjToSimObj)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyObjToSimObj)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CopyObjFromSimObj4Upd_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,从简化对象复制到对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源简化对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyObjFromSimObj4Upd(cls{0}EN_Sim obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}DA.CopyObjFromSimObj4Upd(obj{0}ENS, obj{0}ENT);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyObjFromSimObj4Upd", "Copy表:{0} 简化对象到对象数据(针对修改)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})Copy表对象数据(针对修改)出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据(针对修改)出错!({1}:CopyObjFromSimObj4Upd)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyObjFromSimObj4Upd)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public string Gen_Neo4JBL_SetUpdFlag_S()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">源简化对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void SetUpdFlag(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n   string strsfUpdFldSetStr = obj{0}EN.sf_UpdFldSetStr;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');");
            strBuilder.Append("\r\n   List<string> arrFldSet = new List<string>(sstrFldSet);");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(obj{0}EN.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "if (arrFldSet.Contains(con{0}.{1}, new clsStrCompareIgnoreCase())  ==  true)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strBuilder.Append("\r\n" + "}");

                }
            }

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "SetUpdFlag", "设置表的修改标志出错!表:{0}.", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})设置表的修改标志出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据(针对修改)出错!({1}:CopyObjFromSimObj4Upd)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyObjFromSimObj4Upd)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CopyObjFromSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,从简化对象复制到对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源简化对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyObjFromSimObj(cls{0}EN_Sim obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}DA.CopyObjFromSimObj(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyObjFromSimObj", "Copy表:{0} 简化对象到对象数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})Copy表对象数据出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetSimObjLstFromObjLst_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把对象列表转换成简化对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}ObjLst\">对象列表</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>简化对象列表</returns>");
            strBuilder.AppendFormat("\r\n public static List<cls{0}EN_Sim> GetSimObjLstFromObjLst(List<cls{0}EN> arr{0}ObjLst)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = new List<cls{0}EN_Sim>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n cls{0}EN_Sim obj{0}EN_Sim = new cls{0}EN_Sim();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjToSimObj(obj{0}EN, obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n arr{0}SimObjLst.Add(obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.AppendFormat("\r\n return arr{0}SimObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetSimObjFromObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把对象转换成简化对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>简化对象</returns>");
            strBuilder.AppendFormat("\r\n public static cls{0}EN_Sim GetSimObjFromObj(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n cls{0}EN_Sim obj{0}EN_Sim = new cls{0}EN_Sim();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjToSimObj(obj{0}EN, obj{0}EN_Sim);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n return obj{0}EN_Sim;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetObjFromSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把简化对象转换成对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>简化对象</returns>");
            strBuilder.AppendFormat("\r\n public static cls{0}EN GetObjFromSimObj(cls{0}EN_Sim obj{0}EN_Sim)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}EN();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjFromSimObj(obj{0}EN_Sim, obj{0}EN);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_GetObjFromSimObj4Upd_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把简化对象转换成对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>简化对象</returns>");
            strBuilder.AppendFormat("\r\n public static cls{0}EN GetObjFromSimObj4Upd(cls{0}EN_Sim obj{0}EN_Sim)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}EN();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjFromSimObj4Upd(obj{0}EN_Sim, obj{0}EN);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetSimObjFromObj4Upd_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把简化对象转换成对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>简化对象</returns>");
            strBuilder.AppendFormat("\r\n public static cls{0}EN_Sim GetSimObjFromObj4Upd(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n cls{0}EN_Sim obj{0}EN_Sim = new cls{0}EN_Sim();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string strsfUpdFldSetStr = obj{0}EN.getsfUpdFldSetStr();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "CopyObjToSimObj(obj{0}EN, obj{0}EN_Sim);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}EN_Sim.sf_UpdFldSetStr = strsfUpdFldSetStr;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN_Sim;",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n }");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public void Gen_4BL_Static_SetFieldValue4OneField(clsPrjTabFldENEx objField, StringBuilder strBuilder)
        {
            if (objField.FldOpTypeId == "0004") return;//不读不写
            if (objField.FldOpTypeId == "0002") return;//只读不写
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:为对象设置字段值");
            strBuilder.Append("\r\n /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要设置字段值的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strComparisonOp\">比较运算符,如果有值,可用于组织条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回对象,可以继续连写</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN Set{1}(this cls{0}EN obj{0}EN, {2} {3}, string strComparisonOp=\"\")",
            objPrjTabENEx.TabName, objField.FldName, objField.CsType, objField.PrivFuncName);
            strBuilder.Append("\r\n	{");
            //objUserStateEN.Memo = strMemo;


            //检查非空
            if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                {

                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                   objField.PrivFuncName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                }

            }
            //检查字段长度

            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                && objField.ObjFieldTabENEx.FldLength > 0)
            {

                strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
         objField.PrivFuncName,
         objField.ObjFieldTabENEx.FldLength,
         objPrjTabENEx.TabName,
         objField.ObjFieldTabENEx.FldName);

            }
            //检查外键
            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
               && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
            {

                strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
           objField.PrivFuncName,
           objField.ObjFieldTabENEx.FldLength,
           objPrjTabENEx.TabName,
           objField.ObjFieldTabENEx.FldName);

            }

            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}; //{3}",
             objPrjTabENEx.TabName, objField.FldName, objField.PrivFuncName, objField.ColCaption);
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(strComparisonOp) == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.dicFldComparisonOp.ContainsKey(con{0}.{1}) == false)",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.dicFldComparisonOp.Add(con{0}.{1}, strComparisonOp);",
                objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.dicFldComparisonOp[con{0}.{1}] = strComparisonOp;", objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");


        }

        public string Gen_Neo4JBL_Static_SetFieldValue()
        {
            StringBuilder strBuilder = new StringBuilder();

            objPrjTabENEx.arrFldSet.ForEach(obj => Gen_4BL_Static_SetFieldValue4OneField(obj, strBuilder));

            return strBuilder.ToString();
        }

        public string Gen_4BL_Static_SetFieldValueBak()
        {
            StringBuilder strBuilder = new StringBuilder();

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") continue;//只读不写
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");


                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// /// 功能:为对象设置字段值");
                strBuilder.Append("\r\n /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要设置字段值的实体对象</param>", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n /// <returns>返回对象,可以继续连写</returns>");
                strBuilder.AppendFormat("\r\n" + "public static cls{0}EN Set{1}(this cls{0}EN obj{0}EN, {2} {3})",
                objPrjTabENEx.TabName, objField.FldName, objField.CsType, objField.PrivFuncName);
                strBuilder.Append("\r\n	{");
                //objUserStateEN.Memo = strMemo;

                //检查非空
                if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }

                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName4Get);
                        //strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //    strPrivPropNameWithObjectName4Get );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName4Get );
                        //}
                        //strBuilder.Append(")");
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})字段[{1}|{0}]不能为空(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //        objField.ColCaption,
                        //        objPrjTabENEx.TabCnName,
                        //        strErrId,
                        //        objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                  strPrivPropNameWithObjectName,
                  objField.ObjFieldTabENEx.FldLength,
                  objPrjTabENEx.TabName,
                  objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName );
                        //strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //     strPrivPropNameWithObjectName );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName );
                        //}
                        //strBuilder.Append(")");
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})字段[{1}|{0}]不能为空(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //            objField.ColCaption,
                        //            objPrjTabENEx.TabCnName,
                        //            strErrId,
                        //            objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n}");
                    }
                }
                //检查字段长度

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                 strPrivPropNameWithObjectName,
                 objField.ObjFieldTabENEx.FldLength,
                 objPrjTabENEx.TabName,
                 objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(string.Format(\"(errid:{7})字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}(cls{3}DA:CheckPropertyNew)\", obj{3}EN.{4}));",
                        //objField.ColCaption,
                        //objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        //objPrjTabENEx.TabCnName,
                        //objPrjTabENEx.TabName,
                        //objField.ObjFieldTabENEx.FldName,
                        //"{", "}",
                        //strErrId);
                        // strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                             strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength,
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName);

                    }
                }
                //检查外键
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                   && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                }

                strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}; //{3}",
                 objPrjTabENEx.TabName, objField.FldName, objField.PrivFuncName, objField.ColCaption);
                strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n	}");

            }

            return strBuilder.ToString();
        }


        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JBL_Static_DelNode()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int DelNode(this cls{0}EN obj{0}EN)",
                        objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.{0}DA.DelNode(obj{0}EN.{1});",
                objPrjTabENEx.TabName, objKeyField.FldName);

            //strBuilder.Append("\r\n" + "  //引发删除记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onDelRecord?.Invoke({0});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"在调用删除记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecord_Static", "根据关键字删除记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})根据关键字删除记录出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"11:(errid:{22})根据关键字删除记录出错!({1}:DelRecord)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"根据关键字删除记录出错!({1}: DelRecord)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JBL_DelNode()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int DelNode({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2});",
                objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "int intRecNum = {0}DA.DelNode({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            //strBuilder.Append("\r\n" + "  //引发删除记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onDelRecord?.Invoke({0});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"在调用删除记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.Append("\r\n" + "ReFreshCache();");
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecord", "根据关键字删除记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})根据关键字删除记录出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"11:(errid:{22})根据关键字删除记录出错!({1}:DelRecord)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"根据关键字删除记录出错!({1}: DelRecord)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_TabFeature_DelRecordBySign()
        {

            StringBuilder strBuilder = new StringBuilder();
            if (objDelSignField == null)
            {
                string strMsg = string.Format("//表：[{0}]的删除标志字段(DeletedDate, IsDeleted)为空,不能生成【恢复被删除记录(UnDelRecordBySign)】函数;",
                    objPrjTabENEx.TabName);
                throw new Exception(strMsg);
            }

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:根据标志删除关键字所指定的记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}\">给定的关键字列表</param>", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static int DelRecordBySign(List<{0}> arr{1})",
                 objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                 objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static int DelRecordBySign(List<{0}> arr{1}, {2} {3})",
              objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
              objKeyField.FldName_FstUcase,
                objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "int intRecNum_Total = 0;");
            strBuilder.AppendFormat("\r\n" + "arr{0}.ForEach((x) =>", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = {0}DA.DelRecordBySign(x);",
              objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "            intRecNum_Total += intRecNum;");

            strBuilder.Append("\r\n" + "        });");



            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.Append("\r\n" + "ReFreshCache();");
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "ReFreshCache({0});",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "return intRecNum_Total;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecordBySign", "根据标志删除记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})根据标志删除记录出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"11:(errid:{22})根据关键字删除记录出错!({1}:DelRecordBySign)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"根据关键字删除记录出错!({1}: DelRecordBySign)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_TabFeature_UnDelRecordBySign()
        {

            StringBuilder strBuilder = new StringBuilder();
            if (objDelSignField == null)
            {
                string strMsg = string.Format("//表：[{0}]的删除标志字段(DeletedDate, IsDeleted)为空,不能生成【恢复被删除记录(UnDelRecordBySign)】函数;",
                    objPrjTabENEx.TabName);
                throw new Exception(strMsg);
                //strBuilder.AppendFormat("\r\n" + "//表：[{0}]的删除标志字段为空,不能生成【恢复被删除记录(UnDelRecordBySign)】;", objPrjTabENEx.TabName);
                //return strBuilder.ToString();

            }

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:恢复被删除的记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}\">给定的关键字列表</param>", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n /// <returns>返回恢复删除的记录数</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static int UnDelRecordBySign(List<{0}> arr{1})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                 objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static int UnDelRecordBySign(List<{0}> arr{1}, {2} {3})",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                 objKeyField.FldName_FstUcase,
                objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);

            }
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "int intRecNum_Total = 0;");
            strBuilder.AppendFormat("\r\n" + "arr{0}.ForEach((x) =>", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = {0}DA.UnDelRecordBySign(x);",
              objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "            intRecNum_Total += intRecNum;");

            strBuilder.Append("\r\n" + "        });");


            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.Append("\r\n" + "ReFreshCache();");
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "ReFreshCache({0});",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "return intRecNum_Total;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UnDelRecordBySign", "恢复被删除记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})恢复被删除记录出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"11:(errid:{22})根据关键字删除记录出错!({1}:UnDelRecordBySign)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"根据关键字删除记录出错!({1}: UnDelRecordBySign)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JBL_DelNodeWithTransaction_S()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指的记录,使用事务");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>返回删除是否成功?</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static bool DelNode({0}, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
                        objPrjTabENEx.KeyVarDefineLstStr);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static bool DelRecord({0}, {1} {2}, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
                    objPrjTabENEx.KeyVarDefineLstStr,
                objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);

            }
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.DelRecord({1},objSqlConnection,objSqlTransaction);",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.Append("\r\n" + "ReFreshCache();");
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "ReFreshCache({0});",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecord", "根据关键字删除记录出错!(使用事务)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})根据关键字删除记录出错!(使用事务),{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"11:(errid:{22})根据关键字删除记录出错!(使用事务)({1}:DelRecord)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"根据关键字删除记录出错!(使用事务)({1}: DelRecord)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_DelRecordBySP_S()
        {
            string strTemp = "";
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            ///
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strTemp = string.Format("public bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            }
            else
            {
                strTemp = string.Format("public bool DelRecordBySP({0}, {1} {2}) ",
                        objPrjTabENEx.KeyVarDefineLstStr,
                    objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.DelRecordBySP({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.Append("\r\n" + "ReFreshCache();");
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "ReFreshCache({0});",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "DelRecordBySP", "通过存储过程删除记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})通过存储过程删除记录出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"10:(errid:{22})通过存储过程删除记录出错!({1}:DelRecordBySP)\\r\\n\" + objException.Message);",
            //    objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">给定的关键字值列表</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");

            strBuilder.AppendFormat("\r\n" + "public static int Del{0}s(List<string> arr{1}Lst)",
        objPrjTabENEx.TabName, objKeyField.FldName);
       
    strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}Lst.Count == 0) return 0;", objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "int intDelRecNum = {0}DA.Del{0}(arr{1}Lst);",
                    objPrjTabENEx.TabName, objKeyField.FldName);
            }
            else
            {
                if (objKeyField.IsNumberType())
                {
                    strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2}.Parse(arr{1}Lst[0]));",
    objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.CsType);

                }
                else
                {
                    strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}(arr{1}Lst[0]);",
    objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.PrivFuncName);
                }
                strBuilder.AppendFormat("\r\n" + "int intDelRecNum = {0}DA.Del{0}(arr{1}Lst);",
                    objPrjTabENEx.TabName, objKeyField.FldName);
            }
            

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.Append("\r\n" + "ReFreshCache();");
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "ReFreshCache(obj{0}EN.{1});",
                    objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return intDelRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}s", "删除多关键字记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})删除多关键字记录出错,{{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"09:(errid:{22})删除多关键字记录出错!({1}:Del{0}s)\\r\\n\" + objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"删除多关键字记录出错!({1}: Del{0}s)\\r\\n\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要删除的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>返回删除的记录数。</returns>");
        
                strBuilder.AppendFormat("\r\n" + "public static int Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName, objKeyField.FldName);
        
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strBuilder.AppendFormat("\r\n" + "List<string> arr{1} = GetFldValue(con{0}.{1}, strWhereCond);",
                    objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
                strBuilder.AppendFormat("\r\n" + "int intRecNum = {0}DA.Del{0}(strWhereCond);",
                objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.Append("\r\n" + "ReFreshCache();");
            }
            else
            {                
                strBuilder.AppendFormat("\r\n" + "arr{0}.ForEach(x => ReFreshCache(x));",
                    objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}sByCond", "删除带条件表记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})删除带条件表记录出错!(strWhereCond = {{1}}),{{2}}.({{0}})\",", strErrId, "{", "}");
                     strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"08:(errid:{22})删除带条件表记录出错!(strWhereCond = {{0}})({1}:Del{0}sByCond)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"删除带条件表记录出错!({1}: Del{0}sByCond)\\r\\n\" + objException.Message);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要删除的记录条件</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>返回是否删除成功。</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static bool Del{0}sByCondWithTransaction_S(string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static bool Del{0}sByCondWithTransaction_S(string strWhereCond, {1} {2}, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName,
                objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);

            }
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.Del{0}WithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);",
                objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.Append("\r\n" + "ReFreshCache();");
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "ReFreshCache({0});",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Del{0}sByCondWithTransaction_S", "删除带条件表记录出错!(同时处理事务)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})删除带条件表记录出错!(同时处理事务)(strWhereCond = {{1}}), {{2}}.({{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"08:(errid:{22})删除带条件表记录出错!(同时处理事务)(strWhereCond = {{0}})({1}:Del{0}sByCondWithTransaction_S)\\r\\n 错误信息:{{1}}\",strWhereCond, objException.Message));",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId, "{", "}");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"删除带条件表记录出错!(同时处理事务)({1}: Del{0}WithTransaction_S)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_Neo4JBL_Static_AddNewNode()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewNode(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int"
                 && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空!(from {0})\\r\\n\", ");
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.{0}DA.AddNewNode(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //引发添加新记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onAddNewRecord?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"在调用添加记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewNode_Static", "纯静态添加记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})添加记录出错, {{1}}.(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})添加记录出错!({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_Neo4JBL_Static_AddNewNodeWithMaxId()
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewNodeWithMaxId(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

       
                strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = cls{0}BL.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.{0}DA.AddNewNode(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //引发添加新记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onAddNewRecord?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"在调用添加记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewNodeWithMaxId_Static", "纯静态添加记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})添加记录出错, {{1}}.(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})添加记录出错!({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_Neo4JBL_AddNewNode()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            clsTabFunctionPropEN objTabFunctionProp = objPrjTabENEx.arrTabFunctionProp.Find(x => x.FuncId4GC == objPrjTabENEx.FuncId4GC);
            if (objTabFunctionProp == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static bool AddNewNode(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            }
            else
            {
                clsMethodModifierEN objMethodModifier = clsMethodModifierBL.GetObjByMethodModifierIdCache(objTabFunctionProp.MethodModifierId);
                strBuilder.AppendFormat("\r\n" + "{1} static bool AddNewNode(cls{0}EN obj{0}EN)",
                        objPrjTabENEx.TabName, objMethodModifier.MethodModifierName);
            }

            strBuilder.Append("\r\n" + "{");

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03 
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int"
                 && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空!(from {0})\\r\\n\", ");
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.AddNewNode(obj{0}EN);",
            objPrjTabENEx.TabName);
      
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2", "添加记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})添加记录出错, {{1}}.(from {{0}})\",", strErrId );
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})添加记录出错!({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql2(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03 
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long"
                )
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空.(from {{0}})\", ");
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");

                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.AddNewRecordBySQL2(obj{0}EN, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2", "添加记录出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})添加记录出错!(带事务处理), {{1}}.({{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})添加记录出错!(带事务处理)({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!(带事务处理)({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_Static_AddNewRecordWithTransaction()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:通过SQL命令来插入记录");
            strBuilder.Append("\r\n /// 主要用于上传文件时。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecord(this cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long"
                )
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空.(from {{0}})\", ");
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");

                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.{0}DA.AddNewRecordBySQL2(obj{0}EN, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecord_Static", "添加记录出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})添加记录出错!(带事务处理), {{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})添加记录出错!(带事务处理)({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!(带事务处理)({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_AddNewRecordBySql2WithReturnKey()
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02 
                && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03 
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空!(from {{0}})\", ");
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");

                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.AppendFormat("\r\n" + "string strKey = {0}DA.AddNewRecordBySQL2WithReturnKey(obj{0}EN);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2WithReturnKey", "带返回值的添加记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})带返回值的添加记录出错, {{1}}.(from {{0}})\",", strErrId);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_Static_AddNewRecordWithReturnKey()
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordWithReturnKey(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空!(from {{0}})\", ");
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");

                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.AppendFormat("\r\n" + "string strKey = cls{0}BL.{0}DA.AddNewRecordBySQL2WithReturnKey(obj{0}EN);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecord_Static", "带返回值的添加记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})带返回值的添加记录出错, {{1}}.(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql2WithReturnKeyAndTransaction_S()
        {

            if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
              && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值,该函数可以进行事务处理(针对Identity关键字)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");

            strBuilder.Append("\r\n /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03 
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空!(from {{0}})\", ");
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");

                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strKey = {0}DA.AddNewRecordBySQL2WithReturnKey(obj{0}EN, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql2WithReturnKey", "带返回值的添加记录出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})带返回值的添加记录出错!(带事务处理), {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_Static_AddNewRecordWithReturnKeyAndTransaction()
        {

            if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
              && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值,该函数可以进行事务处理(针对Identity关键字)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");

            strBuilder.Append("\r\n /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordWithReturnKey(this cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空!(from {{0}})\", ");
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");

                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strKey = cls{0}BL.{0}DA.AddNewRecordBySQL2WithReturnKey(obj{0}EN, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordWithReturnKey_Static", "带返回值的添加记录出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})带返回值的添加记录出错!(带事务处理), {{1}}.(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">代表实体对象的XML串</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = GetObjFromXmlStr(str{0}ObjXml);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.AddNewRecordBySQL2(obj{0}EN);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
              objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordBySql_XML", "添加记录出错!(使用XML)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})添加记录出错!(使用XML), {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_Neo4JBL_UpdateNode()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateNode(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateNode(obj{0}EN);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
            objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update", "修改记录出错!", "生成代码");
            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})修改记录出错, {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_Neo4JBL_Static_UpdateNode()
        {

            StringBuilder strBuilder = new StringBuilder();
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update_Static", "修改记录时关键字不能为空!", "生成代码");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateNode(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                if (IsNumberType4Key == true)
                {
                    strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                     objPrjTabENEx.TabName, objKeyField.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                        objPrjTabENEx.TabName, objKeyField.FldName);
                }
                strBuilder.Append("\r\n" + " {");

                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改记录时关键字不能为空!(from {{0}})\\r\\n\",", strErrId);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.{0}DA.UpdateNode(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //引发修改记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onUpdateRecord?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"在调用修改记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update_Static", "修改记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改记录出错,{{1}}!(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_UpdateBySql2()
        {

            StringBuilder strBuilder = new StringBuilder();
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "修改记录时关键字不能为空!", "生成代码");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                if (IsNumberType4Key == true)
                {
                    strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                     objPrjTabENEx.TabName, objKeyField.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                        objPrjTabENEx.TabName, objKeyField.FldName);
                }
                strBuilder.Append("\r\n" + " {");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})修改记录时关键字不能为空!(from {{0}})\\r\\n\",", strErrId);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //引发修改记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onUpdateRecord?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"在调用修改记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "修改记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})修改记录出错,{{1}}!(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_UpdateBySql2ByTabName()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(cls{0}EN obj{0}EN, string strTabName)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //引发修改记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onUpdateRecord?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"在调用修改记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "修改记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})修改记录出错, {{2}}.(from {{0}})\\r\\n\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_Static_UpdateBySql2WithTransaction_S()
        {

            StringBuilder strBuilder = new StringBuilder();
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "修改记录时关键字不能为空!(带事务处理)", "生成代码");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.Append("\r\n /// /// 3、支持事务处理.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(this cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                if (IsNumberType4Key == true)
                {
                    strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                     objPrjTabENEx.TabName, objKeyField.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                        objPrjTabENEx.TabName, objKeyField.FldName);
                }
                strBuilder.Append("\r\n" + " {");
                
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改记录时关键字不能为空!(带事务处理)(from {{0}})\\r\\n\",", strErrId);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.{0}DA.UpdateBySql2(obj{0}EN, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();",
                objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql2", "修改记录出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改记录出错,{{1}}.(带事务处理)(from {{0}})\\r\\n\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_Static_UpdateWithTransaction()
        {

            StringBuilder strBuilder = new StringBuilder();
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update_Static", "修改记录时关键字不能为空!(带事务处理)", "生成代码");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；");
            strBuilder.Append("\r\n /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;");
            strBuilder.Append("\r\n /// /// 3、支持事务处理.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");

            strBuilder.AppendFormat("\r\n" + "public static bool Update(this cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                if (IsNumberType4Key == true)
                {
                    strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                     objPrjTabENEx.TabName, objKeyField.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                        objPrjTabENEx.TabName, objKeyField.FldName);
                }
                strBuilder.Append("\r\n" + " {");

                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改记录时关键字不能为空!(带事务处理)(from {{0}})\\r\\n\",", strErrId);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.{0}DA.UpdateBySql2(obj{0}EN, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update_Static", "修改记录出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改记录出错,{{1}}.(带事务处理)(from {{0}})\\r\\n\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySqlWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySqlWithCondition(obj{0}EN, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySqlWithCondition", "根据条件修改记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})根据条件修改记录出错, {{1}}.(from {{0}})\\r\\n\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_Neo4JBL_Static_UpdateWithCondition()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateWithCondition(this cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.{0}DA.UpdateBySqlWithCondition(obj{0}EN, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateWithCondition_Static", "根据条件修改记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})根据条件修改记录出错, {{1}}.(from {{0}})\\r\\n\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySqlWithConditionTransaction(cls{0}EN obj{0}EN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySqlWithConditionTransaction(obj{0}EN, strWhereCond, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySqlWithConditionTransaction", "根据条件修改记录出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})根据条件修改记录出错!(带事务处理),{{1}}.(from {{0}})\\r\\n\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_Static_UpdateWithConditionTransaction()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateWithCondition(this cls{0}EN obj{0}EN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.{0}DA.UpdateBySqlWithConditionTransaction(obj{0}EN, strWhereCond, objSqlConnection, objSqlTransaction);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateWithCondition_Static", "根据条件修改记录出错!(带事务处理)", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})根据条件修改记录出错!(带事务处理),{{1}}.(from {{0}})\\r\\n\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_UpdateBySql_XML()
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">需要修改的对象,用XML来表示</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = GetObjFromXmlStr(str{0}ObjXml);",
            objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}DA.UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache();", objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName);
            }

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateBySql_XML", "修改记录(UpdateBySql_XML)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})修改记录(UpdateBySql_XML)出错,{{1}}.!(from {{0}})\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_Neo4JBL_IsExistNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:判断是否存在某一条件的记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>");
            strBuilder.Append("\r\n" + "public static bool IsExistNode(string strWhereCond)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = {0}DA.IsExistCondRec(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JBL_GetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");

            strBuilder.AppendFormat("\r\npublic static {0} GetFirstID_S(string strWhereCond) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n {0} {1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n {0} = new cls{1}DA().GetFirstID(strWhereCond);",
            objKeyField.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return {0};", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetFirstID_S", "获取First关键字出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取First关键字出错, {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件的关键字列表值</returns>");

            strBuilder.Append("\r\npublic static List<string> GetPrimaryKeyID_S(string strWhereCond) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n List<string> arrList;");
            //strBuilder.AppendFormat("\r\n {0} {1};",
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arrList = {0}DA.GetID(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return arrList;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetPrimaryKeyID_S", "获取关键字列表出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取关键字列表出错, {{1}}.(from {{0}})\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JBL_GetMaxStrId_S()
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";

            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");

                strBuilder.Append("\r\npublic static string GetMaxStrId() ");
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
          objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetMaxStrId", "获取最大关键字值(GetMaxStrId)出错!", "生成代码");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取最大关键字值出错, {{1}}.(from {{0}})\",", strErrId);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
                strBuilder.AppendFormat("\r\n" + "objException.Message); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                strBuilder.Append("\r\n }");

                strBuilder.Append("\r\n}");
            }
            else
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strBuilder.AppendFormat("\r\npublic static {0} GetMaxId() ", objKeyField.CsType);
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n {0} varMax{1};",
                objKeyField.CsType, objKeyField.FldName_FstUcase);
                strBuilder.Append("\r\n try");
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n varMax{0} = cls{1}DA.GetMaxId();",
                objKeyField.FldName_FstUcase, objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n return varMax{0};", objKeyField.FldName_FstUcase);
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n catch (Exception objException)");
                strBuilder.Append("\r\n {");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetMaxStrId", "获取最大关键字值(GetMaxStrId)出错!", "生成代码");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取最大关键字值出错, {{1}}.(from {{0}})\",", strErrId);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
                strBuilder.AppendFormat("\r\n" + "objException.Message); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                strBuilder.Append("\r\n }");

                strBuilder.Append("\r\n}");
            }
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }
        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JBL_GetMaxStrIdByPrefix_S()
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06) return "";

            if (objKeyField.CsType != "string") return "";
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");

            strBuilder.Append("\r\npublic static string GetMaxStrIdByPrefix(string strPrefix) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strPrefix) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strMsg = string.Format(\"前缀不能为空.(from {0})\",");
            strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n string strMax{1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strMax{0} = new cls{1}DA().GetMaxStrIdByPrefix(strPrefix);",
            objKeyField.FldName_FstUcase, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return strMax{0};", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetMaxStrIdByPrefix_S", "根据前缀获取最大关键字值(GetMaxStrId)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})根据前缀获取最大关键字值出错, {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})检查是否存在当前表(IsExistTable)出错, {{1}}.(from {{0}})\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查是否存在当前表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">给定表</param>");
            strBuilder.Append("\r\n /// <returns>存在就返回True,否则返回False</returns>");

            strBuilder.Append("\r\npublic static bool IsExistTable(string strTabName) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n bool bolIsExist;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n bolIsExist = {0}DA.IsExistTable(strTabName);",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return bolIsExist;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "IsExistTable", "检查是否存在指定表(IsExistTable)出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})检查是否存在指定表(IsExistTable)出错, {{1}}.(from {{0}})\",", strErrId);            
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的对象</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetFirstObj_S(string strWhereCond) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = {0}DA.GetFirstObj(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "GetFirstObj_S", "获取当前表满足条件的第一条记录数据出错", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})获取当前表满足条件的第一条记录数据出错!(strWhereCond = {{1}}),{{2}}.(from {{0}})\",", strErrId, "{", "}");
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRow\">给定的DataRow</param>");
            strBuilder.Append("\r\n /// <returns>返回相关的实体对象</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetObjByDataRow_S(DataRow objRow) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = {0}DA.GetObjByDataRow(objRow);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "getObjByDataRow_S", "根据DataRow记录获取对象出错!", "生成代码");


            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})根据DataRow记录获取对象出错, {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把DataRowView转换成相关实体对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRow\">给定的DataRowView</param>");
            strBuilder.Append("\r\n /// <returns>返回相关的实体对象</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetObjByDataRow_S(DataRowView objRow) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = {0}DA.GetObjByDataRow(objRow);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "getObjByDataRow_S", "根据DataRowView记录获取对象出错!", "生成代码");


            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})通过DataRowView记录对象出错, {{1}}.(from {{0}})\",", strErrId);
                        strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");

            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }


        public string Gen_Neo4JBL_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 判断当前表中是否存在给定关键字值的记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "IsExist",
                    string.Format("在表中,关键字[Key]不能为空!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                     objPrjTabENEx.TabName), "生成代码");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})在表中,关键字[{1}]不能为空!!(from {{0}})\",", strErrId, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{22})在表[{1}]中,关键字[{0}]不能为空!(cls{1}BL:IsExist)\");",
                //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                //         objPrjTabENEx.TabName,
                //         strErrId);
                //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }

            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = {0}DA.IsExist({1});",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
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
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "IsExistByTabName",
                    string.Format("在表中,关键字[Key]不能为空!", objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                     objPrjTabENEx.TabName), "生成代码");

                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})在表中,关键字[{1}]不能为空.(from {{0}})\",", strErrId, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

                //strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{22})在表[{1}]中,关键字[{0}]不能为空!(cls{1}BL:IsExist)\");",
                //        objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                //         objPrjTabENEx.TabName,
                //         strErrId);
                //strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }

            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = {0}DA.IsExist({1}, strTabName);",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_4BL_Static_CheckUniqueness()
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
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(主键)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness(this {1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\n" + "//检测记录是否存在");
                    strBuilder.AppendFormat("\r\n" + "bool bolIsUniqueness = cls{0}BL.{0}DA.Check{1}Uniqueness({3}, {5});",
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
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
                    strBuilder.AppendFormat("\r\n" + "bool bolIsUniqueness = {0}DA.Check{1}Uniqueness({3}, {5});",
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
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
                            objKeyField.PropertyName(this.IsFstLcase));
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
                    strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = {0}DA.Check{1}Uniqueness(",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1});",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "else");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = {0}DA.Check{1}Uniqueness(",
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

        public string Gen_4BL_Static_CheckUniquenessV3()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
              objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求唯一的对象</param>",
                   objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness(this cls{0}EN obj{0}EN)",
                         objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");

            strBuilder.Append("\r\n" + "bool bolIsUniqueness;");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
            objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "int":
                    case "long":
                    case "short":
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                        objPrjTabENEx.TabName,
                        objKeyField.PropertyName(this.IsFstLcase));
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

                strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}BL.{0}DA.Check{0}Uniqueness(",
                objPrjTabENEx.TabName);
                bool bolIsFirst = true;
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

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
                strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}BL.{0}DA.Check{0}Uniqueness(",
                objPrjTabENEx.TabName);

                strBuilder.AppendFormat("obj{0}EN.{1}",
                objPrjTabENEx.TabName,
                objKeyField.FldName);

                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;
                    strBuilder.AppendFormat(", obj{0}EN.{1}",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);

                }
                strBuilder.Append(");");
                strBuilder.Append("\r\n" + "}");
            }
            strBuilder.Append("\r\n" + "return bolIsUniqueness;");

            strBuilder.Append("\r\n" + "}");


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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "int":
                    case "long":
                    case "short":
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                        objPrjTabENEx.TabName,
                        objKeyField.PropertyName(this.IsFstLcase));
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

                strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = {0}DA.Check{0}Uniqueness(",
                objPrjTabENEx.TabName);
                bool bolIsFirst = true;
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

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
                strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = {0}DA.Check{0}Uniqueness(",
                objPrjTabENEx.TabName);

                strBuilder.AppendFormat("obj{0}EN.{1}",
                objPrjTabENEx.TabName,
                objKeyField.FldName);

                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;
                    strBuilder.AppendFormat(", obj{0}EN.{1}",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);

                }
                strBuilder.Append(");");
                strBuilder.Append("\r\n" + "}");
            }
            strBuilder.Append("\r\n" + "return bolIsUniqueness;");

            strBuilder.Append("\r\n" + "}");


            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 检查表的约束
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Static_CheckConstraint()
        {
            int intVerCount = 1;
            StringBuilder strBuilder = new StringBuilder();
            //检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;
                
                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId); 
                switch (objInFor.ConstraintTypeId)
                {
                    case enumConstraintType.Uniqueness_01:

                        strBuilder.Append("\r\n /// <summary>");
                        strBuilder.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
                          objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n /// </summary>");
                        strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求唯一的对象</param>",
                               objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strBuilder.Append("\r\n /// <returns></returns>");
                        strBuilder.Append($"\r\npublic static bool CheckUniqueness{strVersion}(this cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n" + "//检测记录是否存在");

                        strBuilder.Append("\r\n" + "bool bolIsUniqueness;");
                        strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");

                        strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
                        objPrjTabENEx.TabName);

                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "int":
                            case "long":
                            case "short":
                                strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
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

                        //bool bolIsFirst = true;
              
                        strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
                           objKeyField.FldName,
                           objKeyField.PrivFuncName,
                           "{", "}");

                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{0});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName);
                        }
                        strBuilder.AppendFormat("\r\nif (cls{0}BL.IsExistRecord(sbCondition.ToString())  ==  true)",
                                objPrjTabENEx.TabName);
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n" + " bolIsUniqueness = false;");
                        strBuilder.Append("\r\n}");
                        strBuilder.Append("\r\nelse");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n" + " bolIsUniqueness = true;");
                        strBuilder.Append("\r\n}");



                        strBuilder.Append("\r\n}");

                        //bool bolIsFirst = true;


                        strBuilder.Append("\r\n else {");
                        
                        if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                        {
                            strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  {{0}}\", obj{1}EN.{0});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  '{{0}}'\", obj{1}EN.{0});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName);
                        }
                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {
                            
                            strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{0});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName);
                        }
                        strBuilder.AppendFormat("\r\nif (cls{0}BL.IsExistRecord(sbCondition.ToString())  ==  true)",
                                objPrjTabENEx.TabName);
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n" + " bolIsUniqueness = false;");
                        strBuilder.Append("\r\n}");
                        strBuilder.Append("\r\nelse");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n" + " bolIsUniqueness = true;");
                        strBuilder.Append("\r\n}");
                        strBuilder.Append("\r\n}");
                                             
                     
                
                        strBuilder.Append("\r\n" + "return bolIsUniqueness;");

                        strBuilder.Append("\r\n" + "}");
                        break;

                    case enumConstraintType.MaxMinValue_02:

                        strBuilder.Append("\r\n /// <summary>");
                        strBuilder.AppendFormat("\r\n /// 检查最大最小值(MaxMinValue)--{0}({1}), 如果超过最大值,就返回False; 如果低于最小值,就返回False; ",
                          objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n /// </summary>");
                        strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求限制最大值的对象</param>",
                               objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strBuilder.Append("\r\n /// <returns></returns>");
                        strBuilder.AppendFormat("\r\npublic static bool CheckMaxMinValue_{1}(this cls{0}EN obj{0}EN)",
                                     objPrjTabENEx.TabName, objInFor.ConstraintName4GC());
                        strBuilder.Append("\r\n{");
                        
                        strBuilder.Append("\r\n" + "bool bolResult;");
                        
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
                        objPrjTabENEx.TabName);

                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {
                            if (string.IsNullOrEmpty(objField.MaxValue) == false)
                            {
                                strBuilder.AppendFormat("\r\n " + "if (obj{1}EN.{0}> {2}) bolResult = false;",
                                            objField.ObjFieldTab().FldName,
                                            objPrjTabENEx.TabName, objField.MaxValue);
                            }
                            if (string.IsNullOrEmpty(objField.MinValue) == false)
                            {
                                strBuilder.AppendFormat("\r\n " + "if (obj{1}EN.{0}< {2}) bolResult = false;",
                                       objField.ObjFieldTab().FldName,
                                       objPrjTabENEx.TabName, objField.MinValue);
                            }

                        }

                        strBuilder.Append("\r\n" + "return true;");

                        strBuilder.Append("\r\n" + "}");
                        break;

                  
                }
                
            }

            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_Static_GetConditionString4Constraint()
        {
            int intVerCount = 1;
            StringBuilder strBuilder = new StringBuilder();
            //检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;
                
                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);
                switch (objInFor.ConstraintTypeId)
                {
                    case enumConstraintType.Uniqueness_01:

                        strBuilder.Append("\r\n /// <summary>");
                        strBuilder.AppendFormat("\r\n /// 获取唯一性条件串--{0}({1}), 即由对象中唯一性条件字段关键字与值组成的条件串",
                                                  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strBuilder.Append($"\r\n /// 唯一性条件:{objInFor.ConstraintName4GC()}");
                        strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n /// </summary>");
                        strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求唯一的对象</param>",
                               objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strBuilder.Append("\r\n /// <returns></returns>");
                        strBuilder.Append($"\r\npublic static string GetUniCondStr{strVersion}(this cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)"); 
                        
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n" + "//检测记录是否存在");

                        //strBuilder.Append("\r\n" + "bool bolIsUniqueness;");
                        strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");

                        strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return \"\";",
                        objPrjTabENEx.TabName);

                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "int":
                            case "long":
                            case "short":
                                strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
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

                        //bool bolIsFirst = true;

                        strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
                           objKeyField.FldName,
                           objKeyField.PrivFuncName,
                           "{", "}");

                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{0});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName);
                        }
                        strBuilder.AppendFormat("\r\nreturn sbCondition.ToString();",
                                objPrjTabENEx.TabName);


                        strBuilder.Append("\r\n}");

                        //bool bolIsFirst = true;


                        strBuilder.Append("\r\n else {");

                        if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                        {
                            strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  {{0}}\", obj{1}EN.{0});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  '{{0}}'\", obj{1}EN.{0});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName);
                        }
                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{0});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName);
                        }
                        strBuilder.AppendFormat("\r\n return sbCondition.ToString();",
                                objPrjTabENEx.TabName);
                        strBuilder.Append("\r\n}");

                        strBuilder.Append("\r\n" + "}");
                        break;

                    case enumConstraintType.MaxMinValue_02:

                        //strBuilder.Append("\r\n /// <summary>");
                        //strBuilder.AppendFormat("\r\n /// 检查最大最小值(MaxMinValue)--{0}({1}), 如果超过最大值,就返回False; 如果低于最小值,就返回False; ",
                        //  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        //strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        //strBuilder.Append("\r\n /// </summary>");
                        //strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求限制最大值的对象</param>",
                        //       objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        //strBuilder.Append("\r\n /// <returns></returns>");
                        //strBuilder.AppendFormat("\r\npublic static bool CheckMaxMinValue_{1}(this cls{0}EN obj{0}EN)",
                        //             objPrjTabENEx.TabName, objInFor.ConstraintName4GC());
                        //strBuilder.Append("\r\n{");

                        //strBuilder.Append("\r\n" + "bool bolResult;");

                        //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
                        //objPrjTabENEx.TabName);

                        //foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        //{
                        //    if (string.IsNullOrEmpty(objField.MaxValue) == false)
                        //    {
                        //        strBuilder.AppendFormat("\r\n " + "if (obj{1}EN.{0}> {2}) bolResult = false;",
                        //                    objField.ObjFieldTabENEx.FldName,
                        //                    objPrjTabENEx.TabName, objField.MaxValue);
                        //    }
                        //    if (string.IsNullOrEmpty(objField.MinValue) == false)
                        //    {
                        //        strBuilder.AppendFormat("\r\n " + "if (obj{1}EN.{0}< {2}) bolResult = false;",
                        //               objField.ObjFieldTabENEx.FldName,
                        //               objPrjTabENEx.TabName, objField.MinValue);
                        //    }

                        //}

                        //strBuilder.Append("\r\n" + "return true;");

                        //strBuilder.Append("\r\n" + "}");
                        break;


                }
            }

            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_Static_GetUniquenessConditionString()
        {
            if (objPrjTabENEx.arrPrjConstraintSet().Count == 0) return "";
            int intVerCount = 1;
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;
                
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取检查唯一性条件串(Uniqueness)--{0}({1}),根据唯一约束条件来生成",
                  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strBuilder.Append($"\r\n /// 唯一性条件:{objInFor.ConstraintName4GC()}");

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求唯一的对象</param>",
                       objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strBuilder.Append("\r\n /// <returns></returns>");
                strBuilder.Append($"\r\npublic static string GetUniCondStr{strVersion}(this cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\n" + "//检测记录是否存在");

                //
                strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
                objKeyField.FldName,
                objKeyField.PrivFuncName);
                List<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId).ToList();

                foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                {
                    //if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                    strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{0});",
                                objField.ObjFieldTab().FldName,
                                objPrjTabENEx.TabName);
                }

                strBuilder.Append("\r\nreturn sbCondition.ToString();");

                strBuilder.Append("\r\n" + "}");
            }

            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetUniquenessConditionString()
        {
            if (objPrjTabENEx.arrPrjConstraintSet().Count == 0) return "";
            int intVerCount = 1;
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;
                
                var arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 获取检查唯一性条件串(Uniqueness)--{0}({1})",
                  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strBuilder.Append($"\r\n /// 唯一性条件:{objInFor.ConstraintName4GC()}");

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求唯一的对象</param>",
                       objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strBuilder.Append("\r\n /// <returns></returns>");
                strBuilder.Append($"\r\npublic static string GetUniCondStr{strVersion}(cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\n" + "//检测记录是否存在");

                strBuilder.AppendFormat("\r\n" + "string strResult = {0}DA.GetUniCondStr(",
                        objPrjTabENEx.TabName, objInFor.ConstraintName4GC());
                strBuilder.AppendFormat("obj{0}EN);", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "return strResult;");

                strBuilder.Append("\r\n" + "}");
                
            }

            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string Gen_Neo4JBL_Static_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //检测记录是否存在
            strBuilder.AppendFormat("\r\n cls{0}BL.{0}DA.CheckPropertyNew(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            ///检查类中属性是否正确 == == ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //检测记录是否存在
            strBuilder.AppendFormat("\r\n {0}DA.CheckPropertyNew(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            ///检查类中属性是否正确 == == ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string Gen_Neo4JBL_Static_CombineConditionByCondObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {                
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 根据条件对象中的字段内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static string GetCombineCondition(this cls{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");
                               

                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {

                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {
                        case enumDataTypeAbbr.bit_03:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                                 objPrjTabENEx.TabName,
                                        objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.{1} == true)",
                                        objPrjTabENEx.TabName,
                                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                            strCodeForCs.Append("\r\n" + "{");


                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objField.ObjFieldTabENEx.FldName,
                                     objPrjTabENEx.TabName,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objField.ObjFieldTabENEx.FldName,
                                     objPrjTabENEx.TabName,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                            break;

                        case enumDataTypeAbbr.char_04:
                        case enumDataTypeAbbr.varchar_25:
                        case enumDataTypeAbbr.nvarchar_15:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} '{{1}}'\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumDataTypeAbbr.datetime_05:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} '{{1}}'\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumDataTypeAbbr.decimal_06:
                        case enumDataTypeAbbr.float_07:
                        case enumDataTypeAbbr.int_09:
                        case enumDataTypeAbbr.bigint_01:
                        case enumDataTypeAbbr.bigintidentity_26:


                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} {{1}}\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "//数据类型{0}({1})在函数:[{2}]中没有处理!",
                                  objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                  clsStackTrace.GetCurrClassFunction());
                            break;
                    }
                }

                strCodeForCs.Append("\r\n" + " return strWhereCond;");

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

        public string Gen_4BL_Static_CheckProperty4Condition()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckProperty4Condition(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //检测记录是否存在
            strBuilder.AppendFormat("\r\n cls{0}BL.{0}DA.CheckProperty4Condition(obj{0}EN);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckProperty4Condition(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //检测记录是否存在
            strBuilder.AppendFormat("\r\n {0}DA.CheckProperty4Condition(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            ///检查类中属性是否正确 == == ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_ComboBoxBindFunction()
        {
            string strFuncName = "";
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
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 =1 Order By {{0}}\", con{0}.{1}); ",
                        objPrjTabENEx.TabName, strValueFieldName, "{", "}");
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObj = cls{0}BL.GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//初始化一个对象列表");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN()",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    if (bolIsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{1} = \"0\",",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{1} = 0,",
                        objPrjTabENEx.TabName, strValueFieldName);

                    }

                    strCodeForCs.AppendFormat("\r\n" + "{1} = \"选[{2}]...\"",
                        objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);
                    strCodeForCs.Append("\r\n" + "};");

                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//把DataTable中的所有项均加到对象列表中");
                    strCodeForCs.AppendFormat("\r\n" + "foreach(cls{0}EN objInFor in arrObj)", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                                  
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(objInFor);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");

                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = con{0}.{1};",
                     objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = con{0}.{1};",
                     objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

    
        public string Gen_4BL_DdlBindFunction()
        {
            string strFuncName = "";
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
                if (string.IsNullOrEmpty(strValueFieldName) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的关键字段为空,不能生成绑定下拉框相关函数文件;", objPrjTabENEx.TabName);
                    return strCodeForCs.ToString();

                }
                if (string.IsNullOrEmpty(strTextFieldName) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的名称字段为空,不能生成绑定下拉框相关函数文件;", objPrjTabENEx.TabName);
                    return strCodeForCs.ToString();
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

                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 =1 Order By {{0}}\", con{0}.{1}); ",
    objPrjTabENEx.TabName, strValueFieldName, "{", "}");
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = cls{0}BL.GetObjLst(strCondition);",
                         objPrjTabENEx.TabName);

                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = con{0}.{1};", objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = con{0}.{1};", objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = arrObjLst;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

      

        public string Gen_4BL_DdlBindFunctionCache()
        {
            if (this.objPrjTabENEx.IsUseCache == false) return "";

            string strFuncName = "";
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
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Web的下拉框-使用Cache");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objDDL\">需要绑定当前表的下拉框</param>");
                    if (objPrjTabENEx.objCacheClassifyFld == null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}Cache(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}Cache(System.Web.UI.WebControls.DropDownList objDDL, {1} {2})",
               strValueFieldName,
                objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"选[{0}]...\",\"0\");",
                                      objPrjTabENEx.TabCnName);

                    //strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = new cls{1}DA().Get{0}();",
                    //strValueFieldName, objPrjTabENEx.TabName);
                    if (objPrjTabENEx.objCacheClassifyFld == null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = GetAll{0}ObjLstCache(); ",
                              objPrjTabENEx.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = GetAll{0}ObjLstCache({1}); ",
                              objPrjTabENEx.TabName,
                              objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = con{0}.{1};", objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = con{0}.{1};", objPrjTabENEx.TabName, strTextFieldName);
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
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_GetObjLst4SelectListItem()
        {
            string strFuncName = "";
            if (objProjectsENEx.IsSupportMvc == false) return "//由于项目不支持Mvc,所以不能生成GetObjLst4SelectListItem()函数";
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
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 获取用户绑定下拉框的对象列表");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static List<SelectListItem> GetObjLst4SelectListItem(string strWhereCond)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");


                    //strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = new cls{1}DA().Get{0}();",
                    //strValueFieldName, objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(strWhereCond); ",
                              objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "List<SelectListItem> {0}List = new List<SelectListItem>();",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(new SelectListItem {3} Text = \"选[{5}]...\", Value = \"0\" {4});",
                    objPrjTabENEx.TabName, strTextFieldName, strValueFieldName, "{", "}", objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObjLst)", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(new SelectListItem {3} Text = objInFor.{1}, Value = objInFor.{2} {4});",
                        objPrjTabENEx.TabName, strTextFieldName, strValueFieldName, "{", "}");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.AppendFormat("\r\n" + "return {0}List;", objPrjTabENEx.TabName);

                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_SortFunction()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsSortFld == false) continue;
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 对象列表排序函数,根据:{0}字段", objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"parr{0}ObjLst\">需要排序的对象列表</param>", objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "public static void Sort{0}ObjLstBy{1}(List<cls{0}EN> parr{0}ObjLst, SortOrder mySortOrder)",
                                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                    strCodeForCs.AppendFormat("\r\n" + "parr{0}ObjLst.Sort((cls{0}EN obj{0}EN1, cls{0}EN obj{0}EN2) =>",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN1.{1}.CompareTo(obj{0}EN2.{1})<0)",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN1.{1} < obj{0}EN2.{1})",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (mySortOrder == SortOrder.Ascending)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return -1;//左值小于右值,返回-1,为升序,如果返回1,就是降序  ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return 1;//左值小于右值,返回-1,为升序,如果返回1,就是降序  ");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "else if (obj{0}EN1.{1} == obj{0}EN2.{1})//左值等于右值,返回0  ",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return 0;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (mySortOrder == SortOrder.Ascending)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return 1;//左值大于右值,返回1,为升序,如果返回-1,就是降序  ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "return -1;//左值大于右值,返回1,为升序,如果返回-1,就是降序  ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "});");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4BL_GetSubSet4ObjLst()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "06") continue;
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 根据分类字段获取缓存中对象列表的子集,根据:{0}字段", objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"parr{0}ObjLst\">需要排序的对象列表</param>", objPrjTabENEx.TabName);

                    strCodeForCs.AppendFormat("\r\n" + "public static List <cls{0}EN> GetSubSet4{0}ObjLstBy{1}Cache({2} {3})",
                                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                                objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objField.ObjFieldTabENEx.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "   if (string.IsNullOrEmpty({0}) == true) return null;",
                            objField.ObjFieldTabENEx.PrivFuncName);
                    }
                    // strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                    strCodeForCs.Append("\r\n" + "//初始化列表缓存");
                    //strCodeForCs.Append("\r\n" + "InitListCache(); ");
                    //strBuilder.Append("\r\n" + "//获取缓存中的对象列表");
                    if (objPrjTabENEx.objCacheClassifyFld == null)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                            objPrjTabENEx.TabName);
                        strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache();",
                            objPrjTabENEx.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                        objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                        strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                            objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

                    strCodeForCs.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel;", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                }
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
        /// 初始化列表缓存.
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JBL_InitListCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";
            StringBuilder strBuilder = new StringBuilder();
            //初始化列表缓存.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 初始化列表缓存.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n" + "public static void InitListCache()");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
            {
                strBuilder.Append("\r\n" + "//检查缓存刷新机制");
                strBuilder.Append("\r\n" + "string strMsg;");
                strBuilder.AppendFormat("\r\n" + "if (cls{0}BL.objCommFun4BL == null)", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"类cls{2}BL没有刷新缓存机制(cls{2}BL.objCommFun4BL == null), 请联系程序员!(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                    "{", "}", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
            }
            else if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
            {
                List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
                bool bolIsDef_strMsg = false;
                foreach (string strRelaTabId in arrTabId)
                {
                    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, objPrjTabENEx.PrjId);
                    if (objPrjTab.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW) continue;
                    if (objPrjTab.TabName == "Sex")
                    {
                        string strMsg = string.Format("objPrjTab.TabName={0},objPrjTab.TabStateId='{1}'",
                            objPrjTab.TabName, objPrjTab.TabStateId);
                        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                    }
                    if (objPrjTab.TabStateId != "01") continue;

                    if (bolIsDef_strMsg == false)
                    {
                        strBuilder.Append("\r\n" + "//检查缓存刷新机制");
                        strBuilder.Append("\r\n" + "string strMsg;");
                        bolIsDef_strMsg = true;
                    }
                    strBuilder.AppendFormat("\r\n" + "if (cls{0}BL.objCommFun4BL == null)", objPrjTab.TabName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"类cls{2}BL没有刷新缓存机制(cls{2}BL.objCommFun4BL == null), 请联系程序员!(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        "{", "}", objPrjTab.TabName);
                    strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                    strBuilder.Append("\r\n" + "}");
                }
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.AppendFormat("\r\n" + "//string strWhereCond = string.Format(\"1 = 1 order by {0}\");", objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "//if (arr{0}ObjLstCache == null)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//{");
            strBuilder.AppendFormat("\r\n" + "//arr{0}ObjLstCache = {0}DA.GetObjLst(strWhereCond);",
                  objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "intFldNumCache = arr{0}ObjLstCache.Count;", 
            //      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//}");
            strBuilder.Append("\r\n" + "}");

            //初始化列表缓存.======================= = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.使用顺序查询
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjByKeyCache_TryOnce()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象, 从缓存的对象列表中获取.(再试一次)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache_TryOnce({2} {3})",
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

            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}BL.arr{0}ObjLstCache", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + ".Where(x=>x.{1} == {2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count() >= 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel.First();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "intFindFailCount++;");
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return GetObjBy{1}Cache_TryOnce({2});",
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
        public string Gen_Neo4JBL_GetObjByKeyCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";

            StringBuilder strBuilder = new StringBuilder();
            //根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache({2} {3}, {4} {5})",
         objPrjTabENEx.TabName,
         objKeyField.FldName,
         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
         objKeyField.PrivFuncName,
                objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            //strBuilder.Append("\r\n" + "//初始化列表缓存");
            //strBuilder.Append("\r\n" + "InitListCache(); ");
            strBuilder.Append("\r\n" + "//获取缓存中的对象列表");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache();",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                    objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }

            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache", objPrjTabENEx.TabName);
  
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + ".Where(x=> x.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && x.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.Append("\r\n" + ");");

            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count() == 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "   cls{0}EN obj = cls{0}BL.GetObjBy{1}({2});"                ,
                        objPrjTabENEx.TabName,
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "   if (obj != null)");
            strBuilder.Append("\r\n" + " {");
            //strBuilder.AppendFormat("\r\n" + "     cls{0}BL.arr{0}ObjLstCache = null;",
            //            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "     return obj;");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel.First();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");


            //根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetAllRecObjLstCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";

            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 从缓存中获取所有对象列表.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <returns>从缓存中获取的所有对象列表</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetAll{0}ObjLstCache()",
            objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetAll{0}ObjLstCache({1} {2})",
            objPrjTabENEx.TabName,
            objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "//初始化列表缓存");
            //strBuilder.Append("\r\n" + "InitListCache(); ");
            strBuilder.Append("\r\n" + "//获取缓存中的对象列表");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache(); ",
                    objPrjTabENEx.TabName);                               
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1}); ",
                    objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
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
        public string Gen_Neo4JBL_GetObjLstCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";

            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 从缓存中获取所有对象列表.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <returns>从缓存中获取的所有对象列表</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static IEnumerable<cls{0}EN> GetObjLstCache()",
                objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static IEnumerable<cls{0}EN> GetObjLstCache({1} {2})",
                objPrjTabENEx.TabName,
                objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            //strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
            //  objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                 objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLstCache = CacheHelper.GetCache(strKey, () => {{ return GetObjLst(new cls{0}EN()); }});",
                    objPrjTabENEx.TabName);
            }
            else
            {
                if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
                {
                    strBuilder.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                           objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLstCache = CacheHelper.GetCache(strKey, () => {{ return GetObjLst(string.Format(new cls{0}EN(){{ {1}={{0}} }}, {2})); }});",
                        objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName,
                 objPrjTabENEx.objCacheClassifyFld.PrivFuncName);                   
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                         objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLstCache = CacheHelper.GetCache(strKey, () => {{ return GetObjLst(string.Format(new cls{0}EN(){{ {1}='{{0}}' }}, {2})); }});",
                        objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.FldName,
                 objPrjTabENEx.objCacheClassifyFld.PrivFuncName);

                 
                }
            }
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

            if (objKeyField.CsType == "bool") return "";
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字列表获取相关对象列表.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n string strWhereCond = string.Format(\"{0} in ({{0}})\", strSqlConditionStr);", objKeyField.FldName, "{", "}");


            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append(Gen_4BL_GC_GetObjLstFromDataTable());

            

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3}, {5} {6})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName,
                objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            //strBuilder.Append("\r\n" + "//初始化列表缓存");
            //strBuilder.Append("\r\n" + "InitListCache(); ");
            strBuilder.Append("\r\n" + "//获取缓存中的对象列表");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache();",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                    objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }

            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0].{1};",
                objPrjTabENEx.TabName, strTextFieldName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录[{3} = {{0}}](函数:{{1}})\", {4}, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public static string GetNameBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static string GetNameBy{0}Cache({1} {2}, {3} {4})",
                objKeyField.FldName,
           objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
           objKeyField.PrivFuncName,
                objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            //strBuilder.Append("\r\n" + "//初始化列表缓存");
            //strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.Append("\r\n" + "//获取缓存中的对象列表");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache(); ",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                    objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0].{1};",
                objPrjTabENEx.TabName, strTextFieldName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录的相关名称[{3} = {{0}}](函数:{{1}})\", {4}, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
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
        public string Gen_4BL_GetObjByKeyFromList()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象, 从给定的对象列表中获取.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
                    strBuilder.AppendFormat("\r\n" + "if (reader.IsStartElement(con{1}.{0}))",
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
                    strBuilder.AppendFormat("\r\n" + "if (reader.IsStartElement(con{1}.{0}))",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n" + "XmlReaderSettings xmlrs = new XmlReaderSettings()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "IgnoreComments = true,");
            strBuilder.AppendFormat("\r\n" + "IgnoreWhitespace = true");
            strBuilder.Append("\r\n" + "};");
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">需要序列化的对象列表</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"strXmlFile\">生成的XML文件</param>");
            strBuilder.AppendFormat("\r\n" + "public static void SerializeObjLstToXMLFile(List<cls{0}EN> lst{0}ObjLst, string strXmlFile)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Indent = true,");
            strBuilder.AppendFormat("\r\n" + "IndentChars = (\" \")");
            strBuilder.Append("\r\n" + "};");
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjLst\">需要序列化的对象列表</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个生成的XML串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjLstToXMLStr(List<cls{0}EN> lst{0}ObjLst)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strXmlFile = clsSysParaEN.strTempXMLFileName;");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Indent = true,");
            strBuilder.AppendFormat("\r\n" + "IndentChars = (\" \")");
            strBuilder.Append("\r\n" + "};");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SerializeObjLstToXML(lst{0}ObjLst, writer);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要序列化的对象</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个生成的XML串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToXMLStr(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strXmlFile = clsSysParaEN.strTempXMLFileName;");


            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Indent = true,");
            strBuilder.AppendFormat("\r\n" + "IndentChars = (\" \")");
            strBuilder.Append("\r\n" + "};");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要序列化的对象</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象XML串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToXMLStrByIso(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "string strXmlIsoFile = clsSysParaEN.strTempXMLIsoFileName;");

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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.Append("\r\n" + "XmlReaderSettings xmlrs = new XmlReaderSettings()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "IgnoreComments = true,");
            strBuilder.Append("\r\n" + "IgnoreWhitespace = true");
            strBuilder.Append("\r\n" + "};");
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
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "bool":
                        //sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(\"{0}\");",
                        // objField.ObjFieldTabENEx.FldName);
                        //sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} = false ? \"0\" : \"1\") + \"'\");",
                        // strPrivPropNameWithObjectName4Get);
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.Get{0}().ToString().ToLower(CultureInfo.InvariantCulture));",
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
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                      objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "byte[]":
                        //sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        //objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    default:
                        sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.Get{0}().ToString(CultureInfo.InvariantCulture));",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                }

                return sbCodeForCs.ToString();
            }
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "string":
                    sbCodeForCs.AppendFormat("\r\n" + "if (obj{1}EN.{0} != null)",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.Append("\r\n{");
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.Append("\r\n}");
                    break;
                case "bool":
                    //sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(\"{0}\");",
                    // objField.ObjFieldTabENEx.FldName);
                    //sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0} = false ? \"0\" : \"1\") + \"'\");",
                    // strPrivPropNameWithObjectName4Get);
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.{0}.ToString().ToLower(CultureInfo.InvariantCulture));",
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
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
                case "byte[]":
                    //sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    //objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + "if (obj{1}EN.{0} != null)",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.Append("\r\n{");
                    sbCodeForCs.AppendFormat("\r\n" + "writer.WriteElementString(con{1}.{0}, obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.Append("\r\n}");
                    break;
            }

            return sbCodeForCs.ToString();
        }



        public string Gen_4BL_GetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取当前表的记录数.该表与当前类不相关。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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

        public string Gen_Neo4JBL_GetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static long GetRecCountByCond(string strTabName, string strWhereCond)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n long intRecCount = cls{0}DA.GetRecCountByCond(strTabName, strWhereCond);", objPrjTabENEx.TabName);
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">所给定的表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n List<string> arrList = cls{0}DA.GetFldValue(strTabName, strFldName, strWhereCond);", objPrjTabENEx.TabName);
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strFldName, string strWhereCond)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n List<string> arrList = {0}DA.GetFldValue(strFldName, strWhereCond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetFldValueNoDistinct()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n List<string> arrList = {0}DA.GetFldValueNoDistinct(strFldName, strWhereCond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///获取表中的记录数 == = ;
            return strBuilder.ToString();
        }

        public string Gen_Neo4JBL_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}Cond\">给定条件的条件对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.AppendFormat("\r\npublic static long GetRecCountByCond(cls{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n long intRecCount = cls{0}DA.GetRecCountByCond(obj{0}Cond);", objPrjTabENEx.TabName);
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

            strBuilder.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.objLog == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"请初始化用于记录日志的clsSysParaEN.objLog对象!\");");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.objErrorLog == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!\");");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");

            strBuilder.Append("\r\n //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName == true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strBuilder.Append("\r\n //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString) == true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}EN._ConnectString);",
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, string strValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");



            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = {0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = {0}DA.SetFldValue(strFldName, strValue, strWhereCond);",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//ReFreshCache();");
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, float fltValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(cls{0}EN._CurrTabName, strFldName, fltValue, strWhereCond);",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//ReFreshCache();");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置当前表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"intValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, int intValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = {0}DA.SetFldValue( strFldName, intValue, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//ReFreshCache();");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4String_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//ReFreshCache();");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Int_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//ReFreshCache();");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_funSetFldValue4Float_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:设置给定表中的符合条件的某字段的值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>影响的记录数</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) ");
            strBuilder.Append("\r\n{");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = cls{0}DA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//ReFreshCache();");
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
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
                    strRemark = "/**" + strRemark0 + "*/";

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
                if (objField.FieldTypeId == enumFieldType.KeyField_02 &&  objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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
        public string Gen_4BL_SynchToServerByCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            bool bolIsNeedSynchCode = false;
            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == enumFieldType.SynField_08)
                    {
                        bolIsNeedSynchCode = true;
                        break;
                    }
                }
                if (bolIsNeedSynchCode == false) return "";

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 同步满足条件的记录,从Client到Server");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"strCondition\">同步的条件</param>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"strOpUserId\">操作同步的用户</param>");
                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public static int SynchToServerByCondition(string strCondition, string strOpUserId)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strOpUserId) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "throw new Exception(\"同步到服务端时,同步人不能为空!\");");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "int intCount = 0;");

                strCodeForCs.Append("\r\n" + "string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionStringClient\";");

                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ENObjLst = cls{0}BL.GetObjLst(strCondition);",
                    objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN4Web in arr{0}ENObjLst)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//如果这条记录的来源就是Server,就不需要同步了");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN4Web.SynSource == \"Server\") continue;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Web.IsSynchToServer = true;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Web.SynchToServerDate = strCurrDate14;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Web.SynchToServerUser = strOpUserId;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionString\";");

                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Web.SynSource = \"Client\";",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}_Target = cls{0}BL.GetObjBy{1}(obj{0}EN4Web.{1});",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}_Target != null)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "int intResult = (obj{0}_Target.UpdDate.CompareTo(obj{0}EN4Web.UpdDate));",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (intResult < 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UpdateBySql2(obj{0}EN4Web);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AddNewRecordBySql2(obj{0}EN4Web);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionStringClient\";");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UpdateBySql2(obj{0}EN4Web);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "StringBuilder sbMsg = new StringBuilder();");
                strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\"在同步到Server端时,字段表：{0}({1})时出错。({3}).[上级抛错:{2}]\", ");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN._CurrTabName, obj{0}EN4Web.{1}, objException.Message, clsStackTrace.GetCurrClassFunction());",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "throw new Exception(sbMsg.ToString());");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionString\";");
                strCodeForCs.Append("\r\n" + "return intCount;");
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

        public string Gen_4BL_SynchToClientByCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            bool bolIsNeedSynchCode = false;
            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == enumFieldType.SynField_08)
                    {
                        bolIsNeedSynchCode = true;
                        break;
                    }
                }
                if (bolIsNeedSynchCode == false) return "";

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 同步满足条件的记录,从Server到Client");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"strCondition\">同步的条件</param>");
                strCodeForCs.Append("\r\n" + "/// <param name=\"strOpUserId\">操作同步的用户</param>");

                strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public static int SynchToClientByCondition(string strCondition, string strOpUserId)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strOpUserId) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "throw new Exception(\"上传到Client库时,同步人不能为空!\");");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "int intCount = 0;");
                strCodeForCs.Append("\r\n" + "string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionString\";");

                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ENObjLst = cls{0}BL.GetObjLst(strCondition);",
                    objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN4Main in arr{0}ENObjLst)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//如果这条记录的来源就是Client,就不需要同步了");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN4Main.SynSource == \"Client\") continue;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Main.IsSynchToClient = true;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Main.SynchToClientDate = strCurrDate14;",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Main.SynchToClientUser = strOpUserId;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionStringClient\";");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN4Main2 = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.CopyTo(obj{0}EN4Main, obj{0}EN4Main2);",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN4Main2.SynSource = \"Server\";",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}_Target = cls{0}BL.GetObjBy{1}(obj{0}EN4Main.{1});",
                    objPrjTabENEx.TabName, objKeyField.FldName);

                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}_Target != null)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//如果目标地的对象日期小于来源对象的日期就更新");
                strCodeForCs.AppendFormat("\r\n" + "int intResult = obj{0}_Target.UpdDate.CompareTo(obj{0}EN4Main.UpdDate);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (intResult < 0)");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UpdateBySql2(obj{0}EN4Main2);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "intCount++;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.AddNewRecordBySql2(obj{0}EN4Main2);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "intCount++;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionString\";");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.UpdateBySql2(obj{0}EN4Main);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "StringBuilder sbMsg = new StringBuilder();");
                strCodeForCs.Append("\r\n" + "sbMsg.AppendFormat(\"在同步到Client库,字段表：{0}({1})时出错。({3}).[上级抛错:{2}]\", ");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN._CurrTabName, obj{0}EN4Main.{1}, objException.Message, clsStackTrace.GetCurrClassFunction());",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "throw new Exception(sbMsg.ToString());");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "clsSysParaEN.strConnectStrName = \"ConnectionString\";");
                strCodeForCs.Append("\r\n" + "return intCount;");
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

        /// <summary>
        /// 置顶函数。需要同时存在：分类字段和序号字段,才能自动生成该函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GoTop()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";
                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的名称字段为空,不能生成绑定下拉框相关函数文件;", objPrjTabENEx.TabName);
                //    return strCodeForCs.ToString();
                //}

                if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 把所给的关键字列表所对应的对象置顶。");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">所给的关键字列表</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool GoTop(List<{0}> arrKeyId)", objKeyField.CsType);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} - 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
  
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "strCondition = string.Format(\"1 = 1 order by {{0}} \", con{0}.{3}); ",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"置顶出错!错误:{{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 把所给的关键字列表所对应的对象置顶。根据分类字段：{0}单独排序",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">所给的关键字列表</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool GoTopBy{0}(List<{1}> arrKeyId, string str{0})",
                        objAdjustOrderNum.ClassificationFieldValue, objKeyField.CsType);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} - 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
              
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "strCondition = string.Format(\" {{0}} = '{{1}}' order by {{2}} \",  ",
                        objPrjTabENEx.TabName, "{", "}");
                    
                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1}, str{1},", objPrjTabENEx.TabName, objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1});", objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"置顶出错,{{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //return strCodeForCs.ToString();
        }

        /// <summary>
        /// 置顶函数。需要同时存在：分类字段和序号字段,才能自动生成该函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_TabFeature_GoTop()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
        
            try
            {
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";
                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的名称字段为空,不能生成绑定下拉框相关函数文件;", objPrjTabENEx.TabName);
                //    return strCodeForCs.ToString();
                //}

                if (objAdjustOrderNum.arrFieldLst_Classify.Count() == 0)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 把所给的关键字列表所对应的对象置顶。");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">所给的关键字列表</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool GoTop(List<{0}> arrKeyId)", objKeyField.CsType);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} - 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "strCondition = string.Format(\"1 = 1 order by {{0}} \", con{0}.{3}); ",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"置顶出错!错误:{{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();
                }
                else
                {
            

                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 把所给的关键字列表所对应的对象置顶。根据分类字段：{0}单独排序",
                        objAdjustOrderNum.FieldLst);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">所给的关键字列表</param>");
                    foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">分类字段</param>",
                            objInFor.ObjFieldTab().PrivFuncName1());
                    }
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool GoTop(List<{1}> arrKeyId, {0})",
                        string.Join(",", objAdjustOrderNum.VarDefLst), objKeyField.CsType);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} - 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "strCondition = \" 1=1 \";");

                    foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "strCondition += string.Format(\" And {{0}} = '{{1}}' \", con{0}.{1}, {2});",
                            objPrjTabENEx.TabName, objInFor.ObjFieldTab().FldName, objInFor.ObjFieldTab().PrivFuncName1());
                    }
                    strCodeForCs.AppendFormat("\r\n" + " strCondition += string.Format(\" order by {0} \");", objAdjustOrderNum.objField_OrderNum.FldName());

                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"置顶出错,{{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();
                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //return strCodeForCs.ToString();
        }


        /// <summary>
        /// 置底函数。需要同时存在：分类字段和序号字段,才能自动生成该函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GoBottom()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
       
            try
            {
                ///生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

                if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 把所给的关键字列表所对应的对象置底。");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">所给的关键字列表</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool GoBottom(List<{0}> arrKeyId)", objKeyField.CsType);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} + 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
          
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "strCondition = string.Format(\"1 = 1 order by {{0}} \", con{0}.{3}); ",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"置顶出错, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 把所给的关键字列表所对应的对象置顶。根据分类字段：{0}单独排序",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">所给的关键字列表</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool GoBottomBy{0}(List<{1}> arrKeyId, string str{0})",
                        objAdjustOrderNum.ClassificationFieldValue, objKeyField.CsType);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} + 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "strCondition = string.Format(\" {{0}} = '{{1}}' order by {{2}} \",  ",
                        objPrjTabENEx.TabName, "{", "}");

                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1}, str{1},", objPrjTabENEx.TabName, objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1});", objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"置顶出错, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //return strCodeForCs.ToString();
        }

        /// <summary>
        /// 置底函数。需要同时存在：分类字段和序号字段,才能自动生成该函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_TabFeature_GoBottom()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

                if (objAdjustOrderNum.arrFieldLst_Classify.Count() == 0)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 把所给的关键字列表所对应的对象置底。");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">所给的关键字列表</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool GoBottom(List<{0}> arrKeyId)", objKeyField.CsType);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} + 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "strCondition = string.Format(\"1 = 1 order by {{0}} \", con{0}.{3}); ",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"置顶出错, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();
                }
                else
                {
              


                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 把所给的关键字列表所对应的对象置顶。根据分类字段：{0}单独排序",
                        objAdjustOrderNum.FieldLst);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"arrKeyId\">所给的关键字列表</param>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool GoBottom(List<{1}> arrKeyId, {0})",
                        string.Join(",", objAdjustOrderNum.VarDefLst), objKeyField.CsType);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "if (arrKeyId.Count == 0) return true;");
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}} in ({{1}})\", con{0}.{3}, strKeyList);",
                        objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}Lst = GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}Lst)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = obj{0}.{1} + 10000;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "strCondition = \" 1=1 \";");

                    foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "strCondition += string.Format(\" And {{0}} = '{{1}}' \", con{0}.{1}, {2});",
                            objPrjTabENEx.TabName, objInFor.ObjFieldTab().FldName, objInFor.ObjFieldTab().PrivFuncName1());
                    }
                    strCodeForCs.AppendFormat("\r\n" + " strCondition += string.Format(\" order by {0} \");", objAdjustOrderNum.objField_OrderNum.FldName());

                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"置顶出错, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //return strCodeForCs.ToString();
        }


        /// <summary>
        /// 重序函数。需要同时存在：分类字段和序号字段,才能自动生成该函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_ReOrder()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
     
            try
            {
                ///生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";
                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的名称字段为空,不能生成绑定下拉框相关函数文件;", objPrjTabENEx.TabName);
                //    return strCodeForCs.ToString();
                //}

                if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 重新排序。");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.Append("\r\n" + "public static bool ReOrder()");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 = 1 order by {{0}} \", con{0}.{3}); ",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"重序出错, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 重新排序。根据分类字段：{0}单独排序",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"str{0}\">所给的关键字列表</param>",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool ReOrderBy{0}(string str{0})",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\" {{0}} = '{{1}}' order by {{2}} \",  ",
                        objPrjTabENEx.TabName, "{", "}");

                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1}, str{1},", objPrjTabENEx.TabName, objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n" + "con{0}.{1});", objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"置顶出错, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //return strCodeForCs.ToString();
        }

        public string Gen_4BL_TabFeature_ReOrder()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";
                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的名称字段为空,不能生成绑定下拉框相关函数文件;", objPrjTabENEx.TabName);
                //    return strCodeForCs.ToString();
                //}

                if (objAdjustOrderNum.arrFieldLst_Classify.Count() == 0)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 重新排序。");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.Append("\r\n" + "public static bool ReOrder()");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 = 1 order by {{0}} \", con{0}.{3}); ",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.objField_OrderNum.FldName());
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.objField_OrderNum.FldName());
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"重序出错, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();
                }
                else
                {
                    

                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 重新排序。根据分类字段：{0}单独排序",
                        objAdjustOrderNum.FieldLst);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");

                    foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">分类字段</param>",
                            objInFor.ObjFieldTab().PrivFuncName1());
                    }
                    strCodeForCs.Append("\r\n" + "/// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool ReOrder({0})",
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "string strCondition = \" 1=1 \";");

                    foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "strCondition += string.Format(\" And {{0}} = '{{1}}' \", con{0}.{1}, {2});", 
                            objPrjTabENEx.TabName, objInFor.ObjFieldTab().FldName, objInFor.ObjFieldTab().PrivFuncName1());
                    }
                    strCodeForCs.AppendFormat("\r\n" + " strCondition += string.Format(\" order by {0} \");", objAdjustOrderNum.objField_OrderNum.FldName());


                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjList = new cls{0}DA().GetObjLst(strCondition);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "    ");
                    strCodeForCs.Append("\r\n" + "int intIndex = 1;");
                    strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0} in arr{0}ObjList)",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = intIndex;",
                        objPrjTabENEx.TabName, objAdjustOrderNum.objField_OrderNum.FldName());
                    strCodeForCs.AppendFormat("\r\n" + "UpdateBySql2(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "intIndex++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true; ");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"重序出错, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName,
                        "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //return strCodeForCs.ToString();
        }


        public string Gen_4BL_Static_TabFeature_SetFieldValue()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            //string strFeatureId = "0170";

            try
            {
                List<clsTabFeatureEN> arrTabFeature_SetFieldValue = objPrjTabENEx.arrTabFeatureSet().Where(x => x.FeatureId == enumPrjFeature.SetFieldValue_0148).ToList();
                foreach (var objTabFeature_SetFieldValue in arrTabFeature_SetFieldValue)
                {
                    if (objTabFeature_SetFieldValue == null) return "";
                    IEnumerable<clsTabFeatureFldsEN> arrField_SetFldValue = objTabFeature_SetFieldValue.arrTabFeatureFldsSet().Where(x => x.TabFeatureId == objTabFeature_SetFieldValue.TabFeatureId);
                    foreach (clsTabFeatureFldsENEx objInfor in arrField_SetFldValue)
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.AppendFormat("\r\n" + "/// 设置字段值({0})。", objInfor.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        if (objInfor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"obj{0}EN\">当前对象</param>", objPrjTabENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"strUserId\">当前用户Id</param>", objPrjTabENEx.TabName);
                            strCodeForCs.Append("\r\n" + "/// <returns>修改结果是否成功?</returns>");
                            strCodeForCs.AppendFormat("\r\n" + "public static bool {0}(this cls{1}EN obj{1}EN, string strUserId)", objInfor.FuncName, objPrjTabENEx.TabName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "try");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (objInfor.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                            {
                                case "bool":
                                    bool bolValue = bool.Parse(objInfor.DefaultValue.ToLower());
                                    string strValue = bolValue.ToString().ToLower();
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}({2}); ",
                                        objPrjTabENEx.TabName, objInfor.FldName, strValue);
                                    break;
                                case "string":
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(\"{2}\"); ",
                                        objPrjTabENEx.TabName, objInfor.FldName, objInfor.DefaultValue);
                                    break;
                                case "int":
                                case "bigint":
                                case "short":
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}({2}); ",
                                        objPrjTabENEx.TabName, objInfor.FldName, objInfor.DefaultValue);
                                    break;
                                default:
                                    string strMsg = string.Format("数据类型:{0}在Switch没有被处理!(In {1})", objInfor.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                            clsPrjTabFldENEx objField_UpdDate = objPrjTabENEx.arrPrjTabFldENExObjLst.Find(x => x.FieldTypeId == enumFieldType.Log_UpdDate_13);
                            clsPrjTabFldENEx objField_UpdUser = objPrjTabENEx.arrPrjTabFldENExObjLst.Find(x => x.FieldTypeId == enumFieldType.Log_UpdUser_14);
                            if (objField_UpdDate != null)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(clsDateTime.getTodayDateTimeStr(0)); ",
        objPrjTabENEx.TabName, objField_UpdDate.FldName, objInfor.DefaultValue);
                            }
                            if (objField_UpdUser != null)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(strUserId); ",
        objPrjTabENEx.TabName, objField_UpdUser.FldName, objInfor.DefaultValue);
                            }

                            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN.Update();",
                                objPrjTabENEx.TabName);
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"设置字段值出错, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                                objPrjTabENEx.TabName);
                            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                        }
                        else if (objInfor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"obj{0}EN\">当前对象</param>", objPrjTabENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">{1}</param>", objInfor.ObjFieldTabENEx.PrivFuncName, objInfor.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"strUserId\">当前用户Id</param>", objPrjTabENEx.TabName);
                            strCodeForCs.Append("\r\n" + "/// <returns>修改结果是否成功?</returns>");
                            strCodeForCs.AppendFormat("\r\n" + "public static bool {0}(this cls{1}EN obj{1}EN, {2} {3}, string strUserId)",
                                objInfor.FuncName,
                                objPrjTabENEx.TabName,
                                objInfor.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objInfor.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "try");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}({2}); ",
                                objPrjTabENEx.TabName, objInfor.FldName, objInfor.ObjFieldTabENEx.PrivFuncName);

                            clsPrjTabFldENEx objField_UpdDate = objPrjTabENEx.arrPrjTabFldENExObjLst.Find(x => x.FieldTypeId == enumFieldType.Log_UpdDate_13);
                            clsPrjTabFldENEx objField_UpdUser = objPrjTabENEx.arrPrjTabFldENExObjLst.Find(x => x.FieldTypeId == enumFieldType.Log_UpdUser_14);
                            if (objField_UpdDate != null)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(clsDateTime.getTodayDateTimeStr(0)); ",
        objPrjTabENEx.TabName, objField_UpdDate.FldName, objInfor.DefaultValue);
                            }
                            if (objField_UpdUser != null)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(strUserId); ",
        objPrjTabENEx.TabName, objField_UpdUser.FldName, objInfor.DefaultValue);
                            }

                            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN.Update();",
                                objPrjTabENEx.TabName);
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"设置字段值出错, {{0}}. (from {{1}})\", objException.Message, clsStackTrace.GetCurrClassFunction());",
                                objPrjTabENEx.TabName);
                            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                        }

                    }
                }
                return strCodeForCs.ToString();
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //return strCodeForCs.ToString();
        }

        /// <summary>
        /// 重序函数。需要同时存在：分类字段和序号字段,才能自动生成该函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_AdjustOrderNum()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
   
            try
            {
                ///生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";
                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的名称字段为空,不能生成绑定下拉框相关函数文件;", objPrjTabENEx.TabName);
                //    return strCodeForCs.ToString();
                //}

                if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 调整所给关键字记录的序号。");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"strDirect\">方向：用\"Up\",\"Down\"表示</param>");
                    strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">所给的关键字</param>",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "/// <returns>是否成绩</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool AdjustOrderNum(string strDirect, {0} {1})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//操作步骤：");
                    strCodeForCs.AppendFormat("\r\n" + "//1、根据所给定的关键字[{0}],获取相应的序号[{1}]；",
                        objKeyField.FldName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "//2、如果当前序号是否是末端序号；");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "//   3.2、如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取下(上)一个序号记录的关键字{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号加(减)1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号减(加)1",
                        objKeyField.FldName);

                    strCodeForCs.Append("\r\n" + "string strMsg;");
                    strCodeForCs.Append("\r\n" + "int intOrderNum;    //当前记录的序号");
                    strCodeForCs.Append("\r\n" + "int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号");

                    string strPrevKeyFldName = string.Format("{0}Prev{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    string strNextKeyFldName = string.Format("{0}Next{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = 0;    //上一条序号的关键字{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strPrevKeyFldName,
                        objKeyField.FldName);

                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = 0;    //下一条序号的关键字{2}",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            strNextKeyFldName,
                            objKeyField.FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //上一条序号的关键字{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strPrevKeyFldName,
                        objKeyField.FldName);

                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //下一条序号的关键字{2}",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            strNextKeyFldName,
                            objKeyField.FldName);
                    }
                    strCodeForCs.Append("\r\n" + "int intTabRecNum;       //当前表中字段的记录数");
                  
                    strCodeForCs.Append("\r\n" + "StringBuilder strCondition = new StringBuilder();");
                    strCodeForCs.AppendFormat("\r\n" + "//1、根据所给定的关键字[{0}],获取相应的序号[{1}]。",
                        objKeyField.FldName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0} = cls{0}BL.GetObjBy{1}({2});", 
                        objPrjTabENEx.TabName,
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "intOrderNum = obj{0}.{1};//当前序号", 
                        objPrjTabENEx.TabName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intPrevOrderNum = intOrderNum - 1;//前一条记录的序号");
                    strCodeForCs.Append("\r\n" + "intNextOrderNum = intOrderNum + 1;//后一条记录的序号");

                    strCodeForCs.Append("\r\n" + "//3、如果当前序号是否是末端序号,");
                    strCodeForCs.Append("\r\n" + "//		3.1 如果是末端序号,就退出,");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "intTabRecNum = cls{0}BL.GetRecCountByCond(cls{0}EN._CurrTabName, \"1 = 1\");    //获取当前表的记录数", 
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "switch (strDirect)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "case \"UP\":");
                    strCodeForCs.Append("\r\n" + "case \"Up\":");
                    strCodeForCs.Append("\r\n" + "case \"up\":");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//  3.2、如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum <= 1)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"已经是第一条记录,不能再上移.(from {{0}})\", clsStackTrace.GetCurrClassFunction());", 
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "//		    如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");

                    strCodeForCs.AppendFormat("\r\n" + "strCondition.AppendFormat(\" {{0}} = {{1}}\", con{0}.{3}, intOrderNum - 1);", 
                        objPrjTabENEx.TabName, "{", "}",
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取上一个序号字段的关键字{0}",
                         objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(strCondition.ToString());", 
                        objPrjTabENEx.TabName,
                        strPrevKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strPrevKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strPrevKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"获取上一条记录的关键字出错.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号减1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号加1",
                        objKeyField.FldName);

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intPrevOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strPrevKeyFldName);

                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "case \"DOWN\":");
                    strCodeForCs.Append("\r\n" + "case \"Down\":");
                    strCodeForCs.Append("\r\n" + "case \"down\":");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"已经是最后一条记录,不能再下移.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "                            throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取下一个序号字段的关键字{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "strCondition.AppendFormat(\" {{0}} = {{1}}\", con{0}.{3}, intOrderNum + 1);",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(strCondition.ToString());",
                        objPrjTabENEx.TabName,
                        strNextKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strNextKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strNextKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"获取下一条记录的关键字出错.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号加1",
                       objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号减1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intNextOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strNextKeyFldName);
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "default:");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"方向参数出错!strDirect=[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "strDirect,");
                    strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"调整记录次序出错!错误:[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "objException.Message,");
                    strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                    return strCodeForCs.ToString();
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 调整所给关键字记录的序号。根据分类字段：{0}单独排序",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"strDirect\">方向：用\"Up\",\"Down\"表示</param>");
                    strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">所给的关键字</param>",
                         objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"str{0}\">分类字段</param>",
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "/// <returns>是否成功?</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool AdjustOrderNum(string strDirect, {0} {1}, string str{2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//操作步骤：");
                    strCodeForCs.AppendFormat("\r\n" + "//1、根据所给定的关键字[{0}],获取相应的序号[{1}]；",
                        objKeyField.FldName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "//2、如果当前序号是否是末端序号；");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "//   3.2、如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取下(上)一个序号记录的关键字{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号加(减)1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号减(加)1",
                        objKeyField.FldName);

                    strCodeForCs.Append("\r\n" + "string strMsg;");
                    strCodeForCs.Append("\r\n" + "int intOrderNum;    //当前记录的序号");
                    strCodeForCs.Append("\r\n" + "int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号");

                    string strPrevKeyFldName = string.Format("{0}Prev{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    string strNextKeyFldName = string.Format("{0}Next{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = 0;    //上一条序号的关键字{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strPrevKeyFldName,
                        objKeyField.FldName);

                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = 0;    //下一条序号的关键字{2}",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            strNextKeyFldName,
                            objKeyField.FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //上一条序号的关键字{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strPrevKeyFldName,
                        objKeyField.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //下一条序号的关键字{2}",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            strNextKeyFldName,
                            objKeyField.FldName);
                    }
                    strCodeForCs.Append("\r\n" + "int intTabRecNum;       //当前表中字段的记录数");

                    strCodeForCs.Append("\r\n" + "StringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.AppendFormat("\r\n" + "//1、根据所给定的关键字[{0}],获取相应的序号[{1}]。",
                        objKeyField.FldName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0} = cls{0}BL.GetObjBy{1}({2});",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "intOrderNum = obj{0}.{1};//当前序号",
                        objPrjTabENEx.TabName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intPrevOrderNum = intOrderNum - 1;//前一条记录的序号");
                    strCodeForCs.Append("\r\n" + "intNextOrderNum = intOrderNum + 1;//后一条记录的序号");

                    strCodeForCs.Append("\r\n" + "//3、如果当前序号是否是末端序号,");
                    strCodeForCs.Append("\r\n" + "//		3.1 如果是末端序号,就退出,");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"{{0}}='{{1}}'\", con{0}.{3}, str{3});",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n" + "intTabRecNum = cls{0}BL.GetRecCountByCond(cls{0}EN._CurrTabName, strCondition);    //获取当前表的记录数",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "switch (strDirect)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "case \"UP\":");
                    strCodeForCs.Append("\r\n" + "case \"Up\":");
                    strCodeForCs.Append("\r\n" + "case \"up\":");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//  3.2、如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum <= 1)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"已经是第一条记录,不能再上移.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "//		    如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");

                    strCodeForCs.AppendFormat("\r\n" + "sbCondition.AppendFormat(\" {{0}} = {{1}} And {{2}}='{{3}}'\", con{0}.{3}, intOrderNum - 1, con{0}.{4}, str{4});",
                        objPrjTabENEx.TabName, "{", "}",
                        objAdjustOrderNum.OrderNumFieldName, objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取上一个序号字段的关键字{0}",
                         objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(sbCondition.ToString());",
                        objPrjTabENEx.TabName,
                        strPrevKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strPrevKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strPrevKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"获取上一条记录的关键字出错.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号减1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号加1",
                        objKeyField.FldName);

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n  \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intPrevOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strPrevKeyFldName);

                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "case \"DOWN\":");
                    strCodeForCs.Append("\r\n" + "case \"Down\":");
                    strCodeForCs.Append("\r\n" + "case \"down\":");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"已经是最后一条记录,不能再下移.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "                            throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取下一个序号字段的关键字{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "sbCondition.AppendFormat(\" {{0}} = {{1}}  And {{2}}='{{3}}'\", con{0}.{3}, intOrderNum + 1, con{0}.{4}, str{4});",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName, objAdjustOrderNum.ClassificationFieldValue);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(sbCondition.ToString());",
                        objPrjTabENEx.TabName,
                        strNextKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strNextKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strNextKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"获取下一条记录的关键字出错.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号加1",
                       objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号减1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intNextOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strNextKeyFldName);
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "default:");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"方向参数出错!strDirect=[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n \t \t" + "strDirect,");
                    strCodeForCs.Append("\r\n \t \t" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"调整记录次序出错!错误:[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n \t \t" + "objException.Message,");
                    strCodeForCs.Append("\r\n \t \t" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //return strCodeForCs.ToString();
        }

        public string Gen_4BL_TabFeature_AdjustOrderNum()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
      
            try
            {
                clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);
                
                if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";
                //if (string.IsNullOrEmpty(objAdjustOrderNum.ClassificationFieldValue) == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的名称字段为空,不能生成绑定下拉框相关函数文件;", objPrjTabENEx.TabName);
                //    return strCodeForCs.ToString();
                //}

                if (objAdjustOrderNum.arrFieldLst_Classify.Count() == 0)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 调整所给关键字记录的序号。");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"strDirect\">方向：用\"Up\",\"Down\"表示</param>");
                    strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">所给的关键字</param>",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "/// <returns>是否成绩</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool AdjustOrderNum(string strDirect, {0} {1})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//操作步骤：");
                    strCodeForCs.AppendFormat("\r\n" + "//1、根据所给定的关键字[{0}],获取相应的序号[{1}]；",
                        objKeyField.FldName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "//2、如果当前序号是否是末端序号；");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "//   3.2、如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取下(上)一个序号记录的关键字{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号加(减)1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号减(加)1",
                        objKeyField.FldName);

                    strCodeForCs.Append("\r\n" + "string strMsg;");
                    strCodeForCs.Append("\r\n" + "int intOrderNum;    //当前记录的序号");
                    strCodeForCs.Append("\r\n" + "int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号");

                    string strPrevKeyFldName = string.Format("{0}Prev{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    string strNextKeyFldName = string.Format("{0}Next{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = 0;    //上一条序号的关键字{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strPrevKeyFldName,
                        objKeyField.FldName);

                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = 0;    //下一条序号的关键字{2}",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            strNextKeyFldName,
                            objKeyField.FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //上一条序号的关键字{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strPrevKeyFldName,
                        objKeyField.FldName);

                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //下一条序号的关键字{2}",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            strNextKeyFldName,
                            objKeyField.FldName);
                    }
                    strCodeForCs.Append("\r\n" + "int intTabRecNum;       //当前表中字段的记录数");

                    strCodeForCs.Append("\r\n" + "StringBuilder strCondition = new StringBuilder();");
                    strCodeForCs.AppendFormat("\r\n" + "//1、根据所给定的关键字[{0}],获取相应的序号[{1}]。",
                        objKeyField.FldName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0} = cls{0}BL.GetObjBy{1}({2});",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "intOrderNum = obj{0}.{1};//当前序号",
                        objPrjTabENEx.TabName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intPrevOrderNum = intOrderNum - 1;//前一条记录的序号");
                    strCodeForCs.Append("\r\n" + "intNextOrderNum = intOrderNum + 1;//后一条记录的序号");

                    strCodeForCs.Append("\r\n" + "//3、如果当前序号是否是末端序号,");
                    strCodeForCs.Append("\r\n" + "//		3.1 如果是末端序号,就退出,");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "intTabRecNum = cls{0}BL.GetRecCountByCond(cls{0}EN._CurrTabName, \"1 = 1\");    //获取当前表的记录数",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "switch (strDirect)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "case \"UP\":");
                    strCodeForCs.Append("\r\n" + "case \"Up\":");
                    strCodeForCs.Append("\r\n" + "case \"up\":");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//  3.2、如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum <= 1)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"已经是第一条记录,不能再上移.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "//		    如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");

                    strCodeForCs.AppendFormat("\r\n" + "strCondition.AppendFormat(\" {{0}} = {{1}}\", con{0}.{3}, intOrderNum - 1);",
                        objPrjTabENEx.TabName, "{", "}",
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取上一个序号字段的关键字{0}",
                         objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(strCondition.ToString());",
                        objPrjTabENEx.TabName,
                        strPrevKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strPrevKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strPrevKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"获取上一条记录的关键字出错.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号减1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号加1",
                        objKeyField.FldName);

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intPrevOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strPrevKeyFldName);

                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "case \"DOWN\":");
                    strCodeForCs.Append("\r\n" + "case \"Down\":");
                    strCodeForCs.Append("\r\n" + "case \"down\":");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"已经是最后一条记录,不能再下移.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "                            throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取下一个序号字段的关键字{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "strCondition.AppendFormat(\" {{0}} = {{1}}\", con{0}.{3}, intOrderNum + 1);",
                        objPrjTabENEx.TabName, "{", "}", objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(strCondition.ToString());",
                        objPrjTabENEx.TabName,
                        strNextKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strNextKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strNextKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"获取下一条记录的关键字出错.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号加1",
                       objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号减1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intNextOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strNextKeyFldName);
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "default:");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"方向参数出错!strDirect=[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "strDirect,");
                    strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"调整记录次序出错!错误:[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "objException.Message,");
                    strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                    return strCodeForCs.ToString();
                }
                else
                {
                 

                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 调整所给关键字记录的序号。根据分类字段：{0}单独排序",
                        objAdjustOrderNum.FieldLst);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name=\"strDirect\">方向：用\"Up\",\"Down\"表示</param>");
                    strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">所给的关键字</param>",
                         objKeyField.PrivFuncName);
                    foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">分类字段</param>",
                            objInFor.ObjFieldTab().PrivFuncName1());
                    }
                    strCodeForCs.Append("\r\n" + "/// <returns>是否成功?</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static bool AdjustOrderNum(string strDirect, {0} {1}, {2})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        string.Join(",", objAdjustOrderNum.VarDefLst));
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//操作步骤：");
                    strCodeForCs.AppendFormat("\r\n" + "//1、根据所给定的关键字[{0}],获取相应的序号[{1}]；",
                        objKeyField.FldName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "//2、如果当前序号是否是末端序号；");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "//   3.2、如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取下(上)一个序号记录的关键字{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号加(减)1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号减(加)1",
                        objKeyField.FldName);

                    strCodeForCs.Append("\r\n" + "string strMsg;");
                    strCodeForCs.Append("\r\n" + "int intOrderNum;    //当前记录的序号");
                    strCodeForCs.Append("\r\n" + "int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号");

                    string strPrevKeyFldName = string.Format("{0}Prev{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    string strNextKeyFldName = string.Format("{0}Next{1}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        objKeyField.FldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = 0;    //上一条序号的关键字{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strPrevKeyFldName,
                        objKeyField.FldName);

                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = 0;    //下一条序号的关键字{2}",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            strNextKeyFldName,
                            objKeyField.FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //上一条序号的关键字{2}",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        strPrevKeyFldName,
                        objKeyField.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";    //下一条序号的关键字{2}",
                            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                            strNextKeyFldName,
                            objKeyField.FldName);
                    }
                    strCodeForCs.Append("\r\n" + "int intTabRecNum;       //当前表中字段的记录数");

                    strCodeForCs.Append("\r\n" + "StringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.AppendFormat("\r\n" + "//1、根据所给定的关键字[{0}],获取相应的序号[{1}]。",
                        objKeyField.FldName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0} = cls{0}BL.GetObjBy{1}({2});",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "intOrderNum = obj{0}.{1};//当前序号",
                        objPrjTabENEx.TabName,
                        objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n" + "intPrevOrderNum = intOrderNum - 1;//前一条记录的序号");
                    strCodeForCs.Append("\r\n" + "intNextOrderNum = intOrderNum + 1;//后一条记录的序号");

                    strCodeForCs.Append("\r\n" + "//3、如果当前序号是否是末端序号,");
                    strCodeForCs.Append("\r\n" + "//		3.1 如果是末端序号,就退出,");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "string strCondition = \" 1=1 \";");

                    foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "strCondition += string.Format(\" And {{0}} = '{{1}}' \", con{0}.{1}, {2});",
                            objPrjTabENEx.TabName, objInFor.ObjFieldTab().FldName, objInFor.ObjFieldTab().PrivFuncName1());
                    }

                    strCodeForCs.AppendFormat("\r\n" + "intTabRecNum = cls{0}BL.GetRecCountByCond(cls{0}EN._CurrTabName, strCondition);    //获取当前表的记录数",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "switch (strDirect)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "case \"UP\":");
                    strCodeForCs.Append("\r\n" + "case \"Up\":");
                    strCodeForCs.Append("\r\n" + "case \"up\":");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//  3.2、如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum <= 1)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"已经是第一条记录,不能再上移.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "//		    如果是向上移动,就判断当前序号是否“大于”1,");
                    strCodeForCs.Append("\r\n" + "//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。");

                    strCodeForCs.AppendFormat("\r\n" + "sbCondition.AppendFormat(\" {{0}} = {{1}} \", con{0}.{1}, intOrderNum - 1);",
                        objPrjTabENEx.TabName, 
                        objAdjustOrderNum.OrderNumFieldName);

                    foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sbCondition.AppendFormat(\" And {{0}} = '{{1}}' \", con{0}.{1}, {2});",
                            objPrjTabENEx.TabName, objInFor.ObjFieldTab().FldName, objInFor.ObjFieldTab().PrivFuncName1());
                    }

                    strCodeForCs.AppendFormat("\r\n" + "//4、获取上一个序号字段的关键字{0}",
                         objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(sbCondition.ToString());",
                        objPrjTabENEx.TabName,
                        strPrevKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strPrevKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strPrevKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"获取上一条记录的关键字出错.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号减1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号加1",
                        objKeyField.FldName);

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n  \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intPrevOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strPrevKeyFldName);

                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "case \"DOWN\":");
                    strCodeForCs.Append("\r\n" + "case \"Down\":");
                    strCodeForCs.Append("\r\n" + "case \"down\":");
                    strCodeForCs.Append("\r\n" + "//3、如果是末端序号,就退出；");
                    strCodeForCs.Append("\r\n" + "//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,");
                    strCodeForCs.Append("\r\n" + "//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,");
                    strCodeForCs.Append("\r\n" + "if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"已经是最后一条记录,不能再下移.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "                            throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "//4、获取下一个序号字段的关键字{0}",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "sbCondition.AppendFormat(\" {{0}} = {{1}} \", con{0}.{1}, intOrderNum + 1);",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);

                    foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sbCondition.AppendFormat(\" And {{0}} = '{{1}}' \", con{0}.{1}, {2});",
                            objPrjTabENEx.TabName, objInFor.ObjFieldTab().FldName, objInFor.ObjFieldTab().PrivFuncName1());
                    }

                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.AppendFormat("\r\n" + "{1} = cls{0}BL.GetFirstID_S(sbCondition.ToString());",
                        objPrjTabENEx.TabName,
                        strNextKeyFldName);
                    if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN))
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", strNextKeyFldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)", strNextKeyFldName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"获取下一条记录的关键字出错.(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "//5、把当前关键字{0}所对应记录的序号加1",
                       objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "//6、把下(上)一个序号关键字{0}所对应的记录序号减1",
                        objKeyField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intOrderNum + 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, con{0}.{1},",
                        objPrjTabENEx.TabName, objAdjustOrderNum.OrderNumFieldName);
                    strCodeForCs.Append("\r\n \t \t" + "intNextOrderNum - 1,");
                    strCodeForCs.AppendFormat("\r\n \t \t" + "string.Format(\"{{0}} = '{{1}}'\", con{0}.{3}, {4}));",
                        objPrjTabENEx.TabName, "{", "}",
                        objKeyField.FldName,
                        strNextKeyFldName);
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "default:");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"方向参数出错!strDirect=[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n \t \t" + "strDirect,");
                    strCodeForCs.Append("\r\n \t \t" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "return true;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"调整记录次序出错!错误:[{{0}}]({{1}})\",",
                        objPrjTabENEx.TabName, "{", "}");
                    strCodeForCs.Append("\r\n \t \t" + "objException.Message,");
                    strCodeForCs.Append("\r\n \t \t" + "clsStackTrace.GetCurrClassFunction());");
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                    return strCodeForCs.ToString();

                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            //return strCodeForCs.ToString();
        }

        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}BL", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

        public string A_GeneFuncCodeByFuncName(string strFuncName)
        {
            
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBLEx.GetObjByFuncNameCache(strFuncName);
            try
            {
                string strCode = "";
                Type t = typeof(NodeBusinessLogic4CSharp);
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
                        strCode = (string)mt.Invoke(this, new object[] { objFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

    }
}
