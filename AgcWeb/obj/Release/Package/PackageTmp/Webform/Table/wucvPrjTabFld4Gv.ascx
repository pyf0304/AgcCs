<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvPrjTabFld4Gv.ascx.cs" Inherits="AGC.Webform.wucvPrjTabFld4Gv" %>

<%-- 列表层 --%>

<div id="divList" class="div_List"    runat="server">
    <asp:Label ID="lblMsgList" runat="server" Text=""></asp:Label>
    <br />
    <asp:GridView ID="gvPrjTabFld"  runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvPrjTabFld_Sorting"
        OnPageIndexChanging="gvPrjTabFld_PageIndexChanging"
        OnRowCreated="gvPrjTabFld_RowCreated"
        OnRowCommand="gvPrjTabFld_RowCommand"
        OnRowDeleting="gvPrjTabFld_RowDeleting"
        OnRowUpdating="gvPrjTabFld_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="mId"
        CssClass="table table-striped table-bordered table-condensed" OnRowDataBound="gvPrjTabFld_RowDataBound">
        <Columns>
             <asp:TemplateField HeaderText="">
                <HeaderStyle Width="10px" />
                <HeaderTemplate>
                    <asp:CheckBox ID="chkSelAll" CommandName="SelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" AutoPostBack="true" OnCheckedChanged="chkSelAll_CheckedChanged" Text=""></asp:CheckBox>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_PrjTabFld<%# Eval("mId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="SequenceNumber" SortExpression="SequenceNumber" HeaderText="序号"></asp:BoundField>
                <asp:TemplateField HeaderText="字段Id" SortExpression="FldId">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lbEditField" runat="Server" CommandName="EditField" CommandArgument='<%# Eval("FldId") %>'
                                                            ToolTip="编辑字段Id" Text='<%# Bind("FldId") %>'></asp:LinkButton>
                                                        <asp:HiddenField ID="hidFldId" Value='<%# Bind("FldId") %>' runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                <asp:TemplateField HeaderText="字段名" SortExpression="FldName">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lbEditTabField" runat="Server" CommandName="EditTabField" CommandArgument='<%# Eval("mId") %>'
                                                            ToolTip="编辑表字段" Text='<%# Bind("FldName") %>'></asp:LinkButton>
                                                        <asp:HiddenField ID="hidFldName" Value='<%# Bind("FldName") %>' runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

     <%--       <asp:BoundField DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundField>--%>
            <asp:BoundField DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundField>
            <asp:BoundField DataField="FieldTypeName" SortExpression="FieldTypeName" HeaderText="字段类型"></asp:BoundField>
            <asp:BoundField DataField="PrimaryTypeName" SortExpression="PrimaryTypeName" HeaderText="主键类型" Visible="false"></asp:BoundField>
            <asp:BoundField DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="类型"></asp:BoundField>
            <asp:BoundField DataField="FldLength" SortExpression="FldLength" HeaderText="长度"></asp:BoundField>
            <asp:BoundField DataField="FldPrecision" SortExpression="FldPrecision" HeaderText="小数"></asp:BoundField>
            <asp:BoundField DataField="IsTabNullable" SortExpression="IsTabNullable" HeaderText="可空"></asp:BoundField>
            <asp:BoundField DataField="IsTabUnique" SortExpression="IsTabUnique" HeaderText="唯一"></asp:BoundField>
            <asp:BoundField DataField="FldOpTypeName" SortExpression="FldOpTypeName" HeaderText="操作类型"></asp:BoundField>
            <asp:BoundField DataField="IsTabForeignKey" SortExpression="IsTabForeignKey" HeaderText="外键"></asp:BoundField>
            <asp:BoundField DataField="IsSortFld" SortExpression="IsSortFld" HeaderText="排序"></asp:BoundField>
            <asp:BoundField DataField="IsParentObj" SortExpression="IsParentObj" HeaderText="父对象"></asp:BoundField>
            <asp:BoundField DataField="HomologousFldId" SortExpression="HomologousFldId" HeaderText="同源字段"></asp:BoundField>
            <asp:BoundField DataField="CodeTab" SortExpression="CodeTab" HeaderText="代码表"></asp:BoundField>
            <asp:TemplateField HeaderText="外键表" SortExpression="ForeignTabName">
                <ItemTemplate>
                    <asp:LinkButton ID="lbEditForeignTab" runat="Server" CommandName="EditForeignTab" Text='<%# Bind("ForeignTabName") %>' ToolTip="编辑相关外键表。"></asp:LinkButton><asp:HiddenField ID="hidForeignTabId" runat="server" Value='<%# Bind("ForeignKeyTabId") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="DefaultValue" SortExpression="DefaultValue" HeaderText="缺省值" Visible="false"></asp:BoundField>

            <asp:TemplateField HeaderText="源表">
                <ItemTemplate>
                    <asp:LinkButton ID="lbEditCodeTab" runat="Server" CommandName="EditCodeTab" CommandArgument='<%# Eval("SourceTabName") %>'
                        ToolTip="编辑相关代码表。" Text='<%# Bind("SourceTabName") %>'></asp:LinkButton><asp:HiddenField ID="hidCodeTab" Value='<%# Bind("SourceTabName") %>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <%--<asp:TemplateField HeaderText="修改">
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
