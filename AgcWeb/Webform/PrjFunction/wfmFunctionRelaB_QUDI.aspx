<%@ Register TagPrefix="uc1" TagName="wucFunctionRelaB" Src="wucFunctionRelaB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFunctionRelaB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmFunctionRelaB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>函数与函数关系维护的维护</title>
    
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
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >函数与函数关系维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblmIdq" 
                                runat="server" CssClass="text-secondary">mId</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtmIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblFuncAIdq" 
                                runat="server" CssClass="text-secondary">函数AId</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncAIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblFuncBIdq" 
                                runat="server" CssClass="text-secondary">函数BId</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncBIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblFunctionRelaTypeIdq" 
                                runat="server" CssClass="text-secondary">函数关系类型Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFunctionRelaTypeIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblFunctionRelaTypeNameq" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">函数关系类型名称</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFunctionRelaTypeNameq" Style="z-index: 117;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblUpdDateq" Style="z-index: 119;"
                                runat="server" CssClass="text-secondary">修改日期</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUpdDateq" Style="z-index: 120;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblUpdUserq" Style="z-index: 122;"
                                runat="server" CssClass="text-secondary">修改者</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUpdUserq" Style="z-index: 123;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblMemoq" Style="z-index: 125;"
                                runat="server" CssClass="text-secondary">说明</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtMemoq" Style="z-index: 126;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblFuncANameq" Style="z-index: 128;"
                                runat="server" CssClass="text-secondary">FuncAName</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFuncANameq" Style="z-index: 129;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblProgLangTypeIdAq" Style="z-index: 131;"
                                runat="server" CssClass="text-secondary">ProgLangTypeIdA</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtProgLangTypeIdAq" Style="z-index: 132;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblProgLangTypeNameAq" Style="z-index: 134;"
                                runat="server" CssClass="text-secondary">ProgLangTypeNameA</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtProgLangTypeNameAq" Style="z-index: 135;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblCodeTypeIdAq" Style="z-index: 137;"
                                runat="server" CssClass="text-secondary">CodeTypeIdA</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodeTypeIdAq" Style="z-index: 138;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblFuncBNameq" Style="z-index: 140;"
                                runat="server" CssClass="text-secondary">FuncBName</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFuncBNameq" Style="z-index: 141;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblProgLangTypeIdBq" Style="z-index: 143;"
                                runat="server" CssClass="text-secondary">ProgLangTypeIdB</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtProgLangTypeIdBq" Style="z-index: 144;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblProgLangTypeNameBq" Style="z-index: 146;"
                                runat="server" CssClass="text-secondary">ProgLangTypeNameB</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtProgLangTypeNameBq" Style="z-index: 147;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblCodeTypeENNameAq" Style="z-index: 149;"
                                runat="server" CssClass="text-secondary">CodeTypeENNameA</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodeTypeENNameAq" Style="z-index: 150;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblCodeTypeENNameBq" Style="z-index: 152;"
                                runat="server" CssClass="text-secondary">CodeTypeENNameB</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodeTypeENNameBq" Style="z-index: 153;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblCodeTypeIdBq" Style="z-index: 155;"
                                runat="server" CssClass="text-secondary">CodeTypeIdB</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodeTypeIdBq" Style="z-index: 156;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblCodeTypeNameAq" Style="z-index: 158;"
                                runat="server" CssClass="text-secondary">CodeTypeNameA</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodeTypeNameAq" Style="z-index: 159;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblCodeTypeNameBq" Style="z-index: 161;"
                                runat="server" CssClass="text-secondary">CodeTypeNameB</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodeTypeNameBq" Style="z-index: 162;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 164; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
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
                            <asp:Label ID="lblFunctionRelaList" runat="server" 
                                CssClass="h6" Width="250px">函数与函数关系列表</asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" 
                                 CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
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
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                </table>
                <asp:GridView ID="gvFunctionRela" Style="z-index: 165;" runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvFunctionRela_Sorting"
                    OnPageIndexChanging="gvFunctionRela_PageIndexChanging"
                    OnRowCreated="gvFunctionRela_RowCreated"
                    OnRowCommand="gvFunctionRela_RowCommand"
                    OnRowDeleting="gvFunctionRela_RowDeleting"
                    OnRowUpdating="gvFunctionRela_RowUpdating"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="Horizontal"
                    Height="1px"
                    DataKeyNames="mId"
                    CssClass="table table-striped table-bordered table-condensed">
                    <Columns>
                        <asp:TemplateField HeaderText="全选">
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" Text="全选"></asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <a name="A_FunctionRela<%# Eval("mId").ToString().Trim() %>"></a>
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId"></asp:BoundField>
                        <asp:BoundField DataField="FuncAId" SortExpression="FuncAId" HeaderText="函数AId"></asp:BoundField>
                        <asp:BoundField DataField="FuncBId" SortExpression="FuncBId" HeaderText="函数BId"></asp:BoundField>
                        <asp:BoundField DataField="FunctionRelaTypeId" SortExpression="FunctionRelaTypeId" HeaderText="函数关系类型Id"></asp:BoundField>
                        <asp:BoundField DataField="FunctionRelaTypeName" SortExpression="FunctionRelaTypeName" HeaderText="函数关系类型名称"></asp:BoundField>
                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
                        <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者"></asp:BoundField>
                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>
                        <asp:BoundField DataField="FuncAName" SortExpression="FuncAName" HeaderText="FuncAName"></asp:BoundField>
                        <asp:BoundField DataField="ProgLangTypeIdA" SortExpression="ProgLangTypeIdA" HeaderText="ProgLangTypeIdA"></asp:BoundField>
                        <asp:BoundField DataField="ProgLangTypeNameA" SortExpression="ProgLangTypeNameA" HeaderText="ProgLangTypeNameA"></asp:BoundField>
                        <asp:BoundField DataField="FuncBName" SortExpression="FuncBName" HeaderText="FuncBName"></asp:BoundField>
                        <asp:BoundField DataField="ProgLangTypeIdB" SortExpression="ProgLangTypeIdB" HeaderText="ProgLangTypeIdB"></asp:BoundField>
                        <asp:BoundField DataField="ProgLangTypeNameB" SortExpression="ProgLangTypeNameB" HeaderText="ProgLangTypeNameB"></asp:BoundField>
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
            <%-- 编辑层 --%>
            <div id="tabEditFunctionRelaRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditFunctionRela"  runat="server"
                                    CssClass="h6">函数与函数关系编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                <asp:Button ID="btnCancelFunctionRelaEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFunctionRelaEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucFunctionRelaB ID="wucFunctionRelaB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
