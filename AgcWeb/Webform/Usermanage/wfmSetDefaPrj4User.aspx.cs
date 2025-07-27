using System.Data;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
//using SqlSv; 


using AGC.Entity;
using AGC.FunClass;

namespace AGC.Webform
{
    /// <summary>
    /// frmLogin 的摘要说明。
    /// </summary>
    public partial class wfmSetDefaPrj4User : System.Web.UI.Page
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)
            {
                lblWelComeMsg.Text = clsCommonSession.objQxUser.UserName + "，欢迎您使用本系统!";
                ShowInfo();
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

        private void BindRad_Projects()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置DATAGRID的数据源(DataSource)；
            //	4、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            //	5、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsUserPrjGrantBLEx.GetUserPrjGrantT1("UserPrjGrant.UserId='" + clsCommonSession.objQxUser.UserId + "'");
            //	3、设置DATAGRID的数据源(DataSource)；
            this.RadioButtonList1.DataSource = objDT.DefaultView;
            this.RadioButtonList1.DataTextField = "ProjectsPrjName";
            this.RadioButtonList1.DataValueField = "prjId";
            //	4、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.RadioButtonList1.DataBind();
        }

        private void ShowInfo()
        {
            ///	绑定单选列表
            BindRad_Projects();
            //操作步骤：（共3步）
            //	1、通过当前用户，查用户缺省值表，查当前用户的默认工程(00050001)是否存在
            //	2、若不存在就查<系统缺省值名称表>中的缺省值，
            //	3、这样就获取了当前用户的默认工程。

            //	1、通过当前用户，查用户缺省值表，查当前用户的默认工程(00050001)是否存在
            DataTable DT = clsUserDefaValue_LocalBL.GetDataTable_UserDefaValue_Local("UserId='" + clsCommonSession.objQxUser.UserId + "'");
            if (DT.Rows.Count == 0)
            {
                //				Response.Write("<script>alert('该用户不存在！')</script>");
                return;
            }
            string DefaValue = DT.Rows[0]["UserDefaValue"].ToString();
            string DefaValNameId = DT.Rows[0]["DefaValNameId"].ToString();

            //	2、若不存在就查<系统缺省值名称表>中的缺省值，
            if (DefaValue == "")
            {
                DT = clsSysDefaValNameBL.GetDataTable_SysDefaValName("DefaValNameId='" + DefaValNameId + "'");
                if (DT.Rows.Count == 0)
                {
                    Response.Write("<script>alert('系统默认数据不存在！')</script>");
                }
                DefaValue = DT.Rows[0]["SysDefaValue"].ToString();
            }

            //	3、这样就获取了当前用户的默认工程。
            if (clsUserPrjGrantBL.IsExistRecord("UserId = '" + clsCommonSession.objQxUser.UserId + "' and PrjId = '" + DefaValue + "'") == true)
            {
                RadioButtonList1.SelectedValue = DefaValue;
            }
            else
            {
                RadioButtonList1.SelectedIndex = 0;
            }
        }


        protected void btnGO_Click(object sender, System.EventArgs e)
        {
            //Session["P1rjId"]=RadioButtonList1.SelectedValue.ToString();
            Response.Redirect("wfmPrjUserRole_QUDI.aspx");
        }

        protected void btnSetDefaPrj_Click(object sender, System.EventArgs e)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
            string strDefaPrjId;
            strDefaPrjId = RadioButtonList1.SelectedValue.ToString();
            clsUserDefaValue_LocalEN objUserDefaValue = new clsUserDefaValue_LocalEN();
            ///判断该用户是否有缺省值
            if (clsUserDefaValue_LocalBL.IsExistRecord("UserId = '" + clsCommonSession.objQxUser.UserId + "'") == false)
            {
                objUserDefaValue.UserDefaValue = strDefaPrjId;
                objUserDefaValue.UserId = clsCommonSession.objQxUser.UserId;
                objUserDefaValue.DefaValNameId = "00050001";
                clsUserDefaValue_LocalBL.AddNewRecordBySql2(objUserDefaValue);
            }
            else
            {
                objUserDefaValue.mId = long.Parse(clsUserDefaValue_LocalBL.GetPrimaryKeyID_S("UserId='" + clsCommonSession.objQxUser.UserId + "'")[0].ToString());
                clsUserDefaValue_LocalBL.GetUserDefaValue_Local(ref objUserDefaValue);
                objUserDefaValue.UserDefaValue = strDefaPrjId;
                clsUserDefaValue_LocalBL.UpdateBySql2(objUserDefaValue);
            }
            //PrjId = strDefaPrjId;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(strDefaPrjId);
            new clsCommonSession().PrjDataBaseName = objPrjDataBase.DataBaseName;
            lblMsg.Text = "当前用户默认工程已经设置为：" + objProject.PrjName;
        }
    }
}
