<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvFunction4GeneCode4Gv.ascx.cs" Inherits="AGC.Webform.wucvFunction4GeneCode4Gv" %>

<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvFunction4GeneCode"  runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvFunction4GeneCode_Sorting"
        OnPageIndexChanging="gvFunction4GeneCode_PageIndexChanging"
        OnRowCreated="gvFunction4GeneCode_RowCreated"
        OnRowCommand="gvFunction4GeneCode_RowCommand"
        OnRowDeleting="gvFunction4GeneCode_RowDeleting"
        OnRowUpdating="gvFunction4GeneCode_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="FuncId4GC"
        CssClass="table table-striped table-bordered table-condensed" OnRowDataBound="gvFunction4GeneCode_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="全选">
                <HeaderStyle Width="35px" />
                <HeaderTemplate>
                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" Text="全选"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_Function4GeneCode<%# Eval("FuncId4GC").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
                                    <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
                        <asp:BoundField DataField="FuncId4GC" SortExpression="FuncId4GC" HeaderText="函数ID"></asp:BoundField>
                        <asp:BoundField DataField="FuncName" SortExpression="FuncName" HeaderText="函数名"></asp:BoundField>
                        <asp:BoundField DataField="FuncName4Code" SortExpression="FuncName4Code" HeaderText="函数名(Code)"></asp:BoundField>
                        <%--<asp:BoundField DataField="FeatureCount" SortExpression="FeatureCount" HeaderText="功能数"></asp:BoundField>--%>
                        <asp:BoundField DataField="FeatureName" SortExpression="FeatureName" HeaderText="功能"></asp:BoundField>

                        <asp:BoundField DataField="FunctionSignatureSim" SortExpression="FunctionSignatureSim" HeaderText="函数名(Code)"></asp:BoundField>
                        <asp:BoundField DataField="FuncCHName4Code" SortExpression="FuncCHName4Code" HeaderText="Code函数中文名" Visible="true"></asp:BoundField>
                        <asp:BoundField DataField="FuncGCTypeName" SortExpression="FuncGCTypeName" HeaderText="代码类型"></asp:BoundField>
                        <%--                        <asp:BoundField DataField="ParaNum" SortExpression="ParaNum" HeaderText="参数个数"></asp:BoundField>--%>
                        <asp:BoundField DataField="Order4FeatureNum" SortExpression="Order4FeatureNum" HeaderText="功能序号" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FeatureName" SortExpression="FeatureName" HeaderText="功能名称" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FeatureDescription" SortExpression="FeatureDescription" HeaderText="功能说明" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="ProgLangTypeId" SortExpression="ProgLangTypeId" HeaderText="编程语言类型Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="ProgLangTypeName" SortExpression="ProgLangTypeName" HeaderText="语言类型"></asp:BoundField>
                        <asp:BoundField DataField="FuncCodeTypeName" SortExpression="FuncCodeTypeName" HeaderText="代码类型"></asp:BoundField>
                        <asp:BoundField DataField="SqlDsTypeName" SortExpression="SqlDsTypeName" HeaderText="数据源类型"></asp:BoundField>
                        <asp:BoundField DataField="FuncTypeName" SortExpression="FuncTypeName" HeaderText="函数类型"></asp:BoundField>
                        <asp:BoundField DataField="IsTemplate" SortExpression="IsTemplate" HeaderText="模板1?"></asp:BoundField>
                        <asp:BoundField DataField="IsFuncTemplate" SortExpression="IsFuncTemplate" HeaderText="模板2?"></asp:BoundField>
                        <asp:BoundField DataField="TemplateNum" SortExpression="TemplateNum" HeaderText="模板数"></asp:BoundField>
                        <asp:BoundField DataField="InUse" SortExpression="InUse" HeaderText="在用?"></asp:BoundField>
                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者" Visible="false"></asp:BoundField>
            <asp:BoundField DataField="ParsedWords" SortExpression="ParsedWords" HeaderText="函数分词"></asp:BoundField>
            <asp:BoundField DataField="ParsedWordsExcluded" SortExpression="ParsedWordsExcluded" HeaderText="剔除后分词"></asp:BoundField>

            <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>


            <%--            <asp:BoundField DataField="FuncId4GC" SortExpression="FuncId4GC" HeaderText="函数ID"></asp:BoundField>
            <asp:BoundField DataField="FuncName4Code" SortExpression="FuncName4Code" HeaderText="函数名(Code)"></asp:BoundField>
            <asp:BoundField DataField="FuncName" SortExpression="FuncName" HeaderText="函数名"></asp:BoundField>
            <asp:BoundField DataField="FeatureCount" SortExpression="FeatureCount" HeaderText="功能数"></asp:BoundField>
            <asp:BoundField DataField="ProgLangTypeName" SortExpression="ProgLangTypeName" HeaderText="语言"></asp:BoundField>
            <asp:BoundField DataField="CodeTypeName" SortExpression="CodeTypeName" HeaderText="层类型"></asp:BoundField>
            <asp:BoundField DataField="FeatureName" SortExpression="FeatureName" HeaderText="功能"></asp:BoundField>
            <asp:BoundField DataField="FeatureTypeName" SortExpression="FeatureTypeName" HeaderText="功能类型"></asp:BoundField>
            <asp:BoundField DataField="SqlDsTypeName" SortExpression="SqlDsTypeName" HeaderText="Sql数据源名"></asp:BoundField>
            <asp:BoundField DataField="FuncGCTypeName" SortExpression="FuncGCTypeName" HeaderText="函数生成代码类型名"></asp:BoundField>
            <asp:BoundField DataField="FuncTypeName" SortExpression="FuncTypeName" HeaderText="函数类型名"></asp:BoundField>
            <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
            <asp:BoundField DataField="InUse" SortExpression="InUse" HeaderText="是否在用"></asp:BoundField>
            <asp:BoundField DataField="ReturnTypeName" SortExpression="ReturnTypeName" HeaderText="返回类型名"></asp:BoundField>
            <asp:BoundField DataField="Order4FeatureNum" SortExpression="Order4FeatureNum" HeaderText="Order4FeatureNum"></asp:BoundField>
            <asp:BoundField DataField="IsTemplate" SortExpression="IsTemplate" HeaderText="是否模板"></asp:BoundField>
            <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
            <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者"></asp:BoundField>--%>
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
