using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC_CSWin;
using AGC4WS;
using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.file;
using CommonTable.Entity;
using LightningDevelopment;

namespace Agc_CsWin.frm.Test
{
    public partial class frmTestGCByIncludeTab : Form
    {
        public frmTestGCByIncludeTab()
        {
            InitializeComponent();
        }
        private clsPubConst.DataBaseType mdbtDataBaseType = clsPubConst.DataBaseType.MsSql;//数据库类型

        private void frmTestGCByIncludeTab_Load(object sender, EventArgs e)
        {
            string strPrjId = "0116";
            clsPubVar.CurrPrjDataBaseId = "0111";
            //string strPrjId = "0007";
            //clsPubVar.CurrPrjDataBaseId = "0007";

            clsPubVar.CurrSelPrjId = strPrjId;
            clsSysParaEN.strUserId = "pyf";
         
            clsCharEncodingBL.BindCbo_CharEncodingId(cboCharEncodingId);

            string strCharEncodingId = clsPubFun.GetCharEncodingIdByLangTypeId(enumProgLangType.CSharp_01);
            cboCharEncodingId.SelectedValue = strCharEncodingId;

        }

        private void btnGCPubApp_Click(object sender, EventArgs e)
        {
            int intAppTypeId = (int)enumApplicationType.PubApp4WinWeb_7;
            int intApplicationTypeId = intAppTypeId;// getAppTypeId();
            try
            {
                GeneCodeByIncludeXml(intApplicationTypeId);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void GeneCodeByIncludeXml(int intApplicationTypeId)
        {
            string strMsg = "";


            clsAppCodeTypeRelaEN objCondition = new clsAppCodeTypeRelaEN();
            string strCondition = objCondition.SetApplicationTypeId(intApplicationTypeId, "=").GetCombineCondition();
            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRela = clsAppCodeTypeRelaBL.GetObjLst(strCondition);
            IEnumerable<string> arrCodeTypeId = arrAppCodeTypeRela.Select(x => x.CodeTypeId);
  

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            string strCodeText = "";
            lblMsg.Text = "";

            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);

            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WA_Access;
            string strViewId = "";
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            string strClassFName = "";
            string strBuildPrj = "";
            IDictionary<string, string> arrCodeTypePrjFileName = new Dictionary<string, string>();
            IDictionary<int, List<CompileTab>> arrAppIdCompileTabLst = new Dictionary<int, List<CompileTab>>();
            List<CompileTab> arrCompileTab = null;
            foreach (string strCodeTypeId in arrCodeTypeId)
            {
                clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId_Cache(strCodeTypeId);
                clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeId_Cache(objCodeTypeEN.ProgLangTypeId);
                //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
                clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
                clsvUserCodePathEN objvUserCodePathEN = clsvUserCodePathBLEx.GetObjByClassName(intApplicationTypeId, strCodeTypeId, ltLangType, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
                clsUserCodePrjMainPathEN objUserCodePrjMainPathEN
                    = clsUserCodePrjMainPathBLEx.GetObjByUserCodePrjMainPathId_Cache(objvUserCodePathEN.UserCodePrjMainPathId);
               
                clsPubFun.AccessIsExistPath(objvUserCodePathEN);
                string strPrjFileName = string.Format("{0}/{1}/{2}",
                    objUserCodePrjMainPathEN.CodePath, objvUserCodePathEN.ProjectPath, objvUserCodePathEN.ProjectFileName);
                strPrjFileName = strPrjFileName.Replace("\\/\\", "\\")
                    .Replace("/", "\\");
                arrCodeTypePrjFileName.Add(strCodeTypeId, strPrjFileName);
            }
            bool bolIsGetBuildPrj = false;
            foreach (string strCodeTypeId in arrCodeTypeId)
            {
                clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId_Cache(strCodeTypeId);
                clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeId_Cache(objCodeTypeEN.ProgLangTypeId);
                //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
                clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
                clsvUserCodePathEN objvUserCodePathEN = clsvUserCodePathBLEx.GetObjByClassName(intApplicationTypeId, strCodeTypeId, ltLangType, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
                clsUserCodePrjMainPathEN objUserCodePrjMainPathEN
                    = clsUserCodePrjMainPathBLEx.GetObjByUserCodePrjMainPathId_Cache(objvUserCodePathEN.UserCodePrjMainPathId);

                clsPubFun.AccessIsExistPath(objvUserCodePathEN);
                clsIncludeFile.XmlPath = objUserCodePrjMainPathEN.IncludeXmlPath;//  @"E:\ASPNETJX\SamplePrj2017\SamplePrjWin\IncludeFile.xml";
                if (bolIsGetBuildPrj == false)
                {
                    strBuildPrj = clsIncludeFile.GetBuildPrj();
                    clsIncludeFile.SortTabNameLst();
                    bolIsGetBuildPrj = true;
                }
                if (arrAppIdCompileTabLst.Count > 0)
                {
                    arrCompileTab = arrAppIdCompileTabLst[objUserCodePrjMainPathEN.ApplicationTypeId];
                }
                if (arrCompileTab == null)
                {
                    arrCompileTab = clsIncludeFile.getTabNameLst();
                    arrAppIdCompileTabLst.Add(objUserCodePrjMainPathEN.ApplicationTypeId, arrCompileTab);
                }

                string strPrjFileName = arrCodeTypePrjFileName[strCodeTypeId];

                clsMSProject.ProjectPath = strPrjFileName;// @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";
                
                foreach (var item in arrCompileTab)
                {
                    string strTabId = clsPrjTabBLEx.GetTabIdByTabNameEx_Cache(clsPubVar.CurrSelPrjId, item.TabName);
                    if (string.IsNullOrEmpty(strTabId) == true)
                    {
                        clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjId_Cache(clsPubVar.CurrSelPrjId);
                        strMsg = string.Format("表名:{0}在工程:[{1}({2})]中不存在！", item.TabName, objProjects.PrjName, objProjects.PrjId);
                        throw new Exception(strMsg);
                    }

                    switch (item.Operate)
                    {
                        case "Delete":
                            clsPrjTabEN objPrjTab = clsPrjTabBLEx.GetObjByTabId_CacheEx(strTabId, clsPubVar.CurrSelPrjId);
                            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTab.FuncModuleAgcId);
                            string strFileName = string.Format(objCodeTypeEN.FileNameFormat, item.TabName);
                            string strRealyCodePath = objvUserCodePathEN.GetRealyCodePath();
                            string strFileName_InPrj = string.Format("{0}/{1}/{2}", strRealyCodePath, objFuncModule.FuncModuleEnName, strFileName);
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
                            
                            //string strFile = @"Class\Test\clsExamTypeEN_Sim1.cs";
                            if (clsMSProject.RemoveCompileFile(strFileName_InPrj) == false)
                            {
                                string strEvaluatedInclude = clsMSProject.RemoveCompileFileByFileName(strFileName);
                                if (string.IsNullOrEmpty(strEvaluatedInclude) == true)
                                {
                                    strMsg = string.Format("在工程:[{0}]中，文件:[{1}]不存在！",
                                        strPrjFileName, strFileName);
                                    clsPubVar.objLog.WriteDebugLog(strMsg);
                                    if (objCodeTypeEN.IsDefaultOverride == true)
                                    {
                                        DeleteClassFile(strFileName_InPrj, objvUserCodePathEN.NewCodePath,
                                                objvUserCodePathEN.NewCodePathBackup);
                                    }
                                }
                                else
                                {
                                    strMsg = string.Format("在工程:[{0}]中，删除了文件:[{1}],EvaluatedInclude:[{2}].(应该:[{3}])(In {4})",
                                        strPrjFileName, strFileName, strEvaluatedInclude, strFileName_InPrj, clsStackTrace.GetCurrClassFunction());
                                    clsPubVar.objLog.WriteDebugLog(strMsg);
                                    if (objCodeTypeEN.IsDefaultOverride == true)
                                    {
                                        DeleteClassFile(strEvaluatedInclude, objvUserCodePathEN.NewCodePath,
                                                objvUserCodePathEN.NewCodePathBackup);
                                    }
                                }
                            }
                            else
                            {
                                if (objCodeTypeEN.IsDefaultOverride == true)
                                {
                                    DeleteClassFile(strFileName_InPrj, objvUserCodePathEN.NewCodePath,
                                            objvUserCodePathEN.NewCodePathBackup);
                                }
                            }
                            //IEnumerable<string> arr = clsMSProject.getCompileFileLst();
                            break;
                        case "Add":
                            try
                            {
                                if (clsvFunctionTemplateRelaBLEx.GetFunctionCountByTabId(strTabId, strCodeTypeId) == 0)
                                {
                                    continue;
                                }

                                strCodeText = clsAutoGeneCodeWS.GeneCode(objCodeTypeEN.CodeTypeENName, "",
                                    ltLangType, mdbtDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                                   intApplicationTypeId, clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                if (string.IsNullOrEmpty(strRe_FileNameWithModuleName) == true)
                                {
                                    strMsg = string.Format("在生成[{0}]类时， 带模块名的文件名为空，请检查！({1})", objCodeTypeEN.CodeTypeENName, clsStackTrace.GetCurrClassFunction());
                                    MessageBox.Show(strMsg);
                                    return;
                                }
                                strRe_FileNameWithModuleName = InsertSuffixPath(strRe_FileNameWithModuleName, objvUserCodePathEN.SuffixPath);

                                strClassFName = string.Format("{0}\\{1}",
                                    objvUserCodePathEN.NewCodePath,
                                    strRe_FileNameWithModuleName);
                                if (objCodeTypeEN.IsDefaultOverride == true)
                                {
                                    clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeText,
                                        objvUserCodePathEN.NewCodePath,
                                        objvUserCodePathEN.NewCodePathBackup, myEncoding);
                                }
                                else
                                {
                                    try
                                    {
                                        clsPubFun4BLEx.SaveClassContentToFile_NoCover(strClassFName, strCodeText,
                                            objvUserCodePathEN.NewCodePath, objCodeTypeEN, myEncoding);
                                    }
                                    catch(Exception objException)
                                    {

                                    }
                                }
                                if (strRe_FileNameWithModuleName.Contains("clsvClassRoomENEx") == true)
                                {
                                    string ss = "";
                                }
                                string strRealyCodePath2 = objvUserCodePathEN.GetRealyCodePath();
                                string strFileName_InPrj2 = string.Format("{0}/{1}", strRealyCodePath2, strRe_FileNameWithModuleName);
                                                             
                                strFileName_InPrj2 = strFileName_InPrj2.Replace("\\/\\", "\\")
                           .Replace("/", "\\");
                                if (strFileName_InPrj2.Substring(0, 2) == "\\")
                                {
                                    strFileName_InPrj2 = strFileName_InPrj2.Substring(2);
                                }
                                if (strFileName_InPrj2.Substring(0, 1) == "\\")
                                {
                                    strFileName_InPrj2 = strFileName_InPrj2.Substring(1);
                                }
                                clsMSProject.ProjectPath = strPrjFileName;
                                clsMSProject.AddCompileFile(strFileName_InPrj2);
                                if (objCodeTypeEN.IsDefaultOverride == true)
                                {
                                    foreach (string strCodeTypeId2 in arrCodeTypeId)
                                    {
                                        if (strCodeTypeId2 == strCodeTypeId) continue;
                                        string strPrjFileName2 = arrCodeTypePrjFileName[strCodeTypeId2];
                                        if (strPrjFileName2 == strPrjFileName) continue;
                                        string strSimFileName = clsString.GetSimpleFName_S(strFileName_InPrj2);
                                        clsMSProject.ProjectPath = strPrjFileName2;
                                        clsMSProject.RemoveCompileFileByFileName(strSimFileName);
                                    }
                                }
                                //clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetObjByCodeTypeId_Cache("0010", clsPubVar.CurrSelPrjId);

                                //strCodeText = clsPrjTabBLEx.GenWS_Access(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                                //    clsSysParaEN.strUserId,
                                //     clsSysParaEN.strUserName, objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                                //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                                intCount++;
                            }
                            catch (Exception objException)
                            {
                                lblMsg.Text = objException.Message;
                                MessageBox.Show(objException.Message);
                            }
                            break;
                        default:
                            strMsg = string.Format("操作:[{0}]在函数中没有被处理。(In {1})", item.Operate, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);

                    }
                }
            }
            bool bolIsSuccessBuild = false;
            foreach (var item in arrCodeTypePrjFileName)
            {
                string strPrjFileName = item.Value;
                string strPrjFileName_Sim = clsString.GetSimpleFName_S(strPrjFileName);
                if (strPrjFileName_Sim.Contains(strBuildPrj))
                {
                    clsMSProject.ProjectPath = strPrjFileName;
                    bolIsSuccessBuild = clsMSProject.Build();
                    break;
                }
            }
            if (intCount != 1)
            {
                strMsg =string.Format( "生成完成！共计: {0} 个表。并且Build:{1}.", intCount.ToString(), bolIsSuccessBuild ?"成功":"不成功");
                MessageBox.Show(strMsg);
            }
            //BindLv_vPrjTab(false);


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

        private void btnAddCompileFile_Click(object sender, EventArgs e)
        {
            clsMSProject.ProjectPath = @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";
            string strFile = @"Class\Test\clsExamTypeEN_Sim1.cs";
            clsMSProject.AddCompileFile(strFile);
            IEnumerable<string> arr = clsMSProject.getCompileFileLst();
            StringBuilder sbFiles = new StringBuilder();
            arr.ToList().ForEach(x => sbFiles.AppendLine(x));
            MessageBox.Show(sbFiles.ToString());
        }

        private void btnRemoveCompileFile_Click(object sender, EventArgs e)
        {
            clsMSProject.ProjectPath = @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";
            string strFile = @"Class\Test\clsExamTypeEN_Sim1.cs";
            clsMSProject.RemoveCompileFile(strFile);
            IEnumerable<string> arr = clsMSProject.getCompileFileLst();
            StringBuilder sbFiles = new StringBuilder();
            arr.ToList().ForEach(x => sbFiles.AppendLine(x));
            MessageBox.Show(sbFiles.ToString());
        }

        private void btnGetCompileTabLst_Click(object sender, EventArgs e)
        {
            clsIncludeFile.XmlPath = @"E:\ASPNETJX\SamplePrj2017\SamplePrjWin\IncludeFile.xml";
            List<CompileTab> arrCompileTab = clsIncludeFile.getTabNameLst();
            StringBuilder sbFiles = new StringBuilder();
            arrCompileTab.ToList().ForEach(x => sbFiles.AppendLine(string.Format("{0}-{1}", x.TabName, x.IncludeExpand)));

            MessageBox.Show(sbFiles.ToString());

        }

 


        public static bool DeleteClassFile(string strClassFName, string strFolderName_Root, string strBackupFolderName)
        {
            strClassFName = strClassFName.Replace("/", "\\");
            string strFolder = clsString.ParentDir_S(strClassFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
                string strMsg = string.Format("[建立目录成功！]为文件：{2}建立了目录：{0}({1})",
                    strFolder, clsStackTrace.GetCurrClassFunctionByLevel(2),
                    strClassFName);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);

            }
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("[建立目录不成功！]文件：{2}建立目录：{0}。({1})",
                    strFolder, clsStackTrace.GetCurrClassFunctionByLevel(2),
                  strClassFName);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
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
                    }
                    strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);

                }
            }
           
