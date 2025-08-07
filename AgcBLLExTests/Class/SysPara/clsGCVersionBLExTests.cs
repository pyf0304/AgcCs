using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGC.BusinessLogicEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGC.Entity;

namespace AGC.BusinessLogicEx.Tests
{
    [TestClass()]
    public class clsGCVersionBLExTests
    {
        [TestMethod()]
        public void GetNewestVersionObjTest()
        {
            clsGCVersionEN obj =  clsGCVersionBLEx.GetNewestVersionObj();
            Console.WriteLine(obj.PublishDate);
            Assert.Fail();
        }
    }
}