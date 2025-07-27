<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucTabFieldRelaB.ascx.cs" Inherits="AGC.Webform.wucTabFieldRelaB" %>

<table id="tabwucTabFieldRela" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFldID" runat="server" CssClass="col-form-label text-right">字段ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFldID" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            &nbsp;</td>
        <td class="ValueTD">
            &nbsp;</td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlFldName" runat="server" CssClass="col-form-label text-right">Sql字段名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSqlFldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblExcelFieldName" runat="server" CssClass="col-form-label text-right">Excel字段名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtExcelFieldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDefaultValue" runat="server" CssClass="col-form-label text-right">缺省值</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDefaultValue" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsNeedTrans" runat="server" Text="是否需要转换" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransWayId" runat="server" CssClass="col-form-label text-right">转换方式ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransWayId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransTabName" runat="server" CssClass="col-form-label text-right">转换表名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransTabName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransInFldName" runat="server" CssClass="col-form-label text-right">转换IN字段名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransInFldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransOutFldName" runat="server" CssClass="col-form-label text-right">转换Out字段名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransOutFldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsTabPrimary" runat="server" Text="是否作为表中主键" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsTabForeignKey" runat="server" Text="是否表外键" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrimaryTypeId" runat="server" CssClass="col-form-label text-right">主键类型ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrimaryTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsIdentity" runat="server" Text="是否Identity" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsTabUnique" runat="server" Text="是否表中唯一" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsTabNullable" runat="server" Text="是否表中可空" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFieldTypeId" runat="server" CssClass="col-form-label text-right">字段类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFieldTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsNeedCheckPriForeignKey" runat="server" Text="是否检查主外键" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrimaryKeyTabName" runat="server" CssClass="col-form-label text-right">主键表</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrimaryKeyTabName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrimaryKeyFieldName" runat="server" CssClass="col-form-label text-right">主键字段名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrimaryKeyFieldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>   
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransMissingValue" runat="server" CssClass="col-form-label text-right">转换失败值</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransMissingValue" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransNullValue" runat="server" CssClass="col-form-label text-right">转换空值</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransNullValue" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
  
   
    <tr>
        <td class="NameTD">
            &nbsp;</td>
        <td class="ValueTD">
            &nbsp;</td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsVisible" runat="server" Text="是否显示" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSequenceNumber" runat="server" CssClass="col-form-label text-right">顺序号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSequenceNumber" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_SequenceNumber" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtSequenceNumber"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
