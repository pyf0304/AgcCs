using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGC.BusinessLogicEx;

namespace AGC.BusinessLogicEx.Tests
{
    [TestClass]
    public class clsFileResourceBLEx_FileTypeTests
    {
        private const string PrjId = "0005";

        /// <summary>
        /// 核心验证：同名规则，.cs 应识别为 C# 实体层（0001）
        /// </summary>
        [TestMethod]
        public void GetFileTypeInfoByFileName_EntityCs_ShouldBe_0001()
        {
            var ret = clsFileResourceBLEx.GetFileTypeInfoByFileName("clsAssociationMappingEN.cs", PrjId);

            Assert.IsNotNull(ret);
            Assert.AreEqual("0001", ret.CodeTypeId, "cls{0}EN.cs 应匹配 0001(实体层CS)");
        }

        /// <summary>
        /// 核心验证：同名规则，.ts 应识别为 TS 实体层（0121）
        /// </summary>
        [TestMethod]
        public void GetFileTypeInfoByFileName_EntityTs_ShouldBe_0121()
        {
            var ret = clsFileResourceBLEx.GetFileTypeInfoByFileName("clsAssociationMappingEN.ts", PrjId);

            Assert.IsNotNull(ret);
            Assert.AreEqual("0121", ret.CodeTypeId, "cls{0}EN.ts 应匹配 0121(实体层TS)");
        }

        /// <summary>
        /// 回归验证：同基名 .cs / .ts 不能落到同一个 CodeTypeId
        /// </summary>
        [TestMethod]
        public void GetFileTypeInfoByFileName_CsVsTs_ShouldBeDifferentCodeType()
        {
            var retCs = clsFileResourceBLEx.GetFileTypeInfoByFileName("clsAssociationMappingEN.cs", PrjId);
            var retTs = clsFileResourceBLEx.GetFileTypeInfoByFileName("clsAssociationMappingEN.ts", PrjId);

            Assert.IsNotNull(retCs);
            Assert.IsNotNull(retTs);
            Assert.AreNotEqual(retCs.CodeTypeId, retTs.CodeTypeId, "同名不同扩展名应区分 CodeTypeId");
        }

        /// <summary>
        /// 额外验证：WApi TS 文件应匹配 0155
        /// </summary>
        [TestMethod]
        public void GetFileTypeInfoByFileName_WApiTs_ShouldBe_0155()
        {
            var ret = clsFileResourceBLEx.GetFileTypeInfoByFileName("clsAssociationMappingWApi.ts", PrjId);

            Assert.IsNotNull(ret);
            Assert.AreEqual("0155", ret.CodeTypeId, "cls{0}WApi.ts 应匹配 0155");
        }

        /// <summary>
        /// 未知文件应回落到 0000
        /// </summary>
        [TestMethod]
        public void GetFileTypeInfoByFileName_Unknown_ShouldBe_0000()
        {
            var ret = clsFileResourceBLEx.GetFileTypeInfoByFileName("NotExists_Whatever_123.xyz", PrjId);

            Assert.IsNotNull(ret);
            Assert.AreEqual("0000", ret.CodeTypeId, "未知文件应回落到 0000");
        }
    }
}