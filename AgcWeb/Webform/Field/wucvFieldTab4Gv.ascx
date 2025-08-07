<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvFieldTab4Gv.ascx.cs" Inherits="AGC.Webform.wucvFieldTab4Gv" %>

<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvFieldTab"  runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvFieldTab_Sorting"
        OnPageIndexChanging="gvFieldTab_PageIndexChanging"
        OnRowCreated="gvFieldTab_RowCreated"
        OnRowCommand="gvFieldTab_RowCommand"
        OnRowDeleting="gvFieldTab_RowDeleting"
        OnRowUpdating="gvFieldTab_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="FldId"
        CssClass="table table-striped table-bordered table-condensed" OnRowDataBound="gvFieldTab_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="">
                <HeaderStyle Width="10px" />
                <HeaderTemplate>
                    <asp:CheckBox ID="chkSelAll" CommandName="SelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" AutoPostBack="true" OnCheckedChanged="chkSelAll_CheckedChanged" Text=""></asp:CheckBox>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_FieldTab<%# Eval("FldId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="FldId" SortExpression="FldId" HeaderText="字段ID" />
            <asp:TemplateField HeaderText="字段名" SortExpression="FldName">
                <ItemTemplate>
                    <asp:LinkButton ID="lbEditFieldTab" runat="Server" CommandName="EditFieldTab" CommandArgument='<%# Eval("FldId") %>'
                        ToolTip="编辑字段" Text='<%# Bind("FldName") %>'></asp:LinkButton>
                    <asp:HiddenField ID="hidFldName" Value='<%# Bind("FldName") %>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>

<%--            <asp:BoundField DataField="FldName" HeaderText="字段名称" SortExpression="FldName" HeaderStyle-HorizontalAlign="Left">
                <HeaderStyle Width="130px" />
            </asp:BoundField>--%>
            <asp:BoundField DataField="FldBName_B" HeaderText="字段名称_后备" SortExpression="FldBName_B"
                Visible="False">
                <HeaderStyle Width="130px" />
            </asp:BoundField>
            <asp:BoundField DataField="FldName_G" HeaderText="字段名称_国标" SortExpression="FldName_G"
                Visible="False">
                <HeaderStyle Width="130px" />
            </asp:BoundField>
            <asp:BoundField DataField="Caption" HeaderText="标题名称" SortExpression="Caption" HeaderStyle-HorizontalAlign="Left">
                <HeaderStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="FieldTypeName" HeaderText="字段类型" SortExpression="FieldTypeName" HeaderStyle-HorizontalAlign="Left">
                <HeaderStyle  />
            </asp:BoundField>
            <asp:BoundField DataField="DataTypeName" HeaderText="类型" SortExpression="DataTypeName" HeaderStyle-HorizontalAlign="Left">
                <HeaderStyle  />
            </asp:BoundField>
            <asp:BoundField DataField="FldLength" HeaderText="长度" SortExpression="FldLength" HeaderStyle-HorizontalAlign="Left">
                <HeaderStyle />
            </asp:BoundField>
            <asp:BoundField DataField="FldPrecision" HeaderText="小数" SortExpression="FldPrecision" HeaderStyle-HorizontalAlign="Left">
                <HeaderStyle  />
            </asp:BoundField>
            <asp:CheckBoxField DataField="IsNull" HeaderText="可空" SortExpression="IsNull" HeaderStyle-HorizontalAlign="Left" />
            <asp:CheckBoxField DataField="IsPrimaryKey" HeaderText="主键" SortExpression="IsPrimaryKey" HeaderStyle-HorizontalAlign="Left" />
            <asp:BoundField DataField="IsNationStandard" HeaderText="国标" Visible="False" HeaderStyle-HorizontalAlign="Left" />
            <asp:BoundField DataField="MaxValue" HeaderText="最大值" Visible="False" HeaderStyle-HorizontalAlign="Left" />
            <asp:BoundField DataField="MinValue" HeaderText="最小值" Visible="False" HeaderStyle-HorizontalAlign="Left" />
            <asp:BoundField DataField="DefaultValue" HeaderText="缺省值" Visible="False" HeaderStyle-HorizontalAlign="Left" />
            <asp:BoundField DataField="HomologousFldId" HeaderText="同源字段" SortExpression="HomologousFldId" />
            <asp:BoundField DataField="CodeTab" HeaderText="代码表" SortExpression="CodeTab" />
            <asp:BoundField DataField="CodeTabName" SortExpression="CodeTabName" HeaderText="名称字段" />
            <asp:BoundField DataField="CodeTabCode" SortExpression="CodeTabCode" HeaderText="代码字段" />

            <asp:BoundField DataField="TabNum" HeaderText="表数" SortExpression="TabNum" HeaderStyle-HorizontalAlign="Left" />
         

            <asp:BoundField DataField="FldCnName" SortExpression="FldCnName" HeaderText="字段中文详名"></asp:BoundField>
            <asp:BoundField DataField="IsChecked" SortExpression="IsChecked" HeaderText="是否核实"></asp:BoundField>
            <asp:BoundField DataField="IsArchive" SortExpression="IsArchive" HeaderText="是否存档"></asp:BoundField>
            <asp:BoundField DataField="IsOnlyOne" SortExpression="IsOnlyOne" HeaderText="是否唯一"></asp:BoundField>
            <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改用户"></asp:BoundField>
            <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>          
            <asp:BoundField DataField="Memo" HeaderText="备注" SortExpression="Memo" HeaderStyle-HorizontalAlign="Left">
                <ItemStyle CssClass="text-warning" />
            </asp:BoundField>
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
