using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AGC.Entity;
using AGC.PureClass;

namespace AGC.PureClass
{
    public class ASPControlEx : ASPControl
    {
        public string ControlType { get; set; }
        /// <summary>
        /// 是否标题
        /// </summary>
        public bool IsCaption { get; set; }
        /// <summary>
        /// 合并到前一个控件
        /// </summary>
        public bool IsMergeToPreviousControl { get; set; }

        /// <summary>
        /// 跨列数
        /// </summary>
        public int ColSpan_Ctrl { get; set; }
        public bool Is4Mvc { get; set; }
        public List<ASPControlEx> arrSubAspControlLst2 = null;
        public ASPControlEx()
        {
            this.ControlType = "ASPControlEx";
            arrSubAspControlLst2 = new List<ASPControlEx>();
        }

        //public clsQryRegionFldsENEx objQryRegionFldsENEx = null;
        //public clsEditRegionFldsENEx objEditRegionFldsENEx = null;
        //public clsDGRegionFldsENEx objDGRegionFldsENEx = null;
        //public clsExcelExportRegionFldsENEx objExcelExportRegionFldsENEx = null;
        //public clsvViewFeatureFldsENEx objViewFeatureFldsENEx = null;

        public clsQryRegionFldsEN objQryRegionFldsEN = null;
        public clsEditRegionFldsEN objEditRegionFldsEN = null;
        public clsDetailRegionFldsEN objDetailRegionFldsEN = null;
        public clsDGRegionFldsEN objDGRegionFldsEN = null;
        public clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = null;
        public clsViewFeatureFldsEN objViewFeatureFldsEN = null;
        public clsPrjFeatureEN objPrjFeature = null;

        public static clsLabelStyleEN objLabelStyle_Text = null;// clsLabelStyleBL.GetObjByLabelStyleId("0001");
        public static clsGenCtlStyleEN objGenCtlStyle = null;// clsGenCtlStyleBL.GetObjByGenCtlStyleId("0001");
        public static clsCheckStyleEN objCheckStyle = null;// clsCheckStyleBL.GetObjByCheckStyleId("0001");
        public static clsButtonStyleEN objButtonStyle = null;// clsButtonStyleBL.GetObjByButtonStyleId("0001");

        /// <summary>
        /// 行类型
        /// </summary>
        public string RowType { get; set; }
        public string Caption { get; set; }
        public string CsType { get; set; }
        public string TypeScriptType { get; set; }
        public string ItemName4MultiModel { get; set; }
        /// <summary>
        /// 是否专用于纯Html
        /// </summary>
        //public bool Is4PureHtml { get; set; }
        public string FldName { get; set; }
        public string DataProperty { get; set; }

        public string TabName { get; set; }
        public long KeyId { get; set; }
        public int ColIndex { get; set; }

        public string Name4MvcAjax { get; set; }
        public string OnClick4MvcAjax { get; set; }
        public string OnClick4Html { get; set; }
        //public string CommandName { get; set; }

        public string ViewFeatureId { get; set; }
        public string FeatureId { get; set; }
        public string ClickEvent { get; set; }
        public string ChangeEvent { get; set; }

        

        public string ValueGivingModeId { get; set; }
        public ASPControlEx Parent { get; set; }
        public DataRow objDataRow { get; set; }
        /// <summary>
        /// 是否列头复选框
        /// </summary>
        public bool IsCheckBox { get; set; }

        public string _StrTag { get; set; }


    }
}
