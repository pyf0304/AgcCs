using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISOActionBLEx_Static 
    {
        public static void GeneCode(this ISOActionEx objISOActionENEx, StringBuilder strCodeForCs)
        {
            //string strActionId = AgcPubFun.getSwiftID();
            strCodeForCs.AppendFormat("\r\n" + "<action selector =\"{0}:\" destination=\"{1}\" eventType=\"touchDown\" id=\"{2}\"/> ",
                objISOActionENEx.EventFuncName, objISOActionENEx.destination,
                objISOActionENEx.IsoControlId);
            foreach (ISOControlEx objSubISOControlENEx in objISOActionENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }                       
        }
    }
    public class clsISOActionBLEx 
    {

    }
}
