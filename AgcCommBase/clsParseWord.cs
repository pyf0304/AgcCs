using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgcCommBase
{
    public class clsParseWord
    {
        public static List<string> ParseFuncNameIntoWord(string strFuncName)
        {
            List<string> arrWord = new List<string>();
            int intLen = strFuncName.Length;
            char[] arrChar = strFuncName.ToCharArray();
            int i = 0;
            List<int> arrPos = new List<int>();
            int intLastPos = 0;
            while ( i<intLen)
            {
                char c = arrChar[i];
                if (char.IsUpper(c))
                {
                    if (i == 0)
                    {
                        arrPos.Add(i);
                        intLastPos = i;
                    }
                    else if (i > 0)
                    {
                        char chrPrev = arrChar[i - 1];

                        if (char.IsUpper(chrPrev))
                        {
                        }
                        else
                        {
                            arrPos.Add(i);
                            intLastPos = i;
                        }              
                    }
                    else
                    {
                        //intLastPos = i;
                        char chrPrev = arrChar[i - 1];
                        if (new List<char>() { '_', '#', ' ', ':' }.Contains(chrPrev))
                        {
                            arrPos.Add(i);
                        }
                    }
                }
                else if (char.IsLower(c))
                {
                    if (i > 0)
                    {
                        char chrPrev = arrChar[i-1];
                        if (new List<char>() { '_', '#', ' ', ':' }.Contains( chrPrev))
                        {
                            arrPos.Add(i);
                        }
                    }
                }
                else if (c == '_' || c == ':' || c == '#' || c == ' ')
                {
                    arrPos.Add(i);
                }
                else if (c == '4')
                {
                    arrPos.Add(i);
                }
                else if (i==0)
                {
                    arrPos.Add(i);
                }
                else
                {
            //        arrPos.Add(i);
            if (char.IsHighSurrogate(c))
                    {
                        char ss = c;
                    }
                }
                i++;
            }
            string strWord = "";
            int intNextPos = 0;
           


            i = 0;
            while (i < arrPos.Count)
            {
                int intCurrPos = arrPos[i];
                if (i == arrPos.Count -1)
                {
                    strWord = strFuncName.Substring(intCurrPos);
                    arrWord.Add(strWord.Trim());
                    break;
                }
                intNextPos = arrPos[i + 1];
                 strWord = strFuncName.Substring(intCurrPos, intNextPos - intCurrPos);
                arrWord.Add(strWord.Trim());
                i++;
            }
            i = 0;
            while (i < arrWord.Count)
            {
        
                if (arrWord[i] == "4")
                {
                    
                    string strWord_Prev = arrWord[i-1];
                    if (strWord_Prev == "Neo")
                    {
                        if (i < arrWord.Count - 1)
                        {
                            string strWord_Next = arrWord[i + 1];
                            if (strWord_Next == "J")
                            {
                                arrWord[i-1] = "Neo4J";
                                arrWord.RemoveAt(i + 1);
                                arrWord.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }

                i++;
            }
            return arrWord;
        }

        public static int CalcDistance(string strA, string strB)
        {
            if (strA.Length != strB.Length) return 0;
            char[] arrCharA = strA.ToCharArray();
            char[] arrCharB = strB.ToCharArray();
            int intLen = strA.Length;
            int intDistance = 0;
            for (int i = 0; i < intLen; i++)
            {
                if (arrCharA[i] != arrCharB[i]) intDistance++;
            }
            return intDistance;
        }
    }
}
