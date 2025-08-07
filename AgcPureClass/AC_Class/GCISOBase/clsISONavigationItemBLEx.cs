using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;

using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsISONavigationItemBLEx_Static
    {
        public static void GeneCode(this ISONavigationItemEx objISONavigationItemENEx, StringBuilder strCodeForCs)
        {
        
            //string strNavigationItemId = AgcPubFun.getSwiftID();
            strCodeForCs.AppendFormat("\r\n" + "<navigationItem title=\"{1}\" id=\"{0}\">",
                objISONavigationItemENEx.IsoControlId, objISONavigationItemENEx.Text);
                      
            foreach (ISOControlEx objSubISOControlENEx in objISONavigationItemENEx.arrSubIsoControlLst2)
            {
                objSubISOControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</navigationItem>");
        }
    }
}
