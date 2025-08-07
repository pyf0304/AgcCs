<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T_WorkFlow1.aspx.cs" Inherits="AgcMvc3.Webform.A_TestWorkFlow.T_WorkFlow1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li>
                    <asp:Button ID="btnDispWorkFlow" runat="server" Text="显示工作流" OnClick="btnDispWorkFlow_Click" />
                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel>
                </li> 
                <li>
                    <asp:Button ID="btnSetLevelNo" runat="server" Text="设置层No" OnClick="btnSetLevelNo_Click" />
                </li>
                <li>
                    <asp:Button ID="btnCreateWorkFlow" runat="server" Text="建立工作流" OnClick="btnCreateWorkFlow_Click"/>
                </li>
                <li>
                        <asp:DropDownList ID="ddlWorkFlowId" runat="server"></asp:DropDownList>  <asp:Button ID="btnInitWorkFlow" runat="server" Text="初始化工作流" OnClick="btnInitWorkFlow_Click" />
                </li>
                <li>
                    <asp:CheckBox ID="chkLimitInWorkFlow_Start" runat="server" Text="限于本工作流" AutoPostBack="true" OnCheckedChanged="chkLimitInWorkFlow_Start_CheckedChanged" />
                    <asp:DropDownList ID="ddlStartPoint" runat="server"></asp:DropDownList>
                    <asp:CheckBox ID="chkLimitInWorkFlow_End" runat="server" Text="限于本工作流" AutoPostBack="true" OnCheckedChanged="chkLimitInWorkFlow_End_CheckedChanged" />
                    <asp:DropDownList ID="ddlEndPoint" runat="server"></asp:DropDownList>
                    <asp:Button ID="btnAddPrecess" runat="server" Text="添加过程" OnClick="btnAddPrecess_Click"/>
                </li>
            </ul>
            <span class="text-info"style="font-size:12px;">text-info</span>
            <span class="text-dark" style="font-size:10px;">text-dark</span>
        </div>
    </form>
</body>
</html>
