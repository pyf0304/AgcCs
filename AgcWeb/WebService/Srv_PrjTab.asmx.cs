using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;


using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;

namespace AGC.WebSrv
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class clsSrv_PrjTab : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string GetFieldCnNameByFieldName(string strPrjId, string strTabName, string strFieldName)
        {
           string strFieldCnName = clsFieldTabBLEx.GetFieldCnNameByFieldName(strPrjId, strTabName, strFieldName);
           return strFieldCnName;
        }

    }
}
