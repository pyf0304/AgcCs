
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
    using System.Text;
    using com.taishsoft.common;

    /// <summary>
    ///		wucDetailRegionFlds 的摘要说明。
    /// </summary>
    public partial class wucDetailRegion4Preview : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面


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
        public void ShowControl4Regoin(string lngRegionId, string strPrjId, string strKeyId4Test, bool bolInUse)
        {
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, clsPubVar.CurrCmPrjId);
            if (bolInUse == false)
            {
                lblTitle.Visible = false;
                lblTitleOutUse.Visible = true;
                if (string.IsNullOrEmpty(objViewRegion.ClsName) == false )
                {
                    lblTitleOutUse.Text = string.Format("详细信息区: <span class='text-secondary  font-weight-bold'>(类名:{0})</span>", objViewRegion.ClsName);
                }
                pnlControlLst.Controls.Clear();
                return;
            }
            else
            {
                lblTitle.Visible = true;
                if (string.IsNullOrEmpty(objViewRegion.ClsName) == false && lblTitle.Text.Contains("可视化"))
                {
                    lblTitle.Text = string.Format("可视化 <span class='text-secondary  font-weight-bold'>(类名:{0})</span>", objViewRegion.ClsName);
                }
                else
                {
                    lblTitle.Text = string.Format("详细信息区: <span class='text-secondary  font-weight-bold'>(类名:{0})</span>", objViewRegion.ClsName);
                }
                lblTitleOutUse.Visible = false;
            }
                       
            DataTable objDT = null;
            DataRow objDR = null;
            if (string.IsNullOrEmpty(strKeyId4Test) == false)
            {

                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewRegion.TabId, clsPubVar .CurrSelPrjId);
                if (string.IsNullOrEmpty( objPrjTab.KeyFldId()) == true)
                {
                    string strMsg = string.Format("表没有设置关键字，请检查！表名：{0}。(In {1})",
                        objPrjTab.TabName, 
                        clsStackTrace.GetCurrClassFunction());
                    clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
                }
                try
                {

                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.KeyFldId(), clsPubVar.CurrSelPrjId);

                    var bolIsNumber = clsDataTypeAbbrBLEx.IsNumberType(clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId));
                    objDT = clsTablesBLEx.GetDataTableByKey(clsPubVar.CurrPrjDataBaseId, objPrjTab.TabName, objPrjTab.KeyFldName(), strKeyId4Test, bolIsNumber);
                    if (objDT.Rows.Count > 0) objDR = objDT.Rows[0];
                }
                catch (Exception objException)
                {
                    clsGeneralTab.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("在获取表内容（GetDataTableByTabName）时出错！表名：{0},出错信息：{1}。({2})",
                        objPrjTab.TabName, objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                    clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                    throw new Exception(sbMsg.ToString());
                }
            }
            IEnumerable<ASPControlGroupEx> arrControlGroups = clsDetailRegionFldsBLEx.GetControlGroupV3(lngRegionId, clsPubVar.CurrCmPrjId, strPrjId, "", objDR);

            //clsDetailRegionEN objDetailRegion = clsDetailRegionBL.GetObjByRegionIdCache(lngRegionId, strPrjId);
            //if (objDetailRegion == null) return;
            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objDiv.Style["width"] = string.Format("{0}px", objViewRegion.Width);

            switch (objViewRegion.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:
                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objTable.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.FormControl_0002:
                    ASPDivEx objDiv_FormControl = clsASPDivBLEx.PackageByFormControl4DetailRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objDiv_FormControl.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.FormInline_0003:
                    ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4DetailRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objFormInline.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.DivTable_0004:
                    ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4DetailRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objDivTable.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.HorizontalListLi_0005:
                    ASPUlEx objUl = clsASPUlBLEx.PackageByUl4DetailRegion_H(arrControlGroups, objViewRegion.ColNum ?? 0);
               
                    objUl.GeneHtmlControl(objDiv);
                    break;
                case enumGCContainerType.VerticalListLi_0006:
                    ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4DetailRegion_V(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objUl2.GeneHtmlControl(objDiv);
                    break;
                default:
                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objTable2.GeneHtmlControl(objDiv);
                    break;
            }

            pnlControlLst.Controls.Clear();
            pnlControlLst.Controls.Add(objDiv);
            divDetailRegion4Preview.Style["width"] = string.Format("{0}px", objViewRegion.Width);
          
           

        }

        public void ShowControl4Regoin4Query(string lngRegionId, string strCmPrjId, string strPrjId)
        {
            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;

            IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroupV2(lngRegionId, strCmPrjId,  strPrjId, "");
            //clsQueryRegionEN objQueryRegion = clsQueryRegionBL.GetObjByRegionIdCache(lngRegionId, strPrjId);
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, clsPubVar.CurrCmPrjId);

            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objTable.GeneHtmlControl(objDiv);

            pnlControlLst.Controls.Add(objDiv);
            divDetailRegion4Preview.Style["width"] = string.Format("{0}px", objViewRegion.Width);
        }
    }
}