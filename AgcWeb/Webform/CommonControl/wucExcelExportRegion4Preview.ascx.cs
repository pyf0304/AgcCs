
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
    using com.taishsoft.common;
    using System.Text;
    using AGC.PureClass;
    using AGC.PureClassEx;
    using com.taishsoft.datetime;

    /// <summary>
    ///		wucExcelExportRegionFlds 的摘要说明。
    /// </summary>
    public partial class wucExcelExportRegion4Preview : System.Web.UI.UserControl
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
        /// <summary>
        /// 设置标题
        /// </summary>
        public string Title
        {
            set
            {
                lblTitle.Text = value;
            }
        }

        public void ShowControl4Regoin(string lngRegionId, string strPrjId, int intRecNum, bool bolInUse)
        {
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, clsPubVar.CurrCmPrjId);
            if (bolInUse == false)
            {
                lblTitle.Visible = false;
                lblTitleOutUse.Visible = true;
                pnlControlLst.Controls.Clear();
                return;
            }
            else
            {
                lblTitle.Visible = true;
                lblTitleOutUse.Visible = false;
            }
            pnlControlLst.Controls.Clear();
            //clsvExcelExportRegionEN objvExcelExportRegion = null;
            //try
            //{
            //    objvExcelExportRegion = clsvExcelExportRegionBL.GetObjByRegionId(lngRegionId);

            //}
            //catch (Exception objException)
            //{
            //    clsGeneralTab.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
            //    StringBuilder sbMsg = new StringBuilder();
            //    sbMsg.AppendFormat("在获取列表区域对象（GetObjByRegionId）时出错！区域Id：{0},出错信息：{1}。({2})",
            //        lngRegionId, objException.Message,
            //        clsStackTrace.GetCurrClassFunction());
            //    clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
            //    throw new Exception(sbMsg.ToString());
            //}
            //if (objvExcelExportRegion == null)
            //{
            //    clsExcelExportRegionEN objExcelExportRegionEN = new clsExcelExportRegionEN();
            //    objExcelExportRegionEN.RegionId = lngRegionId;
            //    objExcelExportRegionEN.PrjId = strPrjId;
            //    objExcelExportRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            //    objExcelExportRegionEN.UpdUser = clsCommonSession.UserId;
            //    objExcelExportRegionEN.AddNewRecord();
            //    objvExcelExportRegion = clsvExcelExportRegionBL.GetObjByRegionId(lngRegionId);
            //    //StringBuilder sbMsg = new StringBuilder();
            //    //sbMsg.AppendFormat("在获取列表区域对象（GetObjByRegionId）为空！区域Id：{0}。( In {1})",
            //    //    lngRegionId,                    clsStackTrace.GetCurrClassFunction());
            //    //clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
            //    //throw new Exception(sbMsg.ToString());
            //}
            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4ExcelExportRegion();
            List<clsExcelExportRegionFldsENEx> arrExcelExportRegionFlds = clsExcelExportRegionFldsBLEx.GetObjExLstByRegionIdEx1(lngRegionId,clsPubVar.CurrCmPrjId);
          
            IEnumerable<ASPControlEx> arrASPControlObjLst
                = arrExcelExportRegionFlds
          
                .Select(clsASPControlBLEx.GetControl_Asp)
                .Select(clsASPControlBLEx.PackageTd);

            //把查询按钮加进来
            //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
            //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
            //arrButtonObjLst.Add(objASPControlGroup);
            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);
            //封装Td
       

            //int intCount = 0;
            ASPRowEx objRow = new ASPRowEx();
            objRow.RowType = "headrow";
            objTable.arrSubAspControlLst2.Add(objRow);
            foreach (ASPControlEx objInFor in arrASPControlObjLst)
            {
                objRow.arrSubAspControlLst2.Add(objInFor);
            }
            DataTable objDT = null;
  
            try
            {             
                objDT = clsTablesBLEx.GetDataTableByTop(clsPubVar.CurrPrjDataBaseId, objViewRegion.TabName(), intRecNum, "1=1", "");
            }
            catch (Exception objException)
            {
                clsGeneralTab.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在获取表内容（GetDataTableByTabName）时出错！表名：{0},出错信息：{1}。({2})",
                    objViewRegion.TabName(), objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }
            foreach(DataRow objInFor in objDT.Rows)
            {
                ASPRowEx objRow_Data = new ASPRowEx();
                objRow_Data.RowType = "datarow";
                objRow_Data.objDataRow = objInFor;
                foreach (ASPControlEx objInFor_Sub in arrASPControlObjLst)
                {
                    objRow_Data.arrSubAspControlLst2.Add(objInFor_Sub);
                }
                objTable.arrSubAspControlLst2.Add(objRow_Data);
            }
            HtmlGenericControl objDiv = new HtmlGenericControl("div");
             objTable.GeneHtmlControl(objDiv);
            pnlControlLst.Controls.Add(objDiv);
            divExcelExportRegion4Preview.Style["width"] = string.Format("{0}px", objViewRegion.Width);
        }
    }
}