using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGC.Entity;

namespace Agc.PureClass
{
    public interface IGetTabFieldObj
    {
        clsPrjTabEN GetObjByTabId(string strTabId, string strPrjId);
        clsFieldTabEN GetObjByFldId(string strFldId, string strPrjId);

    }
}
