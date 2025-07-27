
using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrjCommBase;


namespace MyProject.Tests
{
    [TestClass]
    public class SqlJoinHelperTests
    {
        private clsSortLinkStrParse helper;

        [TestInitialize]
        public void Setup()
        {
            helper = new clsSortLinkStrParse();
        }

        [TestMethod]
        public void BuildLeftJoinClause_ShouldReturnCorrectJoinSql()
        {
            // Arrange
            var tables = new List<string> { "GCDefaConstants", "DataTypeAbbr" };
            var conditions = new List<string>
            {
                "GCConstantPrjIdRela.ConstId = GCDefaConstants.ConstId",
                "GCDefaConstants.DataTypeId = DataTypeAbbr.DataTypeId"
            };

            var expected =
                "LEFT JOIN GCDefaConstants ON GCConstantPrjIdRela.ConstId = GCDefaConstants.ConstId\r\n" +
                "LEFT JOIN DataTypeAbbr ON GCDefaConstants.DataTypeId = DataTypeAbbr.DataTypeId\r\n";

            // Act
            var actual = clsSortLinkStrParse.BuildLeftJoinClause(tables, conditions);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void BuildLeftJoinClause_ShouldReturnCorrectJoinSql2()
        {
            // Arrange
            var tables = new List<string> { "GCDefaConstants", "DataTypeAbbr" };
            var conditions = new List<string>
            {
                "GCConstantPrjIdRela.ConstId = GCDefaConstants.ConstId",
                "GCDefaConstants.DataTypeId = DataTypeAbbr.DataTypeId"
            };

            var expected =
                "LEFT JOIN GCDefaConstants ON GCConstantPrjIdRela.ConstId = GCDefaConstants.ConstId\r\n" +
                "LEFT JOIN DataTypeAbbr ON GCDefaConstants.DataTypeId = DataTypeAbbr.DataTypeId\r\n";

            // Act
            var actual = clsSortLinkStrParse.BuildLeftJoinClause2(tables, conditions);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BuildLeftJoinClause_ShouldThrowException_WhenCountsMismatch()
        {
            // Arrange
            var tables = new List<string> { "OnlyOneTable" };
            var conditions = new List<string> { "T1.Id = T2.Id", "T2.Id = T3.Id" };

            // Act
            clsSortLinkStrParse.BuildLeftJoinClause(tables, conditions);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BuildLeftJoinClause_ShouldThrowException_WhenNullInput()
        {
            // Act
            clsSortLinkStrParse.BuildLeftJoinClause(null, null);
        }
    }
}

