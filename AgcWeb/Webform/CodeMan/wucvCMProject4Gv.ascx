<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvCMProject4Gv.ascx.cs" Inherits="AGC.Webform.wucvCMProject4Gv" %>
<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvCMProject" Style="z-index: 102;" runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvCMProject_Sorting"
        OnPageIndexChanging="gvCMProject_PageIndexChanging"
        OnRowCreated="gvCMProject_RowCreated"
        OnRowCommand="gvCMProject_RowCommand"
        OnRowDeleting="gvCMProject_RowDeleting"
        OnRowUpdating="gvCMProject_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="CmPrjId"
        CssClass="table table-bordered table-hover table-striped">
        <Columns>
            <asp:TemplateField HeaderText="">
                <HeaderStyle Width="10px" />
                <HeaderTemplate>
                    <asp:CheckBox ID="chkSelAll" CommandName="SelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" AutoPostBack="true" OnCheckedChanged="chkSelAll_CheckedChanged" Text=""></asp:CheckBox>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_CMProject<%# Eval("CmPrjId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="CmPrjId" SortExpression="CmPrjId" HeaderText="工程ID"></asp:BoundField>
            <asp:BoundField DataField="CmPrjName" SortExpression="CmPrjName" HeaderText="CM工程名"></asp:BoundField>
            <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程"></asp:BoundField>
            <asp:BoundField DataField="ApplicationTypeSimName" SortExpression="ApplicationTypeSimName" HeaderText="应用"></asp:BoundField>
            <asp:BoundField DataField="IsFstLcase" SortExpression="IsFstLcase" HeaderText="首字母小写"></asp:BoundField>
            <asp:BoundField DataField="ProjectFileName" SortExpression="ProjectFileName" HeaderText="工程文件"></asp:BoundField>
            <asp:BoundField DataField="IsRefresh4RelaView" SortExpression="IsRefresh4RelaView" HeaderText="刷新相关视图?"></asp:BoundField>
            <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
            <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>
            <asp:TemplateField HeaderText="修改">
                <ItemTemplate>
                    <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="删除">
                <ItemTemplate>
                    <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
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
