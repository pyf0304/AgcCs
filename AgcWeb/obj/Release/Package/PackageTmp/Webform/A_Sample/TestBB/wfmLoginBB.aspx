<%@ Page Language="c#" CodeBehind="wfmLoginBB.aspx.cs" AutoEventWireup="True" Inherits="AGC.Webform.wfmLoginBB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>wfmLoginBB</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server" action="http://202.121.54.152/webapps/bb-quickLogin-bb_bb60/quickLogin.jsp">
        <asp:Label ID="Label1" Style="z-index: 101; left: 16px; position: absolute; top: 16px"
            runat="server" Width="96px"  CssClass="h5">测试BB登录</asp:Label>
        <br/>
        <input id="password" type="password" name="password" value="changeme" style="z-index: 102;
            left: 8px; position: absolute; top: 56px"/>
        <input id="username" name="username" value="Administrator" style="z-index: 103; left: 8px;
            position: absolute; top: 88px"/>
        <input style="z-index: 104; left: 40px; position: absolute; top: 128px" type="submit"
            value="Submit" onclick="myLogin()"/>
        <asp:LinkButton ID="LinkButton1" Style="z-index: 105; left: 40px; position: absolute;
            top: 200px" runat="server" Width="192px" >LinkButton</asp:LinkButton>
        <asp:HyperLink ID="HyperLink1" Style="z-index: 106; left: 288px; position: absolute;
            top: 40px" runat="server" Width="120px" Height="32px" NavigateUrl='http://202.121.54.152/webapps/bb-quickLogin-bb_bb60/quickLogin.jsp?username=Administrator&amp;password=changeme'>连接到BB1</asp:HyperLink>
        <div class="memostyle1" style="display: inline; z-index: 107; left: 424px; width: 232px;
            position: absolute; top: 40px; height: 40px">
            成功!该方式直接设置接连的URL，在URL中传递username和password</div>
        <asp:LinkButton ID="lbLinkToBB" Style="z-index: 109; left: 288px; position: absolute;
            top: 104px" runat="server" OnClick="lbLinkToBB_Click">连接到BB2</asp:LinkButton>
    </form>
</body>
</html>
