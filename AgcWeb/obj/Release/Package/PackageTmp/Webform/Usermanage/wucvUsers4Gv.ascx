<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvUsers4Gv.ascx.cs" Inherits="AGC.Webform.wucvUsers4Gv" %>
<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvUsers" Style="z-index: 102;" runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvUsers_Sorting"
        OnPageIndexChanging="gvUsers_PageIndexChanging"
        OnRowCreated="gvUsers_RowCreated"
        OnRowCommand="gvUsers_RowCommand"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="UserId"
        CssClass="table table-bordered table-hover table-striped">
        <Columns>
            <asp:TemplateField HeaderText="">
                <HeaderStyle Width="10px" />
                <HeaderTemplate>
                    <asp:CheckBox ID="chkSelAll" CommandName="SelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" AutoPostBack="true" OnCheckedChanged="chkSelAll_CheckedChanged" Text=""></asp:CheckBox>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_Users<%# Eval("UserId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="UserId" SortExpression="UserId" HeaderText="用户Id"></asp:BoundField>
            <asp:BoundField DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundField>
            <asp:BoundField DataField="DepartmentName" SortExpression="DepartmentName" HeaderText="部门名称"></asp:BoundField>
            <asp:BoundField DataField="DepartmentAbbrName" SortExpression="DepartmentAbbrName" HeaderText="部门简称"></asp:BoundField>
            <asp:BoundField DataField="DepartmentTypeName" SortExpression="DepartmentTypeName" HeaderText="部门类型"></asp:BoundField>
            <asp:BoundField DataField="UpDepartmentName" SortExpression="UpDepartmentName" HeaderText="上级部门名"></asp:BoundField>
            <asp:BoundField DataField="UserStateName" SortExpression="UserStateName" HeaderText="用户状态名"></asp:BoundField>
            <asp:BoundField DataField="EffectiveDate" SortExpression="EffectiveDate" HeaderText="有效日期"></asp:BoundField>
            <asp:BoundField DataField="EffitiveBeginDate" SortExpression="EffitiveBeginDate" HeaderText="有效开始日期"></asp:BoundField>
            <asp:BoundField DataField="EffitiveEndDate" SortExpression="EffitiveEndDate" HeaderText="有效结束日期"></asp:BoundField>
            <asp:BoundField DataField="Password" SortExpression="Password" HeaderText="口令"></asp:BoundField>
            <asp:BoundField DataField="IdentityDesc" SortExpression="IdentityDesc" HeaderText="身份"></asp:BoundField>
            <asp:BoundField DataField="Email" SortExpression="Email" HeaderText="电子邮箱"></asp:BoundField>
            <asp:BoundField DataField="IsGpUser" SortExpression="IsGpUser" HeaderText="平台用户?"></asp:BoundField>
            <asp:BoundField DataField="RegisterPassword" SortExpression="RegisterPassword" HeaderText="注册密码"></asp:BoundField>
            <asp:BoundField DataField="IsRegister" SortExpression="IsRegister" HeaderText="注册?"></asp:BoundField>
            <asp:BoundField DataField="RegisterDate" SortExpression="RegisterDate" HeaderText="注册日期"></asp:BoundField>
            <asp:BoundField DataField="IsAudit" SortExpression="IsAudit" HeaderText="审核?"></asp:BoundField>
            <asp:BoundField DataField="AuditUser" SortExpression="AuditUser" HeaderText="审核人"></asp:BoundField>
            <asp:BoundField DataField="AuditDate" SortExpression="AuditDate" HeaderText="审核日期"></asp:BoundField>
            <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
            <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者"></asp:BoundField>
            <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>
        </Columns>
        <PagerTemplate>
            <span class="text-info col-form-label-sm">共有记录:</span>
            <asp:Label ID="lblRecCount" runat="server" CssClass="text-info col-form-label-sm" ForeColor="#000066" Width="36px">0</asp:Label>
            <span class="text-info col-form-label-sm">
                <div style="display: inline; width: 16px; height: 13px">
                </div>
            </span><span class="text-info col-form-label-sm">总页数:</span>
            <asp:Label ID="lblAllPages" runat="server" CssClass="text-info col-form-label-sm" ForeColor="#000066">0</asp:Label>
            <div style="display: inline; width: 16px; height: 13px">
            </div>
            <span class="text-info col-form-label-sm">当前页:</span>
            <asp:Label ID="lblCurrentPage" runat="server" CssClass="text-info col-form-label-sm" ForeColor="#000066">0</asp:Label>
            <div style="display: inline; width: 16px; height: 13px">
            </div>
            <asp:Button ID="btnPrevPage" runat="server" CssClass="btn btn-info btn-sm" Text="上一页"
                CommandArgument="Prev" CommandName="PrevPage" /><span style="font-family: Verdana">
                </span>
            <asp:Button ID="btnNextPage" runat="server" CssClass="btn btn-info btn-sm" Text="下一页"
                CommandArgument="Next" CommandName="NextPage" />
            <span class="text-info col-form-label-sm">到第</span>
            <asp:TextBox ID="txtJump2Page" runat="server" CssClass="form-control-sm" Width="35px"></asp:TextBox>
            <span class="text-info col-form-label-sm">页</span>
            <asp:Button ID="btnJumpPage" runat="server" CssClass="btn btn-info btn-sm" OnClick="btnJumpPage_Click"
                Text="确定" CommandName="Page" />
            <span class="text-info col-form-label-sm">页记录数:</span>
            <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="btn btn-outline-info btn-sm"
                Width="70px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>100</asp:ListItem>
                <asp:ListItem>1000</asp:ListItem>
            </asp:DropDownList>
            <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                ErrorMessage="错误!" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
        </PagerTemplate>
        <FooterStyle CssClass="FooterStyle" />
        <RowStyle CssClass="RowStyle" />
        <EmptyDataRowStyle CssClass="EmptyDataRowStyle" />
        <SelectedRowStyle CssClass="SelectedRowStyle" />
        <PagerStyle CssClass="PagerStyle" />
        <HeaderStyle CssClass="HeaderStyle" />
        <EditRowStyle CssClass="EditRowStyle" />
        <AlternatingRowStyle CssClass="AlternatingRowStyle" />
    </asp:GridView>
</div>
