<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucEditRegionFldsBak20190601.ascx.cs"
    Inherits="AGC.Webform.wucEditRegionFldsBak20190601" %>
<table id="tabwucEditRegionFlds" cellspacing="1" cellpadding="1" border="0" style="width: 664px;
    height: 417px">
    <tr>
        <td>
            <asp:Label ID="lblTabFldId" runat="server" >表字段</asp:Label>
        </td>
        <td>
            <asp:Label ID="lblFldName" runat="server"></asp:Label>
        </td>
        <td>
            
        </td>
        <td>
        </td>
    </tr>
        <tr>
        <td>
            <asp:Label ID="Label2" runat="server" >标签标题</asp:Label>
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtLabelCaption" runat="server"
                Width="512px"  ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeId" runat="server" >控件类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCtlTypeId" runat="server" 
                Width="170px">
            </asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="Label1" runat="server">输入输出类型</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlINOUTTypeId" runat="server"
                Width="170px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDDLItemsOptionId" runat="server" >下拉框列表选项</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDDLItemsOptionId" runat="server" 
                Width="170px">
            </asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblDS_TabId" runat="server" >数据源表</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlDS_TabId" runat="server" 
                Width="170px" AutoPostBack="True" OnSelectedIndexChanged="ddlDS_TabId_SelectedIndexChanged">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDS_DataValueFieldId" runat="server" >数据源值字段</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDS_DataValueFieldId" runat="server" 
                 Width="170px">
            </asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblDS_DataTextFieldId" runat="server" >数据源文本字段</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlDS_DataTextFieldId" runat="server" 
                Width="170px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDS_CondStr" runat="server" >数据源条件串</asp:Label>
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtDS_CondStr" runat="server"
                Width="512px" Height="55px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDS_SQLStr" runat="server" >数据源SQL串</asp:Label></td>
        <td colspan="3">
            <asp:TextBox ID="txtDS_SQLStr" runat="server" 
                Width="512px" Height="79px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblItemsString" runat="server" >列表项串</asp:Label></td>
        <td colspan="3">
            <asp:TextBox ID="txtItemsString" runat="server" 
                Width="512px" Height="64px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label></td>
        <td colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="512px" Height="66px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="120" colspan="1" rowspan="1">
            
        </td>
        <td width="180">
            
        </td>
        <td width="120">
            
        </td>
        <td width="180">
            
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
        </td>
        <td>
            <asp:TextBox ID="txtTabFldId" runat="server" ></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUpdDate" runat="server" >修改日期</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUpdDate" runat="server" ></asp:TextBox></td>
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
            <asp:Label ID="lblSeqNum" runat="server" >字段序号</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSeqNum" runat="server" 
                Width="115px"></asp:TextBox>
            <asp:CompareValidator ID="ComValid_SeqNum" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtSeqNum" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator></td>
        <td>
        </td>
    </tr>
</table>
