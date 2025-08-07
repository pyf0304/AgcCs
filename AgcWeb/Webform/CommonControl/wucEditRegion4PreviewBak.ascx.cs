
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Collections;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using AGC.BusinessLogic;using AGC.FunClass;
    
    using AGC.BusinessLogicEx;
    using AGC.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using AGC.PureClass;
    using AGC.PureClassEx;

    /// <summary>
    ///		wucEditRegionFlds 的摘要说明。
    /// </summary>
    public partial class wucEditRegion4Preview : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面


        }
        public class ControlIdComparer : IEqualityComparer<ASPControlEx>
        {
            public bool Equals(ASPControlEx t1, ASPControlEx t2)
            {
                return (t1.CtrlId == t2.CtrlId);
            }
            public int GetHashCode(ASPControlEx t)
            {
                return t.ToString().GetHashCode();
            }
        }
        public void ShowControl4Regoin(string lngRegionId, string strPrjId)
        {
            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion("Test");
            List<clsEditRegionFldsENEx> arrEditRegionFlds = clsEditRegionFldsBLEx.GetObjExLstByRegionIdEx1(lngRegionId, clsPubVar.CurrCmPrjId);

            Func<clsEditRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4AspNet = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, clsPubVar.CurrSelPrjId, false);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = arrEditRegionFlds
                .Where(x => x.IsLogUpdDateOrUpdUser(clsPubVar.CurrSelPrjId) == false)
                .Select(GetControlGroup_Asp4AspNet);

            //把查询按钮加进来
            //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
            //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
            //arrButtonObjLst.Add(objASPControlGroup);
            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);
            //封装Td
            arrASPControlGroupObjLst = arrASPControlGroupObjLst.Select(clsASPControlGroupBLEx.PackageTr4Wuc);

            //int intCount = 0;
            //ASPRowEx objRow = new ASPRowEx();

            foreach (ASPControlEx objInFor in arrASPControlGroupObjLst)
            {
                objTable.arrSubAspControlLst2.Add(objInFor);
            }
            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objTable.GeneHtmlControl(objDiv);


            pnlControlLst.Controls.Add(objDiv);

            //foreach (HtmlControl objInFor in arrHtmlControl)
            //{
            //    pnlControlLst.Controls.Add(objInFor);
            //}
            //HtmlGenericControl objDiv = new HtmlGenericControl("div");
            //objDiv.Attributes["class"] = "nav";
            
            //    HtmlButton objButton = new HtmlButton();
            //objButton.InnerText = "Test1";
            //objButton.Attributes["class"] = "btn btn-outline-info";
            //objButton.ID = "ID1";
            //objDiv.Controls.Add(objButton);
            //HtmlInputButton objHtmlInputButton = new HtmlInputButton();
            //objHtmlInputButton.Attributes["class"] = "btn btn-outline-info";
            //objDiv.Controls.Add(objHtmlInputButton);
            //pnlControlLst.Controls.Add(objDiv);

        }
    }
}