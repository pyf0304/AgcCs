using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsASPControlENBase : clsASPControlEN
    {
        public bool Is4Mvc { get; set; }
        public List<clsASPControlENEx> arrSubAspControlLst2 = null;
        public clsASPControlENEx()
        {
            arrSubAspControlLst2 = new List<clsASPControlENEx>();
        }

        public clsQryRegionFldsENEx objQryRegionFldsENEx = null;
        public clsEditRegionFldsENEx objEditRegionFldsENEx = null;
        public clsDGRegionFldsENEx objDGRegionFldsENEx = null;
        public clsExcelExportRegionFldsENEx objExcelExportRegionFldsENEx = null;
        public clsvViewFeatureFldsENEx objViewFeatureFldsENEx = null;

        public static clsLabelStyleEN objLabelStyle_Text = null;// clsLabelStyleBL.GetObjByLabelStyleId("0001");
        public static clsGenCtlStyleEN objGenCtlStyle = null;// clsGenCtlStyleBL.GetObjByGenCtlStyleId("0001");
        public static clsCheckStyleEN objCheckStyle = null;// clsCheckStyleBL.GetObjByCheckStyleId("0001");
        public static clsButtonStyleEN objButtonStyle = null;// clsButtonStyleBL.GetObjByButtonStyleId("0001");

        /// <summary>
        /// 行类型
        /// </summary>
        public string RowType { get; set; }
        public string Caption { get; set; }
        public string CSType { get; set; }
        public string ItemName4MultiModel { get; set; }
        /// <summary>
        /// 是否专用于纯Html
        /// </summary>
        public bool Is4PureHtml { get; set; }
        public string FldName { get; set; }
        public string TabName { get; set; }
        public string Name4MvcAjax { get; set; }
        public string OnClick4MvcAjax { get; set; }
        public string OnClick4Html { get; set; }
        public string ViewFeatureId { get; set; }
        public string FeatureId { get; set; }
        public string ValueGivingModeId { get; set; }
        public clsASPControlENEx Parent { get; set; }
        public DataRow objDataRow { get; set; }
        /// <summary>
        /// 是否列头复选框
        /// </summary>
        public bool IsCheckBox { get; set; }
    }
}
