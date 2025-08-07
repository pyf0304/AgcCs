using AGC.Entity;
using AutoGCLib.TzGCScript;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoGCLib
{
    public class clsTzGCScript
    {

        private static clsViewInfoENEx objViewInfoENEx = null;
        public clsTzGCScript(clsViewInfoENEx pobjViewInfoENEx)
        {
            objViewInfoENEx = pobjViewInfoENEx;
            InitVariableTab4ViewInfo();
        }
        public static string ExecFunction(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
        {
      
          
            StringBuilder sbCode_Out = new StringBuilder();
            string[] sstrCodeLine = objFunction4GeneCodeEN.FuncCode.Split('\n');
            int intLineNo = 0;
            int intLineNum_Ttl = sstrCodeLine.Length;
            while (intLineNo<intLineNum_Ttl)
            {
                string strLine = sstrCodeLine[intLineNo];
                strLine = strLine.TrimStart(' ');
                if (strLine.Substring(0, 1) == "@")
                {

                }
                else
                {
                    string strLine_Out = AccessLine(strLine);
                    sbCode_Out.Append(strLine_Out);
                    sbCode_Out.Append(Environment.NewLine);
                    intLineNo++;
                }
            }
            //char[] chCodeS = objFunction4GeneCodeEN.FuncCode.ToCharArray();

            return sbCode_Out.ToString();
        }
        private static string AccessLine(string strLine)
        {
            char[] chCodeT = new char[1000];
            //for (int i = 0; i < 1000; i++)
            //{
            //    chCodeT[i] = '\0';
            //}
            strLine = strLine.Replace("\r", "");
            strLine = strLine.Replace("\n", "");
            char[] chCodeS = strLine.ToCharArray();
            int intProject = 0;
            int intCount_Out = 0;
            char ch = chCodeS[intProject];
            while (true)
            {               
                switch (ch)
                {
                    case '#':
                        break;
                    default:
                        if (ch == '\\')
                        {
                            if (chCodeS[intProject + 1] == '(')
                            {
                                AccessInLineVar(chCodeS, chCodeT,
                                    ref intProject, ref intCount_Out);
                            }
                            else
                            {
                                chCodeT[intCount_Out++] = ch;
                                intProject++;
                            }
                        }
                        else
                        {
                            chCodeT[intCount_Out++] = ch;
                        }
                        break;
                }
                intProject++;
                if (intProject >= chCodeS.Length)
                {
                    string strLine_Out = new string(chCodeT, 0, intCount_Out);
                    return strLine_Out;
                }
                ch = chCodeS[intProject];
            }

        }

        private static bool AccessInLineVar(char[] chCodeS, char[] chCodeT, 
            ref int intProject, ref int intCount_Out)
        {
            string strMsg = "";
            char[] token = new char[100];
            int   intCount_Var = 0;
            intProject++;
            intProject++;

            while (chCodeS[intProject] != ')')
            {//后跟数字
                token[intCount_Var++] = chCodeS[intProject];//收集
                intProject++;
            }//多读了一个字符既是下次将要开始的指针位置
            string strVarName = new string(token, 0, intCount_Var);
            clsVariable objVar = clsVariableTab.GetVariableObj(strVarName);
            if (objVar == null)
            {
                strMsg = string.Format("变量名:[{0}]在变量表中不存在!({1})",
                   strVarName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strVarValue = objVar.VariableValue.ToString();
            Char[] chTempArr = strVarValue.ToCharArray();
            foreach (char chTemp in chTempArr)
            {
                chCodeT[intCount_Out++] = chTemp;
            }
            return true;
        }
        public bool InitVariableTab4ViewInfo()
        {
            clsVariableTab.AddVariable("@TabName", objViewInfoENEx.TabName);
            clsVariableTab.AddVariable("@TabCnName", objViewInfoENEx.objMainPrjTab.TabCnName);
            return true;
        }
    }
}
