<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDispViewTab.ascx.cs"
    Inherits="AGC.Webform.wucDispViewTab" %>
<asp:DataGrid ID="dgViewRelaTab" AutoGenerateColumns="False" PageSize="3" BorderColor="White"
    BorderStyle="Ridge" BorderWidth="0px" BackColor="White" CellPadding="0" GridLines="None"
     Font-Names="宋体" Width="200px" runat="server">
    <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
    <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
    <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
    <Columns>
        <asp:BoundColumn Visible="False" DataField="MId" HeaderText="关键字ID"></asp:BoundColumn>
        <asp:BoundColumn Visible="False" DataField="ViewInfoViewName" HeaderText="界面ID"></asp:BoundColumn>
        <asp:BoundColumn DataField="ViewTabTypeViewTabTypeName" HeaderText="界面表类型码"></asp:BoundColumn>
        <asp:BoundColumn DataField="PrjTabTabName" HeaderText="相关表名称"></asp:BoundColumn>
    </Columns>
    <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages">
    </PagerStyle>
</asp:DataGrid>
