<%@ Page Language="C#" AutoEventWireup="True" CodeBehind ="TestConnect.aspx.cs" Inherits="AGC.Webform.TestConnect" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;<asp:Label ID="Label1" runat="server" Text=" com.taishsoft.commdb.clsSpecSQLforSql.WebConfigFileName:"
            Width="402px"></asp:Label><div>
                &nbsp;
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                    Text="����ļ��Ƿ����" />
                <asp:Label ID="Label2" runat="server" Style="z-index: 100; left: 9px; position: absolute;
                    top: 70px"></asp:Label>
                <asp:Label ID="Label3" runat="server" Style="z-index: 100; left: 8px; position: absolute;
                    top: 95px"></asp:Label>
                <asp:Label ID="Label4" runat="server" Style="z-index: 100; left: 10px; position: absolute;
                    top: 123px"></asp:Label>
                <asp:Label ID="Label5" runat="server" Style="z-index: 100; left: 10px; position: absolute;
                    top: 150px"></asp:Label>
    
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="ȡ���Ӵ�" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="��������" />
    
    </div>
    </form>
</body>
</html>
