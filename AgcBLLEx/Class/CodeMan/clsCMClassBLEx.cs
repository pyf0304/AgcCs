
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMClassBLEx
表名:CMClass(00050501)
生成代码版本:2019.10.24.1
生成日期:2019/10/27 10:44:34
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理
模块英文名:CodeMan
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;


using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;

using AgcCommBase;

namespace AGC.BusinessLogicEx
{
    public static class clsCMClassBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMClassENS">源对象</param>
        /// <returns>目标对象=>clsCMClassEN:objCMClassENT</returns>
        public static clsCMClassENEx CopyToEx(this clsCMClassEN objCMClassENS)
        {
            try
            {
                clsCMClassENEx objCMClassENT = new clsCMClassENEx();
                clsCMClassBL.CopyTo(objCMClassENS, objCMClassENT);
                return objCMClassENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objCMClassENS">源对象</param>
        /// <returns>目标对象=>clsCMClassEN:objCMClassENT</returns>
        public static clsCMClassEN CopyTo(this clsCMClassENEx objCMClassENS)
        {
            try
            {
                clsCMClassEN objCMClassENT = new clsCMClassEN();
                clsCMClassBL.CopyTo(objCMClassENS, objCMClassENT);
                return objCMClassENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// CM类(CMClass)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMClassBLEx : clsCMClassBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCMClassDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCMClassDAEx CMClassDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCMClassDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strCmClassId">表关键字</param>
        /// <returns></returns>
        public static bool DelRecordEx(string strCmClassId, string strPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsCMClassDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[CMClass]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition0 = string.Format("{0} in (select {0} From {1} Where {2}='{3}')",
                conCMFuncParaRela.CmFunctionId,
                conCMFunction._CurrTabName,
                conCMFunction.CmClassId,
                strCmClassId);
                clsCMFuncParaRelaBL.DelCMFuncParaRelasByCondWithTransaction_S(strCondition0, strPrjId, objConnection, objSqlTransaction);

                string strCondition = string.Format("{0} = '{1}'",
                conCMClass.CmClassId,
                strCmClassId);
                clsCMFunctionBL.DelCMFunctionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);

                clsCMClassBL.DelRecord(strCmClassId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsCMClassBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strCmClassId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsCMClassENEx> GetObjExLst(string strCondition)
        {
            List<clsCMClassEN> arrObjLst = clsCMClassBL.GetObjLst(strCondition);
            List<clsCMClassENEx> arrObjExLst = new List<clsCMClassENEx>();
            foreach (clsCMClassEN objInFor in arrObjLst)
            {
                clsCMClassENEx objCMClassENEx = new clsCMClassENEx();
                clsCMClassBL.CopyTo(objInFor, objCMClassENEx);
                arrObjExLst.Add(objCMClassENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strCmClassId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCMClassENEx GetObjExByCmClassId(string strCmClassId)
        {
            clsCMClassEN objCMClassEN = clsCMClassBL.GetObjByCmClassId(strCmClassId);
            clsCMClassENEx objCMClassENEx = new clsCMClassENEx();
            clsCMClassBL.CopyTo(objCMClassEN, objCMClassENEx);
            return objCMClassENEx;
        }

        public static clsCMClassEN AddCMClass(clsCMClassEN objCMClass)
        {
            clsCMClassEN objCMClass_Cond = new clsCMClassEN();
            objCMClass_Cond.SetClsName(objCMClass.ClsName, "=");
            string strCondition = objCMClass_Cond.SetProgLangTypeId(objCMClass.ProgLangTypeId, "=")
               .SetTabName(objCMClass.TabName, "=")
               .SetFileName(objCMClass.FileName, "=")
               .SetNameSpace(objCMClass.NameSpace, "=")
               .SetUserId(objCMClass.UserId, "=")
               .SetPrjId(objCMClass.PrjId, "=")
               .GetUniCondStr();
            objCMClass._IsCheckProperty = true;
            bool bolIsExist = clsCMClassBL.IsExistRecord(strCondition);

            if (bolIsExist)
            {
                objCMClass.CmClassId = clsCMClassBL.GetFirstID_S(strCondition);
                objCMClass.FileText = objCMClass.FileText.Replace(";", "；");
                objCMClass.UpdateWithCondition(strCondition);
            }
            else
            {

                objCMClass.SetCmClassId(clsCMClassBL.GetMaxStrId_S());
                objCMClass.AddNewRecord();
            }

            return objCMClass;
        }

        public static IDictionary<string, clsUserCodePathENEx> InitDict4CodeTypeId(List<string> arrCodeTypeIdLst, int intApplicationTypeId, string strPrjId, string strUserId, string strMachineName)
        {

            IDictionary<string, clsUserCodePathENEx> dicCodeTypeIdUserCodePath = new Dictionary<string, clsUserCodePathENEx>();

            foreach (string strCodeTypeId in arrCodeTypeIdLst)
            {
                clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
                //clsCodeTypeENEx objCodeTypeENEx = objCodeTypeEN.CopyToEx();

                clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
                //clsPubConst.ClsName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
                clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
                clsUserCodePathENEx objUserCodePathENEx = clsUserCodePathBLEx.GetObjExByClassName(intApplicationTypeId,
                    strCodeTypeId, strPrjId, strMachineName, clsSysParaEN.strUserId);

                //clsPubFun.AccessIsExistPath(objUserCodePathENEx);
                objUserCodePathENEx.GetObjExInfo(strUserId, strMachineName);

                dicCodeTypeIdUserCodePath.Add(strCodeTypeId, objUserCodePathENEx);
            }
            return dicCodeTypeIdUserCodePath;

        }


        public static bool ImportCode4PrjId(int intApplicationTypeId, string strPrjId, string strMachineName, string strUserId, 
            IMSProject myMSProject, IParseCsFile myParseCsFile)
        {


            clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjIdCache(strPrjId);

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);
            //intCurrIndex = 0;
            //intSuccessCount = 0;
            //intAddCount = 0;
            //intDeleteCount = 0;
            //intNotNeedGC = 0;
            //arrErrorLst = new List<string>();
            //arrAddFileName = new List<string>();
            //arrNotNeedGC = new List<string>();
            //arrDeleteFileName = new List<string>();

            //Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);

            //clsPubConst.ClsName cnClassNameSim = clsPubConst.ClsName.EntityLayer_Sim;
            string strMsg = "";
            
            clsAppCodeTypeRelaEN objCondition = new clsAppCodeTypeRelaEN();
            string strCondition = objCondition.SetApplicationTypeId(intApplicationTypeId, "=").GetCombineCondition();
            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRela = clsAppCodeTypeRelaBL.GetObjLst(strCondition);
            List<string> arrCodeTypeIdLst = arrAppCodeTypeRela.Select(x => x.CodeTypeId).ToList();
            //this.CodeTypeIdLst = arrCodeTypeId;
            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

         
            //初始化与代码类型相关的字典：代码类型<-->工程文件名；代码类型<-->用户代码路径对象
            IDictionary<string, clsUserCodePathENEx> dicCodeTypeIdUserCodePath = InitDict4CodeTypeId(arrCodeTypeIdLst, intApplicationTypeId, strPrjId, strUserId, strMachineName);

            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = arrCompileTab.Count;
            //progressBar2.Minimum = 0;
            //progressBar2.Maximum = arrCompileTab.Count;

            //timer1.Enabled = true;
            //timer1.Start();


            int intCodeTypeIdIndex = 0;
            foreach (string strCodeTypeId in arrCodeTypeIdLst)
            {
                clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
                if (objCodeTypeEN.IsAutoParseFile == false) continue;

                clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
                //clsPubConst.ClsName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
                clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

                clsUserCodePathENEx objUserCodePathEx = dicCodeTypeIdUserCodePath[strCodeTypeId];
                objUserCodePathEx.GetObjExInfo(strUserId, strMachineName);

                //clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;// @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";

                IEnumerable<string> arrCompileFileLst = myMSProject.GetCompileFileLst(objUserCodePathEx.PrjFileName);
                StringBuilder sbMsg = new StringBuilder();
                foreach(string strPrjInnerFileName in arrCompileFileLst)
                {
                    string strFullFileName = string.Format("{0}\\{1}", objUserCodePathEx.FullProjectPath, strPrjInnerFileName);
                    if (File.Exists(strFullFileName) == false)
                    {
                        continue;
                    }
                    myParseCsFile.ParseCsFile(strFullFileName, objUserCodePathEx.FullProjectPath, strPrjId, strUserId);
                    sbMsg.AppendLine(strFullFileName);
                }
                strMsg = sbMsg.ToString();
                if (objCodeTypeEN.IsExtend == true )
                {
                    //RemovePrjInnerFileForOtherPrj4CannotOverride(strCodeTypeId, objPrjTabEx.PrjInnerFileName);

                    continue;
                }

               
                intCodeTypeIdIndex++;
            }
            //intCurrIndex++;

            //bolIsFinished = true;

            return true;
        }

        public static bool ImportCode4PrjIdV2(int intApplicationTypeId, string strProjectPath, string strPrjFileName, string strPrjId, string strUserId,
          IMSProject myMSProject, IParseCsFile myParseCsFile)
        {
            clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjIdCache(strPrjId);

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);
            //intCurrIndex = 0;
            //intSuccessCount = 0;
            //intAddCount = 0;
            //intDeleteCount = 0;
            //intNotNeedGC = 0;
            //arrErrorLst = new List<string>();
            //arrAddFileName = new List<string>();
            //arrNotNeedGC = new List<string>();
            //arrDeleteFileName = new List<string>();

            //Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);

            //clsPubConst.ClsName cnClassNameSim = clsPubConst.ClsName.EntityLayer_Sim;
            string strMsg = "";
     

            //clsAppCodeTypeRelaEN objCondition = new clsAppCodeTypeRelaEN();
            //string strCondition = objCondition.SetApplicationTypeId(intApplicationTypeId, "=").GetCombineCondition();
            //List<clsAppCodeTypeRelaEN> arrAppCodeTypeRela = clsAppCodeTypeRelaBL.GetObjLst(strCondition);
            //List<string> arrCodeTypeIdLst = arrAppCodeTypeRela.Select(x => x.CodeTypeId).ToList();
            //this.CodeTypeIdLst = arrCodeTypeId;
            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

         
            //初始化与代码类型相关的字典：代码类型<-->工程文件名；代码类型<-->用户代码路径对象
            //IDictionary<string, clsUserCodePathENEx> dicCodeTypeIdUserCodePath = InitDict4CodeTypeId(arrCodeTypeIdLst, intApplicationTypeId, strPrjId);

            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = arrCompileTab.Count;
            //progressBar2.Minimum = 0;
            //progressBar2.Maximum = arrCompileTab.Count;

            //timer1.Enabled = true;
            //timer1.Start();


            int intCodeTypeIdIndex = 0;

     
            //clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;// @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";

            IEnumerable<string> arrCompileFileLst = myMSProject.GetCompileFileLst(strPrjFileName);
            StringBuilder sbMsg = new StringBuilder();
            foreach (string strPrjInnerFileName in arrCompileFileLst)
            {
                string strFullFileName = string.Format("{0}\\{1}", strProjectPath, strPrjInnerFileName);
                if (File.Exists(strFullFileName) == false)
                {
                    continue;
                }
                try
                {
                    myParseCsFile.ParseCsFile(strFullFileName, strProjectPath, strPrjId, strUserId);
                    sbMsg.AppendLine(strFullFileName);
                }
                catch(Exception objException)
                {
                    string strSS = objException.Message;
                }
            }
            strMsg = sbMsg.ToString();
            //if (objCodeTypeEN.IsExtend == true)
            //{
            //    //RemovePrjInnerFileForOtherPrj4CannotOverride(strCodeTypeId, objPrjTabEx.PrjInnerFileName);

            //    continue;
            //}


            intCodeTypeIdIndex++;
            //}
            //intCurrIndex++;

            //bolIsFinished = true;

            return true;
        }



        public static void BindDdl_CmClassIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[CM类]...", "0");
            string strCondition = string.Format("{0} ='{1}' Order By {2}", conCMClass.PrjId, strPrjId, conCMClass.ClsName);
            IEnumerable<clsCMClassEN> arrObjLst = clsCMClassBL.GetObjLst(strCondition);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conCMClass.CmClassId;
            objDDL.DataTextField = conCMClass.ClsName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_CodeTypeIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[CM类]...", "0");
            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2} ='{3}') Order By {4}",
                conCodeType.CodeTypeId, conCMClass._CurrTabName, 
                conCMClass.PrjId, strPrjId, conCodeType.CodeTypeName);
            IEnumerable<clsCodeTypeEN> arrObjLst = clsCodeTypeBL.GetObjLst(strCondition);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conCodeType.CodeTypeId;
            objDDL.DataTextField = conCodeType.CodeTypeName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_FuncModuleAgcIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[模块]...", "0");
            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2} ='{3}') Order By {4}",
                conFuncModule_Agc.FuncModuleAgcId, conCMClass._CurrTabName,
                conCMClass.PrjId, strPrjId, conFuncModule_Agc.FuncModuleName);
            IEnumerable<clsFuncModule_AgcEN> arrObjLst = clsFuncModule_AgcBL.GetObjLst(strCondition);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conFuncModule_Agc.FuncModuleAgcId;
            objDDL.DataTextField = conFuncModule_Agc.FuncModuleName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_CodeTypeIdEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[代码类型]...", "0");
            string strCondition = string.Format("{0} in (Select {0} From {1} ) Order By {2}",
                conCodeType.CodeTypeId, conCMClass._CurrTabName,
                conCodeType.CodeTypeName);
            IEnumerable<clsCodeTypeEN> arrObjLst = clsCodeTypeBL.GetObjLst(strCondition);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conCodeType.CodeTypeId;
            objDDL.DataTextField = conCodeType.CodeTypeName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_PrjIdExBak(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[工程]...", "0");
            string strCondition = string.Format("{0} in (Select {0} From {1} ) Order By {2}",
                conProjects.PrjId, conCMClass._CurrTabName,
                conProjects.PrjName);
            IEnumerable<clsProjectsEN> arrObjLst = clsProjectsBL.GetObjLst(strCondition)
                .Where(x => x.UseStateId == enumUseState.InUse_0001)
                .OrderBy(x => x.PrjName);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conProjects.PrjId;
            objDDL.DataTextField = conProjects.PrjName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_PrjIdExCache(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[工程]...", "0");
            string strCondition = string.Format("{0} in (Select {0} From {1} ) Order By {2}",
                conProjects.PrjId, conCMClass._CurrTabName,
                conProjects.PrjName);
            IEnumerable<clsCMClassEN> arrCMClassObjLstCache = clsCMClassBL.GetObjLstCache();
            IEnumerable<string> arrPrjId = arrCMClassObjLstCache.Select(x=>x.PrjId);

            IEnumerable<clsProjectsEN> arrObjLst = clsProjectsBL.GetObjLstCache()                
                .Where(x => arrPrjId.Contains(x.PrjId) && x.UseStateId == enumUseState.InUse_0001)
                .OrderBy(x => x.PrjName);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conProjects.PrjId;
            objDDL.DataTextField = conProjects.PrjName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_UserIdEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[用户]...", "0");
            string strCondition = string.Format("{0} in (Select {0} From {1} ) Order By {2}",
                conUsers.UserId, conCMClass._CurrTabName,
                conUsers.UserName);
            IEnumerable<clsUsersEN> arrObjLst = clsUsersBL.GetObjLst(strCondition);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conUsers.UserId;
            objDDL.DataTextField = conUsers.UserName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    }
}