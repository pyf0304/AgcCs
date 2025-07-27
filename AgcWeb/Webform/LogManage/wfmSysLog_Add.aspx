<%@ Page Language="c#" CodeBehind="wfmSysLog_Add.aspx.cs" AutoEventWireup="True" Inherits="AGC.wfmSysLog_Add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>wfmSysLog_Add</title>
    
</head>
<body background="../../pic/bg3.gif">
    <form id="Form1" method="post" runat="server">
        <div id="divSysLog" style="z-index: 101; left: 40px; width: 464px; position: absolute;
            top: 128px; height: 88px" runat="server" >
            <asp:Label ID="lblUserIdq" Style="z-index: 101; left: 10px; position: absolute;
                top: 5px" runat="server" Width="56px" >
  用户编号</asp:Label>
            <asp:TextBox ID="txtUserIdq" Style="z-index: 102; left: 69px; position: absolute;
                top: 5px" runat="server" Width="96px" ></asp:TextBox>
            <asp:Label ID="lblUserNameq" Style="z-index: 103; left: 10px; position: absolute;
                top: 33px" runat="server" Width="56px" >
  用户姓名</asp:Label>
            <asp:TextBox ID="txtUserNameq" Style="z-index: 104; left: 69px; position: absolute;
                top: 33px" runat="server" Width="96px" ></asp:TextBox>
            <asp:Label ID="lblUserIpq" Style="z-index: 105; left: 10px; position: absolute;
                top: 61px" runat="server"  >
  用户IP</asp:Label>
            <asp:TextBox ID="txtUserIpq" Style="z-index: 106; left: 69px; position: absolute;
                top: 61px" runat="server" Width="96px" ></asp:TextBox>
            <asp:Label ID="lblOperationTypeq" Style="z-index: 107; left: 184px; position: absolute;
                top: 8px" runat="server" Width="56px" >
  操作类型</asp:Label>
            <asp:Label ID="lblTableNameq" Style="z-index: 109; left: 184px; position: absolute;
                top: 40px" runat="server" Width="56px" >
  数据表名</asp:Label>
            <asp:TextBox ID="txtTableNameq" Style="z-index: 110; left: 248px; position: absolute;
                top: 32px" runat="server" Width="96px" ></asp:TextBox>
            <asp:Label ID="lblTableKeyq" Style="z-index: 111; left: 184px; position: absolute;
                top: 64px" runat="server" Width="72px" >
  关键字段名</asp:Label>
            <asp:TextBox ID="txtTableKeyq" Style="z-index: 112; left: 248px; position: absolute;
                top: 56px" runat="server" Width="97px" ></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 113; left: 360px; position: absolute; top: 24px"
                runat="server" Width="88px"  
                Text="详细日志添加"></asp:Button>
            <asp:Button ID="Button1" Style="z-index: 114; left: 360px; position: absolute; top: 56px"
                runat="server" Width="88px" Text="基本日志添加"></asp:Button>
            <asp:DropDownList ID="ddlOpTypeId" Style="z-index: 102; left: 248px; position: absolute;
                top: 0px" runat="server"  Width="158px">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
