
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.datetime;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    public partial class RegisterUser : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsUserIdentityBL.BindDdlIdentityID(ddlIdentityID);
                clsDepartmentInfoBLEx.BindDdl_DepartmentIdEx(this.ddlDepartmentId);
                //clsXzGradeBaseBLEx.BindDdl_IdGradeBaseEx(ddlIdGrade);
            }
        }


        //用户注册
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            clsUsersEN objUsersEN = new clsUsersEN();
            objUsersEN.UserId = this.txtUserId.Text;  //用户ID
            objUsersEN.UserName = this.txtUserName.Text;//用户名
            objUsersEN.Email = this.txtEmail.Text;//邮箱
            objUsersEN.Password = this.txtPassword.Text;//密码

            objUsersEN.DepartmentId = this.ddlDepartmentId.SelectedValue.ToString();
            //objUsersEN.id_XzMajor = this.id_XzMajor;
            //objUsersEN.IdGradeBase = this.IdGradeBase;
            objUsersEN.IsAudit = false;
            objUsersEN.UserStateId = "02";
            //objUsersEN.IdentityID = ddlIdentityID.SelectedValue;
            //if (ddlIdentityID.SelectedValue != "0003")
            //{
            //    objUsersEN.IsAudit = true;
            //    objUsersEN.IdentityID = "0003";
            //}
            //else
            //{
            //    objUsersEN.IsAudit = false;
            //}
            objUsersEN.IsRegister = true;
            objUsersEN.RegisterDate = clsDateTime.getTodayStr(0);
            objUsersEN.UpdDate = clsDateTime.getTodayStr(0);
            objUsersEN.Memo = this.txtReason.Text;

            //获取角色号ID
            objUsersEN.IdentityID = this.ddlIdentityID.SelectedValue;

            if (objUsersEN.IdentityID == "0" || string.IsNullOrEmpty(objUsersEN.IdentityID) == true)
            {
                lblMessage.Text = "注册用户类型不能为空！";
                return;
            }

            if (clsUsersBL.IsExist(objUsersEN.UserId) == false)
            {
                bool i = clsUsersBL.AddNewRecordBySql2(objUsersEN);
                if (i == true)
                {
                    lblMessage.Text = "注册成功！";
                    clsCommonJsFunc.Alert(this, "注册成功！");
                    //Response.Redirect("Index.aspx");
                    // 不会弹出询问
                }
                else
                {
                    clsCommonJsFunc.Alert(this, "注册失败！");
                }
            }
            else
            {
                lblMessage.Text = "您申请的用户已被注册！";
                clsCommonJsFunc.Alert(this, "您申请的用户已被注册！");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtUserId.Text = "";  //用户ID
            this.txtUserName.Text = "";//用户名
            this.txtPassword.Text = "";//密码
            this.txtReason.Text = "";
            ddlIdentityID.SelectedIndex = 0;
            ddlDepartmentId.SelectedIndex = 0;
            txtReason.Text = "";
        }

        protected void btnReturnIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }


        ////根据选择类型判断是否显示食堂
        //protected void ddlRoleID_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (this.ddlIdentityID.SelectedValue == "0003")
        //    {
        //        this.STang.Visible = true;
        //    }
        //    else
        //    {
        //        this.STang.Visible = false;
        //    }
        //}
        //public string id_XzMajor
        //{
        //    get
        //    {
        //        if (ddlId_XzMajor.SelectedValue == "0")
        //            return "";
        //        return ddlId_XzMajor.SelectedValue;
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            ddlId_XzMajor.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            try
        //            {
        //                ddlId_XzMajor.SelectedValue = value;
        //                if (ddlId_XzMajor.SelectedIndex > 0)
        //                {
        //                    string strId_Major = ddlId_XzMajor.SelectedValue.ToString();

        //                }
        //            }
        //            catch (Exception objException)
        //            {
        //                string ss = objException.Message;
        //            }
        //        }
        //    }
        //}

        //public string IdGradeBase
        //{
        //    get
        //    {
        //        if (ddlIdGrade.SelectedValue == "0")
        //            return "";
        //        return ddlIdGrade.SelectedValue;
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            ddlIdGrade.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            try
        //            {
        //                ddlIdGrade.SelectedValue = value;
        //            }
        //            catch (Exception objException)
        //            {
        //                string strSS = objException.Message;
        //            }
        //        }
        //    }
        //}

    }
}