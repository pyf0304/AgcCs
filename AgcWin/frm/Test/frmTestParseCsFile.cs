using AGC.Entity;


using com.taishsoft.common;
using com.taishsoft.file;
using DDW;
using DDW.Collections;
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
using com.taishsoft.datetime;
using System.Text.RegularExpressions;
using AgcCommBase;
using Agc_CsWin.CommFunc;
using AGC4WApi;

namespace Agc_CsWin.frm.Test
{
    public partial class frmTestParseCsFile : Form
    {
        private string strFullFileName = "";
        private string strPrjId = "0161";
        private string strUserId = "pyf";
        private string strProgLangTypeId = enumProgLangTypeWA.CSharp_01;
        public frmTestParseCsFile()
        {
            InitializeComponent();
        }

        private void btnParseFile_Click(object sender, EventArgs e)
        {
            StringBuilder sbResult = new StringBuilder();
            StringBuilder sbResult2 = new StringBuilder();
            StringBuilder sbResult3 = new StringBuilder();

            List<Parser.Error> errors = new List<Parser.Error>();

            string strFileName = txtFileName.Text;
            string strProjectPath = txtProjectPath.Text;
            this.strFullFileName = strFileName;
            List<String> files = new List<string>();
            files.Add(strFileName);

            String[] unparsedFiles = new String[files.Count];
            for (int i = 0; i < files.Count; i++)
            {
                CompilationUnitNode cu = ParseUnit(files[i], errors);
                if (cu == null) return;

                StringBuilder sb = new StringBuilder();
                cu.ToSource(sb);
                unparsedFiles[i] = sb.ToString();
                string strMsg = ShowTokenCollection(cu.toks);
                sbResult.AppendLine(strMsg);
                strMsg = ShowCompilationUnitNode(cu, files[i], strProjectPath);
                sbResult2.AppendLine(strMsg);
            }

            foreach (string strContent in unparsedFiles)
            {
                sbResult3.AppendLine(strContent);
            }
            txtResult.Text = sbResult.ToString();
            txtResult2.Text = sbResult2.ToString();
            txtResult3.Text = sbResult3.ToString();
        }
        private static CompilationUnitNode ParseUnit(string fileName, List<Parser.Error> errors)
        {
            Console.Write("\nParsing " + fileName);
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, true);
            Lexer l = new Lexer(sr);
            TokenCollection toks = l.Lex();
            //string strMsg = ShowTokenCollection(toks);
            //Console.WriteLine(strMsg);
            Parser p = null;
            CompilationUnitNode cu = null;

