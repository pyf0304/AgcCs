using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicCompilerWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.lexicalAnalysis;

namespace DynamicCompilerWin.Tests
{
    [TestClass()]
    public class clsLexicalAnalysis4SqlTests
    {
        [TestMethod()]
        public void getWordLstTest()
        {
            string strText = "select * from xs where (ss='1 or' and dd=2) or(dd=1 and ee=4)";
            List<clsWord_LA> arrResultWord = clsLexicalAnalysis4Sql.getWordLst(strText);
            //            Assert.Fail();
            foreach (clsWord_LA objWord_LA in arrResultWord)
            {
                Console.WriteLine(objWord_LA.Word);
                //                lbWords.Items.Add(objWord_LA.Word);
            }
        }
    }
}