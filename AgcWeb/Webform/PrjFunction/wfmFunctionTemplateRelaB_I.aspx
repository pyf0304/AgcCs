<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFunctionTemplateRelaB_I.aspx.cs"
    Inherits="AGC.Webform.wfmFunctionTemplateRelaB_I" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>函数与模板关系维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
      <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <table class="msgtable" style="width: 80%">
            <tr>

                <td>
                    <asp:Label ID="lblFuncId4GCq" 
                        runat="server" CssClass="text-secondary">函数ID</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFuncId4GCq" 
                        runat="server" CssClass="TextBox_Defa">
                    </asp:TextBox>
                </td>

                <td>
                    <asp:Label ID="lblFuncNameq" 
                        runat="server" CssClass="text-secondary">函数名</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFuncNameq" 
                        runat="server" CssClass="TextBox_Defa" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblFuncTypeID" runat="server" CssClass="col-form-label text-right">函数类型</asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlFuncTypeIDq" runat="server" class="form-control-sm"></asp:DropDownList>
                </td>

                <td>&nbsp;</td>
            </tr>
            <tr>

                <td>
                    <asp:Label ID="lblProgLangTypeIdq" 
                        runat="server" CssClass="text-secondary">语言类型</asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlProgLangTypeIdq" 
                        runat="server" CssClass="TextBox_Defa">
                    </asp:DropDownList>
                </td>

                <td>
                    <asp:Label ID="lblCodeTypeIdq" 
                        runat="server" CssClass="text-secondary">分层类型</asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCodeTypeIdq" 
                        runat="server" CssClass="TextBox_Defa">
                    </asp:DropDownList>
                </td>
                <td>

                    &nbsp;</td>
                <td>

                    &nbsp;</td>
                <td>

                    <asp:Button ID="btnQuery"
                        Style="z-index: 116; width: 80px;"
                        runat="server"
                        Text="查询" CssClass="btn btn-outline-warning btn-sm"
                        OnClick="btnQuery_Click"></asp:Button>
                </td>
            </tr>

        </table>

        <table class="msgtable">
            <tr>
                <td style="width: 80%"></td>
                <%--  <td>
                <asp:Label ID="lblSchoolYearq" Style="z-index: 121;"
                    runat="server" CssClass="text-secondary" Width="51px">学年</asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlSchoolYearq" Style="z-index: 122;" AutoPostBack="true"
                    runat="server" CssClass="TextBox_Defa" OnSelectedIndexChanged="ddlSchoolYear_q_SelectedIndexChanged">
                </asp:DropDownList>
            </td>

            <td>
                <asp:Label ID="lblSchoolTermq" Style="z-index: 124;"
                    runat="server" CssClass="text-secondary" Width="44px">学期</asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlSchoolTermq" Style="z-index: 125;"  AutoPostBack="true"
                    runat="server" CssClass="TextBox_Defa" OnSelectedIndexChanged="ddlSchoolTerm_q_SelectedIndexChanged">
                </asp:DropDownList>
            </td>--%>

                <td>
                    <asp:Label ID="Label6" runat="server" Width="90px">选择模板：</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlFunctionTemplateIdq" runat="server" Width="150px" OnSelectedIndexChanged="ddlFunctionTemplateId_q_SelectedIndexChanged">
                    </asp:DropDownList></td>
                 <td>
                    <asp:Label ID="Label2" 
                        runat="server" CssClass="text-secondary">目标类型</asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCodeTypeId" 
                        runat="server" CssClass="TextBox_Defa">
                    </asp:DropDownList>
                </td>

                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="添加所选函数到模板" CssClass="btn btn-outline-info btn-sm"
                        OnClick="btnAdd_Click" /></td>
                <td>
                    <asp:Button ID="btnCancle" CssClass="btn btn-outline-info btn-sm" runat="server" Text="返回" OnClick="btnCancle_Click" /></td>
            </tr>
        </table>


        <!-- 分页 -->
        <div>
            <asp:GridView ID="gvFunction4GeneCode" runat="server"
                AutoGenerateColumns="False"
                AllowPaging="True"
                AllowSorting="True"
                OnPageIndexChanging="gvFunction4GeneCode_PageIndexChanging"
                OnSorting="gvFunction4GeneCode_Sorting"
                OnPageIndexChanged="gvFunction4GeneCode_PageIndexChanged"
                OnRowCommand="gvFunction4GeneCode_RowCommand"
                EnableModelValidation="True"
                BackColor="White"
                Width="100%"
                BorderColor="#E7E7FF"
                BorderStyle="None"
                BorderWidth="1px"
                CellPadding="3"
                GridLines="None"
                Height="1px"
                DataKeyNames="FuncId4GC"
                CssClass="table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:TemplateField HeaderText="全选">
                        <HeaderStyle Width="50px" />
                        <HeaderTemplate>
                            <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="chkCheckRec" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="编号" SortExpression="FuncId4GC"
                        Visible="False">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("FuncId4GC")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
                    <asp:BoundField DataField="FuncId4GC" SortExpression="FuncId4GC" HeaderText="函数ID"></asp:BoundField>
                    <asp:BoundField DataField="FuncName" SortExpression="FuncName" HeaderText="函数名"></asp:BoundField>
                    <asp:BoundField DataField="ProgLangTypeName" SortExpression="ProgLangTypeName" HeaderText="语言类型"></asp:BoundField>
                    <asp:BoundField DataField="FuncCodeTypeName" SortExpression="FuncCodeTypeName" HeaderText="代码类型"></asp:BoundField>
                    <asp:BoundField DataField="FeatureName" SortExpression="FeatureName" HeaderText="功能"></asp:BoundField>
                    
                    <asp:BoundField DataField="IsTemplate" SortExpression="IsTemplate" HeaderText="模板?"></asp:BoundField>
                    <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
                    <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者"></asp:BoundField>
                    <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>

                    <%-- 
                <asp:BoundField DataField="AdminClassTypeName" SortExpression="AdminClassTypeName" HeaderText="班级类型"></asp:BoundField>--%>
                </Columns>
                <RowStyle HorizontalAlign="Center" />
                <PagerTemplate>
                    <div style="background-color: #ECEFEF">
                        <span>共有记录:</span>
                        <asp:Label ID="lblRecCount" runat="server" ForeColor="#000066">0</asp:Label>
                        <span>
                            <div style="display: inline; width: 16px; height: 13px">
                            </div>
                        </span><span>总页数:</span>
                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager"
                            ForeColor="#000066">0</asp:Label>
                        <div style="display: inline; width: 16px; height: 13px">
                        </div>
                        <span>当前页:</span>
                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager"
                            ForeColor="#000066">0</asp:Label>
                        <div style="display: inline; width: 16px; height: 13px">
                        </div>
                        <asp:Button ID="btnPrevPage" runat="server" CommandArgument="Prev"
                            CommandName="page" CssClass="btn btn-outline-warning btn-sm small" Text="上一页" />
                        <asp:Button ID="btnNextPage" runat="server" CommandArgument="Next"
                            CommandName="Page" CssClass="btn btn-outline-warning btn-sm small" Text="下一页" />
                        <span>到第</span>
                        <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager"
                            Height="15px" Width="35px"></asp:TextBox>
                        <span>页</span>
                        <asp:Button ID="btnJumpPage" runat="server" CommandName="Page"
                            CssClass="btn btn-outline-warning btn-sm small" OnClick="btnJumpPage_Click" Text="确定" />
                        <span>页记录数:</span>
                        <asp:DropDownList ID="ddlPagerRecCount" runat="server" AutoPostBack="True"
                            OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged" Width="41px">
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>50</asp:ListItem>
                            <asp:ListItem>100</asp:ListItem>
                            <asp:ListItem>1000</asp:ListItem>
                        </asp:DropDownList>
                        <asp:CompareValidator ID="CompareValidator" runat="server"
                            ControlToValidate="txtJump2Page" ErrorMessage="错误！" ForeColor="DarkOrange"
                            Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                    </div>
                </PagerTemplate>
                <EmptyDataTemplate>
                    <thead style="background-color: #ECEFEF">
                     
                        <th>函数ID                     
                        </th>
                        <th>函数名
                        </th>
                        <th>语言类型
                        </th>
                        <th>分层类型
                        </th>
                        <th>模板?
                        </th>
                        <th>修改日期
                        </th>
                        <th>修改者
                        </th>
                        <th>说明
                        </th>
                    </thead>
                    <thead>
                        <td align="center" colspan="6">
                            <font color="red">暂无数据!</font>
                        </td>
                    </thead>
                </EmptyDataTemplate>
                <FooterStyle CssClass="FooterStyle" />
                <RowStyle CssClass="RowStyle" />
                <EmptyDataRowStyle CssClass="EmptyDataRowStyle" />
                <PagerStyle CssClass="PagerStyle" />
                <SelectedRowStyle CssClass="SelectedRowStyle" />
                <HeaderStyle CssClass="HeaderStyle" />
                <EditRowStyle CssClass="EditRowStyle" />
                <AlternatingRowStyle CssClass="AlternatingRowStyle" />
            </asp:GridView>
        </div>


    </form>
</body>
</html>
