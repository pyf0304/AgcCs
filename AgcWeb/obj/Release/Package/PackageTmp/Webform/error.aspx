<%@ Page Language="c#" CodeBehind="error.aspx.cs" AutoEventWireup="True" Inherits="AGC.Webform.error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>error</title>
    <link href="../css/tz_base1.css" rel="stylesheet" />
</head>
<body bgcolor="#ffffff">
    <form id="Form1" runat="server">
        <img style="z-index: 103; left: 8px; position: absolute; top: 24px" alt="" src="..\pic\bar1.JPG" />
        <div style="display: inline; font-size: small; z-index: 105; left: 48px; width: 392px; font-family: Verdana; position: absolute; top: 56px; height: 18px; background-color: transparent">
            <p>
                <font face="幼圆"><strong>很抱歉，您的操作无法完成，可能由于以下原因：</strong></font><font face="幼圆">&nbsp;<em>&nbsp;</em></font>
            </p>
        </div>
        &nbsp;
        <div id="DIV1" class="PageRegionH1" style="display: inline; z-index: 102; left: 8px; width: 456px; position: absolute; top: 8px; height: 8px"
            runat="server">
            当前位置：&nbsp;系统信息 &gt;&gt;&nbsp; <strong>出错信息</strong>
        </div>
        <img style="z-index: 101; left: 248px; position: absolute; top: 160px" alt="" src="..\pic\building.jpg" />
        <div style="display: inline; font-size: small; z-index: 104; left: 184px; width: 400px; font-family: Verdana; position: absolute; top: 392px; height: 164px; background-color: transparent"
            id="DIV2" runat="server">
            <p>
                <font face="幼圆"><strong>很抱歉，您的操作无法完成，可能由于以下原因：</strong>&nbsp;&nbsp;&nbsp; </font>
            </p>
            <p>
                <font face="幼圆">&nbsp;<em> 1.您没有足够的使用权限。<br />
                    &nbsp;&nbsp;&nbsp; 2.由于很长时间没有操作了，登录超时。<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3.本功能被管理员暂时关闭。<br />
                </em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>
            </p>
            <p>
                <font face="幼圆"><strong>你可以点击这里</strong>
                    <asp:LinkButton ID="LinkButton1" runat="server"  OnClick="LinkButton1_Click">[重新登录]</asp:LinkButton><strong>，或稍候再试，谢谢！</strong></font><br />
            </p>
        </div>
        <asp:Label ID="lblErrMsg" Style="z-index: 106; left: 72px; position: absolute; top: 88px"
            runat="server" Width="368px" ForeColor="#C00000" CssClass="text-warning">Label</asp:Label>
        <asp:LinkButton ID="lbGoBack" Style="z-index: 107; left: 464px; position: absolute; top: 120px"
            runat="server" Width="55px" OnClick="lbGoBack_Click">返回</asp:LinkButton>
    </form>
</body>
</html>
