<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvTabFeatureFlds4Gv.ascx.cs" Inherits="AGC.Webform.wucvTabFeatureFlds4Gv" %>

<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvTabFeatureFlds"  runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvTabFeatureFlds_Sorting"
        OnPageIndexChanging="gvTabFeatureFlds_PageIndexChanging"
        OnRowCreated="gvTabFeatureFlds_RowCreated"
        OnRowCommand="gvTabFeatureFlds_RowCommand"
        OnRowDeleting="gvTabFeatureFlds_RowDeleting"
        OnRowUpdating="gvTabFeatureFlds_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="mId"
        CssClass="table table-striped table-bordered table-condensed" OnRowDataBound="gvTabFeatureFlds_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="全选">
                <HeaderStyle Width="35px" />
                <HeaderTemplate>
                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" Text="全选"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_TabFeatureFlds<%# Eval("mId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
            <asp:BoundField DataField="TabFeatureName" SortExpression="TabFeatureName" HeaderText="表功能"></asp:BoundField>
            <asp:BoundField DataField="FldName" SortExpression="FldName" HeaderText="字段"></asp:BoundField>
            <asp:BoundField DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundField>
            <asp:BoundField DataField="FieldTypeId" SortExpression="FieldTypeId" HeaderText="字段类型Id" Visible="false"></asp:BoundField>
            <asp:BoundField DataField="FieldTypeName" SortExpression="FieldTypeName" HeaderText="类型名"></asp:BoundField>
            <asp:BoundField DataField="ValueGivingModeName" SortExpression="ValueGivingModeName" HeaderText="给值方式"></asp:BoundField>

            <asp:BoundField DataField="FuncName" SortExpression="FuncName" HeaderText="函数名"></asp:BoundField>
            <asp:BoundField DataField="DefaultValue" SortExpression="DefaultValue" HeaderText="缺省值"></asp:BoundField>
            <asp:BoundField DataField="InUse" SortExpression="InUse" HeaderText="是否在用"></asp:BoundField>
            <asp:BoundField DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="数据类型"></asp:BoundField>
            <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者"  Visible="false"></asp:BoundField>
            <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"  Visible="false"></asp:BoundField>
            <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"  Visible="false"></asp:BoundField>
            <asp:TemplateField HeaderText="修改"  Visible="false">
                <ItemTemplate>
                    <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="删除"  Visible="false">
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
                CommandArgument="Prev" CommandName="PrevPage" /><span style="font-family: Verdana">
                </span>
            <asp:Button ID="btnNextPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="下一页"
                CommandArgument="Next" CommandName="NextPage" />
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
