using com.taishsoft.common;
using com.taishsoft.lexicalAnalysis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicCompilerWin
{
    public partial class frmLexicalAnalysis4CSharp : Form
    {
        List<clsWord_LA> arrWord = new List<clsWord_LA>();
        //private static string[] 保留字1 ={"bool","break","case","char","do","double","else",
        //"false","float","for","if","int","long","main","new","null","private","protected","public",
        //"static","true","try","typeof","unit","void","while","return","short","sizeof","switch"
        //};
        //全局变量，保留字表
        //        private static string[] reserveWord = {"auto", "break", "case", "char", "const", "continue",
        //"default", "do", "double", "else", "enum", "extern",
        //"float", "for", "goto", "if", "int", "long",
        //"register", "return", "short", "signed", "sizeof", "static",
        //"struct", "switch", "typedef", "union", "unsigned", "void",
        //"volatile", "while"
        //};
        private static string[] reserveWord ={"abstract","as","base","bool","break","byte","case","catch","char","checked",
        "class","const","continue","decimal","default","do","double","else","enum","event",
        "explicit","extern","false","finally","fixed","float","for","foreach","goto","if",
        "implicit","in","in（泛型修饰符）","int","interface","internal","为","lock","long",
        "命名空间","namespace","new","null","object","operator","out","out（泛型修饰符）","override",
        "params","private","protected","public","readonly","ref","return","sbyte","sealed",
        "short","sizeof","stackalloc","static","string","结构","struct", "switch","this","throw","true",
        "try","typeof","uint","ulong","unchecked","unsafe","ushort","using","virtual","void",
        "volatile","while"};
        private static string[] systemType ={"bool","byte","char","decimal",
            "double","float","int","interface","long","object",
            "sbyte", "short","string","struct", "uint","ulong","ushort","void", "Exception"};
        private static List<string> arrSystemType = null;//系统类型


        private static string[] NameSpaces = {"System","System.Collections",
            "System.Collections.Generic","System.IO","System.Text",
            "Microsoft.Office.Interop","Word","Microsoft.Office.Interop.Word",
            "System.Reflection","com.taishsoft.common",
            "Microsoft.Office.Interop.Word","System.Data","System.Diagnostics",
            "com.taishsoft.datetime","System.Linq"};
        //        上下文关键字

        //上下文关键字用于提供代码中的特定含义，但它不是 C# 中的保留字。 某些上下文关键字（如 partial 和 where）在两个或更多个上下文中具有特殊含义。
        //添加
        //别名
        private static string[] ContextKeyword = {
     "ascending","descending","dynamic","from","get","global","group","into","join","let","orderby",
            "partial（类型）","partial（方法）","remove","select","set","value","var",
            "where（泛型类型约束）","where（查询子句）","yield"              };
        private static string[] 运算符1 ={"*","/","%","+","-","<<",">>","<",">","<=",">=",
        "==","!=","&","^","|","&&","||","?:","+=","-=","*=","/=","%=","&=","|=","^=",
        "<<=",">>=","="};
        private static string[] operators ={"*","/","%","+","-","<<",">>","<",">","<=",">=",
        "==","!=","&","^","|","&&","||","?:","+=","-=","*=","/=","%=","&=","|=","^=",
        "<<=",">>=","=","++","--"};
        private static string[] Delimiter = { ",", ";", ".", "'", "(", ")", ":", "[", "]", "{", "}", "/", "\"", "\'", "\\" };

        //界符运算符表,根据需要可以自行增加//我去除：,"\?"
        private static string[] operatorOrDelimiter ={
"+","-","*","/","<","<=",">",">=","=","==",
"!=",";","(",")","^",",","\"","\'","#","&",
"&&","|","||","%","~","<<",">>","[","]","{",
"}","\\",".",":","!"
};
        private static string[] 界符1 = { ",", ";", ".", "'", "(", ")", ":", "[", "]", "{", "}", "/" };
        private static List<string> arrUserClassTbl;
        private static string[] UDSpaceNameTbl;
        private static List<string> arrVariableTbl = null;//变量表
        private static List<string> arrFunctionTbl = null;//函数表
        private static List<string> arrUnknownTbl = null;//未知表
        private static List<string> arrRegionTbl = null;//区域表

        private static string[] IDentifierTbl;//标识符表
        private static string[] 常数;
        private static string[] 未知符号;

        //        static char IDentifierTbl[1000][50]={""};//标识符表
        //char resourceProject[10000];//输入的源程序存放处，最大可以存放10000个字符。
        //        char token[20] = { 0 };//每次扫描的时候存储已经扫描的结果。
        //        int syn = -1;//syn即为种别码，约定‘$’的种别码为0，为整个源程序的结束符号一旦扫描到这个字符代表扫描结束
        //        int pProject = 0;//源程序指针，始终指向当前源程序待扫描位置。
        private ArrayList temp = new ArrayList();

        public frmLexicalAnalysis4CSharp()
        {
            InitializeComponent();
            arrSystemType = new List<string>(systemType);
            arrVariableTbl = new List<string>();
            arrUserClassTbl = new List<string>();
            arrFunctionTbl = new List<string>();
            arrRegionTbl = new List<string>();
        }
        /// <summary>
        /// 查找字符编码在相关表中的位置
        /// </summary>
        /// <param name="strWord">词</param>
        /// <param name="sstrWord"></param>
        /// <returns></returns>
        public int Search_Location(clsWord_LA objWord, string[] sstrWord) //查找字符编码
        {
            for (int i = 0; i < sstrWord.Length; i++)
            {
                if (objWord.Word == sstrWord[i])
                    return i + 1;
            }
            return -1;
        }

        /// <summary>
        /// 查找字符编码在相关表中的位置
        /// </summary>
        /// <param name="strWord">词</param>
        /// <param name="sstrWord"></param>
        /// <returns></returns>
        public int Search_Location(clsWord_LA objWord, List<string> sstrWord) //查找字符编码
        {
            for (int i = 0; i < sstrWord.Count; i++)
            {
                if (objWord.Word == sstrWord[i])
                    return i + 1;
            }
            return -1;
        }
        /// <summary>
        /// 插入新的标识符
        /// </summary>
        /// <param name="strWord"></param>
        /// <param name="sstrIDentifier">标识符表</param>
        /// <returns></returns>
        public int InsertId(clsWord_LA objWord, ref string[] sstrIDentifier)//标识符插入标识符表返回位置
        {
            temp.Clear();
            if (sstrIDentifier == null)
                temp.Add(objWord.Word);
            else
            {
                for (int i = 0; i < sstrIDentifier.Length; i++)
                    if (objWord.Word == sstrIDentifier[i])
                        return i;
                for (int j = 0; j < sstrIDentifier.Length; j++)
                {
                    temp.Add(sstrIDentifier[j]);
                }
                temp.Add(objWord.Word);
            }
            sstrIDentifier = (string[])temp.ToArray(typeof(string));
            return sstrIDentifier.Length - 1;
        }

        /// <summary>
        /// 插入新的标识符
        /// </summary>
        /// <param name="strWord"></param>
        /// <param name="sstrIDentifier">标识符表</param>
        /// <returns></returns>
        public int InsertId(clsWord_LA objWord, List<string> sstrIDentifier)//标识符插入标识符表返回位置
        {
            //temp.Clear();
            if (sstrIDentifier == null)
            {
                sstrIDentifier = new List<string>();
            }
            for (int i = 0; i < sstrIDentifier.Count; i++)
                if (objWord.Word == sstrIDentifier[i])
                    return i;
            //for (int j = 0; j < sstrIDentifier.Count; j++)
            //{
            //    temp.Add(sstrIDentifier[j]);
            //}
            sstrIDentifier.Add(objWord.Word);

            return sstrIDentifier.Count - 1;
        }

        /// <summary>
        /// 预处理
        /// </summary>
        /// <returns></returns>
        private string Pretreatment()       //预处理
        {
            string strCode_In = textBox1.Text;
            string strCode_out = null;
            //去除换行和//注释
            string[] sstrLine = textBox1.Lines;
            for (int i = 0; i < sstrLine.Length; i++)
            {
                if (sstrLine[i].Contains("//"))
                {
                    string[] strr = sstrLine[i].Split('/');
                    sstrLine[i] = strr[0];
                }
                else if (sstrLine[i].Contains("#region"))
                {
                    sstrLine[i] = "";
                }
                else if (sstrLine[i].Contains("#endregion"))
                {
                    sstrLine[i] = "";
                }
            }
            for (int i = 0; i < sstrLine.Length; i++)
            {
                //sstrLine[i] = sstrLine[i].Replace(";", " ;");
                //sstrLine[i] = sstrLine[i].Replace("(", " ( ");
                //sstrLine[i] = sstrLine[i].Replace(")", " ) ");

                strCode_out += sstrLine[i] + " ";
            }
            //去除跳格，回车
            if (strCode_out.Contains("/v"))
            {
                strCode_out = strCode_out.Replace("/v", " ");
            }
            if (strCode_out.Contains("/r"))
            {
                strCode_out = strCode_out.Replace("/r", " ");
            }
            if (strCode_out.Contains("/n"))
                strCode_out = strCode_out.Replace("/n", " ");
            if (strCode_out.Contains("/t"))
            {
                strCode_out = strCode_out.Replace("/t", " ");
            }
            //去除注释
            while (strCode_out.Contains("/*") && strCode_out.Contains("*/"))
            {
                strCode_out = strCode_out.Remove(strCode_out.IndexOf("/*"), strCode_out.IndexOf("*/") - strCode_out.IndexOf("/*") + 2);
            }
            //去除多余空格
            while (strCode_out.Contains("  "))
            {
                strCode_out = strCode_out.Replace("  ", " ");
            }
            return strCode_out;
        }
        /// <summary>
        /// 是否是操作符
        /// </summary>
        /// <param name="strWord"></param>
        /// <returns></returns>
        private bool IsOperator(string strWord)
        {
            for (int i = 0; i < operators.Length; i++)
                if (strWord == operators[i])
                    return true;
            return false;
        }
        /// <summary>
        /// 是否是分隔符
        /// </summary>
        /// <param name="strWord">一个词</param>
        /// <returns></returns>
        private bool IsCommunity_character(string strWord)
        {
            for (int i = 0; i < Delimiter.Length; i++)
                if (strWord == Delimiter[i])
                    return true;
            return false;
        }

     
        private void AddWordToList(string strWord)
        {
            clsWord_LA objWord_LA = new clsWord_LA(strWord);
            arrWord.Add(objWord_LA);
        }
        private void AddWordToList(string strWord, string strWordType, tzWordType wtWordTypeId)
        {
            clsWord_LA objWord_LA = new clsWord_LA(strWord);
            objWord_LA.WordType = strWordType;
            objWord_LA.WordTypeId = wtWordTypeId;

            arrWord.Add(objWord_LA);
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            //arrWord = new List<clsWord_LA>();
            //arrUserClassTbl = new List<string>();
            //IDentifierTbl = null;
            string strCode_In = textBox1.Text;
            if (strCode_In == "")
            {
                MessageBox.Show("您没有输入任何字符！");
                return;
            }
            clsLexicalAnalysis4CSharp objLexicalAnalysis4CSharp = new clsLexicalAnalysis4CSharp(strCode_In);
            //objLexicalAnalysis4CSharp.CodeLines = textBox1.Lines;
            //strCode_In = objLexicalAnalysis4CSharp.fnPretreatment();
            string strCode_Out = null;
            try
            {
                string strErrorMsg = objLexicalAnalysis4CSharp.fnAnalyzeV3();
                strCode_Out = objLexicalAnalysis4CSharp.fnShowAllWordType();
                textBox2.Text = strCode_Out;
                if (string.IsNullOrEmpty(strErrorMsg) == false)
                {
                    MessageBox.Show(strErrorMsg);
                }
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string dir = openFileDialog1.FileName;
                string text = null;
                StreamReader sr;
                try
                {
                    sr = new StreamReader(dir, System.Text.Encoding.Default);

                }
                catch
                {

                    MessageBox.Show("操作失败");
                    return;
                }
                while (sr.Peek() != -1)
                {
                    text += sr.ReadLine();
                    text += Environment.NewLine;
                }

                sr.Close();
                textBox1.Text = text;
                textBox2.Text = Pretreatment();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string dir = saveFileDialog1.FileName;
                StreamWriter sw;
                try
                {
                    sw = File.CreateText(dir);

                }
                catch
                {
                    MessageBox.Show("文件创建失败");
                    return;
                }
                string[] text = textBox2.Lines;
                for (int i = 0; i < text.Length; i++)
                {
                    sw.WriteLine(text[i]);
                }
                sw.Close();
            }
        }


        private void frmLexicalAnalysis_Load(object sender, EventArgs e)
        {
            textBox1.Text = "int i = 10 ; /*注释部分 */ ?";
        }
        private void ScannerBak(ref int syn, char[] resourceProject, char[] token, ref int pProject)
        {//根据DFA的状态转换图设计
            int i, count = 0;//count用来做token的指示器，收集有用字符
            char ch;//作为判断使用
            ch = resourceProject[pProject];
            while (ch == ' ')
            {//过滤空格，防止程序因识别不了空格而结束
                pProject++;
                ch = resourceProject[pProject];
            }
            for (i = 0; i < 20; i++)
            {//每次收集前先清零
                token[i] = '\0';
            }
            if (Char.IsLetter(resourceProject[pProject]))
            {//开头为字母
                token[count++] = resourceProject[pProject];//收集
                pProject++;//下移
                while (Char.IsLetter(resourceProject[pProject]) || Char.IsDigit(resourceProject[pProject]))
                {//后跟字母或数字
                    token[count++] = resourceProject[pProject];//收集
                    pProject++;//下移
                }//多读了一个字符既是下次将要开始的指针位置
                token[count] = '\0';
                syn = searchReserve(reserveWord, token);//查表找到种别码
                if (syn == -1)
                {//若不是保留字则是标识符
                    syn = 100;//标识符种别码
                }
                return;
            }
            else if (Char.IsDigit(resourceProject[pProject]))
            {//首字符为数字
                while (Char.IsDigit(resourceProject[pProject]))
                {//后跟数字
                    token[count++] = resourceProject[pProject];//收集
                    pProject++;
                }//多读了一个字符既是下次将要开始的指针位置
                token[count] = '\0';
                syn = 99;//常数种别码
            }
            else if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == ';' || ch == '(' || ch == ')' || ch == '^'
                || ch == ',' || ch == '\"' || ch == '\'' || ch == '~' || ch == '#' || ch == '%' || ch == '['
                || ch == ']' || ch == '{' || ch == '}' || ch == '\\' || ch == '.' || ch == ':')
            {//若为运算符或者界符，查表得到结果////////|| ch == '\?'
                token[0] = resourceProject[pProject];
                token[1] = '\0';//形成单字符串
                for (i = 0; i < 36; i++)
                {//查运算符界符表
                    if (strcmp(token, operatorOrDelimiter[i]) == 0)
                    {
                        syn = 33 + i;//获得种别码，使用了一点技巧，使之呈线性映射
                        break;//查到即推出
                    }
                }
                pProject++;//指针下移，为下一扫描做准备
                return;
            }
            else if (resourceProject[pProject] == '<')
            {//<,<=,<<
                pProject++;//后移，超前搜索
                if (resourceProject[pProject] == '=')
                {
                    syn = 38;
                }
                else if (resourceProject[pProject] == '<')
                {//左移
                    pProject--;
                    syn = 58;
                }
                else
                {
                    pProject--;
                    syn = 37;
                }
                pProject++;//指针下移
                return;
            }
            else if (resourceProject[pProject] == '>')
            {//>,>=,>>
                pProject++;
                if (resourceProject[pProject] == '=')
                {
                    syn = 40;
                }
                else if (resourceProject[pProject] == '>')
                {
                    syn = 59;
                }
                else
                {
                    pProject--;
                    syn = 39;
                }
                pProject++;
                return;
            }
            else if (resourceProject[pProject] == '=')
            {//=.==
                pProject++;
                if (resourceProject[pProject] == '=')
                {
                    syn = 42;
                }
                else
                {
                    pProject--;
                    syn = 41;
                }
                pProject++;
                return;
            }
            else if (resourceProject[pProject] == '!')
            {//!,!=
                pProject++;
                if (resourceProject[pProject] == '=')
                {
                    syn = 43;
                }
                else
                {
                    syn = 68;
                    pProject--;
                }
                pProject++;
                return;
            }
            else if (resourceProject[pProject] == '&')
            {//&,&&
                pProject++;
                if (resourceProject[pProject] == '&')
                {
                    syn = 53;
                }
                else
                {
                    pProject--;
                    syn = 52;
                }
                pProject++;
                return;
            }
            else if (resourceProject[pProject] == '|')
            {//|,||
                pProject++;
                if (resourceProject[pProject] == '|')
                {
                    syn = 55;
                }
                else
                {
                    pProject--;
                    syn = 54;
                }
                pProject++;
                return;
            }
            else if (resourceProject[pProject] == '$')
            {//结束符
                syn = 0;//种别码为0
            }
            else
            {//不能被以上词法分析识别，则出错。
                string strMsg = string.Format("出错：字符[{3}]处分析出错。在行:[{0}].第:[{1}]处。({2})",
                   0, pProject, clsStackTrace.GetCurrClassFunction(), ch);
                Console.WriteLine(strMsg);
                throw new Exception(strMsg);




                return;
            }
        }

        //private void Scanner(char[] resourceProject)
        //{//根据DFA的状态转换图设计
        //    char[] token = new char[100];
        //    char[] chStringConst = new char[10000];
        //    string strWord = "";
        //    int syn = -1;
        //    int pProject = 0;
        //    int iLen = resourceProject.Length;
        //    int i, count = 0;//count用来做token的指示器，收集有用字符
        //    char ch;//作为判断使用

        //    while (true)
        //    {
        //        if (pProject >= iLen) break;
        //        ch = resourceProject[pProject];
        //        count = 0;
        //        while (ch == ' ')
        //        {//过滤空格，防止程序因识别不了空格而结束
        //            pProject++;
        //            if (pProject >= iLen) return;

        //            ch = resourceProject[pProject];
        //        }
        //        for (i = 0; i < 100; i++)
        //        {//每次收集前先清零
        //            token[i] = '\0';
        //        }
        //        if (Char.IsLetter(resourceProject[pProject]))
        //        {//开头为字母
        //            token[count++] = resourceProject[pProject];//收集
        //            pProject++;//下移
        //            while (Char.IsLetter(resourceProject[pProject])
        //                || Char.IsDigit(resourceProject[pProject])
        //                || resourceProject[pProject] == '.'
        //                || resourceProject[pProject] == '_')
        //            {//后跟字母或数字
        //                token[count++] = resourceProject[pProject];//收集
        //                pProject++;//下移
        //            }//多读了一个字符既是下次将要开始的指针位置
        //            token[count] = '\0';
        //            strWord = new string(token, 0, count);
        //            AddWordToList(strWord);
        //            continue;
        //            //syn = searchReserve(reserveWord, token);//查表找到种别码
        //            //if (syn == -1)
        //            //{//若不是保留字则是标识符
        //            //    syn = 100;//标识符种别码
        //            //}
        //            //return;
        //        }
        //        else if (Char.IsDigit(resourceProject[pProject]))
        //        {//首字符为数字
        //            while (Char.IsDigit(resourceProject[pProject])
        //                || resourceProject[pProject] == '.'
        //                || resourceProject[pProject] == 'f')
        //            {//后跟数字
        //                token[count++] = resourceProject[pProject];//收集
        //                pProject++;
        //            }//多读了一个字符既是下次将要开始的指针位置
        //            token[count] = '\0';
        //            strWord = new string(token, 0, count);
        //            AddWordToList(strWord);
        //            continue;
        //            //                    syn = 99;//常数种别码
        //        }
        //        else if (ch == '"')
        //        {
        //            if (AccessStringConst(resourceProject, ref pProject) == true)
        //            {
        //                continue;
        //            }
        //            continue;
        //        }
        //        else if (ch == '@')
        //        {
        //            if (resourceProject[pProject + 1] == '"')
        //            {
        //                if (AccessStringConst(resourceProject, ref pProject) == true)
        //                {
        //                    continue;
        //                }
        //            }
        //            else
        //            {
        //                string strMsg = string.Format("出错：@处出错。在行:[{0}].第:[{1}]处。({2})",
        //                    0, pProject, clsStackTrace.GetCurrClassFunction());
        //                throw new Exception(strMsg);
        //            }
        //            continue;
        //        }
        //        else if (ch == '#')
        //        {
        //            if (AccessRegion(resourceProject, ref pProject) == true)
        //            {
        //                continue;
        //            }
        //            continue;
        //        }
        //        else if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == ';' || ch == '(' || ch == ')' || ch == '^'
        //            || ch == ',' || ch == '\"' || ch == '\'' || ch == '~' || ch == '#' || ch == '%' || ch == '['
        //            || ch == ']' || ch == '{' || ch == '}' || ch == '\\' || ch == '.' || ch == ':')
        //        {//若为运算符或者界符，查表得到结果////////|| ch == '\?'
        //            int pProject_Next = pProject + 1;
        //            token[0] = resourceProject[pProject];
        //            token[1] = resourceProject[pProject_Next];
        //            token[2] = '\0';//形成单字符串
        //            strWord = new string(token, 0, 2);
        //            if (IsCommunity_character(strWord) == true
        //                || IsOperator(strWord) == true)
        //            {
        //                AddWordToList(strWord);
        //                pProject++;
        //                pProject++;
        //                continue;
        //            }
        //            token[1] = '\0';//形成单字符串
        //            strWord = new String(token, 0, 1);
        //            if (IsCommunity_character(strWord) == true
        //                || IsOperator(strWord) == true)
        //            {
        //                AddWordToList(strWord);
        //                pProject++;

        //                continue;
        //            }
        //            //for (i = 0; i < 36; i++)
        //            //{//查运算符界符表
        //            //    if (strcmp(token, operatorOrDelimiter[i]) == 0)
        //            //    {
        //            //        syn = 33 + i;//获得种别码，使用了一点技巧，使之呈线性映射
        //            //        break;//查到即推出
        //            //    }
        //            //}
        //            //pProject++;//指针下移，为下一扫描做准备
        //            //return;
        //        }
        //        //else if (resourceProject[pProject] == '<')
        //        //{//<,<=,<<
        //        //    pProject++;//后移，超前搜索
        //        //    if (resourceProject[pProject] == '=')
        //        //    {
        //        //        syn = 38;
        //        //    }
        //        //    else if (resourceProject[pProject] == '<')
        //        //    {//左移
        //        //        pProject--;
        //        //        syn = 58;
        //        //    }
        //        //    else
        //        //    {
        //        //        pProject--;
        //        //        syn = 37;
        //        //    }
        //        //    pProject++;//指针下移
        //        //    return;
        //        //}
        //        //else if (resourceProject[pProject] == '>')
        //        //{//>,>=,>>
        //        //    pProject++;
        //        //    if (resourceProject[pProject] == '=')
        //        //    {
        //        //        syn = 40;
        //        //    }
        //        //    else if (resourceProject[pProject] == '>')
        //        //    {
        //        //        syn = 59;
        //        //    }
        //        //    else
        //        //    {
        //        //        pProject--;
        //        //        syn = 39;
        //        //    }
        //        //    pProject++;
        //        //    return;
        //        //}
        //        else if (resourceProject[pProject] == '='
        //            || resourceProject[pProject] == '|'
        //            || resourceProject[pProject] == '!'
        //            || resourceProject[pProject] == '&'
        //            || resourceProject[pProject] == '<'
        //            || resourceProject[pProject] == '>')
        //        {//=.==  //|,||  //!,!=  //&,&&

        //            int pProject_Next = pProject + 1;
        //            token[0] = resourceProject[pProject];
        //            token[1] = resourceProject[pProject_Next];
        //            token[2] = '\0';//形成单字符串
        //            strWord = new string(token, 0, 2);
        //            if (IsCommunity_character(strWord) == true
        //                || IsOperator(strWord) == true)
        //            {
        //                AddWordToList(strWord);
        //                pProject++;
        //                pProject++;
        //                continue;
        //            }
        //            token[1] = '\0';//形成单字符串
        //            strWord = new String(token, 0, 1);
        //            if (IsCommunity_character(strWord) == true
        //                || IsOperator(strWord) == true)
        //            {
        //                AddWordToList(strWord);
        //                pProject++;

        //                continue;
        //            }

        //            pProject++;
        //            if (resourceProject[pProject] == '=')
        //            {
        //                syn = 42;
        //            }
        //            else
        //            {
        //                pProject--;
        //                syn = 41;
        //            }
        //            pProject++;
        //            return;
        //        }
        //        //else if (resourceProject[pProject] == '!')
        //        //{//!,!=
        //        //    pProject++;
        //        //    if (resourceProject[pProject] == '=')
        //        //    {
        //        //        syn = 43;
        //        //    }
        //        //    else
        //        //    {
        //        //        syn = 68;
        //        //        pProject--;
        //        //    }
        //        //    pProject++;
        //        //    return;
        //        //}
        //        //else if (resourceProject[pProject] == '&')
        //        //{//&,&&
        //        //    pProject++;
        //        //    if (resourceProject[pProject] == '&')
        //        //    {
        //        //        syn = 53;
        //        //    }
        //        //    else
        //        //    {
        //        //        pProject--;
        //        //        syn = 52;
        //        //    }
        //        //    pProject++;
        //        //    return;
        //        //}
        //        //else if (resourceProject[pProject] == '|')
        //        //{//|,||
        //        //    pProject++;
        //        //    if (resourceProject[pProject] == '|')
        //        //    {
        //        //        syn = 55;
        //        //    }
        //        //    else
        //        //    {
        //        //        pProject--;
        //        //        syn = 54;
        //        //    }
        //        //    pProject++;
        //        //    return;
        //        //}
        //        else if (resourceProject[pProject] == '$')
        //        {//结束符
        //            syn = 0;//种别码为0
        //        }
        //        else
        //        {//不能被以上词法分析识别，则出错。
        //            string strMsg = string.Format("出错：字符[{3}]处分析出错。在行:[{0}].第:[{1}]处。({2})",
        //                       0, pProject, clsStackTrace.GetCurrClassFunction(), ch);
        //            Console.WriteLine(strMsg);
        //            throw new Exception(strMsg);

        //        }
        //    }
        //}
        private int strcmp(char[] chSS, string strTT)
        {
            char[] chTT = strTT.ToCharArray();
            int iLenS = chSS.Length;
            int iLenT = chTT.Length;
            int iLen = iLenS > iLenT ? iLenT : iLenS;
            for (int i = 0; i < iLen; i++)
            {
                if (chTT[i] > chSS[i]) return 1;
                else if (chTT[i] < chSS[i]) return -1;
            }
            if (iLenT == iLenS) return 0;
            if (iLenS > iLenT) return 1;
            return -1;
        }
        private int searchReserve(string[] reserveWord, char[] s)
        {
            int iLen = reserveWord.Length;
            for (int i = 0; i < iLen; i++)
            {
                if (strcmp(s, reserveWord[i]) == 0)
                {//若成功查找，则返回种别码
                    return i + 1;//返回种别码
                }
            }
            return -1;//否则返回-1，代表查找不成功，即为标识符
        }

        //private bool AccessStringConst(char[] resourceProject, ref int pProject)
        //{
        //    int count = 0;
        //    char[] chStringConst = new char[10000];
        //    for (int i = 0; i < 10000; i++)
        //    {//每次收集前先清零
        //        chStringConst[i] = '\0';
        //    }
        //    char ch = resourceProject[pProject];
        //    if (ch == '@')
        //    {
        //        chStringConst[count++] = resourceProject[pProject];//收集
        //        pProject++;//下移
        //    }

        //    chStringConst[count++] = resourceProject[pProject];//收集
        //    pProject++;//下移
        //    bool bolIsHaveEscapedcharacters = false;
        //    while (true)
        //    {//后跟字母或数字
        //        char thisChar = resourceProject[pProject];
        //        char prevChar = resourceProject[pProject - 1];
        //        chStringConst[count++] = resourceProject[pProject];//收集
        //        if (thisChar == '\\')
        //        {
        //            if (bolIsHaveEscapedcharacters == false)
        //            {
        //                bolIsHaveEscapedcharacters = true;
        //            }
        //            else
        //            {
        //                bolIsHaveEscapedcharacters = false;
        //            }
        //        }
        //        if (thisChar == '"')
        //        {
        //            if (bolIsHaveEscapedcharacters == true)
        //            {
        //                pProject++;//下移
        //                bolIsHaveEscapedcharacters = false;
        //            }
        //            else
        //            {
        //                pProject++;//下移
        //                break;
        //            }
        //        }
        //        pProject++;
        //    }//多读了一个字符既是下次将要开始的指针位置
        //    chStringConst[count] = '\0';
        //    string strWord = new string(chStringConst, 0, count);
        //    AddWordToList(strWord, "常量", 2);
        //    return true;
        //}
        //private bool AccessRegion(char[] resourceProject, ref int pProject)
        //{
        //    int count = 0;
        //    char[] chStringConst = new char[1000];
        //    for (int i = 0; i < 1000; i++)
        //    {//每次收集前先清零
        //        chStringConst[i] = '\0';
        //    }


        //    chStringConst[count++] = resourceProject[pProject];//收集
        //    pProject++;//下移

        //    while (true)
        //    {//后跟字母或数字
        //        char thisChar = resourceProject[pProject];
        //        char prevChar = resourceProject[pProject - 1];
        //        chStringConst[count++] = resourceProject[pProject];//收集
        //        //"\r\n"
        //        if (thisChar == '\n' && prevChar == '\r')
        //        {
        //            pProject++;
        //            break;
        //        }
        //        if (thisChar == '\n')
        //        {
        //            string ss = "";
        //        }
        //        if (thisChar == '\r')
        //        {
        //            string ss1 = "";
        //        }
        //        if (count >= 999)
        //        {
        //            string strMsg = string.Format("出错：#处出错。在行:[{0}].第:[{1}]处。({2})",
        //                 0, pProject, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(strMsg);
        //        }
        //        pProject++;
        //    }//多读了一个字符既是下次将要开始的指针位置
        //    chStringConst[count] = '\0';
        //    string strWord = new string(chStringConst, 0, count);
        //    AddWordToList(strWord, "区域", 13);
        //    return true;
        //}

    }
}
