<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFunction4GC4BatchUpdate.ascx.cs"
    Inherits="AGC.Webform.wucFunction4GC4BatchUpdate" %>

<style type="text/css">
    .FirstCol {
        width: 80px;
    }

    table {
        width: 90%;
    }

</style>
<script src="../../js/tzPubFun.js"></script>
<script>
    function ShowHideProperty() {
        var tabGeneralProp = document.getElementById("tabGeneralProp");
        var btnHideProperty = document.getElementById("btnHideProperty");
        console.log(btnHideProperty);
        if (tabGeneralProp == null) return;
        if (btnHideProperty.value === "隐藏属性") {
            console.log(tabGeneralProp);
            btnHideProperty.value = "显示属性"
            tabGeneralProp.style.display = 'none';
        }
        else {
            console.log(tabGeneralProp);
            btnHideProperty.value = "隐藏属性"
            tabGeneralProp.style.display = 'block';
        }
    }
    function ShowGeneCode() {
        var ddlTabId = getObjByTagAndId("select", "ddlTabId");
        ddlTabId.style.display = "block";
        ddlTabId.style.visibility = "visible";

        var btnOKGeneCode = getObjByTagAndId("input", "btnOKGeneCode");
        btnOKGeneCode.style.display = "block";
        btnOKGeneCode.style.visibility = "visible";

    }
</script>

<table id="tabGeneralProp" class="auto-style1">
    <tr>
        <td class="NameTD FirstCol">
            <asp:Label ID="lblFuncName" runat="server" CssClass="col-form-label text-right">函数名替换</asp:Label>
        </td>
        <td class="ValueTD" style="text-align:right" colspan="1">
            <asp:Label ID="lblFunctionSignature0" runat="server" CssClass="col-form-label text-right">原字符串：</asp:Label>
        </td>
        <td class="ValueTD" colspan="2">
            <asp:TextBox ID="txtSourceStr" runat="server" class="form-control-sm" Width="150px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD FirstCol"></td>
        <td class="ValueTD" style="text-align:right" colspan="1">
            <asp:Label ID="lblFunctionSignature1" runat="server" CssClass="col-form-label text-right">目标字符串：</asp:Label>
        </td>
        <td class="ValueTD" colspan="2">
            <asp:TextBox ID="txtTargetStr" runat="server" class="form-control-sm" Width="148px"></asp:TextBox>
        </td>

        <td class="ValueTD">&nbsp;</td>

        <td class="ValueTD">&nbsp;</td>

    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFunctionSignature" runat="server" CssClass="col-form-label text-right">附加前缀</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtAdditionalPrefix" runat="server" class="form-control-sm" Width="510px"></asp:TextBox>
        </td>

        <td class="ValueTD">&nbsp;</td>

        <td class="ValueTD">&nbsp;</td>

    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">功能</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:DropDownList ID="ddlFeatureId" Width="510px" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>

        <td class="ValueTD">&nbsp;</td>

        <td class="ValueTD">&nbsp;</td>

    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLangTypeId" runat="server" CssClass="col-form-label text-right">语言类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblCodeTypeId" runat="server" CssClass="col-form-label text-right" Width="70px">分层类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCodeTypeId" runat="server" class="form-control-sm">
            </asp:DropDownList>
        </td>

        <td>&nbsp;</td>

        <td>&nbsp;</td>

    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">数据源类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSqlDsTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblReturnTypeID" runat="server" CssClass="col-form-label text-right" >返回类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlReturnTypeID" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblFuncTypeID" runat="server" CssClass="col-form-label text-right" Width="70px">函数类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlFuncTypeID" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

</table>

