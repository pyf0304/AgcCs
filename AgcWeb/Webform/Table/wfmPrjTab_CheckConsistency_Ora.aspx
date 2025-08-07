<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="~/Webform/Table/wfmPrjTab_CheckConsistency_Ora.aspx.cs"
    Inherits="AGC.Webform.wfmPrjTab_CheckConsistency_Ora" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>检查系统表与SQL表的一致性</title>
    
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
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px"
            cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
            <tr>
                <td colspan="2">
                    <div style="position: relative; width: 844px; height: 25px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >表字段管理-->检查一致性
                        </asp:Label>
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Style="z-index: 102; left: 191px;
                            position: absolute; top: 3px" Text="表名:"></asp:Label>
                        <asp:Label ID="lblTabName" runat="server" Font-Bold="False" Style="z-index: 102;
                            left: 230px; position: absolute; top: 3px" Text="表名"></asp:Label>
                        <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 101;
                            left: 165px; position: relative; top: 5px" Width="347px"></asp:Label>
                        <asp:LinkButton ID="lbReturn" runat="server" OnClick="lbReturn_Click"
                            Style="z-index: 106; left: 767px; position: absolute; top: 10px" Width="32px">返回</asp:LinkButton>
                    </div>
                </td>
            </tr>
            <tr>
                <td style="width: 772px" valign="top">
                    <table id="tabPrjTabFldGridView" style="width: 450px" runat="server">
                        <tr>
                            <td style="width: 548px">
                                <div style="width: 440px; position: relative; left: 0px; top: 0px;" id="divGridFunction">
                                    
                                    <table style="width: 434px">
                                        <tr>
                                            <td colspan="2">
                                    <asp:Label ID="lblPrjTabFldList" runat="server" CssClass="h6">代码系统中表字段列表</asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>
                                    <asp:Button ID="btnSetFldProperty" runat="server" OnClick="btnSetFldProperty_Click" Text="设置字段属性"  Width="83px" /></td>
                                            <td style="width: 340px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                    <asp:Button ID="btnAddNewField" runat="server" Width="83px" CssClass="btn btn-outline-info btn-sm"
                                        Text="添加新字段" OnClick="btnAddNewField_Click"></asp:Button></td>
                                            <td style="width: 340px">
                                    <asp:Label ID="Label3" runat="server" CssClass="MemoStyle1" Width="328px">把所选SQL数据字段添加到生成代码系统中。</asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btnSynchFldInfoToAgc" runat="server" CssClass="btn btn-outline-info btn-sm" Text="同步字段信息"
                                        Width="83px" OnClick="btnSynchFldInfoToAgc_Click" /></td>
                                            <td style="width: 340px">
                                                <asp:Label ID="Label7" runat="server" CssClass="MemoStyle1" Width="329px">同步字段：把所选SQL数据表字段同步到系统表字段中。</asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btnDelRec" runat="server" OnClick="btnDelRec_Click" Text="删除表字段"
                                                    Width="83px" /></td>
                                            <td style="width: 340px">
                                                <asp:Label ID="Label8" runat="server" CssClass="MemoStyle1" Width="327px">删除：把所选代码系统中字段删除。</asp:Label></td>
                                        </tr>
                                    </table>
                                    </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 548px">
                                <asp:GridView ID="gvPrjTabFld_Agc" Style="z-index: 113; position: relative;" runat="server"
                                    Width="499px" AutoGenerateColumns="False" AllowSorting="True"
                                    OnSorting="gvPrjTabFld_Sorting" OnPageIndexChanging="gvPrjTabFld_PageIndexChanging"
                                    OnRowCreated="gvPrjTabFld_RowCreated" OnRowCommand="gvPrjTabFld_RowCommand" 
                                    BackColor="White" BorderColor="#E7E7FF"
                                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px"
                                    DataKeyNames="mId" CssClass="table table-striped table-bordered table-condensed">
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
                                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                    </PagerTemplate>
                                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <AlternatingRowStyle BackColor="#F7F7F7" /><FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="全选">
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <HeaderStyle Width="35px" />
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId" Visible="False">
                                        </asp:BoundField>
                                        <asp:BoundField DataField="SequenceNumber" SortExpression="SequenceNumber" HeaderText="顺序号" Visible="False">
                                        </asp:BoundField>
                                        <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="表名" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="TabId" SortExpression="TabId" HeaderText="表ID" Visible="False">
                                        </asp:BoundField>
                                        <asp:BoundField DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundField>
                                        <asp:BoundField DataField="OraDbType" SortExpression="OraDbType" HeaderText="类型"></asp:BoundField>
                                        <asp:BoundField DataField="FldLength" SortExpression="FldLength" HeaderText="长度"></asp:BoundField>
                                        <asp:BoundField DataField="IsTabNullable" SortExpression="IsTabNullable" HeaderText="可空"></asp:BoundField>
                                        <asp:BoundField DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundField>
                                        <asp:BoundField DataField="FldId" SortExpression="FldId" HeaderText="字段ID" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="DefaultValue" SortExpression="DefaultValue" HeaderText="缺省值" Visible="False"></asp:BoundField>
                                        <asp:BoundField HeaderText="结果" />
                                    </Columns>
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="width: 762px" valign="top">
                    <table id="tabSQL" style="width: 450px" runat="server">
                        <tr>
                            <td style="width: 423px" valign="top">
                                <div style="width: 451px; position: relative; left: 0px; top: 0px;" id="divSQL" runat="server">
                                <table style="width: 432px">
                                        <tr>
                                            <td colspan="3">
                                    <asp:Label ID="Label2" runat="server" CssClass="h6">SQL数据库表字段列表</asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 70px">
                                    <asp:Button ID="btnReCheckConSistency" runat="server" CssClass="btn btn-outline-info btn-sm" Text="重新检查一致性" Width="114px" OnClick="btnReCheckConSistency_Click" /></td>
                                            <td style="width: 5px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 70px">
                                                <asp:Button ID="btnAddFieldToSqlTable" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnAddFieldToSqlTable_Click" Text="添加新字段"
                                        Width="83px" /></td>
                                            <td style="width: 5px">
                                                <asp:Label ID="Label4" runat="server" CssClass="MemoStyle1" Width="293px">把系统中字段添加到SQL数据表中。</asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 70px">
                                                <asp:Button ID="btnSynchFldInfo" runat="server" CssClass="btn btn-outline-info btn-sm" Text="同步字段信息"
                                        Width="83px" OnClick="btnSynchFldInfo_Click" /></td>
                                            <td style="width: 5px">
                                                <asp:Label ID="Label6" runat="server" CssClass="MemoStyle1" Width="293px">把系统中字段属性同步到SQL数据表中。</asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 70px">
                                                <asp:Button ID="btnDelField_Sql" runat="server" OnClick="btnDelField_Sql_Click" Text="删除表字段"
                                                    Width="83px" /></td>
                                            <td style="width: 5px">
                                                <asp:Label ID="Label9" runat="server" CssClass="MemoStyle1" Width="327px">删除：把所选Sql字段删除。</asp:Label></td>
                                        </tr>
                                    </table>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 423px;" valign="top">
                                <asp:GridView ID="gvPrjTabFld_Sql" Style="z-index: 113; position: relative;" runat="server"
                                    Width="427px" AutoGenerateColumns="False" AllowSorting="True"
                                    OnSorting="gvPrjTabFld_Sql_Sorting" OnPageIndexChanging="gvPrjTabFld_Sql_PageIndexChanging"
                                    OnRowCreated="gvPrjTabFld_Sql_RowCreated" OnRowCommand="gvPrjTabFld_Sql_RowCommand" 
                                    BackColor="White" BorderColor="#E7E7FF"
                                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px"
                                    DataKeyNames="Column_Name" CssClass="table table-striped table-bordered table-condensed">
                                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="全选">
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <HeaderStyle Width="35px" />
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Column_Name" HeaderText="字段名" SortExpression="Column_Name" />
                                        <asp:BoundField DataField="Data_Type" HeaderText="类型" SortExpression="Data_Type" />
                                        <asp:BoundField DataField="Data_Length" HeaderText="长度" SortExpression="Data_Length" />
                                        <asp:BoundField DataField="Nullable" HeaderText="可空" SortExpression="Nullable" />
                                        <asp:BoundField HeaderText="检查结果" />
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
                                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                    </PagerTemplate>
                                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <AlternatingRowStyle BackColor="#F7F7F7" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 423px" valign="top">
                                                <div style="width: 445px; position: relative; height: 32px; left: 0px; top: 3px;" id="divNewTab" runat="server">
                        <asp:Label ID="lblMsg2" runat="server" CssClass="text-warning" Height="35px" Style="z-index: 105;
                            left: 0px; position: relative; top: 0px">SQL数据库中不存在相应表：</asp:Label>
                        &nbsp;
                        <asp:Button ID="btnGenNewTabInSQL" runat="server" CssClass="btn btn-outline-info btn-sm" Style="z-index: 105;
                                        left: 197px; position: absolute; top: 4px" Text="生成新表" Width="71px" OnClick="btnGenNewTabInSQL_Click" />
                        &nbsp;
                        <asp:Label ID="Label5" runat="server" CssClass="MemoStyle1" Height="25px" Style="z-index: 105;
                            left: 82px; position: relative; top: 1px">在SQL数据库添加相关表。</asp:Label></div>

                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="width: 772px">
                </td>
                <td style="width: 762px" valign="top">
                </td>
            </tr>
            <tr>
                <td style="width: 772px">
                </td>
                <td style="width: 762px">
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
