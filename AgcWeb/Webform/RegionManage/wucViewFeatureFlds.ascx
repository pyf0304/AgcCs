<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewFeatureFlds.ascx.cs"
    Inherits="AGC.Webform.wucViewFeatureFlds" %>
<%@ Register Src="~/Webform/CommonControl/wucEditControl.ascx" TagPrefix="uc1" TagName="wucEditControl" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<table id="tabwucViewFeatureFlds" border="0" style="width: 420px; height: 217px">

    <tr id="trViewFeatureName" runat="server">
        <td class="text-right">
            <asp:Label ID="Label1" runat="server" Width="90px" CssClass="col-form-label-sm text-right">界面功能</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:Label ID="lblViewFeatureName" CssClass="text-secondary" Text="界面功能" runat="server" />

        </td>
        <td></td>
        <td></td>
    </tr>
      <tr>
        <td class="text-right">
            <asp:Label ID="lblFieldTypeId" runat="server"  Width="85px" CssClass="col-form-label-sm text-right">字段类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFieldTypeId" runat="server" class="form-control-sm" Width="300px" AutoPostBack="true" OnSelectedIndexChanged="ddlFieldTypeId_SelectedIndexChanged"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblFldId" runat="server" CssClass="col-form-label-sm text-right">字段</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFldId" runat="server" class="form-control-sm" AutoPostBack="True" Width="300px" OnSelectedIndexChanged="ddlFldId_SelectedIndexChanged"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
       <tr>
        <td colspan="4">
            <uc1:wucEditControl runat="server" ID="wucEditControl1" OnctlTypeIdChanged="wucEditControl1_ctlTypeIdChanged"  />
        </td>
    </tr>
   

      <tr id="trCtrlId" runat="server">
        <td class="text-right">
            <asp:Label ID="Label3"  CssClass="col-form-label-sm" runat="server">控件Id</asp:Label></td>
        <td colspan="3">
            <asp:TextBox ID="txtCtrlId" runat="server" Width="300px" class="form-control-sm" ></asp:TextBox></td>
    </tr>
  

    <tr id="trFuncName" runat="server">
        <td class="text-right">
            <asp:Label ID="lblFuncName" CssClass="col-form-label-sm" Width="85px" Text="函数名" runat="server" />
        </td>
        <td colspan="3" class="ValueTD">
            <asp:TextBox ID="txtFuncName" class="form-control-sm" Width="300px" runat="server" />
        </td>
      
    </tr>
    <tr id="trLabelCaption" runat="server">
        <td class="text-right">
            <asp:Label ID="Label2"  CssClass="col-form-label-sm" runat="server">标签标题</asp:Label>
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtLabelCaption" runat="server" class="form-control-sm"                Width="300px"></asp:TextBox>
        </td>
    </tr>
 
    <tr>
        <td class="text-right">
            <asp:Label ID="lblMemo"  CssClass="col-form-label-sm" runat="server">说明</asp:Label></td>
        <td colspan="3">
            <asp:TextBox ID="txtMemo" runat="server"
                Width="300px" Height="50px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>

</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td></td>
        <td>
            <asp:TextBox ID="txtTabFldId" runat="server"></asp:TextBox></td>
        <td></td>
    </tr>

    <tr>
        <td>
            <asp:Label ID="lblSeqNum" runat="server">字段序号</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSeqNum" runat="server"
                Width="115px"></asp:TextBox>
            <asp:CompareValidator ID="ComValid_SeqNum" runat="server"
                ErrorMessage="请输入整型数值!" ControlToValidate="txtSeqNum" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator></td>
        <td></td>
    </tr>
</table>