            p = new Parser(fileName);
            try
            {
                cu = p.Parse(toks, l.StringLiterals);
            }
            catch(Exception objException)
            {
                string strMsg = objException.Message;
                clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
                return null;
            }
            if (cu != null)
            {
                cu.toks = toks;
            }
            //strMsg = ShowCompilationUnitNode(cu, fileName);
            //Console.WriteLine(strMsg);
            if (p.Errors.Count != 0)
            {
                Console.WriteLine();
                PrintErrors(p.Errors);
                errors.AddRange(p.Errors);
                return null;
            }
            return cu;
        }
        public string ShowCompilationUnitNode(CompilationUnitNode cu, string strFileName, string strProjectPath)
        {
            string strFilePath = clsFile.GetDirName_S(strFileName);
            string strSimpleFileName = clsFile.GetSimpleFName_S(strFileName);
            string strFileContent = clsFile.GetContentFromTextFile(strFileName).Replace(";", "；");
            //string strCondition = "";
            //bool bolIsExist = false;
          StringBuilder sbMsg = new StringBuilder();
            foreach (NamespaceNode objInFor in cu.Namespaces)
            {
                sbMsg.AppendLine(objInFor.Name.GenericIdentifier);
                
                foreach (var objInFor2 in objInFor.Classes)
                {
                    sbMsg.AppendLine(objInFor2.Name.Identifier);
                    Tuple<string, string> TableCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassName(objInFor2.Name.Identifier, clsPubConst.LangType.CSharp);
                    clsvPrjTab_SimEN objPrjTab = clsPrjTabExWApi.GetObjByTabNameExCache(strPrjId, TableCodeTypeId.Item1);
                    string strFuncModuleId = "";
                    if (objPrjTab != null)
                    {
                        strFuncModuleId = objPrjTab.FuncModuleAgcId;
                    }
                    clsCMClassEN objCMClass = clsPubClass4CM.GetClassByClassNode(objInFor2, strProgLangTypeId, 
                        objInFor.Name.GenericIdentifier, 
                        strFileName, strProjectPath,
                        strPrjId, strUserId);
                    objCMClass.FileText = objCMClass.FileText.Replace(";", "；");
                    objCMClass = clsCMClassExWApi.AddCMClass(objCMClass);

                    sbMsg.AppendLine(string.Format("常量：{0}个", objInFor2.Constants.Count));
                    foreach (var objInFor3 in objInFor2.Constants)
                    {
                        StringBuilder sbText = new StringBuilder();
                        objInFor3.ToSource(sbText);
                        StringBuilder sbTemp = new StringBuilder();
                        objInFor3.Type.ToSource(sbTemp);
                        StringBuilder sbTemp2 = new StringBuilder();
                        objInFor3.Names.ToSource(sbTemp2);
                        string strTemp = string.Format("{0} {1} {2};//Line:{3}, Col:{4}-->Line:{5}, Col:{6}",
                            objInFor3.Modifiers.ToString(), sbTemp.ToString(), sbTemp2.ToString(),
                            objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);
                        string strMethodContent = "";
                        if (objInFor3.StartToken.Line > 0 && objInFor3.EndToken.Line > 0)
                        {
                            stuTextRange objTextRange = new stuTextRange(new stuTextPos(objInFor3.StartToken.Line, objInFor3.StartToken.Col),
                              new stuTextPos(objInFor3.EndToken.Line, objInFor3.EndToken.Col));
                            strMethodContent = clsFile.GetContentFromTextFileByRange(strFileName, objTextRange);
                        }
                        else
                        {
                            strMethodContent = string.Format("文本范围不正确！Line:{0}, Col:{1}-->Line:{2}, Col:{3}",
                            objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);
                        }
                        sbMsg.AppendLine(strTemp);
                        sbMsg.AppendLine(strMethodContent);
                    }
                    sbMsg.AppendLine(string.Format("字段：{0}个", objInFor2.Fields.Count));
                    foreach (var objInFor3 in objInFor2.Fields)
                    {
                        StringBuilder sbText = new StringBuilder();
                        objInFor3.ToSource(sbText);
                        StringBuilder sbTemp = new StringBuilder();
                        objInFor3.Type.ToSource(sbTemp);
                        StringBuilder sbTemp2 = new StringBuilder();
                        objInFor3.Names.ToSource(sbTemp2);
                        string strTemp = string.Format("{0} {1} {2};//Line:{3}, Col:{4}-->Line:{5}, Col:{6}",
                            objInFor3.Modifiers.ToString(), sbTemp.ToString(), sbTemp2.ToString(),
                            objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);
                        string strMethodContent = "";
                        if (objInFor3.StartToken.Line > 0 && objInFor3.EndToken.Line > 0)
                        {
                            stuTextRange objTextRange = new stuTextRange(new stuTextPos(objInFor3.StartToken.Line, objInFor3.StartToken.Col),
                              new stuTextPos(objInFor3.EndToken.Line, objInFor3.EndToken.Col));
                            strMethodContent = clsFile.GetContentFromTextFileByRange(strFileName, objTextRange);
                        }
                        else
                        {
                            strMethodContent = string.Format("文本范围不正确！Line:{0}, Col:{1}-->Line:{2}, Col:{3}",
                            objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);
                        }
                        sbMsg.AppendLine(strTemp);
                        sbMsg.AppendLine(strMethodContent);
                    }

                    sbMsg.AppendLine(string.Format("属性：{0}个", objInFor2.Properties.Count));
                    foreach (var objInFor3 in objInFor2.Properties)
                    {
                        StringBuilder sbText = new StringBuilder();
                        objInFor3.ToSource(sbText);

                        string strTemp = string.Format("{0} {1}();//Line:{2}, Col:{3}-->Line:{4}, Col:{5}",
                            objInFor3.Modifiers.ToString(), objInFor3.Names[0].GenericIdentifier, objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);
                        string strMethodContent = "";
                        if (objInFor3.StartToken.Line > 0 && objInFor3.EndToken.Line > 0)
                        {
                            stuTextRange objTextRange = new stuTextRange(new stuTextPos(objInFor3.StartToken.Line, objInFor3.StartToken.Col),
                            new stuTextPos(objInFor3.EndToken.Line, objInFor3.EndToken.Col));
                            strMethodContent = clsFile.GetContentFromTextFileByRange(strFileName, objTextRange);
                        }
                        else
                        {
                            strMethodContent = string.Format("文本范围不正确！Line:{0}, Col:{1}-->Line:{2}, Col:{3}",
                            objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);
                        }
                        sbMsg.AppendLine(strTemp);
                        sbMsg.AppendLine(strMethodContent);
                    }
                    sbMsg.AppendLine(string.Format("构造函数：{0}个", objInFor2.Constructors.Count));
                    foreach (var objInFor3 in objInFor2.Constructors)
                    {
                        StringBuilder sbText = new StringBuilder();
                        objInFor3.ToSource(sbText);
                        StringBuilder sbParams = new StringBuilder();

                        objInFor3.Params.ToSource(sbParams, ", ");

                        string strTemp = string.Format("{0} {1}({2});//Line:{3}, Col:{4}-->Line:{5}, Col:{6}",
                            objInFor3.Modifiers,
                            objInFor3.Names[0].GenericIdentifier,
                            sbParams,
                            objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);
                        string strMethodContent = "";
                        if (objInFor3.StartToken.Line > 0 && objInFor3.EndToken.Line > 0)
                        {
                            stuTextRange objTextRange = new stuTextRange(new stuTextPos(objInFor3.StartToken.Line, objInFor3.StartToken.Col),
                            new stuTextPos(objInFor3.EndToken.Line, objInFor3.EndToken.Col));
                            strMethodContent = clsFile.GetContentFromTextFileByRange(strFileName, objTextRange);
                        }
                        else
                        {
                            strMethodContent = string.Format("文本范围不正确！Line:{0}, Col:{1}-->Line:{2}, Col:{3}",
                            objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);
                        }
                        sbMsg.AppendLine(strTemp);
                        sbMsg.AppendLine(strMethodContent);
                    }
                    sbMsg.AppendLine(string.Format("索引函数：{0}个", objInFor2.Indexers.Count));
                    foreach (var objInFor3 in objInFor2.Indexers)
                    {
                        StringBuilder sbText = new StringBuilder();
                        objInFor3.ToSource(sbText);
                        StringBuilder sbParams = new StringBuilder();

                        objInFor3.Params.ToSource(sbParams, ", ");
                        StringBuilder sbType = new StringBuilder();

                        objInFor3.Type.ToSource(sbType);

                        string strTemp = string.Format("{0} {1}this[{2}];//Line:{3}, Col:{4}-->Line:{5}, Col:{6}",
                            objInFor3.Modifiers, sbType, sbParams, objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);
                        string strMethodContent = "";
                        if (objInFor3.StartToken.Line > 0 && objInFor3.EndToken.Line > 0)
                        {
                            stuTextRange objTextRange = new stuTextRange(new stuTextPos(objInFor3.StartToken.Line, objInFor3.StartToken.Col),
                            new stuTextPos(objInFor3.EndToken.Line, objInFor3.EndToken.Col));
                            strMethodContent = clsFile.GetContentFromTextFileByRange(strFileName, objTextRange);
                        }
                        else
                        {
                            strMethodContent = string.Format("文本范围不正确！Line:{0}, Col:{1}-->Line:{2}, Col:{3}",
                            objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);
                        }
                        sbMsg.AppendLine(strTemp);
                        sbMsg.AppendLine(strMethodContent);
                    }
                    sbMsg.AppendLine(string.Format("函数：{0}个", objInFor2.Methods.Count));
                    foreach (var objInFor3 in objInFor2.Methods)
                    {
                        StringBuilder sbText = new StringBuilder();
                        objInFor3.ToSource(sbText);

                        StringBuilder sbParams = new StringBuilder();
                        objInFor3.Params.ToSource(sbParams, ", ");
                        string strTemp = string.Format("{0} {1}({2});//Line:{3}, Col:{4}-->Line:{5}, Col:{6}",
                            objInFor3.Modifiers,
                            objInFor3.GenericIdentifier,
                            sbParams,
                            objInFor3.StartToken.Line, objInFor3.StartToken.Col, objInFor3.EndToken.Line, objInFor3.EndToken.Col);

                        string strTemp_Comment = "";
                        if (objInFor3.StartPos4Comment != null)
                        {
                            strTemp_Comment = string.Format("注释:{0} {1} {2};//Line:{3}, Col:{4}-->Line:{5}, Col:{6}",
                            objInFor3.Modifiers.ToString(), objInFor3.GenericIdentifier, sbParams,
                            objInFor3.StartPos4Comment.Line, objInFor3.StartPos4Comment.Col, objInFor3.EndPos4Comment.Line, objInFor3.EndPos4Comment.Col);
                        }

                        string FunctionSignature = string.Format("{1}({2})",
                            objInFor3.Modifiers,
                            objInFor3.GenericIdentifier,
                            sbParams);
                        StringBuilder sbFuncType = new StringBuilder();
                        objInFor3.Type.ToSource(sbFuncType);

                        StringBuilder sbFuncName = new StringBuilder();
                        objInFor3.Names.ToSource(sbFuncName);
                        string strMethodComment = "";
                        if (objInFor3.StartPos4Comment != null)
                        {
                            stuTextRange objTextRange_Comment = new stuTextRange(new stuTextPos(objInFor3.StartPos4Comment.Line,
                              objInFor3.StartPos4Comment.Col),
                            new stuTextPos(objInFor3.EndPos4Comment.Line, objInFor3.EndPos4Comment.Col));
                            strMethodComment = clsFile.GetContentFromTextFileByRange(strFileName, objTextRange_Comment);
                        }
                        stuTextRange objTextRange = new stuTextRange(new stuTextPos(objInFor3.StartToken.Line, objInFor3.StartToken.Col),
                            new stuTextPos(objInFor3.EndToken.Line, objInFor3.EndToken.Col));
                        string strMethodContent = clsFile.GetContentFromTextFileByRange(strFileName, objTextRange);


                        sbMsg.AppendLine(strTemp_Comment);
                        sbMsg.AppendLine(strMethodComment);

                        sbMsg.AppendLine(strTemp);
                        sbMsg.AppendLine(strMethodContent);
                        clsCMFunctionEN objCMFunction = clsPubClass4CM.GetFunctionByMethodNode(objInFor3, objCMClass.CmClassId, strProgLangTypeId, strFileName, strPrjId, strUserId);
                        objCMFunction = clsCMFunctionExWApi.AddCMFunction(objCMFunction);

                        //clsCMClassFuncRelaEN objCMClassFuncRela = new clsCMClassFuncRelaEN();
                        //objCMClassFuncRela.SetCmClassId(objCMClass.CmClassId)
                        //    .SetCmFunctionId(objCMFunction.CmFunctionId)
                        //    .SetOrderNum(1)
                        //        .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                        //.SetUpdUser(clsSysParaEN_Local.strUserId);

                        //objCMClassFuncRela = clsCMClassFuncRelaExWApi.AddCMClassFuncRela(objCMClassFuncRela);

                        foreach(var objInFor4 in objInFor3.Params)
                        {
                            clsCMFuncParaEN objCMFuncPara = clsPubClass4CM.GetFuncParaByParamDeclNode(objInFor4, strProgLangTypeId, strFileName, strPrjId, strUserId);
                            objCMFuncPara = clsCMFuncParaExWApi.AddCMFuncPara(objCMFuncPara);

                            clsCMFuncParaRelaEN objCMFuncParaRela = new clsCMFuncParaRelaEN();
                            objCMFuncParaRela.SetCmFunctionId(objCMFunction.CmFunctionId)
                                .SetCmFuncParaId(objCMFuncPara.CmFuncParaId)
                                .SetOrderNum(1)
                                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                            .SetUpdUser(clsSysParaEN_Local.strUserId);

                            objCMFuncParaRela = clsCMFuncParaRelaExWApi.AddCMFuncParaRela(objCMFuncParaRela);

                        }
                    }

                }
            }
            return sbMsg.ToString();
        }
        public static string ShowTokenCollection(TokenCollection toks)
        {
            StringBuilder sbMsg = new StringBuilder();
            LinkedListNode<Token> nextTokNode = toks.First;
            while (nextTokNode != null)
            {
                sbMsg.AppendLine(nextTokNode.Value.ToLongString());
                nextTokNode = nextTokNode.Next;
            }
            return sbMsg.ToString();
        }
        private static void AddError(List<Parser.Error> errors, String fileName, string errorStr, Token tok, int line, int column)
        {
            Console.WriteLine("\n" + errorStr);
            errors.Add(new Parser.Error(errorStr, tok, line, column, fileName));
        }

