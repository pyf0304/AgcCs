using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;


using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;
using AGC.Entity;

namespace AGC
{
    /// <summary>
    /// wfmFrameTop 的摘要说明。
    /// </summary>
    public partial class wfmFrameTop_EditTab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)
            {
                clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                if (string.IsNullOrEmpty(clsPubVar.CurrSelPrjId) == true)
                {
                    return;
                }
                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId);
                lblCurrPrjName.Text = objProject.PrjName;
                lblPrjDataBaseName.Text = objPrjDataBase.DataBaseName;
                lblUserName.Text = clsCommonSession.objQxUser.UserName;
            }

        }

      
        private clsUsersEN objUserBak
        {
            get
            {
                clsUsersEN pobjUser;
                pobjUser = (clsUsersEN)Session["objUser"];
                if (pobjUser == null)
                {
                    pobjUser = null;
                }
                return pobjUser;
            }
            set
            {
                clsUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }

        protected void lbLogOff_Click(object sender, System.EventArgs e)
        {
            Session.Clear();
            string c1 = "<script language='javascript'>window.parent.location.href='Index.aspx'; </script>";
            Response.Write(c1);
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string c1 = "<script language='javascript'>window.open('../../help/agc_csV5Help/IndexFrame.html','aa'); </script>";
            Response.Write(c1);
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
                case "浏览表":
                    Response.Redirect("wfmPrjTab_QUDI_Sim.aspx");
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
}
