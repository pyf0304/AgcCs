using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.common.Tests
{
    [TestClass()]
    public class clsCheckSqlTests
    {
        [TestMethod()]
        public void CheckStrSQL_strongTest()
        {
            string strWhere = "(ss='1 or' and dd=2) or(dd=1 and ee=4)";
            try
            {
                bool bolIsSuccess = clsCheckSql.CheckStrSQLV2(strWhere);
                Console.WriteLine(bolIsSuccess);
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                Console.WriteLine(strMsg);
                Assert.Fail();

            }
        }

        [TestMethod()]
        public void CheckStrSQL_WeakTest()
        {
            //            string strWhere = " (ss='1 or' and dd=2) or(dd=1 and ee=4)[Exclude]or [/Exclude]";
              string strWhere = " (ss='1 or' and dd=2) or ss in (select ss from ddd) (dd=1 and ee=4)[Exclude]or [/Exclude]";
            try
            {
                bool bolIsSuccess = clsCheckSql.CheckStrSQL_Weak(strWhere);
                Console.WriteLine(bolIsSuccess);
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                Console.WriteLine(strMsg);
                Assert.Fail();

            }
        }

        [TestMethod()]
        public void CheckSQL4FieldTest()
        {
            //      string strFieldValue = "'; or";
            //string strFieldValue = "'=AA select";
            //string strFieldValue = "'And; or";
            string strFieldValue = "'11 1aor";
            try
            {
                bool bolIsSuccess = clsCheckSql.CheckSqlInjection4Field(strFieldValue, "FieldName");
                Console.WriteLine(bolIsSuccess);
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                Console.WriteLine(strMsg);
                Assert.Fail();

            }
        }

        [TestMethod()]
        public void CheckStringLenTest()
        {
            //      string strFieldValue = "'; or";
            string strFieldValue = null;// "' select1";
            //string strFieldValue = "'; or";
            //string strFieldValue = "'; or";
            try
            {
                bool bolIsSuccess = clsCheckSql.CheckFieldLen(strFieldValue, 8, "AA");
                Console.WriteLine(bolIsSuccess);
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                Console.WriteLine(strMsg);
                Assert.Fail();

            }
        }

        [TestMethod()]
        public void CheckFieldForeignKeyTest()
        {
            //      string strFieldValue = "'; or";
            string strFieldValue = "' select";
            //string strFieldValue = "'; or";
            //string strFieldValue = "'; or";
            try
            {
                bool bolIsSuccess = clsCheckSql.CheckFieldForeignKey(strFieldValue, 8, "AA");
                Console.WriteLine(bolIsSuccess);
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                Console.WriteLine(strMsg);
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void CheckFieldNotNullTest()
        {
            //      string strFieldValue = "'; or";
            string strFieldValue = ""; //"' select";
            //string strFieldValue = "'; or";
            //string strFieldValue = "'; or";
            try
            {
                bool bolIsSuccess = clsCheckSql.CheckFieldNotNull(strFieldValue, "AA");
                Console.WriteLine(bolIsSuccess);
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                Console.WriteLine(strMsg);
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void CheckSqlInjection4InsertTest()
        {
            string strSqlInsert_Right = "insert into Tab1 (F1,F2,F3,F4) Values('1 or', 11,22,33)";
            string strSqlInsert_Error = "insert into Tab1 (F1,F2,F3,F4) Values('1 or', 11 select pg_Page(); -- and dd=2) or(dd=1 and ee=4)";
            try
            {
                //   bool bolIsSuccess = clsCheckSql.CheckSqlInjection4Insert(strSqlInsert_Right);
                bool bolIsSuccess = clsCheckSql.CheckSqlInjection4Insert(strSqlInsert_Error);
                Console.WriteLine(bolIsSuccess);
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                Console.WriteLine(strMsg);
                Assert.Fail();

            }
        }

        [TestMethod()]
        public void CheckStrSQL_WeakTest1()
        {
            Assert.Fail();
        }
    }
}