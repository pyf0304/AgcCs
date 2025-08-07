
<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmWebSrvFuncParaB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmWebSrvFuncParaB_QUDI" %>

<%@ Register Src="~/Webform/GenCode/wucWebSrvFuncParaB.ascx" TagPrefix="uc2" TagName="wucWebSrvFuncParaB" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>WebSrv函数参数维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
   
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >WebSrv函数参数维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 95%">
                    <tr>
                         <td>
                            <asp:Label ID="lblWebSrvClassIdq" 
                                runat="server" CssClass="text-secondary">WebSrv类</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlWebSrvClassIdq" 
                                runat="server" CssClass="TextBox_Defa" OnSelectedIndexChanged="ddlWebSrvClassId_q_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblWebSrvFunctionIdq" Style="z-index: 136;"
                                runat="server" CssClass="text-secondary">函数Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlWebSrvFunctionIdq" Style="z-index: 137;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblParaNameq" Style="z-index: 125;"
                                runat="server" CssClass="text-secondary">参数名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtParaNameq" Style="z-index: 126;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                  


                        <td>
                            <asp:Label ID="lblDataTypeIdq" 
                                runat="server" CssClass="text-secondary">数据类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDataTypeIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblParameterTypeq" Style="z-index: 131;"
                                runat="server" CssClass="text-secondary">参数类型</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtParameterTypeq" Style="z-index: 132;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblCsTypeq" Style="z-index: 119;"
                                runat="server" CssClass="text-secondary">CS类型</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCsTypeq" Style="z-index: 120;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblWebSrvUrl_q0" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">异步函数?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsAsyncFunc" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 139; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>         
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List"
                runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblWebSrvFuncParaList" runat="server" 
                                CssClass="h6" Width="250px">WebSrv函数参数列表</asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnAddToSelfDefDataType" runat="server" OnClick="btnAddToSelfDefDataType_Click"
                                Width="125px" CssClass="auto-style1" Text="添加到自定义类型" ToolTip="添加参数类型到自定义类型"></asp:Button>
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
                <asp:GridView ID="gvWebSrvFuncPara" Style="z-index: 140;" runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvWebSrvFuncPara_Sorting"
                    OnPageIndexChanging="gvWebSrvFuncPara_PageIndexChanging"
                    OnRowCreated="gvWebSrvFuncPara_RowCreated"
                    OnRowCommand="gvWebSrvFuncPara_RowCommand"
                    OnRowDeleting="gvWebSrvFuncPara_RowDeleting"
                    OnRowUpdating="gvWebSrvFuncPara_RowUpdating"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="Horizontal"
                    Height="1px"
                    DataKeyNames="WebSrvFuncParaId"
                    CssClass="table table-striped table-bordered table-condensed">
                    <Columns>
                        <asp:TemplateField HeaderText="全选">
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" Text="全选"></asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <a name="A_WebSrvFuncPara<%# Eval("WebSrvFuncParaId").ToString().Trim() %>"></a>
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="WebSrvFuncParaId" SortExpression="WebSrvFuncParaId" HeaderText="函数参数Id"></asp:BoundField>
                        <asp:BoundField DataField="ClassName" SortExpression="ClassName" HeaderText="类名"></asp:BoundField>
                         <asp:BoundField DataField="FunctionName" SortExpression="FunctionName" HeaderText="函数名"></asp:BoundField>
                        <asp:BoundField DataField="FunctionSignature" SortExpression="FunctionSignature" HeaderText="函数签名" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="ParaName" SortExpression="ParaName" HeaderText="参数名"></asp:BoundField>
                        <asp:BoundField DataField="DataTypeId" SortExpression="DataTypeId" HeaderText="数据类型Id"></asp:BoundField>
                        <asp:BoundField DataField="ParameterType" SortExpression="ParameterType" HeaderText="参数类型"></asp:BoundField>
                        <asp:BoundField DataField="IsKnownType" SortExpression="IsKnownType" HeaderText="已知?"></asp:BoundField>
                        <asp:BoundField DataField="IsByRef" SortExpression="IsByRef" HeaderText="是否引用型参数"></asp:BoundField>
                        <asp:BoundField DataField="CsType" SortExpression="CsType" HeaderText="CS类型"></asp:BoundField>
                        <asp:BoundField DataField="JavaType" SortExpression="JavaType" HeaderText="JAVA类型"></asp:BoundField>
                        <asp:BoundField DataField="JavaObjType" SortExpression="JavaObjType" HeaderText="JAVA对象类型"></asp:BoundField>
                        <asp:BoundField DataField="SwiftType" SortExpression="SwiftType" HeaderText="SwiftType"></asp:BoundField>
                        <asp:BoundField DataField="OraDbType" SortExpression="OraDbType" HeaderText="Ora数据类型"></asp:BoundField>
                        <asp:BoundField DataField="MySqlType" SortExpression="MySqlType" HeaderText="MySqlType"></asp:BoundField>
      <asp:BoundField DataField="IsGeneCode" SortExpression="IsGeneCode" HeaderText="生成?"></asp:BoundField>
                           <asp:BoundField DataField="IsAsyncFunc" SortExpression="IsAsyncFunc" HeaderText="异步?"></asp:BoundField>
                      
                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
                        <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>
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
            <div id="tabEditWebSrvFuncParaRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditWebSrvFuncPara"  runat="server"
                                    CssClass="h6">WebSrv函数参数编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                <asp:Button ID="btnCancelWebSrvFuncParaEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelWebSrvFuncParaEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc2:wucWebSrvFuncParaB id="wucWebSrvFuncParaB1" runat="server" />
                    
                </div>
            </div>
        </div>
    </form>
</body>
</html>
