<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvViewFeatureFlds4Gv.ascx.cs" Inherits="AGC.Webform.wucvViewFeatureFlds4Gv" %>
<link rel="stylesheet" type="text/css" href="../../css/tz_base1.css" />
<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvViewFeatureFlds"  runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvViewFeatureFlds_Sorting"
        OnPageIndexChanging="gvViewFeatureFlds_PageIndexChanging"
        OnRowCreated="gvViewFeatureFlds_RowCreated"
        OnRowCommand="gvViewFeatureFlds_RowCommand"
        OnRowDeleting="gvViewFeatureFlds_RowDeleting"
        OnRowUpdating="gvViewFeatureFlds_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="mId"
        CssClass="GridValue" OnRowDataBound="gvViewFeatureFlds_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="全选">
                <HeaderStyle Width="30px" />
                <HeaderTemplate>
                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="DgSelAll" Text="全选"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_ViewFeatureFlds<%# Eval("mId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField Visible="False" DataField="mId" SortExpression="mId" HeaderText="mId"></asp:BoundField>
            <asp:BoundField Visible="False" DataField="RegionId" SortExpression="RegionId" HeaderText="区域Id"></asp:BoundField>
            <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
            <asp:BoundField DataField="FeatureName" SortExpression="FeatureName" HeaderText="功能名" Visible="true"></asp:BoundField>
            <asp:BoundField DataField="RelaTabName" SortExpression="RelaTabName" HeaderText="表名" Visible="true"></asp:BoundField>
            <asp:BoundField DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundField>
            <asp:BoundField DataField="FieldTypeId" SortExpression="FieldTypeId" HeaderText="字段类型Id" Visible="false"></asp:BoundField>
            <asp:BoundField DataField="FieldTypeName" SortExpression="FieldTypeName" HeaderText="字段类型"></asp:BoundField>
                    
            <asp:BoundField DataField="FuncName" SortExpression="FuncName" HeaderText="函数名" Visible="false"></asp:BoundField>
<%--            <asp:BoundField DataField="DefaultValue" SortExpression="DefaultValue" HeaderText="缺省值"></asp:BoundField>--%>

            <asp:BoundField DataField="LabelCaption" SortExpression="LabelCaption" HeaderText="标题"></asp:BoundField>
             <asp:BoundField DataField="CtrlId" SortExpression="CtrlId" HeaderText="控件Id"></asp:BoundField>
           
            <asp:BoundField DataField="CtlTypeName" SortExpression="CtlTypeName" HeaderText="控件类型"></asp:BoundField>
<%--            <asp:BoundField DataField="DdlItemsOptionName" SortExpression="DdlItemsOptionName" HeaderText="下拉列表选项"></asp:BoundField>
            <asp:BoundField Visible="False" DataField="OUTTabName" SortExpression="OUTTabName" HeaderText="数据源表"></asp:BoundField>--%>
<%--            <asp:BoundField DataField="DsDataValueFieldName" SortExpression="DsDataValueFieldName" HeaderText="值字段"></asp:BoundField>
            <asp:BoundField DataField="DsDataTextFieldName" SortExpression="DsDataTextFieldId" HeaderText="文本字段"></asp:BoundField>
            <asp:BoundField DataField="DsCondStr" SortExpression="DsCondStr" HeaderText="条件串"></asp:BoundField>--%>
            <asp:BoundField Visible="False" DataField="DsSqlStr" SortExpression="DsSqlStr" HeaderText="数据源SQL串"></asp:BoundField>
            <asp:BoundField Visible="False" DataField="ItemsString" SortExpression="ItemsString" HeaderText="列表项串"></asp:BoundField>
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
