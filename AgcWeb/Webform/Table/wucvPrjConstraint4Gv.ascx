<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvPrjConstraint4Gv.ascx.cs" Inherits="AGC.Webform.wucvPrjConstraint4Gv" %>
<link rel="stylesheet" type="text/css" href="../../css/tz_base1.css" />
<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvPrjConstraint"  runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvPrjConstraint_Sorting"
        OnPageIndexChanging="gvPrjConstraint_PageIndexChanging"
        OnRowCreated="gvPrjConstraint_RowCreated"
        OnRowCommand="gvPrjConstraint_RowCommand"
        OnRowDeleting="gvPrjConstraint_RowDeleting"
        OnRowUpdating="gvPrjConstraint_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="PrjConstraintId"
        CssClass="GridValue" OnRowDataBound="gvPrjConstraint_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="">
                <HeaderStyle Width="10px" />
                <HeaderTemplate>
                    <asp:CheckBox ID="chkSelAll" CommandName="SelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" AutoPostBack="true" OnCheckedChanged="chkSelAll_CheckedChanged" Text=""></asp:CheckBox>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_PrjConstraint<%# Eval("PrjConstraintId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="PrjConstraintId" SortExpression="PrjConstraintId" HeaderText="约束表Id"></asp:BoundField>
            <asp:BoundField DataField="ConstraintName" SortExpression="ConstraintName" HeaderText="约束表名称"></asp:BoundField>
            <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="表名"></asp:BoundField>
            <asp:BoundField DataField="ConstraintTypeName" SortExpression="ConstraintTypeName" HeaderText="约束类型名"></asp:BoundField>
            <asp:BoundField DataField="ConstraintTypeNameEN" SortExpression="ConstraintTypeNameEN" HeaderText="约束类型英文名"></asp:BoundField>
            <asp:BoundField DataField="CreateUserId" SortExpression="CreateUserId" HeaderText="建立用户Id"></asp:BoundField>
            <asp:BoundField DataField="InUse" SortExpression="InUse" HeaderText="是否在用"></asp:BoundField>
            <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
            <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者"></asp:BoundField>
            <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>
        </Columns>
        <PagerTemplate>
            <span style="background-color: #c0c0c0">共有记录:</span>
            <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="36px">0</asp:Label>
            <span style="background-color: #c0c0c0">
                <div style="display: inline; width: 16px; height: 13px">
                </div>
            </span><span style="background-color: #c0c0c0">总页数:</span>
            <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
            <div style="display: inline; width: 16px; height: 13px">
            </div>
            <span style="background-color: #c0c0c0">当前页:</span>
            <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
            <div style="display: inline; width: 16px; height: 13px">
            </div>
            <asp:Button ID="btnPrevPage" runat="server" CssClass="Button_DefaInPager" Text="上一页"
                Width="50px" CommandArgument="Prev" CommandName="PrevPage" /><span style="font-family: Verdana">
                </span>
            <asp:Button ID="btnNextPage" runat="server" CssClass="Button_DefaInPager" Text="下一页"
                Width="50px" CommandArgument="Next" CommandName="NextPage" />
            到第
            <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
            <asp:Button ID="btnJumpPage" runat="server" CssClass="Button_DefaInPager" OnClick="btnJumpPage_Click"
                Text="确定" Width="35px" CommandName="Page" />
            <span style="background-color: #c0c0c0">页记录数:</span>
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
