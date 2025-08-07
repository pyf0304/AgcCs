using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGC.BusinessLogicEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx.Tests
{
    [TestClass()]
    public class clsUserCodePrjMainPathBLExTests
    {
        public void SysInit()
        {
            com.taishsoft.commdb.clsSpecSQLforSql.strAppType = "WINAPP";
            com.taishsoft.commdb.clsSpecSQLforSql.IsUseEncrypt = false;
     
        }
        [TestMethod()]
        public void CopyUserCodePrjMainPathFromTemplateTest()
        {
            try
            {
                SysInit();
                clsUserCodePrjMainPathBLEx.CopyUserCodePrjMainPathFromTemplate("0112", "pyf");
            }
            catch (Exception objException)
            {
            Console.WriteLine(objException.Message);
                return;
            }
            //Assert.Fail();
        }
        [TestMethod()]
        public void CopyUserCodePathFromTemplateTest()
        {
            try
            {
                SysInit();
                clsUserCodePathBLEx.CopyUserCodePathFromTemplate("0112", "pyf","01");
            }
            catch (Exception objException)
            {
                Console.WriteLine(objException.Message);
                return;
            }
            //Assert.Fail();
        }
    }
}