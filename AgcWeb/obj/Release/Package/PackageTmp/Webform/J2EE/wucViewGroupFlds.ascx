<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewGroupFlds.ascx.cs"
    Inherits="AGC.Webform.wucViewGroupFlds" %>
<table id="tabwucViewGroupFlds" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblViewGroupId" runat="server" >界面组ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlViewGroupId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTabFldId" runat="server" >表字段ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTabFldId" runat="server" 
                Width="194px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeId" runat="server" >控件类型号</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCtlTypeId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDdlItemsOptionId" runat="server" >下拉框列表选项ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDdlItemsOptionId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsCondStr" runat="server" >数据源条件串</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDsCondStr" runat="server" 
                Width="194px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsDataTextFieldId" runat="server" >数据源文本字段Id</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsDataTextFieldId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsDataValueFieldId" runat="server" >数据源值字段Id</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsDataValueFieldId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsSqlStr" runat="server" >数据源SQL串</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDsSqlStr" runat="server" 
                Width="194px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsTabId" runat="server" >数据源表ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsTabId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblItemsString" runat="server" >列表项串</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtItemsString" runat="server" 
                Width="194px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSeqNum" runat="server" >字段序号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtSeqNum" runat="server" 
                Width="195px"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_SeqNum" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtSeqNum" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="194px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
            
        </td>
    </tr>
</table>
