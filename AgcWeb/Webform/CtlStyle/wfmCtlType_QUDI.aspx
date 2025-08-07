<%@ Register TagPrefix="uc1" TagName="wucCtlTypeAbbr" Src="wucCtlTypeAbbr.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmCtlType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmCtlTypeAbbr_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>�CtlTypeAbbr�Ĳ�ѯ���޸ġ�ɾ����Ӽ�¼</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="Label3" Style="z-index: 118; left: 8px; position: absolute; top: 8px"
            runat="server" Font-Size="Larger" Font-Names="���"  Width="240px"
            ForeColor="Blue">���Ŀ������->�ؼ�����ά��</asp:Label>
        <asp:Label ID="Label2" Style="z-index: 102; left: 256px; position: absolute; top: 8px"
            runat="server" Width="42px" ForeColor="#004040" Font-Bold="True">˵�</asp:Label>
        <asp:Label ID="Label4" Style="z-index: 101; left: 304px; position: absolute; top: 8px"
            runat="server" Height="32px" Width="464px" ForeColor="#004040">���Ҫά���ڽ�����ƹ�������漰�Ŀؼ����͡�����ı�������򡢰�ť�ȡ�</asp:Label>
        <table id="tabLayout" style="z-index: 115; left: 486px; width: 373px; position: absolute;
            top: 40px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="4"
            bordercolor="#333333">
            <tr>
                <td valign="top">
                    <asp:Button ID="btnOKUpd" runat="server"   Text="��"></asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="215px" ></asp:Label></td>
            </tr>
            <tr>
                <td valign="top">
                    <uc1:wucCtlTypeAbbr ID="wucCtlTypeAbbr1" runat="server"></uc1:wucCtlTypeAbbr>
                </td>
            </tr>
        </table>
        <table id="Table1" style="z-index: 119; left: 2px; position: absolute; top: 40px"
            bordercolor="#336666" cellspacing="1" cellpadding="1" width="300" border="4">
            <tr>
                <td>
                    <asp:Label ID="lblCtlTypeIdq" runat="server"  >ӿؼ����ID</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtCtlTypeIdq" runat="server" Width="100px" ></asp:TextBox></td>
                <td>
                    <asp:Label ID="lblCtlTypeNameq" runat="server"  >�������</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtCtlTypeNameq" runat="server" Width="100px" ></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCtlCnNameq" runat="server"  >ƿؼ�������</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtCtlCnNameq" runat="server" Width="100px" ></asp:TextBox></td>
                <td>
                    <asp:Label ID="lblCtlTypeAbbrq" runat="server"  >ƿؼ�������д</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtCtlTypeAbbrq" runat="server" Width="100px" ></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                </td>
                <td colspan="2">
                    <asp:Button ID="btnQuery" runat="server"   Text="��ѯ"></asp:Button></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:DataGrid ID="dgCtlTypeAbbr" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
                        AllowPaging="True" Font-Names="���" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px"
                        CellSpacing="1" BackColor="White" CellPadding="3" GridLines="None">
                        <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                        <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                        <Columns>
                            <asp:BoundColumn DataField="CtlTypeId" HeaderText="�ؼ����ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="CtlTypeName" HeaderText="�������"></asp:BoundColumn>
                            <asp:BoundColumn DataField="CtlCnName" HeaderText="ƿؼ�������"></asp:BoundColumn>
                            <asp:BoundColumn DataField="CtlTypeAbbr" HeaderText="ƿؼ�������д"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" HeaderText="��ע"></asp:BoundColumn>
                            <asp:ButtonColumn Text="�޸" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="�ɾ�"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages">
                        </PagerStyle>
                    </asp:DataGrid></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="����">��ѯ����¼�</asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px" Font-Names="����"
                        ReadOnly="True"></asp:TextBox></td>
            </tr>
        </table>
    </form>
</body>
</html>
