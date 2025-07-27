<%@ Register TagPrefix="uc1" TagName="wucFuncModule" Src="wucFuncModule.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmFuncModule_Copy.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmFuncModule_Copy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表FuncModule_Agc的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 102; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">工程管理-->功能模块名称复制</asp:Label>
                </td>
            </tr>
        </table>
        <div id="divFuncModule" style="z-index: 119; left: 8px; width: 592px; position: absolute; top: 35px; height: 56px"
            runat="server">
            <asp:Label ID="lblFuncModuleIdq" Style="z-index: 104; left: 10px; position: absolute; top: 11px"
                runat="server" Width="70px">
  功能模块Id</asp:Label>
            <asp:TextBox ID="txtFuncModuleIdq" Style="z-index: 105; left: 85px; position: absolute; top: 8px"
                runat="server" Width="121"></asp:TextBox>
            <asp:Label ID="lblFuncModuleNameq" Style="z-index: 107; left: 208px; position: absolute; top: 11px"
                runat="server" >
  功能模块名称</asp:Label>
            <asp:TextBox ID="txtFuncModuleNameq" Style="z-index: 108; left: 296px; position: absolute; top: 8px"
                runat="server" Width="144px"></asp:TextBox>
            <asp:Label ID="lblPrjIdq" Style="z-index: 110; left: 16px; position: absolute; top: 32px"
                runat="server" >
  源工程</asp:Label>
            <asp:DropDownList ID="ddlPrjIdq" Style="z-index: 111; left: 85px; position: absolute; top: 29px"
                runat="server" Width="121">
            </asp:DropDownList>
            <asp:Button ID="btnQuery" Style="z-index: 113; left: 360px; position: absolute; top: 32px"
                runat="server"  
                Text="查询"></asp:Button>
        </div>
        <table id="tabFuncModuleDataGrid" style="z-index: 225; left: 8px; width: 552px; position: absolute; top: 96px"
            cellspacing="0" cellpadding="0"
            width="552" border="0" runat="server">
            <tr>
                <td>
                    <div style="display: inline; width: 584px; position: relative; height: 24px">
                        <asp:Button ID="btnFuncModuleCopy" Style="z-index: 100; left: 204px; position: absolute; top: 0px"
                            runat="server"  Width="97px" Text="复制模块名称"></asp:Button>
                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 101; left: 305px; position: absolute; top: 0px"
                            runat="server"   Text="导出Excel"></asp:Button>
                        <asp:Label ID="lblMsg" Style="z-index: 102; left: 392px; position: absolute; top: 8px"
                            runat="server" Width="184px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DataGrid ID="dgFuncModule" runat="server" Width="592px" AutoGenerateColumns="False"
                        AllowPaging="True" AllowSorting="True"
                        Height="216px">
                        <Columns>
                            <asp:TemplateColumn HeaderText="选择">
                                <HeaderStyle Width="15px"></HeaderStyle>
                                <HeaderTemplate>
                                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server">全选</asp:LinkButton>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="FuncModuleAgcId" SortExpression="FuncModuleAgcId" HeaderText="功能模块Id"></asp:BoundColumn>
                            <asp:BoundColumn DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="源工程"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundColumn>
                        </Columns>
                        <PagerStyle Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid>
                </td>
            </tr>
            <tr>
                <td style="width: 605px" bgcolor="silver">
                    <table id="tabFuncModuleJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                        <tr>
                            <td>
                               <font style="background-color: #c0c0c0">共有记录:</font>
                                    <asp:Label ID="lblFuncModuleRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">总页数:</font>
                                    <asp:Label ID="lblFuncModuleAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">当前页:</font>
                                            <asp:Label ID="lblFuncModuleCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnFuncModulePrevPage" runat="server"
                                            Width="50px" Text="上一页"></asp:Button>
                                        <asp:Button ID="btnFuncModuleNextPage" runat="server"
                                            Width="50px" Text="下一页"></asp:Button>
                                        到第
                                            <asp:TextBox ID="txtFuncModuleJump2Page" runat="server"
                                                Width="35px"></asp:TextBox>页
                                            <asp:Button ID="btnFuncModuleJumpPage" runat="server"
                                                Width="35px" Text="确定"></asp:Button>
                                        <asp:CompareValidator ID="FuncModuleCompareValidator1" runat="server" ForeColor="DarkOrange"
                                            ErrorMessage="错误！" ControlToValidate="txtFuncModuleJump2Page" Type="Integer"
                                            Operator="DataTypeCheck"></asp:CompareValidator>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