            return true;
        }
        private void hideUIError()
        {
            //textBox1.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
        private void executeSafe(Action action)
        {
            try
            {
                action();
                hideUIError();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", ex.ToString());
                showUIError(ex);
                throw;
            }
        }
        private void showUIError(Exception exception)
        {
            //textBox1.Background = new SolidColorBrush(Color.FromRgb(255, 100, 100));
        }
        private void btnBuild_Click(object sender, EventArgs e)
        {
            executeSafe(() =>
            {
                var lightningDevelopmentHandle = new LightningDevelopmentHandle(/*actionsModule*/);
                //ActionsModule actionsModule1 = ActionsModule.CreateFromProject("..\\src\\Modules\\Modules.csproj", AppDomain.CurrentDomain.BaseDirectory + "\\Modules.dll", lightningDevelopmentHandle);
                string strPrjFileName = @"E:\AspNet2011\TaskProject\TaskMan_Base\TaskMan_Base.csproj";
                string strOutputFile = @"E:\AspNet2011\TaskProject\TaskMan_Base\bin\Debug\TaskMan_Base.dll";

                //string strPrjFileName = @"E:\AspNet2011\AGCV2\MyTest3\MyTest3.csproj";
                //string strOutputFile = @"E:\AspNet2011\AGCV2\MyTest3\bin\Debug\MyTest3.dll";

                //                ActionsModule actionsModule1 = ActionsModule.CreateFromProject("..\\src\\MyTest2\\MyTest2.csproj", AppDomain.CurrentDomain.BaseDirectory + "\\MyTest2.dll", lightningDevelopmentHandle);
                ActionsModule actionsModule1 = ActionsModule.CreateFromProject(strPrjFileName, strOutputFile, lightningDevelopmentHandle);


                //actionsModule = new CompositeActionsModule();

                //var lightningDevelopmentHandle = new LightningDevelopmentHandle(/*actionsModule*/);
                //actionsModule.Submodules.Add(ActionsModule.CreateFromDll(Configuration.Get.ModulesDllPath, lightningDevelopmentHandle));
            });
        }

    }
}
