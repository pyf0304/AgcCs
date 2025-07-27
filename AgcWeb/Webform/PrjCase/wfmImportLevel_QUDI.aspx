<%@ Page Language="c#" CodeBehind="wfmImportLevel_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmImportLevel_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucImportLevel" Src="wucImportLevel.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>�ImportLevel�Ĳ�ѯ���޸ġ�ɾ����Ӽ�¼</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="Label1" Style="z-index: 115; left: 8px; position: absolute; top: 8px"
            runat="server" Font-Size="Larger" Font-Names="���"  Width="272px"
            ForeColor="Blue">�ϵͳ���->���Ҫ����ά��</asp:Label>
        <asp:Label ID="Label2" Style="z-index: 107; left: 304px; position: absolute; top: 8px"
            runat="server" Width="42px" ForeColor="#004040" Font-Bold="True">˵�</asp:Label>
        <asp:Label ID="Label3" Style="z-index: 101; left: 344px; position: absolute; top: 8px"
            runat="server" Height="32px" Width="368px" ForeColor="#004040">���Ҫά��������ĳЩ���������Ҫ�̶ȡ�</asp:Label>
        <asp:Label ID="lblImportLevelIdq" Style="z-index: 102; left: 24px; position: absolute;
            top: 40px" runat="server"  >��Ҫ�̶ID</asp:Label>
        <asp:TextBox ID="txtImportLevelIdq" Style="z-index: 104; left: 128px; position: absolute;
            top: 40px" runat="server" Width="100px" ></asp:TextBox>
        <asp:Label ID="lblImportLevelq" Style="z-index: 105; left: 24px; position: absolute;
            top: 64px" runat="server"  >���Ҫ�̶</asp:Label>
        <asp:TextBox ID="txtImportLevelq" Style="z-index: 106; left: 128px; position: absolute;
            top: 64px" runat="server" Width="100px" ></asp:TextBox>
        <asp:Button ID="btnQuery" Style="z-index: 108; left: 248px; position: absolute; top: 64px"
            runat="server"   Text="Ȳ�ѯ"></asp:Button>
        <asp:DataGrid ID="dgImportLevel" Style="z-index: 109; left: 16px; position: absolute;
            top: 96px" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
            PageSize="5" AllowPaging="True" Font-Names="���">
            <Columns>
                <asp:BoundColumn DataField="ImportLevelId" HeaderText="���Ҫ�̶ID"></asp:BoundColumn>
                <asp:BoundColumn DataField="ImportLevel" HeaderText="���Ҫ�̶"></asp:BoundColumn>
                <asp:BoundColumn DataField="Memo" HeaderText="�˵�"></asp:BoundColumn>
                <asp:ButtonColumn Text="��޸" CommandName="Update"></asp:ButtonColumn>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="�ɾ�"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>
            <PagerStyle Mode="NumericPages"></PagerStyle>
        </asp:DataGrid>
        <asp:Label ID="lblRecCount" Style="z-index: 110; left: 24px; position: absolute;
            top: 264px" runat="server" Width="110px" >��ѯ����¼�</asp:Label>
        <asp:TextBox ID="txtRecCount" Style="z-index: 111; left: 144px; position: absolute;
            top: 264px" runat="server" Width="111px"  ReadOnly="True"></asp:TextBox>
        <table id="tabLayout" style="z-index: 112; left: 8px; width: 373px; position: absolute;
            top: 296px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="1">
            <tr>
                <td>
                    <uc1:wucImportLevel id="wucImportLevel1" runat="server">
                    </uc1:wucImportLevel></td>
            </tr>
        </table>
        <asp:Button ID="btnOKUpd" Style="z-index: 113; left: 400px; position: absolute; top: 296px"
            runat="server"   Text="���"></asp:Button>
        <asp:Label ID="lblMsg" Style="z-index: 114; left: 400px; position: absolute; top: 328px"
            runat="server" Width="215px" ></asp:Label>
    </form>
</body>
</html>
