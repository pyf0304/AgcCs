<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvViewInfo4Gv.ascx.cs" Inherits="AGC.Webform.wucvViewInfo4Gv" %>

<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvViewInfo"  runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvViewInfo_Sorting"
        OnPageIndexChanging="gvViewInfo_PageIndexChanging"
        OnRowCreated="gvViewInfo_RowCreated"
        OnRowCommand="gvViewInfo_RowCommand"
        OnRowDeleting="gvViewInfo_RowDeleting"
        OnRowUpdating="gvViewInfo_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="ViewId"
        CssClass="table table-striped table-bordered table-condensed" OnRowDataBound="gvViewInfo_RowDataBound">
        <Columns>
             <asp:TemplateField HeaderText="">
                <HeaderStyle Width="10px" />
                <HeaderTemplate>
                    <asp:CheckBox ID="chkSelAll" CommandName="SelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" AutoPostBack="true" OnCheckedChanged="chkSelAll_CheckedChanged" Text=""></asp:CheckBox>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_ViewInfo<%# Eval("ViewId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ViewId" HeaderText="界面ID" SortExpression="ViewId" Visible="False" />
            <asp:TemplateField HeaderText="应用类型" SortExpression="ApplicationTypeSimName">
                <ItemTemplate>
                    <%# Substring(Eval("ApplicationTypeSimName").ToString(),0,11)%>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="ViewGroupName" HeaderText="界面组" SortExpression="ViewGroupName" Visible="False" />
                <asp:TemplateField HeaderText="界面名" SortExpression="ViewName">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lbEditViewRegionFlds" runat="Server" CommandName="EditViewRegionFlds" CommandArgument='<%# Eval("ViewId") %>'
                                                            ToolTip="编辑界面区域字段信息-编辑界面区域、区域字段等相关操作" Text='<%# Bind("ViewName") %>'></asp:LinkButton>
                                                        <asp:HiddenField ID="hidViewName" Value='<%# Bind("ViewName") %>' runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>


            <%--<asp:BoundField DataField="ViewName" HeaderText="界面名" SortExpression="ViewName" />--%>
            <asp:BoundField DataField="ViewCnName" HeaderText="视图中文名" SortExpression="ViewCnName" />
            
            <asp:BoundField DataField="FuncModuleName" HeaderText="功能模块" SortExpression="FuncModuleName" />
            <asp:BoundField DataField="MainTabName" HeaderText="界面主表" SortExpression="MainTabName" />
            <asp:BoundField DataField="DetailTabName" HeaderText="界面详细表" SortExpression="DetailTabName"
                Visible="False" />
            <asp:BoundField DataField="TitleStyleName" HeaderText="标题类型名" SortExpression="TitleStyleName"
                Visible="False" />
            <asp:BoundField DataField="DgStyleName" HeaderText="DG模式名" SortExpression="DgStyleName"
                Visible="False" />
         
            <asp:BoundField DataField="DataBaseName" HeaderText="数据库名" SortExpression="DataBaseName"
                Visible="False" />
            <asp:BoundField DataField="ViewDetail" HeaderText="界面说明" SortExpression="ViewDetail"
                Visible="False" />
            <asp:BoundField DataField="PrjName" HeaderText="工程名称" SortExpression="PrjName" Visible="False" />
            <asp:BoundField DataField="FileName" HeaderText="文件名" SortExpression="FileName" Visible="False" />
            <asp:BoundField DataField="FilePath" HeaderText="文件路径" SortExpression="FilePath" />
            <asp:BoundField DataField="DefaMenuName" HeaderText="缺省菜单名" SortExpression="DefaMenuName"
                Visible="False" />
            <asp:BoundField DataField="DetailTabKeyFld" HeaderText="DetailTabKeyFld" SortExpression="DetailTabKeyFld"
                Visible="False" />

            <asp:BoundField DataField="TitleStyleName" HeaderText="标题类型" SortExpression="TitleStyleName" Visible="False" />
            <asp:BoundField DataField="DgStyleName" HeaderText="DG模式" SortExpression="DgStyleName"  Visible="False" />

        <%--    <asp:TemplateField HeaderText="区域数" SortExpression="RegionNum">

                <ItemTemplate>
                    <asp:Label ID="lblRegionNum" runat="server" Text='<%# Bind("RegionNum") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
            <asp:BoundField DataField="UpdDate" HeaderText="修改日期" SortExpression="UpdDate" />
            <asp:BoundField DataField="ViewId" HeaderText="界面Id" SortExpression="ViewId" />
<asp:BoundField DataField="KeyId4Test" HeaderText="测试关键字" SortExpression="KeyId4Test" />
<asp:BoundField DataField="ViewMasterName" HeaderText="界面母版" SortExpression="ViewMasterName" />

<%--            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lbAddViewRegion" runat="Server" CommandName="AddViewRegion" ToolTip="为当前界面添加相关区域。" Text="添加区域"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>--%>
           <%-- <asp:TemplateField HeaderText="修改">
                <ItemTemplate>
                    <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="删除">
                <ItemTemplate>
                    <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>--%>
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
