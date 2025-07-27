<%@ Register TagPrefix="uc1" TagName="wucDataGridStyle" Src="wucDataGridStyle.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmDataGridStyle_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmDataGridStyle_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>��DataGridStyle�Ĳ�ѯ���޸ġ�ɾ������Ӽ�¼</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
            <img style="z-index: 101; left: 8px; position: absolute; top: 0px" height="30" alt=""
                src="~/pic/��ɫ����.gif" width="840"/>
            <div style="display: inline; z-index: 102; left: 16px; width: 300px;
                color: #000066; position: absolute; top: 8px; height: 15px">
                �ؼ�ģʽ--&gt;DataGrid��ʽά��</div>
            <div id="divDataGridStyle" style="z-index: 103; left: 8px; width: 400px; position: absolute;
                top: 35px; height: 27px" runat="server">
                <asp:Label ID="lblDGStyleName_q" Style="z-index: 104; left: 10px; position: absolute;
                    top: 5px" runat="server"  
                    Width="70px">
  DGģʽ��</asp:Label>
                <asp:TextBox ID="txtDGStyleName_q" Style="z-index: 105; left: 85px; position: absolute;
                    top: 5px" runat="server" Width="216px"></asp:TextBox>
                <asp:Button ID="btnQuery" Style="z-index: 107; left: 312px; position: absolute; top: 0px"
                    runat="server"   
                    Text="��ѯ" OnClick="btnQuery_Click"></asp:Button>
            </div>
            <table id="Table1" style="z-index: 104; left: 4px; position: absolute; top: 60px"
                cellspacing="1" cellpadding="1" width="300" border="1">
                <tr>
                    <td>
                        <table id="tabDataGridStyleDataGrid" style="width: 552px; height: 350px"
                            cellspacing="0" cellpadding="0" width="552" border="0" runat="server">
                            <tr>
                                <td>
                                    <div style="width: 828px; position: relative; height: 24px">
                                        <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 102; left: 50px; position: absolute;
                                            top: 0px" runat="server"   Text="��Ӽ�¼" OnClick="btnAddNewRec4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 272px; position: absolute;
                                            top: 0px" runat="server"   Text="ɾ����¼" OnClick="btnDelete4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnUpdate4Dg" Style="z-index: 101; left: 360px; position: absolute;
                                            top: 0px" runat="server"   Text="�޸ļ�¼" OnClick="btnUpdate4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 104; left: 448px; position: absolute;
                                            top: 0px" runat="server"   Text="����Excel" OnClick="btnExportExcel4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnAddNewrecByCopy" Style="z-index: 105; left: 144px; position: absolute;
                                            top: 0px" runat="server"  Width="104px" Text="������Ӽ�¼" OnClick="btnAddNewrecByCopy_Click"></asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DataGrid ID="dgDataGridStyle" runat="server" 
                                        Height="300px" Width="844px" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                        BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                                        CellPadding="3" GridLines="Horizontal" OnItemCommand="dgDataGridStyle_ItemCommand" OnItemCreated="dgDataGridStyle_ItemCreated" OnItemDataBound="dgDataGridStyle_ItemDataBound" OnPageIndexChanged="dgDataGridStyle_PageIndexChanged" OnSortCommand="dgDataGridStyle_SortCommand">
                                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                        <Columns>
                                            <asp:TemplateColumn HeaderText="ѡ��">
                                                <HeaderStyle Width="15px"></HeaderStyle>
                                                <HeaderTemplate>
                                                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server"
                                                        >ȫѡ</asp:LinkButton>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn DataField="DGStyleId" SortExpression="DGStyleId" HeaderText="DGģʽID">
                                                <HeaderStyle Width="35px"></HeaderStyle>
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="DGStyleName" SortExpression="DGStyleName" HeaderText="DGģʽ��">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="FontSize" SortExpression="FontSize" HeaderText="�ֺ�"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsRadio" SortExpression="IsRadio" HeaderText="��ѡ��"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsCheck" SortExpression="IsCheck" HeaderText="��ѡ��"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsJumpPage" SortExpression="IsJumpPage" HeaderText="��ҳ">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsHaveUpdBtn" SortExpression="IsHaveUpdBtn" HeaderText="�޸İ�ť">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsHaveDelBtn" SortExpression="IsHaveDelBtn" HeaderText="ɾ����ť">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsHaveDetailBtn" SortExpression="IsHaveDetailBtn" HeaderText="��ϸ��ť">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsInTab" SortExpression="IsInTab" HeaderText="���ɱ���"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="Width" SortExpression="Width" HeaderText="��"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="Height" SortExpression="Height" HeaderText="�߶�"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsDefault" SortExpression="IsDefault" HeaderText="Ĭ��"></asp:BoundColumn>
                                            <asp:ButtonColumn Text="�޸�" CommandName="Update"></asp:ButtonColumn>
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="ɾ��"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                        </Columns>
                                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                        </PagerStyle>
                                    </asp:DataGrid></td>
                            </tr>
                            <tr>
                                <td style="width: 605px" bgcolor="silver">
                                    <table id="tabDataGridStyleJumpPage" style="width: 568px; font-family: Verdana;
                                        height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                        <tr>
                                            <td>
                                                <font face="����"><font style="background-color: #c0c0c0">���м�¼:</font>
                                                    <asp:Label ID="lblDataGridStyleRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">��ҳ��:</font>
                                                    <asp:Label ID="lblDataGridStyleAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">��ǰҳ:
                                                        <asp:Label ID="lblDataGridStyleCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                        <div style="display: inline; width: 16px; height: 13px">
                                                        </div>
                                                        <asp:Button ID="btnDataGridStylePrevPage" runat="server"  
                                                            Width="50px" Text="��һҳ" OnClick="btnDataGridStylePrevPage_Click"></asp:Button><asp:Button ID="btnDataGridStyleNextPage" runat="server"
                                                                 Width="50px" Text="��һҳ" OnClick="btnDataGridStyleNextPage_Click"></asp:Button>����
                                                        <asp:TextBox ID="txtDataGridStyleJump2Page" runat="server"  
                                                            Width="35px"></asp:TextBox>ҳ
                                                        <asp:Button ID="btnDataGridStyleJumpPage" runat="server"  
                                                            Width="35px" Text="ȷ��" OnClick="btnDataGridStyleJumpPage_Click"></asp:Button><asp:CompareValidator ID="DataGridStyleCompareValidator1"
                                                                runat="server" ForeColor="DarkOrange" ErrorMessage="����" ControlToValidate="txtDataGridStyleJump2Page"
                                                                Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabLayout" style="width: 373px; height: 200px" cellspacing="1" cellpadding="1"
                            width="373" border="1" runat="server">
                            <tr>
                                <td style="height: 40px">
                                    <asp:Button ID="btnOKUpd" runat="server" 
                                          Text="���" OnClick="btnOKUpd_Click"></asp:Button><asp:Label ID="lblMsg" runat="server"
                                             Width="136px"></asp:Label><asp:LinkButton
                                                ID="lbDispDataGridList" runat="server" OnClick="lbDispDataGridList_Click" >��ʾ�б�</asp:LinkButton></td>
                            </tr>
                            <tr>
                                <td>
                                    <uc1:wucdatagridstyle id="wucDataGridStyle1" runat="server">
                                    </uc1:wucdatagridstyle></td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