        private static void AddError(List<Parser.Error> errors, String fileName, string errorStr)
        {
            AddError(errors, fileName, errorStr, Parser.EOF, -1, -1);
        }
        private static void PrintErrors(IEnumerable<Parser.Error> errors)
        {
            foreach (Parser.Error error in errors)
            {
                if (error.Token.ID == TokenID.Eof && error.Line == -1)
                {
                    Console.WriteLine(error.Message + "\nFile: " + error.FileName + "\n");
                }
                else
                {
                    Console.WriteLine(error.Message + " in token " + error.Token.ID
                        + "\nline: " + error.Line + ", column: " + error.Column
                        + "\nin file: " + error.FileName + "\n");
                }
            }
        }

        private void btnCodeFileMan_Click(object sender, EventArgs e)
        {
            StringBuilder sbResult = new StringBuilder();
            StringBuilder sbResult2 = new StringBuilder();
            StringBuilder sbResult3 = new StringBuilder();
            string strFileName = txtFileName.Text;
            string strProjectPath = txtProjectPath.Text;
            this.strFullFileName = strFileName;
            List<Parser.Error> errors = new List<Parser.Error>();
            CompilationUnitNode cu = ParseUnit(strFileName, errors);
            //StringBuilder sb = new StringBuilder();
            cu.ToSource(sbResult3);
            
            string strMsg = ShowTokenCollection(cu.toks);
            sbResult.AppendLine(strMsg);
            strMsg = ShowCompilationUnitNode(cu, strFileName, strProjectPath);
            sbResult2.AppendLine(strMsg);
            //sbResult3.AppendLine(sb);
            txtResult.Text = sbResult.ToString();
            txtResult2.Text = sbResult2.ToString();
            txtResult3.Text = sbResult3.ToString();
        }

