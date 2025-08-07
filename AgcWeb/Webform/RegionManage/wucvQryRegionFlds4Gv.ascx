<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvQryRegionFlds4Gv.ascx.cs" Inherits="AGC.Webform.wucvQryRegionFlds4Gv" %>

<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvQryRegionFlds" runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvQryRegionFlds_Sorting"
        OnPageIndexChanging="gvQryRegionFlds_PageIndexChanging"
        OnRowCreated="gvQryRegionFlds_RowCreated"
        OnRowCommand="gvQryRegionFlds_RowCommand"
        OnRowDeleting="gvQryRegionFlds_RowDeleting"
        OnRowUpdating="gvQryRegionFlds_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="mId"
        CssClass="table table-striped table-bordered table-condensed" OnRowDataBound="gvQryRegionFlds_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="全选">
                <HeaderStyle Width="35px" />
                <HeaderTemplate>
                    <asp:CheckBox ID="chkSelAll" CommandName="SelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" AutoPostBack="true" OnCheckedChanged="chkSelAll_CheckedChanged" Text=""></asp:CheckBox>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_QryRegionFlds<%# Eval("mId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField Visible="False" DataField="mId" SortExpression="mId" HeaderText="mId"></asp:BoundField>
            <asp:BoundField Visible="False" DataField="RegionId" SortExpression="RegionId" HeaderText="区域Id"></asp:BoundField>
            <%--<asp:BoundField Visible="False" DataField="TabFldId" SortExpression="TabFldId" HeaderText="表字段ID"></asp:BoundField>--%>
            <asp:BoundField DataField="SeqNum" SortExpression="SeqNum" HeaderText="序号"></asp:BoundField>
            <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="表名"
                Visible="False"></asp:BoundField>
            <asp:BoundField DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundField>
            <asp:BoundField DataField="LabelCaption" SortExpression="LabelCaption" HeaderText="标题"></asp:BoundField>
            <asp:BoundField DataField="SourceTabName" SortExpression="SourceTabName" HeaderText="源表"></asp:BoundField>

            <asp:BoundField DataField="CtlTypeName" SortExpression="CtlTypeName" HeaderText="控件类型"></asp:BoundField>
            <asp:BoundField Visible="False" DataField="DdlItemsOptionName" SortExpression="DdlItemsOptionName" HeaderText="下拉框列表选项ID"></asp:BoundField>

            <asp:BoundField Visible="False" DataField="DsDataValueFieldName" SortExpression="DsDataValueFieldName" HeaderText="数据源值字段"></asp:BoundField>
            <asp:BoundField Visible="False" DataField="DsDataTextFieldName" SortExpression="DsDataTextFieldName" HeaderText="数据源文本字段"></asp:BoundField>

            <asp:BoundField Visible="False" DataField="QueryOptionName" SortExpression="QueryOptionName" HeaderText="查询方式"></asp:BoundField>
            <asp:BoundField Visible="False" DataField="DsCondStr" SortExpression="DsCondStr" HeaderText="数据源条件串"></asp:BoundField>
            <asp:BoundField Visible="False" DataField="DsSqlStr" SortExpression="DsSqlStr" HeaderText="数据源SQL串"></asp:BoundField>
            <asp:BoundField Visible="False" DataField="ItemsString" SortExpression="ItemsString" HeaderText="列表项串"></asp:BoundField>
            <asp:BoundField DataField="ColSpan" SortExpression="ColSpan" HeaderText="跨列"></asp:BoundField>
            <asp:BoundField DataField="Width" SortExpression="Width" HeaderText="宽"></asp:BoundField>
            <asp:BoundField DataField="InUse" SortExpression="InUse" HeaderText="使用?"></asp:BoundField>


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
        <AlternatingRowStyle CssClass="RowStyle" />
    </asp:GridView>
</div>
