using System;
using System.IO;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DDW.CodeGenOpt;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DDW.CodeGenOpt.Tests
{
    [TestClass]
    public class MethodBodyReplacerTests
    {
        [TestMethod]
        public void ReplaceMethodBody_ShouldReplaceTargetMethodBody()
        {
            // Arrange
            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);

            string targetFile = Path.Combine(tempDir, "Target.cs");
            string sourceFile = Path.Combine(tempDir, "Source.cs");
            string methodName = "MyFunction";

            string targetCode = @"
                using System;
                public class TestClass
                {
                    public void MyFunction()
                    {
                        Console.WriteLine(""Old Body"");
                    }
                }
            ";
            string sourceCode = @"
                using System;
                public class TestClass
                {
                    public void MyFunction()
                    {
                        Console.WriteLine(""New Body"");
                    }
                }
            ";

            File.WriteAllText(targetFile, targetCode);
            File.WriteAllText(sourceFile, sourceCode);

            // Act
            BlockSyntax newBody = MethodBodyReplacer.ExtractMethodBody(sourceFile, methodName);
            MethodBodyReplacer.ReplaceMethodBody(targetFile, methodName, newBody);

            // Assert
            string replacedCode = File.ReadAllText(targetFile);
            Assert.IsTrue(replacedCode.Contains("New Body"));
            Assert.IsFalse(replacedCode.Contains("Old Body"));

            // 清理
            File.Delete(targetFile);
            File.Delete(sourceFile);
            Directory.Delete(tempDir);
        }
        [TestMethod]
        public void ReplaceMethodBody_ShouldReplaceTargetMethodBody2()
        {
            // Arrange
            string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);

            //string targetFile = Path.Combine(tempDir, "Target.cs");
            string targetFile = @"E:\AspNet2024\AGCV2\PrjCommBase\Class1.cs";
            string sourceFile = @"E:\AspNet2024\AGCV2\PrjCommBase\B.cs";
            string methodName = "MyFunction";

            //string targetCode = @"
            //    using System;
            //    public class TestClass
            //    {
            //        public void MyFunction()
            //        {
            //            Console.WriteLine(""Old Body"");
            //        }
            //    }
            //";
            //string sourceCode = @"
            //    using System;
            //    public class TestClass
            //    {
            //        public void MyFunction()
            //        {
            //            Console.WriteLine(""New Body"");
            //        }
            //    }
            //";

            //File.WriteAllText(targetFile, targetCode);
            //File.WriteAllText(sourceFile, sourceCode);

            // Act
            BlockSyntax newBody = MethodBodyReplacer.ExtractMethodBody(sourceFile, methodName);
            MethodBodyReplacer.ReplaceMethodBody(targetFile, methodName, newBody);

            // Assert
            string replacedCode = File.ReadAllText(targetFile);
            Assert.IsTrue(replacedCode.Contains("New Body"));
            Assert.IsFalse(replacedCode.Contains("Old Body"));

            // 清理
            //File.Delete(targetFile);
            //File.Delete(sourceFile);
            //Directory.Delete(tempDir);
        }
    }
}
