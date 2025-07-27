<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="RegisterUser.ascx.cs" Inherits="AGC.Webform.RegisterUser" %>

<script src="../../Js/jquery-1.3.2.min.js" type="text/javascript"></script>
<script src="../../Js/jquery.form.js" type="text/javascript"></script>
<script src="../../Js/jquery.validate.min.js" type="text/javascript"></script>
<script src="../../Js/messages_cn.js" type="text/javascript"></script>
<script src="../../Js/cursorfocus.js" type="text/javascript"></script>

<%--<script type="text/javascript">
    $(function () {
        //表单验证JS
        $("#form1").validate({
            //出错时添加的标签
            errorElement: "span",
            success: function (label) {
                //正确时的样式
                label.text(" ").addClass("success");
            }
        });

    });
</script>--%>

<table style="width: 100%" id="tabLayout" cellspacing="2" cellpadding="2" runat="server" class="msgtable">
    <tr>
        <td align="right">
            <asp:Label ID="lblRoleID" runat="server" CssClass="col-form-label text-right" Width="70px">用户类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlIdentityID" runat="server" Width="200px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr runat="server" id="STang">
        <td align="right">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">选择部门</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDepartmentId" runat="server" Width="200px" ></asp:DropDownList>
        </td>
    </tr>
    <%--  <tr runat="server" id="Tr1">
        <td align="right">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">选择专业</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlId_XzMajor" runat="server" Width="200px"></asp:DropDownList>
        </td>
    </tr>
     <tr>
        <td align="right">
             <asp:Label ID="lblIdGrade" runat="server" CssClass="col-form-label text-right">年级</asp:Label>
         </td>
         <td class="ValueTD" style="width: 186px;">
             <asp:DropDownList ID="ddlIdGrade" runat="server" class="form-control-sm" Width="220px">
             </asp:DropDownList>
         </td>
     </tr>--%>
    <tr>
        <td align="right" style="width: 30%">
            <asp:Label ID="lblUserId" runat="server" CssClass="col-form-label text-right">账号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server" CssClass="input w380 required" MaxLength="50"
                minlength="3" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblUserName" runat="server" CssClass="col-form-label text-right">姓名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUserName" runat="server" CssClass="input w380 required" MaxLength="50"
                minlength="2" Width="200px"></asp:TextBox>
        </td>
    </tr>
      <tr>
        <td align="right">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">邮箱</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtEmail" runat="server" CssClass="input w380 required" MaxLength="50"
                minlength="2" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblPassword" runat="server" CssClass="col-form-label text-right">密码</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPassword" runat="server" CssClass="input w380 required" MaxLength="50" TextMode="Password"
                minlength="3" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblPwds" runat="server" CssClass="col-form-label text-right">确认密码</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPwdTwo" runat="server" TextMode="Password" CssClass="input w380 required" MaxLength="50" minlength="3" Width="200px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPwdTwo" ErrorMessage="两次密码输入不一致" ForeColor="Red"></asp:CompareValidator>
        </td>
    </tr>




    <tr>
        <td align="right">
            <asp:Label ID="lblReason" runat="server" CssClass="col-form-label text-right">备注</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtReason" runat="server" CssClass="w380" MaxLength="500" minlength="3" Width="300px" TextMode="MultiLine" Height="50px"></asp:TextBox>
        </td>
    </tr>
    <tr>

        <td class="NameTD" style="text-align: center"></td>
        <td class="ValueTD">

            <asp:Button ID="btnRegister" runat="server" Text="提交"   CssClass="btn btn-outline-info btn-sm" OnClick="btnRegister_Click" />

            &nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="重置"   CssClass="btn btn-outline-info btn-sm" OnClick="btnCancel_Click" />
            &nbsp;<asp:Button ID="btnReturnIndex" runat="server" Text="返回登录"   CssClass="btn btn-outline-info btn-sm" OnClick="btnReturnIndex_Click" />
            &nbsp;
                        <asp:Label ID="lblMessage" Text="" runat="server" ForeColor="Red">
                        </asp:Label>
        </td>

    </tr>
</table>
