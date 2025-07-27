using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{
    public interface IDnPath
    {
        //string PrjId { get; set; }
        string TabId { get; set; }

        string PrjId { get; set; }
        string Caption { get; set; }

        //string CtrlId { get; set; }
        string FldId { get; set; }
        /// <summary>
        /// 表功能
        /// </summary>
        //string OutDataNodeId { get; set; }
        string DnPathId { get; set; }
        //bool IsUseFunc { get; set; }
        bool IsForExtendClass { get; set; }
    //string DataPropertyName { get; set; } //字段Id_条件1
    }
}
