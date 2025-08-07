<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvFeatureRegionFlds4Gv.ascx.cs" Inherits="AGC.Webform.wucvFeatureRegionFlds4Gv" %>

<%-- 列表层 --%>

<div id="divList" class="div_List" runat="server">
    <asp:GridView ID="gvFeatureRegionFlds"  runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvFeatureRegionFlds_Sorting"
        OnPageIndexChanging="gvFeatureRegionFlds_PageIndexChanging"
        OnRowCreated="gvFeatureRegionFlds_RowCreated"
        OnRowCommand="gvFeatureRegionFlds_RowCommand"
        OnRowDeleting="gvFeatureRegionFlds_RowDeleting"
        OnRowUpdating="gvFeatureRegionFlds_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="ViewFeatureId"
        CssClass="table table-sm table-striped table-bordered table-condensed" OnRowDataBound="gvFeatureRegionFlds_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="">
                <HeaderStyle Width="12px" />
                <HeaderTemplate>
                     <asp:CheckBox ID="chkSelAll" CommandName="SelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" AutoPostBack="true" OnCheckedChanged="chkSelAll_CheckedChanged" Text=""></asp:CheckBox>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_FeatureRegionFlds<%# Eval("ViewFeatureId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="RegionName" SortExpression="RegionName" HeaderText="区域"></asp:BoundField>

            <asp:BoundField DataField="SeqNum" SortExpression="SeqNum" HeaderText="No"></asp:BoundField>
            <asp:BoundField DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称" Visible="false"></asp:BoundField>
            <asp:BoundField DataField="FeatureName" SortExpression="FeatureName" HeaderText="功能/按钮文本"></asp:BoundField>
            <asp:BoundField DataField="FeatureDescription" SortExpression="FeatureDescription" HeaderText="说明" Visible="false"></asp:BoundField>
            <asp:BoundField DataField="KeyWords" SortExpression="KeyWords" HeaderText="关键字" Visible="false"></asp:BoundField>
            <asp:BoundField DataField="ButtonName" SortExpression="ButtonName" HeaderText="按钮名"></asp:BoundField>
            <asp:BoundField DataField="ButtonName4Mvc" SortExpression="ButtonName4Mvc" HeaderText="按钮名Mvc"></asp:BoundField>
            <asp:BoundField DataField="EventFuncName" SortExpression="EventFuncName" HeaderText="事件函数"></asp:BoundField>
            <asp:BoundField DataField="Text" SortExpression="Text" HeaderText="文本"></asp:BoundField>
            <asp:BoundField DataField="GroupName" SortExpression="GroupName" HeaderText="组名"></asp:BoundField>
            <asp:BoundField DataField="RelaTabName" SortExpression="RelaTabName" HeaderText="相关表"></asp:BoundField>
            <asp:BoundField DataField="RelaFldName" SortExpression="RelaFldName" HeaderText="相关字段"></asp:BoundField>
            <asp:BoundField DataField="FieldTypeName" SortExpression="FieldTypeName" HeaderText="字段类型"></asp:BoundField>
            <asp:BoundField DataField="ValueGivingModeName" SortExpression="ValueGivingModeName" HeaderText="给值方式名"></asp:BoundField>
            <asp:BoundField DataField="FuncName" SortExpression="FuncName" HeaderText="函数名"></asp:BoundField>
            <asp:BoundField DataField="DefaultValue" SortExpression="DefaultValue" HeaderText="默认值"></asp:BoundField>
<%--            <asp:BoundField DataField="ViewImplName" SortExpression="ViewImplName" HeaderText="实现区域" ></asp:BoundField>--%>
            <asp:BoundField DataField="CtlTypeName" SortExpression="CtlTypeName" HeaderText="控件类型"></asp:BoundField>
<%--            <asp:BoundField DataField="Width" SortExpression="Width" HeaderText="宽" Visible="false"></asp:BoundField>--%>
            <asp:BoundField DataField="FldNum" SortExpression="FldNum" HeaderText="字段数"></asp:BoundField>
            <asp:BoundField DataField="InUse" SortExpression="InUse" HeaderText="在用?"></asp:BoundField>
            <asp:BoundField DataField="TabFeatureName" SortExpression="TabFeatureName" HeaderText="表功能"></asp:BoundField>
            <asp:BoundField DataField="CheckTabFeature" SortExpression="CheckTabFeature" HeaderText="检查表功能"></asp:BoundField>

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
