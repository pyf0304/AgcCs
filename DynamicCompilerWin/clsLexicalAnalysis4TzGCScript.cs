using com.taishsoft.common;
using com.taishsoft.lexicalAnalysis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicCompilerWin
{
    public class clsLexicalAnalysis4TzGCScript : clsLexicalAnalysisBase
    {
        private static string[] sstrSystemType ={"var", "function" };
        private static string[] sstrReserveWord ={"abstract","as","base","bool","break","byte","case","catch","char","checked",
        "class","const","continue","decimal","default","do","double","else","enum","event",
        "explicit","extern","false","finally","fixed","float","for","foreach","goto","if",
        "implicit","in","in（泛型修饰符）","int","interface","internal","为","lock","long",
        "命名空间","namespace","new","null","object","operator","out","out（泛型修饰符）","override",
        "params","private","protected","public","readonly","ref","return","sbyte","sealed",
        "short","sizeof","stackalloc","static","string","结构","struct", "switch","this","throw","true",
        "try","typeof","uint","ulong","unchecked","unsafe","ushort","using","virtual","void",
        "volatile","while","function","PR","$","@"};
        private static string[] sstrSystemVariable = { "arguments" };
        private static string[] sstrSystemObjectProperty = { "length","value" };
        private static string[] sstrOperators ={"*","/","%","+","-","<<",">>",
            "<",">","<=",">=",
        "==","!=","&","^","|","&&","||","?", "?:","+=","-=","*=","/=","%=","&=","|=","^=",
        "<<=",">>=","=","++","--"};
        public clsLexicalAnalysis4TzGCScript(string strCode_In) :base(strCode_In)
        {
            arrSystemType = new List<string>(sstrSystemType);
            arrReserveWord = new List<string>(sstrReserveWord);
            arrSystemVariableTbl = new List<string>(sstrSystemVariable);
            arrSystemObjectProperty = new List<string>(sstrSystemObjectProperty);
            arrOperators = new List<string>(sstrOperators);
            this.esCurrStatus = tzEnvirmentStatus.CodeConst;
        }
        protected override void fnAccessFirstCharIsLetter(char chCurrChar)
        {
            string strWord = "";
            char[] token = new char[100];
            int i, count = 0;//count用来做token的指示器，收集有用字符
            char ch;
            token[count++] = chCurrChar;//收集
            pProject++;//下移
            ch = GetCurrChar();
            while (Char.IsLetter(ch)
                || Char.IsDigit(ch)
                //|| resourceProject[pProject] == '.'
                || ch == '_')
            {//后跟字母或数字
                token[count++] = ch;//收集
                if (count == 3)
                {
                    if (token[0]=='P' && token[1]=='R' && token[2]==' ')
                    {
                        strWord = "PR";
                        fnAddWordToList(strWord);
                        char[] chConstLst = new char[1000];                     
                        count = 0;
                        while (pProject< mintCodeLen)
                        {
                            chConstLst[count++] = ch;
                            pProject++;
                            ch = GetCurrChar();
                        }
                        strWord = new string(chConstLst, 0, count);
                        fnAddWordToList(strWord, "常量", tzWordType.Const );
                        return;
                    }
                }
                pProject++;//下移
                ch = GetCurrChar();
            }//多读了一个字符既是下次将要开始的指针位置
            token[count] = '\0';
            strWord = new string(token, 0, count);
            if (strWord .Equals("PR", StringComparison.InvariantCultureIgnoreCase) == true)
            {
                fnAddWordToList(strWord, "保留字", tzWordType.ReserveWord);
                char[] chConstLst = new char[1000];
                count = 0;
                while (ch != '\r' && pProject < mintCodeLen)
                {
                    chConstLst[count++] = ch;
                    pProject++;
                    ch = GetCurrChar();
                }
                strWord = new string(chConstLst, 0, count);
                fnAddWordToList(strWord, "常量", tzWordType.Const);
                return;
            }
         else
            {
                fnAddWordToList(strWord);
            }
        }
        /// <summary>
        /// 预处理
        /// </summary>
        /// <returns></returns>
        public virtual string fnPretreatment()       //预处理
        {
            string strCode_In = Code_In;// textBox1.Text;
            string strCode_out = null;
            //去除换行和//注释
            string[] sstrLine = CodeLines;// textBox1.Lines;
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
        /// 处理字符@
        /// </summary>
        /// <returns></returns>
        protected override bool fnAccessLetterAt()
        {
            string strWord = "@";
            fnAddWordToList(strWord, "保留字", tzWordType.ReserveWord);
            pProject++;
            this.esCurrStatus = tzEnvirmentStatus.CodeScript;
            return true;
        }

        protected override void fnAccessCodeConst()
        {
            char ch = GetCurrChar();
            if (ch == '@')
            {
                fnAccessLetterAt();
                return;
            }
            char char_Next;
            int count = 0;
            char[] chStringConst = new char[10000];
            string strWord;
            tzFirstCharType fctFirstCharType = fnGetCharTypeByFirstChar(ch);
            switch (fctFirstCharType)
            {
                case tzFirstCharType.IsEmptyReturn:

                    while (ch == ' ' || ch == '\n' || ch == '\r' || ch == '\t')
                    {//过滤空格，防止程序因识别不了空格而结束
                        pProject++;
                        if (pProject >= mintCodeLen) break;
                        ch = GetCurrChar();
                    }
                    break;
                case tzFirstCharType.Slash:// "/"

                    char_Next = GetNextChar();
                    switch (char_Next)
                    {
                        case '/':
                            pProject++;
                            while (ch != '\n' && ch != '\r')
                            {//过滤//后面的注释
                                pProject++;
                                if (pProject >= mintCodeLen) break;
                                ch = GetCurrChar();
                            }
                            pProject++;
                            ch = GetCurrChar();
                            if (ch == '\r' || ch == '\n')
                            {
                                pProject++;
                            }
                            break;
                        case '*'://出现了"/*", 查找"*/",去除之间的部分
                            while (true)
                            {//过滤//后面的注释
                                pProject++;
                                if (pProject >= mintCodeLen) break;
                                ch = GetCurrChar();

                                char_Next = GetNextChar();
                                if (ch == '*' && char_Next == '/')
                                {
                                    //找到了"*/"
                                    pProject++;//这是"/"的位置
                                    pProject++;//这是下个字符的位置
                                    break;
                                }
                            }

                            break;
                      
                        default:
                            chStringConst[count++] = ch;//收集
                            pProject++;//下移
                            ch = GetCurrChar();                      
                            while (ch !='\r')
                            {//后跟字母或数字
                                char thisChar = ch;
                                char prevChar = GetPrevChar();
                                chStringConst[count++] = ch;//收集
                                pProject++;
                                ch = GetCurrChar();
                            }//多读了一个字符既是下次将要开始的指针位置
                            chStringConst[count] = '\0';
                            strWord = new string(chStringConst, 0, count);
                            fnAddWordToList(strWord, "代码常量", tzWordType.CodeConst);
                            return ;                          
                    }
                    break;
                default:
                    chStringConst[count++] = ch;//收集
                    pProject++;//下移
                    ch = GetCurrChar();
                    bool bolIsHaveEscapedcharacters = false;
                    while (ch != '\r')
                    {//后跟字母或数字
                        char thisChar = ch;
                        char prevChar = GetPrevChar();
                        chStringConst[count++] = ch;//收集
                        pProject++;
                        ch = GetCurrChar();
                    }//多读了一个字符既是下次将要开始的指针位置
                    chStringConst[count] = '\0';
                    strWord = new string(chStringConst, 0, count);
                    fnAddWordToList(strWord, "代码常量", tzWordType.CodeConst);
                    return;          
            }
        }

        protected override void fnAccessDelimiter()
        {
            char[] token = new char[100];
            char ch;//作为判断使用
            string strWord = "";
            ch = GetCurrChar();
            if (ch == '{')
            {
                stkMate.Push('{');
                strWord = "{";
                fnAddWordToList(strWord, "分隔符", tzWordType.Delimiter);
                pProject++;
                return;            
            }
            else if (ch == '}')
            {
                char chTop = stkMate.Peek();
                if (chTop == '{')
                {
                    stkMate.Pop();
                }
                if (stkMate.Count == 0)
                {
                    esCurrStatus = tzEnvirmentStatus.CodeConst;
                    strWord = "}";
                    fnAddWordToList(strWord, "分隔符", tzWordType.Delimiter);
                    pProject++;
                    return;
                }                
            }
            token[0] = ch;
            token[1] = GetNextChar();
            token[2] = '\0';//形成单字符串
            strWord = new string(token, 0, 2);
            if (IsCommunity_character(strWord) == true
                || IsOperator(strWord) == true)
            {
                fnAddWordToList(strWord);
                pProject++;
                pProject++;
                return;
            }
            token[1] = '\0';//形成单字符串
            strWord = new String(token, 0, 1);
            if (IsCommunity_character(strWord) == true
                || IsOperator(strWord) == true)
            {
                fnAddWordToList(strWord);
                pProject++;
                return;
            }

        }


    }
}
