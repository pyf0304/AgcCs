<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFunction4Code4GV.ascx.cs" Inherits="AGC.Webform.wucFunction4Code4GV" %>


<div id="divList" class="div_List" runat="server" style="width: 100%">

    <asp:GridView ID="gvFunction4Code" Style="z-index: 120;" runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvFunction4Code_Sorting"
        OnPageIndexChanging="gvFunction4Code_PageIndexChanging"
        OnRowCreated="gvFunction4Code_RowCreated"
        OnRowCommand="gvFunction4Code_RowCommand"
        OnRowDeleting="gvFunction4Code_RowDeleting"
        OnRowUpdating="gvFunction4Code_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="FuncId4Code"
        CssClass="table table-bordered table-hover table-striped" OnRowDataBound="gvFunction4Code_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="全选">
                <HeaderStyle Width="35px" />
                <HeaderTemplate>
                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" Text="全选"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_Function4Code<%# Eval("FuncId4Code").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="FuncTypeName" SortExpression="FuncTypeName" HeaderText="函数类型"></asp:BoundField>
            <asp:BoundField DataField="ClassName" SortExpression="ClassName" HeaderText="类名"></asp:BoundField>
            <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
            <asp:BoundField DataField="FuncId4Code" SortExpression="FuncId4Code" HeaderText="函数Id"></asp:BoundField>
            <asp:BoundField DataField="FuncName4Code" SortExpression="FuncName4Code" HeaderText="函数名"></asp:BoundField>
            <asp:BoundField DataField="FuncCHName4Code" SortExpression="FuncCHName4Code" HeaderText="中文名"></asp:BoundField>            
            <asp:BoundField DataField="FuncPurposeName" SortExpression="FuncPurposeName" HeaderText="用途"></asp:BoundField>
            <asp:BoundField DataField="FuncAccessModeName" SortExpression="FuncAccessModeName" HeaderText="操作模式"></asp:BoundField>
            <asp:BoundField DataField="ReturnTypeName" SortExpression="ReturnTypeName" HeaderText="返回类型"></asp:BoundField>
            <asp:BoundField DataField="Func4GCCount" SortExpression="Func4GCCount" HeaderText="	函数4GC数"></asp:BoundField>
            <asp:BoundField DataField="FeatureCount" SortExpression="FeatureCount" HeaderText="功能数"></asp:BoundField>
            <asp:BoundField DataField="ApplicationTypeName" SortExpression="ApplicationTypeName" HeaderText="应用"></asp:BoundField>
            <asp:BoundField DataField="ParaNum" SortExpression="ParaNum" HeaderText="参数个数"></asp:BoundField>
            <%--<asp:BoundField DataField="ParaList" SortExpression="ParaList" HeaderText="参数列表"></asp:BoundField>--%>
            <asp:BoundField DataField="FunctionSignature" SortExpression="FunctionSignature" HeaderText="函数签名"></asp:BoundField>
            <asp:BoundField DataField="FunctionSignatureSim" SortExpression="FunctionSignatureSim" HeaderText="函数签名"></asp:BoundField>
            <asp:BoundField DataField="ClassName" SortExpression="ClassName" HeaderText="类名"></asp:BoundField>
            <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期" Visible="false"></asp:BoundField>
            <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者" Visible="false"></asp:BoundField>
            <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明" Visible="false"></asp:BoundField>
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

