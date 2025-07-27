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
    public partial class frmLexicalAnalysisV2 : Form
    {
        private static string[] 保留字1 ={"bool","break","case","char","do","double","else",
        "false","float","for","if","int","long","main","new","null","private","protected","public",
        "static","true","try","typeof","unit","void","while","return","short","sizeof","switch"
        };
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
        "<<=",">>=","="};
        //界符运算符表,根据需要可以自行增加//我去除：,"\?"
        private static string[] operatorOrDelimiter ={
"+","-","*","/","<","<=",">",">=","=","==",
"!=",";","(",")","^",",","\"","\'","#","&",
"&&","|","||","%","~","<<",">>","[","]","{",
"}","\\",".",":","!"
};
        private static string[] 界符1 = { ",", ";", ".", "'", "(", ")", ":", "[", "]", "{", "}", "/" };
        private static string[] Delimiter = { ",", ";", ".", "'", "(", ")", ":", "[", "]", "{", "}", "/" };
        private static string[] UserClassTbl;

        private static string[] IDentifierTbl;
        private static string[] 常数;
        private static string[] 未知符号;

        //        static char IDentifierTbl[1000][50]={""};//标识符表
        //char resourceProject[10000];//输入的源程序存放处，最大可以存放10000个字符。
        //        char token[20] = { 0 };//每次扫描的时候存储已经扫描的结果。
        //        int syn = -1;//syn即为种别码，约定‘$’的种别码为0，为整个源程序的结束符号一旦扫描到这个字符代表扫描结束
        //        int pProject = 0;//源程序指针，始终指向当前源程序待扫描位置。
        private ArrayList temp = new ArrayList();

        public frmLexicalAnalysisV2()
        {
            InitializeComponent();
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
            }
            for (int i = 0; i < sstrLine.Length; i++)
            {
                sstrLine[i] = sstrLine[i].Replace(";", " ;");
                sstrLine[i] = sstrLine[i].Replace("(", " ( ");
                sstrLine[i] = sstrLine[i].Replace(")", " ) ");

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

        /// <summary>
        /// 词法分析
        /// </summary>
        /// <param name="strCode_In">输入的代码，分析前的代码</param>
        /// <param name="strCode_Out">输出的代码，已经分析后生成的代码</param>
        void analyze(string strCode_In, ref string strCode_Out)
        {

            string[] sstrWord1 = strCode_In.Split(new char[] { ' ' });
            List<clsWord_LA> arrWord = new List<clsWord_LA>();
            foreach (string strWord in sstrWord1)
            {
                clsWord_LA objWord_LA = new clsWord_LA(strWord);
                arrWord.Add(objWord_LA);
            }
            for (int i = 0; i < arrWord.Count - 1; i++)
            {
                clsWord_LA objWord_Curr = arrWord[i];
                int intType = liexingpanduan(objWord_Curr);
                if (intType == 5 && i > 0)
                {
                    clsWord_LA objWord_Prev = arrWord[i - 1];
                    if (objWord_Prev.Word == "class")
                    {
                        objWord_Curr.WordType = "用户类";
                        intType = 7;
                    }
                    else if (objWord_Prev.WordType == "保留字")
                    {
                        objWord_Curr.WordType = "标识符";
                        intType = 1;
                    }
                }
                switch (intType)
                {
                    case 0:
                        strCode_Out += "( " + arrWord[i].Word + "," + "保留字," + Search_Location(arrWord[i], reserveWord) + " )" + '\r' + '\n';
                        break;
                    case 1:
                        strCode_Out += "( " + arrWord[i].Word + "," + "标识符," + InsertId(arrWord[i], ref IDentifierTbl) + " )" + '\r' + '\n';
                        break;
                    case 2:
                        strCode_Out += "( " + arrWord[i].Word + "," + "常数," + InsertId(arrWord[i], ref 常数) + " )" + '\r' + '\n';
                        break;
                    case 3:
                        strCode_Out += "( " + arrWord[i].Word + "," + "运算符," + Search_Location(arrWord[i], operators) + " )" + '\r' + '\n';
                        break;
                    case 4:
                        strCode_Out += "( " + arrWord[i].Word + "," + "界符," + Search_Location(arrWord[i], Delimiter) + " )" + '\r' + '\n';
                        break;
                    case 5:
                        strCode_Out += "( " + arrWord[i].Word + "," + "未知符号," + InsertId(arrWord[i], ref 未知符号) + " )" + '\r' + '\n';
                        break;
                    case 6:
                        strCode_Out += "( " + arrWord[i].Word + "," + "域名," + Search_Location(arrWord[i], NameSpaces) + " )" + '\r' + '\n';
                        break;
                    case 7:
                        strCode_Out += "( " + arrWord[i].Word + "," + "用户类," + InsertId(arrWord[i], ref UserClassTbl) + " )" + '\r' + '\n';
                        break;
                }
            }
        }
        /// <summary>
        /// 类型判断liexingpanduan
        /// </summary>
        /// <param name="strWord">分解后一个词</param>
        /// <returns></returns>
        private int liexingpanduan(clsWord_LA objWord)
        {
            if (objWord == null)
                return -1;
            char a = objWord.Word[0];
            //            str = str.TrimEnd(';');
            if (char.IsLetter(a))  //首个字符为字母，则可能为保留字/标识符，也可能是未知字符
            {
                int i = 0;
                for (int k = 0; k < reserveWord.Length; k++)
                    if (objWord.Word == reserveWord[k])
                    {
                        objWord.WordType = "保留字";
                        return 0;//保留字
                    }
                for (int k = 0; k < NameSpaces.Length; k++)
                    if (objWord.Word == NameSpaces[k])
                    {
                        objWord.WordType = "域名";
                        return 6;//域名
                    }
                if (IDentifierTbl != null)
                {
                    for (int k = 0; k < IDentifierTbl.Length; k++)
                        if (objWord.Word == IDentifierTbl[k])
                        {
                            objWord.WordType = "标识符";
                            return 1;//域名
                        }
                }
                for (i = 0; i < objWord.Word.Length; i++)
                    if (char.IsLetterOrDigit(objWord.Word[i]) == false)
                    {
                        objWord.WordType = "未知符号";
                        return 5;//未知符号
                    }
                if (i >= objWord.Word.Length)
                {
                    objWord.WordType = "未知";
                    return 7;//未知   
                }
            }
            else if (char.IsDigit(a))//首个字符为数字，则可能为数字也可能为未知字符
            {
                int j = 0;
                for (j = 0; j < objWord.Word.Length; j++)
                    if (char.IsDigit(objWord.Word[j]) == false)
                        return 5;//未知符号
                if (j >= objWord.Word.Length)
                    return 2; //常数
            }
            else//首个字符不是字母/数字，则可能是运算符/界符或未知字符
            {
                if (IsOperator(objWord.Word))
                    return 3;//运算符
                if (IsCommunity_character(objWord.Word))
                    return 4;//界符                  
            }
            return 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string textbox1text = textBox1.Text;
            if (textbox1text == "")
            {
                MessageBox.Show("您没有输入任何字符！");
                return;
            }
            textbox1text = Pretreatment();
            string textbox2text = null;
            analyze(textbox1text, ref textbox2text);
            textBox2.Text = textbox2text;
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

        private void Scanner(ref int syn, char[] resourceProject, char[] token, ref int pProject)
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
                string strMsg = string.Format("error：there is no exist {0} \n", ch);
                Console.WriteLine(strMsg);

                return;
            }
        }
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
                if (strcmp( s, reserveWord[i]) == 0)
                {//若成功查找，则返回种别码
                    return i + 1;//返回种别码
                }
            }
            return -1;//否则返回-1，代表查找不成功，即为标识符
        }

    }
}
