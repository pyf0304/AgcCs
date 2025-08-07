using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{
    public interface ISessionStorageVar
    {

        string PrjId { get; set; }
        string LabelCaption { get; set; }
        string FldId { get; set; }

        //string CtrlId { get; set; }
        string VarId { get; set; }
    }
}
