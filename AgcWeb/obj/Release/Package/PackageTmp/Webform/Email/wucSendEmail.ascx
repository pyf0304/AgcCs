<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucSendEmail.ascx.cs"
    Inherits="AGC.Webform.JCXX.wucSendEmail" %>

<div style="width: 665px; position: relative; height: 304px">
    <asp:TextBox ID="txtMailTo" Style="z-index: 100; left: 48px; position: absolute; top: 0px"
        runat="server"></asp:TextBox>
    <asp:TextBox ID="txtCopytoWithSender" Style="z-index: 101; left: 48px; position: absolute; top: 24px"
        runat="server"></asp:TextBox>
    <asp:TextBox ID="txtCopytoWithoutSender" Style="z-index: 102; left: 48px; position: absolute; top: 48px"
        runat="server"></asp:TextBox>
    <asp:Label ID="Label1" Style="z-index: 103; left: 0px; position: absolute; top: 0px"
        runat="server" Font-Bold="True">收信人：</asp:Label>
    <asp:Label ID="Label2" Style="z-index: 104; left: 8px; position: absolute; top: 24px"
        runat="server" Font-Bold="True">抄送：</asp:Label>
    <asp:Label ID="Label3" Style="z-index: 105; left: 8px; position: absolute; top: 48px"
        runat="server" Font-Bold="True">暗送：</asp:Label>
    <asp:Button ID="btnAdd_Mailto" Style="z-index: 106; left: 208px; position: absolute; top: 0px"
        runat="server" Text="添加"></asp:Button>
    <asp:Button ID="btnAdd_CopytoWithSender" Style="z-index: 107; left: 208px; position: absolute; top: 24px"
        runat="server" Text="添加"></asp:Button>
    <asp:Button ID="btnAdd_CopytoWithoutSender" Style="z-index: 108; left: 208px; position: absolute; top: 48px"
        runat="server" Text="添加"></asp:Button>
    <asp:Button ID="btnClear_Mailto" Style="z-index: 109; left: 248px; position: absolute; top: 0px"
        runat="server" Text="清空"></asp:Button>
    <asp:Button ID="btnClear_CopytoWithSender" Style="z-index: 110; left: 248px; position: absolute; top: 24px"
        runat="server" Text="清空"></asp:Button>
    <asp:Button ID="btnClear_CopytoWithoutSender" Style="z-index: 111; left: 248px; position: absolute; top: 48px"
        runat="server" Text="清空"></asp:Button>
    <asp:Label ID="lblMailTo" Style="z-index: 112; left: 288px; position: absolute; top: 0px"
        runat="server" Font-Bold="True">请添加相应的Email地址</asp:Label>
    <asp:Label ID="lblCopytoWithSender" Style="z-index: 113; left: 288px; position: absolute; top: 24px"
        runat="server" Font-Bold="True">请添加相应的Email地址</asp:Label>
    <asp:Label ID="lblCopytoWithoutSender" Style="z-index: 115; left: 288px; position: absolute; top: 48px"
        runat="server" Font-Bold="True">请添加相应的Email地址</asp:Label>
    <asp:TextBox ID="txtSubject" Style="z-index: 116; left: 48px; position: absolute; top: 80px"
        runat="server" Width="592px"></asp:TextBox>
    <asp:Label ID="Label7" Style="z-index: 117; left: 8px; position: absolute; top: 88px"
        runat="server" Font-Bold="True">主题：</asp:Label>
    <asp:Label ID="Label8" Style="z-index: 118; left: 8px; position: absolute; top: 112px"
        runat="server" Font-Bold="True">内容：</asp:Label>
    <asp:TextBox ID="txtBody" Style="z-index: 119; left: 48px; position: absolute; top: 112px"
        runat="server" Width="592px" Height="144px" TextMode="MultiLine"></asp:TextBox>
    <asp:Button ID="btn_SendMail" Style="z-index: 120; left: 128px; position: absolute; top: 264px"
        runat="server" Text="发送" Width="85px"></asp:Button>
    <asp:Label ID="lblErrorMsg" Style="z-index: 121; left: 224px; position: absolute; top: 264px"
        runat="server" ForeColor="Red"
        Font-Bold="True"></asp:Label>
</div>
