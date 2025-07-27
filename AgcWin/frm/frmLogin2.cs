using System;
using System.Windows.Forms;
using AGC.Entity;
using AGC_CSWin;
using AGC4WApi;
using com.taishsoft.common;
using GeneralPlatform.Entity;
using GeneralPlatform4WApi;
namespace Agc_CsWin
{
    public partial class frmLogin2 : Form
    {
        public frmLogin2()
        {
            InitializeComponent();
        }

        private void frmLogin2_Load(object sender, System.EventArgs e)
        {
            this.btnUpdatePassWord.Visible = false;
            this.btnEnterSys.Visible = false;

        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            this.LoginJudge();
        }

        private void LoginJudge()
        {
            string strMsg;
            if (this.txtUserID.Text == "")
            {
                strMsg = "请输入用户名!";
                MessageBox.Show(strMsg);
                return;
            }
            stuLoginPara objLoginPara = new stuLoginPara()
            {
                LoginName = this.txtUserID.Text,
                UserPassword = this.txtPassWord.Text,
            };
            //if (LoginIsTrue(this.txtUserID.Text, this.txtPassWord.Text))
            bool bolResult = false;
            try
            {
                bolResult = clsLoginWApi.UserLogin(objLoginPara);
            }
            catch (Exception objException)
            {
                GeneralPlatform4WApi.clsSysPara4WebApi_GP.strCurrIPAddressAndPort = clsMyConfig4AgcWin.CurrIPAddressAndPortBackup;// "202.121.63.9";
                bolResult = clsLoginWApi.UserLogin(objLoginPara);
                GeneralPlatform4WApi.clsSysPara4WebApi_GP.strCurrIPAddressAndPort = clsMyConfig4AgcWin.CurrIPAddressAndPort4WABackup;// "103.116.76.183";

                //com.taishsoft.commdb.clsSpecSQLforSql.IsUseBackupConnect = true;
            }
            if (bolResult == true)
            {
                strMsg = string.Format("strCurrIPAddressAndPort={0}, strCurrPrx={1}.(In {2})",
          GeneralPlatform4WApi.clsSysPara4WebApi_GP.strCurrIPAddressAndPort, AGC4WApi.clsSysPara4WebApi_Agc.strCurrPrx, clsStackTrace.GetCurrClassFunction());
                clsPubVar.objLog.WriteDebugLog(strMsg);

                AGC.Entity.clsSysParaEN.strUserId = this.txtUserID.Text.Trim();
                clsQxUsersEN objUsersEN = clsQxUsersWApi.GetObjByUserId(AGC.Entity.clsSysParaEN.strUserId);

                AGC.Entity.clsSysParaEN.strUserName = objUsersEN.UserName;
                //判断当前用户是否超级管理员
                //if (clsUserRoleRelationEx.IsAdmin(clsSysParaEN.strUserId) == true)
                //{
                //    clsUserPrjGrantEN objUserPrjGrantEN = clsUserPrjGrantExWApi.GetFirstUserPrjGrantByUserId(clsSysParaEN.strUserId);
                //    clsSysParaEN.CurrSelPrjId = objUserPrjGrantEN.PrjId;
                //    clsSysParaEN.strUserRoleId = "00000001";
                //    this.Close();
                //    clsSysParaEN.strUserStateId = "0001";
                //    this.Set_UserInfoToSave(this.txtUserID.Text);
                //    strMsg = "登录成功，欢迎你使用本系统!";
                //    return;
                //}

                strMsg = "登录成功，欢迎你使用本系统!";
                int intPrjCountByUserId = clsUserPrjGrantExWApi.GetPrjCountByUserId(AGC.Entity.clsSysParaEN.strUserId);
                if (intPrjCountByUserId == 0)
                {
                    strMsg = "你没有任何项目的权限，请与管理员联系!";
                    MessageBox.Show(strMsg);
                    this.Close();
                    AGC.Entity.clsSysParaEN.strUserStateId = "0000";
                    //return;
                }
                else if (intPrjCountByUserId == 1)
                {
                    clsUserPrjGrantEN objUserPrjGrantEN = clsUserPrjGrantExWApi.GetFirstUserPrjGrantByUserId(AGC.Entity.clsSysParaEN.strUserId);
                    AGC.Entity.clsSysParaEN.CurrSelPrjId = objUserPrjGrantEN.PrjId;
                    clsPubVar.CurrSelPrjId = objUserPrjGrantEN.PrjId;
                    clsPubVar.CurrPrjDataBaseId = clsUserDefaPrjDataBaseExWApi.GetPrjDataBaseIdByPrjIdAndUserId(clsPubVar.CurrSelPrjId, AGC.Entity.clsSysParaEN.strUserId);

                    clsPubVar.objCurrSelProjectEN = clsProjectsWApi.GetObjByPrjId(AGC.Entity.clsSysParaEN.CurrSelPrjId);
                    AGC.Entity.clsSysParaEN.strUserRoleId = objUserPrjGrantEN.RoleId;
                    this.Close();
                    AGC.Entity.clsSysParaEN.strUserStateId = "0001";
                    MessageBox.Show(strMsg);
                }
                else
                {
                    frmUserPrjGrant_SelectPrj frm = new frmUserPrjGrant_SelectPrj();
                    frm.ShowDialog();
                    if (string.IsNullOrEmpty(AGC.Entity.clsSysParaEN.CurrSelPrjId) == true)
                    {
                        strMsg = "你没有选择任何项目，不能使用本系统!";
                        MessageBox.Show(strMsg);
                        this.Close();
                        AGC.Entity.clsSysParaEN.strUserStateId = "0000";
                    }
                    else
                    {
                        this.Close();
                        AGC.Entity.clsSysParaEN.strUserStateId = "0001";
                        MessageBox.Show(strMsg);
                    }
                }
                this.btnGetbackPassWord.Visible = true;
                this.btnUpdatePassWord.Visible = true;
                this.btnEnterSys.Visible = true;
            }
            else
            {
                strMsg = "用户名或密码错误!";
                MessageBox.Show(strMsg);
                return;
            }
            if (clsPubVar.objMainForm == null)
            {
                clsPubVar.objMainForm = new MdiForm();
            }
            clsPubVar.objMainForm.DispMenu();
            clsPubVar.bolIsDispMenu = true;
        }


