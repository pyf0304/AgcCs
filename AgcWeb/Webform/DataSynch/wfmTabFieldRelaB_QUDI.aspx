<%@ Register TagPrefix="uc1" TagName="wucTabFieldRelaB" Src="wucTabFieldRelaB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmTabFieldRelaB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmTabFieldRelaB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表字段关系维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >表字段关系维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td style="text-align:right">
                            <asp:Label ID="lblTabIdq" 
                                runat="server" CssClass="text-secondary">表名</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblTabName" 
                                runat="server" CssClass="text-secondary">表名</asp:Label>
                        </td>

                        <td  style="text-align:right">
                            <asp:Label ID="lblFldIDq" 
                                runat="server" CssClass="text-secondary">字段ID</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFldIDq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                       <td></td>
                       <td>
                            <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" 
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置导出字段"></asp:Button>
                        </td>
                    </tr>
                    <tr>

                        <td style="text-align:right">
                            <asp:Label ID="lblFldNameq" 
                                runat="server" CssClass="text-secondary">字段名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFldNameq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td style="text-align:right">
                            <asp:Label ID="lblFieldTypeIdq" 
                                runat="server" CssClass="text-secondary">字段类型Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFieldTypeIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                    

                      
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 119; Width: 80px; "
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    

                      
                        <td>

                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List"
                runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblTabFieldRelaList" runat="server" 
                                CssClass="h6" Width="250px">表字段关系列表</asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnCopyTabField" runat="server" OnClick="btnCopyTabField_Click" 
                                Width="93px" CssClass="btn btn-outline-info btn-sm" Text="复制表字段"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </td>
                          <td>
                            <asp:Button ID="btnGoFirstLine"  runat="server" 
                                Text="首行" OnClick="btnGoFirstLine_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnUpMove"  runat="server"  Text="上移"
                                OnClick="btnUpMove_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnDownMove"  runat="server"  Text="下移"
                                OnClick="btnDownMove_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnGoLastLine"  runat="server" 
                                Text="尾行" OnClick="btnGoLastLine_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnReOrder"  runat="server"  Text="重序"
                                OnClick="btnReOrder_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>

                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
                <asp:GridView ID="gvTabFieldRela" Style="z-index: 120;" runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvTabFieldRela_Sorting"
                    OnPageIndexChanging="gvTabFieldRela_PageIndexChanging"
                    OnRowCreated="gvTabFieldRela_RowCreated"
                    OnRowCommand="gvTabFieldRela_RowCommand"
                    OnRowDeleting="gvTabFieldRela_RowDeleting"
                    OnRowUpdating="gvTabFieldRela_RowUpdating"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="Horizontal"
                    Height="1px"
                    DataKeyNames="id_FieldTabRela"
                    CssClass="table table-striped table-bordered table-condensed">
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
                       <asp:BoundField DataField="SequenceNumber" SortExpression="SequenceNumber" HeaderText="顺序号"></asp:BoundField>
                         <asp:BoundField DataField="id_FieldTabRela" SortExpression="id_FieldTabRela" HeaderText="字段表关系流水号" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="TabId" SortExpression="TabId" HeaderText="表ID" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FldId" SortExpression="FldId" HeaderText="字段ID" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundField>
                        <asp:BoundField DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundField>
                        <asp:BoundField DataField="SqlFldName" SortExpression="SqlFldName" HeaderText="Sql字段名称"></asp:BoundField>
                        <asp:BoundField DataField="DefaultValue" SortExpression="DefaultValue" HeaderText="缺省值"></asp:BoundField>
                        <asp:BoundField DataField="vFieldCnName" SortExpression="vFieldCnName" HeaderText="视图字段中文名称" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="ExcelFieldName" SortExpression="ExcelFieldName" HeaderText="Excel字段名称" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="PrimaryTypeName" SortExpression="PrimaryTypeName" HeaderText="主键类型名"></asp:BoundField>
                        <asp:BoundField DataField="Trans_TabName" SortExpression="Trans_TabName" HeaderText="转换表名" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="IsIdentity" SortExpression="IsIdentity" HeaderText="是否Identity"></asp:BoundField>
                        <asp:BoundField DataField="IsVisible" SortExpression="IsVisible" HeaderText="是否显示" Visible="false"></asp:BoundField>
                                                <asp:BoundField DataField="ForeignKeyTabId" SortExpression="ForeignKeyTabId" HeaderText="外键表ID" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="IsTabNullable" SortExpression="IsTabNullable" HeaderText="是否表中可空" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="IsTabUnique" SortExpression="IsTabUnique" HeaderText="是否表中唯一" ></asp:BoundField>
                        <asp:BoundField DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="数据类型"></asp:BoundField>
                        <asp:BoundField DataField="IsNeedCheckPriForeignKey" SortExpression="IsNeedCheckPriForeignKey" HeaderText="是否检查主外键" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="IsTabForeignKey" SortExpression="IsTabForeignKey" HeaderText="是否表外键" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="PrimaryKeyFieldName" SortExpression="PrimaryKeyFieldName" HeaderText="主键字段名" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="IsNeedTrans" SortExpression="IsNeedTrans" HeaderText="是否需要转换"></asp:BoundField>
                         <asp:BoundField DataField="TransWayName" SortExpression="TransWayName" HeaderText="转换方式名称" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FldLength" SortExpression="FldLength" HeaderText="字段长度"></asp:BoundField>
                        <asp:BoundField DataField="Trans_MissingValue" SortExpression="Trans_MissingValue" HeaderText="转换失败值" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Trans_NullValue" SortExpression="Trans_NullValue" HeaderText="转换空值" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Prefix" SortExpression="Prefix" HeaderText="前缀" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="PrefixFldId" SortExpression="PrefixFldId" HeaderText="前缀字段Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="PrefixFldName" SortExpression="PrefixFldName" HeaderText="前缀字段名" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="KeyWord" SortExpression="KeyWord" HeaderText="关键字"></asp:BoundField>
                        <asp:BoundField DataField="TabCnName" SortExpression="TabCnName" HeaderText="表中文名" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="TabEnName" SortExpression="TabEnName" HeaderText="表英文详细名" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <PagerTemplate>
                        <span class="text-secondary">共有记录:</span>
                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="46px">0</asp:Label>
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
                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
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
            <%-- 编辑层 --%>
            <div id="tabEditTabFieldRelaRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditTabFieldRela"  runat="server"
                                    CssClass="h6">表字段关系编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                &nbsp;
                                <asp:Button ID="btnCancelTabFieldRelaEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelTabFieldRelaEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucTabFieldRelaB id="wucTabFieldRelaB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
