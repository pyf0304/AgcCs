<%@ Register TagPrefix="uc1" TagName="wucFuncPara4CodeB" Src="wucFuncPara4CodeB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFuncParaRela_QUDI.aspx.cs" Inherits="AGC.Webform.wfmFuncParaRelaB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>函数参数4Code维护的维护</title>
    
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">函数参数关系维护 </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblDataTypeIdq"
                                runat="server" CssClass="text-secondary">数据类型Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDataTypeIdq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblParameterTypeq"
                                runat="server" CssClass="text-secondary">参数类型</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtParameterTypeq" 
                                runat="server" CssClass="TextBox_Defa"> </asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblParaNameq" 
                                runat="server" CssClass="text-secondary">参数名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtParaNameq" 
                                runat="server" CssClass="TextBox_Defa"> </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblFuncId4Codeq" 
                                runat="server" CssClass="text-secondary">Code函数</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncId4Codeq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
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

                            <asp:Button ID="btnQuery"
                                Style="z-index: 116; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List"
                runat="server">
                <div id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblFuncParaRelaList" runat="server"
                                CssClass="h6" Width="300px">函数参数列表</asp:Label>
                        </li>
                           <li class="nav-item ml-3">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                 <asp:DropDownList ID="ddlFuncParaId" runat="server" CssClass="TextBox_Defa ml-1">
                                </asp:DropDownList>
                                <asp:Button ID="btnAddRela" runat="server" OnClick="btnAddRela_Click"
                                    CssClass="btn btn-outline-info btn-sm" Text="添加参数"></asp:Button>
                               
                            </div>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                                CssClass="btn btn-outline-info btn-sm" Text="添加新参数"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCloneNewRec4Gv" runat="server" OnClick="btnCloneNewRec4Gv_Click"
                                Width="44px" CssClass="btn btn-outline-info btn-sm" Text="克隆"></asp:Button>
                        </li>
                       
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server" Visible="false"
                                CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnReturnParent" OnClick="btnReturnParent_Click" runat="server"
                                Width="126px" CssClass="btn btn-outline-warning btn-sm" Text="返回函数编辑界面"></asp:Button>
                        </li>
                            <li class="nav-item ml-3">

                            <div class="btn-group " role="group" aria-label="Basic example">
                                <asp:Button ID="btnGoTop" runat="server" Text="移顶" OnClick="btnGoTop_Click" CssClass="btn btn-outline-info btn-sm" />
                                <asp:Button ID="btnUpMove" runat="server" OnClick="btnUpMove_Click" Text="上移" CssClass="btn btn-outline-info btn-sm" />
                                <asp:Button ID="btnDownMove" runat="server" OnClick="btnDownMove_Click" Text="下移" CssClass="btn btn-outline-info btn-sm" />
                                <asp:Button ID="btnGoBottum" runat="server" Text="移底" OnClick="btnGoBottum_Click" CssClass="btn btn-outline-info btn-sm" />
                                <asp:Button ID="btnReOrder" runat="server" OnClick="btnReOrder_Click" Text="重序" CssClass="btn btn-outline-info btn-sm" />

                            </div>
                        </li>
                    </ul>
                </div>
                <asp:GridView ID="gvFuncParaRela" Style="z-index: 117;" runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvFuncParaRela_Sorting"
                    OnPageIndexChanging="gvFuncParaRela_PageIndexChanging"
                    OnRowCreated="gvFuncParaRela_RowCreated"
                    OnRowCommand="gvFuncParaRela_RowCommand"
                    OnRowDeleting="gvFuncParaRela_RowDeleting"
                    OnRowUpdating="gvFuncParaRela_RowUpdating"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="Horizontal"
                    Height="1px"
                    DataKeyNames="mId"
                    CssClass="table table-striped table-bordered table-condensed" OnRowDataBound="gvFuncParaRela_RowDataBound" >
                    <Columns>
                        <asp:TemplateField HeaderText="全选">
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" Text="全选"></asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <a name="A_FuncParaRela<%# Eval("FuncParaId4Code").ToString().Trim() %>"></a>
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
                        <asp:BoundField DataField="FuncId4Code" SortExpression="FuncId4Code" HeaderText="函数Id4Code"></asp:BoundField>
                        <asp:BoundField DataField="FuncName4Code" SortExpression="FuncName4Code" HeaderText="函数名4Code"></asp:BoundField>
                        <asp:BoundField DataField="FunctionSignature" SortExpression="FunctionSignature" HeaderText="函数签名"></asp:BoundField>
                        <asp:BoundField DataField="FuncParaId4Code" SortExpression="FuncParaId4Code" HeaderText="函数参数Id"></asp:BoundField>
                        <asp:BoundField DataField="ParaName" SortExpression="ParaName" HeaderText="参数名"></asp:BoundField>
                        <%--<asp:BoundField DataField="ParaCnName" SortExpression="ParaCnName" HeaderText="参数中文名"></asp:BoundField>--%>

                        <asp:BoundField DataField="DataTypeId" SortExpression="DataTypeId" HeaderText="数据类型Id"></asp:BoundField>
                        <asp:BoundField DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="数据类型名"></asp:BoundField>
                        <%--<asp:BoundField DataField="DataCnName" SortExpression="DataCnName" HeaderText="数据类型中文"></asp:BoundField>--%>
                        <asp:BoundField DataField="CsType" SortExpression="CsType" HeaderText="CS类型"></asp:BoundField>
                        <asp:BoundField DataField="JavaType" SortExpression="JavaType" HeaderText="JAVA类型"></asp:BoundField>
                        <asp:BoundField DataField="JavaObjType" SortExpression="JavaObjType" HeaderText="JAVA对象类型"></asp:BoundField>
                        <asp:BoundField DataField="SwiftType" SortExpression="SwiftType" HeaderText="SwiftType"></asp:BoundField>
                        <asp:BoundField DataField="IsNeedQuote" SortExpression="IsNeedQuote" HeaderText="是否需要引号"></asp:BoundField>
                        <asp:BoundField DataField="OraDbType" SortExpression="OraDbType" HeaderText="Ora数据类型"></asp:BoundField>
                        <asp:BoundField DataField="MySqlType" SortExpression="MySqlType" HeaderText="MySqlType"></asp:BoundField>
                        <asp:BoundField DataField="ParameterType" SortExpression="ParameterType" HeaderText="参数类型"></asp:BoundField>
                        <asp:BoundField DataField="ParameterTypeFullName" SortExpression="ParameterTypeFullName" HeaderText="参数类型"></asp:BoundField>
                        <asp:BoundField DataField="IsByRef" SortExpression="IsByRef" HeaderText="是否引用型参数"></asp:BoundField>
                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
                        <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者"></asp:BoundField>
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
            <div id="tabEditFuncPara4CodeRegion" class="tab_Edit"
                runat="server">
                <div>
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditFuncParaRela" runat="server" Width="300px"
                                CssClass="h6">函数参数编辑区域</asp:Label>
                        </li>
                       
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelFuncPara4CodeEdit"
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFuncPara4CodeEdit_Click"></asp:Button>
                        </li>
                         <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="208px" CssClass="text-warning"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucFuncPara4CodeB ID="wucFuncPara4CodeB1" runat="server" />
                </div>
            </div>
        </div>
        <asp:HiddenField ID="hidPrevPage" runat="server" />
    </form>
</body>
</html>
