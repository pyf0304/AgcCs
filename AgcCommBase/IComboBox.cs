using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{
    public interface IComboBox
    {
        string PrjId { get; set; }
        string LabelCaption { get; set; }
        string DdlItemOptionId { get; set; }

        //string CtrlId { get; set; }
        string DsTabId { get; set; }
        /// <summary>
        /// 表功能
        /// </summary>
        string TabFeatureId4Ddl { get; set; }
        //string Ds_DataTextFieldId { get; set; }
        //string DsDataValueFieldId { get; set; }
        string FldIdCond1 { get; set; } //字段Id_条件1
        //string VarTypeIdCond1 { get; set; } //变量类型Id_条件1
        string VarIdCond1 { get; set; } //变量Id_条件1
        string FldIdCond2 { get; set; } //字段Id_条件2
        //string VarTypeIdCond2 { get; set; } //变量类型Id_条件2
        string VarIdCond2 { get; set; } //变量Id_条件2

        //string TextFieldName { get; set; }
        //string ValueFieldName { get; set; }
    }
}
