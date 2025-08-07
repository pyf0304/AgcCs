using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DDW.CodeGenOpt;

namespace DDW.CodeGenOpt.Tests
{
    [TestClass]
    public class RoslynFunctionExtractorTests
    {
        [TestMethod]
        public void ExtractMethod_ShouldPrintMethod_WhenMethodExists()
        {
            // Arrange
            string tempFile = Path.GetTempFileName();
            string code = @"
                using System;
                public class TestClass
                {
                    public void MyFunction()
                    {
                        Console.WriteLine(""Hello"");
                    }
                }
            ";
            
            File.WriteAllText(tempFile, code);
            string path = @"E:\AspNet2024\AGCV2\PrjCommBase\clsSortLinkStrParse.cs";
            ////            RoslynFunctionExtractor.ExtractMethod(path, "BuildLeftJoinClause");
            ////        }
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                RoslynFunctionExtractor.ExtractMethod(path, "BuildLeftJoinClause");

                // Assert
                string output = sw.ToString();
                Assert.IsTrue(output.Contains("BuildLeftJoinClause"));
                Assert.IsTrue(output.Contains("joinTables"));
            }

            File.Delete(tempFile);
        }

        [TestMethod]
        public void ExtractMethod_ShouldPrintNotFound_WhenMethodDoesNotExist()
        {
            // Arrange
            string tempFile = Path.GetTempFileName();
            string code = @"
                public class TestClass
                {
                    public void AnotherFunction() { }
                }
            ";
            File.WriteAllText(tempFile, code);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                RoslynFunctionExtractor.ExtractMethod(tempFile, "MyFunction");

                // Assert
                string output = sw.ToString();
                Assert.IsTrue(output.Contains("未找到指定函数"));
            }

            File.Delete(tempFile);
        }
    }
}
//namespace UnitTestProject1
//{
//    [TestClass]
//    public class RoslynFunctionExtractorTest
//    {
//        [TestMethod]
//        static void TestFindFunc1()
//        {
//            string path = @"E:\AspNet2024\AGCV2\PrjCommBase\clsSortLinkStrParse.cs";
//            RoslynFunctionExtractor.ExtractMethod(path, "BuildLeftJoinClause");
//        }
//    }
//}
