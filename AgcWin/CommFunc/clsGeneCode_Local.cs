using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.frm;
using AGC_CSWin;
using AGC4WApi;

using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agc_CsWin
{
    /// <summary>
    /// 生成代码的参数
    /// </summary>
    public class GeneCodeParameters
    {
        public List<string> arrTabIdLst = null;
        public List<string> arrWebSrvClassIdLst = null;
        public string strCharEncodingId = "";
        public string strTypeParas = "";
        public string strTabMainTypeId = "";
        public string strViewTypeCode = "";
        public string strBuildPrj = "";
        public string strCmPrjId = "";
        public bool bolIsUpdCurr = false;
        public bool bolIsIgnoreCommTable = false;
        public clsPubConst.LangType mltLangType;

        public clsPubConst.DataBaseType mdbtDataBaseType;
        public clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = null;
        public List<CompileTab> arrCompileTab = null;
        private int mintApplicationTypeId = 0;
        public int ApplicationTypeId
        {
            get
            {
                return mintApplicationTypeId;
            }

            set
            {
                mintApplicationTypeId = value;
            }
        }
    }
    public class clsGeneCode_Local
    {
        public List<string> arrErrorLst = new List<string>();
        public List<string> arrWarnningLst = new List<string>();
        private string strVersion = "";
        public int mintErrorNum = 0;
        //public string strCodeText = "";
        //public string strTypeParas = "";
        /// <summary>
        /// 从生成函数中返回的类名
        /// </summary>
        //public string Re_ClsName { get; set; }
        /// <summary>
        /// 从生成函数中返回的文件名，带模块路径
        /// </summary>
        //public string Re_FileNameWithModuleName { get; set; }
        /// <summary>
        /// 类文件名
        /// </summary>
        public string ClassFName { get; set; }

        public string mstrLogFName = "";
        public int intCurrIndex = 0;//当前生成表的序号
        public int intSuccessCount = 0;//成功数
        public int intWarnningCount = 0;//警告数

        public List<string> arrAddFileName = null;
        public int intGc_FileCount = 0;//生成文件数
        public int intDeleteCount = 0;//成功数
        public List<string> arrDeleteFileName = null;
        public int intNotNeedGC = 0;
        public List<string> arrNotNeedGC = null;

        public bool bolIsSuccessBuild = false;
        public int intAllTabCount = 0;
        public bool bolIsFinished = false;


        public void GeneAllCheckedTableThreeLayer(object objGeneCodeParameters)
        {
            string strMachineName = Environment.MachineName;
            GeneCodeParameters myGeneCodeParameters = objGeneCodeParameters as GeneCodeParameters;
            List<string> arrTabIdLst = myGeneCodeParameters.arrTabIdLst;
            string strCharEncodingId = myGeneCodeParameters.strCharEncodingId;
            var strCmPrjId1 = myGeneCodeParameters.strCmPrjId;
            var strGCMainPathId = "";
            this.ApplicationTypeId = myGeneCodeParameters.ApplicationTypeId;
            this.ObjGCPrjRelaFile = new clsGCPrjRelaFile();
            this.ObjGCPrjRelaFile.IsCheckDate = false;
            //clsPubConst.LangType mltLangType = myGeneCodeParameters.mltLangType;
            clsPubConst.DataBaseType mdbtDataBaseType = myGeneCodeParameters.mdbtDataBaseType;
            intAllTabCount = arrTabIdLst.Count;
            clsGCVersionEN objGCVersion = clsGCVersionExWApi.GetNewestVersionObj();
            DateTime dtNewestPublishDate;
            if (objGCVersion == null) dtNewestPublishDate = clsDateTime.GetDateTimeByDateStr8(objGCVersion.PublishDate);
            else dtNewestPublishDate = new DateTime(2000, 1, 1);

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId,                clsSysParaEN.strUserId, strCharEncodingId);
            intCurrIndex = 0;
            int intFileCount = 0;
            intSuccessCount = 0;
            intGc_FileCount = 0;
            intDeleteCount = 0;
            intNotNeedGC = 0;
            arrErrorLst = new List<string>();
            arrAddFileName = new List<string>();
            arrNotNeedGC = new List<string>();
            arrDeleteFileName = new List<string>();
            var strCmPrjId = myGeneCodeParameters.strCmPrjId;

            //string strFileName = "";
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.EntityLayer;
            //clsPubConst.ClassName cnClassName_Sim = clsPubConst.ClassName.EntityLayer_Sim;
            //string strViewId = "";
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);

            StringBuilder sbLog4GeneFile = new StringBuilder();
            sbLog4GeneFile.AppendFormat("生成日期：{0}(当前工程Id:{1}, 用户：{2})\r\n",
                strCurrDate, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
            clsUserCodePrjMainPathENEx objUserCodePrjMainPathEN = null;
            try
            {
                long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(myGeneCodeParameters.strCmPrjId, myGeneCodeParameters.ApplicationTypeId,  clsPubVar.CurrSelPrjId);
                objUserCodePrjMainPathEN
                      = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                strGCMainPathId = objUserCodePrjMainPathEN.GcPathId;
                if (string.IsNullOrEmpty(strGCMainPathId) == true)
                {
                    var objCmCMProjectAppRela = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(objUserCodePrjMainPathEN.CMProjectAppRelaId, 
                        clsPubVar.CurrSelPrjId);

                    var objCMProject = clsCMProjectWApi.GetObjByCmPrjIdCache(objCmCMProjectAppRela.CmPrjId);
                    var objAppType = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(objCmCMProjectAppRela.ApplicationTypeId);
                    var strMsg = string.Format("生成主目录的GC路径为空，请检查！CM项目:{0},应用:{1},请联系管理员。",
                        objCMProject.CmPrjName, objAppType.ApplicationTypeName);
                    var strKeyId = clsGCPathExWApi.AddGCPath4Main(objUserCodePrjMainPathEN.CodePath, objUserCodePrjMainPathEN.PrjId, objUserCodePrjMainPathEN.UserId);
                    if (string.IsNullOrEmpty(strKeyId) == false)
                    {
                        var objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLstCache(objUserCodePrjMainPathEN.UserCodePrjMainPathId, strMachineName, clsPubVar.CurrSelPrjId);
                        if (objUserCodePrjMainPath_MachineName == null)
                        {
                            objUserCodePrjMainPath_MachineName = new clsUserCodePrjMainPath_MachineNameEN();
                            objUserCodePrjMainPath_MachineName
                                .SetUserCodePrjMainPathId(objUserCodePrjMainPathEN.UserCodePrjMainPathId)
                                .SetMachineName(strMachineName)
                                .SetGcPathId(strKeyId)
                                .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                                .AddNewRecord();
                        }
                        else
                        {
                            objUserCodePrjMainPath_MachineName
                                .SetGcPathId(strKeyId)
                                .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                                .Update();
                        }
                    }
                    //MessageBox.Show(strMsg);
                }

            }
            catch (Exception objException)
            {
                arrErrorLst.Add(objException.Message);
                bolIsFinished = true;
                return;
                //                throw new Exception("请设置应用类型Id!");
            }

            this.ObjUserCodePrjMainPath = objUserCodePrjMainPathEN;

            if (myGeneCodeParameters.ApplicationTypeId == 0)
            {
                arrErrorLst.Add("请设置应用类型Id!");
                bolIsFinished = true;
                return;

                //throw new Exception();
            }
            string strPrjId_CommonTable = "0170";
            List<clsvCodeType_SimEN> arrCodeTypeObjList = clsCodeTypeExWApi.GetCodeTypeObjLstByApplicationType4Back(this.ApplicationTypeId, myGeneCodeParameters.strTabMainTypeId);
            var arrUserCodePath_UserMainPath = clsUserCodePathExWApi.GetObjLstByUserCodePrjMainPathIdCache(objUserCodePrjMainPathEN.UserCodePrjMainPathId,
                            clsSysParaEN.strUserId, clsPubVar.CurrSelPrjId);
            var arrCodeTypeId_UserMainPath = arrUserCodePath_UserMainPath.Select(x => x.CodeTypeId).ToList();
            if (arrCodeTypeId_UserMainPath.Count == 0)
            {
                clsApplicationTypeEN objApplicationType = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(this.ApplicationTypeId);
                string strMsg2 = string.Format("当前工程：{0}({1})没有相应的代码类型！({1})",
                                   objApplicationType.ApplicationTypeName, objApplicationType.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
                arrErrorLst.Add(strMsg2);
                //throw new Exception(strMsg2);
            }
            this.CodeTypeIdLst = arrCodeTypeObjList.Select(x => x.CodeTypeId).ToList();
            //初始化与代码类型相关的字典：代码类型<-->工程文件名；代码类型<-->用户代码路径对象
            try
            {
                InitDict4CodeTypeId1(arrCodeTypeId_UserMainPath, strMachineName, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objExceptoin)
            {
                MessageBox.Show(objExceptoin.Message);
                arrErrorLst.Add(objExceptoin.Message);
                bolIsFinished = true;
                return;
            }
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {
                    clsvPrjTab_SimENEx objPrjTabEx = clsPrjTabExWApi.GetObjExByTabId_CacheEx(strTabId, clsPubVar.CurrSelPrjId);

                    if (myGeneCodeParameters.bolIsIgnoreCommTable == true
                        && clsPubVar.CurrSelPrjId != strPrjId_CommonTable)
                    {
                        if (clsPrjTabExWApi.IsExistTabNameInCommonTable(objPrjTabEx.TabName) == true)
                        {
                            string strMsg1 = string.Format("表名：{0}已经存在于【通用表】中，在该项目中不能生成！({1})",
                                       objPrjTabEx.TabName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg1);
                        }
                    }
                    sbLog4GeneFile.AppendFormat("针对表:{0}({1})\r\n", objPrjTabEx.TabId, objPrjTabEx.TabName);

                    //string strClsName = "";
                    //string strCodePath = "";
                    //生成新版-实体层
                    clsUserCodePathENEx objUserCodePathEx = null;
                    //string strCodeText = "";
                    //string strCodeText_Sim = "";
                    //bool bolIsFirstCodeType = true;
                    int intCodeTypeNum_GC = 0;
                    foreach (clsvCodeType_SimEN objCodeTypeEN in arrCodeTypeObjList)
                    {
                        objUserCodePathEx = clsUserCodePathExWApi.GetObjExByClassName(objUserCodePrjMainPathEN.CMProjectAppRelaId, objCodeTypeEN.CodeTypeId,
                         clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                        //strGcPathId = objUserCodePathEx.GcPathId;
                        objUserCodePathEx.GetObjExInfo11(clsSysParaEN.strUserId, strMachineName, clsPubVar.CurrSelPrjId);
                        if (objUserCodePathEx.IsGeneCode == false) continue;
                        clsPubFun.SetIsShareCodePath(objUserCodePathEx, objPrjTabEx);
                        if (myGeneCodeParameters.bolIsUpdCurr == true)
                        {
                            string strFileName_GC = string.Format(objCodeTypeEN.FileNameFormat, objPrjTabEx.TabName);
                            List<string> arrFindFileLst = clsFile.FindFileLstFromFolder(objUserCodePathEx.FullProjectPath, strFileName_GC);
                            if (arrFindFileLst.Count == 0) continue;
                        }
                        if (arrCodeTypeId_UserMainPath.Contains(objCodeTypeEN.CodeTypeId) == false) continue;
                        if (clsvFunctionTemplateRelaExWApi.GetFunctionCountByTabId(strTabId, clsPubVar.CurrSelPrjId, objCodeTypeEN.CodeTypeId) == 0)
                        {
                            continue;
                        }

                        if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeENName) == true) continue;

                        clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
                        clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);


                        clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;// @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";
                        if (string.IsNullOrEmpty(objPrjTabEx.FuncModuleAgcId) == true) continue;
                        objPrjTabEx.GetObjExInfo1(objUserCodePathEx);
                        switch (objCodeTypeEN.SqlDsTypeId)
                        {
                            case enumSQLDSTypeWA.AllTab_00:
                                break;
                            case enumSQLDSTypeWA.SqlTab_01:
                                if (objPrjTabEx.SqlDsTypeId == enumSQLDSTypeWA.SqlView_02)
                                {
                                    continue;
                                }
                                break;
                            case enumSQLDSTypeWA.SqlView_02:
                                if (objPrjTabEx.SqlDsTypeId == enumSQLDSTypeWA.SqlTab_01)
                                {
                                    continue;
                                }
                                break;
                        }

                        clsPubFun.AccessIsExistPath(objUserCodePathEx);
                        if (objCodeTypeEN.IsDefaultOverride == true)
                        {
                            Add4IncludeXmlTab_IsDefaultOverride(objPrjTabEx, strCmPrjId1, mdbtDataBaseType, strCharEncodingId, false, strMachineName);
                        }
                        else
                        {
                            Add4IncludeXmlTab_CannotOverride(objPrjTabEx, objCodeTypeEN.CodeTypeId, strCmPrjId1, mdbtDataBaseType, strCharEncodingId, false);
                        }
                        intCodeTypeNum_GC++;
                    }
                    intSuccessCount++;
                    if (intCodeTypeNum_GC > 0)
                    {
                        clsLog4GeneTabCodeExWApi.AddLog4GeneTabCode(strTabId, strGCMainPathId, ApplicationTypeId, clsSysParaEN.strUserId, strVersion);
                    }
                }
                catch (Exception objException)
                {
                    string strMsg = "";
                    clsPrjTabEN objPrjTabEN = clsPrjTabWApi.GetObjByTabId(strTabId);
                    if (objPrjTabEN == null)
                    {
                        strMsg = string.Format("错误：{0}生成表:[{4}]时.({1}->{2}->{3})",
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(3),
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction(),
                            strTabId);
                        sbLog4GeneFile.AppendFormat("{0}.\r\n", strMsg);
                    }
                    else
                    {
                        strMsg = string.Format("错误：{0}生成表:[{4}({5})]时.({1}->{2}->{3})",
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(3),
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction(),
                            objPrjTabEN.TabName, objPrjTabEN.TabId);
                        sbLog4GeneFile.AppendFormat("{0}.\r\n", strMsg);
                    }
                    //string strMsg = objException.Message;
                    arrErrorLst.Add(strMsg);
                    mintErrorNum++;
                    //lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    //ErrorInformationWApi.AddInformation("wfmPrjTab_QUDI3.aspx", "lbGeneAllCheckedTableThreeLayer0_Click", objException.Message, clsSysParaEN.strUserId);
                    //return;
                } //显示生成代码区域
                intCurrIndex++;

            }
            intGc_FileCount = intFileCount;
            sbLog4GeneFile.AppendFormat("共计生成文件数:{0}(共计表:{1}).\r\n", intFileCount, intCurrIndex);

            string strLogFName = string.Format("{0}\\{1}{2}.log",
                       objUserCodePrjMainPathEN.CodePath,
                       objUserCodePrjMainPathEN.LogPath,
                       strCurrDate);
            bolIsFinished = true;
            clsPubFun4WApi.WriteLogFile(strLogFName, sbLog4GeneFile.ToString(), myEncoding);
            mstrLogFName = strLogFName;
        }

        public void GeneAllCheckedWebSrvClassThreeLayer(object objGeneCodeParameters)
        {
            GeneCodeParameters myGeneCodeParameters = objGeneCodeParameters as GeneCodeParameters;
            List<string> arrWebSrvClassIdLst = myGeneCodeParameters.arrWebSrvClassIdLst;
            string strCharEncodingId = myGeneCodeParameters.strCharEncodingId;
            int intApplicationTypeId = myGeneCodeParameters.ApplicationTypeId;
            var strCmPrjId = myGeneCodeParameters.strCmPrjId;
            clsPubConst.LangType mltLangType = myGeneCodeParameters.mltLangType;
            clsPubConst.DataBaseType mdbtDataBaseType = myGeneCodeParameters.mdbtDataBaseType;
            intAllTabCount = arrWebSrvClassIdLst.Count;
            string strMachineName = Environment.MachineName;
            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId,                clsSysParaEN.strUserId, strCharEncodingId);
            intCurrIndex = 0;
            intSuccessCount = 0;
            arrErrorLst = new List<string>();
            //string strFileName = "";
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.EntityLayer;
            //clsPubConst.ClassName cnClassName_Sim = clsPubConst.ClassName.EntityLayer_Sim;
            //string strViewId = "";
            //string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            clsGCResult objGCResult = null;
            string strCodeTypeId = "0000";
            List<clsvCodeType_SimEN> arrCodeTypeObjList = clsCodeTypeExWApi.GetCodeTypeObjLstByApplicationType4Back(intApplicationTypeId, myGeneCodeParameters.strTabMainTypeId);
            long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

            foreach (string strWebSrvClassId in arrWebSrvClassIdLst)
            {
                try
                {
                    //string strClsName = "";
                    //string strCodePath = "";
                    //生成新版-实体层
                    clsUserCodePathENEx objUserCodePathEN = null;
                    string strCodeText = "";
                    //string strCodeText_Sim = "";
                    foreach (clsvCodeType_SimEN objCodeTypeEN in arrCodeTypeObjList)
                    {
                        if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeENName) == true) continue;
                        clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByStringBak(objCodeTypeEN.CodeTypeENName);
                        objUserCodePathEN = clsUserCodePathExWApi.GetObjExByClassName(lngCMProjectAppRelaId,
                            strCodeTypeId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                        objUserCodePathEN.GetObjExInfo11(clsSysParaEN.strUserId, strMachineName, clsPubVar.CurrSelPrjId);
                        clsPubFun.AccessIsExistPath(objUserCodePathEN);

                        try
                        {
                            //strCodeText = clsAutoGeneCodeWS.GeneCode4SelfCreateWs(cnClassName, myGeneCodeParameters.strTypeParas,
                            //    mltLangType, mdbtDataBaseType, strWebSrvClassId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                            //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                            clsGCPara objGCPara = new clsGCPara()
                            {
                                applicationTypeId = this.ApplicationTypeId,
                                codeTypeId = objCodeTypeEN.CodeTypeId,
                                dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                                tabId = "",
                                viewId = "",
                                webSrvClassId = strWebSrvClassId,
                                gcUserId = clsSysParaEN.strUserId,
                                prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                                prjId = clsPubVar.CurrSelPrjId,
                                typeParas = ""
                            };

                            objGCResult = AutoGeneCodeWApi.GeneCode4SelfCreateWs(objGCPara);

                        }
                        catch (Exception objException)
                        {
                            if (objException.Message.IndexOf("不需要生成文件。") >= 0)
                            {
                                continue;
                            }
                            clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassExWApi.GetWebSrvClassObjByWebSrvClassId_CacheEx(strWebSrvClassId, clsPubVar.CurrSelPrjId);
                            string strMsg = string.Format("错误：{0}生成表:[{4}({5})]的代码类型:[{6}]时.({1}->{2}->{3})",
                                objException.Message,
                                clsStackTrace.GetCurrClassFunctionByLevel(3),
                                clsStackTrace.GetCurrClassFunctionByLevel(2),
                                clsStackTrace.GetCurrClassFunction(),
                                objWebSrvClassEN.ClsName, objWebSrvClassEN.WebSrvClassId,
                                objCodeTypeEN.CodeTypeName);

                            //string strMsg = objException.Message;
                            arrErrorLst.Add(strMsg);
                        }
                        if (string.IsNullOrEmpty(strCodeText) == true) continue;

                        strRe_FileNameWithModuleName = InsertSuffixPath(strRe_FileNameWithModuleName, objUserCodePathEN.SuffixPath);
                        string strClassFName = string.Format("{0}\\{1}",
                            objUserCodePathEN.NewCodePath,
                            strRe_FileNameWithModuleName);
                        if (objCodeTypeEN.IsDefaultOverride == true)
                        {
                            clsPubFun4WApi.SaveClassContentToFile(strClassFName, strCodeText,
                                objUserCodePathEN.NewCodePath,
                                objUserCodePathEN.NewCodePathBackup, myEncoding);
                        }
                        else
                        {
                            try
                            {
                                var c = clsPubFun4WApi.SaveClassContentToFile_NoCover(strClassFName, strCodeText,
                                    objUserCodePathEN.NewCodePath, objCodeTypeEN, myEncoding);
                            }
                            catch (Exception objException)
                            {
                                Console.WriteLine(objException);
                            }
                        }
                    }
                    intSuccessCount++;
                }
                catch (Exception objException)
                {
                    clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassExWApi.GetWebSrvClassObjByWebSrvClassId_CacheEx(strWebSrvClassId, clsPubVar.CurrSelPrjId);
                    string strMsg = string.Format("错误：{0}生成WebSrv类:[{4}({5})]时.({1}->{2}->{3})",
                        objException.Message,
                        clsStackTrace.GetCurrClassFunctionByLevel(3),
                        clsStackTrace.GetCurrClassFunctionByLevel(2),
                        clsStackTrace.GetCurrClassFunction(),
                        objWebSrvClassEN.ClsName, objWebSrvClassEN.WebSrvClassId);

                    //string strMsg = objException.Message;
                    arrErrorLst.Add(strMsg);
                    mintErrorNum++;
                    //lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    //ErrorInformationWApi.AddInformation("wfmWebSrvClass_QUDI3.aspx", "lbGeneAllCheckedTableThreeLayer0_Click", objException.Message, clsSysParaEN.strUserId);
                    //return;
                } //显示生成代码区域
                intCurrIndex++;

            }
            bolIsFinished = true;
        }


        public string InsertSuffixPath(string strRe_FileNameWithModuleName, string strSuffixPath)
        {
            if (string.IsNullOrEmpty(strSuffixPath) == true) return strRe_FileNameWithModuleName;
            string[] strItems = strRe_FileNameWithModuleName.Split('\\');
            if (strItems.Length < 2)
            {
                string strMsg = string.Format("带模块文件信息：[{0}]经过折分，不能折成两部分，出错！({1})",
                    strRe_FileNameWithModuleName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strReturnValue = "";
            if (strSuffixPath.StartsWith("_"))
            {
                strReturnValue = string.Format("{0}{1}\\{2}", strItems[0], strSuffixPath, strItems[1]);
            }
            else
            {
                strReturnValue = string.Format("{0}\\{1}\\{2}", strItems[0], strSuffixPath, strItems[1]);
            }
            return strReturnValue;
        }

        public void GeneBusinessLogic4Mvc(object objGeneCodeParameters)
        {
            GeneCodeParameters myGeneCodeParameters = objGeneCodeParameters as GeneCodeParameters;
            List<string> arrTabIdLst = myGeneCodeParameters.arrTabIdLst;
            string strCharEncodingId = myGeneCodeParameters.strCharEncodingId;
            int intApplicationTypeId = myGeneCodeParameters.ApplicationTypeId;
            var strCmPrjId = myGeneCodeParameters.strCmPrjId;
            clsPubConst.LangType mltLangType = myGeneCodeParameters.mltLangType;
            clsPubConst.DataBaseType mdbtDataBaseType = myGeneCodeParameters.mdbtDataBaseType;
            intAllTabCount = arrTabIdLst.Count;
            string strMachineName = Environment.MachineName;
            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            intCurrIndex = 0;
            intSuccessCount = 0;
            arrErrorLst = new List<string>();
            //string strCodeText = "";
            string strCodeTypeId = "0000";
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.BusinessLogic4Mvc;
            string strViewId = "";
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            //string strClassFName = "";
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {
                    clsUserCodePathENEx objUserCodePathEN = clsUserCodePathExWApi.GetObjExByClassName(this.ObjUserCodePrjMainPath.CMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                    objUserCodePathEN.GetObjExInfo11(clsSysParaEN.strUserId, strMachineName, clsPubVar.CurrSelPrjId);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);

                    //strCodeText = clsAutoGeneCodeWS.GeneCode(objCodeTypeEN.CodeTypeENName, myGeneCodeParameters.strTypeParas,
                    //    mltLangType, mdbtDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = intApplicationTypeId,
                        codeTypeId = strCodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = strTabId,
                        viewId = strViewId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        typeParas = ""
                    };

                    clsGCResult objGCResult = AutoGeneCodeWApi.GeneCode(objGCPara);
                    strVersion = objGCResult.version;
                    if (string.IsNullOrEmpty(objGCResult.codeText) == true)
                    {
                        continue;
                    }
                    this.ClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        objGCResult.re_FileNameWithModuleName);
                    clsPubFun4WApi.SaveClassContentToFile(this.ClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath,
                        objUserCodePathEN.NewCodePathBackup, myEncoding);
                    intSuccessCount++;
                }
                catch (Exception objException)
                {
                    if (objException.Message.IndexOf("不需要生成文件。") >= 0)
                    {
                        continue;
                    }
                    string strMsg = "";
                    clsPrjTabEN objPrjTabEN = clsPrjTabWApi.GetObjByTabId(strTabId);
                    if (objPrjTabEN == null)
                    {

                        strMsg = string.Format("错误：{0}生成表:[{4}]时.({1}->{2}->{3})",
                           objException.Message,
                           clsStackTrace.GetCurrClassFunctionByLevel(3),
                           clsStackTrace.GetCurrClassFunctionByLevel(2),
                           clsStackTrace.GetCurrClassFunction(),
                           strTabId);
                    }
                    else
                    {
                        strMsg = string.Format("错误：{0}生成表:[{4}({5})]时.({1}->{2}->{3})",
                           objException.Message,
                           clsStackTrace.GetCurrClassFunctionByLevel(3),
                           clsStackTrace.GetCurrClassFunctionByLevel(2),
                           clsStackTrace.GetCurrClassFunction(),
                           objPrjTabEN.TabName, objPrjTabEN.TabId);
                    }
                }
                intCurrIndex++;
            }
            bolIsFinished = true;
        }

        #region 用于生成IncludeXmlFile中的表信息
        public void GC_IncludeTab(object objGeneCodeParameters)
        {
            GeneCodeParameters myGeneCodeParameters = objGeneCodeParameters as GeneCodeParameters;
            var strCmPrjId = myGeneCodeParameters.strCmPrjId;
            string strCharEncodingId = myGeneCodeParameters.strCharEncodingId;
            this.ApplicationTypeId = myGeneCodeParameters.ApplicationTypeId;
            clsPubConst.LangType mltLangType = myGeneCodeParameters.mltLangType;
            clsPubConst.DataBaseType mdbtDataBaseType = myGeneCodeParameters.mdbtDataBaseType;
            string strMachineName = Environment.MachineName;
            List<CompileTab> arrCompileTab = myGeneCodeParameters.arrCompileTab;
            this.ObjUserCodePrjMainPath = myGeneCodeParameters.objUserCodePrjMainPathEN;
            string strBuildPrj = myGeneCodeParameters.strBuildPrj;
            intAllTabCount = arrCompileTab.Count;
            clsGCVersionEN objGCVersion = clsGCVersionExWApi.GetNewestVersionObj();
            DateTime dtNewestPublishDate;
            if (objGCVersion != null) dtNewestPublishDate = clsDateTime.GetDateTimeByDateStr8(objGCVersion.PublishDate);
            else dtNewestPublishDate = new DateTime(2000, 1, 1);

            clsProjectsEN objProjects = clsProjectsWApi.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId);
            List<clsvPrjTab_SimENEx> arrPrjTabObjLst = clsvPrjTab_SimExWApi.GetObjExLstByPrjIdEx(clsPubVar.CurrSelPrjId);
            this.ObjGCPrjRelaFile = new clsGCPrjRelaFile();
            this.ObjGCPrjRelaFile.NewestPublishDate = dtNewestPublishDate;
            this.ObjGCPrjRelaFile.IsCheckDate = true;
            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);
            intCurrIndex = 0;
            intSuccessCount = 0;
            intGc_FileCount = 0;
            intDeleteCount = 0;
            intNotNeedGC = 0;
            arrErrorLst = new List<string>();
            arrAddFileName = new List<string>();
            arrNotNeedGC = new List<string>();
            arrDeleteFileName = new List<string>();

            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.EntityLayer;
            //clsPubConst.ClassName cnClassName_Sim = clsPubConst.ClassName.EntityLayer_Sim;
            string strMsg = "";
            //string strViewId = "";
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            //string strClassFName = "";


            clsAppCodeTypeRelaEN objCondition = new clsAppCodeTypeRelaEN();
            string strCondition = objCondition.SetApplicationTypeId(this.ApplicationTypeId, "=").GetCombineCondition();
            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRela = clsAppCodeTypeRelaWApi.GetObjLst(strCondition);
            this.CodeTypeIdLst = arrAppCodeTypeRela.Select(x => x.CodeTypeId).ToList();
            //this.CodeTypeIdLst = arrCodeTypeId;
            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            //int intCount = 0;
            //string strCodeText = "";
            //初始化与代码类型相关的字典：代码类型<-->工程文件名；代码类型<-->用户代码路径对象
            InitDict4CodeTypeId1(this.CodeTypeIdLst, strMachineName, clsPubVar.CurrSelPrjId);

            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = arrCompileTab.Count;
            //progressBar2.Minimum = 0;
            //progressBar2.Maximum = arrCompileTab.Count;

            //timer1.Enabled = true;
            //timer1.Start();

            foreach (var item in arrCompileTab)
            {
                clsvPrjTab_SimENEx objPrjTabEx = arrPrjTabObjLst.Find(x => x.TabName.Equals(item.TabName, StringComparison.InvariantCultureIgnoreCase));
                if (item.Operate == "Add")
                {
                    if (objPrjTabEx == null || objPrjTabEx.TabStateId != enumTabStateWA.Normal_01)
                    {
                        strMsg = string.Format("表名:{0}在工程:[{1}({2})]中不存在！", item.TabName, objProjects.PrjName, objProjects.PrjId);
                        throw new Exception(strMsg);
                    }
                }
                if (objPrjTabEx == null && item.Operate == "Add") continue;
                int intCodeTypeIdIndex = 0;
                foreach (string strCodeTypeId in this.CodeTypeIdLst)
                {
                    clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(strCodeTypeId);
                    if (item.Operate == "Add" && objPrjTabEx.TabTypeId == enumTabTypeWA.PureClass_0008 && objCodeTypeEN.DependsOn == "Table") continue;

                    clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
                    //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
                    clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

                    clsUserCodePathENEx objUserCodePathEx = this.DicCodeTypeIdUserCodePath[strCodeTypeId];
                    objUserCodePathEx.GetObjExInfo11(clsSysParaEN.strUserId, strMachineName, clsPubVar.CurrSelPrjId);

                    clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;// @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";
                    if (objPrjTabEx != null)
                    {
                        objPrjTabEx.GetObjExInfo1(objUserCodePathEx);
                    }

                    if (objCodeTypeEN.IsExtend == true && item.IncludeExpand == false)
                    {
                        RemovePrjInnerFileForOtherPrj4CannotOverride(strCodeTypeId, objPrjTabEx.PrjInnerFileName);

                        continue;
                    }

                    switch (item.Operate)
                    {
                        case "Delete":
                            //删除在IncludeXml文件中所包含的表
                            if (objPrjTabEx == null)
                            {
                                Delete4IncludeXmlTabOnlyByTabName(objPrjTabEx);
                            }
                            else
                            {
                                Delete4IncludeXmlTab(objPrjTabEx);
                            }
                            break;
                        case "Add":
                            try
                            {
                                //如果文件是可以覆盖的
                                if (objCodeTypeEN.IsDefaultOverride == true)
                                {
                                    Add4IncludeXmlTab_IsDefaultOverride(objPrjTabEx, strCmPrjId, mdbtDataBaseType, strCharEncodingId, false, strMachineName);
                                }
                                else
                                {
                                    //如果文件是不可以覆盖的，例如扩展类等
                                    Add4IncludeXmlTab_CannotOverride(objPrjTabEx, objCodeTypeEN.CodeTypeId, strCmPrjId, mdbtDataBaseType, strCharEncodingId, false);

                                }
                            }
                            catch (Exception objException)
                            {
                                strMsg = string.Format("在生成表：{0},代码类型：{1}时出错。{2}", item.TabName, objCodeTypeEN.CodeTypeName, objException.Message);

                                arrErrorLst.Add(strMsg);
                                mintErrorNum++;
                            }

                            break;
                        default:

                            strMsg = string.Format("操作:[{0}]在函数中没有被处理。(In {1})", item.Operate, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);

                    }
                    intCodeTypeIdIndex++;
                }
                intCurrIndex++;
            }

            foreach (var item in this.DicCodeTypeIdUserCodePath)
            {
                string strPrjFileName = item.Value.PrjFileName;
                string strPrjFileName_Sim = clsString.GetSimpleFName_S(strPrjFileName);
                if (strPrjFileName_Sim.Contains(strBuildPrj))
                {
                    clsMSProject.ProjectPath = strPrjFileName;
                    this.bolIsSuccessBuild = clsMSProject.Build();
                    break;
                }
            }
            bolIsFinished = true;
        }

        /// <summary>
        /// 删除工程文件，从文件系统中物理删除
        /// </summary>
        /// <param name="strClassFName">工程文件</param>
        /// <param name="strFolderName_Root">工程根路径，需要删除文件的根路径存在</param>
        /// <param name="strBackupFolderName">备份路径名</param>
        /// <returns></returns>
        public static bool DeleteClassFile(string strClassFName, string strFolderName_Root, string strBackupFolderName)
        {
            strClassFName = strClassFName.Replace("/", "\\");

            if (clsSysParaEN_Local.IsBackupForGeneCode == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    if (string.IsNullOrEmpty(strBackupFolderName) == false)
                    {
                        clsFile.FileBackup(strFindFileFullFile, strBackupFolderName);
                        File.Delete(strFindFileFullFile);
                        return true;
                    }
                    strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);
                }
            }
            return false;
        }


        /// <summary>
        /// 把工程文件移除出工程，同时删除相应的物理文件 
        /// </summary>
        /// <param name="strProjectPath">工程文件完全路径</param>
        /// <param name="strFileNameWithModuleName">带模块名的文件名</param>
        /// <param name="objvUserCodePathEN"></param>
        /// <returns></returns>
        public bool RemoveAndDeleteClassFile1(string strProjectPath, string strFileNameWithModuleName, clsUserCodePathENEx objUserCodePathEx)
        {
            string strRealyCodePath = objUserCodePathEx.PrjInnerCodePath;
            string strFileName_InPrj = string.Format("{0}\\{1}", strRealyCodePath, strFileNameWithModuleName);

            strFileName_InPrj = strFileName_InPrj.Replace("\\/\\", "\\").Replace("\\\\", "\\").Replace("\\\\", "\\")
       .Replace("/", "\\");
            if (strFileName_InPrj.Substring(0, 2) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(2);
            }
            if (strFileName_InPrj.Substring(0, 1) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(1);
            }

            string strSimFileName = clsString.GetSimpleFName_S(strFileName_InPrj);
            clsMSProject.ProjectPath = strProjectPath;
            string strEvaluatedInclude = clsMSProject.RemoveCompileFileByFileName(strSimFileName);
            string strPrjPathDir = clsString.ParentDir_S(strProjectPath);
            if (string.IsNullOrEmpty(strEvaluatedInclude) == false)
            {
                string strFullFileName = string.Format("{0}\\{1}",
                    strPrjPathDir, strEvaluatedInclude);
                strFullFileName = strFullFileName.Replace("\\/\\", "\\")
                    .Replace("/", "\\").Replace("\\\\", "\\").Replace("\\\\", "\\");
                if (File.Exists(strFullFileName))
                {
                    File.Delete(strFullFileName);
                    string strMsg = string.Format("文件已经被删除。文件：{0}", strFullFileName);
                    arrDeleteFileName.Add(strMsg);
                    intDeleteCount++;
                }
            }
            else
            {
                string strFindFileFullFile = clsFile.FindFileFromFolder(strPrjPathDir, strSimFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    File.Delete(strFindFileFullFile);
                    strFindFileFullFile = clsFile.FindFileFromFolder(strPrjPathDir, strSimFileName);
                }
            }
            //else
            //{
            //    string strMsg = string.Format("准备删除的文件不存在。文件：{0}", strFullFileName);
            //    arrDeleteFileName.Add(strMsg);
            //    intDeleteCount++;
            //}
            return true;
        }

        public bool RemoveAndDeleteClassFileBySimFileName(string strProjectPath, string strSimFileName, clsUserCodePathENEx objUserCodePathEx)
        {
            string strRealyCodePath = objUserCodePathEx.PrjInnerCodePath;

            clsMSProject.ProjectPath = strProjectPath;
            string strEvaluatedInclude = clsMSProject.RemoveCompileFileByFileName(strSimFileName);
            string strPrjPathDir = clsString.ParentDir_S(strProjectPath);
            if (string.IsNullOrEmpty(strEvaluatedInclude) == false)
            {
                string strFullFileName = string.Format("{0}\\{1}",
                    strPrjPathDir, strEvaluatedInclude);
                strFullFileName = strFullFileName.Replace("\\/\\", "\\")
                    .Replace("/", "\\").Replace("\\\\", "\\").Replace("\\\\", "\\");
                if (File.Exists(strFullFileName))
                {
                    File.Delete(strFullFileName);
                    string strMsg = string.Format("文件已经被删除。文件：{0}", strFullFileName);
                    arrDeleteFileName.Add(strMsg);
                    intDeleteCount++;
                }
            }
            else
            {
                string strFindFileFullFile = clsFile.FindFileFromFolder(strPrjPathDir, strSimFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    File.Delete(strFindFileFullFile);
                    strFindFileFullFile = clsFile.FindFileFromFolder(strPrjPathDir, strSimFileName);
                }
            }
            //else
            //{
            //    string strMsg = string.Format("准备删除的文件不存在。文件：{0}", strFullFileName);
            //    arrDeleteFileName.Add(strMsg);
            //    intDeleteCount++;
            //}
            return true;
        }


        /// <summary>
        /// 从工程中移除并且删除类文件，针对不能覆盖的类文件
        /// </summary>
        /// <param name="strProjectPath"></param>
        /// <param name="strFileNameWithModuleName"></param>
        /// <param name="objUserCodePathEN"></param>
        /// <returns></returns>
        public bool RemoveAndDeleteClassFile4CannotOverride(string strProjectPath, string strFileNameWithModuleName, clsUserCodePathENEx objUserCodePathEN)
        {
            if (string.IsNullOrEmpty(strProjectPath)) return true;
            if (objUserCodePathEN.PrjFileStateId != enumPrjFileStateWA.ProjectCanOpen_04) return true;

            string strRealyCodePath = objUserCodePathEN.PrjInnerCodePath;
            string strFileName_InPrj = string.Format("{0}\\{1}", strRealyCodePath, strFileNameWithModuleName);

            strFileName_InPrj = strFileName_InPrj.Replace("\\/\\", "\\").Replace("\\\\", "\\").Replace("\\\\", "\\")
       .Replace("/", "\\");
            if (strFileName_InPrj.Substring(0, 2) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(2);
            }
            if (strFileName_InPrj.Substring(0, 1) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(1);
            }

            string strSimFileName = clsString.GetSimpleFName_S(strFileName_InPrj);
            clsMSProject.ProjectPath = strProjectPath;
            string strEvaluatedInclude = clsMSProject.RemoveCompileFileByFileName(strSimFileName);
            string strPrjPathDir = clsString.ParentDir_S(strProjectPath);
            if (string.IsNullOrEmpty(strEvaluatedInclude) == false)
            {
                string strFullFileName = string.Format("{0}\\{1}",
                    strPrjPathDir, strEvaluatedInclude);
                strFullFileName = strFullFileName.Replace("\\/\\", "\\")
                    .Replace("/", "\\").Replace("\\\\", "\\").Replace("\\\\", "\\");

                if (File.Exists(strFullFileName))
                {
                    if (clsFile.IsUpdated(strFullFileName) == false)
                    {
                        File.Delete(strFullFileName);
                        string strMsg = string.Format("文件已经被删除。文件：{0}", strFullFileName);
                        arrDeleteFileName.Add(strMsg);
                        intDeleteCount++;
                    }
                }
            }
            else
            {
                string strFindFileFullFile = clsFile.FindFileFromFolder(strPrjPathDir, strSimFileName);
                if (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    if (clsFile.IsUpdated(strFindFileFullFile) == false)
                    {
                        File.Delete(strFindFileFullFile);
                    }
                    //strFindFileFullFile = clsFile.FindFileFromFolder(strPrjPathDir, strSimFileName);
                }
            }
            //else
            //{
            //    string strMsg = string.Format("准备删除的文件不存在。文件：{0}", strFullFileName);
            //    arrDeleteFileName.Add(strMsg);
            //    intDeleteCount++;
            //}
            return true;
        }


        /// <summary>
        /// 把工程文件移除出工程
        /// </summary>
        /// <param name="strProjectPath">工程文件完全路径</param>
        /// <param name="strFileNameWithModuleName">带模块名的文件名</param>
        /// <param name="objvUserCodePathEN"></param>
        /// <returns></returns>
        public bool RemoveClassFile(string strProjectPath, string strFileNameWithModuleName, clsUserCodePathENEx objUserCodePathEx)
        {
            string strRealyCodePath = objUserCodePathEx.PrjInnerCodePath;
            string strFileName_InPrj = string.Format("{0}/{1}", strRealyCodePath, strFileNameWithModuleName);

            strFileName_InPrj = strFileName_InPrj.Replace("\\/\\", "\\")
       .Replace("/", "\\");
            if (strFileName_InPrj.Substring(0, 2) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(2);
            }
            if (strFileName_InPrj.Substring(0, 1) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(1);
            }

            string strSimFileName = clsString.GetSimpleFName_S(strFileName_InPrj);
            clsMSProject.ProjectPath = strProjectPath;
            if (clsMSProject.IsExistFileName(strSimFileName))
            {
                clsMSProject.RemoveCompileFileByFileName(strSimFileName);

                string strMsg = string.Format("文件:{0}已经被移除出工程:{1}", strSimFileName, strProjectPath);
                arrDeleteFileName.Add(strMsg);
                intDeleteCount++;
            }
            return true;
        }


        public bool RemoveClassFileBySimFileName(string strProjectPath, string strSimFileName, clsUserCodePathENEx objUserCodePathEN)
        {
            string strRealyCodePath = objUserCodePathEN.PrjInnerCodePath;

            clsMSProject.ProjectPath = strProjectPath;
            if (clsMSProject.IsExistFileName(strSimFileName))
            {
                clsMSProject.RemoveCompileFileByFileName(strSimFileName);

                string strMsg = string.Format("文件:{0}已经被移除出工程:{1}", strSimFileName, strProjectPath);
                arrDeleteFileName.Add(strMsg);
                intDeleteCount++;
            }
            return true;
        }

        /// <summary>
        /// 获取在工程中的文件名
        /// </summary>
        /// <param name="strCodePath">在工程中的代码路径</param>
        /// <param name="strFuncModuleEnName">模块名</param>
        /// <param name="strFileName">文件名</param>
        /// <returns></returns>
        public string GetFileNameInPrj(string strCodePath, string strFuncModuleEnName, string strFileName)
        {
            string strFileName_InPrj = string.Format("{0}/{1}/{2}", strCodePath, strFuncModuleEnName, strFileName);
            strFileName_InPrj = strFileName_InPrj.Replace("\\/\\", "\\")
                .Replace("/", "\\");
            if (strFileName_InPrj.Substring(0, 2) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(2);
            }
            if (strFileName_InPrj.Substring(0, 1) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(1);
            }
            return strFileName_InPrj;
        }

        /// <summary>
        /// 在文件列表中，找出没有修改过的文件
        /// </summary>
        /// <param name="arrFindFileLst">文件列表</param>
        /// <returns>返回没有修改过的文件名，如果没有，就返回空串</returns>
        public string GetFileName4NoUpdated(List<string> arrFindFileLst)
        {
            foreach (string strFindFile in arrFindFileLst)
            {
                if (clsFile.IsUpdated(strFindFile) == true) continue;
                return strFindFile;
            }
            return "";
        }
        /// <summary>
        /// 当前处理的工程文件名
        /// </summary>
        //public string PrjFileName { get; set; }
        //public clsFuncModule_AgcEN ObjFuncModule { get; set; }
        /// <summary>
        /// 删除并移除工程内部文件
        /// </summary>
        /// <param name="strCodeTypeId">当前代码类型</param>
        /// <param name="strPrjInnerFile">工程内部文件(带模块名)</param>
        /// <returns></returns>
        public bool RemovePrjInnerFileForOtherPrj4CannotOverride(string strCodeTypeId, string strPrjInnerFile)
        {
            foreach (string strCodeTypeId2 in this.CodeTypeIdLst)
            {
                if (strCodeTypeId2 == strCodeTypeId) continue;
                string strPrjFileName2 = this.DicCodeTypeIdUserCodePath[strCodeTypeId2].PrjFileName;
                if (strPrjFileName2.Equals(this.DicCodeTypeIdUserCodePath[strCodeTypeId].PrjFileName, StringComparison.InvariantCultureIgnoreCase)) continue;

                clsUserCodePathENEx objUserCodePathEN2 = this.DicCodeTypeIdUserCodePath[strCodeTypeId2];
                RemoveAndDeleteClassFile4CannotOverride(strPrjFileName2, strPrjInnerFile, objUserCodePathEN2);
            }
            return true;
        }

        /// <summary>
        /// 删除并移除工程内部文件
        /// </summary>
        /// <param name="strCodeTypeId">当前代码类型</param>
        /// <param name="strPrjInnerFile">工程内部文件(带模块名)</param>
        /// <returns></returns>
        public bool RemoveDeletePrjInnerFileOfOtherPrj(string strCodeTypeId, string strPrjInnerFile)
        {
            foreach (string strCodeTypeId2 in this.CodeTypeIdLst)
            {
                if (strCodeTypeId2 == strCodeTypeId) continue;
                string strPrjFileName2 = this.DicCodeTypeIdUserCodePath[strCodeTypeId2].PrjFileName;
                if (strPrjFileName2.Equals(this.DicCodeTypeIdUserCodePath[strCodeTypeId].PrjFileName, StringComparison.InvariantCultureIgnoreCase)) continue;

                clsUserCodePathENEx objUserCodePathEN2 = this.DicCodeTypeIdUserCodePath[strCodeTypeId2];
                clsvCodeType_SimEN objCodeType = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(strCodeTypeId);
                if (objCodeType.IsDefaultOverride == true)
                {
                    RemoveAndDeleteClassFile1(strPrjFileName2, strPrjInnerFile, objUserCodePathEN2);
                }
                else
                {
                    RemoveClassFile(strPrjFileName2, strPrjInnerFile, objUserCodePathEN2);
                }
            }
            return true;
        }

        public bool RemoveDeletePrjInnerFileOfOtherPrjBySimFileName(string strCodeTypeId, string strFileName)
        {
            foreach (string strCodeTypeId2 in this.CodeTypeIdLst)
            {
                if (strCodeTypeId2 == strCodeTypeId) continue;
                string strPrjFileName2 = this.DicCodeTypeIdUserCodePath[strCodeTypeId2].PrjFileName;
                if (strPrjFileName2.Equals(this.DicCodeTypeIdUserCodePath[strCodeTypeId].PrjFileName, StringComparison.InvariantCultureIgnoreCase)) continue;

                clsUserCodePathENEx objUserCodePathEN2 = this.DicCodeTypeIdUserCodePath[strCodeTypeId2];
                clsvCodeType_SimEN objCodeType = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(strCodeTypeId);
                if (objCodeType.IsDefaultOverride == true)
                {
                    RemoveAndDeleteClassFileBySimFileName(strPrjFileName2, strFileName, objUserCodePathEN2);
                }
                else
                {
                    RemoveClassFileBySimFileName(strPrjFileName2, strFileName, objUserCodePathEN2);
                }
            }
            return true;
        }


        /// <summary>
        /// 删除并移除工程内部文件,该类文件可以覆盖
        /// </summary>
        /// <param name="strCodeTypeId">当前代码类型</param>
        /// <param name="strFileName">纯粹的文件名</param>
        /// <returns></returns>
        public bool RemoveDeletePrjInnerFileOfOtherPrj4Override(string strCodeTypeId, clsvPrjTab_SimENEx objPrjTabEx, string strMachineName, string strCmPrjId)
        {
            foreach (string strCodeTypeId2 in this.CodeTypeIdLst)
            {
                if (strCodeTypeId2 == strCodeTypeId) continue;
                if (this.DicCodeTypeIdUserCodePath.ContainsKey(strCodeTypeId2) == false) continue;
                string strPrjFileName2 = this.DicCodeTypeIdUserCodePath[strCodeTypeId2].PrjFileName;

                if (strPrjFileName2.Equals(this.DicCodeTypeIdUserCodePath[strCodeTypeId].PrjFileName, StringComparison.InvariantCultureIgnoreCase)) continue;

                clsUserCodePathENEx objUserCodePathEN2 = this.DicCodeTypeIdUserCodePath[strCodeTypeId2];
                if (objUserCodePathEN2.PrjFileStateId == enumPrjFileStateWA.ProjectCanOpen_04)
                {
                    string strFileNameWithModuleName = string.Format("{0}\\{1}", objPrjTabEx.ObjFuncModule.FuncModuleEnName, objPrjTabEx.FileName);
                    strFileNameWithModuleName = strFileNameWithModuleName.Replace("\\/\\", "\\")
                        .Replace("/", "\\").Replace("\\\\", "\\");

                    RemoveAndDeleteClassFile1(strPrjFileName2, strFileNameWithModuleName, objUserCodePathEN2);
                    string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
                    string strFullProjectPath_Other = objUserCodePathEN2.GetFullProjectPath1(this.ObjUserCodePrjMainPath, strMachineName, strPrjId);
                    string strFindFileFullFile_Other = clsFile.FindFileFromFolder(strFullProjectPath_Other, objPrjTabEx.FileName);
                    if (string.IsNullOrEmpty(strFindFileFullFile_Other) == false)
                    {
                        if (File.Exists(strFindFileFullFile_Other) == true)
                        {
                            File.Delete(strFindFileFullFile_Other);
                        }
                    }
                }
            }
            return true;
        }
        public List<string> CodeTypeIdLst { get; set; }

        public IDictionary<string, clsUserCodePathENEx> DicCodeTypeIdUserCodePath { get; set; }
        /// <summary>
        /// 当前处理的文件名
        /// </summary>
        //public string FileName { get; set; }
        public clsUserCodePrjMainPathEN ObjUserCodePrjMainPath { get; set; }

        public bool InitDict4CodeTypeId1(List<string> arrCodeTypeId_UserMainPath, string strMachineName, string strPrjId)
        {

            IDictionary<string, clsUserCodePathENEx> dicCodeTypeIdUserCodePath = new Dictionary<string, clsUserCodePathENEx>();

            foreach (string strCodeTypeId in this.CodeTypeIdLst)
            {
                if (arrCodeTypeId_UserMainPath.Contains(strCodeTypeId) == false) continue;
                clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(strCodeTypeId);
                //clsCodeTypeENEx objCodeTypeENEx = objCodeTypeEN.CopyToEx();

                clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
                //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
                clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
                clsUserCodePathENEx objUserCodePathENEx = clsUserCodePathExWApi.GetObjExByClassName(this.ObjUserCodePrjMainPath.CMProjectAppRelaId,
                    strCodeTypeId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                if (objUserCodePathENEx.IsGeneCode == false) continue;
                clsPubFun.AccessIsExistPath(objUserCodePathENEx);
                objUserCodePathENEx.GetObjExInfo11(clsSysParaEN.strUserId, strMachineName, strPrjId);

                dicCodeTypeIdUserCodePath.Add(strCodeTypeId, objUserCodePathENEx);
            }
            this.DicCodeTypeIdUserCodePath = dicCodeTypeIdUserCodePath;
            return true;
        }
        public int ApplicationTypeId { get; set; }
        public clsGCPrjRelaFile ObjGCPrjRelaFile { get; set; }
        /// <summary>
        /// 删除在IncludeXml文件中所包含的表，带删除标志
        /// </summary>
        /// <returns></returns>
        public bool Delete4IncludeXmlTab(clsvPrjTab_SimENEx objPrjTabEx)
        {
            string strMsg = "";

            clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(objPrjTabEx.CodeTypeId);
            clsUserCodePathENEx objUserCodePathEx = this.DicCodeTypeIdUserCodePath[objPrjTabEx.CodeTypeId];
            clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;
            if (clsMSProject.RemoveCompileFile(objPrjTabEx.PrjInnerFileName) == false)
            {
                string strEvaluatedInclude = clsMSProject.RemoveCompileFileByFileName(objPrjTabEx.FileName);
                if (string.IsNullOrEmpty(strEvaluatedInclude) == true)
                {
                    //strMsg = string.Format("在工程:[{0}]中，文件:[{1}]不存在！",
                    //    strPrjFileName, strFileName);
                    //clsPubVar.objLog.WriteDebugLog(strMsg);
                    //arrDeleteFileName.Add(strMsg);
                    if (objCodeTypeEN.IsDefaultOverride == true)
                    {
                        if (DeleteClassFile(objPrjTabEx.PrjInnerFileName, objUserCodePathEx.FullProjectPath,
                                   objUserCodePathEx.FullCodeBackupPath) == true)
                        {
                            intDeleteCount++;
                        }
                    }
                }
                else
                {
                    strMsg = string.Format("在工程:[{0}]中，删除了文件:[{1}],EvaluatedInclude:[{2}].(应该:[{3}])(In {4})",
                        objUserCodePathEx.PrjFileName, objPrjTabEx.FileName, strEvaluatedInclude, objPrjTabEx.PrjInnerFileName, clsStackTrace.GetCurrClassFunction());
                    clsPubVar.objLog.WriteDebugLog(strMsg);
                    strMsg = string.Format("在工程:[{0}]中，删除了文件:[{1}],EvaluatedInclude:[{2}].(应该:[{3}])",
                 objUserCodePathEx.PrjFileName, objPrjTabEx.FileName, strEvaluatedInclude, objPrjTabEx.PrjInnerFileName, clsStackTrace.GetCurrClassFunction());
                    arrDeleteFileName.Add(strMsg);
                    if (objCodeTypeEN.IsDefaultOverride == true)
                    {
                        if (DeleteClassFile(strEvaluatedInclude, objUserCodePathEx.FullProjectPath,
                                       objUserCodePathEx.FullCodeBackupPath) == true)
                        {

                        }
                    }
                    intDeleteCount++;
                }
            }
            else
            {
                if (objCodeTypeEN.IsDefaultOverride == true)
                {
                    if (DeleteClassFile(objPrjTabEx.PrjInnerFileName, objUserCodePathEx.FullProjectPath,
                            objUserCodePathEx.FullCodeBackupPath) == true)
                    {
                        intDeleteCount++;
                    }

                }
            }
            //IEnumerable<string> arr = clsMSProject.getCompileFileLst();
            RemoveDeletePrjInnerFileOfOtherPrj(objPrjTabEx.CodeTypeId, objPrjTabEx.PrjInnerFileName);

            return true;
        }


        public bool Delete4IncludeXmlTabOnlyByTabName(clsvPrjTab_SimENEx objPrjTabEx)
        {
            string strMsg = "";
            clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(objPrjTabEx.CodeTypeId);
            clsUserCodePathENEx objUserCodePathEx = this.DicCodeTypeIdUserCodePath[objPrjTabEx.CodeTypeId];
            clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;
            string strEvaluatedInclude = clsMSProject.RemoveCompileFileByFileName(objPrjTabEx.FileName);

            if (string.IsNullOrEmpty(strEvaluatedInclude) == true)
            {
                //strMsg = string.Format("在工程:[{0}]中，文件:[{1}]不存在！",
                //    strPrjFileName, strFileName);
                //clsPubVar.objLog.WriteDebugLog(strMsg);
                //arrDeleteFileName.Add(strMsg);
                if (objCodeTypeEN.IsDefaultOverride == true)
                {
                    if (clsMSProject.DeleteClassFileBySimpleFileName(objPrjTabEx.FileName, objUserCodePathEx.FullProjectPath) == true)
                    {
                        intDeleteCount++;
                    }
                }
            }
            else
            {
                strMsg = string.Format("在工程:[{0}]中，删除了文件:[{1}],EvaluatedInclude:[{2}].(应该:[{3}])(In {4})",
                    objUserCodePathEx.PrjFileName, objPrjTabEx.FileName, strEvaluatedInclude, objPrjTabEx.PrjInnerFileName, clsStackTrace.GetCurrClassFunction());
                clsPubVar.objLog.WriteDebugLog(strMsg);
                strMsg = string.Format("在工程:[{0}]中，删除了文件:[{1}],EvaluatedInclude:[{2}].(应该:[{3}])",
             objUserCodePathEx.PrjFileName, objPrjTabEx.FileName, strEvaluatedInclude, objPrjTabEx.PrjInnerFileName, clsStackTrace.GetCurrClassFunction());
                arrDeleteFileName.Add(strMsg);
                if (objCodeTypeEN.IsDefaultOverride == true)
                {
                    if (clsMSProject.DeleteClassFileBySimpleFileName(objPrjTabEx.FileName, objUserCodePathEx.FullProjectPath) == true)
                    {

                    }
                }
                intDeleteCount++;
            }


            //IEnumerable<string> arr = clsMSProject.getCompileFileLst();
            RemoveDeletePrjInnerFileOfOtherPrjBySimFileName(objPrjTabEx.CodeTypeId, objPrjTabEx.FileName);

            return true;
        }

        public bool Add4IncludeXmlTab_CannotOverride(clsvPrjTab_SimENEx objPrjTabEx, string strCodeTypeId, string strCmPrjId,
            clsPubConst.DataBaseType mdbtDataBaseType,
            string strCharEncodingId, bool bolIsRecordLog)
        {
            //string strRe_FileNameWithModuleName = "";
            //string strRe_ClsName = "";
            string strClassFName = "";
            string strMsg = "";
            string strViewId = "";
            clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(strCodeTypeId);
            clsUserCodePathENEx objUserCodePathEx = this.DicCodeTypeIdUserCodePath[strCodeTypeId];
            clsPubFun.SetIsShareCodePath(objUserCodePathEx, objPrjTabEx);


            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            if (objUserCodePathEx.PrjFileStateId == enumPrjFileStateWA.ProjectCanOpen_04)
            {
                clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;
                List<string> arrFindFileLst = clsFile.FindFileLstFromFolder(objUserCodePathEx.FullProjectPath, objPrjTabEx.FileName);
                if (arrFindFileLst.Count > 1)
                {
                    string strEvaluatedInclude = clsMSProject.GetEvaluatedIncludeByFileName(objPrjTabEx.FileName);
                    string strFileName_NoUpdated = GetFileName4NoUpdated(arrFindFileLst);
                    //如果项目不存在当前文件
                    if (objUserCodePathEx.PrjFileStateId == enumPrjFileStateWA.ProjectCanOpen_04
                        && string.IsNullOrEmpty(strEvaluatedInclude) == true)
                    {
                        if (string.IsNullOrEmpty(strFileName_NoUpdated) == false) File.Delete(strFileName_NoUpdated);
                        foreach (string strFindFile in arrFindFileLst)
                        {
                            if (strFindFile == strFileName_NoUpdated) continue;
                            if (strFindFile.EndsWith(objPrjTabEx.PrjInnerFileName, StringComparison.InvariantCultureIgnoreCase))
                            {
                                if (objUserCodePathEx.PrjFileStateId == enumPrjFileStateWA.ProjectCanOpen_04) clsMSProject.AddCompileFile(objPrjTabEx.PrjInnerFileName);
                            }
                            else
                            {
                                string strFolder = clsString.ParentDir_S(objPrjTabEx.FullFileName);
                                if (System.IO.Directory.Exists(strFolder) == false)
                                {
                                    Directory.CreateDirectory(strFolder);
                                }

                                File.Move(strFindFile, objPrjTabEx.FullFileName);
                                if (objUserCodePathEx.PrjFileStateId == enumPrjFileStateWA.ProjectCanOpen_04) clsMSProject.AddCompileFile(objPrjTabEx.PrjInnerFileName);
                            }
                        }
                        intNotNeedGC++;
                        strMsg = string.Format("不需要生成,已添加到工程中。文件名:{0}", objPrjTabEx.FileName);
                        arrNotNeedGC.Add(strMsg);
                    }
                    else //如果项目中存在当前文件
                    {
                        //如果目前工程中文件是未修改文件，就从项目中移除该文件，并且删除文件，再把另一个文件移到正确的位置，添加到工程中
                        if (strFileName_NoUpdated.EndsWith(objPrjTabEx.PrjInnerFileName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            //从项目中移除该文件，并且删除未修改文件
                            if (objUserCodePathEx.PrjFileStateId == enumPrjFileStateWA.ProjectCanOpen_04) clsMSProject.RemoveCompileFile(objPrjTabEx.PrjInnerFileName);
                            File.Delete(strFileName_NoUpdated);
                            //把另一个文件移到正确的位置，添加到工程中
                            foreach (string strFindFile in arrFindFileLst)
                            {
                                if (strFindFile == strFileName_NoUpdated) continue;

                                string strFolder = clsString.ParentDir_S(objPrjTabEx.FullFileName);
                                if (System.IO.Directory.Exists(strFolder) == false)
                                {
                                    Directory.CreateDirectory(strFolder);
                                }
                                File.Move(strFindFile, objPrjTabEx.FullFileName);
                                if (objUserCodePathEx.PrjFileStateId == enumPrjFileStateWA.ProjectCanOpen_04) clsMSProject.AddCompileFile(objPrjTabEx.PrjInnerFileName);
                            }
                        }
                        else
                        {
                            //就直接删除未修改文件
                            if (string.IsNullOrEmpty(strFileName_NoUpdated) == false) File.Delete(strFileName_NoUpdated);

                        }
                        intNotNeedGC++;
                        strMsg = string.Format("不需要生成,已添加到工程中。文件名:{0}", objPrjTabEx.FileName);
                        arrNotNeedGC.Add(strMsg);
                    }
                    RemovePrjInnerFileForOtherPrj4CannotOverride(strCodeTypeId, objPrjTabEx.PrjInnerFileName);
                    return true;
                }
                else if (arrFindFileLst.Count == 1)
                {
                    string strEvaluatedInclude = clsMSProject.GetEvaluatedIncludeByFileName(objPrjTabEx.FileName);
                    string strFileName_In = arrFindFileLst[0];
                    if (string.IsNullOrEmpty(strEvaluatedInclude) == true)
                    {
                        if (strFileName_In.EndsWith(objPrjTabEx.PrjInnerFileName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            clsMSProject.AddCompileFile(objPrjTabEx.PrjInnerFileName);
                        }
                        else
                        {
                            string strFolder = clsString.ParentDir_S(objPrjTabEx.FullFileName);
                            if (System.IO.Directory.Exists(strFolder) == false)
                            {
                                Directory.CreateDirectory(strFolder);
                            }

                            File.Move(strFileName_In, objPrjTabEx.FullFileName);
                            clsMSProject.AddCompileFile(objPrjTabEx.PrjInnerFileName);
                        }
                    }
                    else
                    {
                        if (strEvaluatedInclude.Equals(objPrjTabEx.PrjInnerFileName) == false)
                        {
                            string strFolder = clsString.ParentDir_S(objPrjTabEx.FullFileName);
                            if (System.IO.Directory.Exists(strFolder) == false)
                            {
                                Directory.CreateDirectory(strFolder);
                            }

                            clsMSProject.RemoveCompileFile(strEvaluatedInclude);
                            File.Move(strFileName_In, objPrjTabEx.FullFileName);
                            clsMSProject.AddCompileFile(objPrjTabEx.PrjInnerFileName);
                        }
                    }
                    RemovePrjInnerFileForOtherPrj4CannotOverride(strCodeTypeId, objPrjTabEx.PrjInnerFileName);
                    intNotNeedGC++;
                    strMsg = string.Format("不需要生成,已在工程中。文件名:{0}", objPrjTabEx.FileName);
                    arrNotNeedGC.Add(strMsg);
                    return true;
                }
            }
            if (clsvFunctionTemplateRelaExWApi.GetFunctionCountByTabId(objPrjTabEx.TabId, clsPubVar.CurrSelPrjId, strCodeTypeId) == 0)
            {
                return true;
            }

            //strCodeText = clsAutoGeneCodeWS.GeneCode(objCodeTypeEN.CodeTypeENName, "",
            //    ltLangType, mdbtDataBaseType, objPrjTabEx.TabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
            //   this.ApplicationTypeId, clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
            clsGCPara objGCPara = new clsGCPara()
            {
                applicationTypeId = this.ApplicationTypeId,
                codeTypeId = objCodeTypeEN.CodeTypeId,
                dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                tabId = objPrjTabEx.TabId,
                viewId = strViewId,
                gcUserId = clsSysParaEN.strUserId,
                prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                prjId = clsPubVar.CurrSelPrjId,
                cmPrjId = strCmPrjId,
                typeParas = "",
                isRecordLog = bolIsRecordLog
            };

            clsGCResult objGCResult = AutoGeneCodeWApi.GeneCode(objGCPara);
            strVersion = objGCResult.version;
            if (objGCResult.errorId > 0)
            {
                strMsg = $"在生成表:[{objPrjTabEx.TabName}]的[{objCodeTypeEN.CodeTypeENName}]类时, {objGCResult.errorMsg}({clsStackTrace.GetCurrClassFunction()})";
                arrErrorLst.Add(strMsg);
                mintErrorNum++;
                return true;
            }
            if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
            {
                strMsg = $"在生成表:[{objPrjTabEx.TabName}]的[{objCodeTypeEN.CodeTypeENName}]类时， 带模块名的文件名为空，请检查！({clsStackTrace.GetCurrClassFunction()})";
                arrErrorLst.Add(strMsg);
                mintErrorNum++;
                return true;
            }
            if (objGCResult.codeText.Contains("没有可以生成的函数"))
            {
                strMsg = string.Format("在生成表：{0},代码类型：{1}时,没有可以生成的函数.({2})",
                    objPrjTabEx.TabName, objCodeTypeEN.CodeTypeENName, clsStackTrace.GetCurrClassFunction());
                arrErrorLst.Add(strMsg);
                intWarnningCount++;
                return true;
            }
            objGCResult.re_FileNameWithModuleName = InsertSuffixPath(objGCResult.re_FileNameWithModuleName, objPrjTabEx.SuffixPath);

            strClassFName = string.Format("{0}\\{1}",
                objUserCodePathEx.FullCodePath,
                objGCResult.re_FileNameWithModuleName);

            try
            {
                var c = clsPubFun4WApi.SaveClassContentToFile_NoCover(strClassFName, objGCResult.codeText,
                       objUserCodePathEx.FullCodePath, objCodeTypeEN, myEncoding);
                if (c.Item1 == false)
                {
                    strMsg = string.Format("警告:保存不可覆盖的文件时, {1}. \r\n文件名:{0}. ", strClassFName, c.Item2);
                    intWarnningCount++;
                    arrWarnningLst.Add(strMsg);
                }
            }
            catch (Exception objException)
            {
                strMsg = string.Format("保存不可覆盖的文件时出错。\r\n文件名:{0}, \r\n错误:{1}. (In {2})", strClassFName, objException.Message, clsStackTrace.GetCurrClassFunction());
                mintErrorNum++;
                arrErrorLst.Add(strMsg);
            }
            if (objUserCodePathEx.PrjFileStateId == enumPrjFileStateWA.ProjectCanOpen_04)
            {
                clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;
                try
                {
                    clsMSProject.AddCompileFile(objPrjTabEx.PrjInnerFileName);
                }
                catch (Exception objException)
                {
                    strMsg = string.Format("在添加编译文件时出错。{0}. 编译文件:{1}. (In {2})",
                        objException.Message, objPrjTabEx.PrjInnerFileName, clsStackTrace.GetCurrClassFunction());
                    mintErrorNum++;
                    arrErrorLst.Add(strMsg);
                    //throw new Exception(strMsg);
                }
            }
            strMsg = string.Format("生成:{0}", objPrjTabEx.FileName);
            arrAddFileName.Add(strMsg);

            //intCount++;
            intGc_FileCount++;
            return true;
        }
        public bool Add4IncludeXmlTab_IsDefaultOverride(clsvPrjTab_SimENEx objPrjTabEx, string strCmPrjId,
            clsPubConst.DataBaseType mdbtDataBaseType,
            string strCharEncodingId, bool bolIsRecordLog, string strMachineName)
        {
            //string strRe_FileNameWithModuleName = "";
            //string strRe_ClsName = "";
            string strClassFName = "";
            string strMsg = "";
            string strViewId = "";
            string strPrjId = clsCMProjectExWApi.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(objPrjTabEx.CodeTypeId);
            clsUserCodePathENEx objUserCodePathEx = this.DicCodeTypeIdUserCodePath[objPrjTabEx.CodeTypeId];
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);

            List<string> arrFindFileLst = clsFile.FindFileLstFromFolder(objUserCodePathEx.FullProjectPath, objPrjTabEx.FileName);
            arrFindFileLst.ForEach(x =>
            {
                if (x.Equals(objPrjTabEx.FullFileName, StringComparison.InvariantCultureIgnoreCase) == false)
                {
                    string strFileName_InPrj_Temp = x.ToLower()
                            .Replace(objUserCodePathEx.FullProjectPath.ToLower(), "");
                    strFileName_InPrj_Temp = strFileName_InPrj_Temp.TrimStart("\\".ToCharArray());
                    if (objUserCodePathEx.PrjFileStateId == enumPrjFileStateWA.ProjectCanOpen_04)
                    {
                        bool bolResult = clsMSProject.RemoveCompileFile(strFileName_InPrj_Temp);
                    }
                    File.Delete(x);
                }
            });
            bool bolIsNeedGC = true;
            //如果文件已经存在
            if (File.Exists(objPrjTabEx.FullFileName) == true)
            {
                //如果文件生成时间大于表修改时间，就不需要再生成了
                FileInfo objFileInfo = new FileInfo(objPrjTabEx.FullFileName);
                DateTime objTabUpdateTime = clsDateTime.GetDateTimeByDateStr14(objPrjTabEx.UpdDate);
                if (this.ObjGCPrjRelaFile.IsCheckDate)
                {
                    if (objFileInfo.LastWriteTime > this.ObjGCPrjRelaFile.NewestPublishDate)
                    {
                        bolIsNeedGC = false;

                    }

                    if (objFileInfo.LastWriteTime > objTabUpdateTime &&
                        objFileInfo.LastWriteTime > this.ObjGCPrjRelaFile.NewestPublishDate)
                    {
                        bolIsNeedGC = false;

                    }

                }


            }
            if (bolIsNeedGC)
            {
                if (clsvFunctionTemplateRelaExWApi.GetFunctionCountByTabId(objPrjTabEx.TabId, strPrjId, objPrjTabEx.CodeTypeId) == 0)
                {
                    return true;
                }

                //strCodeText = clsAutoGeneCodeWS.GeneCode(objCodeTypeEN.CodeTypeENName, "",
                //    ltLangType, mdbtDataBaseType, objPrjTabEx.TabId, strViewId, 
                //    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                //   this.ApplicationTypeId, clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                //GeneralPlatform4WApi.
                //             strCodeText = clsAutoGeneCodeWA.GeneCode(objCodeTypeEN.CodeTypeENName, "",
                // ltLangType, mdbtDataBaseType, objPrjTabEx.TabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                //this.ApplicationTypeId, clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                clsGCPara objGCPara = new clsGCPara()
                {
                    applicationTypeId = this.ApplicationTypeId,
                    codeTypeId = objCodeTypeEN.CodeTypeId,
                    dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                    tabId = objPrjTabEx.TabId,
                    viewId = strViewId,
                    gcUserId = clsSysParaEN.strUserId,
                    prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                    prjId = clsPubVar.CurrSelPrjId,
                    cmPrjId = strCmPrjId,
                    typeParas = "",
                    isRecordLog = bolIsRecordLog
                };

                clsGCResult objGCResult = AutoGeneCodeWApi.GeneCode(objGCPara);
                strVersion = objGCResult.version;
                if (objGCResult.errorId > 0)
                {
                    strMsg = $"在生成表:[{objPrjTabEx.TabName}]的[{objCodeTypeEN.CodeTypeENName}]类时, {objGCResult.errorMsg}({clsStackTrace.GetCurrClassFunction()})";
                    arrErrorLst.Add(strMsg);
                    mintErrorNum++;
                    return true;
                }

                if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                {
                    strMsg = $"在生成表:[{objPrjTabEx.TabName}]的[{objCodeTypeEN.CodeTypeENName}]类时， 带模块名的文件名为空，请检查！({clsStackTrace.GetCurrClassFunction()})";
                    arrErrorLst.Add(strMsg);
                    mintErrorNum++;
                    return true;
                }
                objGCResult.re_FileNameWithModuleName = InsertSuffixPath(objGCResult.re_FileNameWithModuleName, objPrjTabEx.SuffixPath);

                strClassFName = string.Format("{0}\\{1}",
                    objUserCodePathEx.FullCodePath,
                    objGCResult.re_FileNameWithModuleName);
                //保存文件
                try
                {
                    clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                        objUserCodePathEx.FullCodePath,
                        objUserCodePathEx.FullCodeBackupPath, myEncoding);
                    strMsg = string.Format("生成并覆盖:{0}", objPrjTabEx.FileName);
                    arrAddFileName.Add(strMsg);
                }
                catch (Exception objException)
                {
                    strMsg = string.Format("在保存代码文件时出错。{0}. strClassFName:{1}, NewCodePath:{2}. (In {3})",
                        objException.Message, strClassFName, objUserCodePathEx.FullCodePath, clsStackTrace.GetCurrClassFunction());
                    //throw new Exception(strMsg);
                    mintErrorNum++;
                    arrErrorLst.Add(strMsg);
                }
                //把文件添加到工程中，可以编译                      

            }
            else
            {
                intNotNeedGC++;
                strMsg = string.Format("不需要生成:{0}", objPrjTabEx.FileName);
                arrNotNeedGC.Add(strMsg);
            }
            if (objUserCodePathEx.PrjFileStateId == enumPrjFileStateWA.ProjectCanOpen_04)
            {
                clsMSProject.ProjectPath = objUserCodePathEx.PrjFileName;
                try
                {

                    if (clsMSProject.AddCompileFile(objPrjTabEx.PrjInnerFileName) == false)
                    {
                        strMsg = string.Format("添加工程文件不成功！文件:{0}，工程文件：{1}",
                            objPrjTabEx.PrjInnerFileName, objUserCodePathEx.PrjFileName);
                        arrErrorLst.Add(strMsg);
                        mintErrorNum++;
                        return true;
                    }

                }
                catch (Exception objException)
                {
                    strMsg = string.Format("在添加编译文件时出错。{0}. 编译文件:{1}. (In {2})",
                        objException.Message, objPrjTabEx.PrjInnerFileName, clsStackTrace.GetCurrClassFunction());
                    mintErrorNum++;
                    arrErrorLst.Add(strMsg);
                    //throw new Exception(strMsg);
                }

                //删除同组其他项目中相同的类文件
                RemoveDeletePrjInnerFileOfOtherPrj4Override(objPrjTabEx.CodeTypeId, objPrjTabEx, strMachineName, strCmPrjId);
            }
            //intCount++;
            intGc_FileCount++;

            return true;
        }
        #endregion



    }

}
