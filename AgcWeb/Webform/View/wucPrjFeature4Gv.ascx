<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucPrjFeature4Gv.ascx.cs" Inherits="AGC.Webform.wucPrjFeature4Gv" %>

<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvPrjFeature"  runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="20" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvPrjFeature_Sorting"
        OnPageIndexChanging="gvPrjFeature_PageIndexChanging"
        OnRowCreated="gvPrjFeature_RowCreated"
        OnRowCommand="gvPrjFeature_RowCommand"
        OnRowDeleting="gvPrjFeature_RowDeleting"
        OnRowUpdating="gvPrjFeature_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="FeatureId"
        CssClass="table table-sm table-striped table-bordered table-condensed">
        <Columns>
            <asp:TemplateField HeaderText="全选">
                <HeaderStyle Width="35px" />
                <HeaderTemplate>
                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" Text="全选"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_PrjFeature<%# Eval("FeatureId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
            <asp:BoundField DataField="FeatureId" SortExpression="FeatureId" HeaderText="功能Id"></asp:BoundField>
            <asp:BoundField DataField="FeatureName" SortExpression="FeatureName" HeaderText="功能名称"></asp:BoundField>
            <asp:BoundField DataField="KeyWords" SortExpression="KeyWords" HeaderText="关键字"></asp:BoundField>
            <asp:BoundField DataField="FeatureDescription" SortExpression="FeatureDescription" HeaderText="功能说明"></asp:BoundField>
            <asp:BoundField DataField="FunctionGroupId" SortExpression="FunctionGroupId" HeaderText="函数组Id"></asp:BoundField>
            <asp:BoundField DataField="FunctionGroupName" SortExpression="FunctionGroupName" HeaderText="函数组名称"></asp:BoundField>
            <asp:BoundField DataField="FeatureTypeId" SortExpression="FeatureTypeId" HeaderText="功能类型Id"></asp:BoundField>
            <asp:BoundField DataField="FeatureTypeName" SortExpression="FeatureTypeName" HeaderText="功能类型名称"></asp:BoundField>
            <asp:BoundField DataField="CreateUserId" SortExpression="CreateUserId" HeaderText="建立用户Id"></asp:BoundField>
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
