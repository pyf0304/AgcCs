using AGC.BusinessLogic;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsCharEncodingBLEx
    {
        public static string GetDefaultCharEncoding()
        {
            string strCondition = string.Format("IsDefault = '1'");
            clsCharEncodingEN objCharEncodingEN = clsCharEncodingBL.GetFirstObj_S(strCondition);
            if (objCharEncodingEN  ==  null)
            {
                throw new Exception(string.Format("在表:【{0}】中，默认的值不存在!", clsCharEncodingEN._CurrTabName));
            }
            return objCharEncodingEN.CharEncodingId;
        }
    }
}