        private void btnTestRegex_Click(object sender, EventArgs e)
        {
            string str = "make maze and manage to measure it";

            //Console.WriteLine("Matching words start with 'm' and ends with 'e':");
            showMatch(str, @"\bm\S*e\b");
            //Console.ReadKey();


            string strClass1 = "clsTest11BLEx aclsTestBLExaa clsTestBLEx";
            string strClass2 = "clsTest11BLEx";
            string strClass3 = "clsTestENEx";

            string strPattern = @"\bcls\S*BLEx\b";
            var r = new Regex(strPattern);
            Match m2 = r.Match(strClass2);
            Match m3 = r.Match(strClass3);
           Tuple< string, string> TableCodeTypeId = clsCodeTypeExWApi.GetCodeTypeIdByClassName(strClass2, clsPubConst.LangType.CSharp);
            Tuple<string, string> TableCodeTypeId2 = clsCodeTypeExWApi.GetCodeTypeIdByClassName(strClass3, clsPubConst.LangType.CSharp);

            MatchCollection mc = Regex.Matches(strClass1, strPattern);
            StringBuilder sbMsg = new StringBuilder();
            foreach (Match m in mc)
            {
                sbMsg.AppendLine(m.Value);
            }
            if (mc.Count > 0)
            {

                txtResult2.Text = sbMsg.ToString();
            }
            else
            {
                txtResult2.Text = "不匹配！";
            }
            
        }
        private void showMatch(string text, string expr)
        {
            StringBuilder sbMsg = new StringBuilder();

            sbMsg.AppendLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                sbMsg.AppendLine(m.Value);
            }
            txtResult.Text = sbMsg.ToString();
        }
        void Main11(string[] args)
        {
            string str = "make maze and manage to measure it";

            Console.WriteLine("Matching words start with 'm' and ends with 'e':");
            showMatch(str, @"\bm\S*e\b");
            Console.ReadKey();
        }

        private void frmTestParseCsFile_Load(object sender, EventArgs e)
        {
            txtFileName.Text = @"E:\AspNet2011\TaskProject\TaskMan_Business\ClassEx\PrjManage\clsPrjInfoExWApi.cs";
            txtProjectPath.Text = @"E:\AspNet2011\TaskProject\TaskMan_Business\";

            txtFileName.Text = @"E:\BaseClass2005\TzPubFunction\com\taishsoft\commdb4odbc\clsAccess2007SQL.cs";
            txtProjectPath.Text = @"E:\BaseClass2005\TzPubFunction\";

        
        }
    }
}
