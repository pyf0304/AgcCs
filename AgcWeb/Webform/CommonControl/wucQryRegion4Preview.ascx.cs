
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
    ///		wucQryRegionFlds 的摘要说明。
    /// </summary>
    public partial class wucQryRegion4Preview : System.Web.UI.UserControl
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
        public void ShowControl4RegoinBak(string lngRegionId, string strPrjId)
        {
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(lngRegionId, clsPubVar.CurrCmPrjId);
            if (objViewRegion.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId) == false)
            {
                lblTitle.Visible = false;
                lblTitleOutUse.Visible = true;
                pnlControlLst.Controls.Clear();
                return;
            }
            else
            {
                lblTitle.Visible = true;
                if (objViewRegion.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId) == false)
                {
                    if (lblTitle.Text.IndexOf("-不显示") == -1)
                    {
                        lblTitle.Text += "-不显示";
                    }
                    lblTitle.CssClass += " text-danger";
                }
                lblTitleOutUse.Visible = false;
            }

            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;
            pnlControlLst.Controls.Clear();
            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objDiv.ID = "div1";
            objDiv.Style["width"] = string.Format("{0}px", objViewRegion.Width);
            if (objViewRegion.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId) == true)
            {
                IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroupV2(lngRegionId, clsPubVar.CurrCmPrjId, strPrjId, "");
                //clsQueryRegionEN objQueryRegion = clsQueryRegionBL.GetObjByRegionIdCache(lngRegionId, strPrjId);
                switch (objViewRegion.ContainerTypeId)
                {
                    case enumGCContainerType.TableContainer_0001:
                        ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);
                        objTable.Width = objViewRegion.Width ?? 0;
                        objTable.GeneHtmlControl(objDiv);
                        break;
                    case enumGCContainerType.FormControl_0002:
                        ASPDivEx objDiv_FormControl = clsASPDivBLEx.PackageByFormControl4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                        objDiv_FormControl.GeneHtmlControl(objDiv);
                        break;
                    case enumGCContainerType.FormInline_0003:
                        ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                        objFormInline.GeneHtmlControl(objDiv);
                        break;
                    case enumGCContainerType.DivTable_0004:
                        ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                        objDivTable.GeneHtmlControl(objDiv);
                        break;
                    case enumGCContainerType.HorizontalListLi_0005:
                        ASPUlEx objUl = clsASPUlBLEx.PackageByUl4QueryRegion_H(arrControlGroups, objViewRegion.ColNum ?? 0);

                        objUl.GeneHtmlControl(objDiv);
                        break;
                    case enumGCContainerType.VerticalListLi_0006:
                        ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4QueryRegion_V(arrControlGroups, objViewRegion.ColNum ?? 0);
                        objUl2.GeneHtmlControl(objDiv);
                        break;
                    default:
                        ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);
                        objTable2.GeneHtmlControl(objDiv);
                        break;
                }

            }

            //clsvViewRegionEN objViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(lngRegionId, strPrjId);

            //Func<clsQryRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4MultiModel = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, strItemName4MultiModel);
            var arrQryRegionFlds = clsQryRegionFldsBLEx.GetObjExLstByRegionIdCacheEx(lngRegionId, strPrjId).Where(x => x.CtlTypeId == enumCtlType.ViewVariable_38);
            if (arrQryRegionFlds.Count() > 0)
            {
                ASPDivEx objAspDiv = new ASPDivEx();

                ASPLabelEx objLabel_title = new ASPLabelEx();
                //objLabel_title.Is4PureHtml = true;

                //objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
                objLabel_title.CssClass = "col-form-label text-right text-info font-weight-bold";

                //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
                //  objLabelStyle.Runat);
                objLabel_title.Text = "附加条件串：";
                objAspDiv.arrSubAspControlLst2.Add(objLabel_title);


                foreach (var objInFor in arrQryRegionFlds)
                {
                    string strVarName = "";
                    var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                    if (objVar != null)
                    {
                        strVarName = objVar.VarExpression;
                    }
                    ASPLabelEx objLabel = new ASPLabelEx();
                    //objLabel.Is4PureHtml = true;
                    objLabel.ColSpan_Ctrl = 1;
                    objLabel.CtrlId = string.Format("lbl{0}q", objInFor.ObjFieldTab().FldName);
                    objLabel.OnClick4Html = string.Format("lbl_Click('{0}')", objLabel.CtrlId);
                    objLabel.Width = objInFor.Width ?? 0;
                    //objLabel.Height = ASPControlEx.objLabelStyle_Text.Height;
                    objLabel.FldName = objInFor.ObjFieldTab().FldName;
                    objLabel.ItemName4MultiModel = "";

                    objLabel.TabName = objInFor.ObjPrjTab_PC().TabName;
                    //objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
                    objLabel.CssClass = "col-form-label text-primary";

                    //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
                    //  objLabelStyle.Runat);
                    objLabel.Text = string.Format("strWhereCond += \" And {0} = {1}\";//{2}",
                        objInFor.ObjFieldTab().FldName,
                        strVarName,
                        objInFor.LabelCaption);
                    objAspDiv.arrSubAspControlLst2.Add(objLabel);
                }
                objAspDiv.GeneHtmlControl(objDiv);
            }
            pnlControlLst.Controls.Add(objDiv);
            divQryRegion4Preview.Style["width"] = string.Format("{0}px", objViewRegion.Width);
        }

        public void ShowControl4Regoin(string lngRegionId, string strPrjId, bool bolInUse, bool bolIsDisp)
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
                if (bolIsDisp == false)
                {
                    if (lblTitle.Text.IndexOf("-不显示") == -1)
                    {
                        lblTitle.Text += "-不显示";
                    }
                    lblTitle.CssClass += " text-danger";
                }
                lblTitleOutUse.Visible = false;
            }

            //string strPrjId = "0116";// clsPubVar.CurrSelPrjId;
            pnlControlLst.Controls.Clear();
            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            objDiv.ID = "div1";
            objDiv.Style["width"] = string.Format("{0}px", objViewRegion.Width);
            if (bolIsDisp == true)
            {
                IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroupV2(lngRegionId, clsPubVar.CurrCmPrjId, strPrjId, "");
                //clsQueryRegionEN objQueryRegion = clsQueryRegionBL.GetObjByRegionIdCache(lngRegionId, strPrjId);
                switch (objViewRegion.ContainerTypeId)
                {
                    case enumGCContainerType.TableContainer_0001:
                        ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);
                        objTable.Width = objViewRegion.Width ?? 0;
                        objTable.GeneHtmlControl(objDiv);
                        break;
                    case enumGCContainerType.FormControl_0002:
                        ASPDivEx objDiv_FormControl = clsASPDivBLEx.PackageByFormControl4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                        objDiv_FormControl.GeneHtmlControl(objDiv);
                        break;
                    case enumGCContainerType.FormInline_0003:
                        ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                        objFormInline.GeneHtmlControl(objDiv);
                        break;
                    case enumGCContainerType.DivTable_0004:
                        ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                        objDivTable.GeneHtmlControl(objDiv);
                        break;
                    case enumGCContainerType.HorizontalListLi_0005:
                        ASPUlEx objUl = clsASPUlBLEx.PackageByUl4QueryRegion_H(arrControlGroups, objViewRegion.ColNum ?? 0);

                        objUl.GeneHtmlControl(objDiv);
                        break;
                    case enumGCContainerType.VerticalListLi_0006:
                        ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4QueryRegion_V(arrControlGroups, objViewRegion.ColNum ?? 0);
                        objUl2.GeneHtmlControl(objDiv);
                        break;
                    default:
                        ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);
                        objTable2.GeneHtmlControl(objDiv);
                        break;
                }

            }

            //clsvViewRegionEN objViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(lngRegionId, strPrjId);

            //Func<clsQryRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4MultiModel = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, strItemName4MultiModel);
            var arrQryRegionFlds = clsQryRegionFldsBLEx.GetObjExLstByRegionIdCacheEx(lngRegionId, clsPubVar.CurrCmPrjId).Where(x => x.CtlTypeId == enumCtlType.ViewVariable_38);
            if (arrQryRegionFlds.Count() > 0)
            {
                ASPDivEx objAspDiv = new ASPDivEx();

                ASPLabelEx objLabel_title = new ASPLabelEx();
                //objLabel_title.Is4PureHtml = true;

                //objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
                objLabel_title.CssClass = "col-form-label text-right text-info font-weight-bold";

                //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
                //  objLabelStyle.Runat);
                objLabel_title.Text = "附加条件串：";
                objAspDiv.arrSubAspControlLst2.Add(objLabel_title);


                foreach (var objInFor in arrQryRegionFlds)
                {
                    string strVarName = "";
                    var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                    if (objVar != null)
                    {
                        strVarName = objVar.VarExpression;
                    }
                    ASPLabelEx objLabel = new ASPLabelEx();
                    //objLabel.Is4PureHtml = true;
                    objLabel.ColSpan_Ctrl = 1;
                    objLabel.CtrlId = string.Format("lbl{0}q", objInFor.ObjFieldTab().FldName);
                    objLabel.OnClick4Html = string.Format("lbl_Click('{0}')", objLabel.CtrlId);
                    objLabel.Width = objInFor.Width ?? 0;
                    //objLabel.Height = ASPControlEx.objLabelStyle_Text.Height;
                    objLabel.FldName = objInFor.ObjFieldTab().FldName;
                    objLabel.ItemName4MultiModel = "";

                    objLabel.TabName = objInFor.ObjPrjTab_PC().TabName;
                    //objLabel.Runat = ASPControlEx.objLabelStyle_Text.Runat;
                    objLabel.CssClass = "col-form-label text-primary";

                    //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"text-secondary\">",
                    //  objLabelStyle.Runat);
                    objLabel.Text = string.Format("strWhereCond += \" And {0} = {1}\";//{2}",
                        objInFor.ObjFieldTab().FldName,
                        strVarName,
                        objInFor.LabelCaption);
                    objAspDiv.arrSubAspControlLst2.Add(objLabel);
                }
                objAspDiv.GeneHtmlControl(objDiv);
            }
            pnlControlLst.Controls.Add(objDiv);
            divQryRegion4Preview.Style["width"] = string.Format("{0}px", objViewRegion.Width);
        }
    }
}