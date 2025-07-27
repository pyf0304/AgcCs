<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvAppCodeTypeRela4Gv.ascx.cs" Inherits="AGC.Webform.wucvAppCodeTypeRela4Gv" %>

<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvAppCodeTypeRela" Style="z-index: 101; " runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvAppCodeTypeRela_Sorting"
        OnPageIndexChanging="gvAppCodeTypeRela_PageIndexChanging"
        OnRowCreated="gvAppCodeTypeRela_RowCreated"
        OnRowCommand="gvAppCodeTypeRela_RowCommand"
        OnRowDeleting="gvAppCodeTypeRela_RowDeleting"
        OnRowUpdating="gvAppCodeTypeRela_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="mId"
        CssClass="table table-striped table-bordered table-condensed">
        <Columns>
            <asp:TemplateField HeaderText="全选">
                <HeaderStyle Width="35px" />
                <HeaderTemplate>
                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" Text="全选"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_AppCodeTypeRela<%# Eval("mId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId" Visible="false"></asp:BoundField>
            <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
            <asp:BoundField DataField="CodeTypeId" SortExpression="CodeTypeId" HeaderText="代码类型Id"></asp:BoundField>
            <asp:BoundField DataField="CodeTypeName" SortExpression="CodeTypeName" HeaderText="代码类型名"></asp:BoundField>
            <asp:BoundField DataField="GroupName" SortExpression="GroupName" HeaderText="组名"></asp:BoundField>
            <asp:BoundField DataField="ProgLangTypeName" SortExpression="ProgLangTypeName" HeaderText="代码语言"></asp:BoundField>
            <asp:BoundField DataField="ApplicationTypeName" SortExpression="ApplicationTypeName" HeaderText="应用类型"></asp:BoundField>
            <asp:BoundField DataField="ViewTypeName" SortExpression="ViewTypeName" HeaderText="界面类型"></asp:BoundField>
            <asp:BoundField DataField="TabMainTypeName" SortExpression="TabMainTypeName" HeaderText="表主类型"></asp:BoundField>
            
            <asp:BoundField DataField="DependsOn" SortExpression="DependsOn" HeaderText="依赖于"></asp:BoundField>
            <asp:BoundField DataField="FrontOrBack" SortExpression="FrontOrBack" HeaderText="前后台"></asp:BoundField>
            <asp:BoundField DataField="ProgLangTypeId" SortExpression="ProgLangTypeId" HeaderText="语言Id"></asp:BoundField>
            <%--<asp:BoundField DataField="ProgLangTypeId3" SortExpression="ProgLangTypeId3" HeaderText="编程语言类型Id3"></asp:BoundField>--%>
            <asp:BoundField DataField="AppCount" SortExpression="AppCount" HeaderText="应用数"></asp:BoundField>
            <asp:BoundField DataField="IsVisible" SortExpression="IsVisible" HeaderText="是否显示"></asp:BoundField>
            <asp:BoundField DataField="IsInGroupGeneCode" SortExpression="IsInGroupGeneCode" HeaderText="组生成代码?"></asp:BoundField>
            <asp:BoundField DataField="ApplicationTypeId" SortExpression="ApplicationTypeId" HeaderText="应用类型ID" ></asp:BoundField>
            <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
            <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者"></asp:BoundField>
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
            <span class="text-secondary">共有记录:</span>
            <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="36px">0</asp:Label>
            <span style="background-color: #c0c0c0">
                <div style="display: inline; width: 16px; height: 13px">
                </div>
            </span><span class="text-secondary">总页数:</span>
            <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
            <div style="display: inline; width: 16px; height: 13px">
            </div>
            <span class="text-secondary">当前页:</span>
            <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
            <div style="display: inline; width: 16px; height: 13px">
            </div>
            <asp:Button ID="btnPrevPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="上一页"
                CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
                </span>
            <asp:Button ID="btnNextPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="下一页"
                CommandArgument="Next" CommandName="Page" />
            到第
            <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
            <asp:Button ID="btnJumpPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" OnClick="btnJumpPage_Click"
                Text="确定" Width="45px" CommandName="Page" />
            <span class="text-secondary">页记录数:</span>
            <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                Width="55px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
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
