using com.taishsoft.web.menu;
using CommFunc4WebForm;
using AGC.Entity;
using AGC.web.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform.CommonPage
{
    public partial class TestWucMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTv_ExamBatch();
                BindTv_ExamBatch2();

                MenuItem objMI = new MenuItem();
                objMI.Text = "PYF";
                MenuItem objMI_L2 = new MenuItem();
                objMI_L2.Text = "PYF2";
                objMI.ChildItems.Add(objMI_L2);
                Menu1.Items.Add(objMI);

                //  mnuTopMenu.Items.Add(objMI);
            }

        }
        private void BindTv_ExamBatch()
        {
            wucMenu1.tmMenuModel = MenuModel.GRADE_COURSE_EXAMBATCH;
            wucMenu1.BindTv();
            //wucMenu1.Expand(1);
            //wucMenu1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucMenu1.SelectNode(strTypeName, strKeyId);
        }

        private void BindTv_ExamBatch2()
        {
            wucMenu2.tmMenuModel = MenuModel.GRADE_COURSE_EXAMBATCH;
            wucMenu2.BindTv();
            //wucMenu1.Expand(1);
            //wucMenu1.afterSelect_Tz += WucTreeView1_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            wucMenu2.SelectNode(strTypeName, strKeyId);
        }
        protected void wucMenu1_afterSelect_Tz(object sender, clsEventArgs4Menu e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.MenuItemType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            lblMsg.Text = strMsg;
            //clsCommonJsFunc.Alert(this, strMsg);
            //wucMenu1.SelectNode(clsExamBatchEN._CurrTabName, strKeyId);

        }
        protected string vsTreeNodeType
        {
            get
            {
                string sTreeNodeType;
                sTreeNodeType = (string)ViewState["TreeNodeType"];
                if (sTreeNodeType == null)
                {
                    sTreeNodeType = "";
                }
                return sTreeNodeType;
            }
            set
            {
                string sTreeNodeType = value;
                ViewState.Add("TreeNodeType", sTreeNodeType);
            }
        }


        protected string vsKeyId
        {
            get
            {
                string sKeyId;
                sKeyId = (string)ViewState["KeyId"];
                if (sKeyId == null)
                {
                    sKeyId = "";
                }
                return sKeyId;
            }
            set
            {
                string sKeyId = value;
                ViewState.Add("KeyId", sKeyId);
            }
        }

        protected void wucMenu1_afterSelect_Tz1()
        {

        }

        protected void mnuTopMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            string strMenuName = e.Item.Text;
            string strMenuValue = e.Item.Value;
            lblMsg.Text = string.Format("Text:{0}, Value:{1}", strMenuName, strMenuValue);
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string strMenuName = e.Item.Text;
            string strMenuValue = e.Item.Value;
            
            lblMsg.Text = string.Format("Text:{0}, Value:{1}", strMenuName, strMenuValue);
            e.Item.Text = string.Format("<span class='selectedNode'>{0}</span>", e.Item.Text);
        }
    }
}