using System;
using System.Collections.Generic;
using AGC.BusinessLogic;
using AGC.DAL;

namespace AGC.BusinessLogicEx
{
    public partial class clsViewTypeCodeTabBLEx: clsViewTypeCodeTabBL
    {

        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsViewTypeCodeTabDAEx().GoTop(arrKeyId);
                bolResult = new clsViewTypeCodeTabDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }

        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsViewTypeCodeTabDAEx().GoBottom(arrKeyId);
                bolResult = new clsViewTypeCodeTabDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }

        public static bool AdjustSequenceNumber(string strDirect, int intViewTypeCode)
        {
            try
            {
                bool bolResult = new clsViewTypeCodeTabDAEx().AdjustSequenceNumber(strDirect, intViewTypeCode);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错!\r\n" + objException.Message);
            }
        }
        public static bool ReOrder()
        {
            try
            {
                bool bolResult = new clsViewTypeCodeTabDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错!\r\n" + objException.Message);
            }

        }

    }
}
