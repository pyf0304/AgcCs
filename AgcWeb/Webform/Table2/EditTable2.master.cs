using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



using System.Text;
using System.Collections;
using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;
using AGC;

public partial class Webform_Table2_EditTable2 : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindPrjTabAccordion(clsPubVar.CurrSelPrjId);
            BindPrjViewAccordion(clsPubVar.CurrSelPrjId);
            string strObjId = new clsCommonSession().ObjId;
            //if (string.IsNullOrEmpty(strObjId) == false)
            //{
            //    clsPrjObjectsEN objPrjObjectsEN = clsPrjObjectsBL.GetPrjObjectsByObjId(strObjId);
            //    lblTabNameObjName.Text = "对象名:" + objPrjObjectsEN.ObjName;
            //}
            //转换成相关表ID(TabId)
            string strTabId = clsCommonSession.TabId;
            if (string.IsNullOrEmpty(strTabId) == false)
            {
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
                lblTabNameObjName.Text = lblTabNameObjName.Text +
                    string.Format("   表名：{0}({1})", objPrjTabEN.TabName, objPrjTabEN.TabCnName);
            }
            //else if (string.IsNullOrEmpty(FromWebForm_qs) == false)
            //{
            //    EditPrjTabFieldByTabId(clsCommonSession.TabId);
            //}


        }
    }
    //定义从外面传来的ObjId(对象ID)
    private string ObjId_qs
    {
        get
        {
            string strObjId = Request.QueryString["ObjId"] ?? "".ToString();
            if ((strObjId != null) && (strObjId != ""))
            {
                return strObjId;//Request.QueryString["id"] ?? "";
            }
            else
            {
                return "";
            }
        }
    }
    //定义从外面传来的ObjId(对象ID)
    private string TabId_qs
    {
        get
        {
            string strTabId = Request.QueryString["TabId"] ?? "".ToString();
            if ((strTabId != null) && (strTabId != ""))
            {
                return strTabId;//Request.QueryString["id"] ?? "";
            }
            else
            {
                return "";
            }
        }
    }
    //定义从外面传来的FromWebForm(从什么页面传来)
    private string FromWebForm_qs
    {
        get
        {
            string strFromWebForm = Request.QueryString["FromWebForm"] ?? "".ToString();
            if ((strFromWebForm != null) && (strFromWebForm != ""))
            {
                return strFromWebForm;//Request.QueryString["id"] ?? "";
            }
            else
            {
                return "";
            }
        }
    }
    //protected void LoadAccordion()
    //{
    //    string CurrentGroupSQL = "";
    //    SqlDataReader drmain = UserBase.USP_SELECT_OA_UserQuerySort();

    //    Accordion1.SelectedIndex = -1;
    //    int i = 0;
    //    while (drmain.Read())
    //    {
    //        i++;
    //        AjaxControlToolkit.AccordionPane ap = new AjaxControlToolkit.AccordionPane();
    //        ap.ID = "AP_" + i.ToString();
    //        string hlabel = drmain["QueryName"].ToString();//这里取大的分类
    //        CurrentGroupSQL = drmain["GroupSQL"].ToString();
    //        ITemplate ITheader = new GenericTemplateImplementation(
    //            delegate(Control container)
    //            {
    //                Label headerLabel = new Label();
    //                headerLabel.ID = "HL_" + i.ToString();
    //                headerLabel.Text = "<table border='0' cellpadding='0' cellspacing='0' style='width:100%;'><tr><td class='UserMenu' valign='middle'>&nbsp;" + hlabel + "</td></tr></table>";
    //                // headerLabel.CssClass = "UserMenu";
    //                container.Controls.Add(headerLabel);
    //            }
    //        );
    //        //取组，角色和组织
    //        SqlDataReader drGroup = GetGroupColl(CurrentGroupSQL);

    //        ITemplate ITcontent = new GenericTemplateImplementation(
    //            delegate(Control container)
    //            {
    //                AjaxControlToolkit.Accordion ac = new AjaxControlToolkit.Accordion();
    //                ac.ID = "ACCC_" + i.ToString();
    //                ac.HeaderCssClass = "accordionHeader";
    //                ac.HeaderSelectedCssClass = "accordionHeaderSelected";
    //                ac.ContentCssClass = "accordionContent";
    //                ac.SelectedIndex = -1;

    //                int x = 0;
    //                while (drGroup.Read())
    //                {
    //                    x++;
    //                    AjaxControlToolkit.AccordionPane apx = new AjaxControlToolkit.AccordionPane();
    //                    apx.ID = "APx_" + x.ToString();
    //                    string hxlabel = drGroup["ClassName"].ToString();
    //                    SqlDataReader drEmployee = GetUserColl(drGroup["id"].ToString());//得到用户 
    //                    ITemplate ITxheader = new GenericTemplateImplementation(
    //                        delegate(Control container2)
    //                        {
    //                            Label xheaderLabel = new Label();
    //                            xheaderLabel.ID = "HLx_" + x.ToString();
    //                            xheaderLabel.Text = "<div class='UserHeight'><img  src='images/userarrow1.png' />&nbsp;" + hxlabel + "</div>";
    //                            xheaderLabel.CssClass = "UserArraw";
    //                            container2.Controls.Add(xheaderLabel);
    //                        }
    //                    );


    //                    string xcLabel = "";
    //                    string sEmployee = "";
    //                    string sEmployeeID = "";
    //                    while (drEmployee.Read())
    //                    {
    //                        sEmployee = drEmployee["username"].ToString();
    //                        sEmployeeID = drEmployee["id"].ToString();
    //                        xcLabel = xcLabel + "&nbsp;&nbsp;<img  src='images/addrss.gif' /><a href='' TagName=" + sEmployeeID.Trim() + "," + sEmployee.Trim() + "   onclick='addFile(this);return false;'>" + sEmployee + "</a><br/>";
    //                    }
    //                    drEmployee.Close();
    //                    drEmployee.Dispose();
    //                    ITemplate ITxcontent = new GenericTemplateImplementation(
    //                        delegate(Control container3)
    //                        {
    //                            Label xcontentLabel = new Label();
    //                            xcontentLabel.ID = "CLx_" + x.ToString();
    //                            xcontentLabel.Text = xcLabel;
    //                            container3.Controls.Add(xcontentLabel);
    //                        }
    //                    );
    //                    apx.Header = ITxheader;
    //                    apx.Content = ITxcontent;
    //                    ac.Panes.Add(apx);
    //                }
    //                ac.SelectedIndex = -1;
    //                container.Controls.Add(ac);
    //                drGroup.Close();
    //                drGroup.Dispose();
    //            }
    //        );
    //        ap.Header = ITheader;
    //        ap.Content = ITcontent;

    //        Accordion1.Panes.Add(ap);
    //    }

    //    drmain.Close();
    //    drmain.Dispose();

    //}



    private void BindPrjTabAccordionBak(string strPrjId)
    {
        StringBuilder strCondition = new StringBuilder();
        strCondition.AppendFormat("PrjId = '{0}'", strPrjId);

        //clsPrjTabBLEx objPrjMenuBLEx = new clsPrjTabBLEx();
        //List<clsvPrjTabEN> arrPrjTabObjLst = null;
        List<clsvFuncModule_AgcEN> arrFuncModuleObjLst
           = clsvFuncModule_AgcBLEx.GetFuncModuleObjLst(strPrjId);// new clsFuncModule_AgcBL.GetFuncModuleObjList(strCondition.ToString() + " order by FuncModuleName");
        ArrayList arrTabTypeNames = new ArrayList();
     

        //MenuItem miTab = new MenuItem();
        //miTab.Text = "表(Table)";
        //mnuPrjTab.Items.Add(miTab);

        accPrjTab.SelectedIndex = -1;
    
       
    }

    private void BindPrjTabAccordion(string strPrjId)
    {
        StringBuilder strCondition = new StringBuilder();
        strCondition.AppendFormat("PrjId = '{0}'", strPrjId);

        //clsPrjTabBLEx objPrjMenuBLEx = new clsPrjTabBLEx();
        List<clsvFuncModule_AgcEN> arrFuncModuleObjLst
           = clsvFuncModule_AgcBLEx.GetFuncModuleObjLst(strPrjId);// new clsFuncModule_AgcBL.GetFuncModuleObjList(strCondition.ToString() + " order by FuncModuleName");
        ArrayList arrTabTypeNames = new ArrayList();
   
        //clsObjectTypeEN objObjectType2 = new clsObjectTypeEN();
        //objObjectType2.ObjectTypeId = clsSQLDSTypeBLEx.SQLVIEW;
        //objObjectType2.ObjectType = "视图(View)";
        //arrTabTypeNames.Add(objObjectType2);

        //MenuItem miTab = new MenuItem();
        //miTab.Text = "表(Table)";
        //mnuPrjTab.Items.Add(miTab);

        accPrjTab.SelectedIndex = -1;
   
    }
    private void BindPrjViewAccordion(string strPrjId)
    {
        StringBuilder strCondition = new StringBuilder();
        strCondition.AppendFormat("PrjId = '{0}'", strPrjId);

        List<clsvFuncModule_AgcEN> arrFuncModuleObjLst
           = clsvFuncModule_AgcBLEx.GetFuncModuleObjLst(strPrjId);// new clsFuncModule_AgcBL.GetFuncModuleObjList(strCondition.ToString() + " order by FuncModuleName");
        ArrayList arrTabTypeNames = new ArrayList();
        //clsObjectTypeEN objObjectType1 = new clsObjectTypeEN();
        //objObjectType1.ObjectTypeId = clsSQLDSTypeBLEx.SQLTAB;
        //objObjectType1.ObjectType = "表(Table)";
        //arrTabTypeNames.Add(objObjectType1);
      
        //MenuItem miTab = new MenuItem();
        //miTab.Text = "表(Table)";
        //mnuPrjTab.Items.Add(miTab);

        accPrjTab.SelectedIndex = -1;
      
    }


    //private void BindPrjTabMenu1(string strPrjId)
    //{
    //    StringBuilder strCondition = new StringBuilder();
    //    strCondition.AppendFormat("PrjId = '{0}'", strPrjId);

    //    //clsPrjTabBLEx objPrjMenuBLEx = new clsPrjTabBLEx();
    //    ArrayList arrPrjTabObjLst = clsPrjTabBLEx.GetPrjTabObjLst(strPrjId);
    //    ArrayList arrFuncModuleObjLst
    //       = clsFuncModuleBLEx.GetFuncModuleObjLst(strPrjId);// new clsFuncModule_AgcBL.GetFuncModuleObjList(strCondition.ToString() + " order by FuncModuleName");


    //    MenuItem miTab = new MenuItem();
    //    miTab.Text = "表(Table)";
    //    mnuPrjTab.Items.Add(miTab);

    //    foreach (clsvFuncModuleEN objFuncModule in arrFuncModuleObjLst)
    //    {
    //        MenuItem miFuncModule = new MenuItem();
    //        foreach (clsvPrjTabEN objPrjTabEN in arrPrjTabObjLst)
    //        {
    //            if (objPrjTabEN.FuncModuleAgcId == objFuncModule.FuncModuleAgcId && objPrjTabEN.SqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
    //            {
    //                MenuItem miPrjTab = new MenuItem();
    //                miPrjTab.Text = string.Format("{0}_{1}({2})",
    //                    objPrjTabEN.TabName, objPrjTabEN.TabCnName,
    //                    objPrjTabEN.FldNum);
    //                miPrjTab.NavigateUrl = @"wfmPrjTab_QUDI2.aspx?TabId=" + objPrjTabEN.TabId;
    //                miFuncModule.ChildItems.Add(miPrjTab);
    //            }
    //        }
    //        miFuncModule.Text = string.Format("{0}({1})",
    //            objFuncModule.FuncModuleName, miFuncModule.ChildItems.Count);
    //        miTab.ChildItems.Add(miFuncModule);
    //    }

    //    MenuItem miFuncModule_Unknow = new MenuItem();
    //    miFuncModule_Unknow.Text = "未知模块";
    //    foreach (clsvPrjTabEN objPrjTabEN in arrPrjTabObjLst)
    //    {
    //        if (string.IsNullOrEmpty(objPrjTabEN.FuncModuleAgcId) == true && objPrjTabEN.SqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
    //        {
    //            MenuItem miPrjTab = new MenuItem();
    //            miPrjTab.Text = string.Format("{0}_{1}({2})",
    //                   objPrjTabEN.TabName, objPrjTabEN.TabCnName,
    //                   objPrjTabEN.FldNum);
    //            miPrjTab.NavigateUrl = @"wfmPrjTab_QUDI2.aspx?TabId=" + objPrjTabEN.TabId;
    //            miFuncModule_Unknow.ChildItems.Add(miPrjTab);
    //        }
    //    }
    //    if (miFuncModule_Unknow.ChildItems.Count > 0)
    //    {
    //        miFuncModule_Unknow.Text = string.Format("未知模块({0})", miFuncModule_Unknow.ChildItems.Count);
    //        miTab.ChildItems.Add(miFuncModule_Unknow);
    //    }



    //    MenuItem miView = new MenuItem();
    //    miView.Text = "视图(View)";
    //    mnuPrjTab.Items.Add(miView);

    //    foreach (clsvFuncModuleEN objFuncModule in arrFuncModuleObjLst)
    //    {
    //        MenuItem miFuncModule = new MenuItem();
    //        foreach (clsvPrjTabEN objPrjTabEN in arrPrjTabObjLst)
    //        {
    //            if (objPrjTabEN.FuncModuleAgcId == objFuncModule.FuncModuleAgcId && objPrjTabEN.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
    //            {
    //                MenuItem miPrjTab = new MenuItem();
    //                miPrjTab.Text = string.Format("{0}_{1}({2})",
    //                   objPrjTabEN.TabName, objPrjTabEN.TabCnName,
    //                   objPrjTabEN.FldNum);
    //                miPrjTab.NavigateUrl = @"wfmPrjTab_QUDI2.aspx?TabId=" + objPrjTabEN.TabId;
    //                miFuncModule.ChildItems.Add(miPrjTab);
    //            }
    //        }
    //        if (miFuncModule.ChildItems.Count > 0)
    //        {
    //            miFuncModule.Text = string.Format("{0}({1})",
    //objFuncModule.FuncModuleName, miFuncModule.ChildItems.Count);

    //            miView.ChildItems.Add(miFuncModule);
    //        }
    //    }

    //    MenuItem miFuncModule_Unknow2 = new MenuItem();
    //    miFuncModule_Unknow2.Text = "未知模块";
    //    foreach (clsvPrjTabEN objPrjTabEN in arrPrjTabObjLst)
    //    {
    //        if (string.IsNullOrEmpty(objPrjTabEN.FuncModuleAgcId) == true && objPrjTabEN.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
    //        {
    //            MenuItem miPrjTab = new MenuItem();
    //            miPrjTab.Text = string.Format("{0}_{1}({2})",
    //                   objPrjTabEN.TabName, objPrjTabEN.TabCnName,
    //                   objPrjTabEN.FldNum);
    //            miPrjTab.NavigateUrl = @"wfmPrjTab_QUDI2.aspx?TabId=" + objPrjTabEN.TabId;
    //            miFuncModule_Unknow2.ChildItems.Add(miPrjTab);
    //        }
    //    }
    //    if (miFuncModule_Unknow2.ChildItems.Count > 0)
    //    {
    //        miFuncModule_Unknow2.Text = string.Format("未知模块({0})", miFuncModule_Unknow2.ChildItems.Count);
    //        miView.ChildItems.Add(miFuncModule_Unknow2);
    //    }

    //    //tvPrjMenus.ExpandAll();


    //}
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

        //MultiView1.ActiveViewIndex = int.Parse(e.Item.Value);
        //switch (MultiView1.ActiveViewIndex)
        //{
        //    case 0:
        //        EditPrjObject(new clsCommonSession().ObjId);
        //        break;
        //    case 1:
        //        //获取
        //        EditPrjTab(clsCommonSession.TabId);
        //        break;
        //    case 2:
        //        //获取
        //        EditTabFieldByObjId(new clsCommonSession().ObjId);
        //        break;
        //    case 3:
        //        //获取
        //        EditPrjTabFieldByTabId(clsCommonSession.TabId);
        //        break;
        //    case 4:
        //        //获取
        //        DispGeneCode();
        //        break;
        //    case 5:
        //        //获取
        //        DispGeneStoreProcedure();
        //        break;
        //    default:
        //        break;
        //}
    }

    protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
    {
        //<asp:MenuItem Text="对象属性" Value="Object"></asp:MenuItem>
        //<asp:MenuItem Text="表属性" Value="Table"></asp:MenuItem>
        //<asp:MenuItem Text="对象字段" Value="ObjField"></asp:MenuItem>
        //<asp:MenuItem Text="表字段" Value="TabField"></asp:MenuItem>
        //<asp:MenuItem Text="生成代码" Value="GeneCode"></asp:MenuItem>
        //<asp:MenuItem Text="生成SQL存储过程" Value="GeneSqlSP"></asp:MenuItem>
        //<asp:MenuItem Text="生成Oracle存储过程" Value="GeneOracleSP"></asp:MenuItem>

        string strMenuValue = e.Item.Value.ToString();
        switch (strMenuValue)
        {
            case "Object":
                Response.Redirect("wfmPrjObject_QUDI2.aspx");
                break;
            case "Table":
                Response.Redirect("wfmPrjTab_QUDI2.aspx");
                break;
            case "ObjField":
                Response.Redirect("wfmFieldTab_QUDI2.aspx");
                break;
            case "TabField":
                Response.Redirect("wfmPrjTabFld_QUDI2.aspx");
                break;
            case "CheckConsistency":
                Response.Redirect("wfmPrjTab_CheckConsistency2.aspx");
                break;

            case "GeneCode":
                Response.Redirect("wfmGeneCode4Tab_QUDI2.aspx");
                break;
            case "GeneSqlSP":
                Response.Redirect("wfmGeneSP4MsSql_QUDI2.aspx");
                break;

        }
    }
}
