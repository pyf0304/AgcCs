<%@ Page Language="c#" CodeBehind="wfmElecDict_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmElecDict_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucElecDict" Src="wucElecDict.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>�ElecDict�Ĳ�ѯ���޸ġ�ɾ����Ӽ�¼</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
    <table id="tabTitle" style="z-index: 102; left: 8px; position: absolute; top: 8px"
        cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
        <tr>
            <td bgcolor="#ff6666">
                <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="���" ForeColor="White"
                    Font-Bold="True">幤�̹��->�����ֵ</asp:Label>
            </td>
        </tr>
    </table>
    <div id="divElecDict" style="z-index: 119; left: 8px; width: 784px; position: absolute;
        top: 35px; height: 32px" runat="server">
        <asp:Label ID="lblWordTypeIdq" Style="z-index: 107; left: 16px; position: absolute;
            top: 8px" runat="server" Width="70px">
  䵥�ʷ��ID</asp:Label>
        <asp:DropDownList ID="ddlWordTypeIdq" Style="z-index: 108; left: 96px; position: absolute;
            top: 8px" runat="server" Width="104px">
        </asp:DropDownList>
        <asp:Label ID="lblChineseWordq" Style="z-index: 110; left: 496px; position: absolute;
            top: 8px" runat="server" Width="56px">
  ����ĵ��</asp:Label>
        <asp:TextBox ID="txtChineseWordq" Style="z-index: 111; left: 560px; position: absolute;
            top: 8px" runat="server" Width="128px"></asp:TextBox>
        <asp:Label ID="lblEnglishWordq" Style="z-index: 113; left: 240px; position: absolute;
            top: 8px" runat="server" Width="70px">
  �Ӣ�ĵ��</asp:Label>
        <asp:TextBox ID="txtEnglishWordq" Style="z-index: 114; left: 312px; position: absolute;
            top: 8px" runat="server" Width="152px"></asp:TextBox>
        <asp:Button ID="btnQuery" Style="z-index: 119; left: 696px; position: absolute; top: 8px"
            runat="server"   Text="ʲ�ѯ" OnClick="btnQuery_Click">
        </asp:Button>
    </div>
    <table id="tabElecDictDataGrid" style="z-index: 225; left: 8px; width: 544px; position: absolute;
        top: 72px; height: 362px" cellspacing="0" cellpadding="0" width="544" border="0"
        runat="server">
        <tr>
            <td>
                <asp:DataGrid ID="dgElecDict" runat="server" Width="552px" Height="300px" AutoGenerateColumns="False"
                    PageSize="15" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333"
                    GridLines="None" OnItemCommand="dgElecDict_ItemCommand" OnItemCreated="dgElecDict_ItemCreated"
                    OnPageIndexChanged="dgElecDict_PageIndexChanged" OnSortCommand="dgElecDict_SortCommand">
                    <Columns>
                        <asp:BoundColumn DataField="mId" SortExpression="mId" HeaderText="mId"></asp:BoundColumn>
                        <asp:BoundColumn DataField="WordTypeWordTypeName" SortExpression="WordTypeId" HeaderText="���ʷ��ID">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="EnglishWord" SortExpression="EnglishWord" HeaderText="�Ӣ�ĵ��">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="ChineseWord" SortExpression="ChineseWord" HeaderText="����ĵ��">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="�˵�"></asp:BoundColumn>
                        <asp:ButtonColumn Text="��޸" CommandName="Update"></asp:ButtonColumn>
                        <asp:TemplateColumn>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="�ɾ�"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center"></PagerStyle>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditItemStyle BackColor="#999999" />
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                </asp:DataGrid>
            </td>
        </tr>
        <tr>
            <td style="width: 605px" bgcolor="silver">
                <table id="tabElecDictJumpPage" style="width: 544px; font-family: Verdana; height: 26px"
                    cellspacing="0" cellpadding="0" width="544" border="1" runat="server">
                    <tr>
                        <td>
                            <font face="����"><font style="background-color: #c0c0c0">干�м�¼:</font>
                                <asp:Label ID="lblElecDictRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                <div style="display: inline; width: 16px; height: 13px">
                                </div>
                                <font style="background-color: #c0c0c0">��ҳ�:</font>
                                <asp:Label ID="lblElecDictAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                <div style="display: inline; width: 16px; height: 13px">
                                </div>
                                <font style="background-color: #c0c0c0">�ǰҳ:
                                    <asp:Label ID="lblElecDictCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <asp:Button ID="btnElecDictPrevPage" runat="server" Width="50px" Text="��һҳ"></asp:Button>
                                    <asp:Button ID="btnElecDictNextPage" runat="server" Width="50px" Text="��һҳ"></asp:Button>
                                    ���
                                    <asp:TextBox ID="txtElecDictJump2Page" runat="server" Width="35px"></asp:TextBox>�ҳ
                                    <asp:Button ID="btnElecDictJumpPage" runat="server" Width="35px" Text="ȷ��"></asp:Button>
                                    <asp:CompareValidator ID="ElecDictCompareValidator1" runat="server" ForeColor="DarkOrange"
                                        ErrorMessage="���" ControlToValidate="txtElecDictJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <table id="tabLayout" style="z-index: 241; left: 560px; width: 304px; position: absolute;
        top: 72px; height: 200px" cellspacing="1" cellpadding="1" width="304" border="1">
        <tr>
            <td>
                <asp:Button ID="btnOKUpd" runat="server"   Text="���" OnClick="btnOKUpd_Click">
                </asp:Button>
            </td>
            <td>
                <asp:Label ID="lblMsg" runat="server" Width="209px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <uc1:wucElecDict ID="wucElecDict1" runat="server"></uc1:wucElecDict>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
