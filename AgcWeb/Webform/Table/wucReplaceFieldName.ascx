<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucReplaceFieldName.ascx.cs" Inherits="AGC.Webform.wucReplaceFieldName" %>
<script src="../../js/agc.js"></script>
<script src="../../js/tzPubFun.js"></script>
<div id="divReplaceStrInField" runat="server">
    <table id="Table2" style="z-index: 107; width: 600px;" border="0">
       
        <tr>
            <td style="width: 100px; text-align: right">
                <asp:Label ID="Label2" Style="z-index: 102; left: 8px;"
                    runat="server" CssClass="NameLabel2">原字段名称</asp:Label></td>
            <td style="width: 130px">
                <asp:TextBox ID="txtSourceField" runat="server" Text="" CssClass="ValueLabel2" Width="130px"></asp:TextBox>
            </td>
          
            <td style="width: 100px; text-align: right">
                <asp:Label ID="Label11" 
                    runat="server" CssClass="NameLabel2">目标字段名称</asp:Label></td>
            <td style="width: 130px">
                <asp:TextBox ID="txtTargetField" runat="server" Text="" CssClass="ValueLabel2" Width="130px"></asp:TextBox>
            </td>
           
            <td style="width: 100px">
                <asp:Button ID="btnSumbitReplace" runat="server" Text="确认替换" OnClick="btnSumbitReplace_Click" />
            </td>
           
        </tr>
    </table>

</div>
