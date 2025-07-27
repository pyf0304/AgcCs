<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmImportDataBaseFromSQL.aspx.cs"
    Inherits="AGC.Webform.wfmImportDataBaseFromSQL" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Tables的维护</title>    
    
      <%--<script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>--%>
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
        <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 6px"
            cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
            <tr>
                <td style="width: 812px">
                    <div style="position: relative; width: 648px; height: 27px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >Tables表的查询
                        </asp:Label>
                        <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105;
                            left: 54px; position: relative; top: 4px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <div id="divTables" class="row">
                        <div class="btn-group col-3" role="group" aria-label="Basic example">
                            <asp:Label ID="lblTabNameq" 
                                runat="server" Width="70px" CssClass="text-secondary">表名</asp:Label>
                            <asp:TextBox ID="txtTabNameq" 
                                runat="server" Width="145px" CssClass="Textbox_Defa"></asp:TextBox>
                        </div>
                        <div class="btn-group col-3" role="group" aria-label="Basic example">
                            <asp:Label ID="lblDataBaseNameq" runat="server" CssClass="auto-style1">SQL表类型</asp:Label>
                            <asp:TextBox ID="txtXtypeq" 
                                runat="server" Width="70px" CssClass="Textbox_Defa"></asp:TextBox>
                        </div>
                        <div class="btn-group col-3" role="group" aria-label="Basic example">
                            <asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="btn btn-outline-warning btn-sm" OnClick="btnQuery_Click"></asp:Button>
                        </div>
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                </td>
            </tr>
            <tr>
                <td style="width: 812px" colspan="3">
                    <table id="tabTablesGridView" style="width: 552px" runat="server">
                        <tr>
                            <td>
                                <div style="width: 750px; position: relative; height: 32px" id="divGridFunction">
                                    <asp:Label ID="lblTablesList" runat="server" Style="z-index: 105; left: 0px;
                                        position: relative; top: 0px" CssClass="h6">SQL表列表</asp:Label>&nbsp;
                                    <asp:Button ID="btnGO2" runat="server" Font-Names="新宋体" OnClick="btnGO2_Click"  CssClass="btn btn-outline-info btn-sm"  Style="left: 134px;
                                        position: relative; top: 0px" Text="导入所选SQL表" Width="172px" />
                                    <asp:Button ID="btnImportAllTables" runat="server" Font-Names="新宋体" OnClick="btnImportAllTables_Click"  CssClass="btn btn-outline-info btn-sm"
                                        Style="left: 151px; position: relative; top: 0px" Text="导入全部SQL表" Width="172px" /></div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvTables" Style="z-index: 111; position: relative;" runat="server"
                                    Width="800px" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                    OnSorting="gvTables_Sorting" OnPageIndexChanging="gvTables_PageIndexChanging"
                                    OnRowCommand="gvTables_RowCommand" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                                    BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px" DataKeyNames="Name"
                                    CssClass="table table-striped table-bordered table-condensed" onrowcreated="gvTables_RowCreated">
                                    <Columns>
                                        <asp:TemplateField HeaderText="全选">
                                            <HeaderStyle Width="35px" />
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Name" SortExpression="Name" HeaderText="表名"></asp:BoundField>
                                        <asp:BoundField DataField="xtype" SortExpression="xtype" HeaderText="SQL表类型"></asp:BoundField>
                                       <asp:BoundField DataField="crDate" SortExpression="crDate" HeaderText="建立时间"></asp:BoundField>
                                    </Columns>
                                    <PagerTemplate>
                                        <span class="text-secondary">共有记录:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                            Width="46px">0</asp:Label>
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
                                            Width="41px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>20</asp:ListItem>
                                            <asp:ListItem>30</asp:ListItem>
                                            <asp:ListItem>50</asp:ListItem>
                                            <asp:ListItem>100</asp:ListItem>
                                            <asp:ListItem>1000</asp:ListItem>
                                            <asp:ListItem></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                    </PagerTemplate>
                                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <AlternatingRowStyle BackColor="#F7F7F7" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
