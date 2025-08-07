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

public partial class Webform_Table2_EditTable : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //string strObjId = new clsCommonSession().ObjId;
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
