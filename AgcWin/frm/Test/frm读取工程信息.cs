using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using AGC.Entity;
using Agc_CsWin.frm;
using AGC4WApi;
using com.taishsoft.datetime;
using com.taishsoft.file;
using Microsoft.Build.Construction;//.XXXXX;
using Microsoft.Build.Evaluation;


namespace AGC_CSWin
{
    public partial class frm读取工程信息 : Form
    {
        public frm读取工程信息()
        {
            InitializeComponent();
        }

        private void btnReadPrjInfo_Click(object sender, EventArgs e)
        {
            StringBuilder sbFiles = new StringBuilder();
            string strFilePath = @"E:\ASPNETJX\SamplePrj2017\SamplePrj_Entity\SamplePrj_Entity.csproj";
            XmlDocument doc = new XmlDocument();
            doc.Load(strFilePath);
            XmlNodeList xnl = doc.ChildNodes[0].ChildNodes;
            if (doc.ChildNodes[0].Name.ToLower() != "project")
                xnl = doc.ChildNodes[1].ChildNodes;

            string assemblyname = string.Empty;//程序集名
            string outputpath = string.Empty;//输出路径
                                             //遍历工程集文件
            foreach (XmlNode xn in xnl)
            {
                if (xn.ChildNodes.Count > 0 && xn.ChildNodes[0].Name.ToLower() == "configuration")
                {
                    foreach (XmlNode cxn in xn.ChildNodes)
                    {
                        if (cxn.Name.ToLower() == "assemblyname")
                        {
                            assemblyname = cxn.InnerText;
                        }
                    }
                }

                if (xn.ChildNodes.Count > 0 && xn.ChildNodes[0].Name.ToLower() == "debugsymbols")
                {
                    foreach (XmlNode cxn in xn.ChildNodes)
                    {
                        if (cxn.Name.ToLower() == "outputpath")
                        {
                            outputpath = cxn.InnerText.EndsWith("\\") ? cxn.InnerText.Substring(0, cxn.InnerText.Length - 1) : cxn.InnerText;
                            if (string.IsNullOrEmpty(outputpath) || !outputpath.ToUpper().Contains("EAPPRORESOURCE"))
                            {
                                MessageBox.Show("工程：" + tn.Text + " 的输出路径设置不对，" + outputpath + "应设置到对应的EAPPRORESOURCE文件夹下的对应业务文件存放的文件夹中。");
                                return;
                            }
                            outputpath = outputpath.Substring(outputpath.ToUpper().IndexOf("EAPPRORESOURCE"), outputpath.Length - outputpath.ToUpper().IndexOf("EAPPRORESOURCE"));
                            outputpath = outputpath.Substring(outputpath.IndexOf("\\") + 1, outputpath.Length - outputpath.IndexOf("\\") - 1);
                        }
                    }
                }
            }
            sbFiles.Append("|" + outputpath + "\\" + assemblyname + ".dll");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strFilePath = @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";
            StringBuilder sbFiles = new StringBuilder();
            var project = new Project(strFilePath);
            project.ProjectCollection.UnloadAllProjects();
            ICollection<ProjectItem> arr = project.GetItems("Compile");
            string strFile = @"Class\Test\clsExamTypeEN_Sim1.cs";
            ProjectItem objProjectItem_Sel = arr.FirstOrDefault(x => x.EvaluatedInclude == strFile);
            if (objProjectItem_Sel != null)
            {
                project.RemoveItem(objProjectItem_Sel);
            }

            if (objProjectItem_Sel == null)
            {
                project.AddItem("Compile", strFile);
            }
            project.Save();
            foreach (var file in project.GetItems("Compile"))
            {
                
                sbFiles.AppendLine(file.ItemType + file.EvaluatedInclude.ToString());
            }
            string strText = sbFiles.ToString();
            project = null;
            MessageBox.Show(strText);
        }

        private void btnAddCompileFile_Click(object sender, EventArgs e)
        {
            clsMSProject.ProjectPath = @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";
            string strFile = @"Class\Test\clsExamTypeEN_Sim1.cs";
            clsMSProject.AddCompileFile(strFile);
            IEnumerable<string> arr = clsMSProject.getCompileFileLst();
            StringBuilder sbFiles = new StringBuilder();
            arr.ToList().ForEach(x=> sbFiles.AppendLine(x));
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

        private void btnReadPrjFileInfo_Click(object sender, EventArgs e)
        {
            string strPhysicalDir = @"E:\AspNetCore\AgcSpa\AgcSpa";
            if (cboCmPrjId.SelectedIndex<=0)
            {
                MessageBox.Show("请选择一个CmPrjId");
                cboCmPrjId.Focus();
                return;
            }
            string strCmPrjId = cboCmPrjId.SelectedValue.ToString();

            FileCollection objFileColl = new FileCollection();


            clsFile.GetFileListEx(strPhysicalDir, objFileColl);
            string strServerIp = "111";
            int intCount = 0;
            foreach (UserFile objUserFile in objFileColl.FileLst)
            {

                //FileAttributes objFileAttr = File.GetAttributes(strFileName);
                clsFileResourceEN objFileResource = new clsFileResourceEN();
                objFileResource.FileDirName = objUserFile.FullDirName;
                objFileResource.IpAddress = strServerIp;
                objFileResource.FileName = objUserFile.FileName;
                objFileResource.FileLength = objUserFile.FileSize;
                //objFileResource.UpdDate = strCurrDateTime;
                objFileResource.UpdUser = clsSysParaEN_Local.strUserId;
                objFileResource.Extension = objUserFile.Extension;
                objFileResource.CreationTime = clsDateTime.getDateStr(objUserFile.CreationTime, 1);
                objFileResource.LastWriteTime = clsDateTime.getDateStr(objUserFile.CreationTime, 1);
                objFileResource.IsExistFile = true;
                objFileResource.PrjId = clsPubVar.CurrSelPrjId;
                objFileResource.CmPrjId = strCmPrjId;
                string strCondtion = new clsFileResourceEN()
                    .SetPrjId(objFileResource.PrjId, "=")
                    .SetCmPrjId(objFileResource.CmPrjId, "=")
                    .SetFileDirName(objFileResource.FileDirName, "=")
                    .SetFileName(objFileResource.FileName, "=")
                    .GetCombineCondition();
                if (clsFileResourceWApi.IsExistRecord(strCondtion) == false)
                {
                    clsFileResourceWApi.AddNewRecord(objFileResource);
                    intCount++;
                }

            }
            string strMsg = string.Format("共导入:{0}个文件。", intCount);
            MessageBox.Show(strMsg);
            //return intCount;
        }

        private void frm读取工程信息_Load(object sender, EventArgs e)
        {
            clsCMProjectExWApi.BindCbo_CmPrjIdCacheEx(cboCmPrjId, clsPubVar.CurrSelPrjId);
        }
    }
    
}