        private bool LoginIsTrue(string strUserID, string strPassWord)
        {


            bool bolIsResult = false;
            //if (clsSysParaEN.bolIsUseXmlDataSource == true)
            //{
            //    bolIsResult = objUser.GetUsersForXml();
            //}
            //else
            //{

            //}
            clsUsersEN objUser = clsUsersWApi.GetObjByUserId(strUserID);

            if (objUser != null)
            {
                string pwd = objUser.Password.ToString();
                if (pwd.Trim() == strPassWord.Trim())
                    return true;
                else
                    return false;
            }
            else
                return false;
        }


        private void Set_UserInfoToSave(string strUserID)
        {
            //clsSysParaEN.strUserId = strUserID;
            //clsUsersEx objUser = new clsUsersEx();
            //objUser.UserId = strUserID;
            //objUser.GetUsers();
            //string strid_User = objUser.id_User;
            //string strStuTeacherID = objUser.StuTeacherID;
            //string strid_Identity = objUser.id_Identity;
            //SetUserDepartment(strid_Identity,strStuTeacherID);
            //clsQxUserRoleRelEx objUserRoleRel = new clsQxUserRoleRelEx();
            //objUserRoleRel.id_User=strid_User;
            //objUserRoleRel.GetQxUserRoleRel();
            //string strRoleId=objUserRoleRel.RoleId;
            //clsSysParaEN.strUserRoleId = strRoleId;
            //ArrayList arrUserAllRoleIds =  clsLogin.GetAllRoleIdsFromUserId(strid_User);//获得所有角色
            //clsSysParaEN.arrUserAllRoleIds = arrUserAllRoleIds;

            //ArrayList arrobjRights = clsLogin.GetobjRightByArrRoleId(arrUserAllRoleIds);
            //clsSysParaEN.strUserId = strUserID;
            //clsSysParaEN.arrobjRights = arrobjRights;
        }

        private void SetUserDepartment(string strid_Identity, string strStuTeacherID)
        {
            //string strid_College="";
            //System.Data.DataTable objDT = new DataTable();
            //if(strid_Identity=="02")//教师
            //{

            //    objDT = clsTeacherInfo.GetTeacherInfo("TeacherID = '"+strStuTeacherID+"'");
            //    strid_College = objDT.Rows[0]["id_College"].ToString();
            //}
            //else if(strid_Identity=="03")//学生
            //{

            //    objDT = clsvXsStu.GetvXsStu("StuID = '"+strStuTeacherID+"'");
            //    strid_College = objDT.Rows[0]["id_College"].ToString();
            //}
            //else
            //    if (strid_Identity == "01")//管理员
            //    {

            //        //objDT = clsTeacherInfo.GetTeacherInfo("TeacherID = '" + strStuTeacherID + "'");
            //        strid_College = "0000";
            //    }
            //clsSysParaEN.strDepartmentId = strid_College;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnUpdatePassWord_Click(object sender, System.EventArgs e)
        {
            UpdatePassword frm1 = new UpdatePassword();
            frm1.Show();

        }

        private void btnGetbackPassWord_Click(object sender, System.EventArgs e)
        {
            MaintainPassWord frm1 = new MaintainPassWord();
            frm1.Show();
            //		
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {

        }

        private void txtPassWord_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.LoginJudge();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}
