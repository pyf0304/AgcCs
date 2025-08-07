using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;
using CommFunc4WebForm;

namespace AgcMvc3.Webform.A_Sample
{
    public partial class T_TestParseWord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFuncNameParseWord_Click(object sender, EventArgs e)
        {
            List<string> arrWord = clsParseWord.ParseFuncNameIntoWord("BtnFuncNameParseWord_Neo4J4BL_Click");
            arrWord.ForEach(x => ListBox1.Items.Add(x));
            if (clsFunction4GeneCodeBLEx.FuncName_ParseWord() == true)
            {
                clsCommonJsFunc.Alert(this, "分词完成！");
            }
            else
            {
                clsCommonJsFunc.Alert(this, "分词失败！");
            }
        }

        protected void btnTotalWord_ClickBak(object sender, EventArgs e)
        {
            bool bolResult = clsFunction4GeneCodeBLEx.WordSummarize();
            IEnumerable<string> arrWord = null;
            Dictionary<string, int> dicWordFrequency = new Dictionary<string, int>();
            List<clsFunction4GeneCodeEN> arrObjLst = clsFunction4GeneCodeBL.GetObjLst("1=1");
            foreach (clsFunction4GeneCodeEN objInFor in arrObjLst)
            {
                arrWord = objInFor.ParsedWords.Split(",".ToCharArray());
                foreach (string strWord in arrWord)
                {
                    if (dicWordFrequency.ContainsKey(strWord))
                    {
                        int intCount = dicWordFrequency[strWord];
                        dicWordFrequency[strWord] = intCount + 1;
                    }
                    else
                    {
                        dicWordFrequency.Add(strWord, 1);
                    }
                }
            }
            var arrWordCount = dicWordFrequency.OrderByDescending(x => x.Value).ToList();
            List<string> arrExclude = new List<string>() { "4", "Async", "JS", "Js", "_", "#", ":", "BL", "DA","JDA", "Neo", "Neo4J", "Gen", "CS", "Java", "S", "Ts", "Web", "Ws", "WS", "Swift", "Swift3" };
            List<string> arrWord_Finished = arrWordCount.Select(x => x.Key).Where(x => arrExclude.Contains(x) == false).ToList();
            string strTemplate = clsString.combineStrS("0", arrWord_Finished.Count);
            foreach (clsFunction4GeneCodeEN objInFor in arrObjLst)
            {
                StringBuilder sbWordVector = new StringBuilder(strTemplate);
                arrWord = objInFor.ParsedWords.Split(",".ToCharArray());
                foreach (string strWord in arrWord)
                {
                    var index = arrWord_Finished.IndexOf(strWord);
                    if (index >= 0)
                    {
                        sbWordVector.Replace("0", "1", index, 1);
                    }
                }
                objInFor.SetWordVector(sbWordVector.ToString()).Update();
            }

            StringBuilder sbContent = new StringBuilder();
            foreach (var varWord in arrWordCount)
            {
                string strWordCount = string.Format("{0}----{1}--{2}",
                    varWord.Key,
                    varWord.Value,
                    arrExclude.Contains(varWord.Key) ? "排除" : "");
                sbContent.AppendLine(strWordCount);
            }


            string strFileName = @"E:\WordCount.txt";
            Encoding myEncoding = Encoding.Unicode;
            clsFile.CreateFileByString(strFileName, sbContent.ToString(), myEncoding);
            GridView1.DataSource = arrWordCount;
            GridView1.DataBind();
            clsCommonJsFunc.Alert(this, "统计完成！");
        }
        protected void btnTotalWord_Click(object sender, EventArgs e)
        {
            bool bolResult = clsFunction4GeneCodeBLEx.WordSummarize();
            if (bolResult)
            {
                clsCommonJsFunc.Alert(this, "统计并建立词向量完成！");
            }
            else
            {
                clsCommonJsFunc.Alert(this, "统计并建立词向量失败！");
            }
        }

        public static Tuple<bool, string> SaveClassContentToFile_NoCover(string strClassFName, string strClassContent, string strFolderName_Root, clsCodeTypeEN objCodeTypeEN, Encoding myEncoding)
        {
            string strFolder = clsString.ParentDir_S(strClassFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = "";
                    if (objCodeTypeEN != null)
                    {
                        strMsg = string.Format("\r\n[文件已经存在!]({2})",
                            strFindFileFullFile,
                            clsStackTrace.GetCurrClassFunctionByLevel(2), objCodeTypeEN.CodeTypeName);
                    }
                    else
                    {
                        strMsg = string.Format("\r\n[文件已经存在!]",
                            strFindFileFullFile,
                            clsStackTrace.GetCurrClassFunctionByLevel(2));
                    }
                    return Tuple.Create(false, strMsg);

                }
            }
            clsFile.CreateFileByString(strClassFName, strClassContent, myEncoding);
            return Tuple.Create(true, "");
        }

        protected void btnParseFeatureId_Click(object sender, EventArgs e)
        {
            int intCount = clsFunction4GeneCodeBLEx.ParseFeatureId();
            string strMsg = string.Format("分析完成！共分析了:{0}条记录！", intCount);     
            clsCommonJsFunc.Alert(this, strMsg);
        }
  
    }
}