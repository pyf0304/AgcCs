
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucvFrontAndBack4AppType4Gv.ascx.cs" Inherits = "AGC.Webform.wucvFrontAndBack4AppType4Gv" %>
<link rel = "stylesheet" type = "text/css" href = "../../css/tz_base1.css"/>
<%-- 列表层 --%>

<div id = "divList" class = "div_List" 
runat = "server">
<asp:GridView id = "gvFrontAndBack4AppType" style = "z-index: 102;" runat = "server" 
Width = "100%" AutoGenerateColumns = "False" 
PageSize = "10" AllowPaging = "true" 
AllowSorting = "true" 
OnSorting = "gvFrontAndBack4AppType_Sorting" 
OnPageIndexChanging = "gvFrontAndBack4AppType_PageIndexChanging" 
OnRowCreated = "gvFrontAndBack4AppType_RowCreated"
OnRowCommand = "gvFrontAndBack4AppType_RowCommand"
OnRowDeleting = "gvFrontAndBack4AppType_RowDeleting" 
OnRowUpdating = "gvFrontAndBack4AppType_RowUpdating" 
BackColor = "White" 
BorderColor = "#E7E7FF" 
BorderStyle = "None" 
BorderWidth = "1px"
cellpadding = "3" 
GridLines = "Horizontal" 
Height = "1px" 
DataKeyNames = "mId" 
CssClass = "GridValue">
<Columns>
<asp:TemplateField HeaderText = "全选">
<HeaderStyle Width = "30px" />
<HeaderTemplate>
<asp:LinkButton id = "lbSelAll" CommandName = "lbSelAll" runat = "server" CssClass = "DgSelAll" Text = "全选"></asp:LinkButton>
</HeaderTemplate>
<ItemTemplate>
<a name = "A_FrontAndBack4AppType<%# Eval("mId").ToString().Trim() %>"></a>
<asp:CheckBox id = "chkCheckRec" runat = "server"></asp:CheckBox>
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField DataField = "mId" SortExpression = "mId" HeaderText = "mId"></asp:BoundField>
<asp:BoundField DataField = "AppTypeId4Front" SortExpression = "AppTypeId4Front" HeaderText = "应用类型Id4Front"></asp:BoundField>
<asp:BoundField DataField = "ApplTypeName4Front" SortExpression = "ApplTypeName4Front" HeaderText = "ApplTypeName4Front"></asp:BoundField>
<asp:BoundField DataField = "IsVisible" SortExpression = "IsVisible" HeaderText = "是否显示"></asp:BoundField>
<asp:BoundField DataField = "OrderNum" SortExpression = "OrderNum" HeaderText = "序号"></asp:BoundField>
<asp:BoundField DataField = "AppTypeId4Back" SortExpression = "AppTypeId4Back" HeaderText = "应用类型Id4Back"></asp:BoundField>
<asp:BoundField DataField = "ApplTypeName4Back" SortExpression = "ApplTypeName4Back" HeaderText = "ApplTypeName4Back"></asp:BoundField>
<asp:BoundField DataField = "UpdDate" SortExpression = "UpdDate" HeaderText = "修改日期"></asp:BoundField>
<asp:BoundField DataField = "UpdUser" SortExpression = "UpdUser" HeaderText = "修改者"></asp:BoundField>
<asp:BoundField DataField = "Memo" SortExpression = "Memo" HeaderText = "说明"></asp:BoundField>
<asp:TemplateField HeaderText = "修改">
<ItemTemplate>
<asp:LinkButton id = "lbUpdate" runat = "Server" CommandName = "Update" Text = "修改" CssClass = "LinkButton_DefaInGv"></asp:LinkButton>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText = "删除">
<ItemTemplate>
<asp:LinkButton id = "lbDelete" runat = "Server" CommandName = "Delete" Text = "删除" CssClass = "LinkButton_DefaInGv"></asp:LinkButton>
</ItemTemplate>
</asp:TemplateField>
</Columns>
<PagerTemplate>
<span style = "background-color: #c0c0c0">共有记录:</span>
<asp:Label ID = "lblRecCount" runat = "server" CssClass = "Label_DefaInPager" ForeColor = "#000066" Width = "36px">0</asp:Label>
<span style = "background-color: #c0c0c0">
<div style = "display: inline; width: 16px; height: 13px">
</div>
</span><span style = "background-color: #c0c0c0">总页数:</span>
<asp:Label ID = "lblAllPages" runat = "server" CssClass = "Label_DefaInPager" ForeColor = "#000066">0</asp:Label>
<div style = "display: inline; width: 16px; height: 13px">
</div>
<span style = "background-color: #c0c0c0">当前页:</span>
<asp:Label ID = "lblCurrentPage" runat = "server" CssClass = "Label_DefaInPager" ForeColor = "#000066">0</asp:Label>
<div style = "display: inline; width: 16px; height: 13px">
</div>
<asp:Button ID = "btnPrevPage" runat = "server" CssClass = "Button_DefaInPager" Text = "上一页"
Width = "50px" CommandArgument = "Prev" CommandName = "PrevPage" /><span style = "font-family: Verdana">
</span>
<asp:Button ID = "btnNextPage" runat = "server" CssClass = "Button_DefaInPager" Text = "下一页"
Width = "50px" CommandArgument = "Next" CommandName = "NextPage" />
到第
<asp:TextBox ID = "txtJump2Page" runat = "server" CssClass = "TextBox_DefaInPager" Width = "35px"></asp:TextBox>页
<asp:Button ID = "btnJumpPage" runat = "server" CssClass = "Button_DefaInPager" OnClick = "btnJumpPage_Click"
Text = "确定" Width = "35px" CommandName = "Page" />
<span style = "background-color: #c0c0c0">页记录数:</span>
<asp:DropDownList ID = "ddlPagerRecCount" runat = "server" CssClass = "DropDown_DefaInPager"
Width = "55px" AutoPostBack = "True" OnSelectedIndexChanged = "ddlPagerRecCount_SelectedIndexChanged">
<asp:ListItem>5</asp:ListItem>
<asp:ListItem>10</asp:ListItem>
<asp:ListItem>15</asp:ListItem>
<asp:ListItem>20</asp:ListItem>
<asp:ListItem>30</asp:ListItem>
<asp:ListItem>50</asp:ListItem>
<asp:ListItem>100</asp:ListItem>
<asp:ListItem>1000</asp:ListItem>
</asp:DropDownList>
<asp:CompareValidator ID = "CompareValidator" runat = "server" ControlToValidate = "txtJump2Page"
ErrorMessage = "错误!" ForeColor = "DarkOrange" Operator = "DataTypeCheck" Type = "Integer"></asp:CompareValidator>
</PagerTemplate>
<FooterStyle CssClass = "FooterStyle" />
<RowStyle CssClass = "RowStyle" />
<EmptyDataRowStyle CssClass = "EmptyDataRowStyle" />
<SelectedRowStyle CssClass = "SelectedRowStyle" />
<PagerStyle CssClass = "PagerStyle" />
<HeaderStyle CssClass = "HeaderStyle" />
<EditRowStyle CssClass = "EditRowStyle" />
<AlternatingRowStyle CssClass = "AlternatingRowStyle" />
</asp:GridView>
</div>