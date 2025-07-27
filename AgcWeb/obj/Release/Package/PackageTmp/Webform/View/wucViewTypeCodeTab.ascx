<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewTypeCodeTab.ascx.cs"
    Inherits="AGC.Webform.wucViewTypeCodeTab" %>

<table id="tabwucViewTypeCodeTab" cellspacing="1" cellpadding="1" border="0"
    style="width: 797px; height: 295px">
    <tr>
        <td class="NameTD" style="width: 101px">
            <asp:Label ID="lblViewTypeCode" runat="server" 
                CssClass="col-form-label text-right">界面类型码</asp:Label>
        </td>
        <td class="ValueTD" style="width: 171px">
            <asp:TextBox ID="txtViewTypeCode" runat="server" 
                class="form-control-sm"></asp:TextBox>
        </td>
        <td style="width: 125px">
            <asp:Label ID="lblViewTypeName" runat="server" 
                CssClass="col-form-label text-right">界面类型名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewTypeName" runat="server" 
                class="form-control-sm" Width="227px"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 101px">
            <asp:Label ID="lblApplicationTypeId" runat="server" 
                CssClass="col-form-label text-right">应用程序类型</asp:Label>
        </td>
        <td class="ValueTD" style="width: 171px">
            <asp:DropDownList ID="ddlApplicationTypeId" runat="server" 
                class="form-control-sm" Width="158px">
            </asp:DropDownList>
        </td>
        <td style="width: 125px">
            <asp:CheckBox ID="chkIsHaveExcelExport" runat="server"
                Text="是否EXCEL导出"></asp:CheckBox>
        </td>
        <td>
            <asp:CheckBox ID="chkIsHaveSetExportExcel" runat="server"
                Text="是否设置EXCEL导出"></asp:CheckBox>
        </td>
    </tr>
    <tr>
        <td style="width: 101px">
            <asp:CheckBox ID="chkIsHaveAdd" runat="server"
                Text="是否有添加" Width="90px"></asp:CheckBox>
        </td>
        <td style="width: 171px">
            <asp:CheckBox ID="chkIsHaveUpdate" runat="server"
                Text="是否有修改"></asp:CheckBox>
        </td>
        <td style="width: 125px">
            <asp:CheckBox ID="chkIsHaveDel" runat="server"
                Text="是否有删除"></asp:CheckBox>
        </td>
        <td>
            <asp:CheckBox ID="chkIsHaveQuery" runat="server"
                Text="是否有查询"></asp:CheckBox>
            </td>
    </tr>
    <tr>
        <td style="width: 101px">
            &nbsp;</td>
        <td style="width: 171px">
            <asp:CheckBox ID="chkIsHaveDetail" runat="server"
                Text="是否有详细"></asp:CheckBox>
        </td>
        <td style="width: 125px">
            <asp:CheckBox ID="chkIsHaveExeAdd" runat="server" Text="是否有调用添加" Width="138px" />
        </td>
        <td>
            <asp:CheckBox ID="chkIsHaveExeUpdate" runat="server" Text="是否有调用修改" /></td>
    </tr>
    <tr>
        <td style="width: 101px">
            &nbsp;</td>
        <td style="width: 171px">
            <asp:CheckBox ID="chkIsHaveMainView" runat="server"
                Text="是否有主界面"></asp:CheckBox>
        </td>
        <td style="width: 125px">
            <asp:CheckBox ID="chkIsHaveSubView" runat="server"
                Text="是否有子界面"></asp:CheckBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
      <tr>
        <td>
            <asp:CheckBox ID="chkIsWebApp" runat="server" Text="是否Web应用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
       
        <td>
            <asp:CheckBox ID="chkIsWinApp" runat="server" Text="是否Win应用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
      
        <td>
            <asp:CheckBox ID="chkIsMobileApp" runat="server" Text="是否移动终端应用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
     
        <td></td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 101px">
            <asp:Label ID="lblViewFunction" runat="server" 
                CssClass="col-form-label text-right">界面功能</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtViewFunction" runat="server" 
                class="form-control-sm" Width="576px" TextMode="MultiLine" Height="56px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 101px">
            <asp:Label ID="lblOptProcess" runat="server" 
                CssClass="col-form-label text-right">操作流程</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtOptProcess" runat="server" 
                class="form-control-sm" Width="576px" TextMode="MultiLine" Height="56px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 101px">
            <asp:Label ID="lblViewDetail" runat="server" 
                CssClass="col-form-label text-right">界面说明</asp:Label>
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtViewDetail" runat="server" 
                class="form-control-sm" Width="576px" TextMode="MultiLine" Height="77px"></asp:TextBox>
        </td>
    </tr>
</table>
