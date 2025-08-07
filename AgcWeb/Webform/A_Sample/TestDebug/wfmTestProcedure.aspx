<%@ Page Language="c#" CodeBehind="wfmTestProcedure.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmTestProcedure" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>wfmTestProcedure</title>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        
            <asp:LinkButton ID="LinkButton1" Style="z-index: 100; left: 32px; position: absolute;
                top: 56px" runat="server" Width="184px" Height="32px">测试存储过程带返回值</asp:LinkButton>
            <asp:LinkButton ID="lbGetDaBaseTime" Style="z-index: 107; left: 32px; position: absolute;
                top: 272px" runat="server" Width="224px" Height="48px">获取数据库时间</asp:LinkButton>
            <asp:LinkButton ID="lbExecProcWithReturnDataTable" Style="z-index: 101; left: 32px;
                position: absolute; top: 88px" runat="server" Width="216px" Height="40px">测试存储过程返回DataTable</asp:LinkButton>
            <asp:DataGrid ID="DataGrid1" Style="z-index: 102; left: 328px; position: absolute;
                top: 64px" runat="server" Width="376px" Height="160px">
            </asp:DataGrid>
            <asp:LinkButton ID="lbCallFuncReDataTable" Style="z-index: 103; left: 32px; position: absolute;
                top: 136px" runat="server" Width="256px" >测试调用函数返回DataTable</asp:LinkButton>
            <asp:LinkButton ID="lbGetDaBaseDate" Style="z-index: 105; left: 32px; position: absolute;
                top: 168px" runat="server" Width="224px" Height="48px">获取数据库日期</asp:LinkButton>
            <asp:Label ID="lblMsg" Style="z-index: 106; left: 32px; position: absolute; top: 232px"
                runat="server" Width="160px" Height="40px">Label</asp:Label>
            <asp:LinkButton ID="lbTestGetSP_Para" runat="server" Height="32px" OnClick="lbTestGetSP_Para_Click"
                Style="z-index: 100; left: 31px; position: absolute; top: 339px" Width="184px">测试存储过程获取参数</asp:LinkButton>
        </font>
    </form>
</body>
</html>
